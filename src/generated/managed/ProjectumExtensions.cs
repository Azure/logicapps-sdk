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
        public IBodyWorkflowAction<string> GeneratePowerpointDoc(Expression<Func<string>> generationInfodataMap, Expression<Func<string>> generationInfofile = null)
        {
            var apiCallPath = "/api/Powerpoint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var generationInfo = new JObject();
            var generationInfopropCount = 0;
            generationInfopropCount++;
            generationInfo["dataMap"] = CSharpExpressionConverter.ConvertToken(generationInfodataMap);
            if (generationInfofile != null)
            {
                generationInfo["file"] = CSharpExpressionConverter.ConvertToken(generationInfofile);
                generationInfopropCount++;
            }

            if (generationInfopropCount > 0)
            {
                callPayload.Body = generationInfo;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string> GenerateWordDoc(Expression<Func<string>> generationInfodataMap, Expression<Func<string>> generationInfofile = null)
        {
            var apiCallPath = "/api/Word";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var generationInfo = new JObject();
            var generationInfopropCount = 0;
            generationInfopropCount++;
            generationInfo["dataMap"] = CSharpExpressionConverter.ConvertToken(generationInfodataMap);
            if (generationInfofile != null)
            {
                generationInfo["file"] = CSharpExpressionConverter.ConvertToken(generationInfofile);
                generationInfopropCount++;
            }

            if (generationInfopropCount > 0)
            {
                callPayload.Body = generationInfo;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string> MergePowerpointDocuments(Expression<Func<string[]>> documents = null)
        {
            var apiCallPath = "/api/Powerpoint/Merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(documents);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "projectum")]
        public IBodyWorkflowAction<string> MergeWordDocuments(Expression<Func<string[]>> documents = null)
        {
            var apiCallPath = "/api/Word/Merge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(documents);
            return new ApiConnectionAction<string>(callPayload);
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