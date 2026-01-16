//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rencoregovernance
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RencoregovernanceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rencoregovernance")]
        public IBodyWorkflowAction<GetViolationsResponse> GetViolations(Expression<Func<string>> workspaceId, Expression<Func<string>> environmentId, Expression<Func<string>> checkId)
        {
            var apiCallPath = String.Format("/v1/workspaces/{0}/environments/{1}/checks/{2}/results", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(checkId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetViolationsResponse>(callPayload);
        }
    }

    public class RencoregovernanceTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CheckNotificationTrigger(Expression<Func<string>> workspaceId, Expression<Func<string>> environmentId, Expression<Func<string>> checkId)
        {
            var apiCallPath = String.Format("/v1/workspaces/{0}/environments/{1}/checks/{2}/hooks", ExpressionConverter.ConvertWithUrlEncoding(workspaceId, 1), ExpressionConverter.ConvertWithUrlEncoding(environmentId, 1), ExpressionConverter.ConvertWithUrlEncoding(checkId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class GetViolationsResponse
    {
        [JsonProperty("checkInfo")]
        public GetViolationsResponseCheckInfoType CheckInfo { get; set; }

        [JsonProperty("affectedUsers")]
        public ViolationResourcePrincipal[] AffectedUsers { get; set; }

        [JsonProperty("nonCompliantResources")]
        public ViolationResource[] NonCompliantResources { get; set; }

        [JsonProperty("totalAffectedUsers")]
        public int TotalAffectedUsers { get; set; }

        [JsonProperty("totalNonCompliantResources")]
        public int TotalNonCompliantResources { get; set; }

        [JsonProperty("totalResources")]
        public int TotalResources { get; set; }
    }

    public class GetViolationsResponseCheckInfoType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("targetService")]
        public string TargetService { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("totalCount")]
        public JToken TotalCount { get; set; }
    }

    public class ViolationResourcePrincipal
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ownedNonCompliantResources")]
        public ViolationResourceWithoutPrincipals[] OwnedNonCompliantResources { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("usedNonCompliantResources")]
        public ViolationResourceWithoutPrincipals[] UsedNonCompliantResources { get; set; }
    }

    public class ViolationResourceWithoutPrincipals
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUsed")]
        public string LastUsed { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nonCompliantSince")]
        public string NonCompliantSince { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ViolationResource
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastUsed")]
        public string LastUsed { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nonCompliantSince")]
        public string NonCompliantSince { get; set; }

        [JsonProperty("owners")]
        public ViolationResourcePrincipalWithoutResources[] Owners { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("users")]
        public ViolationResourcePrincipalWithoutResources[] Users { get; set; }
    }

    public class ViolationResourcePrincipalWithoutResources
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rencoregovernance;

    public partial class WorkflowManagedActions
    {
        public RencoregovernanceActions Rencoregovernance(string connectionId) => new RencoregovernanceActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RencoregovernanceTriggers Rencoregovernance(string connectionId) => new RencoregovernanceTriggers(connectionId);
    }
}