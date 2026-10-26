//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vocean
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoceanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<GetIdeasResponseItem[], ApiConnectionActionConfiguration> GetIdeas(Expression<Func<string>> activityId, Expression<Func<string>> networkId = null)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            return new DeferredBodyAction<GetIdeasResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/data/connector/innovate/activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(__workflow_networkId);
                callPayload.Queries["activityId"] = ExpressionConverter.Convert(__workflow_activityId);
                return new ApiConnectionAction<GetIdeasResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<GetVotesResponseItem[], ApiConnectionActionConfiguration> GetVotes(Expression<Func<string>> activityId, Expression<Func<string>> networkId = null)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            return new DeferredBodyAction<GetVotesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/data/connector/vote/activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(__workflow_networkId);
                callPayload.Queries["activityId"] = ExpressionConverter.Convert(__workflow_activityId);
                return new ApiConnectionAction<GetVotesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<GetExploreResponsesResponseItem[], ApiConnectionActionConfiguration> GetExploreResponses(Expression<Func<string>> activityId, Expression<Func<string>> networkId = null)
        {
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            return new DeferredBodyAction<GetExploreResponsesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/data/connector/explore/activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(__workflow_networkId);
                callPayload.Queries["activityId"] = ExpressionConverter.Convert(__workflow_activityId);
                return new ApiConnectionAction<GetExploreResponsesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<GetSpacesResponseItem[], ApiConnectionActionConfiguration> GetSpaces()
        {
            return new DeferredBodyAction<GetSpacesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/connector/v2/networks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpacesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<GetActivitiesResponseItem[], ApiConnectionActionConfiguration> GetActivities(Expression<Func<string>> networkId, Expression<Func<activityTypeInput>> activityType)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: true);
            var __workflow_activityType = WorkflowExpression.Compile(activityType, nameof(activityType), required: true);
            return new DeferredBodyAction<GetActivitiesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/connector/v2/networks/{0}/activities", __workflow_networkId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["activityType"] = ExpressionConverter.Convert(__workflow_activityType);
                return new ApiConnectionAction<GetActivitiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<AddIdeaResponse, ApiConnectionActionConfiguration> AddIdea(Expression<Func<string>> networkId, Expression<Func<string>> activityId, Expression<Func<AddIdeaInput>> body)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: true);
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddIdeaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/connector/v2/networks/{0}/activities/{1}/ideas", __workflow_networkId.WithUrlEncoding(1), __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddIdeaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<AddIdeasResponseItem[], ApiConnectionActionConfiguration> AddIdeas(Expression<Func<string>> networkId, Expression<Func<string>> activityId, Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: true);
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddIdeasResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/connector/v2/networks/{0}/activities/{1}/ideas/many", __workflow_networkId.WithUrlEncoding(1), __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddIdeasResponseItem[]>(callPayload);
            });
        }
    }

    public class VoceanTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IdeaTrigger(Expression<Func<string>> networkId, Expression<Func<string>> activityId, Expression<Func<IdeaTriggerInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: true);
            var __workflow_activityId = WorkflowExpression.Compile(activityId, nameof(activityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/connector/v2/networks/{0}/activities/{1}/ideas/webhooks", __workflow_networkId.WithUrlEncoding(1), __workflow_activityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> UserActivityTrigger(Expression<Func<UserActivityTriggerInput>> body, Expression<Func<string>> networkId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_networkId = WorkflowExpression.Compile(networkId, nameof(networkId), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/connector/v2/current-user/activities/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(__workflow_networkId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetIdeasResponseItem
    {
        [JsonProperty("ideaId")]
        public string IdeaId { get; set; }

        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("ideaCreateDate")]
        public string IdeaCreateDate { get; set; }

        [JsonProperty("ideaTextOriginal")]
        public string IdeaTextOriginal { get; set; }

        [JsonProperty("ideaKeyPhrasesOriginal")]
        public string[] IdeaKeyPhrasesOriginal { get; set; }

        [JsonProperty("ideaTextEnglishTranslation")]
        public string IdeaTextEnglishTranslation { get; set; }

        [JsonProperty("ideaKeyPhrasesEnglishTranslation")]
        public string[] IdeaKeyPhrasesEnglishTranslation { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("ideaPropertyValues")]
        public GetIdeasResponseItemIdeaPropertyValuesTypeItem[] IdeaPropertyValues { get; set; }

        [JsonProperty("ideaCategories")]
        public string[] IdeaCategories { get; set; }
    }

    public class GetIdeasResponseItemIdeaPropertyValuesTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GetVotesResponseItem
    {
        [JsonProperty("voteId")]
        public string VoteId { get; set; }

        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("voteCreateDate")]
        public string VoteCreateDate { get; set; }

        [JsonProperty("voteOptionValues")]
        public GetVotesResponseItemVoteOptionValuesTypeItem[] VoteOptionValues { get; set; }
    }

    public class GetVotesResponseItemVoteOptionValuesTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetExploreResponsesResponseItem
    {
        [JsonProperty("responseId")]
        public string ResponseId { get; set; }

        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("questionId")]
        public string QuestionId { get; set; }

        [JsonProperty("responder")]
        public string Responder { get; set; }

        [JsonProperty("responseCreateDate")]
        public string ResponseCreateDate { get; set; }

        [JsonProperty("questionOrder")]
        public int QuestionOrder { get; set; }

        [JsonProperty("questionText")]
        public string QuestionText { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("responseTextOriginal")]
        public string ResponseTextOriginal { get; set; }

        [JsonProperty("responseTextEnglishTranslation")]
        public string ResponseTextEnglishTranslation { get; set; }

        [JsonProperty("responseNumericValue")]
        public string ResponseNumericValue { get; set; }

        [JsonProperty("responseSliderValue")]
        public string ResponseSliderValue { get; set; }

        [JsonProperty("responseYesNoValue")]
        public GetExploreResponsesResponseItemResponseYesNoValueType ResponseYesNoValue { get; set; }

        [JsonProperty("responseMultipleValues")]
        public GetExploreResponsesResponseItemResponseMultipleValuesTypeItem[] ResponseMultipleValues { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetExploreResponsesResponseItemResponseYesNoValueType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class GetExploreResponsesResponseItemResponseMultipleValuesTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetSpacesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetActivitiesResponseItem
    {
        [JsonProperty("activityId")]
        public string ActivityId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }

        [JsonProperty("activityType")]
        public string ActivityType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum activityTypeInput
    {
        Innovate,
        Prioritize,
        Explore
    }

    public class AddIdeaResponse
    {
        [JsonProperty("ideaId")]
        public string IdeaId { get; set; }
    }

    public class AddIdeaInput
    {
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }
    }

    public class AddIdeasResponseItem
    {
        [JsonProperty("ideaId")]
        public string IdeaId { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class IdeaTriggerInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("eventTypes")]
        public IdeaTriggerInputEventTypesTypeItem[] EventTypes { get; set; }
    }

    public class IdeaTriggerInputEventTypesTypeItem
    {
        [JsonProperty("eventType")]
        public string EventType { get; set; }
    }

    public class UserActivityTriggerInput
    {
        [JsonProperty("targetUrl", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("eventTypes")]
        public UserActivityTriggerInputEventTypesTypeItem[] EventTypes { get; set; }
    }

    public class UserActivityTriggerInputEventTypesTypeItem
    {
        [JsonProperty("eventType")]
        public string EventType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vocean;

    public partial class WorkflowManagedActions
    {
        public VoceanActions Vocean(string connectionId) => new VoceanActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VoceanTriggers Vocean(string connectionId) => new VoceanTriggers(connectionId);
    }
}