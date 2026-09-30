//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docfusion365
{
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
        public IBodyWorkflowAction<GetLinkedListTemplatesResponse[]> GetTheLinkedListTemplates([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName)
        {
            var apiCallPath = "/api/DocFusion365/GetLinkedListTemplates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
            return new ApiConnectionAction<GetLinkedListTemplatesResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse> ComposeALinkedTemplate([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<int> templateId, [WorkflowExpression] Func<int> listItemId, [WorkflowExpression] Func<bool> skipPostProcess)
        {
            var apiCallPath = "/api/DocFusion365/ComposeLinkedTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
            callPayload.Queries["TemplateId"] = ExpressionConverter.Convert(templateId);
            callPayload.Queries["listItemId"] = ExpressionConverter.Convert(listItemId);
            callPayload.Queries["skipPostProcess"] = ExpressionConverter.Convert(skipPostProcess);
            return new ApiConnectionAction<ComposeLinkedTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse[]> ComposeAllTheLinkedTemplates([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<int> listItemId, [WorkflowExpression] Func<bool> skipPostProcess)
        {
            var apiCallPath = "/api/DocFusion365/ComposeAllLinkedTemplates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
            callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
            callPayload.Queries["listItemId"] = ExpressionConverter.Convert(listItemId);
            callPayload.Queries["skipPostProcess"] = ExpressionConverter.Convert(skipPostProcess);
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