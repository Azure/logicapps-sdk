//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jirasearch
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JirasearchActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jirasearch")]
        public IBodyWorkflowAction<SimpleSearchResponse> SimpleSearch([WorkflowExpression] Func<string> jql, [WorkflowExpression] Func<string> hostname, [WorkflowExpression] Func<string> fields, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<int> startAt = null, [WorkflowExpression] Func<int> maxResults = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rest/api/2/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["jql"] = SourceExpressionConverter.ConvertO(jql);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.ConvertO(expand);
                callPayload.Queries["hostname"] = SourceExpressionConverter.ConvertO(hostname);
                callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (startAt != null)
                    callPayload.Queries["startAt"] = SourceExpressionConverter.ConvertO(startAt);
                callPayload.Queries["maxResults"] = Convert.ToString(50);
                if (maxResults != null)
                    callPayload.Queries["maxResults"] = SourceExpressionConverter.ConvertO(maxResults);
                return callPayload;
            }

            return new ApiConnectionAction<SimpleSearchResponse>(BuildSourceInput);
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