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