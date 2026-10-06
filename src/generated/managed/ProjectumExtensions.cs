//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Projectum
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectumActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string> GeneratePowerpointDoc([WorkflowExpression] Func<string> generationInfodataMap, [WorkflowExpression] Func<string> generationInfoFile = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Powerpoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generationInfo = new JObject();
                var generationInfopropCount = 0;
                generationInfopropCount++;
                generationInfo["dataMap"] = SourceExpressionConverter.ConvertToken(generationInfodataMap);
                if (generationInfoFile != null)
                {
                    generationInfo["file"] = SourceExpressionConverter.ConvertToken(generationInfoFile);
                    generationInfopropCount++;
                }

                if (generationInfopropCount > 0)
                {
                    callPayload.Body = generationInfo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string> GenerateWordDoc([WorkflowExpression] Func<string> generationInfodataMap, [WorkflowExpression] Func<string> generationInfoFile = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Word";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generationInfo = new JObject();
                var generationInfopropCount = 0;
                generationInfopropCount++;
                generationInfo["dataMap"] = SourceExpressionConverter.ConvertToken(generationInfodataMap);
                if (generationInfoFile != null)
                {
                    generationInfo["file"] = SourceExpressionConverter.ConvertToken(generationInfoFile);
                    generationInfopropCount++;
                }

                if (generationInfopropCount > 0)
                {
                    callPayload.Body = generationInfo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string> MergePowerpointDocuments([WorkflowExpression] Func<string[]> documents = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Powerpoint/Merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(documents);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string> MergeWordDocuments([WorkflowExpression] Func<string[]> documents = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Word/Merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(documents);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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