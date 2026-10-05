//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zanranscaffolder
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZanranscaffolderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        [WorkflowExpressionFactory(nameof(__BuildUploadDocument))]
        public IBodyWorkflowAction<string> UploadDocument([WorkflowExpression] Func<object> file, [WorkflowExpression] Func<int> startPage = null, [WorkflowExpression] Func<int> endPage = null, [WorkflowExpression] Func<string> coords = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildUploadDocument(WorkflowValue<object> file, WorkflowValue<int> startPage = null, WorkflowValue<int> endPage = null, WorkflowValue<string> coords = null)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(startPage, nameof(startPage), required: false);
            WorkflowValue.Validate(endPage, nameof(endPage), required: false);
            WorkflowValue.Validate(coords, nameof(coords), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Upload/UploadFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        [WorkflowExpressionFactory(nameof(__BuildGetStatus))]
        public IBodyWorkflowAction<string> GetStatus([WorkflowExpression] Func<string> docname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetStatus(WorkflowValue<string> docname)
        {
            WorkflowValue.Validate(docname, nameof(docname), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/DocSearch/GetStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadFileXlsx))]
        public IBodyWorkflowAction<object> DownloadFileXlsx([WorkflowExpression] Func<string> docname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildDownloadFileXlsx(WorkflowValue<string> docname)
        {
            WorkflowValue.Validate(docname, nameof(docname), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/{0}.xlsx", ExpressionConverter.ConvertWithUrlEncoding(docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadFileAllXml))]
        public IBodyWorkflowAction<object> DownloadFileAllXml([WorkflowExpression] Func<string> docname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildDownloadFileAllXml(WorkflowValue<string> docname)
        {
            WorkflowValue.Validate(docname, nameof(docname), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/allxml/{0}", ExpressionConverter.ConvertWithUrlEncoding(docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadFileZnr))]
        public IBodyWorkflowAction<object> DownloadFileZnr([WorkflowExpression] Func<string> docname)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildDownloadFileZnr(WorkflowValue<string> docname)
        {
            WorkflowValue.Validate(docname, nameof(docname), required: true);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/znr/{0}", ExpressionConverter.ConvertWithUrlEncoding(docname, 1));
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
