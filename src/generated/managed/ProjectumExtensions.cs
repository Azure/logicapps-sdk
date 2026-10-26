//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectum
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GeneratePowerpointDoc(Expression<Func<GeneratePowerpointDocInput>> generationInfo)
        {
            var __workflow_generationInfo = WorkflowExpression.Compile(generationInfo, nameof(generationInfo), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_generationInfo);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateWordDoc(Expression<Func<GenerateWordDocInput>> generationInfo)
        {
            var __workflow_generationInfo = WorkflowExpression.Compile(generationInfo, nameof(generationInfo), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_generationInfo);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergePowerpointDocuments(Expression<Func<string[]>> documents)
        {
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Powerpoint/Merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documents);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergeWordDocuments(Expression<Func<string[]>> documents)
        {
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Word/Merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_documents);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class ProjectumTriggers([ConnectionName] string connectionId)
    {
    }

    public class GeneratePowerpointDocInput
    {
        [JsonProperty("dataMap", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataMap { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }
    }

    public class GenerateWordDocInput
    {
        [JsonProperty("dataMap", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DataMap { get; set; }

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public string File { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Projectum;

    public partial class WorkflowManagedActions
    {
        public ProjectumActions Projectum(string connectionId) => new ProjectumActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ProjectumTriggers Projectum(string connectionId) => new ProjectumTriggers(connectionId);
    }
}