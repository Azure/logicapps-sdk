//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adoboards
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdoboardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListAccount> ListAccounts([WorkflowExpression] Func<string> memberId)
        {
            var apiCallPath = "/_apis/Accounts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["memberId"] = ExpressionConverter.Convert(memberId);
            return new ApiConnectionAction<VstsListAccount>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<Profile> GetProfile([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/_apis/profile/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Profile>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListProject> ListProjects([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account)
        {
            var apiCallPath = String.Format("/{0}/_apis/projects", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VstsListProject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListRootQueryFolders([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> project)
        {
            var apiCallPath = String.Format("/{0}/{1}/_apis/wit/queries", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(project, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListWorkItemType> ListWorkItemTypes([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> project)
        {
            var apiCallPath = String.Format("/{0}/{1}/_apis/wit/workitemtypes", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(project, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VstsListWorkItemType>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> ListWorkItems([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> project, [WorkflowExpression] Func<string> ids)
        {
            var apiCallPath = String.Format("/{0}/{1}/_apis/wit/workitems", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(project, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["ids"] = ExpressionConverter.Convert(ids);
            return new ApiConnectionAction<VstsListListWorkItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListQueriesInFolder([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> project, [WorkflowExpression] Func<string> folderPath)
        {
            var apiCallPath = String.Format("/{0}/{1}/_apis/wit/queries/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(folderPath, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VstsListQueryHierarchyItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListJObject> GetQueryResults([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> project, [WorkflowExpression] Func<string> queryId)
        {
            var apiCallPath = String.Format("/{0}/{1}/_apis/wit/wiql/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(queryId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<VstsListJObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListSubject> GetSubject([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression] Func<string> subjectQueryDetailssearchTerm, [WorkflowExpression] Func<string[]> subjectQueryDetailssubjectKind, [WorkflowExpression] Func<string> subjectQueryDetailsscopeDescriptor = null)
        {
            var apiCallPath = String.Format("/{0}/_apis/graph/subjectquery", ExpressionConverter.ConvertWithUrlEncoding(account, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var subjectQueryDetails = new JObject();
            var subjectQueryDetailspropCount = 0;
            subjectQueryDetailspropCount++;
            subjectQueryDetails["query"] = ExpressionConverter.ConvertO(subjectQueryDetailssearchTerm);
            subjectQueryDetailspropCount++;
            subjectQueryDetails["subjectKind"] = ExpressionConverter.ConvertO(subjectQueryDetailssubjectKind);
            if (subjectQueryDetailsscopeDescriptor != null)
            {
                subjectQueryDetails["scopeDescriptor"] = ExpressionConverter.ConvertO(subjectQueryDetailsscopeDescriptor);
                subjectQueryDetailspropCount++;
            }

            if (subjectQueryDetailspropCount > 0)
            {
                callPayload.Body = subjectQueryDetails;
            }

            return new ApiConnectionAction<VstsListSubject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<JToken> UpdateWorkItem([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> account, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> workItempriority = null, [WorkflowExpression] Func<KeyValuePair[]> workItemotherFields = null)
        {
            var apiCallPath = String.Format("/{0}/{1}/_apis/wit/workitems/{2}", ExpressionConverter.ConvertWithUrlEncoding(account, 1), ExpressionConverter.ConvertWithUrlEncoding(project, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var workItem = new JObject();
            var workItempropCount = 0;
            if (workItempriority != null)
            {
                workItem["priority"] = ExpressionConverter.ConvertO(workItempriority);
                workItempropCount++;
            }

            if (workItemotherFields != null)
            {
                workItem["userEnteredFields"] = ExpressionConverter.ConvertO(workItemotherFields);
                workItempropCount++;
            }

            if (workItempropCount > 0)
            {
                callPayload.Body = workItem;
            }

            return new ApiConnectionAction<JToken>(callPayload);
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