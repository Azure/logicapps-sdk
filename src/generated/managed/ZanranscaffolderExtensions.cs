//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zanranscaffolder
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ZanranscaffolderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<string> UploadDocument(Expression<Func<object>> file, Expression<Func<int>> startPage = null, Expression<Func<int>> endPage = null, Expression<Func<string>> coords = null)
        {
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_startPage = WorkflowExpression.Compile(startPage, nameof(startPage), required: false);
            var __workflow_endPage = WorkflowExpression.Compile(endPage, nameof(endPage), required: false);
            var __workflow_coords = WorkflowExpression.Compile(coords, nameof(coords), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Upload/UploadFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<string> GetStatus(Expression<Func<string>> docname)
        {
            var __workflow_docname = WorkflowExpression.Compile(docname, nameof(docname), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/DocSearch/GetStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<object> DownloadFileXlsx(Expression<Func<string>> docname)
        {
            var __workflow_docname = WorkflowExpression.Compile(docname, nameof(docname), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/{0}.xlsx", ExpressionConverter.ConvertWithUrlEncoding(__workflow_docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<object> DownloadFileAllXml(Expression<Func<string>> docname)
        {
            var __workflow_docname = WorkflowExpression.Compile(docname, nameof(docname), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/allxml/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<object> DownloadFileZnr(Expression<Func<string>> docname)
        {
            var __workflow_docname = WorkflowExpression.Compile(docname, nameof(docname), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/znr/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }
    }

    public class ZanranscaffolderTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zanranscaffolder;

    public partial class WorkflowManagedActions
    {
        public ZanranscaffolderActions Zanranscaffolder(string connectionId) => new ZanranscaffolderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZanranscaffolderTriggers Zanranscaffolder(string connectionId) => new ZanranscaffolderTriggers(connectionId);
    }
}
