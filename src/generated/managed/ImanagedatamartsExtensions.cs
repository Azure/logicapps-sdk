//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagedatamarts
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanagedatamartsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagedatamarts")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSourceMetadataInBatch))]
        public IBodyWorkflowAction<ItemBatchResponse> DeleteSourceMetadataInBatch([WorkflowExpression] Func<string> itemType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemBatchResponse> __BuildDeleteSourceMetadataInBatch(WorkflowExpression<string> itemType)
        {
            WorkflowExpression.Validate(itemType, nameof(itemType), required: true);
            return new DeferredBodyAction<ItemBatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/batch/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(itemType, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ItemBatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagedatamarts")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSourceMetadataInBatch))]
        public IBodyWorkflowAction<ItemBatchResponse> UpdateSourceMetadataInBatch([WorkflowExpression] Func<string> itemType)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemBatchResponse> __BuildUpdateSourceMetadataInBatch(WorkflowExpression<string> itemType)
        {
            WorkflowExpression.Validate(itemType, nameof(itemType), required: true);
            return new DeferredBodyAction<ItemBatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/batch/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(itemType, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ItemBatchResponse>(callPayload);
            });
        }
    }

    public class ImanagedatamartsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ItemBatchResponse
    {
        [JsonProperty("successes")]
        public JToken[] Successes { get; set; }

        [JsonProperty("failures")]
        public JToken[] Failures { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Imanagedatamarts;

    public partial class WorkflowManagedActions
    {
        public ImanagedatamartsActions Imanagedatamarts(string connectionId) => new ImanagedatamartsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ImanagedatamartsTriggers Imanagedatamarts(string connectionId) => new ImanagedatamartsTriggers(connectionId);
    }
}