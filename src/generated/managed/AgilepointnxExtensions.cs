//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Agilepointnx
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AgilepointnxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IBodyWorkflowAction<CompleteAutoWorkItemResponse, ApiConnectionActionConfiguration> CompleteAutoWorkItem(Expression<Func<string>> wORKITEMId)
        {
            var __workflow_wORKITEMId = WorkflowExpression.Compile(wORKITEMId, nameof(wORKITEMId), required: true);
            return new DeferredBodyAction<CompleteAutoWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Workflow/CompleteProcedure/{0}", __workflow_wORKITEMId.WithUrlEncoding(2)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompleteAutoWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IBodyWorkflowAction<CreateProcInstResponse, ApiConnectionActionConfiguration> CreateProcInst(Expression<Func<CreateProcInstInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateProcInstResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Workflow/CreateProcInst";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateProcInstResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetCustomAttrs(Expression<Func<string>> cUSTOMId, Expression<Func<SetCustomAttrsInput>> body = null)
        {
            var __workflow_cUSTOMId = WorkflowExpression.Compile(cUSTOMId, nameof(cUSTOMId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Workflow/SetCustomAttrs/{0}", __workflow_cUSTOMId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCustomAttr(Expression<Func<string>> cUSTOMId, Expression<Func<GetCustomAttrInput>> body = null)
        {
            var __workflow_cUSTOMId = WorkflowExpression.Compile(cUSTOMId, nameof(cUSTOMId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Workflow/GetCustomAttr/{0}", __workflow_cUSTOMId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IBodyWorkflowAction<GetUUIdResponse, ApiConnectionActionConfiguration> GetUUID()
        {
            return new DeferredBodyAction<GetUUIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Workflow/GetUUID";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetUUIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IBodyWorkflowAction<GetProcessInstanceResponse, ApiConnectionActionConfiguration> GetProcessInstance(Expression<Func<string>> processInstanceId)
        {
            var __workflow_processInstanceId = WorkflowExpression.Compile(processInstanceId, nameof(processInstanceId), required: true);
            return new DeferredBodyAction<GetProcessInstanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Workflow/GetProcInst/{0}", __workflow_processInstanceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProcessInstanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IBodyWorkflowAction<GetRegisteredUserbyNameResponse, ApiConnectionActionConfiguration> GetRegisteredUserbyName(Expression<Func<GetRegisteredUserbyNameInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<GetRegisteredUserbyNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Admin/GetRegisterUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetRegisteredUserbyNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IBodyWorkflowAction<CompleteManualWorkItemResponse, ApiConnectionActionConfiguration> CompleteManualWorkItem(Expression<Func<string>> workItemId, Expression<Func<CompleteManualWorkItemInput>> body = null)
        {
            var __workflow_workItemId = WorkflowExpression.Compile(workItemId, nameof(workItemId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CompleteManualWorkItemResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Workflow/CompleteWorkItem/{0}", __workflow_workItemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CompleteManualWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "agilepointnx")]
        public IBodyWorkflowAction<ProcessDefinitionResponse, ApiConnectionActionConfiguration> ProcessDefinition()
        {
            return new DeferredBodyAction<ProcessDefinitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Workflow/GetProcDefs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProcessDefinitionResponse>(callPayload);
            });
        }
    }

    public class AgilepointnxTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggerByAgilePointProcessInstanceCreation(Expression<Func<TriggerByAgilePointProcessInstanceCreationInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Admin/CreateAndActivateWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> TriggeryByAgilePointActivity(Expression<Func<TriggeryByAgilePointActivityInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/Admin/CreateWebhook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CompleteAutoWorkItemResponse
    {
        [JsonProperty("ActivityInstID")]
        public string ActivityInstId { get; set; }
        public bool AutoStart { get; set; }
        public CompleteAutoWorkItemResponseCustomAttributesTypeItem[] CustomAttributes { get; set; }
        public bool Diagnostic { get; set; }
        public string EndDate { get; set; }
        public int Entries { get; set; }
        public string Error { get; set; }

        [JsonProperty("EventID")]
        public string EventId { get; set; }
        public string EventName { get; set; }
        public bool HighPriority { get; set; }
        public string ParamsXml { get; set; }

        [JsonProperty("ParentProcInstID")]
        public string ParentProcInstId { get; set; }

        [JsonProperty("ProcDefID")]
        public string ProcDefId { get; set; }

        [JsonProperty("ProcInstID")]
        public string ProcInstId { get; set; }
        public string ProcInstName { get; set; }
        public string Sender { get; set; }
        public string SentDate { get; set; }

        [JsonProperty("SourceWorkItemID")]
        public string SourceWorkItemId { get; set; }
        public string Status { get; set; }

        [JsonProperty("TenantID")]
        public string TenantId { get; set; }

        [JsonProperty("UserID")]
        public string UserId { get; set; }

        [JsonProperty("WorkItemID")]
        public string WorkItemId { get; set; }

        [JsonProperty("WorkObjectID")]
        public string WorkObjectId { get; set; }
        public string WorkObjectInfo { get; set; }
    }

    public class CompleteAutoWorkItemResponseCustomAttributesTypeItem
    {
        public string Name { get; set; }
        public CompleteAutoWorkItemResponseCustomAttributesTypeItemValueType Value { get; set; }
    }

    public class CompleteAutoWorkItemResponseCustomAttributesTypeItemValueType
    {
        public CompleteAutoWorkItemResponseCustomAttributesTypeItemValueTypeNameValueType NameValue { get; set; }
    }

    public class CompleteAutoWorkItemResponseCustomAttributesTypeItemValueTypeNameValueType
    {
        public string Name { get; set; }
        public CompleteAutoWorkItemResponseCustomAttributesTypeItemValueTypeNameValueTypeValueType Value { get; set; }
    }

    public class CompleteAutoWorkItemResponseCustomAttributesTypeItemValueTypeNameValueTypeValueType
    {
        public string NameValue { get; set; }
    }

    public class CreateProcInstResponse
    {
        [JsonProperty("ActivityInstID")]
        public string ActivityInstId { get; set; }
        public bool AutoStart { get; set; }
        public CreateProcInstResponseCustomAttributesTypeItem[] CustomAttributes { get; set; }
        public bool Diagnostic { get; set; }
        public string EndDate { get; set; }
        public int Entries { get; set; }
        public string Error { get; set; }

        [JsonProperty("EventID")]
        public string EventId { get; set; }
        public string EventName { get; set; }
        public bool HighPriority { get; set; }
        public string ParamsXml { get; set; }

        [JsonProperty("ParentProcInstID")]
        public string ParentProcInstId { get; set; }

        [JsonProperty("ProcDefID")]
        public string ProcDefId { get; set; }

        [JsonProperty("ProcInstID")]
        public string ProcInstId { get; set; }
        public string ProcInstName { get; set; }
        public string Sender { get; set; }
        public string SentDate { get; set; }

        [JsonProperty("SourceWorkItemID")]
        public string SourceWorkItemId { get; set; }
        public string Status { get; set; }

        [JsonProperty("TenantID")]
        public string TenantId { get; set; }

        [JsonProperty("UserID")]
        public string UserId { get; set; }

        [JsonProperty("WorkItemID")]
        public string WorkItemId { get; set; }

        [JsonProperty("WorkObjectID")]
        public string WorkObjectId { get; set; }
        public string WorkObjectInfo { get; set; }
    }

    public class CreateProcInstResponseCustomAttributesTypeItem
    {
        public string Name { get; set; }
        public CreateProcInstResponseCustomAttributesTypeItemValueType Value { get; set; }
    }

    public class CreateProcInstResponseCustomAttributesTypeItemValueType
    {
        public CreateProcInstResponseCustomAttributesTypeItemValueTypeNameValueType NameValue { get; set; }
    }

    public class CreateProcInstResponseCustomAttributesTypeItemValueTypeNameValueType
    {
        public string Name { get; set; }
        public CreateProcInstResponseCustomAttributesTypeItemValueTypeNameValueTypeValueType Value { get; set; }
    }

    public class CreateProcInstResponseCustomAttributesTypeItemValueTypeNameValueTypeValueType
    {
        public string NameValue { get; set; }
    }

    public class CreateProcInstInput
    {
        [JsonProperty("ProcessID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessId { get; set; }

        [JsonProperty("ProcessInstID")]
        public string ProcessInstId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcInstName { get; set; }

        [JsonProperty("WorkObjID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkObjId { get; set; }
        public string WorkObjInfo { get; set; }

        [JsonProperty("SuperProcInstID")]
        public string SuperProcInstId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Initiator { get; set; }

        [JsonProperty("CustomID")]
        public string CustomId { get; set; }

        [JsonProperty("blnStartImmediately", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BlnStartImmediately { get; set; } = true;
        public CreateProcInstInputAttributesTypeItem[] Attributes { get; set; }
    }

    public class CreateProcInstInputAttributesTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class SetCustomAttrsInput
    {
        [JsonProperty("attributes")]
        public SetCustomAttrsInputAttributesTypeItem[] Attributes { get; set; }
    }

    public class SetCustomAttrsInputAttributesTypeItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetCustomAttrInput
    {
        [JsonProperty("attrName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string AttrName { get; set; }
    }

    public class GetUUIdResponse
    {
        [JsonProperty("GetUUIDResult")]
        public string GetUUIdResult { get; set; }
    }

    public class GetProcessInstanceResponse
    {
        public GetProcessInstanceResponseGetProcInstResultType GetProcInstResult { get; set; }
    }

    public class GetProcessInstanceResponseGetProcInstResultType
    {
        public string ApplName { get; set; }
        public string ApplicationDisplayName { get; set; }
        public string CompletedDate { get; set; }

        [JsonProperty("DefID")]
        public string DefId { get; set; }
        public string DefName { get; set; }
        public string DueDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string LastModifiedDate { get; set; }
        public string LastRunningEndTime { get; set; }
        public string LastRunningStartTime { get; set; }
        public string LastSwapDate { get; set; }
        public string ProcInitiator { get; set; }
        public string ProcInitiatorLoc { get; set; }

        [JsonProperty("ProcInstID")]
        public string ProcInstId { get; set; }
        public string ProcInstName { get; set; }
        public string ProcessDefinitionDisplayName { get; set; }
        public string ProcessInitiator { get; set; }
        public string ProcessInitiatorLocation { get; set; }

        [JsonProperty("SourceProcInstID")]
        public string SourceProcInstId { get; set; }
        public string StartedDate { get; set; }
        public string Status { get; set; }

        [JsonProperty("SuperProcInstID")]
        public string SuperProcInstId { get; set; }

        [JsonProperty("TargetProcInstID")]
        public string TargetProcInstId { get; set; }

        [JsonProperty("ToplevelProcInstID")]
        public string ToplevelProcInstId { get; set; }
        public string Version { get; set; }

        [JsonProperty("WorkObjectID")]
        public string WorkObjectId { get; set; }
        public string WorkObjectInfo { get; set; }
    }

    public class GetRegisteredUserbyNameResponse
    {
        public string Department { get; set; }
        public bool Disabled { get; set; }
        public string EMailAddress { get; set; }
        public string FullName { get; set; }
        public string Level { get; set; }
        public string Locale { get; set; }
        public string Manager { get; set; }
        public string OnlineContact { get; set; }

        [JsonProperty("RefID")]
        public string RefId { get; set; }
        public string RegisteredDate { get; set; }
        public string SupportedLanguage { get; set; }
        public string TimeZone { get; set; }
        public string Title { get; set; }
        public string UALExpirationDate { get; set; }
        public bool UALNeverExpires { get; set; }
        public string UserName { get; set; }
        public string UserOrgInfo { get; set; }

        [JsonProperty("WorkCalendarID")]
        public string WorkCalendarId { get; set; }
    }

    public class GetRegisteredUserbyNameInput
    {
        [JsonProperty("userName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }
    }

    public class CompleteManualWorkItemResponse
    {
        [JsonProperty("ActivityInstID")]
        public string ActivityInstId { get; set; }
        public bool AutoStart { get; set; }
        public string CustomAttributes { get; set; }
        public bool Diagnostic { get; set; }
        public string EndDate { get; set; }
        public int Entries { get; set; }
        public string Error { get; set; }

        [JsonProperty("EventID")]
        public string EventId { get; set; }
        public string EventName { get; set; }
        public bool HighPriority { get; set; }
        public string ParamsXml { get; set; }

        [JsonProperty("ParentProcInstID")]
        public string ParentProcInstId { get; set; }

        [JsonProperty("ProcDefID")]
        public string ProcDefId { get; set; }

        [JsonProperty("ProcInstID")]
        public string ProcInstId { get; set; }
        public string ProcInstName { get; set; }
        public string Sender { get; set; }
        public string SentDate { get; set; }

        [JsonProperty("SourceWorkItemID")]
        public string SourceWorkItemId { get; set; }
        public string Status { get; set; }

        [JsonProperty("TenantID")]
        public string TenantId { get; set; }

        [JsonProperty("UserID")]
        public string UserId { get; set; }

        [JsonProperty("WorkItemID")]
        public string WorkItemId { get; set; }

        [JsonProperty("WorkObjectID")]
        public string WorkObjectId { get; set; }
        public string WorkObjectInfo { get; set; }
    }

    public class CompleteManualWorkItemInput
    {
        [JsonProperty("clientData", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClientData { get; set; } = "null";
    }

    public class ProcessDefinitionResponse
    {
        public ProcessDefinitionResponseGetProcDefsResultTypeItem[] GetProcDefsResult { get; set; }
    }

    public class ProcessDefinitionResponseGetProcDefsResultTypeItem
    {
        public string ApplName { get; set; }
        public string AssemblyName { get; set; }
        public int AuditLevel { get; set; }

        [JsonProperty("BaseDefID")]
        public string BaseDefId { get; set; }
        public string CheckedOutBy { get; set; }
        public string CheckedOutDate { get; set; }
        public string ClassName { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedDate { get; set; }

        [JsonProperty("DefID")]
        public string DefId { get; set; }
        public string DefName { get; set; }
        public string Description { get; set; }
        public bool Diagnostic { get; set; }
        public string DocRef { get; set; }
        public ProcessDefinitionResponseGetProcDefsResultTypeItemExpectedTimeType ExpectedTime { get; set; }
        public int InitiateConstraint { get; set; }
        public int MaximumSessionAllowed { get; set; }
        public int OnComplete { get; set; }
        public string Owner { get; set; }
        public string PreVersion { get; set; }
        public string ReleaseDate { get; set; }
        public string Rule { get; set; }
        public string Status { get; set; }
        public string SupplementInfo { get; set; }
        public string Version { get; set; }
    }

    public class ProcessDefinitionResponseGetProcDefsResultTypeItemExpectedTimeType
    {
        public bool BusinessTime { get; set; }
        public string Length { get; set; }
        public ProcessDefinitionResponseGetProcDefsResultTypeItemExpectedTimeTypeUnitType Unit { get; set; }
    }

    public class ProcessDefinitionResponseGetProcDefsResultTypeItemExpectedTimeTypeUnitType
    {
        public int Value { get; set; }
    }

    public class TriggerByAgilePointProcessInstanceCreationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationAddressUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] Triggers { get; set; } = new string[]
        {
            "StartProcessInstance"
        };

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] TargetApplications { get; set; }
    }

    public class TriggeryByAgilePointActivityInput
    {
        public string Name { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string NotificationAddressUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] Triggers { get; set; } = new string[]
        {
            "PowerAutomateTrigger"
        };

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] TargetApplications { get; set; } = new string[]
        {
            "*"
        };
        public TriggeryByAgilePointActivityInputHeadersTypeItem[] Headers { get; set; }
    }

    public class TriggeryByAgilePointActivityInputHeadersTypeItem
    {
        public string Name { get; set; }
        public TriggeryByAgilePointActivityInputHeadersTypeItemValueType? Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TriggeryByAgilePointActivityInputHeadersTypeItemValueType
    {
        Text,
        Number,
        Decimal,
        Date,
        Time,
        DateTime,
        Byte,
        Boolean
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Agilepointnx;

    public partial class WorkflowManagedActions
    {
        public AgilepointnxActions Agilepointnx(string connectionId) => new AgilepointnxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AgilepointnxTriggers Agilepointnx(string connectionId) => new AgilepointnxTriggers(connectionId);
    }
}