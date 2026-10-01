//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Adoboards
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdoboardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListAccount> ListAccounts([WorkflowExpression] Func<string> memberId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/_apis/Accounts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["memberId"] = SourceExpressionConverter.ConvertO(memberId);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListAccount>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<Profile> GetProfile([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/_apis/profile/profiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Profile>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListProject> ListProjects([WorkflowExpression] Func<string> account)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/projects", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListProject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListRootQueryFolders([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/_apis/wit/queries", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListQueryHierarchyItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListWorkItemType> ListWorkItemTypes([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/_apis/wit/workitemtypes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListWorkItemType>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListListWorkItemResponse> ListWorkItems([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> ids)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/_apis/wit/workitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ids"] = SourceExpressionConverter.ConvertO(ids);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListListWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListQueryHierarchyItem> ListQueriesInFolder([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> folderPath)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/_apis/wit/queries/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderPath, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListQueryHierarchyItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListJObject> GetQueryResults([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<string> queryId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/_apis/wit/wiql/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(queryId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<VstsListJObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<VstsListSubject> GetSubject([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> subjectQueryDetailssearchTerm, [WorkflowExpression] Func<string[]> subjectQueryDetailssubjectKind, [WorkflowExpression] Func<string> subjectQueryDetailsscopeDescriptor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/_apis/graph/subjectquery", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subjectQueryDetails = new JObject();
                var subjectQueryDetailspropCount = 0;
                subjectQueryDetailspropCount++;
                subjectQueryDetails["query"] = SourceExpressionConverter.ConvertToken(subjectQueryDetailssearchTerm);
                subjectQueryDetailspropCount++;
                subjectQueryDetails["subjectKind"] = SourceExpressionConverter.ConvertToken(subjectQueryDetailssubjectKind);
                if (subjectQueryDetailsscopeDescriptor != null)
                {
                    subjectQueryDetails["scopeDescriptor"] = SourceExpressionConverter.ConvertToken(subjectQueryDetailsscopeDescriptor);
                    subjectQueryDetailspropCount++;
                }

                if (subjectQueryDetailspropCount > 0)
                {
                    callPayload.Body = subjectQueryDetails;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VstsListSubject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "adoboards")]
        public IBodyWorkflowAction<JToken> UpdateWorkItem([WorkflowExpression] Func<string> account, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> project, [WorkflowExpression] Func<int> workItempriority = null, [WorkflowExpression] Func<KeyValuePair[]> workItemotherFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/_apis/wit/workitems/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(account, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(project, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var workItem = new JObject();
                var workItempropCount = 0;
                if (workItempriority != null)
                {
                    workItem["priority"] = SourceExpressionConverter.ConvertToken(workItempriority);
                    workItempropCount++;
                }

                if (workItemotherFields != null)
                {
                    workItem["userEnteredFields"] = SourceExpressionConverter.ConvertToken(workItemotherFields);
                    workItempropCount++;
                }

                if (workItempropCount > 0)
                {
                    callPayload.Body = workItem;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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