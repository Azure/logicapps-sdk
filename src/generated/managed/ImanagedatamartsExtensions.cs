//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Imanagedatamarts
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ImanagedatamartsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagedatamarts")]
        public IBodyWorkflowAction<ItemBatchResponse> DeleteSourceMetadataInBatch(Expression<Func<string>> itemType)
        {
            var apiCallPath = String.Format("/batch/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(itemType, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ItemBatchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "imanagedatamarts")]
        public IBodyWorkflowAction<ItemBatchResponse> UpdateSourceMetadataInBatch(Expression<Func<string>> itemType)
        {
            var apiCallPath = String.Format("/batch/{0}/metadata", ExpressionConverter.ConvertWithUrlEncoding(itemType, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ItemBatchResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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