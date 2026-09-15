//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Giscloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GiscloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        public IBodyWorkflowAction<UploadFileToPathResponse> UploadFileToPath(Expression<Func<string>> aPIKey, Expression<Func<object>> filedata, Expression<Func<string>> pathToAFile, Expression<Func<int>> destinationMap = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pathToAFile, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (destinationMap != null)
                callPayload.Queries["destination_map"] = CSharpExpressionConverter.ConvertO(destinationMap);
            callPayload.Headers["API-Key"] = CSharpExpressionConverter.ConvertO(aPIKey);
            return new ApiConnectionAction<UploadFileToPathResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        public IBodyWorkflowAction<Error> DeleteFileAtPath(Expression<Func<string>> aPIKey, Expression<Func<string>> fileName, Expression<Func<string>> pathToAFile)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(pathToAFile, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileName, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["API-Key"] = CSharpExpressionConverter.ConvertO(aPIKey);
            return new ApiConnectionAction<Error>(callPayload);
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