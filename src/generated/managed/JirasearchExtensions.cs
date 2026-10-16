//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jirasearch
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JirasearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jirasearch")]
        public IBodyWorkflowAction<SimpleSearchResponse> SimpleSearch(Expression<Func<string>> jql, Expression<Func<string>> hostname, Expression<Func<string>> fields, Expression<Func<string>> expand = null, Expression<Func<int>> startAt = null, Expression<Func<int>> maxResults = null)
        {
            var __workflow_jql = WorkflowExpression.Compile(jql, nameof(jql), required: true);
            var __workflow_hostname = WorkflowExpression.Compile(hostname, nameof(hostname), required: true);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_startAt = WorkflowExpression.Compile(startAt, nameof(startAt), required: false);
            var __workflow_maxResults = WorkflowExpression.Compile(maxResults, nameof(maxResults), required: false);
            return new DeferredBodyAction<SimpleSearchResponse>(() =>
            {
                var apiCallPath = "/rest/api/2/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jql"] = ExpressionConverter.Convert(__workflow_jql);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Queries["hostname"] = ExpressionConverter.Convert(__workflow_hostname);
                callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_startAt != null)
                    callPayload.Queries["startAt"] = ExpressionConverter.Convert(__workflow_startAt);
                callPayload.Queries["maxResults"] = Convert.ToString(50);
                if (__workflow_maxResults != null)
                    callPayload.Queries["maxResults"] = ExpressionConverter.Convert(__workflow_maxResults);
                return new ApiConnectionAction<SimpleSearchResponse>(callPayload);
            });
        }
    }

    public class JirasearchTriggers([ConnectionName] string connectionId)
    {
    }

    public class SimpleSearchResponse
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }

        [JsonProperty("startAt")]
        public int StartAt { get; set; }

        [JsonProperty("maxResults")]
        public int MaxResults { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("issues")]
        public SimpleSearchResponseIssuesTypeItem[] Issues { get; set; }
    }

    public class SimpleSearchResponseIssuesTypeItem
    {
        [JsonProperty("expand")]
        public string Expand { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("fields")]
        public SimpleSearchResponseIssuesTypeItemFieldsType Fields { get; set; }
    }

    public class SimpleSearchResponseIssuesTypeItemFieldsType
    {
        [JsonProperty("issuelinks")]
        public JToken[] Issuelinks { get; set; }

        [JsonProperty("assignee")]
        public JToken Assignee { get; set; }

        [JsonProperty("subtasks")]
        public JToken[] Subtasks { get; set; }

        [JsonProperty("votes")]
        public JToken Votes { get; set; }

        [JsonProperty("worklog")]
        public JToken Worklog { get; set; }

        [JsonProperty("issuetype")]
        public SimpleSearchResponseIssuesTypeItemFieldsTypeIssuetypeType Issuetype { get; set; }

        [JsonProperty("timetracking")]
        public JToken Timetracking { get; set; }

        [JsonProperty("status")]
        public JToken Status { get; set; }

        [JsonProperty("creator")]
        public JToken Creator { get; set; }

        [JsonProperty("workratio")]
        public int Workratio { get; set; }

        [JsonProperty("labels")]
        public JToken[] Labels { get; set; }

        [JsonProperty("components")]
        public JToken[] Components { get; set; }

        [JsonProperty("reporter")]
        public JToken Reporter { get; set; }

        [JsonProperty("progress")]
        public SimpleSearchResponseIssuesTypeItemFieldsTypeProgressType Progress { get; set; }

        [JsonProperty("project")]
        public SimpleSearchResponseIssuesTypeItemFieldsTypeProjectType Project { get; set; }

        [JsonProperty("watches")]
        public JToken Watches { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("comment")]
        public JToken Comment { get; set; }

        [JsonProperty("statuscategorychangedate")]
        public string Statuscategorychangedate { get; set; }

        [JsonProperty("fixVersions")]
        public JToken[] FixVersions { get; set; }

        [JsonProperty("priority")]
        public SimpleSearchResponseIssuesTypeItemFieldsTypePriorityType Priority { get; set; }

        [JsonProperty("versions")]
        public JToken[] Versions { get; set; }

        [JsonProperty("aggregateprogress")]
        public SimpleSearchResponseIssuesTypeItemFieldsTypeAggregateprogressType Aggregateprogress { get; set; }

        [JsonProperty("issuerestriction")]
        public JToken Issuerestriction { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }
    }

    public class SimpleSearchResponseIssuesTypeItemFieldsTypeIssuetypeType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subtask")]
        public bool Subtask { get; set; }

        [JsonProperty("avatarId")]
        public int AvatarId { get; set; }

        [JsonProperty("hierarchyLevel")]
        public int HierarchyLevel { get; set; }
    }

    public class SimpleSearchResponseIssuesTypeItemFieldsTypeProgressType
    {
        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class SimpleSearchResponseIssuesTypeItemFieldsTypeProjectType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("projectTypeKey")]
        public string ProjectTypeKey { get; set; }

        [JsonProperty("simplified")]
        public bool Simplified { get; set; }
    }

    public class SimpleSearchResponseIssuesTypeItemFieldsTypePriorityType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class SimpleSearchResponseIssuesTypeItemFieldsTypeAggregateprogressType
    {
        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jirasearch;

    public partial class WorkflowManagedActions
    {
        public JirasearchActions Jirasearch(string connectionId) => new JirasearchActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JirasearchTriggers Jirasearch(string connectionId) => new JirasearchTriggers(connectionId);
    }
}
