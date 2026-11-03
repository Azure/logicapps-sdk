//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Objectiveconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ObjectiveconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<GetParticipantsResponseItem[], ApiConnectionActionConfiguration> GetParticipants(Expression<Func<string>> userUuid = null)
        {
            var __workflow_userUuid = WorkflowExpression.Compile(userUuid, nameof(userUuid), required: false);
            return new DeferredBodyAction<GetParticipantsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/participants";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["noContentReplacesSeeOther"] = Convert.ToString(true);
                if (__workflow_userUuid != null)
                    callPayload.Queries["userUuid"] = ExpressionConverter.Convert(__workflow_userUuid);
                callPayload.Headers["accept"] = Convert.ToString("application/hal+json");
                return new ApiConnectionAction<GetParticipantsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<AddParticipantResponseItem[], ApiConnectionActionConfiguration> AddParticipant(Expression<Func<string[]>> bodyemails, Expression<Func<string>> bodyshareUuid, Expression<Func<string>> bodymessage = null, Expression<Func<bodyrolesInputItem[]>> bodyroles = null, Expression<Func<bodytypeInput>> bodytype = null)
        {
            var __workflow_bodyemails = WorkflowExpression.Compile(bodyemails, nameof(bodyemails), required: true);
            var __workflow_bodyshareUuid = WorkflowExpression.Compile(bodyshareUuid, nameof(bodyshareUuid), required: true);
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: false);
            var __workflow_bodyroles = WorkflowExpression.Compile(bodyroles, nameof(bodyroles), required: false);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            return new DeferredBodyAction<AddParticipantResponseItem[], ApiConnectionActionConfiguration>(() =>
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
                body["emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                if (__workflow_bodymessage != null)
                {
                    body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                    bodypropCount++;
                }

                if (__workflow_bodyroles != null)
                {
                    body["roles"] = ExpressionConverter.ConvertO(__workflow_bodyroles);
                    bodypropCount++;
                }

                bodypropCount++;
                body["shareUuid"] = ExpressionConverter.ConvertO(__workflow_bodyshareUuid);
                if (__workflow_bodytype != null)
                {
                    if (__workflow_bodytype != null)
                    {
                        body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["type"] = "STANDARD";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddParticipantResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteParticipant(Expression<Func<string>> uuid)
        {
            var __workflow_uuid = WorkflowExpression.Compile(uuid, nameof(uuid), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/participants/{0}", __workflow_uuid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["noContentReplacesSeeOther"] = Convert.ToString(true);
                callPayload.Headers["Accept"] = Convert.ToString("application/hal+json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<ShareResponse[], ApiConnectionActionConfiguration> ListWorkspaces(Expression<Func<int>> length = null, Expression<Func<int>> offset = null, Expression<Func<string>> ownerUuid = null, Expression<Func<string>> participantUuid = null, Expression<Func<string>> query = null, Expression<Func<string>> sort = null, Expression<Func<string>> workgroupUuid = null)
        {
            var __workflow_length = WorkflowExpression.Compile(length, nameof(length), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_ownerUuid = WorkflowExpression.Compile(ownerUuid, nameof(ownerUuid), required: false);
            var __workflow_participantUuid = WorkflowExpression.Compile(participantUuid, nameof(participantUuid), required: false);
            var __workflow_query = WorkflowExpression.Compile(query, nameof(query), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_workgroupUuid = WorkflowExpression.Compile(workgroupUuid, nameof(workgroupUuid), required: false);
            return new DeferredBodyAction<ShareResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/shares";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_length != null)
                    callPayload.Queries["length"] = ExpressionConverter.Convert(__workflow_length);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_ownerUuid != null)
                    callPayload.Queries["ownerUuid"] = ExpressionConverter.Convert(__workflow_ownerUuid);
                if (__workflow_participantUuid != null)
                    callPayload.Queries["participantUuid"] = ExpressionConverter.Convert(__workflow_participantUuid);
                if (__workflow_query != null)
                    callPayload.Queries["query"] = ExpressionConverter.Convert(__workflow_query);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_workgroupUuid != null)
                    callPayload.Queries["workgroupUuid"] = ExpressionConverter.Convert(__workflow_workgroupUuid);
                return new ApiConnectionAction<ShareResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "objectiveconnect")]
        public IBodyWorkflowAction<UserResponse[], ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> emailAddress = null, Expression<Func<int>> length = null, Expression<Func<int>> offset = null, Expression<Func<string>> orgUuid = null, Expression<Func<string>> sort = null, Expression<Func<string[]>> uuids = null)
        {
            var __workflow_emailAddress = WorkflowExpression.Compile(emailAddress, nameof(emailAddress), required: false);
            var __workflow_length = WorkflowExpression.Compile(length, nameof(length), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_orgUuid = WorkflowExpression.Compile(orgUuid, nameof(orgUuid), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_uuids = WorkflowExpression.Compile(uuids, nameof(uuids), required: false);
            return new DeferredBodyAction<UserResponse[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_emailAddress != null)
                    callPayload.Queries["emailAddress"] = ExpressionConverter.Convert(__workflow_emailAddress);
                if (__workflow_length != null)
                    callPayload.Queries["length"] = ExpressionConverter.Convert(__workflow_length);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_orgUuid != null)
                    callPayload.Queries["orgUuid"] = ExpressionConverter.Convert(__workflow_orgUuid);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_uuids != null)
                    callPayload.Queries["uuids"] = ExpressionConverter.Convert(__workflow_uuids);
                callPayload.Headers["accept"] = Convert.ToString("application/hal+json");
                return new ApiConnectionAction<UserResponse[]>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ShareStatus
    {
        ACTIVE,
        TRANSFERRING
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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