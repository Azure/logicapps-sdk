//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loopio
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LoopioActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loopio")]
        [WorkflowExpressionFactory(nameof(__BuildListStacks))]
        public IBodyWorkflowAction<ListStacksResponse> ListStacks([WorkflowExpression] Func<string> fields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loopio")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListStacksResponse> __BuildListStacks(WorkflowExpression<string> fields = null)
        {
            WorkflowExpression.Validate(fields, nameof(fields), required: false);
            return new DeferredBodyAction<ListStacksResponse>(() =>
            {
                var apiCallPath = "/stacks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("@wide");
                if (fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
                return new ApiConnectionAction<ListStacksResponse>(callPayload);
            });
        }
    }

    public class LoopioTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListStacksResponse
    {
        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("items")]
        public ListStacksResponseItemsTypeItem[] Items { get; set; }
    }

    public class ListStacksResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("categories")]
        public ListStacksResponseItemsTypeItemCategoriesTypeItem[] Categories { get; set; }
    }

    public class ListStacksResponseItemsTypeItemCategoriesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stackID")]
        public int StackID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subCategories")]
        public ListStacksResponseItemsTypeItemCategoriesTypeItemSubCategoriesTypeItem[] SubCategories { get; set; }
    }

    public class ListStacksResponseItemsTypeItemCategoriesTypeItemSubCategoriesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stackID")]
        public int StackID { get; set; }

        [JsonProperty("categoryID")]
        public int CategoryID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Loopio;

    public partial class WorkflowManagedActions
    {
        public LoopioActions Loopio(string connectionId) => new LoopioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LoopioTriggers Loopio(string connectionId) => new LoopioTriggers(connectionId);
    }
}