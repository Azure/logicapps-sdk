//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Objectiveconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ObjectiveconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<GetParticipantsResponseItem[]> GetParticipants(Expression<Func<string>> userUuid = null)
        {
            var apiCallPath = "/participants";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["noContentReplacesSeeOther"] = Convert.ToString(true);
            if (userUuid != null)
                callPayload.Queries["userUuid"] = ExpressionConverter.Convert(userUuid);
            callPayload.Headers["accept"] = Convert.ToString("application/hal+json");
            return new ApiConnectionAction<GetParticipantsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<AddParticipantResponseItem[]> AddParticipant(Expression<Func<string[]>> bodyemails, Expression<Func<string>> bodyshareUuid, Expression<Func<string>> bodymessage = null, Expression<Func<bodyrolesInputItem[]>> bodyroles = null, Expression<Func<bodytypeInput>> bodytype = null)
        {
            var apiCallPath = "/participants/batch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["noContentReplacesSeeOther"] = Convert.ToString(true);
            callPayload.Headers["Accept"] = Convert.ToString("application/hal+json");
            callPayload.Headers["Content-Type"] = Convert.ToString("application/hal+json");
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["emails"] = ExpressionConverter.ConvertO(bodyemails);
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodyroles != null)
            {
                body["roles"] = ExpressionConverter.ConvertO(bodyroles);
                bodypropCount++;
            }

            bodypropCount++;
            body["shareUuid"] = ExpressionConverter.ConvertO(bodyshareUuid);
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddParticipantResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IWorkflowAction DeleteParticipant(Expression<Func<string>> uuid)
        {
            var apiCallPath = String.Format("/participants/{0}", ExpressionConverter.ConvertWithUrlEncoding(uuid, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["noContentReplacesSeeOther"] = Convert.ToString(true);
            callPayload.Headers["Accept"] = Convert.ToString("application/hal+json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<ShareResponse[]> ListWorkspaces(Expression<Func<int>> length = null, Expression<Func<int>> offset = null, Expression<Func<string>> ownerUuid = null, Expression<Func<string>> participantUuid = null, Expression<Func<string>> query = null, Expression<Func<string>> sort = null, Expression<Func<string>> workgroupUuid = null)
        {
            var apiCallPath = "/shares";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (length != null)
                callPayload.Queries["length"] = ExpressionConverter.Convert(length);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (ownerUuid != null)
                callPayload.Queries["ownerUuid"] = ExpressionConverter.Convert(ownerUuid);
            if (participantUuid != null)
                callPayload.Queries["participantUuid"] = ExpressionConverter.Convert(participantUuid);
            if (query != null)
                callPayload.Queries["query"] = ExpressionConverter.Convert(query);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (workgroupUuid != null)
                callPayload.Queries["workgroupUuid"] = ExpressionConverter.Convert(workgroupUuid);
            return new ApiConnectionAction<ShareResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<UserResponse[]> GetUser(Expression<Func<string>> emailAddress = null, Expression<Func<int>> length = null, Expression<Func<int>> offset = null, Expression<Func<string>> orgUuid = null, Expression<Func<string>> sort = null, Expression<Func<string[]>> uuids = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (emailAddress != null)
                callPayload.Queries["emailAddress"] = ExpressionConverter.Convert(emailAddress);
            if (length != null)
                callPayload.Queries["length"] = ExpressionConverter.Convert(length);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (orgUuid != null)
                callPayload.Queries["orgUuid"] = ExpressionConverter.Convert(orgUuid);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (uuids != null)
                callPayload.Queries["uuids"] = ExpressionConverter.Convert(uuids);
            callPayload.Headers["accept"] = Convert.ToString("application/hal+json");
            return new ApiConnectionAction<UserResponse[]>(callPayload);
        }
    }

    public class ObjectiveconnectTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetParticipantsResponseItem
    {
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("isOwner")]
        public bool IsOwner { get; set; }

        [JsonProperty("joinedDate")]
        public string JoinedDate { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("shareUuid")]
        public string ShareUuid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public class AddParticipantResponseItem
    {
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("isOwner")]
        public bool IsOwner { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("shareUuid")]
        public string ShareUuid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public enum bodyrolesInputItem
    {
        READER,
        DOWNLOADER,
        [EnumMember(Value = "DOCUMENT_CREATOR")]
        DOCUMENTCREATOR,
        [EnumMember(Value = "CONTAINER_CREATOR")]
        CONTAINERCREATOR,
        EDITOR,
        INVITER,
        COMMENTER
    }

    public enum bodytypeInput
    {
        STANDARD,
        BCC
    }

    public class ShareResponse
    {
        [JsonProperty("access")]
        public Access Access { get; set; }

        [JsonProperty("connections")]
        public int Connections { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("endOnDateOptionalValue")]
        public EndOnDateOptionalValue EndOnDateOptionalValue { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("organisationUuid")]
        public string OrganisationUuid { get; set; }

        [JsonProperty("ownerUuid")]
        public string OwnerUuid { get; set; }

        [JsonProperty("secure")]
        public bool Secure { get; set; }

        [JsonProperty("shareStatus")]
        public ShareStatus ShareStatus { get; set; }

        [JsonProperty("status")]
        public AssetStatus Status { get; set; }

        [JsonProperty("synchStatus")]
        public SynchStatus SynchStatus { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public enum Access
    {
        READ,
        [EnumMember(Value = "READ_ADD")]
        READADD
    }

    public class EndOnDateOptionalValue
    {
        [JsonProperty("present")]
        public bool Present { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum ShareStatus
    {
        ACTIVE,
        TRANSFERRING
    }

    public enum AssetStatus
    {
        COMPLETE,
        ERROR,
        SAVED,
        SAVING,
        SCANNED,
        SCANNING,
        UNDEFINED,
        UPLOADING,
        [EnumMember(Value = "VIRUS_DETECTED")]
        VIRUSDETECTED,
        [EnumMember(Value = "WAITING_FOR_UPLOAD")]
        WAITINGFORUPLOAD
    }

    public enum SynchStatus
    {
        COMPLETE,
        ERROR,
        SAVED,
        SAVING,
        SCANNED,
        SCANNING,
        UNDEFINED,
        UPLOADING,
        [EnumMember(Value = "VIRUS_DETECTED")]
        VIRUSDETECTED,
        [EnumMember(Value = "WAITING_FOR_UPLOAD")]
        WAITINGFORUPLOAD
    }

    public class UserResponse
    {
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("hideEmailAddress")]
        public bool HideEmailAddress { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("notificationPreferences")]
        public NotificationPreference[] NotificationPreferences { get; set; }

        [JsonProperty("organisationUuid")]
        public string OrganisationUuid { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("status")]
        public UserStatus Status { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }

    public enum NotificationPreference
    {
        [EnumMember(Value = "DAILY_EMAIL")]
        DAILYEMAIL,
        [EnumMember(Value = "DAILY_SMS")]
        DAILYSMS,
        [EnumMember(Value = "IMMEDIATE_EMAIL")]
        IMMEDIATEEMAIL,
        [EnumMember(Value = "IMMEDIATE_SMS")]
        IMMEDIATESMS,
        [EnumMember(Value = "WEEKLY_EMAIL")]
        WEEKLYEMAIL,
        [EnumMember(Value = "WEEKLY_SMS")]
        WEEKLYSMS
    }

    public enum UserStatus
    {
        ACTIVE,
        INVITED
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Objectiveconnect;

    public partial class WorkflowManagedActions
    {
        public ObjectiveconnectActions Objectiveconnect(string connectionId) => new ObjectiveconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ObjectiveconnectTriggers Objectiveconnect(string connectionId) => new ObjectiveconnectTriggers(connectionId);
    }
}