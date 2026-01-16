//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbbreviationsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abbreviationsip")]
        public IBodyWorkflowAction<AbbrGetResponse> AbbrGet(Expression<Func<string>> term, Expression<Func<string>> categoryid = null, Expression<Func<sortbyInput>> sortby = null, Expression<Func<searchtypeInput>> searchtype = null)
        {
            var apiCallPath = "/abbr.php";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["term"] = ExpressionConverter.Convert(term);
            if (categoryid != null)
                callPayload.Queries["categoryid"] = ExpressionConverter.Convert(categoryid);
            callPayload.Queries["sortby"] = Convert.ToString("p");
            if (sortby != null)
                callPayload.Queries["sortby"] = ExpressionConverter.Convert(sortby);
            callPayload.Queries["searchtype"] = Convert.ToString("e");
            if (searchtype != null)
                callPayload.Queries["searchtype"] = ExpressionConverter.Convert(searchtype);
            callPayload.Queries["format"] = Convert.ToString("json");
            return new ApiConnectionAction<AbbrGetResponse>(callPayload);
        }
    }

    public class AbbreviationsipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AbbrGetResponse
    {
        [JsonProperty("result")]
        public AbbrGetResponseResultTypeItem[] Result { get; set; }
    }

    public class AbbrGetResponseResultTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("categoryname")]
        public string Categoryname { get; set; }

        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public enum sortbyInput
    {
        [EnumMember(Value = "p")]
        Popularity,
        [EnumMember(Value = "a")]
        Alphabetically,
        [EnumMember(Value = "c")]
        Category
    }

    public enum searchtypeInput
    {
        [EnumMember(Value = "e")]
        ExactMatch,
        [EnumMember(Value = "r")]
        ReverseLookup
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;

    public partial class WorkflowManagedActions
    {
        public AbbreviationsipActions Abbreviationsip(string connectionId) => new AbbreviationsipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AbbreviationsipTriggers Abbreviationsip(string connectionId) => new AbbreviationsipTriggers(connectionId);
    }
}