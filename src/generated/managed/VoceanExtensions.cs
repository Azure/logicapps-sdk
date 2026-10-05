//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vocean
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VoceanActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        [WorkflowExpressionFactory(nameof(__BuildGetIdeas))]
        public IBodyWorkflowAction<GetIdeasResponseItem[]> GetIdeas([WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<string> networkId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetIdeasResponseItem[]> __BuildGetIdeas(WorkflowValue<string> activityId, WorkflowValue<string> networkId = null)
        {
            WorkflowValue.Validate(activityId, nameof(activityId), required: true);
            WorkflowValue.Validate(networkId, nameof(networkId), required: false);
            return new DeferredBodyAction<GetIdeasResponseItem[]>(() =>
            {
                var apiCallPath = "/api/data/connector/innovate/activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(networkId);
                callPayload.Queries["activityId"] = ExpressionConverter.Convert(activityId);
                return new ApiConnectionAction<GetIdeasResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        [WorkflowExpressionFactory(nameof(__BuildGetVotes))]
        public IBodyWorkflowAction<GetVotesResponseItem[]> GetVotes([WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<string> networkId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetVotesResponseItem[]> __BuildGetVotes(WorkflowValue<string> activityId, WorkflowValue<string> networkId = null)
        {
            WorkflowValue.Validate(activityId, nameof(activityId), required: true);
            WorkflowValue.Validate(networkId, nameof(networkId), required: false);
            return new DeferredBodyAction<GetVotesResponseItem[]>(() =>
            {
                var apiCallPath = "/api/data/connector/vote/activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(networkId);
                callPayload.Queries["activityId"] = ExpressionConverter.Convert(activityId);
                return new ApiConnectionAction<GetVotesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        [WorkflowExpressionFactory(nameof(__BuildGetExploreResponses))]
        public IBodyWorkflowAction<GetExploreResponsesResponseItem[]> GetExploreResponses([WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<string> networkId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExploreResponsesResponseItem[]> __BuildGetExploreResponses(WorkflowValue<string> activityId, WorkflowValue<string> networkId = null)
        {
            WorkflowValue.Validate(activityId, nameof(activityId), required: true);
            WorkflowValue.Validate(networkId, nameof(networkId), required: false);
            return new DeferredBodyAction<GetExploreResponsesResponseItem[]>(() =>
            {
                var apiCallPath = "/api/data/connector/explore/activity";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(networkId);
                callPayload.Queries["activityId"] = ExpressionConverter.Convert(activityId);
                return new ApiConnectionAction<GetExploreResponsesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        public IBodyWorkflowAction<GetSpacesResponseItem[]> GetSpaces()
        {
            var apiCallPath = "/api/connector/v2/networks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSpacesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        [WorkflowExpressionFactory(nameof(__BuildGetActivities))]
        public IBodyWorkflowAction<GetActivitiesResponseItem[]> GetActivities([WorkflowExpression] Func<string> networkId, [WorkflowExpression] Func<activityTypeInput> activityType)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetActivitiesResponseItem[]> __BuildGetActivities(WorkflowValue<string> networkId, WorkflowValue<activityTypeInput> activityType)
        {
            WorkflowValue.Validate(networkId, nameof(networkId), required: true);
            WorkflowValue.Validate(activityType, nameof(activityType), required: true);
            return new DeferredBodyAction<GetActivitiesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/connector/v2/networks/{0}/activities", ExpressionConverter.ConvertWithUrlEncoding(networkId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["activityType"] = ExpressionConverter.Convert(activityType);
                return new ApiConnectionAction<GetActivitiesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        [WorkflowExpressionFactory(nameof(__BuildAddIdea))]
        public IBodyWorkflowAction<AddIdeaResponse> AddIdea([WorkflowExpression] Func<string> networkId, [WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<string> bodytext)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddIdeaResponse> __BuildAddIdea(WorkflowValue<string> networkId, WorkflowValue<string> activityId, WorkflowValue<string> bodytext)
        {
            WorkflowValue.Validate(networkId, nameof(networkId), required: true);
            WorkflowValue.Validate(activityId, nameof(activityId), required: true);
            WorkflowValue.Validate(bodytext, nameof(bodytext), required: true);
            return new DeferredBodyAction<AddIdeaResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/connector/v2/networks/{0}/activities/{1}/ideas", ExpressionConverter.ConvertWithUrlEncoding(networkId, 1), ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(bodytext);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddIdeaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vocean")]
        [WorkflowExpressionFactory(nameof(__BuildAddIdeas))]
        public IBodyWorkflowAction<AddIdeasResponseItem[]> AddIdeas([WorkflowExpression] Func<string> networkId, [WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddIdeasResponseItem[]> __BuildAddIdeas(WorkflowValue<string> networkId, WorkflowValue<string> activityId, WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(networkId, nameof(networkId), required: true);
            WorkflowValue.Validate(activityId, nameof(activityId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<AddIdeasResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/connector/v2/networks/{0}/activities/{1}/ideas/many", ExpressionConverter.ConvertWithUrlEncoding(networkId, 1), ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<AddIdeasResponseItem[]>(callPayload);
            });
        }
    }

    public class VoceanTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildIdeaTrigger))]
        public IWorkflowTrigger IdeaTrigger([WorkflowExpression] Func<string> networkId, [WorkflowExpression] Func<string> activityId, [WorkflowExpression] Func<bodyeventTypesInputItem[]> bodyeventTypes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildIdeaTrigger(WorkflowValue<string> networkId, WorkflowValue<string> activityId, WorkflowValue<bodyeventTypesInputItem[]> bodyeventTypes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(networkId, nameof(networkId), required: true);
            WorkflowValue.Validate(activityId, nameof(activityId), required: true);
            WorkflowValue.Validate(bodyeventTypes, nameof(bodyeventTypes), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/connector/v2/networks/{0}/activities/{1}/ideas/webhooks", ExpressionConverter.ConvertWithUrlEncoding(networkId, 1), ExpressionConverter.ConvertWithUrlEncoding(activityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyeventTypes != null)
                {
                    body["eventTypes"] = ExpressionConverter.ConvertO(bodyeventTypes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildUserActivityTrigger))]
        public IWorkflowTrigger UserActivityTrigger([WorkflowExpression] Func<string> networkId = null, [WorkflowExpression] Func<bodyeventTypesInputItem[]> bodyeventTypes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildUserActivityTrigger(WorkflowValue<string> networkId = null, WorkflowValue<bodyeventTypesInputItem[]> bodyeventTypes = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(networkId, nameof(networkId), required: false);
            WorkflowValue.Validate(bodyeventTypes, nameof(bodyeventTypes), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/connector/v2/current-user/activities/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (networkId != null)
                    callPayload.Queries["networkId"] = ExpressionConverter.Convert(networkId);
                var body = new JObject();
                var bodypropCount = 0;
                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyeventTypes != null)
                {
                    body["eventTypes"] = ExpressionConverter.ConvertO(bodyeventTypes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
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

    public class bodyeventTypesInputItem
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
