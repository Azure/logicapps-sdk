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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GeneratePowerpointDoc(Expression<Func<string>> generationInfodataMap, Expression<Func<string>> generationInfoFile = null)
        {
            var __workflow_generationInfodataMap = WorkflowExpression.Compile(generationInfodataMap, nameof(generationInfodataMap), required: true);
            var __workflow_generationInfoFile = WorkflowExpression.Compile(generationInfoFile, nameof(generationInfoFile), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generationInfo = new JObject();
                var generationInfopropCount = 0;
                generationInfopropCount++;
                generationInfo["dataMap"] = ExpressionConverter.ConvertO(__workflow_generationInfodataMap);
                if (__workflow_generationInfoFile != null)
                {
                    generationInfo["file"] = ExpressionConverter.ConvertO(__workflow_generationInfoFile);
                    generationInfopropCount++;
                }

                if (generationInfopropCount > 0)
                {
                    callPayload.Body = generationInfo;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GenerateWordDoc(Expression<Func<string>> generationInfodataMap, Expression<Func<string>> generationInfoFile = null)
        {
            var __workflow_generationInfodataMap = WorkflowExpression.Compile(generationInfodataMap, nameof(generationInfodataMap), required: true);
            var __workflow_generationInfoFile = WorkflowExpression.Compile(generationInfoFile, nameof(generationInfoFile), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generationInfo = new JObject();
                var generationInfopropCount = 0;
                generationInfopropCount++;
                generationInfo["dataMap"] = ExpressionConverter.ConvertO(__workflow_generationInfodataMap);
                if (__workflow_generationInfoFile != null)
                {
                    generationInfo["file"] = ExpressionConverter.ConvertO(__workflow_generationInfoFile);
                    generationInfopropCount++;
                }

                if (generationInfopropCount > 0)
                {
                    callPayload.Body = generationInfo;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergePowerpointDocuments(Expression<Func<string[]>> documents = null)
        {
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: false);
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergeWordDocuments(Expression<Func<string[]>> documents = null)
        {
            var __workflow_documents = WorkflowExpression.Compile(documents, nameof(documents), required: false);
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