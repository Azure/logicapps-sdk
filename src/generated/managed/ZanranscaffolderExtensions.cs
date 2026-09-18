//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zanranscaffolder
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZanranscaffolderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<string> UploadDocument([WorkflowExpression] Func<object> file, [WorkflowExpression] Func<int> startPage = null, [WorkflowExpression] Func<int> endPage = null, [WorkflowExpression] Func<string> coords = null)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(startPage, nameof(startPage), required: false);
            SourceExpression.Validate(endPage, nameof(endPage), required: false);
            SourceExpression.Validate(coords, nameof(coords), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Upload/UploadFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<string> GetStatus([WorkflowExpression] Func<string> docname)
        {
            SourceExpression.Validate(docname, nameof(docname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/DocSearch/GetStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<object> DownloadFileXlsx([WorkflowExpression] Func<string> docname)
        {
            SourceExpression.Validate(docname, nameof(docname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/{0}.xlsx", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<object> DownloadFileAllXml([WorkflowExpression] Func<string> docname)
        {
            SourceExpression.Validate(docname, nameof(docname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/allxml/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zanranscaffolder")]
        public IBodyWorkflowAction<object> DownloadFileZnr([WorkflowExpression] Func<string> docname)
        {
            SourceExpression.Validate(docname, nameof(docname), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/znr/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(docname, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<object>(BuildSourceInput);
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