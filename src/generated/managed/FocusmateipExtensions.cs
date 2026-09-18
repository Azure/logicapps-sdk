//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Focusmateip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FocusmateipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "focusmateip")]
        public IBodyWorkflowAction<ProfileResponse> Profile()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/me";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProfileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "focusmateip")]
        public IBodyWorkflowAction<PartnerProfileResponse> PartnerProfile([WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PartnerProfileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "focusmateip")]
        public IBodyWorkflowAction<GetSessionsResponse> GetSessions([WorkflowExpression] Func<string> start, [WorkflowExpression] Func<string> end)
        {
            SourceExpression.Validate(start, nameof(start), required: true);
            SourceExpression.Validate(end, nameof(end), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/sessions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["start"] = SourceExpressionConverter.ConvertO(start);
                callPayload.Queries["end"] = SourceExpressionConverter.ConvertO(end);
                return callPayload;
            }

            return new ApiConnectionAction<GetSessionsResponse>(BuildSourceInput);
        }
    }

    public class FocusmateipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProfileResponse
    {
        [JsonProperty("user")]
        public ProfileResponseUserType User { get; set; }
    }

    public class ProfileResponseUserType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("totalSessionCount")]
        public int TotalSessionCount { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("photoUrl")]
        public string PhotoUrl { get; set; }
    }

    public class PartnerProfileResponse
    {
        [JsonProperty("user")]
        public PartnerProfileResponseUserType User { get; set; }
    }

    public class PartnerProfileResponseUserType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("totalSessionCount")]
        public int TotalSessionCount { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("photoUrl")]
        public string PhotoUrl { get; set; }
    }

    public class GetSessionsResponse
    {
        [JsonProperty("sessions")]
        public GetSessionsResponseSessionsTypeItem[] Sessions { get; set; }
    }

    public class GetSessionsResponseSessionsTypeItem
    {
        [JsonProperty("sessionId")]
        public string SessionId { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("users")]
        public GetSessionsResponseSessionsTypeItemUsersTypeItem[] Users { get; set; }
    }

    public class GetSessionsResponseSessionsTypeItemUsersTypeItem
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("requestedAt")]
        public string RequestedAt { get; set; }

        [JsonProperty("joinedAt")]
        public string JoinedAt { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("sessionTitle")]
        public string SessionTitle { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Focusmateip;

    public partial class WorkflowManagedActions
    {
        public FocusmateipActions Focusmateip(string connectionId) => new FocusmateipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FocusmateipTriggers Focusmateip(string connectionId) => new FocusmateipTriggers(connectionId);
    }
}