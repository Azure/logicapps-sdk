//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class AbbreviationsipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abbreviationsip")]
        public IBodyWorkflowAction<AbbrGetResponse> AbbrGet(Expression<Func<string>> term, Expression<Func<string>> categoryid = null, Expression<Func<sortbyInput>> sortby = null, Expression<Func<searchtypeInput>> searchtype = null)
        {
            var __workflow_term = term == null ? null : WorkflowExpression.Compile(term);
            WorkflowExpression.Validate(__workflow_term, nameof(term), required: true);
            var __workflow_categoryid = categoryid == null ? null : WorkflowExpression.Compile(categoryid);
            WorkflowExpression.Validate(__workflow_categoryid, nameof(categoryid), required: false);
            var __workflow_sortby = sortby == null ? null : WorkflowExpression.Compile(sortby);
            WorkflowExpression.Validate(__workflow_sortby, nameof(sortby), required: false);
            var __workflow_searchtype = searchtype == null ? null : WorkflowExpression.Compile(searchtype);
            WorkflowExpression.Validate(__workflow_searchtype, nameof(searchtype), required: false);
            return new DeferredBodyAction<AbbrGetResponse>(() =>
            {
                var apiCallPath = "/abbr.php";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["term"] = ExpressionConverter.Convert(__workflow_term);
                if (__workflow_categoryid != null)
                    callPayload.Queries["categoryid"] = ExpressionConverter.Convert(__workflow_categoryid);
                callPayload.Queries["sortby"] = Convert.ToString("p");
                if (__workflow_sortby != null)
                    callPayload.Queries["sortby"] = ExpressionConverter.Convert(__workflow_sortby);
                callPayload.Queries["searchtype"] = Convert.ToString("e");
                if (__workflow_searchtype != null)
                    callPayload.Queries["searchtype"] = ExpressionConverter.Convert(__workflow_searchtype);
                callPayload.Queries["format"] = Convert.ToString("json");
                return new ApiConnectionAction<AbbrGetResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum sortbyInput
    {
        [EnumMember(Value = "p")]
        Popularity,
        [EnumMember(Value = "a")]
        Alphabetically,
        [EnumMember(Value = "c")]
        Category
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum searchtypeInput
    {
        [EnumMember(Value = "e")]
        ExactMatch,
        [EnumMember(Value = "r")]
        ReverseLookup
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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
