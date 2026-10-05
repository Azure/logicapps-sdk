//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectum
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        [WorkflowExpressionFactory(nameof(__BuildGeneratePowerpointDoc))]
        public IBodyWorkflowAction<string> GeneratePowerpointDoc([WorkflowExpression] Func<string> generationInfodataMap, [WorkflowExpression] Func<string> generationInfofile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGeneratePowerpointDoc(WorkflowValue<string> generationInfodataMap, WorkflowValue<string> generationInfofile = null)
        {
            WorkflowValue.Validate(generationInfodataMap, nameof(generationInfodataMap), required: true);
            WorkflowValue.Validate(generationInfofile, nameof(generationInfofile), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generationInfo = new JObject();
                var generationInfopropCount = 0;
                generationInfopropCount++;
                generationInfo["dataMap"] = ExpressionConverter.ConvertO(generationInfodataMap);
                if (generationInfofile != null)
                {
                    generationInfo["file"] = ExpressionConverter.ConvertO(generationInfofile);
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
        [WorkflowExpressionFactory(nameof(__BuildGenerateWordDoc))]
        public IBodyWorkflowAction<string> GenerateWordDoc([WorkflowExpression] Func<string> generationInfodataMap, [WorkflowExpression] Func<string> generationInfofile = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGenerateWordDoc(WorkflowValue<string> generationInfodataMap, WorkflowValue<string> generationInfofile = null)
        {
            WorkflowValue.Validate(generationInfodataMap, nameof(generationInfodataMap), required: true);
            WorkflowValue.Validate(generationInfofile, nameof(generationInfofile), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generationInfo = new JObject();
                var generationInfopropCount = 0;
                generationInfopropCount++;
                generationInfo["dataMap"] = ExpressionConverter.ConvertO(generationInfodataMap);
                if (generationInfofile != null)
                {
                    generationInfo["file"] = ExpressionConverter.ConvertO(generationInfofile);
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
        [WorkflowExpressionFactory(nameof(__BuildMergePowerpointDocuments))]
        public IBodyWorkflowAction<string> MergePowerpointDocuments([WorkflowExpression] Func<string[]> documents = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergePowerpointDocuments(WorkflowValue<string[]> documents = null)
        {
            WorkflowValue.Validate(documents, nameof(documents), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Powerpoint/Merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(documents);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        [WorkflowExpressionFactory(nameof(__BuildMergeWordDocuments))]
        public IBodyWorkflowAction<string> MergeWordDocuments([WorkflowExpression] Func<string[]> documents = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMergeWordDocuments(WorkflowValue<string[]> documents = null)
        {
            WorkflowValue.Validate(documents, nameof(documents), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/Word/Merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(documents);
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
