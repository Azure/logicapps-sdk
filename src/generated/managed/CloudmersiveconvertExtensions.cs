//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudmersiveconvert
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudmersiveconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankDocxResponse, ApiConnectionActionConfiguration> EditDocumentDocxCreateBlankDocument(Expression<Func<string>> inputinitialText = null)
        {
            var __workflow_inputinitialText = WorkflowExpression.Compile(inputinitialText, nameof(inputinitialText), required: false);
            return new DeferredBodyAction<CreateBlankDocxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/create/blank";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputinitialText != null)
                {
                    input["InitialText"] = ExpressionConverter.ConvertO(__workflow_inputinitialText);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<CreateBlankDocxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentDocxDeletePages(Expression<Func<int>> reqConfigendDeletePageNumber = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<int>> reqConfigstartDeletePageNumber = null)
        {
            var __workflow_reqConfigendDeletePageNumber = WorkflowExpression.Compile(reqConfigendDeletePageNumber, nameof(reqConfigendDeletePageNumber), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigstartDeletePageNumber = WorkflowExpression.Compile(reqConfigstartDeletePageNumber, nameof(reqConfigstartDeletePageNumber), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/delete-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfigendDeletePageNumber != null)
                {
                    reqConfig["EndDeletePageNumber"] = ExpressionConverter.ConvertO(__workflow_reqConfigendDeletePageNumber);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigstartDeletePageNumber != null)
                {
                    reqConfig["StartDeletePageNumber"] = ExpressionConverter.ConvertO(__workflow_reqConfigstartDeletePageNumber);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxDeleteTableRow(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigtablePath = null, Expression<Func<int>> reqConfigtableRowRowIndex = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigtablePath = WorkflowExpression.Compile(reqConfigtablePath, nameof(reqConfigtablePath), required: false);
            var __workflow_reqConfigtableRowRowIndex = WorkflowExpression.Compile(reqConfigtableRowRowIndex, nameof(reqConfigtableRowRowIndex), required: false);
            return new DeferredBodyAction<DeleteDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/delete-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtablePath != null)
                {
                    reqConfig["TablePath"] = ExpressionConverter.ConvertO(__workflow_reqConfigtablePath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableRowRowIndex != null)
                {
                    reqConfig["TableRowRowIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableRowRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<DeleteDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DeleteDocxTableRowRangeResponse, ApiConnectionActionConfiguration> EditDocumentDocxDeleteTableRowRange(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigtablePath = null, Expression<Func<int>> reqConfigtableRowRowIndexEnd = null, Expression<Func<int>> reqConfigtableRowRowIndexStart = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigtablePath = WorkflowExpression.Compile(reqConfigtablePath, nameof(reqConfigtablePath), required: false);
            var __workflow_reqConfigtableRowRowIndexEnd = WorkflowExpression.Compile(reqConfigtableRowRowIndexEnd, nameof(reqConfigtableRowRowIndexEnd), required: false);
            var __workflow_reqConfigtableRowRowIndexStart = WorkflowExpression.Compile(reqConfigtableRowRowIndexStart, nameof(reqConfigtableRowRowIndexStart), required: false);
            return new DeferredBodyAction<DeleteDocxTableRowRangeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/delete-table-row/range";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtablePath != null)
                {
                    reqConfig["TablePath"] = ExpressionConverter.ConvertO(__workflow_reqConfigtablePath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableRowRowIndexEnd != null)
                {
                    reqConfig["TableRowRowIndexEnd"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableRowRowIndexEnd);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableRowRowIndexStart != null)
                {
                    reqConfig["TableRowRowIndexStart"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableRowRowIndexStart);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<DeleteDocxTableRowRangeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxBodyResponse, ApiConnectionActionConfiguration> EditDocumentDocxBody(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxBodyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-body";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxBodyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxCommentsHierarchicalResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetCommentsHierarchical(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxCommentsHierarchicalResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-comments/hierarchical";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxCommentsHierarchicalResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetHeadersAndFooters(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-headers-and-footers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxHeadersAndFootersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxImagesResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetImages(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxImagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-images";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxPagesResponse, ApiConnectionActionConfiguration> EditDocumentDocxPages(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxPagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-pages";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxPagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxSectionsResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetSections(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxSectionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-sections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxSectionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxStylesResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetStyles(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxStylesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-styles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxStylesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetTableRow(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigtablePath = null, Expression<Func<int>> reqConfigtableRowRowIndex = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigtablePath = WorkflowExpression.Compile(reqConfigtablePath, nameof(reqConfigtablePath), required: false);
            var __workflow_reqConfigtableRowRowIndex = WorkflowExpression.Compile(reqConfigtableRowRowIndex, nameof(reqConfigtableRowRowIndex), required: false);
            return new DeferredBodyAction<GetDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtablePath != null)
                {
                    reqConfig["TablePath"] = ExpressionConverter.ConvertO(__workflow_reqConfigtablePath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableRowRowIndex != null)
                {
                    reqConfig["TableRowRowIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableRowRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTableByIndexResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetTableByIndex(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<int>> reqConfigtableIndex = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigtableIndex = WorkflowExpression.Compile(reqConfigtableIndex, nameof(reqConfigtableIndex), required: false);
            return new DeferredBodyAction<GetDocxTableByIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-table/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableIndex != null)
                {
                    reqConfig["TableIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxTableByIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetDocxTablesResponse, ApiConnectionActionConfiguration> EditDocumentDocxGetTables(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<GetDocxTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/get-tables";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<GetDocxTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxCommentOnParagraphResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertCommentOnParagraph(Expression<Func<string>> reqConfigcommentToInsertauthor = null, Expression<Func<string>> reqConfigcommentToInsertauthorInitials = null, Expression<Func<string>> reqConfigcommentToInsertcommentDate = null, Expression<Func<string>> reqConfigcommentToInsertcommentText = null, Expression<Func<bool>> reqConfigcommentToInsertdone = null, Expression<Func<bool>> reqConfigcommentToInsertisReply = null, Expression<Func<bool>> reqConfigcommentToInsertisTopLevel = null, Expression<Func<string>> reqConfigcommentToInsertparentCommentPath = null, Expression<Func<string>> reqConfigcommentToInsertpath = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigparagraphPath = null)
        {
            var __workflow_reqConfigcommentToInsertauthor = WorkflowExpression.Compile(reqConfigcommentToInsertauthor, nameof(reqConfigcommentToInsertauthor), required: false);
            var __workflow_reqConfigcommentToInsertauthorInitials = WorkflowExpression.Compile(reqConfigcommentToInsertauthorInitials, nameof(reqConfigcommentToInsertauthorInitials), required: false);
            var __workflow_reqConfigcommentToInsertcommentDate = WorkflowExpression.Compile(reqConfigcommentToInsertcommentDate, nameof(reqConfigcommentToInsertcommentDate), required: false);
            var __workflow_reqConfigcommentToInsertcommentText = WorkflowExpression.Compile(reqConfigcommentToInsertcommentText, nameof(reqConfigcommentToInsertcommentText), required: false);
            var __workflow_reqConfigcommentToInsertdone = WorkflowExpression.Compile(reqConfigcommentToInsertdone, nameof(reqConfigcommentToInsertdone), required: false);
            var __workflow_reqConfigcommentToInsertisReply = WorkflowExpression.Compile(reqConfigcommentToInsertisReply, nameof(reqConfigcommentToInsertisReply), required: false);
            var __workflow_reqConfigcommentToInsertisTopLevel = WorkflowExpression.Compile(reqConfigcommentToInsertisTopLevel, nameof(reqConfigcommentToInsertisTopLevel), required: false);
            var __workflow_reqConfigcommentToInsertparentCommentPath = WorkflowExpression.Compile(reqConfigcommentToInsertparentCommentPath, nameof(reqConfigcommentToInsertparentCommentPath), required: false);
            var __workflow_reqConfigcommentToInsertpath = WorkflowExpression.Compile(reqConfigcommentToInsertpath, nameof(reqConfigcommentToInsertpath), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigparagraphPath = WorkflowExpression.Compile(reqConfigparagraphPath, nameof(reqConfigparagraphPath), required: false);
            return new DeferredBodyAction<InsertDocxCommentOnParagraphResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-comment/on/paragraph";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var commentToInsertObject = new JObject();
                var commentToInsertObjectpropCount = 0;
                if (__workflow_reqConfigcommentToInsertauthor != null)
                {
                    commentToInsertObject["Author"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertauthor);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertauthorInitials != null)
                {
                    commentToInsertObject["AuthorInitials"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertauthorInitials);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertcommentDate != null)
                {
                    commentToInsertObject["CommentDate"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertcommentDate);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertcommentText != null)
                {
                    commentToInsertObject["CommentText"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertcommentText);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertdone != null)
                {
                    commentToInsertObject["Done"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertdone);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertisReply != null)
                {
                    commentToInsertObject["IsReply"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertisReply);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertisTopLevel != null)
                {
                    commentToInsertObject["IsTopLevel"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertisTopLevel);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertparentCommentPath != null)
                {
                    commentToInsertObject["ParentCommentPath"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertparentCommentPath);
                    commentToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigcommentToInsertpath != null)
                {
                    commentToInsertObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigcommentToInsertpath);
                    commentToInsertObjectpropCount++;
                }

                if (commentToInsertObjectpropCount > 0)
                {
                    reqConfig["CommentToInsert"] = commentToInsertObject;
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigparagraphPath != null)
                {
                    reqConfig["ParagraphPath"] = ExpressionConverter.ConvertO(__workflow_reqConfigparagraphPath);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<InsertDocxCommentOnParagraphResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxInsertImageResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertImage(Expression<Func<int>> reqConfigheightInEMUs = null, Expression<Func<string>> reqConfigimageToAddimageContentsURL = null, Expression<Func<string>> reqConfigimageToAddimageDataContentType = null, Expression<Func<string>> reqConfigimageToAddimageDataEmbedId = null, Expression<Func<string>> reqConfigimageToAddimageDescription = null, Expression<Func<int>> reqConfigimageToAddimageHeight = null, Expression<Func<int>> reqConfigimageToAddimageId = null, Expression<Func<string>> reqConfigimageToAddimageInternalFileName = null, Expression<Func<string>> reqConfigimageToAddimageName = null, Expression<Func<int>> reqConfigimageToAddimageWidth = null, Expression<Func<bool>> reqConfigimageToAddinlineWithText = null, Expression<Func<string>> reqConfigimageToAddpath = null, Expression<Func<int>> reqConfigimageToAddxOffset = null, Expression<Func<int>> reqConfigimageToAddyOffset = null, Expression<Func<string>> reqConfiginputDocumentFileBytes = null, Expression<Func<string>> reqConfiginputDocumentFileUrl = null, Expression<Func<string>> reqConfiginputImageFileBytes = null, Expression<Func<string>> reqConfiginputImageFileUrl = null, Expression<Func<string>> reqConfiginsertPath = null, Expression<Func<string>> reqConfiginsertPlacement = null, Expression<Func<int>> reqConfigwidthInEMUs = null)
        {
            var __workflow_reqConfigheightInEMUs = WorkflowExpression.Compile(reqConfigheightInEMUs, nameof(reqConfigheightInEMUs), required: false);
            var __workflow_reqConfigimageToAddimageContentsURL = WorkflowExpression.Compile(reqConfigimageToAddimageContentsURL, nameof(reqConfigimageToAddimageContentsURL), required: false);
            var __workflow_reqConfigimageToAddimageDataContentType = WorkflowExpression.Compile(reqConfigimageToAddimageDataContentType, nameof(reqConfigimageToAddimageDataContentType), required: false);
            var __workflow_reqConfigimageToAddimageDataEmbedId = WorkflowExpression.Compile(reqConfigimageToAddimageDataEmbedId, nameof(reqConfigimageToAddimageDataEmbedId), required: false);
            var __workflow_reqConfigimageToAddimageDescription = WorkflowExpression.Compile(reqConfigimageToAddimageDescription, nameof(reqConfigimageToAddimageDescription), required: false);
            var __workflow_reqConfigimageToAddimageHeight = WorkflowExpression.Compile(reqConfigimageToAddimageHeight, nameof(reqConfigimageToAddimageHeight), required: false);
            var __workflow_reqConfigimageToAddimageId = WorkflowExpression.Compile(reqConfigimageToAddimageId, nameof(reqConfigimageToAddimageId), required: false);
            var __workflow_reqConfigimageToAddimageInternalFileName = WorkflowExpression.Compile(reqConfigimageToAddimageInternalFileName, nameof(reqConfigimageToAddimageInternalFileName), required: false);
            var __workflow_reqConfigimageToAddimageName = WorkflowExpression.Compile(reqConfigimageToAddimageName, nameof(reqConfigimageToAddimageName), required: false);
            var __workflow_reqConfigimageToAddimageWidth = WorkflowExpression.Compile(reqConfigimageToAddimageWidth, nameof(reqConfigimageToAddimageWidth), required: false);
            var __workflow_reqConfigimageToAddinlineWithText = WorkflowExpression.Compile(reqConfigimageToAddinlineWithText, nameof(reqConfigimageToAddinlineWithText), required: false);
            var __workflow_reqConfigimageToAddpath = WorkflowExpression.Compile(reqConfigimageToAddpath, nameof(reqConfigimageToAddpath), required: false);
            var __workflow_reqConfigimageToAddxOffset = WorkflowExpression.Compile(reqConfigimageToAddxOffset, nameof(reqConfigimageToAddxOffset), required: false);
            var __workflow_reqConfigimageToAddyOffset = WorkflowExpression.Compile(reqConfigimageToAddyOffset, nameof(reqConfigimageToAddyOffset), required: false);
            var __workflow_reqConfiginputDocumentFileBytes = WorkflowExpression.Compile(reqConfiginputDocumentFileBytes, nameof(reqConfiginputDocumentFileBytes), required: false);
            var __workflow_reqConfiginputDocumentFileUrl = WorkflowExpression.Compile(reqConfiginputDocumentFileUrl, nameof(reqConfiginputDocumentFileUrl), required: false);
            var __workflow_reqConfiginputImageFileBytes = WorkflowExpression.Compile(reqConfiginputImageFileBytes, nameof(reqConfiginputImageFileBytes), required: false);
            var __workflow_reqConfiginputImageFileUrl = WorkflowExpression.Compile(reqConfiginputImageFileUrl, nameof(reqConfiginputImageFileUrl), required: false);
            var __workflow_reqConfiginsertPath = WorkflowExpression.Compile(reqConfiginsertPath, nameof(reqConfiginsertPath), required: false);
            var __workflow_reqConfiginsertPlacement = WorkflowExpression.Compile(reqConfiginsertPlacement, nameof(reqConfiginsertPlacement), required: false);
            var __workflow_reqConfigwidthInEMUs = WorkflowExpression.Compile(reqConfigwidthInEMUs, nameof(reqConfigwidthInEMUs), required: false);
            return new DeferredBodyAction<DocxInsertImageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfigheightInEMUs != null)
                {
                    reqConfig["HeightInEMUs"] = ExpressionConverter.ConvertO(__workflow_reqConfigheightInEMUs);
                    reqConfigpropCount++;
                }

                var imageToAddObject = new JObject();
                var imageToAddObjectpropCount = 0;
                if (__workflow_reqConfigimageToAddimageContentsURL != null)
                {
                    imageToAddObject["ImageContentsURL"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageContentsURL);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageDataContentType != null)
                {
                    imageToAddObject["ImageDataContentType"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageDataContentType);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageDataEmbedId != null)
                {
                    imageToAddObject["ImageDataEmbedId"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageDataEmbedId);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageDescription != null)
                {
                    imageToAddObject["ImageDescription"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageDescription);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageHeight != null)
                {
                    imageToAddObject["ImageHeight"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageHeight);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageId != null)
                {
                    imageToAddObject["ImageId"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageId);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageInternalFileName != null)
                {
                    imageToAddObject["ImageInternalFileName"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageInternalFileName);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageName != null)
                {
                    imageToAddObject["ImageName"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageName);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddimageWidth != null)
                {
                    imageToAddObject["ImageWidth"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddimageWidth);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddinlineWithText != null)
                {
                    imageToAddObject["InlineWithText"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddinlineWithText);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddpath != null)
                {
                    imageToAddObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddpath);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddxOffset != null)
                {
                    imageToAddObject["XOffset"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddxOffset);
                    imageToAddObjectpropCount++;
                }

                if (__workflow_reqConfigimageToAddyOffset != null)
                {
                    imageToAddObject["YOffset"] = ExpressionConverter.ConvertO(__workflow_reqConfigimageToAddyOffset);
                    imageToAddObjectpropCount++;
                }

                if (imageToAddObjectpropCount > 0)
                {
                    reqConfig["ImageToAdd"] = imageToAddObject;
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputDocumentFileBytes != null)
                {
                    reqConfig["InputDocumentFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputDocumentFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputDocumentFileUrl != null)
                {
                    reqConfig["InputDocumentFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputDocumentFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputImageFileBytes != null)
                {
                    reqConfig["InputImageFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputImageFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputImageFileUrl != null)
                {
                    reqConfig["InputImageFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputImageFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginsertPath != null)
                {
                    reqConfig["InsertPath"] = ExpressionConverter.ConvertO(__workflow_reqConfiginsertPath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(__workflow_reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigwidthInEMUs != null)
                {
                    reqConfig["WidthInEMUs"] = ExpressionConverter.ConvertO(__workflow_reqConfigwidthInEMUs);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<DocxInsertImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxInsertParagraphResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertParagraph(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfiginsertPath = null, Expression<Func<string>> reqConfiginsertPlacement = null, Expression<Func<DocxRun[]>> reqConfigparagraphToInsertcontentRuns = null, Expression<Func<int>> reqConfigparagraphToInsertparagraphIndex = null, Expression<Func<string>> reqConfigparagraphToInsertpath = null, Expression<Func<string>> reqConfigparagraphToInsertstyleId = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfiginsertPath = WorkflowExpression.Compile(reqConfiginsertPath, nameof(reqConfiginsertPath), required: false);
            var __workflow_reqConfiginsertPlacement = WorkflowExpression.Compile(reqConfiginsertPlacement, nameof(reqConfiginsertPlacement), required: false);
            var __workflow_reqConfigparagraphToInsertcontentRuns = WorkflowExpression.Compile(reqConfigparagraphToInsertcontentRuns, nameof(reqConfigparagraphToInsertcontentRuns), required: false);
            var __workflow_reqConfigparagraphToInsertparagraphIndex = WorkflowExpression.Compile(reqConfigparagraphToInsertparagraphIndex, nameof(reqConfigparagraphToInsertparagraphIndex), required: false);
            var __workflow_reqConfigparagraphToInsertpath = WorkflowExpression.Compile(reqConfigparagraphToInsertpath, nameof(reqConfigparagraphToInsertpath), required: false);
            var __workflow_reqConfigparagraphToInsertstyleId = WorkflowExpression.Compile(reqConfigparagraphToInsertstyleId, nameof(reqConfigparagraphToInsertstyleId), required: false);
            return new DeferredBodyAction<InsertDocxInsertParagraphResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-paragraph";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginsertPath != null)
                {
                    reqConfig["InsertPath"] = ExpressionConverter.ConvertO(__workflow_reqConfiginsertPath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(__workflow_reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                var paragraphToInsertObject = new JObject();
                var paragraphToInsertObjectpropCount = 0;
                if (__workflow_reqConfigparagraphToInsertcontentRuns != null)
                {
                    paragraphToInsertObject["ContentRuns"] = ExpressionConverter.ConvertO(__workflow_reqConfigparagraphToInsertcontentRuns);
                    paragraphToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigparagraphToInsertparagraphIndex != null)
                {
                    paragraphToInsertObject["ParagraphIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigparagraphToInsertparagraphIndex);
                    paragraphToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigparagraphToInsertpath != null)
                {
                    paragraphToInsertObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigparagraphToInsertpath);
                    paragraphToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigparagraphToInsertstyleId != null)
                {
                    paragraphToInsertObject["StyleID"] = ExpressionConverter.ConvertO(__workflow_reqConfigparagraphToInsertstyleId);
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

                return new ApiConnectionAction<InsertDocxInsertParagraphResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTablesResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertTable(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfiginsertPath = null, Expression<Func<string>> reqConfiginsertPlacement = null, Expression<Func<string>> reqConfigtableToInsertbottomBorderColor = null, Expression<Func<int>> reqConfigtableToInsertbottomBorderSize = null, Expression<Func<int>> reqConfigtableToInsertbottomBorderSpace = null, Expression<Func<string>> reqConfigtableToInsertbottomBorderType = null, Expression<Func<string>> reqConfigtableToInsertcellHorizontalBorderColor = null, Expression<Func<int>> reqConfigtableToInsertcellHorizontalBorderSize = null, Expression<Func<int>> reqConfigtableToInsertcellHorizontalBorderSpace = null, Expression<Func<string>> reqConfigtableToInsertcellHorizontalBorderType = null, Expression<Func<string>> reqConfigtableToInsertcellVerticalBorderColor = null, Expression<Func<int>> reqConfigtableToInsertcellVerticalBorderSize = null, Expression<Func<int>> reqConfigtableToInsertcellVerticalBorderSpace = null, Expression<Func<string>> reqConfigtableToInsertcellVerticalBorderType = null, Expression<Func<string>> reqConfigtableToInsertendBorderColor = null, Expression<Func<int>> reqConfigtableToInsertendBorderSize = null, Expression<Func<int>> reqConfigtableToInsertendBorderSpace = null, Expression<Func<string>> reqConfigtableToInsertendBorderType = null, Expression<Func<string>> reqConfigtableToInsertleftBorderColor = null, Expression<Func<int>> reqConfigtableToInsertleftBorderSize = null, Expression<Func<int>> reqConfigtableToInsertleftBorderSpace = null, Expression<Func<string>> reqConfigtableToInsertleftBorderType = null, Expression<Func<string>> reqConfigtableToInsertpath = null, Expression<Func<string>> reqConfigtableToInsertrightBorderColor = null, Expression<Func<int>> reqConfigtableToInsertrightBorderSize = null, Expression<Func<int>> reqConfigtableToInsertrightBorderSpace = null, Expression<Func<string>> reqConfigtableToInsertrightBorderType = null, Expression<Func<string>> reqConfigtableToInsertstartBorderColor = null, Expression<Func<int>> reqConfigtableToInsertstartBorderSize = null, Expression<Func<int>> reqConfigtableToInsertstartBorderSpace = null, Expression<Func<string>> reqConfigtableToInsertstartBorderType = null, Expression<Func<string>> reqConfigtableToInserttableId = null, Expression<Func<string>> reqConfigtableToInserttableIndentationMode = null, Expression<Func<int>> reqConfigtableToInserttableIndentationWidth = null, Expression<Func<DocxTableRow[]>> reqConfigtableToInserttableRows = null, Expression<Func<string>> reqConfigtableToInserttopBorderColor = null, Expression<Func<int>> reqConfigtableToInserttopBorderSize = null, Expression<Func<int>> reqConfigtableToInserttopBorderSpace = null, Expression<Func<string>> reqConfigtableToInserttopBorderType = null, Expression<Func<string>> reqConfigtableToInsertwidth = null, Expression<Func<string>> reqConfigtableToInsertwidthType = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfiginsertPath = WorkflowExpression.Compile(reqConfiginsertPath, nameof(reqConfiginsertPath), required: false);
            var __workflow_reqConfiginsertPlacement = WorkflowExpression.Compile(reqConfiginsertPlacement, nameof(reqConfiginsertPlacement), required: false);
            var __workflow_reqConfigtableToInsertbottomBorderColor = WorkflowExpression.Compile(reqConfigtableToInsertbottomBorderColor, nameof(reqConfigtableToInsertbottomBorderColor), required: false);
            var __workflow_reqConfigtableToInsertbottomBorderSize = WorkflowExpression.Compile(reqConfigtableToInsertbottomBorderSize, nameof(reqConfigtableToInsertbottomBorderSize), required: false);
            var __workflow_reqConfigtableToInsertbottomBorderSpace = WorkflowExpression.Compile(reqConfigtableToInsertbottomBorderSpace, nameof(reqConfigtableToInsertbottomBorderSpace), required: false);
            var __workflow_reqConfigtableToInsertbottomBorderType = WorkflowExpression.Compile(reqConfigtableToInsertbottomBorderType, nameof(reqConfigtableToInsertbottomBorderType), required: false);
            var __workflow_reqConfigtableToInsertcellHorizontalBorderColor = WorkflowExpression.Compile(reqConfigtableToInsertcellHorizontalBorderColor, nameof(reqConfigtableToInsertcellHorizontalBorderColor), required: false);
            var __workflow_reqConfigtableToInsertcellHorizontalBorderSize = WorkflowExpression.Compile(reqConfigtableToInsertcellHorizontalBorderSize, nameof(reqConfigtableToInsertcellHorizontalBorderSize), required: false);
            var __workflow_reqConfigtableToInsertcellHorizontalBorderSpace = WorkflowExpression.Compile(reqConfigtableToInsertcellHorizontalBorderSpace, nameof(reqConfigtableToInsertcellHorizontalBorderSpace), required: false);
            var __workflow_reqConfigtableToInsertcellHorizontalBorderType = WorkflowExpression.Compile(reqConfigtableToInsertcellHorizontalBorderType, nameof(reqConfigtableToInsertcellHorizontalBorderType), required: false);
            var __workflow_reqConfigtableToInsertcellVerticalBorderColor = WorkflowExpression.Compile(reqConfigtableToInsertcellVerticalBorderColor, nameof(reqConfigtableToInsertcellVerticalBorderColor), required: false);
            var __workflow_reqConfigtableToInsertcellVerticalBorderSize = WorkflowExpression.Compile(reqConfigtableToInsertcellVerticalBorderSize, nameof(reqConfigtableToInsertcellVerticalBorderSize), required: false);
            var __workflow_reqConfigtableToInsertcellVerticalBorderSpace = WorkflowExpression.Compile(reqConfigtableToInsertcellVerticalBorderSpace, nameof(reqConfigtableToInsertcellVerticalBorderSpace), required: false);
            var __workflow_reqConfigtableToInsertcellVerticalBorderType = WorkflowExpression.Compile(reqConfigtableToInsertcellVerticalBorderType, nameof(reqConfigtableToInsertcellVerticalBorderType), required: false);
            var __workflow_reqConfigtableToInsertendBorderColor = WorkflowExpression.Compile(reqConfigtableToInsertendBorderColor, nameof(reqConfigtableToInsertendBorderColor), required: false);
            var __workflow_reqConfigtableToInsertendBorderSize = WorkflowExpression.Compile(reqConfigtableToInsertendBorderSize, nameof(reqConfigtableToInsertendBorderSize), required: false);
            var __workflow_reqConfigtableToInsertendBorderSpace = WorkflowExpression.Compile(reqConfigtableToInsertendBorderSpace, nameof(reqConfigtableToInsertendBorderSpace), required: false);
            var __workflow_reqConfigtableToInsertendBorderType = WorkflowExpression.Compile(reqConfigtableToInsertendBorderType, nameof(reqConfigtableToInsertendBorderType), required: false);
            var __workflow_reqConfigtableToInsertleftBorderColor = WorkflowExpression.Compile(reqConfigtableToInsertleftBorderColor, nameof(reqConfigtableToInsertleftBorderColor), required: false);
            var __workflow_reqConfigtableToInsertleftBorderSize = WorkflowExpression.Compile(reqConfigtableToInsertleftBorderSize, nameof(reqConfigtableToInsertleftBorderSize), required: false);
            var __workflow_reqConfigtableToInsertleftBorderSpace = WorkflowExpression.Compile(reqConfigtableToInsertleftBorderSpace, nameof(reqConfigtableToInsertleftBorderSpace), required: false);
            var __workflow_reqConfigtableToInsertleftBorderType = WorkflowExpression.Compile(reqConfigtableToInsertleftBorderType, nameof(reqConfigtableToInsertleftBorderType), required: false);
            var __workflow_reqConfigtableToInsertpath = WorkflowExpression.Compile(reqConfigtableToInsertpath, nameof(reqConfigtableToInsertpath), required: false);
            var __workflow_reqConfigtableToInsertrightBorderColor = WorkflowExpression.Compile(reqConfigtableToInsertrightBorderColor, nameof(reqConfigtableToInsertrightBorderColor), required: false);
            var __workflow_reqConfigtableToInsertrightBorderSize = WorkflowExpression.Compile(reqConfigtableToInsertrightBorderSize, nameof(reqConfigtableToInsertrightBorderSize), required: false);
            var __workflow_reqConfigtableToInsertrightBorderSpace = WorkflowExpression.Compile(reqConfigtableToInsertrightBorderSpace, nameof(reqConfigtableToInsertrightBorderSpace), required: false);
            var __workflow_reqConfigtableToInsertrightBorderType = WorkflowExpression.Compile(reqConfigtableToInsertrightBorderType, nameof(reqConfigtableToInsertrightBorderType), required: false);
            var __workflow_reqConfigtableToInsertstartBorderColor = WorkflowExpression.Compile(reqConfigtableToInsertstartBorderColor, nameof(reqConfigtableToInsertstartBorderColor), required: false);
            var __workflow_reqConfigtableToInsertstartBorderSize = WorkflowExpression.Compile(reqConfigtableToInsertstartBorderSize, nameof(reqConfigtableToInsertstartBorderSize), required: false);
            var __workflow_reqConfigtableToInsertstartBorderSpace = WorkflowExpression.Compile(reqConfigtableToInsertstartBorderSpace, nameof(reqConfigtableToInsertstartBorderSpace), required: false);
            var __workflow_reqConfigtableToInsertstartBorderType = WorkflowExpression.Compile(reqConfigtableToInsertstartBorderType, nameof(reqConfigtableToInsertstartBorderType), required: false);
            var __workflow_reqConfigtableToInserttableId = WorkflowExpression.Compile(reqConfigtableToInserttableId, nameof(reqConfigtableToInserttableId), required: false);
            var __workflow_reqConfigtableToInserttableIndentationMode = WorkflowExpression.Compile(reqConfigtableToInserttableIndentationMode, nameof(reqConfigtableToInserttableIndentationMode), required: false);
            var __workflow_reqConfigtableToInserttableIndentationWidth = WorkflowExpression.Compile(reqConfigtableToInserttableIndentationWidth, nameof(reqConfigtableToInserttableIndentationWidth), required: false);
            var __workflow_reqConfigtableToInserttableRows = WorkflowExpression.Compile(reqConfigtableToInserttableRows, nameof(reqConfigtableToInserttableRows), required: false);
            var __workflow_reqConfigtableToInserttopBorderColor = WorkflowExpression.Compile(reqConfigtableToInserttopBorderColor, nameof(reqConfigtableToInserttopBorderColor), required: false);
            var __workflow_reqConfigtableToInserttopBorderSize = WorkflowExpression.Compile(reqConfigtableToInserttopBorderSize, nameof(reqConfigtableToInserttopBorderSize), required: false);
            var __workflow_reqConfigtableToInserttopBorderSpace = WorkflowExpression.Compile(reqConfigtableToInserttopBorderSpace, nameof(reqConfigtableToInserttopBorderSpace), required: false);
            var __workflow_reqConfigtableToInserttopBorderType = WorkflowExpression.Compile(reqConfigtableToInserttopBorderType, nameof(reqConfigtableToInserttopBorderType), required: false);
            var __workflow_reqConfigtableToInsertwidth = WorkflowExpression.Compile(reqConfigtableToInsertwidth, nameof(reqConfigtableToInsertwidth), required: false);
            var __workflow_reqConfigtableToInsertwidthType = WorkflowExpression.Compile(reqConfigtableToInsertwidthType, nameof(reqConfigtableToInsertwidthType), required: false);
            return new DeferredBodyAction<InsertDocxTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-table";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginsertPath != null)
                {
                    reqConfig["InsertPath"] = ExpressionConverter.ConvertO(__workflow_reqConfiginsertPath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(__workflow_reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                var tableToInsertObject = new JObject();
                var tableToInsertObjectpropCount = 0;
                if (__workflow_reqConfigtableToInsertbottomBorderColor != null)
                {
                    tableToInsertObject["BottomBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertbottomBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertbottomBorderSize != null)
                {
                    tableToInsertObject["BottomBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertbottomBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertbottomBorderSpace != null)
                {
                    tableToInsertObject["BottomBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertbottomBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertbottomBorderType != null)
                {
                    tableToInsertObject["BottomBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertbottomBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellHorizontalBorderColor != null)
                {
                    tableToInsertObject["CellHorizontalBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellHorizontalBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellHorizontalBorderSize != null)
                {
                    tableToInsertObject["CellHorizontalBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellHorizontalBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellHorizontalBorderSpace != null)
                {
                    tableToInsertObject["CellHorizontalBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellHorizontalBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellHorizontalBorderType != null)
                {
                    tableToInsertObject["CellHorizontalBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellHorizontalBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellVerticalBorderColor != null)
                {
                    tableToInsertObject["CellVerticalBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellVerticalBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellVerticalBorderSize != null)
                {
                    tableToInsertObject["CellVerticalBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellVerticalBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellVerticalBorderSpace != null)
                {
                    tableToInsertObject["CellVerticalBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellVerticalBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertcellVerticalBorderType != null)
                {
                    tableToInsertObject["CellVerticalBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertcellVerticalBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertendBorderColor != null)
                {
                    tableToInsertObject["EndBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertendBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertendBorderSize != null)
                {
                    tableToInsertObject["EndBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertendBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertendBorderSpace != null)
                {
                    tableToInsertObject["EndBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertendBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertendBorderType != null)
                {
                    tableToInsertObject["EndBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertendBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertleftBorderColor != null)
                {
                    tableToInsertObject["LeftBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertleftBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertleftBorderSize != null)
                {
                    tableToInsertObject["LeftBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertleftBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertleftBorderSpace != null)
                {
                    tableToInsertObject["LeftBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertleftBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertleftBorderType != null)
                {
                    tableToInsertObject["LeftBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertleftBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertpath != null)
                {
                    tableToInsertObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertpath);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertrightBorderColor != null)
                {
                    tableToInsertObject["RightBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertrightBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertrightBorderSize != null)
                {
                    tableToInsertObject["RightBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertrightBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertrightBorderSpace != null)
                {
                    tableToInsertObject["RightBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertrightBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertrightBorderType != null)
                {
                    tableToInsertObject["RightBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertrightBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertstartBorderColor != null)
                {
                    tableToInsertObject["StartBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertstartBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertstartBorderSize != null)
                {
                    tableToInsertObject["StartBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertstartBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertstartBorderSpace != null)
                {
                    tableToInsertObject["StartBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertstartBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertstartBorderType != null)
                {
                    tableToInsertObject["StartBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertstartBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttableId != null)
                {
                    tableToInsertObject["TableID"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttableId);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttableIndentationMode != null)
                {
                    tableToInsertObject["TableIndentationMode"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttableIndentationMode);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttableIndentationWidth != null)
                {
                    tableToInsertObject["TableIndentationWidth"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttableIndentationWidth);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttableRows != null)
                {
                    tableToInsertObject["TableRows"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttableRows);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttopBorderColor != null)
                {
                    tableToInsertObject["TopBorderColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttopBorderColor);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttopBorderSize != null)
                {
                    tableToInsertObject["TopBorderSize"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttopBorderSize);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttopBorderSpace != null)
                {
                    tableToInsertObject["TopBorderSpace"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttopBorderSpace);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInserttopBorderType != null)
                {
                    tableToInsertObject["TopBorderType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInserttopBorderType);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertwidth != null)
                {
                    tableToInsertObject["Width"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertwidth);
                    tableToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigtableToInsertwidthType != null)
                {
                    tableToInsertObject["WidthType"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableToInsertwidthType);
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

                return new ApiConnectionAction<InsertDocxTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxInsertTableRow(Expression<Func<string>> reqConfigexistingTablePath = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfiginsertPlacement = null, Expression<Func<string>> reqConfigrowToInsertpath = null, Expression<Func<DocxTableCell[]>> reqConfigrowToInsertrowCells = null, Expression<Func<int>> reqConfigrowToInsertrowIndex = null)
        {
            var __workflow_reqConfigexistingTablePath = WorkflowExpression.Compile(reqConfigexistingTablePath, nameof(reqConfigexistingTablePath), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfiginsertPlacement = WorkflowExpression.Compile(reqConfiginsertPlacement, nameof(reqConfiginsertPlacement), required: false);
            var __workflow_reqConfigrowToInsertpath = WorkflowExpression.Compile(reqConfigrowToInsertpath, nameof(reqConfigrowToInsertpath), required: false);
            var __workflow_reqConfigrowToInsertrowCells = WorkflowExpression.Compile(reqConfigrowToInsertrowCells, nameof(reqConfigrowToInsertrowCells), required: false);
            var __workflow_reqConfigrowToInsertrowIndex = WorkflowExpression.Compile(reqConfigrowToInsertrowIndex, nameof(reqConfigrowToInsertrowIndex), required: false);
            return new DeferredBodyAction<InsertDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/insert-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfigexistingTablePath != null)
                {
                    reqConfig["ExistingTablePath"] = ExpressionConverter.ConvertO(__workflow_reqConfigexistingTablePath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginsertPlacement != null)
                {
                    reqConfig["InsertPlacement"] = ExpressionConverter.ConvertO(__workflow_reqConfiginsertPlacement);
                    reqConfigpropCount++;
                }

                var rowToInsertObject = new JObject();
                var rowToInsertObjectpropCount = 0;
                if (__workflow_reqConfigrowToInsertpath != null)
                {
                    rowToInsertObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigrowToInsertpath);
                    rowToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigrowToInsertrowCells != null)
                {
                    rowToInsertObject["RowCells"] = ExpressionConverter.ConvertO(__workflow_reqConfigrowToInsertrowCells);
                    rowToInsertObjectpropCount++;
                }

                if (__workflow_reqConfigrowToInsertrowIndex != null)
                {
                    rowToInsertObject["RowIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigrowToInsertrowIndex);
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

                return new ApiConnectionAction<InsertDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<RemoveDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration> EditDocumentDocxRemoveHeadersAndFooters(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<bool>> reqConfigremoveFooters = null, Expression<Func<bool>> reqConfigremoveHeaders = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigremoveFooters = WorkflowExpression.Compile(reqConfigremoveFooters, nameof(reqConfigremoveFooters), required: false);
            var __workflow_reqConfigremoveHeaders = WorkflowExpression.Compile(reqConfigremoveHeaders, nameof(reqConfigremoveHeaders), required: false);
            return new DeferredBodyAction<RemoveDocxHeadersAndFootersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/remove-headers-and-footers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigremoveFooters != null)
                {
                    reqConfig["RemoveFooters"] = ExpressionConverter.ConvertO(__workflow_reqConfigremoveFooters);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigremoveHeaders != null)
                {
                    reqConfig["RemoveHeaders"] = ExpressionConverter.ConvertO(__workflow_reqConfigremoveHeaders);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<RemoveDocxHeadersAndFootersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxRemoveObjectResponse, ApiConnectionActionConfiguration> EditDocumentDocxRemoveObject(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigpathToObjectToRemove = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigpathToObjectToRemove = WorkflowExpression.Compile(reqConfigpathToObjectToRemove, nameof(reqConfigpathToObjectToRemove), required: false);
            return new DeferredBodyAction<DocxRemoveObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/remove-object";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigpathToObjectToRemove != null)
                {
                    reqConfig["PathToObjectToRemove"] = ExpressionConverter.ConvertO(__workflow_reqConfigpathToObjectToRemove);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<DocxRemoveObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentDocxReplace(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<bool>> reqConfigmatchCase = null, Expression<Func<string>> reqConfigmatchString = null, Expression<Func<string>> reqConfigreplaceString = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigmatchCase = WorkflowExpression.Compile(reqConfigmatchCase, nameof(reqConfigmatchCase), required: false);
            var __workflow_reqConfigmatchString = WorkflowExpression.Compile(reqConfigmatchString, nameof(reqConfigmatchString), required: false);
            var __workflow_reqConfigreplaceString = WorkflowExpression.Compile(reqConfigreplaceString, nameof(reqConfigreplaceString), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/replace-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigmatchCase != null)
                {
                    reqConfig["MatchCase"] = ExpressionConverter.ConvertO(__workflow_reqConfigmatchCase);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigmatchString != null)
                {
                    reqConfig["MatchString"] = ExpressionConverter.ConvertO(__workflow_reqConfigmatchString);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigreplaceString != null)
                {
                    reqConfig["ReplaceString"] = ExpressionConverter.ConvertO(__workflow_reqConfigreplaceString);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse, ApiConnectionActionConfiguration> EditDocumentDocxSetFooter(Expression<Func<DocxParagraph[]>> reqConfigfooterToApplyparagraphs = null, Expression<Func<string>> reqConfigfooterToApplypath = null, Expression<Func<DocxSection[]>> reqConfigfooterToApplysectionsWithFooter = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfigfooterToApplyparagraphs = WorkflowExpression.Compile(reqConfigfooterToApplyparagraphs, nameof(reqConfigfooterToApplyparagraphs), required: false);
            var __workflow_reqConfigfooterToApplypath = WorkflowExpression.Compile(reqConfigfooterToApplypath, nameof(reqConfigfooterToApplypath), required: false);
            var __workflow_reqConfigfooterToApplysectionsWithFooter = WorkflowExpression.Compile(reqConfigfooterToApplysectionsWithFooter, nameof(reqConfigfooterToApplysectionsWithFooter), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<DocxSetFooterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/set-footer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var footerToApplyObject = new JObject();
                var footerToApplyObjectpropCount = 0;
                if (__workflow_reqConfigfooterToApplyparagraphs != null)
                {
                    footerToApplyObject["Paragraphs"] = ExpressionConverter.ConvertO(__workflow_reqConfigfooterToApplyparagraphs);
                    footerToApplyObjectpropCount++;
                }

                if (__workflow_reqConfigfooterToApplypath != null)
                {
                    footerToApplyObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigfooterToApplypath);
                    footerToApplyObjectpropCount++;
                }

                if (__workflow_reqConfigfooterToApplysectionsWithFooter != null)
                {
                    footerToApplyObject["SectionsWithFooter"] = ExpressionConverter.ConvertO(__workflow_reqConfigfooterToApplysectionsWithFooter);
                    footerToApplyObjectpropCount++;
                }

                if (footerToApplyObjectpropCount > 0)
                {
                    reqConfig["FooterToApply"] = footerToApplyObject;
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<DocxSetFooterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetFooterResponse, ApiConnectionActionConfiguration> EditDocumentDocxSetFooterAddPageNumber(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigprependText = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigprependText = WorkflowExpression.Compile(reqConfigprependText, nameof(reqConfigprependText), required: false);
            return new DeferredBodyAction<DocxSetFooterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/set-footer/add-page-number";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigprependText != null)
                {
                    reqConfig["PrependText"] = ExpressionConverter.ConvertO(__workflow_reqConfigprependText);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<DocxSetFooterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<DocxSetHeaderResponse, ApiConnectionActionConfiguration> EditDocumentDocxSetHeader(Expression<Func<DocxParagraph[]>> reqConfigheaderToApplyparagraphs = null, Expression<Func<string>> reqConfigheaderToApplypath = null, Expression<Func<DocxSection[]>> reqConfigheaderToApplysectionsWithHeader = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfigheaderToApplyparagraphs = WorkflowExpression.Compile(reqConfigheaderToApplyparagraphs, nameof(reqConfigheaderToApplyparagraphs), required: false);
            var __workflow_reqConfigheaderToApplypath = WorkflowExpression.Compile(reqConfigheaderToApplypath, nameof(reqConfigheaderToApplypath), required: false);
            var __workflow_reqConfigheaderToApplysectionsWithHeader = WorkflowExpression.Compile(reqConfigheaderToApplysectionsWithHeader, nameof(reqConfigheaderToApplysectionsWithHeader), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<DocxSetHeaderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/set-header";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var headerToApplyObject = new JObject();
                var headerToApplyObjectpropCount = 0;
                if (__workflow_reqConfigheaderToApplyparagraphs != null)
                {
                    headerToApplyObject["Paragraphs"] = ExpressionConverter.ConvertO(__workflow_reqConfigheaderToApplyparagraphs);
                    headerToApplyObjectpropCount++;
                }

                if (__workflow_reqConfigheaderToApplypath != null)
                {
                    headerToApplyObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigheaderToApplypath);
                    headerToApplyObjectpropCount++;
                }

                if (__workflow_reqConfigheaderToApplysectionsWithHeader != null)
                {
                    headerToApplyObject["SectionsWithHeader"] = ExpressionConverter.ConvertO(__workflow_reqConfigheaderToApplysectionsWithHeader);
                    headerToApplyObjectpropCount++;
                }

                if (headerToApplyObjectpropCount > 0)
                {
                    reqConfig["HeaderToApply"] = headerToApplyObject;
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<DocxSetHeaderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableCellResponse, ApiConnectionActionConfiguration> EditDocumentDocxUpdateTableCell(Expression<Func<int>> reqConfigcellToUpdatecellIndex = null, Expression<Func<string>> reqConfigcellToUpdatecellShadingColor = null, Expression<Func<string>> reqConfigcellToUpdatecellShadingFill = null, Expression<Func<string>> reqConfigcellToUpdatecellShadingPattern = null, Expression<Func<string>> reqConfigcellToUpdatecellWidth = null, Expression<Func<string>> reqConfigcellToUpdatecellWidthMode = null, Expression<Func<DocxParagraph[]>> reqConfigcellToUpdateparagraphs = null, Expression<Func<string>> reqConfigcellToUpdatepath = null, Expression<Func<string>> reqConfigexistingTablePath = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<int>> reqConfigtableCellIndex = null, Expression<Func<int>> reqConfigtableRowIndex = null)
        {
            var __workflow_reqConfigcellToUpdatecellIndex = WorkflowExpression.Compile(reqConfigcellToUpdatecellIndex, nameof(reqConfigcellToUpdatecellIndex), required: false);
            var __workflow_reqConfigcellToUpdatecellShadingColor = WorkflowExpression.Compile(reqConfigcellToUpdatecellShadingColor, nameof(reqConfigcellToUpdatecellShadingColor), required: false);
            var __workflow_reqConfigcellToUpdatecellShadingFill = WorkflowExpression.Compile(reqConfigcellToUpdatecellShadingFill, nameof(reqConfigcellToUpdatecellShadingFill), required: false);
            var __workflow_reqConfigcellToUpdatecellShadingPattern = WorkflowExpression.Compile(reqConfigcellToUpdatecellShadingPattern, nameof(reqConfigcellToUpdatecellShadingPattern), required: false);
            var __workflow_reqConfigcellToUpdatecellWidth = WorkflowExpression.Compile(reqConfigcellToUpdatecellWidth, nameof(reqConfigcellToUpdatecellWidth), required: false);
            var __workflow_reqConfigcellToUpdatecellWidthMode = WorkflowExpression.Compile(reqConfigcellToUpdatecellWidthMode, nameof(reqConfigcellToUpdatecellWidthMode), required: false);
            var __workflow_reqConfigcellToUpdateparagraphs = WorkflowExpression.Compile(reqConfigcellToUpdateparagraphs, nameof(reqConfigcellToUpdateparagraphs), required: false);
            var __workflow_reqConfigcellToUpdatepath = WorkflowExpression.Compile(reqConfigcellToUpdatepath, nameof(reqConfigcellToUpdatepath), required: false);
            var __workflow_reqConfigexistingTablePath = WorkflowExpression.Compile(reqConfigexistingTablePath, nameof(reqConfigexistingTablePath), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigtableCellIndex = WorkflowExpression.Compile(reqConfigtableCellIndex, nameof(reqConfigtableCellIndex), required: false);
            var __workflow_reqConfigtableRowIndex = WorkflowExpression.Compile(reqConfigtableRowIndex, nameof(reqConfigtableRowIndex), required: false);
            return new DeferredBodyAction<UpdateDocxTableCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/update-table-cell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                var cellToUpdateObject = new JObject();
                var cellToUpdateObjectpropCount = 0;
                if (__workflow_reqConfigcellToUpdatecellIndex != null)
                {
                    cellToUpdateObject["CellIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdatecellIndex);
                    cellToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigcellToUpdatecellShadingColor != null)
                {
                    cellToUpdateObject["CellShadingColor"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdatecellShadingColor);
                    cellToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigcellToUpdatecellShadingFill != null)
                {
                    cellToUpdateObject["CellShadingFill"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdatecellShadingFill);
                    cellToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigcellToUpdatecellShadingPattern != null)
                {
                    cellToUpdateObject["CellShadingPattern"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdatecellShadingPattern);
                    cellToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigcellToUpdatecellWidth != null)
                {
                    cellToUpdateObject["CellWidth"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdatecellWidth);
                    cellToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigcellToUpdatecellWidthMode != null)
                {
                    cellToUpdateObject["CellWidthMode"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdatecellWidthMode);
                    cellToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigcellToUpdateparagraphs != null)
                {
                    cellToUpdateObject["Paragraphs"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdateparagraphs);
                    cellToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigcellToUpdatepath != null)
                {
                    cellToUpdateObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigcellToUpdatepath);
                    cellToUpdateObjectpropCount++;
                }

                if (cellToUpdateObjectpropCount > 0)
                {
                    reqConfig["CellToUpdate"] = cellToUpdateObject;
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigexistingTablePath != null)
                {
                    reqConfig["ExistingTablePath"] = ExpressionConverter.ConvertO(__workflow_reqConfigexistingTablePath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableCellIndex != null)
                {
                    reqConfig["TableCellIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableCellIndex);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableRowIndex != null)
                {
                    reqConfig["TableRowIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<UpdateDocxTableCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UpdateDocxTableRowResponse, ApiConnectionActionConfiguration> EditDocumentDocxUpdateTableRow(Expression<Func<string>> reqConfigexistingTablePath = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigrowToUpdatepath = null, Expression<Func<DocxTableCell[]>> reqConfigrowToUpdaterowCells = null, Expression<Func<int>> reqConfigrowToUpdaterowIndex = null, Expression<Func<int>> reqConfigtableRowIndex = null)
        {
            var __workflow_reqConfigexistingTablePath = WorkflowExpression.Compile(reqConfigexistingTablePath, nameof(reqConfigexistingTablePath), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigrowToUpdatepath = WorkflowExpression.Compile(reqConfigrowToUpdatepath, nameof(reqConfigrowToUpdatepath), required: false);
            var __workflow_reqConfigrowToUpdaterowCells = WorkflowExpression.Compile(reqConfigrowToUpdaterowCells, nameof(reqConfigrowToUpdaterowCells), required: false);
            var __workflow_reqConfigrowToUpdaterowIndex = WorkflowExpression.Compile(reqConfigrowToUpdaterowIndex, nameof(reqConfigrowToUpdaterowIndex), required: false);
            var __workflow_reqConfigtableRowIndex = WorkflowExpression.Compile(reqConfigtableRowIndex, nameof(reqConfigtableRowIndex), required: false);
            return new DeferredBodyAction<UpdateDocxTableRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/docx/update-table-row";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfigexistingTablePath != null)
                {
                    reqConfig["ExistingTablePath"] = ExpressionConverter.ConvertO(__workflow_reqConfigexistingTablePath);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                var rowToUpdateObject = new JObject();
                var rowToUpdateObjectpropCount = 0;
                if (__workflow_reqConfigrowToUpdatepath != null)
                {
                    rowToUpdateObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigrowToUpdatepath);
                    rowToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigrowToUpdaterowCells != null)
                {
                    rowToUpdateObject["RowCells"] = ExpressionConverter.ConvertO(__workflow_reqConfigrowToUpdaterowCells);
                    rowToUpdateObjectpropCount++;
                }

                if (__workflow_reqConfigrowToUpdaterowIndex != null)
                {
                    rowToUpdateObject["RowIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigrowToUpdaterowIndex);
                    rowToUpdateObjectpropCount++;
                }

                if (rowToUpdateObjectpropCount > 0)
                {
                    reqConfig["RowToUpdate"] = rowToUpdateObject;
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigtableRowIndex != null)
                {
                    reqConfig["TableRowIndex"] = ExpressionConverter.ConvertO(__workflow_reqConfigtableRowIndex);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<UpdateDocxTableRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentFinishEditing(Expression<Func<string>> reqConfiginputFileUrl = null)
        {
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/finish-editing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentPptxDeleteSlides(Expression<Func<int>> reqConfigendDeleteSlideNumber = null, Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<int>> reqConfigstartDeleteSlideNumber = null)
        {
            var __workflow_reqConfigendDeleteSlideNumber = WorkflowExpression.Compile(reqConfigendDeleteSlideNumber, nameof(reqConfigendDeleteSlideNumber), required: false);
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigstartDeleteSlideNumber = WorkflowExpression.Compile(reqConfigstartDeleteSlideNumber, nameof(reqConfigstartDeleteSlideNumber), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/pptx/delete-slides";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfigendDeleteSlideNumber != null)
                {
                    reqConfig["EndDeleteSlideNumber"] = ExpressionConverter.ConvertO(__workflow_reqConfigendDeleteSlideNumber);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigstartDeleteSlideNumber != null)
                {
                    reqConfig["StartDeleteSlideNumber"] = ExpressionConverter.ConvertO(__workflow_reqConfigstartDeleteSlideNumber);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> EditDocumentPptxReplace(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<bool>> reqConfigmatchCase = null, Expression<Func<string>> reqConfigmatchString = null, Expression<Func<string>> reqConfigreplaceString = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigmatchCase = WorkflowExpression.Compile(reqConfigmatchCase, nameof(reqConfigmatchCase), required: false);
            var __workflow_reqConfigmatchString = WorkflowExpression.Compile(reqConfigmatchString, nameof(reqConfigmatchString), required: false);
            var __workflow_reqConfigreplaceString = WorkflowExpression.Compile(reqConfigreplaceString, nameof(reqConfigreplaceString), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/pptx/replace-all";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigmatchCase != null)
                {
                    reqConfig["MatchCase"] = ExpressionConverter.ConvertO(__workflow_reqConfigmatchCase);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigmatchString != null)
                {
                    reqConfig["MatchString"] = ExpressionConverter.ConvertO(__workflow_reqConfigmatchString);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfigreplaceString != null)
                {
                    reqConfig["ReplaceString"] = ExpressionConverter.ConvertO(__workflow_reqConfigreplaceString);
                    reqConfigpropCount++;
                }

                if (reqConfigpropCount > 0)
                {
                    callPayload.Body = reqConfig;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<ClearXlsxCellResponse, ApiConnectionActionConfiguration> EditDocumentXlsxClearCellByIndex(Expression<Func<int>> inputcellIndex = null, Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<int>> inputrowIndex = null, Expression<Func<string>> inputworksheetToUpdatepath = null, Expression<Func<string>> inputworksheetToUpdateworksheetName = null)
        {
            var __workflow_inputcellIndex = WorkflowExpression.Compile(inputcellIndex, nameof(inputcellIndex), required: false);
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputrowIndex = WorkflowExpression.Compile(inputrowIndex, nameof(inputrowIndex), required: false);
            var __workflow_inputworksheetToUpdatepath = WorkflowExpression.Compile(inputworksheetToUpdatepath, nameof(inputworksheetToUpdatepath), required: false);
            var __workflow_inputworksheetToUpdateworksheetName = WorkflowExpression.Compile(inputworksheetToUpdateworksheetName, nameof(inputworksheetToUpdateworksheetName), required: false);
            return new DeferredBodyAction<ClearXlsxCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/clear-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputcellIndex != null)
                {
                    input["CellIndex"] = ExpressionConverter.ConvertO(__workflow_inputcellIndex);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                if (__workflow_inputrowIndex != null)
                {
                    input["RowIndex"] = ExpressionConverter.ConvertO(__workflow_inputrowIndex);
                    inputpropCount++;
                }

                var worksheetToUpdateObject = new JObject();
                var worksheetToUpdateObjectpropCount = 0;
                if (__workflow_inputworksheetToUpdatepath != null)
                {
                    worksheetToUpdateObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToUpdatepath);
                    worksheetToUpdateObjectpropCount++;
                }

                if (__workflow_inputworksheetToUpdateworksheetName != null)
                {
                    worksheetToUpdateObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToUpdateworksheetName);
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

                return new ApiConnectionAction<ClearXlsxCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateBlankSpreadsheetResponse, ApiConnectionActionConfiguration> EditDocumentXlsxCreateBlankSpreadsheet(Expression<Func<string>> inputworksheetName = null)
        {
            var __workflow_inputworksheetName = WorkflowExpression.Compile(inputworksheetName, nameof(inputworksheetName), required: false);
            return new DeferredBodyAction<CreateBlankSpreadsheetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/create/blank";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputworksheetName != null)
                {
                    input["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetName);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<CreateBlankSpreadsheetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<CreateSpreadsheetFromDataResponse, ApiConnectionActionConfiguration> EditDocumentXlsxCreateSpreadsheetFromData(Expression<Func<XlsxSpreadsheetRow[]>> inputrows = null, Expression<Func<string>> inputworksheetName = null)
        {
            var __workflow_inputrows = WorkflowExpression.Compile(inputrows, nameof(inputrows), required: false);
            var __workflow_inputworksheetName = WorkflowExpression.Compile(inputworksheetName, nameof(inputworksheetName), required: false);
            return new DeferredBodyAction<CreateSpreadsheetFromDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/create/from/data";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputrows != null)
                {
                    input["Rows"] = ExpressionConverter.ConvertO(__workflow_inputrows);
                    inputpropCount++;
                }

                if (__workflow_inputworksheetName != null)
                {
                    input["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetName);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<CreateSpreadsheetFromDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EditDocumentXlsxDeleteWorksheet(Expression<Func<string>> reqConfiginputFileBytes = null, Expression<Func<string>> reqConfiginputFileUrl = null, Expression<Func<string>> reqConfigworksheetToRemovepath = null, Expression<Func<string>> reqConfigworksheetToRemoveworksheetName = null)
        {
            var __workflow_reqConfiginputFileBytes = WorkflowExpression.Compile(reqConfiginputFileBytes, nameof(reqConfiginputFileBytes), required: false);
            var __workflow_reqConfiginputFileUrl = WorkflowExpression.Compile(reqConfiginputFileUrl, nameof(reqConfiginputFileUrl), required: false);
            var __workflow_reqConfigworksheetToRemovepath = WorkflowExpression.Compile(reqConfigworksheetToRemovepath, nameof(reqConfigworksheetToRemovepath), required: false);
            var __workflow_reqConfigworksheetToRemoveworksheetName = WorkflowExpression.Compile(reqConfigworksheetToRemoveworksheetName, nameof(reqConfigworksheetToRemoveworksheetName), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/delete-worksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var reqConfig = new JObject();
                var reqConfigpropCount = 0;
                if (__workflow_reqConfiginputFileBytes != null)
                {
                    reqConfig["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileBytes);
                    reqConfigpropCount++;
                }

                if (__workflow_reqConfiginputFileUrl != null)
                {
                    reqConfig["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_reqConfiginputFileUrl);
                    reqConfigpropCount++;
                }

                var worksheetToRemoveObject = new JObject();
                var worksheetToRemoveObjectpropCount = 0;
                if (__workflow_reqConfigworksheetToRemovepath != null)
                {
                    worksheetToRemoveObject["Path"] = ExpressionConverter.ConvertO(__workflow_reqConfigworksheetToRemovepath);
                    worksheetToRemoveObjectpropCount++;
                }

                if (__workflow_reqConfigworksheetToRemoveworksheetName != null)
                {
                    worksheetToRemoveObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_reqConfigworksheetToRemoveworksheetName);
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

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetCellByIdentifier(Expression<Func<string>> inputcellIdentifier = null, Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<string>> inputworksheetToQuerypath = null, Expression<Func<string>> inputworksheetToQueryworksheetName = null)
        {
            var __workflow_inputcellIdentifier = WorkflowExpression.Compile(inputcellIdentifier, nameof(inputcellIdentifier), required: false);
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputworksheetToQuerypath = WorkflowExpression.Compile(inputworksheetToQuerypath, nameof(inputworksheetToQuerypath), required: false);
            var __workflow_inputworksheetToQueryworksheetName = WorkflowExpression.Compile(inputworksheetToQueryworksheetName, nameof(inputworksheetToQueryworksheetName), required: false);
            return new DeferredBodyAction<GetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-cell/by-identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputcellIdentifier != null)
                {
                    input["CellIdentifier"] = ExpressionConverter.ConvertO(__workflow_inputcellIdentifier);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (__workflow_inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (__workflow_inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQueryworksheetName);
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

                return new ApiConnectionAction<GetXlsxCellByIdentifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxCellResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetCellByIndex(Expression<Func<int>> inputcellIndex = null, Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<int>> inputrowIndex = null, Expression<Func<string>> inputworksheetToQuerypath = null, Expression<Func<string>> inputworksheetToQueryworksheetName = null)
        {
            var __workflow_inputcellIndex = WorkflowExpression.Compile(inputcellIndex, nameof(inputcellIndex), required: false);
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputrowIndex = WorkflowExpression.Compile(inputrowIndex, nameof(inputrowIndex), required: false);
            var __workflow_inputworksheetToQuerypath = WorkflowExpression.Compile(inputworksheetToQuerypath, nameof(inputworksheetToQuerypath), required: false);
            var __workflow_inputworksheetToQueryworksheetName = WorkflowExpression.Compile(inputworksheetToQueryworksheetName, nameof(inputworksheetToQueryworksheetName), required: false);
            return new DeferredBodyAction<GetXlsxCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputcellIndex != null)
                {
                    input["CellIndex"] = ExpressionConverter.ConvertO(__workflow_inputcellIndex);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                if (__workflow_inputrowIndex != null)
                {
                    input["RowIndex"] = ExpressionConverter.ConvertO(__workflow_inputrowIndex);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (__workflow_inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (__workflow_inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQueryworksheetName);
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

                return new ApiConnectionAction<GetXlsxCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxColumnsResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetColumns(Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<string>> inputworksheetToQuerypath = null, Expression<Func<string>> inputworksheetToQueryworksheetName = null)
        {
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputworksheetToQuerypath = WorkflowExpression.Compile(inputworksheetToQuerypath, nameof(inputworksheetToQuerypath), required: false);
            var __workflow_inputworksheetToQueryworksheetName = WorkflowExpression.Compile(inputworksheetToQueryworksheetName, nameof(inputworksheetToQueryworksheetName), required: false);
            return new DeferredBodyAction<GetXlsxColumnsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-columns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (__workflow_inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (__workflow_inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQueryworksheetName);
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

                return new ApiConnectionAction<GetXlsxColumnsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxImagesResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetImages(Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<string>> inputworksheetToQuerypath = null, Expression<Func<string>> inputworksheetToQueryworksheetName = null)
        {
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputworksheetToQuerypath = WorkflowExpression.Compile(inputworksheetToQuerypath, nameof(inputworksheetToQuerypath), required: false);
            var __workflow_inputworksheetToQueryworksheetName = WorkflowExpression.Compile(inputworksheetToQueryworksheetName, nameof(inputworksheetToQueryworksheetName), required: false);
            return new DeferredBodyAction<GetXlsxImagesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-images";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (__workflow_inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (__workflow_inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQueryworksheetName);
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

                return new ApiConnectionAction<GetXlsxImagesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxRowsAndCellsResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetRowsAndCells(Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<string>> inputworksheetToQuerypath = null, Expression<Func<string>> inputworksheetToQueryworksheetName = null)
        {
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputworksheetToQuerypath = WorkflowExpression.Compile(inputworksheetToQuerypath, nameof(inputworksheetToQuerypath), required: false);
            var __workflow_inputworksheetToQueryworksheetName = WorkflowExpression.Compile(inputworksheetToQueryworksheetName, nameof(inputworksheetToQueryworksheetName), required: false);
            return new DeferredBodyAction<GetXlsxRowsAndCellsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-rows-and-cells";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToQueryObject = new JObject();
                var worksheetToQueryObjectpropCount = 0;
                if (__workflow_inputworksheetToQuerypath != null)
                {
                    worksheetToQueryObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQuerypath);
                    worksheetToQueryObjectpropCount++;
                }

                if (__workflow_inputworksheetToQueryworksheetName != null)
                {
                    worksheetToQueryObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToQueryworksheetName);
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

                return new ApiConnectionAction<GetXlsxRowsAndCellsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxStylesResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetStyles(Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null)
        {
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            return new DeferredBodyAction<GetXlsxStylesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-styles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<GetXlsxStylesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<GetXlsxWorksheetsResponse, ApiConnectionActionConfiguration> EditDocumentXlsxGetWorksheets(Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null)
        {
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            return new DeferredBodyAction<GetXlsxWorksheetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/get-worksheets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<GetXlsxWorksheetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<InsertXlsxWorksheetResponse, ApiConnectionActionConfiguration> EditDocumentXlsxInsertWorksheet(Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<string>> inputworksheetToInsertpath = null, Expression<Func<string>> inputworksheetToInsertworksheetName = null)
        {
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputworksheetToInsertpath = WorkflowExpression.Compile(inputworksheetToInsertpath, nameof(inputworksheetToInsertpath), required: false);
            var __workflow_inputworksheetToInsertworksheetName = WorkflowExpression.Compile(inputworksheetToInsertworksheetName, nameof(inputworksheetToInsertworksheetName), required: false);
            return new DeferredBodyAction<InsertXlsxWorksheetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/insert-worksheet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToInsertObject = new JObject();
                var worksheetToInsertObjectpropCount = 0;
                if (__workflow_inputworksheetToInsertpath != null)
                {
                    worksheetToInsertObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToInsertpath);
                    worksheetToInsertObjectpropCount++;
                }

                if (__workflow_inputworksheetToInsertworksheetName != null)
                {
                    worksheetToInsertObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToInsertworksheetName);
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

                return new ApiConnectionAction<InsertXlsxWorksheetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration> EditDocumentXlsxSetCellByIdentifier(Expression<Func<string>> inputcellIdentifier = null, Expression<Func<string>> inputcellValuecellIdentifier = null, Expression<Func<string>> inputcellValueformula = null, Expression<Func<string>> inputcellValuepath = null, Expression<Func<int>> inputcellValuestyleIndex = null, Expression<Func<string>> inputcellValuetextValue = null, Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<string>> inputworksheetToUpdatepath = null, Expression<Func<string>> inputworksheetToUpdateworksheetName = null)
        {
            var __workflow_inputcellIdentifier = WorkflowExpression.Compile(inputcellIdentifier, nameof(inputcellIdentifier), required: false);
            var __workflow_inputcellValuecellIdentifier = WorkflowExpression.Compile(inputcellValuecellIdentifier, nameof(inputcellValuecellIdentifier), required: false);
            var __workflow_inputcellValueformula = WorkflowExpression.Compile(inputcellValueformula, nameof(inputcellValueformula), required: false);
            var __workflow_inputcellValuepath = WorkflowExpression.Compile(inputcellValuepath, nameof(inputcellValuepath), required: false);
            var __workflow_inputcellValuestyleIndex = WorkflowExpression.Compile(inputcellValuestyleIndex, nameof(inputcellValuestyleIndex), required: false);
            var __workflow_inputcellValuetextValue = WorkflowExpression.Compile(inputcellValuetextValue, nameof(inputcellValuetextValue), required: false);
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputworksheetToUpdatepath = WorkflowExpression.Compile(inputworksheetToUpdatepath, nameof(inputworksheetToUpdatepath), required: false);
            var __workflow_inputworksheetToUpdateworksheetName = WorkflowExpression.Compile(inputworksheetToUpdateworksheetName, nameof(inputworksheetToUpdateworksheetName), required: false);
            return new DeferredBodyAction<SetXlsxCellByIdentifierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/set-cell/by-identifier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputcellIdentifier != null)
                {
                    input["CellIdentifier"] = ExpressionConverter.ConvertO(__workflow_inputcellIdentifier);
                    inputpropCount++;
                }

                var cellValueObject = new JObject();
                var cellValueObjectpropCount = 0;
                if (__workflow_inputcellValuecellIdentifier != null)
                {
                    cellValueObject["CellIdentifier"] = ExpressionConverter.ConvertO(__workflow_inputcellValuecellIdentifier);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValueformula != null)
                {
                    cellValueObject["Formula"] = ExpressionConverter.ConvertO(__workflow_inputcellValueformula);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValuepath != null)
                {
                    cellValueObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputcellValuepath);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValuestyleIndex != null)
                {
                    cellValueObject["StyleIndex"] = ExpressionConverter.ConvertO(__workflow_inputcellValuestyleIndex);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValuetextValue != null)
                {
                    cellValueObject["TextValue"] = ExpressionConverter.ConvertO(__workflow_inputcellValuetextValue);
                    cellValueObjectpropCount++;
                }

                if (cellValueObjectpropCount > 0)
                {
                    input["CellValue"] = cellValueObject;
                    inputpropCount++;
                }

                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                var worksheetToUpdateObject = new JObject();
                var worksheetToUpdateObjectpropCount = 0;
                if (__workflow_inputworksheetToUpdatepath != null)
                {
                    worksheetToUpdateObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToUpdatepath);
                    worksheetToUpdateObjectpropCount++;
                }

                if (__workflow_inputworksheetToUpdateworksheetName != null)
                {
                    worksheetToUpdateObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToUpdateworksheetName);
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

                return new ApiConnectionAction<SetXlsxCellByIdentifierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<SetXlsxCellResponse, ApiConnectionActionConfiguration> EditDocumentXlsxSetCellByIndex(Expression<Func<int>> inputcellIndex = null, Expression<Func<string>> inputcellValuecellIdentifier = null, Expression<Func<string>> inputcellValueformula = null, Expression<Func<string>> inputcellValuepath = null, Expression<Func<int>> inputcellValuestyleIndex = null, Expression<Func<string>> inputcellValuetextValue = null, Expression<Func<string>> inputinputFileBytes = null, Expression<Func<string>> inputinputFileUrl = null, Expression<Func<int>> inputrowIndex = null, Expression<Func<string>> inputworksheetToUpdatepath = null, Expression<Func<string>> inputworksheetToUpdateworksheetName = null)
        {
            var __workflow_inputcellIndex = WorkflowExpression.Compile(inputcellIndex, nameof(inputcellIndex), required: false);
            var __workflow_inputcellValuecellIdentifier = WorkflowExpression.Compile(inputcellValuecellIdentifier, nameof(inputcellValuecellIdentifier), required: false);
            var __workflow_inputcellValueformula = WorkflowExpression.Compile(inputcellValueformula, nameof(inputcellValueformula), required: false);
            var __workflow_inputcellValuepath = WorkflowExpression.Compile(inputcellValuepath, nameof(inputcellValuepath), required: false);
            var __workflow_inputcellValuestyleIndex = WorkflowExpression.Compile(inputcellValuestyleIndex, nameof(inputcellValuestyleIndex), required: false);
            var __workflow_inputcellValuetextValue = WorkflowExpression.Compile(inputcellValuetextValue, nameof(inputcellValuetextValue), required: false);
            var __workflow_inputinputFileBytes = WorkflowExpression.Compile(inputinputFileBytes, nameof(inputinputFileBytes), required: false);
            var __workflow_inputinputFileUrl = WorkflowExpression.Compile(inputinputFileUrl, nameof(inputinputFileUrl), required: false);
            var __workflow_inputrowIndex = WorkflowExpression.Compile(inputrowIndex, nameof(inputrowIndex), required: false);
            var __workflow_inputworksheetToUpdatepath = WorkflowExpression.Compile(inputworksheetToUpdatepath, nameof(inputworksheetToUpdatepath), required: false);
            var __workflow_inputworksheetToUpdateworksheetName = WorkflowExpression.Compile(inputworksheetToUpdateworksheetName, nameof(inputworksheetToUpdateworksheetName), required: false);
            return new DeferredBodyAction<SetXlsxCellResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/edit/xlsx/set-cell/by-index";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputcellIndex != null)
                {
                    input["CellIndex"] = ExpressionConverter.ConvertO(__workflow_inputcellIndex);
                    inputpropCount++;
                }

                var cellValueObject = new JObject();
                var cellValueObjectpropCount = 0;
                if (__workflow_inputcellValuecellIdentifier != null)
                {
                    cellValueObject["CellIdentifier"] = ExpressionConverter.ConvertO(__workflow_inputcellValuecellIdentifier);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValueformula != null)
                {
                    cellValueObject["Formula"] = ExpressionConverter.ConvertO(__workflow_inputcellValueformula);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValuepath != null)
                {
                    cellValueObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputcellValuepath);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValuestyleIndex != null)
                {
                    cellValueObject["StyleIndex"] = ExpressionConverter.ConvertO(__workflow_inputcellValuestyleIndex);
                    cellValueObjectpropCount++;
                }

                if (__workflow_inputcellValuetextValue != null)
                {
                    cellValueObject["TextValue"] = ExpressionConverter.ConvertO(__workflow_inputcellValuetextValue);
                    cellValueObjectpropCount++;
                }

                if (cellValueObjectpropCount > 0)
                {
                    input["CellValue"] = cellValueObject;
                    inputpropCount++;
                }

                if (__workflow_inputinputFileBytes != null)
                {
                    input["InputFileBytes"] = ExpressionConverter.ConvertO(__workflow_inputinputFileBytes);
                    inputpropCount++;
                }

                if (__workflow_inputinputFileUrl != null)
                {
                    input["InputFileUrl"] = ExpressionConverter.ConvertO(__workflow_inputinputFileUrl);
                    inputpropCount++;
                }

                if (__workflow_inputrowIndex != null)
                {
                    input["RowIndex"] = ExpressionConverter.ConvertO(__workflow_inputrowIndex);
                    inputpropCount++;
                }

                var worksheetToUpdateObject = new JObject();
                var worksheetToUpdateObjectpropCount = 0;
                if (__workflow_inputworksheetToUpdatepath != null)
                {
                    worksheetToUpdateObject["Path"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToUpdatepath);
                    worksheetToUpdateObjectpropCount++;
                }

                if (__workflow_inputworksheetToUpdateworksheetName != null)
                {
                    worksheetToUpdateObject["WorksheetName"] = ExpressionConverter.ConvertO(__workflow_inputworksheetToUpdateworksheetName);
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

                return new ApiConnectionAction<SetXlsxCellResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebHtmlToDocx(Expression<Func<string>> inputRequesthtml = null)
        {
            var __workflow_inputRequesthtml = WorkflowExpression.Compile(inputRequesthtml, nameof(inputRequesthtml), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/html/to/docx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var inputRequest = new JObject();
                var inputRequestpropCount = 0;
                if (__workflow_inputRequesthtml != null)
                {
                    inputRequest["Html"] = ExpressionConverter.ConvertO(__workflow_inputRequesthtml);
                    inputRequestpropCount++;
                }

                if (inputRequestpropCount > 0)
                {
                    callPayload.Body = inputRequest;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertDataJsonToXml()
        {
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlTemplateApplicationResponse, ApiConnectionActionConfiguration> ConvertTemplateApplyHtmlTemplate(Expression<Func<string>> valuehtmlTemplate = null, Expression<Func<string>> valuehtmlTemplateUrl = null, Expression<Func<HtmlTemplateOperation[]>> valueoperations = null)
        {
            var __workflow_valuehtmlTemplate = WorkflowExpression.Compile(valuehtmlTemplate, nameof(valuehtmlTemplate), required: false);
            var __workflow_valuehtmlTemplateUrl = WorkflowExpression.Compile(valuehtmlTemplateUrl, nameof(valuehtmlTemplateUrl), required: false);
            var __workflow_valueoperations = WorkflowExpression.Compile(valueoperations, nameof(valueoperations), required: false);
            return new DeferredBodyAction<HtmlTemplateApplicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/template/html/apply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var value = new JObject();
                var valuepropCount = 0;
                if (__workflow_valuehtmlTemplate != null)
                {
                    value["HtmlTemplate"] = ExpressionConverter.ConvertO(__workflow_valuehtmlTemplate);
                    valuepropCount++;
                }

                if (__workflow_valuehtmlTemplateUrl != null)
                {
                    value["HtmlTemplateUrl"] = ExpressionConverter.ConvertO(__workflow_valuehtmlTemplateUrl);
                    valuepropCount++;
                }

                if (__workflow_valueoperations != null)
                {
                    value["Operations"] = ExpressionConverter.ConvertO(__workflow_valueoperations);
                    valuepropCount++;
                }

                if (valuepropCount > 0)
                {
                    callPayload.Body = value;
                }

                return new ApiConnectionAction<HtmlTemplateApplicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebHtmlToPdf(Expression<Func<int>> inputextraLoadingWait = null, Expression<Func<string>> inputhtml = null)
        {
            var __workflow_inputextraLoadingWait = WorkflowExpression.Compile(inputextraLoadingWait, nameof(inputextraLoadingWait), required: false);
            var __workflow_inputhtml = WorkflowExpression.Compile(inputhtml, nameof(inputhtml), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/html/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(__workflow_inputextraLoadingWait);
                    inputpropCount++;
                }

                if (__workflow_inputhtml != null)
                {
                    input["Html"] = ExpressionConverter.ConvertO(__workflow_inputhtml);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ConvertWebHtmlToPng(Expression<Func<int>> inputextraLoadingWait = null, Expression<Func<string>> inputhtml = null, Expression<Func<int>> inputscreenshotHeight = null, Expression<Func<int>> inputscreenshotWidth = null)
        {
            var __workflow_inputextraLoadingWait = WorkflowExpression.Compile(inputextraLoadingWait, nameof(inputextraLoadingWait), required: false);
            var __workflow_inputhtml = WorkflowExpression.Compile(inputhtml, nameof(inputhtml), required: false);
            var __workflow_inputscreenshotHeight = WorkflowExpression.Compile(inputscreenshotHeight, nameof(inputscreenshotHeight), required: false);
            var __workflow_inputscreenshotWidth = WorkflowExpression.Compile(inputscreenshotWidth, nameof(inputscreenshotWidth), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/html/to/png";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(__workflow_inputextraLoadingWait);
                    inputpropCount++;
                }

                if (__workflow_inputhtml != null)
                {
                    input["Html"] = ExpressionConverter.ConvertO(__workflow_inputhtml);
                    inputpropCount++;
                }

                if (__workflow_inputscreenshotHeight != null)
                {
                    input["ScreenshotHeight"] = ExpressionConverter.ConvertO(__workflow_inputscreenshotHeight);
                    inputpropCount++;
                }

                if (__workflow_inputscreenshotWidth != null)
                {
                    input["ScreenshotWidth"] = ExpressionConverter.ConvertO(__workflow_inputscreenshotWidth);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<HtmlToTextResponse, ApiConnectionActionConfiguration> ConvertWebHtmlToTxt(Expression<Func<string>> inputhtml = null)
        {
            var __workflow_inputhtml = WorkflowExpression.Compile(inputhtml, nameof(inputhtml), required: false);
            return new DeferredBodyAction<HtmlToTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/html/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputhtml != null)
                {
                    input["Html"] = ExpressionConverter.ConvertO(__workflow_inputhtml);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<HtmlToTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebUrlToPdf(Expression<Func<int>> inputextraLoadingWait = null, Expression<Func<int>> inputscreenshotHeight = null, Expression<Func<int>> inputscreenshotWidth = null, Expression<Func<string>> inputurl = null)
        {
            var __workflow_inputextraLoadingWait = WorkflowExpression.Compile(inputextraLoadingWait, nameof(inputextraLoadingWait), required: false);
            var __workflow_inputscreenshotHeight = WorkflowExpression.Compile(inputscreenshotHeight, nameof(inputscreenshotHeight), required: false);
            var __workflow_inputscreenshotWidth = WorkflowExpression.Compile(inputscreenshotWidth, nameof(inputscreenshotWidth), required: false);
            var __workflow_inputurl = WorkflowExpression.Compile(inputurl, nameof(inputurl), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/url/to/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(__workflow_inputextraLoadingWait);
                    inputpropCount++;
                }

                if (__workflow_inputscreenshotHeight != null)
                {
                    input["ScreenshotHeight"] = ExpressionConverter.ConvertO(__workflow_inputscreenshotHeight);
                    inputpropCount++;
                }

                if (__workflow_inputscreenshotWidth != null)
                {
                    input["ScreenshotWidth"] = ExpressionConverter.ConvertO(__workflow_inputscreenshotWidth);
                    inputpropCount++;
                }

                if (__workflow_inputurl != null)
                {
                    input["Url"] = ExpressionConverter.ConvertO(__workflow_inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertWebUrlToScreenshot(Expression<Func<int>> inputextraLoadingWait = null, Expression<Func<int>> inputscreenshotHeight = null, Expression<Func<int>> inputscreenshotWidth = null, Expression<Func<string>> inputurl = null)
        {
            var __workflow_inputextraLoadingWait = WorkflowExpression.Compile(inputextraLoadingWait, nameof(inputextraLoadingWait), required: false);
            var __workflow_inputscreenshotHeight = WorkflowExpression.Compile(inputscreenshotHeight, nameof(inputscreenshotHeight), required: false);
            var __workflow_inputscreenshotWidth = WorkflowExpression.Compile(inputscreenshotWidth, nameof(inputscreenshotWidth), required: false);
            var __workflow_inputurl = WorkflowExpression.Compile(inputurl, nameof(inputurl), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/url/to/screenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputextraLoadingWait != null)
                {
                    input["ExtraLoadingWait"] = ExpressionConverter.ConvertO(__workflow_inputextraLoadingWait);
                    inputpropCount++;
                }

                if (__workflow_inputscreenshotHeight != null)
                {
                    input["ScreenshotHeight"] = ExpressionConverter.ConvertO(__workflow_inputscreenshotHeight);
                    inputpropCount++;
                }

                if (__workflow_inputscreenshotWidth != null)
                {
                    input["ScreenshotWidth"] = ExpressionConverter.ConvertO(__workflow_inputscreenshotWidth);
                    inputpropCount++;
                }

                if (__workflow_inputurl != null)
                {
                    input["Url"] = ExpressionConverter.ConvertO(__workflow_inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudmersiveconvert")]
        public IBodyWorkflowAction<UrlToTextResponse, ApiConnectionActionConfiguration> ConvertWebUrlToTxt(Expression<Func<string>> inputurl = null)
        {
            var __workflow_inputurl = WorkflowExpression.Compile(inputurl, nameof(inputurl), required: false);
            return new DeferredBodyAction<UrlToTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/convert/web/url/to/txt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var input = new JObject();
                var inputpropCount = 0;
                if (__workflow_inputurl != null)
                {
                    input["Url"] = ExpressionConverter.ConvertO(__workflow_inputurl);
                    inputpropCount++;
                }

                if (inputpropCount > 0)
                {
                    callPayload.Body = input;
                }

                return new ApiConnectionAction<UrlToTextResponse>(callPayload);
            });
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

        [JsonProperty("StyleID")]
        public string StyleId { get; set; }
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

        [JsonProperty("TableID")]
        public string TableId { get; set; }
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

        [JsonProperty("StyleID")]
        public string StyleId { get; set; }
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
        [JsonProperty("BuiltInID")]
        public int BuiltInId { get; set; }

        [JsonProperty("FormatID")]
        public int FormatId { get; set; }
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