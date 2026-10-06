//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sessionizeip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SessionizeipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sessionizeip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSessions))]
        public IBodyWorkflowAction<GetSessionsResponseItem[]> GetSessions([WorkflowExpression] Func<string> iD)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sessionizeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSessionsResponseItem[]> __BuildGetSessions(WorkflowExpression<string> iD)
        {
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            return new DeferredBodyAction<GetSessionsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/view/Sessions", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSessionsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sessionizeip")]
        [WorkflowExpressionFactory(nameof(__BuildGetSpeakers))]
        public IBodyWorkflowAction<GetSpeakersResponseItem[]> GetSpeakers([WorkflowExpression] Func<string> iD)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sessionizeip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSpeakersResponseItem[]> __BuildGetSpeakers(WorkflowExpression<string> iD)
        {
            WorkflowExpression.Validate(iD, nameof(iD), required: true);
            return new DeferredBodyAction<GetSpeakersResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/view/Speakers", ExpressionConverter.ConvertWithUrlEncoding(iD, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetSpeakersResponseItem[]>(callPayload);
            });
        }
    }

    public class SessionizeipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSessionsResponseItem
    {
        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("sessions")]
        public GetSessionsResponseItemSessionsTypeItem[] Sessions { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }
    }

    public class GetSessionsResponseItemSessionsTypeItem
    {
        [JsonProperty("questionAnswers")]
        public JToken[] QuestionAnswers { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startsAt")]
        public string StartsAt { get; set; }

        [JsonProperty("endsAt")]
        public string EndsAt { get; set; }

        [JsonProperty("isServiceSession")]
        public bool IsServiceSession { get; set; }

        [JsonProperty("isPlenumSession")]
        public bool IsPlenumSession { get; set; }

        [JsonProperty("speakers")]
        public GetSessionsResponseItemSessionsTypeItemSpeakersTypeItem[] Speakers { get; set; }

        [JsonProperty("categories")]
        public JToken[] Categories { get; set; }

        [JsonProperty("roomId")]
        public int RoomId { get; set; }

        [JsonProperty("room")]
        public string Room { get; set; }

        [JsonProperty("liveUrl")]
        public string LiveUrl { get; set; }

        [JsonProperty("recordingUrl")]
        public string RecordingUrl { get; set; }
    }

    public class GetSessionsResponseItemSessionsTypeItemSpeakersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetSpeakersResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("tagLine")]
        public string TagLine { get; set; }

        [JsonProperty("profilePicture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("sessions")]
        public GetSpeakersResponseItemSessionsTypeItem[] Sessions { get; set; }

        [JsonProperty("isTopSpeaker")]
        public bool IsTopSpeaker { get; set; }

        [JsonProperty("links")]
        public JToken[] Links { get; set; }

        [JsonProperty("questionAnswers")]
        public JToken[] QuestionAnswers { get; set; }

        [JsonProperty("categories")]
        public JToken[] Categories { get; set; }
    }

    public class GetSpeakersResponseItemSessionsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sessionizeip;

    public partial class WorkflowManagedActions
    {
        public SessionizeipActions Sessionizeip(string connectionId) => new SessionizeipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SessionizeipTriggers Sessionizeip(string connectionId) => new SessionizeipTriggers(connectionId);
    }
}