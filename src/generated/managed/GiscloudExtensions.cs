//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Giscloud
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GiscloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFileToPath))]
        public IBodyWorkflowAction<UploadFileToPathResponse> UploadFileToPath([WorkflowExpression] Func<string> aPIKey, [WorkflowExpression] Func<object> filedata, [WorkflowExpression] Func<string> pathToAFile, [WorkflowExpression] Func<int> destinationMap = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadFileToPathResponse> __BuildUploadFileToPath(WorkflowValue<string> aPIKey, WorkflowValue<object> filedata, WorkflowValue<string> pathToAFile, WorkflowValue<int> destinationMap = null)
        {
            WorkflowValue.Validate(aPIKey, nameof(aPIKey), required: true);
            WorkflowValue.Validate(filedata, nameof(filedata), required: true);
            WorkflowValue.Validate(pathToAFile, nameof(pathToAFile), required: true);
            WorkflowValue.Validate(destinationMap, nameof(destinationMap), required: false);
            return new DeferredBodyAction<UploadFileToPathResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}", ExpressionConverter.ConvertWithUrlEncoding(pathToAFile, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (destinationMap != null)
                    callPayload.Queries["destination_map"] = ExpressionConverter.Convert(destinationMap);
                callPayload.Headers["API-Key"] = ExpressionConverter.Convert(aPIKey);
                return new ApiConnectionAction<UploadFileToPathResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteFileAtPath))]
        public IBodyWorkflowAction<Error> DeleteFileAtPath([WorkflowExpression] Func<string> aPIKey, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> pathToAFile)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Error> __BuildDeleteFileAtPath(WorkflowValue<string> aPIKey, WorkflowValue<string> fileName, WorkflowValue<string> pathToAFile)
        {
            WorkflowValue.Validate(aPIKey, nameof(aPIKey), required: true);
            WorkflowValue.Validate(fileName, nameof(fileName), required: true);
            WorkflowValue.Validate(pathToAFile, nameof(pathToAFile), required: true);
            return new DeferredBodyAction<Error>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(pathToAFile, 1), ExpressionConverter.ConvertWithUrlEncoding(fileName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["API-Key"] = ExpressionConverter.Convert(aPIKey);
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
