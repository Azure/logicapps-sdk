//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adoboards
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdoboardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListAccount> ListAccounts(Expression<Func<string>> memberId)
        {
            var __workflow_memberId = WorkflowExpression.Compile(memberId, nameof(memberId), required: true);
            return new DeferredBodyAction<VstsListAccount>(() =>
            {
                var apiCallPath = "/_apis/Accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["memberId"] = ExpressionConverter.Convert(__workflow_memberId);
                return new ApiConnectionAction<VstsListAccount>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<Profile> GetProfile(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Profile>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/_apis/profile/profiles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Profile>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListProject> ListProjects(Expression<Func<string>> account)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            return new DeferredBodyAction<VstsListProject>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/projects", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VstsListProject>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListRootQueryFolders(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/_apis/wit/queries", __workflow_account.WithUrlEncoding(1), __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListWorkItemType> ListWorkItemTypes(Expression<Func<string>> account, Expression<Func<string>> project)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            return new DeferredBodyAction<VstsListWorkItemType>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/_apis/wit/workitemtypes", __workflow_account.WithUrlEncoding(1), __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VstsListWorkItemType>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> ListWorkItems(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> ids)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: true);
            return new DeferredBodyAction<VstsListListWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/_apis/wit/workitems", __workflow_account.WithUrlEncoding(1), __workflow_project.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = ExpressionConverter.Convert(__workflow_ids);
                return new ApiConnectionAction<VstsListListWorkItemResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListQueriesInFolder(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> folderPath)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            return new DeferredBodyAction<VstsListQueryHierarchyItem>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/_apis/wit/queries/{2}", __workflow_account.WithUrlEncoding(1), __workflow_project.WithUrlEncoding(1), __workflow_folderPath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListJObject> GetQueryResults(Expression<Func<string>> account, Expression<Func<string>> project, Expression<Func<string>> queryId)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_queryId = WorkflowExpression.Compile(queryId, nameof(queryId), required: true);
            return new DeferredBodyAction<VstsListJObject>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/_apis/wit/wiql/{2}", __workflow_account.WithUrlEncoding(1), __workflow_project.WithUrlEncoding(1), __workflow_queryId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<VstsListJObject>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListSubject> GetSubject(Expression<Func<string>> account, Expression<Func<string>> subjectQueryDetailssearchTerm, Expression<Func<string[]>> subjectQueryDetailssubjectKind, Expression<Func<string>> subjectQueryDetailsscopeDescriptor = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_subjectQueryDetailssearchTerm = WorkflowExpression.Compile(subjectQueryDetailssearchTerm, nameof(subjectQueryDetailssearchTerm), required: true);
            var __workflow_subjectQueryDetailssubjectKind = WorkflowExpression.Compile(subjectQueryDetailssubjectKind, nameof(subjectQueryDetailssubjectKind), required: true);
            var __workflow_subjectQueryDetailsscopeDescriptor = WorkflowExpression.Compile(subjectQueryDetailsscopeDescriptor, nameof(subjectQueryDetailsscopeDescriptor), required: false);
            return new DeferredBodyAction<VstsListSubject>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/_apis/graph/subjectquery", __workflow_account.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subjectQueryDetails = new JObject();
                var subjectQueryDetailspropCount = 0;
                subjectQueryDetailspropCount++;
                subjectQueryDetails["query"] = ExpressionConverter.ConvertO(__workflow_subjectQueryDetailssearchTerm);
                subjectQueryDetailspropCount++;
                subjectQueryDetails["subjectKind"] = ExpressionConverter.ConvertO(__workflow_subjectQueryDetailssubjectKind);
                if (__workflow_subjectQueryDetailsscopeDescriptor != null)
                {
                    subjectQueryDetails["scopeDescriptor"] = ExpressionConverter.ConvertO(__workflow_subjectQueryDetailsscopeDescriptor);
                    subjectQueryDetailspropCount++;
                }

                if (subjectQueryDetailspropCount > 0)
                {
                    callPayload.Body = subjectQueryDetails;
                }

                return new ApiConnectionAction<VstsListSubject>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<JToken> UpdateWorkItem(Expression<Func<string>> account, Expression<Func<string>> id, Expression<Func<string>> project, Expression<Func<int>> workItempriority = null, Expression<Func<KeyValuePair[]>> workItemotherFields = null)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_project = WorkflowExpression.Compile(project, nameof(project), required: true);
            var __workflow_workItempriority = WorkflowExpression.Compile(workItempriority, nameof(workItempriority), required: false);
            var __workflow_workItemotherFields = WorkflowExpression.Compile(workItemotherFields, nameof(workItemotherFields), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}/{1}/_apis/wit/workitems/{2}", __workflow_account.WithUrlEncoding(1), __workflow_project.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var workItem = new JObject();
                var workItempropCount = 0;
                if (__workflow_workItempriority != null)
                {
                    workItem["priority"] = ExpressionConverter.ConvertO(__workflow_workItempriority);
                    workItempropCount++;
                }

                if (__workflow_workItemotherFields != null)
                {
                    workItem["userEnteredFields"] = ExpressionConverter.ConvertO(__workflow_workItemotherFields);
                    workItempropCount++;
                }

                if (workItempropCount > 0)
                {
                    callPayload.Body = workItem;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class AdoboardsTriggers([ConnectionName] string connectionId)
    {
    }

    public class VstsListAccount
    {
        [JsonProperty("value")]
        public Account[] Value { get; set; }
    }

    public class Account
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountUri")]
        public string AccountURI { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("accountOwner")]
        public string AccountOwner { get; set; }

        [JsonProperty("organizationName")]
        public string OrganizationName { get; set; }

        [JsonProperty("accountType")]
        public string AccountType { get; set; }
    }

    public class Profile
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("publicAlias")]
        public string PublicAlias { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("revision")]
        public int Revision { get; set; }

        [JsonProperty("coreRevision")]
        public int CoreRevision { get; set; }
    }

    public class VstsListProject
    {
        [JsonProperty("value")]
        public Project[] Value { get; set; }
    }

    public class Project
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("url")]
        public string ProjectURL { get; set; }
    }

    public class VstsListQueryHierarchyItem
    {
        [JsonProperty("value")]
        public QueryHierarchyItem[] Value { get; set; }
    }

    public class QueryHierarchyItem
    {
        [JsonProperty("hasChildren")]
        public bool HasChildren { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("isFolder")]
        public bool IsFolder { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("_links")]
        public JToken Links { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class VstsListWorkItemType
    {
        [JsonProperty("value")]
        public WorkItemType[] Value { get; set; }
    }

    public class WorkItemType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("transitions")]
        public JToken Transitions { get; set; }

        [JsonProperty("icon")]
        public WorkItemTypeIconType Icon { get; set; }

        [JsonProperty("states")]
        public WorkItemStateColor[] States { get; set; }
    }

    public class WorkItemTypeIconType
    {
        [JsonProperty("id")]
        public string IconId { get; set; }

        [JsonProperty("url")]
        public string IconUrl { get; set; }
    }

    public class WorkItemStateColor
    {
        [JsonProperty("category")]
        public string CategoryOfState { get; set; }

        [JsonProperty("color")]
        public string ColorValue { get; set; }

        [JsonProperty("name")]
        public string StateName { get; set; }
    }

    public class VstsListListWorkItemResponse
    {
        [JsonProperty("value")]
        public ListWorkItemResponse[] Value { get; set; }
    }

    public class ListWorkItemResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("areaPath")]
        public string AreaPath { get; set; }

        [JsonProperty("teamProject")]
        public string TeamProject { get; set; }

        [JsonProperty("iterationPath")]
        public string IterationPath { get; set; }

        [JsonProperty("workItemType")]
        public string WorkItemType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("updatedAt")]
        public string ChangedDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("assignedToName")]
        public string AssignedToName { get; set; }
    }

    public class VstsListJObject
    {
        [JsonProperty("value")]
        public JToken[] Value { get; set; }
    }

    public class VstsListSubject
    {
        [JsonProperty("value")]
        public Subject[] Value { get; set; }
    }

    public class Subject
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("mailAddress")]
        public string MailAddress { get; set; }

        [JsonProperty("principalName")]
        public string PrincipalName { get; set; }

        [JsonProperty("subjectKind")]
        public string SubjectKind { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class KeyValuePair
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Adoboards;

    public partial class WorkflowManagedActions
    {
        public AdoboardsActions Adoboards(string connectionId) => new AdoboardsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdoboardsTriggers Adoboards(string connectionId) => new AdoboardsTriggers(connectionId);
    }
}
