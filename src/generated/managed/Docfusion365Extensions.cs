//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docfusion365
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Docfusion365Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<VersionResponse> GetApiVersion()
        {
            var apiCallPath = "/api/DocFusion365/GetVersion";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VersionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<GetLinkedListTemplatesResponse[]> GetTheLinkedListTemplates(Expression<Func<string>> siteUrl, Expression<Func<string>> listName)
        {
            var apiCallPath = "/api/DocFusion365/GetLinkedListTemplates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["listName"] = CSharpExpressionConverter.ConvertO(listName);
            return new ApiConnectionAction<GetLinkedListTemplatesResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse> ComposeALinkedTemplate(Expression<Func<string>> siteUrl, Expression<Func<string>> listName, Expression<Func<int>> templateId, Expression<Func<int>> listItemId, Expression<Func<bool>> skipPostProcess)
        {
            var apiCallPath = "/api/DocFusion365/ComposeLinkedTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["listName"] = CSharpExpressionConverter.ConvertO(listName);
            callPayload.Queries["TemplateId"] = CSharpExpressionConverter.ConvertO(templateId);
            callPayload.Queries["listItemId"] = CSharpExpressionConverter.ConvertO(listItemId);
            callPayload.Queries["skipPostProcess"] = CSharpExpressionConverter.ConvertO(skipPostProcess);
            return new ApiConnectionAction<ComposeLinkedTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse[]> ComposeAllTheLinkedTemplates(Expression<Func<string>> siteUrl, Expression<Func<string>> listName, Expression<Func<int>> listItemId, Expression<Func<bool>> skipPostProcess)
        {
            var apiCallPath = "/api/DocFusion365/ComposeAllLinkedTemplates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = CSharpExpressionConverter.ConvertO(siteUrl);
            callPayload.Queries["listName"] = CSharpExpressionConverter.ConvertO(listName);
            callPayload.Queries["listItemId"] = CSharpExpressionConverter.ConvertO(listItemId);
            callPayload.Queries["skipPostProcess"] = CSharpExpressionConverter.ConvertO(skipPostProcess);
            return new ApiConnectionAction<ComposeLinkedTemplateResponse[]>(callPayload);
        }
    }

    public class Docfusion365Triggers([ConnectionName] string connectionId)
    {
    }

    public class VersionResponse
    {
        public string ApiVersion { get; set; }
    }

    public class GetLinkedListTemplatesResponse
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string OutputFormat { get; set; }
    }

    public class ComposeLinkedTemplateResponse
    {
        public string Error { get; set; }
        public bool Succeeded { get; set; }
        public string OutputItemUrl { get; set; }
        public string LogListUrl { get; set; }
        public string ListName { get; set; }
        public int ListItemId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Docfusion365;

    public partial class WorkflowManagedActions
    {
        public Docfusion365Actions Docfusion365(string connectionId) => new Docfusion365Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Docfusion365Triggers Docfusion365(string connectionId) => new Docfusion365Triggers(connectionId);
    }
}