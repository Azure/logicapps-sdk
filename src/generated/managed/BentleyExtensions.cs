//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bentley
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BentleyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        public IBodyWorkflowAction<BadRequestObjectResult> SynchronizeDocumentAttributes([WorkflowExpression] Func<string> connection, [WorkflowExpression] Func<string> documentIdentifier, [WorkflowExpression] Func<attributeSynchronizationModeldirectionInput> attributeSynchronizationModeldirection)
        {
            SourceExpression.Validate(connection, nameof(connection), required: true);
            SourceExpression.Validate(documentIdentifier, nameof(documentIdentifier), required: true);
            SourceExpression.Validate(attributeSynchronizationModeldirection, nameof(attributeSynchronizationModeldirection), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/{0}/documents/{1}/attributeSynchronization", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(connection, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attributeSynchronizationModel = new JObject();
                var attributeSynchronizationModelpropCount = 0;
                attributeSynchronizationModelpropCount++;
                attributeSynchronizationModel["direction"] = SourceExpressionConverter.Convert(attributeSynchronizationModeldirection);
                if (attributeSynchronizationModelpropCount > 0)
                {
                    callPayload.Body = attributeSynchronizationModel;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BadRequestObjectResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        public IBodyWorkflowAction<BadRequestObjectResult> UploadFile([WorkflowExpression] Func<string> connection, [WorkflowExpression] Func<string> documentIdentifier, [WorkflowExpression] Func<string> xBsFileName, [WorkflowExpression] Func<string> fileContent = null)
        {
            SourceExpression.Validate(connection, nameof(connection), required: true);
            SourceExpression.Validate(documentIdentifier, nameof(documentIdentifier), required: true);
            SourceExpression.Validate(xBsFileName, nameof(xBsFileName), required: true);
            SourceExpression.Validate(fileContent, nameof(fileContent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v2/{0}/documents/{1}/file", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(connection, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentIdentifier, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-bs-file-name"] = SourceExpressionConverter.ConvertO(xBsFileName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(fileContent);
                return callPayload;
            }

            return new ApiConnectionAction<BadRequestObjectResult>(BuildSourceInput);
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