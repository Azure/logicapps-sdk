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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/DocFusion365/GetVersion";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<GetLinkedListTemplatesResponse[]> GetTheLinkedListTemplates([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(listName, nameof(listName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/DocFusion365/GetLinkedListTemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["listName"] = SourceExpressionConverter.ConvertO(listName);
                return callPayload;
            }

            return new ApiConnectionAction<GetLinkedListTemplatesResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse> ComposeALinkedTemplate([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<int> templateId, [WorkflowExpression] Func<int> listItemId, [WorkflowExpression] Func<bool> skipPostProcess)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(listName, nameof(listName), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(listItemId, nameof(listItemId), required: true);
            SourceExpression.Validate(skipPostProcess, nameof(skipPostProcess), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/DocFusion365/ComposeLinkedTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["listName"] = SourceExpressionConverter.ConvertO(listName);
                callPayload.Queries["TemplateId"] = SourceExpressionConverter.ConvertO(templateId);
                callPayload.Queries["listItemId"] = SourceExpressionConverter.ConvertO(listItemId);
                callPayload.Queries["skipPostProcess"] = SourceExpressionConverter.ConvertO(skipPostProcess);
                return callPayload;
            }

            return new ApiConnectionAction<ComposeLinkedTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "docfusion365")]
        public IBodyWorkflowAction<ComposeLinkedTemplateResponse[]> ComposeAllTheLinkedTemplates([WorkflowExpression] Func<string> siteUrl, [WorkflowExpression] Func<string> listName, [WorkflowExpression] Func<int> listItemId, [WorkflowExpression] Func<bool> skipPostProcess)
        {
            SourceExpression.Validate(siteUrl, nameof(siteUrl), required: true);
            SourceExpression.Validate(listName, nameof(listName), required: true);
            SourceExpression.Validate(listItemId, nameof(listItemId), required: true);
            SourceExpression.Validate(skipPostProcess, nameof(skipPostProcess), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/DocFusion365/ComposeAllLinkedTemplates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteUrl"] = SourceExpressionConverter.ConvertO(siteUrl);
                callPayload.Queries["listName"] = SourceExpressionConverter.ConvertO(listName);
                callPayload.Queries["listItemId"] = SourceExpressionConverter.ConvertO(listItemId);
                callPayload.Queries["skipPostProcess"] = SourceExpressionConverter.ConvertO(skipPostProcess);
                return callPayload;
            }

            return new ApiConnectionAction<ComposeLinkedTemplateResponse[]>(BuildSourceInput);
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