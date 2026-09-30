//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Haveibeenpwnedip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HaveibeenpwnedipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<AllBreachesAccountResponseItem[]> AllBreachesAccount([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<bool> truncateResponse = null, [WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<bool> includeUnverified = null)
        {
            var apiCallPath = String.Format("/api/v3/breachedaccount/{0}", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["truncateResponse"] = Convert.ToString(false);
            if (truncateResponse != null)
                callPayload.Queries["truncateResponse"] = ExpressionConverter.Convert(truncateResponse);
            if (domain != null)
                callPayload.Queries["domain"] = ExpressionConverter.Convert(domain);
            callPayload.Queries["includeUnverified"] = Convert.ToString(true);
            if (includeUnverified != null)
                callPayload.Queries["includeUnverified"] = ExpressionConverter.Convert(includeUnverified);
            return new ApiConnectionAction<AllBreachesAccountResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<string[]> DataClasses()
        {
            var apiCallPath = "/api/v3/dataclasses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<PastesResponseItem[]> Pastes([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account)
        {
            var apiCallPath = String.Format("/api/v3/pasteaccount/{0}", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PastesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<AllBreachesResponseItem[]> AllBreaches()
        {
            var apiCallPath = "/api/v3/breaches";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AllBreachesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<BreachSingleResponse> BreachSingle([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> name)
        {
            var apiCallPath = String.Format("/api/v3/breach/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BreachSingleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<BreachRecentResponse> BreachRecent()
        {
            var apiCallPath = "/api/v3/latestbreach";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BreachRecentResponse>(callPayload);
        }
    }

    public class HaveibeenpwnedipTriggers([ConnectionName] string connectionId)
    {
    }

    public class AllBreachesAccountResponseItem
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Domain { get; set; }
        public string BreachDate { get; set; }
        public string AddedDate { get; set; }
        public string ModifiedDate { get; set; }
        public int PwnCount { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string[] DataClasses { get; set; }
        public bool IsVerified { get; set; }
        public bool IsFabricated { get; set; }
        public bool IsSensitive { get; set; }
        public bool IsRetired { get; set; }
        public bool IsSpamList { get; set; }
        public bool IsMalware { get; set; }
    }

    public class PastesResponseItem
    {
        public string Source { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public int EmailCount { get; set; }
    }

    public class AllBreachesResponseItem
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Domain { get; set; }
        public string BreachDate { get; set; }
        public string AddedDate { get; set; }
        public string ModifiedDate { get; set; }
        public int PwnCount { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string[] DataClasses { get; set; }
        public bool IsVerified { get; set; }
        public bool IsFabricated { get; set; }
        public bool IsSensitive { get; set; }
        public bool IsRetired { get; set; }
        public bool IsSpamList { get; set; }
        public bool IsMalware { get; set; }
    }

    public class BreachSingleResponse
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Domain { get; set; }
        public string BreachDate { get; set; }
        public string AddedDate { get; set; }
        public string ModifiedDate { get; set; }
        public int PwnCount { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string[] DataClasses { get; set; }
        public bool IsVerified { get; set; }
        public bool IsFabricated { get; set; }
        public bool IsSensitive { get; set; }
        public bool IsRetired { get; set; }
        public bool IsSpamList { get; set; }
        public bool IsMalware { get; set; }
    }

    public class BreachRecentResponse
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Domain { get; set; }
        public string BreachDate { get; set; }
        public string AddedDate { get; set; }
        public string ModifiedDate { get; set; }
        public int PwnCount { get; set; }
        public string Description { get; set; }
        public string LogoPath { get; set; }
        public string[] DataClasses { get; set; }
        public bool IsVerified { get; set; }
        public bool IsFabricated { get; set; }
        public bool IsSensitive { get; set; }
        public bool IsRetired { get; set; }
        public bool IsSpamList { get; set; }
        public bool IsMalware { get; set; }
        public bool IsSubscriptionFree { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Haveibeenpwnedip;

    public partial class WorkflowManagedActions
    {
        public HaveibeenpwnedipActions Haveibeenpwnedip(string connectionId) => new HaveibeenpwnedipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HaveibeenpwnedipTriggers Haveibeenpwnedip(string connectionId) => new HaveibeenpwnedipTriggers(connectionId);
    }
}