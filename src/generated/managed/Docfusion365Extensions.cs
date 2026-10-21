//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Docfusion365
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
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
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_listName = WorkflowExpression.Compile(listName, nameof(listName), required: true);
            return new DeferredBodyAction<GetLinkedListTemplatesResponse[]>(() =>
            {
                var apiCallPath = "/api/DocFusion365/GetLinkedListTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(__workflow_listName);
                return new ApiConnectionAction<GetLinkedListTemplatesResponse[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse> ComposeALinkedTemplate(Expression<Func<string>> siteUrl, Expression<Func<string>> listName, Expression<Func<int>> templateId, Expression<Func<int>> listItemId, Expression<Func<bool>> skipPostProcess)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_listName = WorkflowExpression.Compile(listName, nameof(listName), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_listItemId = WorkflowExpression.Compile(listItemId, nameof(listItemId), required: true);
            var __workflow_skipPostProcess = WorkflowExpression.Compile(skipPostProcess, nameof(skipPostProcess), required: true);
            return new DeferredBodyAction<ComposeLinkedTemplateResponse>(() =>
            {
                var apiCallPath = "/api/DocFusion365/ComposeLinkedTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(__workflow_listName);
                callPayload.Queries["TemplateId"] = ExpressionConverter.Convert(__workflow_templateId);
                callPayload.Queries["listItemId"] = ExpressionConverter.Convert(__workflow_listItemId);
                callPayload.Queries["skipPostProcess"] = ExpressionConverter.Convert(__workflow_skipPostProcess);
                return new ApiConnectionAction<ComposeLinkedTemplateResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse[]> ComposeAllTheLinkedTemplates(Expression<Func<string>> siteUrl, Expression<Func<string>> listName, Expression<Func<int>> listItemId, Expression<Func<bool>> skipPostProcess)
        {
            var __workflow_siteUrl = WorkflowExpression.Compile(siteUrl, nameof(siteUrl), required: true);
            var __workflow_listName = WorkflowExpression.Compile(listName, nameof(listName), required: true);
            var __workflow_listItemId = WorkflowExpression.Compile(listItemId, nameof(listItemId), required: true);
            var __workflow_skipPostProcess = WorkflowExpression.Compile(skipPostProcess, nameof(skipPostProcess), required: true);
            return new DeferredBodyAction<ComposeLinkedTemplateResponse[]>(() =>
            {
                var apiCallPath = "/api/DocFusion365/ComposeAllLinkedTemplates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = ExpressionConverter.Convert(__workflow_siteUrl);
                callPayload.Queries["listName"] = ExpressionConverter.Convert(__workflow_listName);
                callPayload.Queries["listItemId"] = ExpressionConverter.Convert(__workflow_listItemId);
                callPayload.Queries["skipPostProcess"] = ExpressionConverter.Convert(__workflow_skipPostProcess);
                return new ApiConnectionAction<ComposeLinkedTemplateResponse[]>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
