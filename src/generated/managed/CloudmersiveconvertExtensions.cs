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
        public IBodyWorkflowAction<AutodetectGetInfoResult> ConvertDocumentAutodetectGetInfo(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/autodetect/get-info";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AutodetectGetInfoResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentAutodetectToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/autodetect/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<AutodetectToPngResult> ConvertDocumentAutodetectToPngArray(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/autodetect/to/png";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AutodetectToPngResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<TextConversionResult> ConvertDocumentAutodetectToTxt(Expression<Func<object>> inputFile, Expression<Func<string>> textFormattingMode = null)
        {
            var apiCallPath = "/convert/autodetect/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (textFormattingMode != null)
                callPayload.Headers["textFormattingMode"] = ExpressionConverter.Convert(textFormattingMode);
            return new ApiConnectionAction<TextConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> CompareDocumentDocx(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2)
        {
            var apiCallPath = "/convert/compare/docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken[]> ConvertDataCsvToJson(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/csv/to/json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentCsvToXlsx(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/csv/to/xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentDocToDocx(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/doc/to/docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentDocToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/doc/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<TextConversionResult> ConvertDocumentDocToTxt(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/doc/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TextConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentDocxToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/docx/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<TextConversionResult> ConvertDocumentDocxToTxt(Expression<Func<object>> inputFile, Expression<Func<string>> textFormattingMode = null)
        {
            var apiCallPath = "/convert/docx/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (textFormattingMode != null)
                callPayload.Headers["textFormattingMode"] = ExpressionConverter.Convert(textFormattingMode);
            return new ApiConnectionAction<TextConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentBeginEditing(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/edit/begin-editing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankDocxResponse> EditDocumentDocxCreateBlankDocument(Expression<Func<string>> inputInitialText = null)
        {
            var apiCallPath = "/convert/edit/docx/create/blank";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputInitialText != null)
            {
                input["InitialText"] = ExpressionConverter.ConvertO(inputInitialText);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<CreateBlankDocxResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentDocxDeletePages(Expression<Func<int>> reqConfigEndDeletePageNumber = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<int>> reqConfigStartDeletePageNumber = null)
        {
            var apiCallPath = "/convert/edit/docx/delete-pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigEndDeletePageNumber != null)
            {
                reqConfig["EndDeletePageNumber"] = ExpressionConverter.ConvertO(reqConfigEndDeletePageNumber);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigStartDeletePageNumber != null)
            {
                reqConfig["StartDeletePageNumber"] = ExpressionConverter.ConvertO(reqConfigStartDeletePageNumber);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowResponse> EditDocumentDocxDeleteTableRow(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigTablePath = null, Expression<Func<int>> reqConfigTableRowRowIndex = null)
        {
            var apiCallPath = "/convert/edit/docx/delete-table-row";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigTablePath != null)
            {
                reqConfig["TablePath"] = ExpressionConverter.ConvertO(reqConfigTablePath);
                reqConfigpropCount++;
            }

            if (reqConfigTableRowRowIndex != null)
            {
                reqConfig["TableRowRowIndex"] = ExpressionConverter.ConvertO(reqConfigTableRowRowIndex);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<DeleteDocxTableRowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowRangeResponse> EditDocumentDocxDeleteTableRowRange(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigTablePath = null, Expression<Func<int>> reqConfigTableRowRowIndexEnd = null, Expression<Func<int>> reqConfigTableRowRowIndexStart = null)
        {
            var apiCallPath = "/convert/edit/docx/delete-table-row/range";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigTablePath != null)
            {
                reqConfig["TablePath"] = ExpressionConverter.ConvertO(reqConfigTablePath);
                reqConfigpropCount++;
            }

            if (reqConfigTableRowRowIndexEnd != null)
            {
                reqConfig["TableRowRowIndexEnd"] = ExpressionConverter.ConvertO(reqConfigTableRowRowIndexEnd);
                reqConfigpropCount++;
            }

            if (reqConfigTableRowRowIndexStart != null)
            {
                reqConfig["TableRowRowIndexStart"] = ExpressionConverter.ConvertO(reqConfigTableRowRowIndexStart);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<DeleteDocxTableRowRangeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxBodyResponse> EditDocumentDocxBody(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-body";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxBodyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxCommentsHierarchicalResponse> EditDocumentDocxGetCommentsHierarchical(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-comments/hierarchical";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxCommentsHierarchicalResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxHeadersAndFootersResponse> EditDocumentDocxGetHeadersAndFooters(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-headers-and-footers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxHeadersAndFootersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxImagesResponse> EditDocumentDocxGetImages(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-images";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxImagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxPagesResponse> EditDocumentDocxPages(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-pages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxPagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxSectionsResponse> EditDocumentDocxGetSections(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-sections";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxSectionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxStylesResponse> EditDocumentDocxGetStyles(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-styles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxStylesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableRowResponse> EditDocumentDocxGetTableRow(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigTablePath = null, Expression<Func<int>> reqConfigTableRowRowIndex = null)
        {
            var apiCallPath = "/convert/edit/docx/get-table-row";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigTablePath != null)
            {
                reqConfig["TablePath"] = ExpressionConverter.ConvertO(reqConfigTablePath);
                reqConfigpropCount++;
            }

            if (reqConfigTableRowRowIndex != null)
            {
                reqConfig["TableRowRowIndex"] = ExpressionConverter.ConvertO(reqConfigTableRowRowIndex);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxTableRowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableByIndexResponse> EditDocumentDocxGetTableByIndex(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<int>> reqConfigTableIndex = null)
        {
            var apiCallPath = "/convert/edit/docx/get-table/by-index";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigTableIndex != null)
            {
                reqConfig["TableIndex"] = ExpressionConverter.ConvertO(reqConfigTableIndex);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxTableByIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTablesResponse> EditDocumentDocxGetTables(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/get-tables";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<GetDocxTablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxCommentOnParagraphResponse> EditDocumentDocxInsertCommentOnParagraph(Expression<Func<string>> reqConfigCommentToInsertAuthor = null, Expression<Func<string>> reqConfigCommentToInsertAuthorInitials = null, Expression<Func<string>> reqConfigCommentToInsertCommentDate = null, Expression<Func<string>> reqConfigCommentToInsertCommentText = null, Expression<Func<bool>> reqConfigCommentToInsertDone = null, Expression<Func<bool>> reqConfigCommentToInsertIsReply = null, Expression<Func<bool>> reqConfigCommentToInsertIsTopLevel = null, Expression<Func<string>> reqConfigCommentToInsertParentCommentPath = null, Expression<Func<string>> reqConfigCommentToInsertPath = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigParagraphPath = null)
        {
            var apiCallPath = "/convert/edit/docx/insert-comment/on/paragraph";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            var CommentToInsertObject = new JObject();
            var CommentToInsertObjectpropCount = 0;
            if (reqConfigCommentToInsertAuthor != null)
            {
                CommentToInsertObject["Author"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertAuthor);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertAuthorInitials != null)
            {
                CommentToInsertObject["AuthorInitials"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertAuthorInitials);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertCommentDate != null)
            {
                CommentToInsertObject["CommentDate"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertCommentDate);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertCommentText != null)
            {
                CommentToInsertObject["CommentText"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertCommentText);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertDone != null)
            {
                CommentToInsertObject["Done"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertDone);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertIsReply != null)
            {
                CommentToInsertObject["IsReply"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertIsReply);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertIsTopLevel != null)
            {
                CommentToInsertObject["IsTopLevel"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertIsTopLevel);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertParentCommentPath != null)
            {
                CommentToInsertObject["ParentCommentPath"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertParentCommentPath);
                CommentToInsertObjectpropCount++;
            }

            if (reqConfigCommentToInsertPath != null)
            {
                CommentToInsertObject["Path"] = ExpressionConverter.ConvertO(reqConfigCommentToInsertPath);
                CommentToInsertObjectpropCount++;
            }

            if (CommentToInsertObjectpropCount > 0)
            {
                reqConfig["CommentToInsert"] = CommentToInsertObject;
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigParagraphPath != null)
            {
                reqConfig["ParagraphPath"] = ExpressionConverter.ConvertO(reqConfigParagraphPath);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<InsertDocxCommentOnParagraphResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxInsertImageResponse> EditDocumentDocxInsertImage(Expression<Func<int>> reqConfigHeightInEMUs = null, Expression<Func<string>> reqConfigImageToAddImageContentsURL = null, Expression<Func<string>> reqConfigImageToAddImageDataContentType = null, Expression<Func<string>> reqConfigImageToAddImageDataEmbedId = null, Expression<Func<string>> reqConfigImageToAddImageDescription = null, Expression<Func<int>> reqConfigImageToAddImageHeight = null, Expression<Func<int>> reqConfigImageToAddImageId = null, Expression<Func<string>> reqConfigImageToAddImageInternalFileName = null, Expression<Func<string>> reqConfigImageToAddImageName = null, Expression<Func<int>> reqConfigImageToAddImageWidth = null, Expression<Func<bool>> reqConfigImageToAddInlineWithText = null, Expression<Func<string>> reqConfigImageToAddPath = null, Expression<Func<int>> reqConfigImageToAddXOffset = null, Expression<Func<int>> reqConfigImageToAddYOffset = null, Expression<Func<string>> reqConfigInputDocumentFileBytes = null, Expression<Func<string>> reqConfigInputDocumentFileUrl = null, Expression<Func<string>> reqConfigInputImageFileBytes = null, Expression<Func<string>> reqConfigInputImageFileUrl = null, Expression<Func<string>> reqConfigInsertPath = null, Expression<Func<string>> reqConfigInsertPlacement = null, Expression<Func<int>> reqConfigWidthInEMUs = null)
        {
            var apiCallPath = "/convert/edit/docx/insert-image";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigHeightInEMUs != null)
            {
                reqConfig["HeightInEMUs"] = ExpressionConverter.ConvertO(reqConfigHeightInEMUs);
                reqConfigpropCount++;
            }

            var ImageToAddObject = new JObject();
            var ImageToAddObjectpropCount = 0;
            if (reqConfigImageToAddImageContentsURL != null)
            {
                ImageToAddObject["ImageContentsURL"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageContentsURL);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageDataContentType != null)
            {
                ImageToAddObject["ImageDataContentType"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageDataContentType);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageDataEmbedId != null)
            {
                ImageToAddObject["ImageDataEmbedId"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageDataEmbedId);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageDescription != null)
            {
                ImageToAddObject["ImageDescription"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageDescription);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageHeight != null)
            {
                ImageToAddObject["ImageHeight"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageHeight);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageId != null)
            {
                ImageToAddObject["ImageId"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageId);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageInternalFileName != null)
            {
                ImageToAddObject["ImageInternalFileName"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageInternalFileName);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageName != null)
            {
                ImageToAddObject["ImageName"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageName);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddImageWidth != null)
            {
                ImageToAddObject["ImageWidth"] = ExpressionConverter.ConvertO(reqConfigImageToAddImageWidth);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddInlineWithText != null)
            {
                ImageToAddObject["InlineWithText"] = ExpressionConverter.ConvertO(reqConfigImageToAddInlineWithText);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddPath != null)
            {
                ImageToAddObject["Path"] = ExpressionConverter.ConvertO(reqConfigImageToAddPath);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddXOffset != null)
            {
                ImageToAddObject["XOffset"] = ExpressionConverter.ConvertO(reqConfigImageToAddXOffset);
                ImageToAddObjectpropCount++;
            }

            if (reqConfigImageToAddYOffset != null)
            {
                ImageToAddObject["YOffset"] = ExpressionConverter.ConvertO(reqConfigImageToAddYOffset);
                ImageToAddObjectpropCount++;
            }

            if (ImageToAddObjectpropCount > 0)
            {
                reqConfig["ImageToAdd"] = ImageToAddObject;
                reqConfigpropCount++;
            }

            if (reqConfigInputDocumentFileBytes != null)
            {
                reqConfig["InputDocumentFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputDocumentFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputDocumentFileUrl != null)
            {
                reqConfig["InputDocumentFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputDocumentFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigInputImageFileBytes != null)
            {
                reqConfig["InputImageFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputImageFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputImageFileUrl != null)
            {
                reqConfig["InputImageFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputImageFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigInsertPath != null)
            {
                reqConfig["InsertPath"] = ExpressionConverter.ConvertO(reqConfigInsertPath);
                reqConfigpropCount++;
            }

            if (reqConfigInsertPlacement != null)
            {
                reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(reqConfigInsertPlacement);
                reqConfigpropCount++;
            }

            if (reqConfigWidthInEMUs != null)
            {
                reqConfig["WidthInEMUs"] = ExpressionConverter.ConvertO(reqConfigWidthInEMUs);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<DocxInsertImageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxInsertParagraphResponse> EditDocumentDocxInsertParagraph(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigInsertPath = null, Expression<Func<string>> reqConfigInsertPlacement = null, Expression<Func<DocxRun[]>> reqConfigParagraphToInsertContentRuns = null, Expression<Func<int>> reqConfigParagraphToInsertParagraphIndex = null, Expression<Func<string>> reqConfigParagraphToInsertPath = null, Expression<Func<string>> reqConfigParagraphToInsertStyleID = null)
        {
            var apiCallPath = "/convert/edit/docx/insert-paragraph";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigInsertPath != null)
            {
                reqConfig["InsertPath"] = ExpressionConverter.ConvertO(reqConfigInsertPath);
                reqConfigpropCount++;
            }

            if (reqConfigInsertPlacement != null)
            {
                reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(reqConfigInsertPlacement);
                reqConfigpropCount++;
            }

            var ParagraphToInsertObject = new JObject();
            var ParagraphToInsertObjectpropCount = 0;
            if (reqConfigParagraphToInsertContentRuns != null)
            {
                ParagraphToInsertObject["ContentRuns"] = ExpressionConverter.ConvertO(reqConfigParagraphToInsertContentRuns);
                ParagraphToInsertObjectpropCount++;
            }

            if (reqConfigParagraphToInsertParagraphIndex != null)
            {
                ParagraphToInsertObject["ParagraphIndex"] = ExpressionConverter.ConvertO(reqConfigParagraphToInsertParagraphIndex);
                ParagraphToInsertObjectpropCount++;
            }

            if (reqConfigParagraphToInsertPath != null)
            {
                ParagraphToInsertObject["Path"] = ExpressionConverter.ConvertO(reqConfigParagraphToInsertPath);
                ParagraphToInsertObjectpropCount++;
            }

            if (reqConfigParagraphToInsertStyleID != null)
            {
                ParagraphToInsertObject["StyleID"] = ExpressionConverter.ConvertO(reqConfigParagraphToInsertStyleID);
                ParagraphToInsertObjectpropCount++;
            }

            if (ParagraphToInsertObjectpropCount > 0)
            {
                reqConfig["ParagraphToInsert"] = ParagraphToInsertObject;
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<InsertDocxInsertParagraphResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTablesResponse> EditDocumentDocxInsertTable(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigInsertPath = null, Expression<Func<string>> reqConfigInsertPlacement = null, Expression<Func<string>> reqConfigTableToInsertBottomBorderColor = null, Expression<Func<int>> reqConfigTableToInsertBottomBorderSize = null, Expression<Func<int>> reqConfigTableToInsertBottomBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertBottomBorderType = null, Expression<Func<string>> reqConfigTableToInsertCellHorizontalBorderColor = null, Expression<Func<int>> reqConfigTableToInsertCellHorizontalBorderSize = null, Expression<Func<int>> reqConfigTableToInsertCellHorizontalBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertCellHorizontalBorderType = null, Expression<Func<string>> reqConfigTableToInsertCellVerticalBorderColor = null, Expression<Func<int>> reqConfigTableToInsertCellVerticalBorderSize = null, Expression<Func<int>> reqConfigTableToInsertCellVerticalBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertCellVerticalBorderType = null, Expression<Func<string>> reqConfigTableToInsertEndBorderColor = null, Expression<Func<int>> reqConfigTableToInsertEndBorderSize = null, Expression<Func<int>> reqConfigTableToInsertEndBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertEndBorderType = null, Expression<Func<string>> reqConfigTableToInsertLeftBorderColor = null, Expression<Func<int>> reqConfigTableToInsertLeftBorderSize = null, Expression<Func<int>> reqConfigTableToInsertLeftBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertLeftBorderType = null, Expression<Func<string>> reqConfigTableToInsertPath = null, Expression<Func<string>> reqConfigTableToInsertRightBorderColor = null, Expression<Func<int>> reqConfigTableToInsertRightBorderSize = null, Expression<Func<int>> reqConfigTableToInsertRightBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertRightBorderType = null, Expression<Func<string>> reqConfigTableToInsertStartBorderColor = null, Expression<Func<int>> reqConfigTableToInsertStartBorderSize = null, Expression<Func<int>> reqConfigTableToInsertStartBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertStartBorderType = null, Expression<Func<string>> reqConfigTableToInsertTableID = null, Expression<Func<string>> reqConfigTableToInsertTableIndentationMode = null, Expression<Func<int>> reqConfigTableToInsertTableIndentationWidth = null, Expression<Func<DocxTableRow[]>> reqConfigTableToInsertTableRows = null, Expression<Func<string>> reqConfigTableToInsertTopBorderColor = null, Expression<Func<int>> reqConfigTableToInsertTopBorderSize = null, Expression<Func<int>> reqConfigTableToInsertTopBorderSpace = null, Expression<Func<string>> reqConfigTableToInsertTopBorderType = null, Expression<Func<string>> reqConfigTableToInsertWidth = null, Expression<Func<string>> reqConfigTableToInsertWidthType = null)
        {
            var apiCallPath = "/convert/edit/docx/insert-table";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigInsertPath != null)
            {
                reqConfig["InsertPath"] = ExpressionConverter.ConvertO(reqConfigInsertPath);
                reqConfigpropCount++;
            }

            if (reqConfigInsertPlacement != null)
            {
                reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(reqConfigInsertPlacement);
                reqConfigpropCount++;
            }

            var TableToInsertObject = new JObject();
            var TableToInsertObjectpropCount = 0;
            if (reqConfigTableToInsertBottomBorderColor != null)
            {
                TableToInsertObject["BottomBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertBottomBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertBottomBorderSize != null)
            {
                TableToInsertObject["BottomBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertBottomBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertBottomBorderSpace != null)
            {
                TableToInsertObject["BottomBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertBottomBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertBottomBorderType != null)
            {
                TableToInsertObject["BottomBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertBottomBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellHorizontalBorderColor != null)
            {
                TableToInsertObject["CellHorizontalBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellHorizontalBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellHorizontalBorderSize != null)
            {
                TableToInsertObject["CellHorizontalBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellHorizontalBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellHorizontalBorderSpace != null)
            {
                TableToInsertObject["CellHorizontalBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellHorizontalBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellHorizontalBorderType != null)
            {
                TableToInsertObject["CellHorizontalBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellHorizontalBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellVerticalBorderColor != null)
            {
                TableToInsertObject["CellVerticalBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellVerticalBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellVerticalBorderSize != null)
            {
                TableToInsertObject["CellVerticalBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellVerticalBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellVerticalBorderSpace != null)
            {
                TableToInsertObject["CellVerticalBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellVerticalBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertCellVerticalBorderType != null)
            {
                TableToInsertObject["CellVerticalBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertCellVerticalBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertEndBorderColor != null)
            {
                TableToInsertObject["EndBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertEndBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertEndBorderSize != null)
            {
                TableToInsertObject["EndBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertEndBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertEndBorderSpace != null)
            {
                TableToInsertObject["EndBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertEndBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertEndBorderType != null)
            {
                TableToInsertObject["EndBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertEndBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertLeftBorderColor != null)
            {
                TableToInsertObject["LeftBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertLeftBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertLeftBorderSize != null)
            {
                TableToInsertObject["LeftBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertLeftBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertLeftBorderSpace != null)
            {
                TableToInsertObject["LeftBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertLeftBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertLeftBorderType != null)
            {
                TableToInsertObject["LeftBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertLeftBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertPath != null)
            {
                TableToInsertObject["Path"] = ExpressionConverter.ConvertO(reqConfigTableToInsertPath);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertRightBorderColor != null)
            {
                TableToInsertObject["RightBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertRightBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertRightBorderSize != null)
            {
                TableToInsertObject["RightBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertRightBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertRightBorderSpace != null)
            {
                TableToInsertObject["RightBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertRightBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertRightBorderType != null)
            {
                TableToInsertObject["RightBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertRightBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertStartBorderColor != null)
            {
                TableToInsertObject["StartBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertStartBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertStartBorderSize != null)
            {
                TableToInsertObject["StartBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertStartBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertStartBorderSpace != null)
            {
                TableToInsertObject["StartBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertStartBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertStartBorderType != null)
            {
                TableToInsertObject["StartBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertStartBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTableID != null)
            {
                TableToInsertObject["TableID"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTableID);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTableIndentationMode != null)
            {
                TableToInsertObject["TableIndentationMode"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTableIndentationMode);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTableIndentationWidth != null)
            {
                TableToInsertObject["TableIndentationWidth"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTableIndentationWidth);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTableRows != null)
            {
                TableToInsertObject["TableRows"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTableRows);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTopBorderColor != null)
            {
                TableToInsertObject["TopBorderColor"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTopBorderColor);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTopBorderSize != null)
            {
                TableToInsertObject["TopBorderSize"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTopBorderSize);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTopBorderSpace != null)
            {
                TableToInsertObject["TopBorderSpace"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTopBorderSpace);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertTopBorderType != null)
            {
                TableToInsertObject["TopBorderType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertTopBorderType);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertWidth != null)
            {
                TableToInsertObject["Width"] = ExpressionConverter.ConvertO(reqConfigTableToInsertWidth);
                TableToInsertObjectpropCount++;
            }

            if (reqConfigTableToInsertWidthType != null)
            {
                TableToInsertObject["WidthType"] = ExpressionConverter.ConvertO(reqConfigTableToInsertWidthType);
                TableToInsertObjectpropCount++;
            }

            if (TableToInsertObjectpropCount > 0)
            {
                reqConfig["TableToInsert"] = TableToInsertObject;
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<InsertDocxTablesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTableRowResponse> EditDocumentDocxInsertTableRow(Expression<Func<string>> reqConfigExistingTablePath = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigInsertPlacement = null, Expression<Func<string>> reqConfigRowToInsertPath = null, Expression<Func<DocxTableCell[]>> reqConfigRowToInsertRowCells = null, Expression<Func<int>> reqConfigRowToInsertRowIndex = null)
        {
            var apiCallPath = "/convert/edit/docx/insert-table-row";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigExistingTablePath != null)
            {
                reqConfig["ExistingTablePath"] = ExpressionConverter.ConvertO(reqConfigExistingTablePath);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigInsertPlacement != null)
            {
                reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(reqConfigInsertPlacement);
                reqConfigpropCount++;
            }

            var RowToInsertObject = new JObject();
            var RowToInsertObjectpropCount = 0;
            if (reqConfigRowToInsertPath != null)
            {
                RowToInsertObject["Path"] = ExpressionConverter.ConvertO(reqConfigRowToInsertPath);
                RowToInsertObjectpropCount++;
            }

            if (reqConfigRowToInsertRowCells != null)
            {
                RowToInsertObject["RowCells"] = ExpressionConverter.ConvertO(reqConfigRowToInsertRowCells);
                RowToInsertObjectpropCount++;
            }

            if (reqConfigRowToInsertRowIndex != null)
            {
                RowToInsertObject["RowIndex"] = ExpressionConverter.ConvertO(reqConfigRowToInsertRowIndex);
                RowToInsertObjectpropCount++;
            }

            if (RowToInsertObjectpropCount > 0)
            {
                reqConfig["RowToInsert"] = RowToInsertObject;
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<InsertDocxTableRowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<RemoveDocxHeadersAndFootersResponse> EditDocumentDocxRemoveHeadersAndFooters(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<bool>> reqConfigRemoveFooters = null, Expression<Func<bool>> reqConfigRemoveHeaders = null)
        {
            var apiCallPath = "/convert/edit/docx/remove-headers-and-footers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigRemoveFooters != null)
            {
                reqConfig["RemoveFooters"] = ExpressionConverter.ConvertO(reqConfigRemoveFooters);
                reqConfigpropCount++;
            }

            if (reqConfigRemoveHeaders != null)
            {
                reqConfig["RemoveHeaders"] = ExpressionConverter.ConvertO(reqConfigRemoveHeaders);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<RemoveDocxHeadersAndFootersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxRemoveObjectResponse> EditDocumentDocxRemoveObject(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigPathToObjectToRemove = null)
        {
            var apiCallPath = "/convert/edit/docx/remove-object";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigPathToObjectToRemove != null)
            {
                reqConfig["PathToObjectToRemove"] = ExpressionConverter.ConvertO(reqConfigPathToObjectToRemove);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<DocxRemoveObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentDocxReplace(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<bool>> reqConfigMatchCase = null, Expression<Func<string>> reqConfigMatchString = null, Expression<Func<string>> reqConfigReplaceString = null)
        {
            var apiCallPath = "/convert/edit/docx/replace-all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigMatchCase != null)
            {
                reqConfig["MatchCase"] = ExpressionConverter.ConvertO(reqConfigMatchCase);
                reqConfigpropCount++;
            }

            if (reqConfigMatchString != null)
            {
                reqConfig["MatchString"] = ExpressionConverter.ConvertO(reqConfigMatchString);
                reqConfigpropCount++;
            }

            if (reqConfigReplaceString != null)
            {
                reqConfig["ReplaceString"] = ExpressionConverter.ConvertO(reqConfigReplaceString);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse> EditDocumentDocxSetFooter(Expression<Func<DocxParagraph[]>> reqConfigFooterToApplyParagraphs = null, Expression<Func<string>> reqConfigFooterToApplyPath = null, Expression<Func<DocxSection[]>> reqConfigFooterToApplySectionsWithFooter = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/set-footer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            var FooterToApplyObject = new JObject();
            var FooterToApplyObjectpropCount = 0;
            if (reqConfigFooterToApplyParagraphs != null)
            {
                FooterToApplyObject["Paragraphs"] = ExpressionConverter.ConvertO(reqConfigFooterToApplyParagraphs);
                FooterToApplyObjectpropCount++;
            }

            if (reqConfigFooterToApplyPath != null)
            {
                FooterToApplyObject["Path"] = ExpressionConverter.ConvertO(reqConfigFooterToApplyPath);
                FooterToApplyObjectpropCount++;
            }

            if (reqConfigFooterToApplySectionsWithFooter != null)
            {
                FooterToApplyObject["SectionsWithFooter"] = ExpressionConverter.ConvertO(reqConfigFooterToApplySectionsWithFooter);
                FooterToApplyObjectpropCount++;
            }

            if (FooterToApplyObjectpropCount > 0)
            {
                reqConfig["FooterToApply"] = FooterToApplyObject;
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<DocxSetFooterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse> EditDocumentDocxSetFooterAddPageNumber(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigPrependText = null)
        {
            var apiCallPath = "/convert/edit/docx/set-footer/add-page-number";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigPrependText != null)
            {
                reqConfig["PrependText"] = ExpressionConverter.ConvertO(reqConfigPrependText);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<DocxSetFooterResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetHeaderResponse> EditDocumentDocxSetHeader(Expression<Func<DocxParagraph[]>> reqConfigHeaderToApplyParagraphs = null, Expression<Func<string>> reqConfigHeaderToApplyPath = null, Expression<Func<DocxSection[]>> reqConfigHeaderToApplySectionsWithHeader = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/docx/set-header";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            var HeaderToApplyObject = new JObject();
            var HeaderToApplyObjectpropCount = 0;
            if (reqConfigHeaderToApplyParagraphs != null)
            {
                HeaderToApplyObject["Paragraphs"] = ExpressionConverter.ConvertO(reqConfigHeaderToApplyParagraphs);
                HeaderToApplyObjectpropCount++;
            }

            if (reqConfigHeaderToApplyPath != null)
            {
                HeaderToApplyObject["Path"] = ExpressionConverter.ConvertO(reqConfigHeaderToApplyPath);
                HeaderToApplyObjectpropCount++;
            }

            if (reqConfigHeaderToApplySectionsWithHeader != null)
            {
                HeaderToApplyObject["SectionsWithHeader"] = ExpressionConverter.ConvertO(reqConfigHeaderToApplySectionsWithHeader);
                HeaderToApplyObjectpropCount++;
            }

            if (HeaderToApplyObjectpropCount > 0)
            {
                reqConfig["HeaderToApply"] = HeaderToApplyObject;
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<DocxSetHeaderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableCellResponse> EditDocumentDocxUpdateTableCell(Expression<Func<int>> reqConfigCellToUpdateCellIndex = null, Expression<Func<string>> reqConfigCellToUpdateCellShadingColor = null, Expression<Func<string>> reqConfigCellToUpdateCellShadingFill = null, Expression<Func<string>> reqConfigCellToUpdateCellShadingPattern = null, Expression<Func<string>> reqConfigCellToUpdateCellWidth = null, Expression<Func<string>> reqConfigCellToUpdateCellWidthMode = null, Expression<Func<DocxParagraph[]>> reqConfigCellToUpdateParagraphs = null, Expression<Func<string>> reqConfigCellToUpdatePath = null, Expression<Func<string>> reqConfigExistingTablePath = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<int>> reqConfigTableCellIndex = null, Expression<Func<int>> reqConfigTableRowIndex = null)
        {
            var apiCallPath = "/convert/edit/docx/update-table-cell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            var CellToUpdateObject = new JObject();
            var CellToUpdateObjectpropCount = 0;
            if (reqConfigCellToUpdateCellIndex != null)
            {
                CellToUpdateObject["CellIndex"] = ExpressionConverter.ConvertO(reqConfigCellToUpdateCellIndex);
                CellToUpdateObjectpropCount++;
            }

            if (reqConfigCellToUpdateCellShadingColor != null)
            {
                CellToUpdateObject["CellShadingColor"] = ExpressionConverter.ConvertO(reqConfigCellToUpdateCellShadingColor);
                CellToUpdateObjectpropCount++;
            }

            if (reqConfigCellToUpdateCellShadingFill != null)
            {
                CellToUpdateObject["CellShadingFill"] = ExpressionConverter.ConvertO(reqConfigCellToUpdateCellShadingFill);
                CellToUpdateObjectpropCount++;
            }

            if (reqConfigCellToUpdateCellShadingPattern != null)
            {
                CellToUpdateObject["CellShadingPattern"] = ExpressionConverter.ConvertO(reqConfigCellToUpdateCellShadingPattern);
                CellToUpdateObjectpropCount++;
            }

            if (reqConfigCellToUpdateCellWidth != null)
            {
                CellToUpdateObject["CellWidth"] = ExpressionConverter.ConvertO(reqConfigCellToUpdateCellWidth);
                CellToUpdateObjectpropCount++;
            }

            if (reqConfigCellToUpdateCellWidthMode != null)
            {
                CellToUpdateObject["CellWidthMode"] = ExpressionConverter.ConvertO(reqConfigCellToUpdateCellWidthMode);
                CellToUpdateObjectpropCount++;
            }

            if (reqConfigCellToUpdateParagraphs != null)
            {
                CellToUpdateObject["Paragraphs"] = ExpressionConverter.ConvertO(reqConfigCellToUpdateParagraphs);
                CellToUpdateObjectpropCount++;
            }

            if (reqConfigCellToUpdatePath != null)
            {
                CellToUpdateObject["Path"] = ExpressionConverter.ConvertO(reqConfigCellToUpdatePath);
                CellToUpdateObjectpropCount++;
            }

            if (CellToUpdateObjectpropCount > 0)
            {
                reqConfig["CellToUpdate"] = CellToUpdateObject;
                reqConfigpropCount++;
            }

            if (reqConfigExistingTablePath != null)
            {
                reqConfig["ExistingTablePath"] = ExpressionConverter.ConvertO(reqConfigExistingTablePath);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigTableCellIndex != null)
            {
                reqConfig["TableCellIndex"] = ExpressionConverter.ConvertO(reqConfigTableCellIndex);
                reqConfigpropCount++;
            }

            if (reqConfigTableRowIndex != null)
            {
                reqConfig["TableRowIndex"] = ExpressionConverter.ConvertO(reqConfigTableRowIndex);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<UpdateDocxTableCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableRowResponse> EditDocumentDocxUpdateTableRow(Expression<Func<string>> reqConfigExistingTablePath = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigRowToUpdatePath = null, Expression<Func<DocxTableCell[]>> reqConfigRowToUpdateRowCells = null, Expression<Func<int>> reqConfigRowToUpdateRowIndex = null, Expression<Func<int>> reqConfigTableRowIndex = null)
        {
            var apiCallPath = "/convert/edit/docx/update-table-row";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigExistingTablePath != null)
            {
                reqConfig["ExistingTablePath"] = ExpressionConverter.ConvertO(reqConfigExistingTablePath);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            var RowToUpdateObject = new JObject();
            var RowToUpdateObjectpropCount = 0;
            if (reqConfigRowToUpdatePath != null)
            {
                RowToUpdateObject["Path"] = ExpressionConverter.ConvertO(reqConfigRowToUpdatePath);
                RowToUpdateObjectpropCount++;
            }

            if (reqConfigRowToUpdateRowCells != null)
            {
                RowToUpdateObject["RowCells"] = ExpressionConverter.ConvertO(reqConfigRowToUpdateRowCells);
                RowToUpdateObjectpropCount++;
            }

            if (reqConfigRowToUpdateRowIndex != null)
            {
                RowToUpdateObject["RowIndex"] = ExpressionConverter.ConvertO(reqConfigRowToUpdateRowIndex);
                RowToUpdateObjectpropCount++;
            }

            if (RowToUpdateObjectpropCount > 0)
            {
                reqConfig["RowToUpdate"] = RowToUpdateObject;
                reqConfigpropCount++;
            }

            if (reqConfigTableRowIndex != null)
            {
                reqConfig["TableRowIndex"] = ExpressionConverter.ConvertO(reqConfigTableRowIndex);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<UpdateDocxTableRowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentFinishEditing(Expression<Func<string>> reqConfigInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/finish-editing";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentPptxDeleteSlides(Expression<Func<int>> reqConfigEndDeleteSlideNumber = null, Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<int>> reqConfigStartDeleteSlideNumber = null)
        {
            var apiCallPath = "/convert/edit/pptx/delete-slides";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigEndDeleteSlideNumber != null)
            {
                reqConfig["EndDeleteSlideNumber"] = ExpressionConverter.ConvertO(reqConfigEndDeleteSlideNumber);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigStartDeleteSlideNumber != null)
            {
                reqConfig["StartDeleteSlideNumber"] = ExpressionConverter.ConvertO(reqConfigStartDeleteSlideNumber);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> EditDocumentPptxReplace(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<bool>> reqConfigMatchCase = null, Expression<Func<string>> reqConfigMatchString = null, Expression<Func<string>> reqConfigReplaceString = null)
        {
            var apiCallPath = "/convert/edit/pptx/replace-all";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            if (reqConfigMatchCase != null)
            {
                reqConfig["MatchCase"] = ExpressionConverter.ConvertO(reqConfigMatchCase);
                reqConfigpropCount++;
            }

            if (reqConfigMatchString != null)
            {
                reqConfig["MatchString"] = ExpressionConverter.ConvertO(reqConfigMatchString);
                reqConfigpropCount++;
            }

            if (reqConfigReplaceString != null)
            {
                reqConfig["ReplaceString"] = ExpressionConverter.ConvertO(reqConfigReplaceString);
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<ClearXlsxCellResponse> EditDocumentXlsxClearCellByIndex(Expression<Func<int>> inputCellIndex = null, Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<int>> inputRowIndex = null, Expression<Func<string>> inputWorksheetToUpdatePath = null, Expression<Func<string>> inputWorksheetToUpdateWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/clear-cell/by-index";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputCellIndex != null)
            {
                input["CellIndex"] = ExpressionConverter.ConvertO(inputCellIndex);
                inputpropCount++;
            }

            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            if (inputRowIndex != null)
            {
                input["RowIndex"] = ExpressionConverter.ConvertO(inputRowIndex);
                inputpropCount++;
            }

            var WorksheetToUpdateObject = new JObject();
            var WorksheetToUpdateObjectpropCount = 0;
            if (inputWorksheetToUpdatePath != null)
            {
                WorksheetToUpdateObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToUpdatePath);
                WorksheetToUpdateObjectpropCount++;
            }

            if (inputWorksheetToUpdateWorksheetName != null)
            {
                WorksheetToUpdateObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToUpdateWorksheetName);
                WorksheetToUpdateObjectpropCount++;
            }

            if (WorksheetToUpdateObjectpropCount > 0)
            {
                input["WorksheetToUpdate"] = WorksheetToUpdateObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<ClearXlsxCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankSpreadsheetResponse> EditDocumentXlsxCreateBlankSpreadsheet(Expression<Func<string>> inputWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/create/blank";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputWorksheetName != null)
            {
                input["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetName);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<CreateBlankSpreadsheetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateSpreadsheetFromDataResponse> EditDocumentXlsxCreateSpreadsheetFromData(Expression<Func<XlsxSpreadsheetRow[]>> inputRows = null, Expression<Func<string>> inputWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/create/from/data";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputRows != null)
            {
                input["Rows"] = ExpressionConverter.ConvertO(inputRows);
                inputpropCount++;
            }

            if (inputWorksheetName != null)
            {
                input["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetName);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<CreateSpreadsheetFromDataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken> EditDocumentXlsxDeleteWorksheet(Expression<Func<string>> reqConfigInputFileBytes = null, Expression<Func<string>> reqConfigInputFileUrl = null, Expression<Func<string>> reqConfigWorksheetToRemovePath = null, Expression<Func<string>> reqConfigWorksheetToRemoveWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/delete-worksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var reqConfig = new JObject();
            var reqConfigpropCount = 0;
            if (reqConfigInputFileBytes != null)
            {
                reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(reqConfigInputFileBytes);
                reqConfigpropCount++;
            }

            if (reqConfigInputFileUrl != null)
            {
                reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(reqConfigInputFileUrl);
                reqConfigpropCount++;
            }

            var WorksheetToRemoveObject = new JObject();
            var WorksheetToRemoveObjectpropCount = 0;
            if (reqConfigWorksheetToRemovePath != null)
            {
                WorksheetToRemoveObject["Path"] = ExpressionConverter.ConvertO(reqConfigWorksheetToRemovePath);
                WorksheetToRemoveObjectpropCount++;
            }

            if (reqConfigWorksheetToRemoveWorksheetName != null)
            {
                WorksheetToRemoveObject["WorksheetName"] = ExpressionConverter.ConvertO(reqConfigWorksheetToRemoveWorksheetName);
                WorksheetToRemoveObjectpropCount++;
            }

            if (WorksheetToRemoveObjectpropCount > 0)
            {
                reqConfig["WorksheetToRemove"] = WorksheetToRemoveObject;
                reqConfigpropCount++;
            }

            if (reqConfigpropCount > 0)
            {
                callPayload.Body = reqConfig;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellByIdentifierResponse> EditDocumentXlsxGetCellByIdentifier(Expression<Func<string>> inputCellIdentifier = null, Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<string>> inputWorksheetToQueryPath = null, Expression<Func<string>> inputWorksheetToQueryWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/get-cell/by-identifier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputCellIdentifier != null)
            {
                input["CellIdentifier"] = ExpressionConverter.ConvertO(inputCellIdentifier);
                inputpropCount++;
            }

            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            var WorksheetToQueryObject = new JObject();
            var WorksheetToQueryObjectpropCount = 0;
            if (inputWorksheetToQueryPath != null)
            {
                WorksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToQueryPath);
                WorksheetToQueryObjectpropCount++;
            }

            if (inputWorksheetToQueryWorksheetName != null)
            {
                WorksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToQueryWorksheetName);
                WorksheetToQueryObjectpropCount++;
            }

            if (WorksheetToQueryObjectpropCount > 0)
            {
                input["WorksheetToQuery"] = WorksheetToQueryObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetXlsxCellByIdentifierResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellResponse> EditDocumentXlsxGetCellByIndex(Expression<Func<int>> inputCellIndex = null, Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<int>> inputRowIndex = null, Expression<Func<string>> inputWorksheetToQueryPath = null, Expression<Func<string>> inputWorksheetToQueryWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/get-cell/by-index";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputCellIndex != null)
            {
                input["CellIndex"] = ExpressionConverter.ConvertO(inputCellIndex);
                inputpropCount++;
            }

            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            if (inputRowIndex != null)
            {
                input["RowIndex"] = ExpressionConverter.ConvertO(inputRowIndex);
                inputpropCount++;
            }

            var WorksheetToQueryObject = new JObject();
            var WorksheetToQueryObjectpropCount = 0;
            if (inputWorksheetToQueryPath != null)
            {
                WorksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToQueryPath);
                WorksheetToQueryObjectpropCount++;
            }

            if (inputWorksheetToQueryWorksheetName != null)
            {
                WorksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToQueryWorksheetName);
                WorksheetToQueryObjectpropCount++;
            }

            if (WorksheetToQueryObjectpropCount > 0)
            {
                input["WorksheetToQuery"] = WorksheetToQueryObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetXlsxCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxColumnsResponse> EditDocumentXlsxGetColumns(Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<string>> inputWorksheetToQueryPath = null, Expression<Func<string>> inputWorksheetToQueryWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/get-columns";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            var WorksheetToQueryObject = new JObject();
            var WorksheetToQueryObjectpropCount = 0;
            if (inputWorksheetToQueryPath != null)
            {
                WorksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToQueryPath);
                WorksheetToQueryObjectpropCount++;
            }

            if (inputWorksheetToQueryWorksheetName != null)
            {
                WorksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToQueryWorksheetName);
                WorksheetToQueryObjectpropCount++;
            }

            if (WorksheetToQueryObjectpropCount > 0)
            {
                input["WorksheetToQuery"] = WorksheetToQueryObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetXlsxColumnsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxImagesResponse> EditDocumentXlsxGetImages(Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<string>> inputWorksheetToQueryPath = null, Expression<Func<string>> inputWorksheetToQueryWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/get-images";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            var WorksheetToQueryObject = new JObject();
            var WorksheetToQueryObjectpropCount = 0;
            if (inputWorksheetToQueryPath != null)
            {
                WorksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToQueryPath);
                WorksheetToQueryObjectpropCount++;
            }

            if (inputWorksheetToQueryWorksheetName != null)
            {
                WorksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToQueryWorksheetName);
                WorksheetToQueryObjectpropCount++;
            }

            if (WorksheetToQueryObjectpropCount > 0)
            {
                input["WorksheetToQuery"] = WorksheetToQueryObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetXlsxImagesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxRowsAndCellsResponse> EditDocumentXlsxGetRowsAndCells(Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<string>> inputWorksheetToQueryPath = null, Expression<Func<string>> inputWorksheetToQueryWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/get-rows-and-cells";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            var WorksheetToQueryObject = new JObject();
            var WorksheetToQueryObjectpropCount = 0;
            if (inputWorksheetToQueryPath != null)
            {
                WorksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToQueryPath);
                WorksheetToQueryObjectpropCount++;
            }

            if (inputWorksheetToQueryWorksheetName != null)
            {
                WorksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToQueryWorksheetName);
                WorksheetToQueryObjectpropCount++;
            }

            if (WorksheetToQueryObjectpropCount > 0)
            {
                input["WorksheetToQuery"] = WorksheetToQueryObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetXlsxRowsAndCellsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxStylesResponse> EditDocumentXlsxGetStyles(Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/xlsx/get-styles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetXlsxStylesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxWorksheetsResponse> EditDocumentXlsxGetWorksheets(Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null)
        {
            var apiCallPath = "/convert/edit/xlsx/get-worksheets";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<GetXlsxWorksheetsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertXlsxWorksheetResponse> EditDocumentXlsxInsertWorksheet(Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<string>> inputWorksheetToInsertPath = null, Expression<Func<string>> inputWorksheetToInsertWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/insert-worksheet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            var WorksheetToInsertObject = new JObject();
            var WorksheetToInsertObjectpropCount = 0;
            if (inputWorksheetToInsertPath != null)
            {
                WorksheetToInsertObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToInsertPath);
                WorksheetToInsertObjectpropCount++;
            }

            if (inputWorksheetToInsertWorksheetName != null)
            {
                WorksheetToInsertObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToInsertWorksheetName);
                WorksheetToInsertObjectpropCount++;
            }

            if (WorksheetToInsertObjectpropCount > 0)
            {
                input["WorksheetToInsert"] = WorksheetToInsertObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<InsertXlsxWorksheetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellByIdentifierResponse> EditDocumentXlsxSetCellByIdentifier(Expression<Func<string>> inputCellIdentifier = null, Expression<Func<string>> inputCellValueCellIdentifier = null, Expression<Func<string>> inputCellValueFormula = null, Expression<Func<string>> inputCellValuePath = null, Expression<Func<int>> inputCellValueStyleIndex = null, Expression<Func<string>> inputCellValueTextValue = null, Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<string>> inputWorksheetToUpdatePath = null, Expression<Func<string>> inputWorksheetToUpdateWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/set-cell/by-identifier";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputCellIdentifier != null)
            {
                input["CellIdentifier"] = ExpressionConverter.ConvertO(inputCellIdentifier);
                inputpropCount++;
            }

            var CellValueObject = new JObject();
            var CellValueObjectpropCount = 0;
            if (inputCellValueCellIdentifier != null)
            {
                CellValueObject["CellIdentifier"] = ExpressionConverter.ConvertO(inputCellValueCellIdentifier);
                CellValueObjectpropCount++;
            }

            if (inputCellValueFormula != null)
            {
                CellValueObject["Formula"] = ExpressionConverter.ConvertO(inputCellValueFormula);
                CellValueObjectpropCount++;
            }

            if (inputCellValuePath != null)
            {
                CellValueObject["Path"] = ExpressionConverter.ConvertO(inputCellValuePath);
                CellValueObjectpropCount++;
            }

            if (inputCellValueStyleIndex != null)
            {
                CellValueObject["StyleIndex"] = ExpressionConverter.ConvertO(inputCellValueStyleIndex);
                CellValueObjectpropCount++;
            }

            if (inputCellValueTextValue != null)
            {
                CellValueObject["TextValue"] = ExpressionConverter.ConvertO(inputCellValueTextValue);
                CellValueObjectpropCount++;
            }

            if (CellValueObjectpropCount > 0)
            {
                input["CellValue"] = CellValueObject;
                inputpropCount++;
            }

            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            var WorksheetToUpdateObject = new JObject();
            var WorksheetToUpdateObjectpropCount = 0;
            if (inputWorksheetToUpdatePath != null)
            {
                WorksheetToUpdateObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToUpdatePath);
                WorksheetToUpdateObjectpropCount++;
            }

            if (inputWorksheetToUpdateWorksheetName != null)
            {
                WorksheetToUpdateObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToUpdateWorksheetName);
                WorksheetToUpdateObjectpropCount++;
            }

            if (WorksheetToUpdateObjectpropCount > 0)
            {
                input["WorksheetToUpdate"] = WorksheetToUpdateObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<SetXlsxCellByIdentifierResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellResponse> EditDocumentXlsxSetCellByIndex(Expression<Func<int>> inputCellIndex = null, Expression<Func<string>> inputCellValueCellIdentifier = null, Expression<Func<string>> inputCellValueFormula = null, Expression<Func<string>> inputCellValuePath = null, Expression<Func<int>> inputCellValueStyleIndex = null, Expression<Func<string>> inputCellValueTextValue = null, Expression<Func<string>> inputInputFileBytes = null, Expression<Func<string>> inputInputFileUrl = null, Expression<Func<int>> inputRowIndex = null, Expression<Func<string>> inputWorksheetToUpdatePath = null, Expression<Func<string>> inputWorksheetToUpdateWorksheetName = null)
        {
            var apiCallPath = "/convert/edit/xlsx/set-cell/by-index";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputCellIndex != null)
            {
                input["CellIndex"] = ExpressionConverter.ConvertO(inputCellIndex);
                inputpropCount++;
            }

            var CellValueObject = new JObject();
            var CellValueObjectpropCount = 0;
            if (inputCellValueCellIdentifier != null)
            {
                CellValueObject["CellIdentifier"] = ExpressionConverter.ConvertO(inputCellValueCellIdentifier);
                CellValueObjectpropCount++;
            }

            if (inputCellValueFormula != null)
            {
                CellValueObject["Formula"] = ExpressionConverter.ConvertO(inputCellValueFormula);
                CellValueObjectpropCount++;
            }

            if (inputCellValuePath != null)
            {
                CellValueObject["Path"] = ExpressionConverter.ConvertO(inputCellValuePath);
                CellValueObjectpropCount++;
            }

            if (inputCellValueStyleIndex != null)
            {
                CellValueObject["StyleIndex"] = ExpressionConverter.ConvertO(inputCellValueStyleIndex);
                CellValueObjectpropCount++;
            }

            if (inputCellValueTextValue != null)
            {
                CellValueObject["TextValue"] = ExpressionConverter.ConvertO(inputCellValueTextValue);
                CellValueObjectpropCount++;
            }

            if (CellValueObjectpropCount > 0)
            {
                input["CellValue"] = CellValueObject;
                inputpropCount++;
            }

            if (inputInputFileBytes != null)
            {
                input["InputFileBytes"] = ExpressionConverter.ConvertO(inputInputFileBytes);
                inputpropCount++;
            }

            if (inputInputFileUrl != null)
            {
                input["InputFileUrl"] = ExpressionConverter.ConvertO(inputInputFileUrl);
                inputpropCount++;
            }

            if (inputRowIndex != null)
            {
                input["RowIndex"] = ExpressionConverter.ConvertO(inputRowIndex);
                inputpropCount++;
            }

            var WorksheetToUpdateObject = new JObject();
            var WorksheetToUpdateObjectpropCount = 0;
            if (inputWorksheetToUpdatePath != null)
            {
                WorksheetToUpdateObject["Path"] = ExpressionConverter.ConvertO(inputWorksheetToUpdatePath);
                WorksheetToUpdateObjectpropCount++;
            }

            if (inputWorksheetToUpdateWorksheetName != null)
            {
                WorksheetToUpdateObject["WorksheetName"] = ExpressionConverter.ConvertO(inputWorksheetToUpdateWorksheetName);
                WorksheetToUpdateObjectpropCount++;
            }

            if (WorksheetToUpdateObjectpropCount > 0)
            {
                input["WorksheetToUpdate"] = WorksheetToUpdateObject;
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<SetXlsxCellResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebHtmlToDocx(Expression<Func<string>> inputRequestHtml = null)
        {
            var apiCallPath = "/convert/html/to/docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var inputRequest = new JObject();
            var inputRequestpropCount = 0;
            if (inputRequestHtml != null)
            {
                inputRequest["Html"] = ExpressionConverter.ConvertO(inputRequestHtml);
                inputRequestpropCount++;
            }

            if (inputRequestpropCount > 0)
            {
                callPayload.Body = inputRequest;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentHtmlToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/html/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<PdfToPngResult> ConvertDocumentHtmlToPng(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/html/to/png";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PdfToPngResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<TextConversionResult> ConvertDocumentHtmlToTxt(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/html/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TextConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<MultipageImageFormatConversionResult> ConvertImageMultipageImageFormatConvert(Expression<Func<string>> format1, Expression<Func<string>> format2, Expression<Func<object>> inputFile)
        {
            var apiCallPath = String.Format("/convert/image-multipage/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(format1, 1), ExpressionConverter.ConvertWithUrlEncoding(format2, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MultipageImageFormatConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetImageInfoResult> ConvertImageGetImageInfo(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/image/get-info";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetImageInfoResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertImageImageSetDPI(Expression<Func<int>> dpi, Expression<Func<object>> inputFile)
        {
            var apiCallPath = String.Format("/convert/image/set-dpi/{0}", ExpressionConverter.ConvertWithUrlEncoding(dpi, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertImageImageFormatConvert(Expression<Func<string>> format1, Expression<Func<string>> format2, Expression<Func<object>> inputFile)
        {
            var apiCallPath = String.Format("/convert/image/{0}/to/{1}", ExpressionConverter.ConvertWithUrlEncoding(format1, 1), ExpressionConverter.ConvertWithUrlEncoding(format2, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDataJsonToXml()
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

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentDocx(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2)
        {
            var apiCallPath = "/convert/merge/docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentDocxMulti(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/merge/docx/multi";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentPdf(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2)
        {
            var apiCallPath = "/convert/merge/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentPdfMulti(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/merge/pdf/multi";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentPng(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2)
        {
            var apiCallPath = "/convert/merge/png/vertical";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentPptx(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2)
        {
            var apiCallPath = "/convert/merge/pptx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentPptxMulti(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/merge/pptx/multi";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken> MergeDocumentTxt(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2)
        {
            var apiCallPath = "/convert/merge/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentTxtMulti(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/merge/txt/multi";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentXlsx(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2)
        {
            var apiCallPath = "/convert/merge/xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> MergeDocumentXlsxMulti(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/merge/xlsx/multi";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPdfToDocx(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/pdf/to/docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPdfToDocxRasterize(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/pdf/to/docx/rasterize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<PdfToPngResult> ConvertDocumentPdfToPngArray(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/pdf/to/png";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PdfToPngResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPdfToPngSingle(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/pdf/to/png/merge-single";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPdfToPptx(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/pdf/to/pptx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<TextConversionResult> ConvertDocumentPdfToTxt(Expression<Func<object>> inputFile, Expression<Func<string>> textFormattingMode = null)
        {
            var apiCallPath = "/convert/pdf/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (textFormattingMode != null)
                callPayload.Headers["textFormattingMode"] = ExpressionConverter.Convert(textFormattingMode);
            return new ApiConnectionAction<TextConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPngArrayToPdf(Expression<Func<object>> inputFile1, Expression<Func<object>> inputFile2, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/png/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPptToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/ppt/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPptToPptx(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/ppt/to/pptx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentPptxToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/pptx/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<TextConversionResult> ConvertDocumentPptxToTxt(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/pptx/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TextConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SplitDocxDocumentResult> SplitDocumentDocx(Expression<Func<object>> inputFile, Expression<Func<bool>> returnDocumentContents = null)
        {
            var apiCallPath = "/convert/split/docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (returnDocumentContents != null)
                callPayload.Headers["returnDocumentContents"] = ExpressionConverter.Convert(returnDocumentContents);
            return new ApiConnectionAction<SplitDocxDocumentResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SplitPdfResult> SplitDocumentPdfByPage(Expression<Func<object>> inputFile, Expression<Func<bool>> returnDocumentContents = null)
        {
            var apiCallPath = "/convert/split/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (returnDocumentContents != null)
                callPayload.Headers["returnDocumentContents"] = ExpressionConverter.Convert(returnDocumentContents);
            return new ApiConnectionAction<SplitPdfResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SplitPptxPresentationResult> SplitDocumentPptx(Expression<Func<object>> inputFile, Expression<Func<bool>> returnDocumentContents = null)
        {
            var apiCallPath = "/convert/split/pptx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (returnDocumentContents != null)
                callPayload.Headers["returnDocumentContents"] = ExpressionConverter.Convert(returnDocumentContents);
            return new ApiConnectionAction<SplitPptxPresentationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SplitTextDocumentByLinesResult> SplitDocumentTxtByLine(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/split/txt/by-line";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SplitTextDocumentByLinesResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SplitTextDocumentByStringResult> SplitDocumentTxtByString(Expression<Func<object>> inputFile, Expression<Func<string>> splitDelimiter, Expression<Func<bool>> skipEmptyElements = null)
        {
            var apiCallPath = "/convert/split/txt/by-string";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["splitDelimiter"] = ExpressionConverter.Convert(splitDelimiter);
            if (skipEmptyElements != null)
                callPayload.Headers["skipEmptyElements"] = ExpressionConverter.Convert(skipEmptyElements);
            return new ApiConnectionAction<SplitTextDocumentByStringResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SplitXlsxWorksheetResult> SplitDocumentXlsx(Expression<Func<object>> inputFile, Expression<Func<bool>> returnDocumentContents = null)
        {
            var apiCallPath = "/convert/split/xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (returnDocumentContents != null)
                callPayload.Headers["returnDocumentContents"] = ExpressionConverter.Convert(returnDocumentContents);
            return new ApiConnectionAction<SplitXlsxWorksheetResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlTemplateApplicationResponse> ConvertTemplateApplyHtmlTemplate(Expression<Func<string>> valueHtmlTemplate = null, Expression<Func<string>> valueHtmlTemplateUrl = null, Expression<Func<HtmlTemplateOperation[]>> valueOperations = null)
        {
            var apiCallPath = "/convert/template/html/apply";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var value = new JObject();
            var valuepropCount = 0;
            if (valueHtmlTemplate != null)
            {
                value["HtmlTemplate"] = ExpressionConverter.ConvertO(valueHtmlTemplate);
                valuepropCount++;
            }

            if (valueHtmlTemplateUrl != null)
            {
                value["HtmlTemplateUrl"] = ExpressionConverter.ConvertO(valueHtmlTemplateUrl);
                valuepropCount++;
            }

            if (valueOperations != null)
            {
                value["Operations"] = ExpressionConverter.ConvertO(valueOperations);
                valuepropCount++;
            }

            if (valuepropCount > 0)
            {
                callPayload.Body = value;
            }

            return new ApiConnectionAction<HtmlTemplateApplicationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<AutodetectDocumentValidationResult> ValidateDocumentAutodetectValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/autodetect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AutodetectDocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentDocxValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/docx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentJsonValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentPdfValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentPptxValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/pptx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentXlsxValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocumentValidationResult> ValidateDocumentXmlValidation(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/validate/xml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocumentValidationResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebHtmlToPdf(Expression<Func<int>> inputExtraLoadingWait = null, Expression<Func<string>> inputHtml = null)
        {
            var apiCallPath = "/convert/web/html/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputExtraLoadingWait != null)
            {
                input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(inputExtraLoadingWait);
                inputpropCount++;
            }

            if (inputHtml != null)
            {
                input["Html"] = ExpressionConverter.ConvertO(inputHtml);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken> ConvertWebHtmlToPng(Expression<Func<int>> inputExtraLoadingWait = null, Expression<Func<string>> inputHtml = null, Expression<Func<int>> inputScreenshotHeight = null, Expression<Func<int>> inputScreenshotWidth = null)
        {
            var apiCallPath = "/convert/web/html/to/png";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputExtraLoadingWait != null)
            {
                input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(inputExtraLoadingWait);
                inputpropCount++;
            }

            if (inputHtml != null)
            {
                input["Html"] = ExpressionConverter.ConvertO(inputHtml);
                inputpropCount++;
            }

            if (inputScreenshotHeight != null)
            {
                input["ScreenshotHeight"] = ExpressionConverter.ConvertO(inputScreenshotHeight);
                inputpropCount++;
            }

            if (inputScreenshotWidth != null)
            {
                input["ScreenshotWidth"] = ExpressionConverter.ConvertO(inputScreenshotWidth);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlToTextResponse> ConvertWebHtmlToTxt(Expression<Func<string>> inputHtml = null)
        {
            var apiCallPath = "/convert/web/html/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputHtml != null)
            {
                input["Html"] = ExpressionConverter.ConvertO(inputHtml);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<HtmlToTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlMdResult> ConvertWebMdToHtml(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/web/md/to/html";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<HtmlMdResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebUrlToPdf(Expression<Func<int>> inputExtraLoadingWait = null, Expression<Func<int>> inputScreenshotHeight = null, Expression<Func<int>> inputScreenshotWidth = null, Expression<Func<string>> inputUrl = null)
        {
            var apiCallPath = "/convert/web/url/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputExtraLoadingWait != null)
            {
                input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(inputExtraLoadingWait);
                inputpropCount++;
            }

            if (inputScreenshotHeight != null)
            {
                input["ScreenshotHeight"] = ExpressionConverter.ConvertO(inputScreenshotHeight);
                inputpropCount++;
            }

            if (inputScreenshotWidth != null)
            {
                input["ScreenshotWidth"] = ExpressionConverter.ConvertO(inputScreenshotWidth);
                inputpropCount++;
            }

            if (inputUrl != null)
            {
                input["Url"] = ExpressionConverter.ConvertO(inputUrl);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertWebUrlToScreenshot(Expression<Func<int>> inputExtraLoadingWait = null, Expression<Func<int>> inputScreenshotHeight = null, Expression<Func<int>> inputScreenshotWidth = null, Expression<Func<string>> inputUrl = null)
        {
            var apiCallPath = "/convert/web/url/to/screenshot";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputExtraLoadingWait != null)
            {
                input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(inputExtraLoadingWait);
                inputpropCount++;
            }

            if (inputScreenshotHeight != null)
            {
                input["ScreenshotHeight"] = ExpressionConverter.ConvertO(inputScreenshotHeight);
                inputpropCount++;
            }

            if (inputScreenshotWidth != null)
            {
                input["ScreenshotWidth"] = ExpressionConverter.ConvertO(inputScreenshotWidth);
                inputpropCount++;
            }

            if (inputUrl != null)
            {
                input["Url"] = ExpressionConverter.ConvertO(inputUrl);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UrlToTextResponse> ConvertWebUrlToTxt(Expression<Func<string>> inputUrl = null)
        {
            var apiCallPath = "/convert/web/url/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var input = new JObject();
            var inputpropCount = 0;
            if (inputUrl != null)
            {
                input["Url"] = ExpressionConverter.ConvertO(inputUrl);
                inputpropCount++;
            }

            if (inputpropCount > 0)
            {
                callPayload.Body = input;
            }

            return new ApiConnectionAction<UrlToTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentXlsToCsv(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xls/to/csv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken[]> ConvertDataXlsToJson(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xls/to/json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentXlsToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xls/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentXlsToXlsx(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xls/to/xlsx";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentXlsxToCsv(Expression<Func<object>> inputFile, Expression<Func<string>> outputEncoding = null)
        {
            var apiCallPath = "/convert/xlsx/to/csv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (outputEncoding != null)
                callPayload.Headers["outputEncoding"] = ExpressionConverter.Convert(outputEncoding);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken[]> ConvertDataXlsxToJson(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xlsx/to/json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDocumentXlsxToPdf(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xlsx/to/pdf";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<TextConversionResult> ConvertDocumentXlsxToTxt(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xlsx/to/txt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TextConversionResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlAddAttributeWithXPathResult> ConvertDataXmlEditAddAttributeWithXPath(Expression<Func<object>> inputFile, Expression<Func<string>> xPathExpression, Expression<Func<string>> xmlAttributeName, Expression<Func<string>> xmlAttributeValue)
        {
            var apiCallPath = "/convert/xml/edit/xpath/add-attribute";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XPathExpression"] = ExpressionConverter.Convert(xPathExpression);
            callPayload.Headers["XmlAttributeName"] = ExpressionConverter.Convert(xmlAttributeName);
            callPayload.Headers["XmlAttributeValue"] = ExpressionConverter.Convert(xmlAttributeValue);
            return new ApiConnectionAction<XmlAddAttributeWithXPathResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlAddChildWithXPathResult> ConvertDataXmlEditAddChildWithXPath(Expression<Func<object>> inputFile, Expression<Func<string>> xPathExpression, Expression<Func<string>> xmlNodeToAdd)
        {
            var apiCallPath = "/convert/xml/edit/xpath/add-child";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XPathExpression"] = ExpressionConverter.Convert(xPathExpression);
            callPayload.Headers["XmlNodeToAdd"] = ExpressionConverter.Convert(xmlNodeToAdd);
            return new ApiConnectionAction<XmlAddChildWithXPathResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlRemoveWithXPathResult> ConvertDataXmlRemoveWithXPath(Expression<Func<string>> xPathExpression, Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xml/edit/xpath/remove";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XPathExpression"] = ExpressionConverter.Convert(xPathExpression);
            return new ApiConnectionAction<XmlRemoveWithXPathResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlRemoveAllChildrenWithXPathResult> ConvertDataXmlEditRemoveAllChildNodesWithXPath(Expression<Func<object>> inputFile, Expression<Func<string>> xPathExpression)
        {
            var apiCallPath = "/convert/xml/edit/xpath/remove-all-children";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XPathExpression"] = ExpressionConverter.Convert(xPathExpression);
            return new ApiConnectionAction<XmlRemoveAllChildrenWithXPathResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlReplaceWithXPathResult> ConvertDataXmlEditReplaceWithXPath(Expression<Func<object>> inputFile, Expression<Func<string>> xPathExpression, Expression<Func<string>> xmlNodeReplacement)
        {
            var apiCallPath = "/convert/xml/edit/xpath/replace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XPathExpression"] = ExpressionConverter.Convert(xPathExpression);
            callPayload.Headers["XmlNodeReplacement"] = ExpressionConverter.Convert(xmlNodeReplacement);
            return new ApiConnectionAction<XmlReplaceWithXPathResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlSetValueWithXPathResult> ConvertDataXmlEditSetValueWithXPath(Expression<Func<object>> inputFile, Expression<Func<string>> xPathExpression, Expression<Func<string>> xmlValue)
        {
            var apiCallPath = "/convert/xml/edit/xpath/set-value";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XPathExpression"] = ExpressionConverter.Convert(xPathExpression);
            callPayload.Headers["XmlValue"] = ExpressionConverter.Convert(xmlValue);
            return new ApiConnectionAction<XmlSetValueWithXPathResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlQueryWithXQueryResult> ConvertDataXmlQueryWithXQuery(Expression<Func<object>> inputFile, Expression<Func<string>> xQuery)
        {
            var apiCallPath = "/convert/xml/query/xquery";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XQuery"] = ExpressionConverter.Convert(xQuery);
            return new ApiConnectionAction<XmlQueryWithXQueryResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlQueryWithXQueryMultiResult> ConvertDataXmlQueryWithXQueryMulti(Expression<Func<object>> inputFile1, Expression<Func<string>> xQuery, Expression<Func<object>> inputFile2 = null, Expression<Func<object>> inputFile3 = null, Expression<Func<object>> inputFile4 = null, Expression<Func<object>> inputFile5 = null, Expression<Func<object>> inputFile6 = null, Expression<Func<object>> inputFile7 = null, Expression<Func<object>> inputFile8 = null, Expression<Func<object>> inputFile9 = null, Expression<Func<object>> inputFile10 = null)
        {
            var apiCallPath = "/convert/xml/query/xquery/multi";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XQuery"] = ExpressionConverter.Convert(xQuery);
            return new ApiConnectionAction<XmlQueryWithXQueryMultiResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<XmlFilterWithXPathResult> ConvertDataXmlFilterWithXPath(Expression<Func<string>> xPathExpression, Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xml/select/xpath";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["XPathExpression"] = ExpressionConverter.Convert(xPathExpression);
            return new ApiConnectionAction<XmlFilterWithXPathResult>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken> ConvertDataXmlToJson(Expression<Func<object>> inputFile)
        {
            var apiCallPath = "/convert/xml/to/json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string> ConvertDataXmlTransformWithXsltToXml(Expression<Func<object>> inputFile, Expression<Func<object>> transformFile)
        {
            var apiCallPath = "/convert/xml/transform/xslt/to/xml";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class CloudmersiveconvertTriggers([ConnectionName] string connectionId)
    {
    }

    public class AutodetectGetInfoResult
    {
        public AlternateFileFormatCandidate[] AlternateFileTypeCandidates { get; set; }
        public string Author { get; set; }
        public string DateModified { get; set; }
        public string DetectedFileExtension { get; set; }
        public string DetectedMimeType { get; set; }
        public int PageCount { get; set; }
        public bool Successful { get; set; }
    }

    public class AlternateFileFormatCandidate
    {
        public string DetectedFileExtension { get; set; }
        public string DetectedMimeType { get; set; }
        public double Probability { get; set; }
    }

    public class AutodetectToPngResult
    {
        public ConvertedPngPage[] PngResultPages { get; set; }
        public bool Successful { get; set; }
    }

    public class ConvertedPngPage
    {
        public int PageNumber { get; set; }
        public string URL { get; set; }
    }

    public class TextConversionResult
    {
        public bool Successful { get; set; }
        public string TextResult { get; set; }
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

    public class PdfToPngResult
    {
        public ConvertedPngPage[] PngResultPages { get; set; }
        public bool Successful { get; set; }
    }

    public class MultipageImageFormatConversionResult
    {
        public int PageCount { get; set; }
        public PageConversionResult[] Pages { get; set; }
        public bool Successful { get; set; }
    }

    public class PageConversionResult
    {
        public string FileBytes { get; set; }
        public string Filename { get; set; }
    }

    public class GetImageInfoResult
    {
        public int BitDepth { get; set; }
        public int ColorCount { get; set; }
        public string ColorSpace { get; set; }
        public string ColorType { get; set; }
        public string Comment { get; set; }
        public int CompressionLevel { get; set; }
        public double DPI { get; set; }
        public string DPIUnit { get; set; }
        public string ExifProfileName { get; set; }
        public ExifValue[] ExifValues { get; set; }
        public bool HasTransparency { get; set; }
        public int Height { get; set; }
        public string ImageFormat { get; set; }
        public string ImageHashSignature { get; set; }
        public string MimeType { get; set; }
        public bool Successful { get; set; }
        public int Width { get; set; }
    }

    public class ExifValue
    {
        public string DataType { get; set; }
        public string DataValue { get; set; }
        public string Tag { get; set; }
    }

    public class SplitDocxDocumentResult
    {
        public SplitDocumentResult[] ResultDocuments { get; set; }
        public bool Successful { get; set; }
    }

    public class SplitDocumentResult
    {
        public string DocumentContents { get; set; }
        public int PageNumber { get; set; }
        public string URL { get; set; }
    }

    public class SplitPdfResult
    {
        public PdfDocument[] Documents { get; set; }
        public bool Successful { get; set; }
    }

    public class PdfDocument
    {
        public string DocumentContents { get; set; }
        public int PageNumber { get; set; }
        public string URL { get; set; }
    }

    public class SplitPptxPresentationResult
    {
        public PresentationResult[] ResultPresentations { get; set; }
        public bool Successful { get; set; }
    }

    public class PresentationResult
    {
        public string PresentationContents { get; set; }
        public int SlideNumber { get; set; }
        public string URL { get; set; }
    }

    public class SplitTextDocumentByLinesResult
    {
        public int LineCount { get; set; }
        public TextDocumentLine[] ResultLines { get; set; }
        public bool Successful { get; set; }
    }

    public class TextDocumentLine
    {
        public string LineContents { get; set; }
        public int LineNumber { get; set; }
    }

    public class SplitTextDocumentByStringResult
    {
        public int ElementCount { get; set; }
        public TextDocumentElement[] ResultElements { get; set; }
        public bool Successful { get; set; }
    }

    public class TextDocumentElement
    {
        public string ElementContents { get; set; }
        public int ElementNumber { get; set; }
    }

    public class SplitXlsxWorksheetResult
    {
        public WorksheetResult[] ResultWorksheets { get; set; }
        public bool Successful { get; set; }
    }

    public class WorksheetResult
    {
        public string URL { get; set; }
        public string WorksheetContents { get; set; }
        public string WorksheetName { get; set; }
        public int WorksheetNumber { get; set; }
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
        [EnumMember(Value = "1")]
        _1
    }

    public class AutodetectDocumentValidationResult
    {
        public bool DocumentIsValid { get; set; }
        public int ErrorCount { get; set; }
        public DocumentValidationError[] ErrorsAndWarnings { get; set; }
        public string FileFormatExtension { get; set; }
        public int WarningCount { get; set; }
    }

    public class DocumentValidationError
    {
        public string Description { get; set; }
        public bool IsError { get; set; }
        public string Path { get; set; }
        public string Uri { get; set; }
    }

    public class DocumentValidationResult
    {
        public bool DocumentIsValid { get; set; }
        public int ErrorCount { get; set; }
        public DocumentValidationError[] ErrorsAndWarnings { get; set; }
        public int WarningCount { get; set; }
    }

    public class HtmlToTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class HtmlMdResult
    {
        public string Html { get; set; }
        public bool Successful { get; set; }
    }

    public class UrlToTextResponse
    {
        public bool Successful { get; set; }
        public string TextContentResult { get; set; }
    }

    public class XmlAddAttributeWithXPathResult
    {
        public int NodesEditedCount { get; set; }
        public string ResultingXmlDocument { get; set; }
        public bool Successful { get; set; }
    }

    public class XmlAddChildWithXPathResult
    {
        public int NodesEditedCount { get; set; }
        public string ResultingXmlDocument { get; set; }
        public bool Successful { get; set; }
    }

    public class XmlRemoveWithXPathResult
    {
        public int NodesRemovedCount { get; set; }
        public string ResultingXmlDocument { get; set; }
        public bool Successful { get; set; }
        public string[] XmlNodesRemoved { get; set; }
    }

    public class XmlRemoveAllChildrenWithXPathResult
    {
        public int NodesEditedCount { get; set; }
        public string ResultingXmlDocument { get; set; }
        public bool Successful { get; set; }
    }

    public class XmlReplaceWithXPathResult
    {
        public int NodesEditedCount { get; set; }
        public string ResultingXmlDocument { get; set; }
        public bool Successful { get; set; }
    }

    public class XmlSetValueWithXPathResult
    {
        public int NodesEditedCount { get; set; }
        public string ResultingXmlDocument { get; set; }
        public bool Successful { get; set; }
    }

    public class XmlQueryWithXQueryResult
    {
        public string ErrorMessage { get; set; }
        public string ResultingXml { get; set; }
        public bool Successful { get; set; }
    }

    public class XmlQueryWithXQueryMultiResult
    {
        public string ErrorMessage { get; set; }
        public string ResultingXml { get; set; }
        public bool Successful { get; set; }
    }

    public class XmlFilterWithXPathResult
    {
        public int ResultCount { get; set; }
        public bool Successful { get; set; }
        public string[] XmlNodes { get; set; }
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