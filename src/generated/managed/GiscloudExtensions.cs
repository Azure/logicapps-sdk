//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Giscloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GiscloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        public IBodyWorkflowAction<UploadFileToPathResponse> UploadFileToPath(Expression<Func<string>> aPIKey, Expression<Func<object>> filedata, Expression<Func<string>> pathToAFile, Expression<Func<int>> destinationMap = null)
        {
            var __workflow_aPIKey = WorkflowExpression.Compile(aPIKey, nameof(aPIKey), required: true);
            var __workflow_filedata = WorkflowExpression.Compile(filedata, nameof(filedata), required: true);
            var __workflow_pathToAFile = WorkflowExpression.Compile(pathToAFile, nameof(pathToAFile), required: true);
            var __workflow_destinationMap = WorkflowExpression.Compile(destinationMap, nameof(destinationMap), required: false);
            return new DeferredBodyAction<UploadFileToPathResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_pathToAFile, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_destinationMap != null)
                    callPayload.Queries["destination_map"] = ExpressionConverter.Convert(__workflow_destinationMap);
                callPayload.Headers["API-Key"] = ExpressionConverter.Convert(__workflow_aPIKey);
                return new ApiConnectionAction<UploadFileToPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        public IBodyWorkflowAction<Error> DeleteFileAtPath(Expression<Func<string>> aPIKey, Expression<Func<string>> fileName, Expression<Func<string>> pathToAFile)
        {
            var __workflow_aPIKey = WorkflowExpression.Compile(aPIKey, nameof(aPIKey), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_pathToAFile = WorkflowExpression.Compile(pathToAFile, nameof(pathToAFile), required: true);
            return new DeferredBodyAction<Error>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_pathToAFile, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileName, 1));
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

    public class UploadFileToPathResponse
    {
        [JsonProperty("location")]
        public string Location { get; set; }
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
