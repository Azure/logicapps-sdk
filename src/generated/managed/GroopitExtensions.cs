//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Groopit
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GroopitActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<GroopDataExportDto[], ApiConnectionActionConfiguration> GetGroups()
        {
            return new DeferredBodyAction<GroopDataExportDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/data/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GroopDataExportDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<AssignmentDataExportDto[], ApiConnectionActionConfiguration> GetForms(Expression<Func<string>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<AssignmentDataExportDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/forms", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AssignmentDataExportDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<GroopItDataExportDto[], ApiConnectionActionConfiguration> GetReports(Expression<Func<string>> groupId, Expression<Func<string>> formId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GroopItDataExportDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/forms/{1}/reports", __workflow_groupId.WithUrlEncoding(1), __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["perPage"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<GroopItDataExportDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<GroopItDataExportDto[], ApiConnectionActionConfiguration> GetReports2(Expression<Func<string>> groupId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<GroopItDataExportDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/reports", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["perPage"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<GroopItDataExportDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<LinkedGroupMembershipDataExportDto[], ApiConnectionActionConfiguration> GetLinkedMembers(Expression<Func<string>> groupId, Expression<Func<int>> page = null, Expression<Func<int>> perPage = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_perPage = WorkflowExpression.Compile(perPage, nameof(perPage), required: false);
            return new DeferredBodyAction<LinkedGroupMembershipDataExportDto[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/linked-members", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(0);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["perPage"] = Convert.ToString(25);
                if (__workflow_perPage != null)
                    callPayload.Queries["perPage"] = ExpressionConverter.Convert(__workflow_perPage);
                return new ApiConnectionAction<LinkedGroupMembershipDataExportDto[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "groopit")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AddListOption(Expression<Func<string>> groupId, Expression<Func<string>> formId, Expression<Func<int>> fieldId, Expression<Func<string>> option = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            var __workflow_option = WorkflowExpression.Compile(option, nameof(option), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/forms/{1}/fields/{2}", __workflow_groupId.WithUrlEncoding(1), __workflow_formId.WithUrlEncoding(1), __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_option != null)
                    callPayload.Queries["option"] = ExpressionConverter.Convert(__workflow_option);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class GroopitTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GroopItWebhookDto, ApiConnectionPollingTriggerConfiguration> SubscribeToReports(Expression<Func<string>> groupId, Expression<Func<string>> formId, Expression<Func<SubscribeToReports2SubscribeInput>> subscribe)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_subscribe = WorkflowExpression.Compile(subscribe, nameof(subscribe), required: true);
            return new DeferredBodyTrigger<GroopItWebhookDto, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/forms/{1}/reports/subscribe", __workflow_groupId.WithUrlEncoding(1), __workflow_formId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscribe);
                return new ApiConnectionPollingTrigger<GroopItWebhookDto>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GroopItWebhookDto, ApiConnectionPollingTriggerConfiguration> SubscribeToReports2(Expression<Func<string>> groupId, Expression<Func<SubscribeToReports2SubscribeInput>> subscribe)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_subscribe = WorkflowExpression.Compile(subscribe, nameof(subscribe), required: true);
            return new DeferredBodyTrigger<GroopItWebhookDto, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/reports/subscribe", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscribe);
                return new ApiConnectionPollingTrigger<GroopItWebhookDto>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GroopItWebhookDto, ApiConnectionPollingTriggerConfiguration> SubscribeToLinkedMembers(Expression<Func<string>> groupId, Expression<Func<SubscribeToLinkedMembersSubscribeInput>> subscribe)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_subscribe = WorkflowExpression.Compile(subscribe, nameof(subscribe), required: true);
            return new DeferredBodyTrigger<GroopItWebhookDto, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/data/groups/{0}/linked-members/subscribe", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_subscribe);
                return new ApiConnectionPollingTrigger<GroopItWebhookDto>(callPayload);
            });
        }
    }

    public class GroopDataExportDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AssignmentDataExportDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public ComponentModelDataExportDto[] Fields { get; set; }
    }

    public class ComponentModelDataExportDto
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class GroopItDataExportDto
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
        public UserDataExportDto Creator { get; set; }

        [JsonProperty("createTime")]
        public string CreateTime { get; set; }

        [JsonProperty("lastEditTime")]
        public string LastEditTime { get; set; }

        [JsonProperty("lastEditor")]
        public UserDataExportDto LastEditor { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("data")]
        public ComponentDataDataExportDto[] Data { get; set; }

        [JsonProperty("dataBlob")]
        public string DataBlob { get; set; }

        [JsonProperty("filteredDataBlob")]
        public string FilteredDataBlob { get; set; }
    }

    public class UserDataExportDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class ComponentDataDataExportDto
    {
        [JsonProperty("field")]
        public ComponentModelDataExportDto Field { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }

        [JsonProperty("stringValue")]
        public string StringValue { get; set; }
    }

    public class LinkedGroupMembershipDataExportDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("member")]
        public UserDataExportDto Member { get; set; }

        [JsonProperty("group")]
        public GroopDataExportDto Group { get; set; }

        [JsonProperty("role")]
        public UserRole Role { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class GroopItWebhookDto
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

    public class SubscribeToReports2SubscribeInput
    {
        public SubscribeToReports2SubscribeInput(SubscribeInputUpdateType0Created1EditedType updateType0Created1Edited)
        {
            this.UpdateType0Created1Edited = updateType0Created1Edited;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("EventType", DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeInputUpdateType0Created1EditedType UpdateType0Created1Edited { get; set; }
    }

    public enum SubscribeInputUpdateType0Created1EditedType
    {
        _0 = 0,
        _1 = 1
    }

    public class SubscribeToLinkedMembersSubscribeInput
    {
        public SubscribeToLinkedMembersSubscribeInput(SubscribeInputEventTypeType eventType)
        {
            this.EventType = eventType;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Callback { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SubscribeInputEventTypeType EventType { get; set; }
    }

    public enum SubscribeInputEventTypeType
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