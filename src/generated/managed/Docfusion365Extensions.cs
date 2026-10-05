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
        [WorkflowExpressionFactory(nameof(__BuildGetTheLinkedListTemplates))]
        public IBodyWorkflowAction<GetLinkedListTemplatesResponse[]> GetTheLinkedListTemplates([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLinkedListTemplatesResponse[]> __BuildGetTheLinkedListTemplates(WorkflowValue<string> siteUrl, WorkflowValue<string> listName)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(listName, nameof(listName), required: true);
            return new DeferredBodyAction<GetLinkedListTemplatesResponse[]>(() =>
            {
                var apiCallPath = "/api/DocFusion365/GetLinkedListTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
                return new ApiConnectionAction<GetLinkedListTemplatesResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        [WorkflowExpressionFactory(nameof(__BuildComposeALinkedTemplate))]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse> ComposeALinkedTemplate([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<int> templateId, [WorkflowExpression] Func<int> listItemId, [WorkflowExpression] Func<bool> skipPostProcess)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse> __BuildComposeALinkedTemplate(WorkflowValue<string> siteUrl, WorkflowValue<string> listName, WorkflowValue<int> templateId, WorkflowValue<int> listItemId, WorkflowValue<bool> skipPostProcess)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(listName, nameof(listName), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(listItemId, nameof(listItemId), required: true);
            WorkflowValue.Validate(skipPostProcess, nameof(skipPostProcess), required: true);
            return new DeferredBodyAction<ComposeLinkedTemplateResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        [WorkflowExpressionFactory(nameof(__BuildComposeAllTheLinkedTemplates))]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse[]> ComposeAllTheLinkedTemplates([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<int> listItemId, [WorkflowExpression] Func<bool> skipPostProcess)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse[]> __BuildComposeAllTheLinkedTemplates(WorkflowValue<string> siteUrl, WorkflowValue<string> listName, WorkflowValue<int> listItemId, WorkflowValue<bool> skipPostProcess)
        {
            WorkflowValue.Validate(siteUrl, nameof(siteUrl), required: true);
            WorkflowValue.Validate(listName, nameof(listName), required: true);
            WorkflowValue.Validate(listItemId, nameof(listItemId), required: true);
            WorkflowValue.Validate(skipPostProcess, nameof(skipPostProcess), required: true);
            return new DeferredBodyAction<ComposeLinkedTemplateResponse[]>(() =>
            {
                var apiCallPath = "/api/DocFusion365/ComposeAllLinkedTemplates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(siteUrl);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(listName);
                callPayload.Queries["listItemId"] = ExpressionConverter.Convert(listItemId);
                callPayload.Queries["skipPostProcess"] = ExpressionConverter.Convert(skipPostProcess);
                return new ApiConnectionAction<ComposeLinkedTemplateResponse[]>(callPayload);
            });
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
