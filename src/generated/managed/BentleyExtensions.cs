//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Bentley
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BentleyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        public IBodyWorkflowAction<BadRequestObjectResult, ApiConnectionActionConfiguration> SynchronizeDocumentAttributes(Expression<Func<string>> connection, Expression<Func<string>> documentIdentifier, Expression<Func<attributeSynchronizationModeldirectionInput>> attributeSynchronizationModeldirection)
        {
            var __workflow_connection = WorkflowExpression.Compile(connection, nameof(connection), required: true);
            var __workflow_documentIdentifier = WorkflowExpression.Compile(documentIdentifier, nameof(documentIdentifier), required: true);
            var __workflow_attributeSynchronizationModeldirection = WorkflowExpression.Compile(attributeSynchronizationModeldirection, nameof(attributeSynchronizationModeldirection), required: true);
            return new DeferredBodyAction<BadRequestObjectResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/{0}/documents/{1}/attributeSynchronization", __workflow_connection.WithUrlEncoding(1), __workflow_documentIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var attributeSynchronizationModel = new JObject();
                var attributeSynchronizationModelpropCount = 0;
                attributeSynchronizationModelpropCount++;
                attributeSynchronizationModel["direction"] = ExpressionConverter.ConvertO(__workflow_attributeSynchronizationModeldirection);
                if (attributeSynchronizationModelpropCount > 0)
                {
                    callPayload.Body = attributeSynchronizationModel;
                }

                return new ApiConnectionAction<BadRequestObjectResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "bentley")]
        public IBodyWorkflowAction<BadRequestObjectResult, ApiConnectionActionConfiguration> UploadFile(Expression<Func<string>> connection, Expression<Func<string>> documentIdentifier, Expression<Func<string>> xBsFileName, Expression<Func<string>> fileContent = null)
        {
            var __workflow_connection = WorkflowExpression.Compile(connection, nameof(connection), required: true);
            var __workflow_documentIdentifier = WorkflowExpression.Compile(documentIdentifier, nameof(documentIdentifier), required: true);
            var __workflow_xBsFileName = WorkflowExpression.Compile(xBsFileName, nameof(xBsFileName), required: true);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: false);
            return new DeferredBodyAction<BadRequestObjectResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v2/{0}/documents/{1}/file", __workflow_connection.WithUrlEncoding(1), __workflow_documentIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-bs-file-name"] = ExpressionConverter.Convert(__workflow_xBsFileName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileContent);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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