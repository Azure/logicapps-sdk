//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Regexflowregularexpr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RegexflowregularexprActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "regexflowregularexpr")]
        [WorkflowExpressionFactory(nameof(__BuildRegexMultiGroup))]
        public IBodyWorkflowAction<RegexMultiGroupResponse> RegexMultiGroup([WorkflowExpression] Func<string> pattern, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "regexflowregularexpr")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RegexMultiGroupResponse> __BuildRegexMultiGroup(WorkflowExpression<string> pattern, WorkflowExpression<string> body = null)
        {
            WorkflowExpression.Validate(pattern, nameof(pattern), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<RegexMultiGroupResponse>(() =>
            {
                var apiCallPath = "/RegexMultiGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pattern"] = ExpressionConverter.Convert(pattern);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<RegexMultiGroupResponse>(callPayload);
            });
        }
    }

    public class RegexflowregularexprTriggers([ConnectionName] string connectionId)
    {
    }

    public class RegexMultiGroupResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("matches")]
        public RegexMultiGroupResponseMatchesTypeItem[] Matches { get; set; }

        [JsonProperty("caution")]
        public string Caution { get; set; }
    }

    public class RegexMultiGroupResponseMatchesTypeItem
    {
        public string MatchId { get; set; }
        public string Match { get; set; }

        [JsonProperty("groups")]
        public RegexMultiGroupResponseMatchesTypeItemGroupsTypeItem[] Groups { get; set; }
    }

    public class RegexMultiGroupResponseMatchesTypeItemGroupsTypeItem
    {
        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("groupValue")]
        public string GroupValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Regexflowregularexpr;

    public partial class WorkflowManagedActions
    {
        public RegexflowregularexprActions Regexflowregularexpr(string connectionId) => new RegexflowregularexprActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RegexflowregularexprTriggers Regexflowregularexpr(string connectionId) => new RegexflowregularexprTriggers(connectionId);
    }
}