//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Regexflowregularexpr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RegexflowregularexprActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "regexflowregularexpr")]
        public IBodyWorkflowAction<RegexMultiGroupResponse> RegexMultiGroup([WorkflowExpression] Func<string> pattern, [WorkflowExpression] Func<string> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/RegexMultiGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["pattern"] = SourceExpressionConverter.ConvertO(pattern);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<RegexMultiGroupResponse>(BuildSourceInput);
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