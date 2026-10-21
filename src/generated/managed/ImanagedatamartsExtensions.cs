//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagedatamarts
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanagedatamartsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagedatamarts")]
        public IBodyWorkflowAction<ItemBatchResponse> DeleteSourceMetadataInBatch(Expression<Func<string>> itemType)
        {
            var __workflow_itemType = WorkflowExpression.Compile(itemType, nameof(itemType), required: true);
            return new DeferredBodyAction<ItemBatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/batch/{0}/metadata", __workflow_itemType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ItemBatchResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagedatamarts")]
        public IBodyWorkflowAction<ItemBatchResponse> UpdateSourceMetadataInBatch(Expression<Func<string>> itemType)
        {
            var __workflow_itemType = WorkflowExpression.Compile(itemType, nameof(itemType), required: true);
            return new DeferredBodyAction<ItemBatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/batch/{0}/metadata", __workflow_itemType.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ItemBatchResponse>(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
