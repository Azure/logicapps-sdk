//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Groopit
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GroopitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<GroopDataExportDTO[]> GetGroups()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/data/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GroopDataExportDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<AssignmentDataExportDTO[]> GetForms([WorkflowExpression] Func<string> groupId)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/forms", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AssignmentDataExportDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<GroopItDataExportDTO[]> GetReports([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/forms/{1}/reports", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["perPage"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["perPage"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<GroopItDataExportDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<GroopItDataExportDTO[]> GetReports2([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/reports", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["perPage"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["perPage"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<GroopItDataExportDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<LinkedGroupMembershipDataExportDTO[]> GetLinkedMembers([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> perPage = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(page, nameof(page), required: false);
            SourceExpression.Validate(perPage, nameof(perPage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/linked-members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                callPayload.Queries["perPage"] = Convert.ToString(25);
                if (perPage != null)
                    callPayload.Queries["perPage"] = SourceExpressionConverter.ConvertO(perPage);
                return callPayload;
            }

            return new ApiConnectionAction<LinkedGroupMembershipDataExportDTO[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<string> AddListOption([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<int> fieldId, [WorkflowExpression] Func<string> option = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            SourceExpression.Validate(option, nameof(option), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/forms/{1}/fields/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(fieldId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (option != null)
                    callPayload.Queries["option"] = SourceExpressionConverter.ConvertO(option);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class GroopitTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GroopItWebhookDTO> SubscribeToReports([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<subscribeupdateType0Created1EditedInput> subscribeupdateType0Created1Edited, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(subscribeupdateType0Created1Edited, nameof(subscribeupdateType0Created1Edited), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/forms/{1}/reports/subscribe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscribe = new JObject();
                var subscribepropCount = 0;
                subscribe["Callback"] = "#{listCallbackUrl()}";
                subscribepropCount++;
                subscribepropCount++;
                subscribe["EventType"] = SourceExpressionConverter.Convert(subscribeupdateType0Created1Edited);
                if (subscribepropCount > 0)
                {
                    callPayload.Body = subscribe;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<GroopItWebhookDTO>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GroopItWebhookDTO> SubscribeToReports2([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<subscribeupdateType0Created1EditedInput> subscribeupdateType0Created1Edited, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(subscribeupdateType0Created1Edited, nameof(subscribeupdateType0Created1Edited), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/reports/subscribe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscribe = new JObject();
                var subscribepropCount = 0;
                subscribe["Callback"] = "#{listCallbackUrl()}";
                subscribepropCount++;
                subscribepropCount++;
                subscribe["EventType"] = SourceExpressionConverter.Convert(subscribeupdateType0Created1Edited);
                if (subscribepropCount > 0)
                {
                    callPayload.Body = subscribe;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<GroopItWebhookDTO>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GroopItWebhookDTO> SubscribeToLinkedMembers([WorkflowExpression] Func<string> groupId, [WorkflowExpression] Func<subscribeeventTypeInput> subscribeeventType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(groupId, nameof(groupId), required: true);
            SourceExpression.Validate(subscribeeventType, nameof(subscribeeventType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/data/groups/{0}/linked-members/subscribe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(groupId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var subscribe = new JObject();
                var subscribepropCount = 0;
                subscribe["Callback"] = "#{listCallbackUrl()}";
                subscribepropCount++;
                subscribepropCount++;
                subscribe["EventType"] = SourceExpressionConverter.Convert(subscribeeventType);
                if (subscribepropCount > 0)
                {
                    callPayload.Body = subscribe;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<GroopItWebhookDTO>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class GroopDataExportDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AssignmentDataExportDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public ComponentModelDataExportDTO[] Fields { get; set; }
    }

    public class ComponentModelDataExportDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public ComponentType Type { get; set; }

        [JsonProperty("hiddenFromMembers")]
        public bool HiddenFromMembers { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public enum ComponentType
    {
        Picture,
        Location,
        Note,
        MultipleChoice,
        Obsolete,
        DateTime,
        MultipleChoiceExtended,
        Obsolete2,
        FixedDecimal,
        PictureSet,
        Table,
        FileSet,
        SaveToSalesforce,
        InheritedData,
        FollowUpRequest,
        Unknown
    }

    public class GroopItDataExportDTO
    {
        [JsonProperty("baseUri")]
        public string BaseUri { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("formId")]
        public string FormId { get; set; }

        [JsonProperty("formName")]
        public string FormName { get; set; }

        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        [JsonProperty("reportUrl")]
        public string ReportUrl { get; set; }

        [JsonProperty("formUrl")]
        public string FormUrl { get; set; }

        [JsonProperty("groupUrl")]
        public string GroupUrl { get; set; }

        [JsonProperty("creator")]
        public UserDataExportDTO Creator { get; set; }

        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        [JsonProperty("lastEditTime")]
        public string LastEditTime { get; set; }

        [JsonProperty("lastEditor")]
        public UserDataExportDTO LastEditor { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("data")]
        public ComponentDataDataExportDTO[] Data { get; set; }

        [JsonProperty("dataBlob")]
        public string DataBlob { get; set; }

        [JsonProperty("filteredDataBlob")]
        public string FilteredDataBlob { get; set; }
    }

    public class UserDataExportDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ComponentDataDataExportDTO
    {
        [JsonProperty("field")]
        public ComponentModelDataExportDTO Field { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("stringValue")]
        public string StringValue { get; set; }
    }

    public class LinkedGroupMembershipDataExportDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("member")]
        public UserDataExportDTO Member { get; set; }

        [JsonProperty("group")]
        public GroopDataExportDTO Group { get; set; }

        [JsonProperty("role")]
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        None,
        Member,
        Moderator,
        Organizer,
        Administrator,
        Invited,
        JoinRequested,
        Publisher
    }

    public class GroopItWebhookDTO
    {
        public int Id { get; set; }
        public string CreatorId { get; set; }
        public string GroupId { get; set; }
        public string FormId { get; set; }
        public string Callback { get; set; }
        public EventType EventType { get; set; }
    }

    public enum EventType
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }

    public enum subscribeupdateType0Created1EditedInput
    {
        _0 = 0,
        _1 = 1
    }

    public enum subscribeeventTypeInput
    {
        _0 = 0,
        _1 = 1,
        _2 = 2
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Groopit;

    public partial class WorkflowManagedActions
    {
        public GroopitActions Groopit(string connectionId) => new GroopitActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GroopitTriggers Groopit(string connectionId) => new GroopitTriggers(connectionId);
    }
}