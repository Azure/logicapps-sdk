//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Interaction
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InteractionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "interaction")]
        public IBodyWorkflowAction<ListResponse> ReadLists(Expression<Func<bodyvariableslistClassInput>> bodyvariableslistClass = null, Expression<Func<int>> bodyvariablesskip = null, Expression<Func<int>> bodyvariableslimit = null, Expression<Func<string>> bodyvariablesfilterByName = null)
        {
            var apiCallPath = "/graphql/ReadLists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["query"] = "query Lists($listClass: [ListClass], $skip: Int, $limit: Int, $filterByName: String) {   lists(listClass: $listClass, skip: $skip, limit: $limit,  filter: {field: name, value: $filterByName}) {     skip     limit     totalModels     models {       id       name       description       listType {         id         isActive         listClass         name       }       allowedLinkInto       allowedRemoveFrom       addAllowed       deleteAllowed       addActivityAllowed       addNoteAllowed       ownerName       creatorName       allowedContactEntity       isAdministrator     }   } }";
            bodypropCount++;
            var variablesObject = new JObject();
            var variablesObjectpropCount = 0;
            if (bodyvariableslistClass != null)
            {
                variablesObject["listClass"] = ExpressionConverter.ConvertO(bodyvariableslistClass);
                variablesObjectpropCount++;
            }

            if (bodyvariablesskip != null)
            {
                variablesObject["skip"] = ExpressionConverter.ConvertO(bodyvariablesskip);
                variablesObjectpropCount++;
            }

            if (bodyvariableslimit != null)
            {
                variablesObject["limit"] = ExpressionConverter.ConvertO(bodyvariableslimit);
                variablesObjectpropCount++;
            }

            if (bodyvariablesfilterByName != null)
            {
                variablesObject["filterByName"] = ExpressionConverter.ConvertO(bodyvariablesfilterByName);
                variablesObjectpropCount++;
            }

            if (variablesObjectpropCount > 0)
            {
                body["variables"] = variablesObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ListResponse>(callPayload);
        }
    }

    public class InteractionTriggers([ConnectionName] string connectionId)
    {
    }

    public class ListResponse
    {
        [JsonProperty("data")]
        public ListResponseDataType Data { get; set; }
    }

    public class ListResponseDataType
    {
        [JsonProperty("lists")]
        public ListResponseDataTypeListsType Lists { get; set; }
    }

    public class ListResponseDataTypeListsType
    {
        [JsonProperty("skip")]
        public int Skip { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("totalModels")]
        public int TotalModels { get; set; }

        [JsonProperty("models")]
        public ListResponseDataTypeListsTypeModelsTypeItem[] Models { get; set; }
    }

    public class ListResponseDataTypeListsTypeModelsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("listType")]
        public ListResponseDataTypeListsTypeModelsTypeItemListTypeType ListType { get; set; }

        [JsonProperty("allowedLinkInto")]
        public bool AllowedLinkInto { get; set; }

        [JsonProperty("allowedRemoveFrom")]
        public bool AllowedRemoveFrom { get; set; }

        [JsonProperty("addAllowed")]
        public bool AddAllowed { get; set; }

        [JsonProperty("deleteAllowed")]
        public bool DeleteAllowed { get; set; }

        [JsonProperty("addActivityAllowed")]
        public bool AddActivityAllowed { get; set; }

        [JsonProperty("addNoteAllowed")]
        public bool AddNoteAllowed { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("allowedContactEntity")]
        public string AllowedContactEntity { get; set; }

        [JsonProperty("isAdministrator")]
        public bool IsAdministrator { get; set; }
    }

    public class ListResponseDataTypeListsTypeModelsTypeItemListTypeType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("listClass")]
        public string ListClass { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum bodyvariableslistClassInput
    {
        MarketingList,
        MarketingListWithSponsorship,
        WorkingList,
        AllLists,
        AllMarketingLists
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Interaction;

    public partial class WorkflowManagedActions
    {
        public InteractionActions Interaction(string connectionId) => new InteractionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InteractionTriggers Interaction(string connectionId) => new InteractionTriggers(connectionId);
    }
}