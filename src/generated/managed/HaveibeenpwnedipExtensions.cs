//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Haveibeenpwnedip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HaveibeenpwnedipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<AllBreachesAccountResponseItem[], ApiConnectionActionConfiguration> AllBreachesAccount(Expression<Func<string>> account, Expression<Func<bool>> truncateResponse = null, Expression<Func<string>> domain = null, Expression<Func<bool>> includeUnverified = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_truncateResponse = WorkflowExpression.Compile(truncateResponse, nameof(truncateResponse), required: false);
            var __workflow_domain = WorkflowExpression.Compile(domain, nameof(domain), required: false);
            var __workflow_includeUnverified = WorkflowExpression.Compile(includeUnverified, nameof(includeUnverified), required: false);
            return new DeferredBodyAction<AllBreachesAccountResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/breachedaccount/{0}", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["truncateResponse"] = Convert.ToString(false);
                if (__workflow_truncateResponse != null)
                    callPayload.Queries["truncateResponse"] = ExpressionConverter.Convert(__workflow_truncateResponse);
                if (__workflow_domain != null)
                    callPayload.Queries["domain"] = ExpressionConverter.Convert(__workflow_domain);
                callPayload.Queries["includeUnverified"] = Convert.ToString(true);
                if (__workflow_includeUnverified != null)
                    callPayload.Queries["includeUnverified"] = ExpressionConverter.Convert(__workflow_includeUnverified);
                return new ApiConnectionAction<AllBreachesAccountResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> DataClasses()
        {
            var apiCallPath = "/api/v3/dataclasses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<PastesResponseItem[], ApiConnectionActionConfiguration> Pastes(Expression<Func<string>> account)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            return new DeferredBodyAction<PastesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/pasteaccount/{0}", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PastesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<AllBreachesResponseItem[], ApiConnectionActionConfiguration> AllBreaches()
        {
            var apiCallPath = "/api/v3/breaches";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AllBreachesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<BreachSingleResponse, ApiConnectionActionConfiguration> BreachSingle(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<BreachSingleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/breach/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BreachSingleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "haveibeenpwnedip")]
        public IBodyWorkflowAction<BreachRecentResponse, ApiConnectionActionConfiguration> BreachRecent()
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
