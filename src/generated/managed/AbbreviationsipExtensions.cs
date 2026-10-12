//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AbbreviationsipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "abbreviationsip")]
        [WorkflowExpressionFactory(nameof(__BuildAbbrGet))]
        public IBodyWorkflowAction<AbbrGetResponse> AbbrGet([WorkflowExpression] Func<string> term, [WorkflowExpression] Func<string> categoryid = null, [WorkflowExpression] Func<sortbyInput> sortby = null, [WorkflowExpression] Func<searchtypeInput> searchtype = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AbbrGetResponse> __BuildAbbrGet(WorkflowExpression<string> term, WorkflowExpression<string> categoryid = null, WorkflowExpression<sortbyInput> sortby = null, WorkflowExpression<searchtypeInput> searchtype = null)
        {
            WorkflowExpression.Validate(term, nameof(term), required: true);
            WorkflowExpression.Validate(categoryid, nameof(categoryid), required: false);
            WorkflowExpression.Validate(sortby, nameof(sortby), required: false);
            WorkflowExpression.Validate(searchtype, nameof(searchtype), required: false);
            return new DeferredBodyAction<AbbrGetResponse>(() =>
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