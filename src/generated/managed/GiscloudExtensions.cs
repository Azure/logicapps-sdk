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
        public IBodyWorkflowAction<UploadFileToPathResponse> UploadFileToPath([WorkflowExpression] Func<string> aPIKey, [WorkflowExpression] Func<object> filedata, [WorkflowExpression] Func<string> pathToAFile, [WorkflowExpression] Func<int> destinationMap = null)
        {
            SourceExpression.Validate(aPIKey, nameof(aPIKey), required: true);
            SourceExpression.Validate(filedata, nameof(filedata), required: true);
            SourceExpression.Validate(pathToAFile, nameof(pathToAFile), required: true);
            SourceExpression.Validate(destinationMap, nameof(destinationMap), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pathToAFile, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (destinationMap != null)
                    callPayload.Queries["destination_map"] = SourceExpressionConverter.ConvertO(destinationMap);
                callPayload.Headers["API-Key"] = SourceExpressionConverter.ConvertO(aPIKey);
                return callPayload;
            }

            return new ApiConnectionAction<UploadFileToPathResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "giscloud")]
        public IBodyWorkflowAction<Error> DeleteFileAtPath([WorkflowExpression] Func<string> aPIKey, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> pathToAFile)
        {
            SourceExpression.Validate(aPIKey, nameof(aPIKey), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(pathToAFile, nameof(pathToAFile), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/storage/fs/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pathToAFile, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileName, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["API-Key"] = SourceExpressionConverter.ConvertO(aPIKey);
                return callPayload;
            }

            return new ApiConnectionAction<Error>(BuildSourceInput);
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