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
        [WorkflowExpressionFactory(nameof(__BuildAllBreachesAccount))]
        public IBodyWorkflowAction<AllBreachesAccountResponseItem[]> AllBreachesAccount([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<bool> truncateResponse = null, [WorkflowExpression] Func<string> domain = null, [WorkflowExpression] Func<bool> includeUnverified = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AllBreachesAccountResponseItem[]> __BuildAllBreachesAccount(WorkflowExpression<string> account, WorkflowExpression<bool> truncateResponse = null, WorkflowExpression<string> domain = null, WorkflowExpression<bool> includeUnverified = null)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            WorkflowExpression.Validate(truncateResponse, nameof(truncateResponse), required: false);
            WorkflowExpression.Validate(domain, nameof(domain), required: false);
            WorkflowExpression.Validate(includeUnverified, nameof(includeUnverified), required: false);
            return new DeferredBodyAction<AllBreachesAccountResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v3/breachedaccount/{0}", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildPastes))]
        public IBodyWorkflowAction<PastesResponseItem[]> Pastes([WorkflowExpression] Func<string> account)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PastesResponseItem[]> __BuildPastes(WorkflowExpression<string> account)
        {
            WorkflowExpression.Validate(account, nameof(account), required: true);
            return new DeferredBodyAction<PastesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v3/pasteaccount/{0}", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PastesResponseItem[]>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildBreachSingle))]
        public IBodyWorkflowAction<BreachSingleResponse> BreachSingle([WorkflowExpression] Func<string> name)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BreachSingleResponse> __BuildBreachSingle(WorkflowExpression<string> name)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            return new DeferredBodyAction<BreachSingleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v3/breach/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BreachSingleResponse>(callPayload);
            });
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