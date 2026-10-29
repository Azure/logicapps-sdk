//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Loopioint01
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Loopioint01Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "loopioint01")]
        public IBodyWorkflowAction<ListStacksResponse, ApiConnectionActionConfiguration> ListStacks(Expression<Func<string>> fields = null)
        {
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            return new DeferredBodyAction<ListStacksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/stacks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fields"] = Convert.ToString("@wide");
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                return new ApiConnectionAction<ListStacksResponse>(callPayload);
            });
        }
    }

    public class Loopioint01Triggers([ConnectionName] string connectionId)
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
        public int StackId { get; set; }

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
        public int StackId { get; set; }

        [JsonProperty("categoryID")]
        public int CategoryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Loopioint01;

    public partial class WorkflowManagedActions
    {
        public Loopioint01Actions Loopioint01(string connectionId) => new Loopioint01Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Loopioint01Triggers Loopioint01(string connectionId) => new Loopioint01Triggers(connectionId);
    }
}