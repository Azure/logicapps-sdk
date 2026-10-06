//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bentley
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BentleyActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFile))]
        public IBodyWorkflowAction<BadRequestObjectResult> UploadFile([WorkflowExpression] Func<string> connectedProjectId, [WorkflowExpression] Func<string> federatedRepositoryId, [WorkflowExpression] Func<string> documentIdentifier, [WorkflowExpression] Func<string> xBsFileName, [WorkflowExpression] Func<string> fileContent = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BadRequestObjectResult> __BuildUploadFile(WorkflowExpression<string> connectedProjectId, WorkflowExpression<string> federatedRepositoryId, WorkflowExpression<string> documentIdentifier, WorkflowExpression<string> xBsFileName, WorkflowExpression<string> fileContent = null)
        {
            WorkflowExpression.Validate(connectedProjectId, nameof(connectedProjectId), required: true);
            WorkflowExpression.Validate(federatedRepositoryId, nameof(federatedRepositoryId), required: true);
            WorkflowExpression.Validate(documentIdentifier, nameof(documentIdentifier), required: true);
            WorkflowExpression.Validate(xBsFileName, nameof(xBsFileName), required: true);
            WorkflowExpression.Validate(fileContent, nameof(fileContent), required: false);
            return new DeferredBodyAction<BadRequestObjectResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v1/connectedProjects/{0}/federatedRepositories/{1}/documents/{2}/file", ExpressionConverter.ConvertWithUrlEncoding(connectedProjectId, 1), ExpressionConverter.ConvertWithUrlEncoding(federatedRepositoryId, 1), ExpressionConverter.ConvertWithUrlEncoding(documentIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-bs-file-name"] = ExpressionConverter.Convert(xBsFileName);
                callPayload.Body = ExpressionConverter.ConvertO(fileContent);
                return new ApiConnectionAction<BadRequestObjectResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        [WorkflowExpressionFactory(nameof(__BuildSynchronizeDocumentAttributes))]
        public IBodyWorkflowAction<BadRequestObjectResult> SynchronizeDocumentAttributes([WorkflowExpression] Func<string> connection, [WorkflowExpression] Func<string> documentIdentifier, [WorkflowExpression] Func<attributeSynchronizationModeldirectionInput> attributeSynchronizationModeldirection)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BadRequestObjectResult> __BuildSynchronizeDocumentAttributes(WorkflowExpression<string> connection, WorkflowExpression<string> documentIdentifier, WorkflowExpression<attributeSynchronizationModeldirectionInput> attributeSynchronizationModeldirection)
        {
            WorkflowExpression.Validate(connection, nameof(connection), required: true);
            WorkflowExpression.Validate(documentIdentifier, nameof(documentIdentifier), required: true);
            WorkflowExpression.Validate(attributeSynchronizationModeldirection, nameof(attributeSynchronizationModeldirection), required: true);
            return new DeferredBodyAction<BadRequestObjectResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v2/{0}/documents/{1}/attributeSynchronization", ExpressionConverter.ConvertWithUrlEncoding(connection, 1), ExpressionConverter.ConvertWithUrlEncoding(documentIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attributeSynchronizationModel = new JObject();
                var attributeSynchronizationModelpropCount = 0;
                attributeSynchronizationModelpropCount++;
                attributeSynchronizationModel["direction"] = ExpressionConverter.ConvertO(attributeSynchronizationModeldirection);
                if (attributeSynchronizationModelpropCount > 0)
                {
                    callPayload.Body = attributeSynchronizationModel;
                }

                return new ApiConnectionAction<BadRequestObjectResult>(callPayload);
            });
        }
    }

    public class BentleyTriggers([ConnectionName] string connectionId)
    {
    }

    public class BadRequestObjectResult
    {
        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("formatters")]
        public JToken[] Formatters { get; set; }

        [JsonProperty("contentTypes")]
        public string[] ContentTypes { get; set; }

        [JsonProperty("declaredType")]
        public string DeclaredType { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
    }

    public enum attributeSynchronizationModeldirectionInput
    {
        [EnumMember(Value = "fromFile")]
        FromFile,
        [EnumMember(Value = "toFile")]
        ToFile
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bentley;

    public partial class WorkflowManagedActions
    {
        public BentleyActions Bentley(string connectionId) => new BentleyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BentleyTriggers Bentley(string connectionId) => new BentleyTriggers(connectionId);
    }
}