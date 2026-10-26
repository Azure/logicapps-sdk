//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Giscloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GiscloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        public IBodyWorkflowAction<Error, ApiConnectionActionConfiguration> DeleteFileAtPath(Expression<Func<string>> aPIKey, Expression<Func<string>> fileName, Expression<Func<string>> pathToAFile)
        {
            var __workflow_aPIKey = WorkflowExpression.Compile(aPIKey, nameof(aPIKey), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_pathToAFile = WorkflowExpression.Compile(pathToAFile, nameof(pathToAFile), required: true);
            return new DeferredBodyAction<Error, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/storage/fs/{0}/{1}", __workflow_pathToAFile.WithUrlEncoding(1), __workflow_fileName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["API-Key"] = ExpressionConverter.Convert(__workflow_aPIKey);
                return new ApiConnectionAction<Error>(callPayload);
            });
        }
    }

    public class GiscloudTriggers([ConnectionName] string connectionId)
    {
    }

    public class Error
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Giscloud;

    public partial class WorkflowManagedActions
    {
        public GiscloudActions Giscloud(string connectionId) => new GiscloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GiscloudTriggers Giscloud(string connectionId) => new GiscloudTriggers(connectionId);
    }
}