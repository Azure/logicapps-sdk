//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uipath
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UipathActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipath")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> StartAndWaitForJobCompletion(Expression<Func<int>> xUIPATHOrganizationUnitId, Expression<Func<double>> processId, Expression<Func<object>> dynamicListSchema, Expression<Func<bool>> runAsMe = null)
        {
            var __workflow_xUIPATHOrganizationUnitId = WorkflowExpression.Compile(xUIPATHOrganizationUnitId, nameof(xUIPATHOrganizationUnitId), required: true);
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: true);
            var __workflow_runAsMe = WorkflowExpression.Compile(runAsMe, nameof(runAsMe), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/startJobAndWaitForCompletion/{0}", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["runAsMe"] = Convert.ToString(true);
                if (__workflow_runAsMe != null)
                    callPayload.Queries["runAsMe"] = ExpressionConverter.Convert(__workflow_runAsMe);
                callPayload.Headers["X-UIPATH-OrganizationUnitId"] = ExpressionConverter.Convert(__workflow_xUIPATHOrganizationUnitId);
                callPayload.Headers["url"] = Convert.ToString("#{listCallbackUrl()}");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipath")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetJobUpdate(Expression<Func<int>> xUIPATHOrganizationUnitId, Expression<Func<double>> processId, Expression<Func<GetJobUpdateInput>> body)
        {
            var __workflow_xUIPATHOrganizationUnitId = WorkflowExpression.Compile(xUIPATHOrganizationUnitId, nameof(xUIPATHOrganizationUnitId), required: true);
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/jobupdate/webhook/{0}", __workflow_processId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-UIPATH-OrganizationUnitId"] = ExpressionConverter.Convert(__workflow_xUIPATHOrganizationUnitId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipath")]
        public IBodyWorkflowAction<JobDto, ApiConnectionActionConfiguration> StartJobs(Expression<Func<int>> xUIPATHOrganizationUnitId, Expression<Func<double>> processId, Expression<Func<object>> dynamicListSchema = null, Expression<Func<bool>> runAsMe = null)
        {
            var __workflow_xUIPATHOrganizationUnitId = WorkflowExpression.Compile(xUIPATHOrganizationUnitId, nameof(xUIPATHOrganizationUnitId), required: true);
            var __workflow_processId = WorkflowExpression.Compile(processId, nameof(processId), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: false);
            var __workflow_runAsMe = WorkflowExpression.Compile(runAsMe, nameof(runAsMe), required: false);
            return new DeferredBodyAction<JobDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/jobs/startjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["processId"] = ExpressionConverter.Convert(__workflow_processId);
                callPayload.Queries["runAsMe"] = Convert.ToString(true);
                if (__workflow_runAsMe != null)
                    callPayload.Queries["runAsMe"] = ExpressionConverter.Convert(__workflow_runAsMe);
                callPayload.Headers["X-UIPATH-OrganizationUnitId"] = ExpressionConverter.Convert(__workflow_xUIPATHOrganizationUnitId);
                if (__workflow_dynamicListSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
                return new ApiConnectionAction<JobDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipath")]
        public IBodyWorkflowAction<QueueItemDto, ApiConnectionActionConfiguration> AddQueueItem(Expression<Func<int>> xUIPATHOrganizationUnitId, Expression<Func<object>> dynamicListSchema, Expression<Func<int>> queueId, Expression<Func<string>> deferDate = null, Expression<Func<string>> dueDate = null, Expression<Func<string>> riskSlaDate = null, Expression<Func<string>> reference = null, Expression<Func<string>> progress = null, Expression<Func<string>> parentOperationId = null, Expression<Func<priorityInput>> priority = null)
        {
            var __workflow_xUIPATHOrganizationUnitId = WorkflowExpression.Compile(xUIPATHOrganizationUnitId, nameof(xUIPATHOrganizationUnitId), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: true);
            var __workflow_queueId = WorkflowExpression.Compile(queueId, nameof(queueId), required: true);
            var __workflow_deferDate = WorkflowExpression.Compile(deferDate, nameof(deferDate), required: false);
            var __workflow_dueDate = WorkflowExpression.Compile(dueDate, nameof(dueDate), required: false);
            var __workflow_riskSlaDate = WorkflowExpression.Compile(riskSlaDate, nameof(riskSlaDate), required: false);
            var __workflow_reference = WorkflowExpression.Compile(reference, nameof(reference), required: false);
            var __workflow_progress = WorkflowExpression.Compile(progress, nameof(progress), required: false);
            var __workflow_parentOperationId = WorkflowExpression.Compile(parentOperationId, nameof(parentOperationId), required: false);
            var __workflow_priority = WorkflowExpression.Compile(priority, nameof(priority), required: false);
            return new DeferredBodyAction<QueueItemDto, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/queue/addQueueItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["queueId"] = ExpressionConverter.Convert(__workflow_queueId);
                if (__workflow_deferDate != null)
                    callPayload.Queries["deferDate"] = ExpressionConverter.Convert(__workflow_deferDate);
                if (__workflow_dueDate != null)
                    callPayload.Queries["dueDate"] = ExpressionConverter.Convert(__workflow_dueDate);
                if (__workflow_riskSlaDate != null)
                    callPayload.Queries["riskSlaDate"] = ExpressionConverter.Convert(__workflow_riskSlaDate);
                if (__workflow_reference != null)
                    callPayload.Queries["reference"] = ExpressionConverter.Convert(__workflow_reference);
                if (__workflow_progress != null)
                    callPayload.Queries["progress"] = ExpressionConverter.Convert(__workflow_progress);
                if (__workflow_parentOperationId != null)
                    callPayload.Queries["parentOperationId"] = ExpressionConverter.Convert(__workflow_parentOperationId);
                if (__workflow_priority != null)
                    callPayload.Queries["priority"] = ExpressionConverter.Convert(__workflow_priority);
                callPayload.Headers["X-UIPATH-OrganizationUnitId"] = ExpressionConverter.Convert(__workflow_xUIPATHOrganizationUnitId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
                return new ApiConnectionAction<QueueItemDto>(callPayload);
            });
        }
    }

    public class UipathTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetJobUpdateInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("jobKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public string JobId { get; set; }
    }

    public class JobDto
    {
        [JsonProperty("Id")]
        public int JobId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        [JsonProperty("State")]
        public JobDtoJobStateType JobState { get; set; }
        public JobDtoJobPriorityType JobPriority { get; set; }
        public SimpleRobotDto Robot { get; set; }
        public SimpleReleaseDto Release { get; set; }
        public string Source { get; set; }
        public JobDtoSourceTypeType SourceType { get; set; }
        public string BatchExecutionKey { get; set; }
        public string Info { get; set; }
        public string CreationTime { get; set; }
        public string StartingScheduleId { get; set; }
        public string ReleaseName { get; set; }
        public JobDtoTypeType Type { get; set; }
        public string InputArguments { get; set; }
        public string OutputArguments { get; set; }
        public string HostMachineName { get; set; }
        public bool HasMediaRecorded { get; set; }
        public string PersistenceId { get; set; }
        public string ResumeVersion { get; set; }
        public JobDtoStopStrategyType StopStrategy { get; set; }
        public JobDtoRuntimeTypeType RuntimeType { get; set; }
        public bool RequiresUserInteraction { get; set; }
        public int ReleaseVersionId { get; set; }
        public string EntryPointPath { get; set; }
        public int OrganizationUnitId { get; set; }
        public string OrganizationUnitFullyQualifiedName { get; set; }
        public string Reference { get; set; }
        public JobDtoProcessTypeType ProcessType { get; set; }
        public string Key { get; set; }
        public MachineDto Machine { get; set; }
        public string ProfilingOptions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoJobStateType
    {
        Pending,
        Running,
        Stopping,
        Terminating,
        Faulted,
        Successful,
        Stopped,
        Suspended,
        Resumed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoJobPriorityType
    {
        Low,
        Normal,
        High
    }

    public class SimpleRobotDto
    {
        public string LicenseKey { get; set; }
        public string MachineName { get; set; }
        public int MachineId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string ExternalName { get; set; }
        public string Description { get; set; }
        public SimpleRobotDtoTypeType Type { get; set; }
        public SimpleRobotDtoHostingTypeType HostingType { get; set; }
        public SimpleRobotDtoProvisionTypeType ProvisionType { get; set; }
        public string Password { get; set; }
        public int CredentialStoreId { get; set; }
        public int UserId { get; set; }
        public bool Enabled { get; set; }
        public SimpleRobotDtoCredentialTypeType CredentialType { get; set; }
        public EnvironmentDto[] Environments { get; set; }
        public string RobotEnvironments { get; set; }
        public JToken ExecutionSettings { get; set; }
        public bool IsExternalLicensed { get; set; }
        public bool LimitConcurrentExecution { get; set; }
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleRobotDtoTypeType
    {
        NonProduction,
        Attended,
        Unattended,
        Studio,
        RpaDeveloper,
        Development,
        StudioX,
        CitizenDeveloper,
        Headless,
        RpaDeveloperPro,
        StudioPro,
        TestAutomation
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleRobotDtoHostingTypeType
    {
        Standard,
        Floating
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleRobotDtoProvisionTypeType
    {
        Manual,
        Automatic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleRobotDtoCredentialTypeType
    {
        Default,
        SmartCard,
        NCipher,
        SafeNet
    }

    public class EnvironmentDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SimpleRobotDto[] Robots { get; set; }
        public EnvironmentDtoTypeType Type { get; set; }
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EnvironmentDtoTypeType
    {
        Dev,
        Test,
        Prod
    }

    public class SimpleReleaseDto
    {
        public string Key { get; set; }
        public string ProcessKey { get; set; }
        public string ProcessVersion { get; set; }
        public bool IsLatestVersion { get; set; }
        public bool IsProcessDeleted { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
        public EnvironmentDto Environment { get; set; }
        public int EntryPointId { get; set; }
        public EntryPointDto EntryPoint { get; set; }
        public string InputArguments { get; set; }
        public SimpleReleaseDtoProcessTypeType ProcessType { get; set; }
        public bool SupportsMultipleEntryPoints { get; set; }
        public bool RequiresUserInteraction { get; set; }
        public ReleaseVersionDto CurrentVersion { get; set; }
        public ReleaseVersionDto[] ReleaseVersions { get; set; }
        public ArgumentMetadata Arguments { get; set; }
        public string ProcessSettings { get; set; }
        public bool AutoUpdate { get; set; }
        public string FeedId { get; set; }
        public SimpleReleaseDtoJobPriorityType JobPriority { get; set; }
        public string CreationTime { get; set; }
        public int OrganizationUnitId { get; set; }
        public string OrganizationUnitFullyQualifiedName { get; set; }
        public int Id { get; set; }
    }

    public class EntryPointDto
    {
        public string UniqueId { get; set; }
        public string Path { get; set; }
        public string InputArguments { get; set; }
        public string OutputArguments { get; set; }
        public EntryPointDataVariationDto DataVariation { get; set; }
        public int Id { get; set; }
    }

    public class EntryPointDataVariationDto
    {
        public string Content { get; set; }
        public EntryPointDataVariationDtoContentTypeType ContentType { get; set; }
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EntryPointDataVariationDtoContentTypeType
    {
        Json
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleReleaseDtoProcessTypeType
    {
        Undefined,
        Process,
        TestAutomationProcess
    }

    public class ReleaseVersionDto
    {
        public int ReleaseId { get; set; }
        public string VersionNumber { get; set; }
        public string CreationTime { get; set; }
        public string ReleaseName { get; set; }
        public int Id { get; set; }
    }

    public class ArgumentMetadata
    {
        public string Input { get; set; }
        public string Output { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleReleaseDtoJobPriorityType
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoSourceTypeType
    {
        Manual,
        Schedule,
        Agent,
        Queue,
        StudioWeb
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoTypeType
    {
        Unattended,
        Attended
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoStopStrategyType
    {
        SoftStop,
        Kill
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoRuntimeTypeType
    {
        NonProduction,
        Attended,
        Unattended,
        Studio,
        RpaDeveloper,
        Development,
        StudioX,
        CitizenDeveloper,
        Headless,
        RpaDeveloperPro,
        StudioPro,
        TestAutomation
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoProcessTypeType
    {
        Undefined,
        Process,
        TestAutomationProcess
    }

    public class MachineDto
    {
        public string LicenseKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public MachineDtoTypeType Type { get; set; }
        public MachineDtoScopeType Scope { get; set; }
        public int NonProductionSlots { get; set; }
        public int UnattendedSlots { get; set; }
        public int HeadlessSlots { get; set; }
        public int TestAutomationSlots { get; set; }
        public string Key { get; set; }
        public MachinesRobotVersionDto[] RobotVersions { get; set; }
        public RobotUserDto[] RobotUsers { get; set; }
        public MachineDtoAutoScalingProfileType AutoScalingProfile { get; set; }
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MachineDtoTypeType
    {
        Standard,
        Template
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MachineDtoScopeType
    {
        Default,
        Shared,
        PersonalWorkspace,
        Cloud
    }

    public class MachinesRobotVersionDto
    {
        public int Count { get; set; }
        public string Version { get; set; }
        public int MachineId { get; set; }
    }

    public class RobotUserDto
    {
        public string UserName { get; set; }
        public int RobotId { get; set; }
        public bool HasTriggers { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum MachineDtoAutoScalingProfileType
    {
        CostEfficient,
        Balanced,
        Fast,
        Custom
    }

    public class QueueItemDto
    {
        public int QueueDefinitionId { get; set; }
        public ProcessingExceptionDto ProcessingException { get; set; }
        public JToken SpecificContent { get; set; }
        public JToken Output { get; set; }
        public string OutputData { get; set; }
        public JToken Analytics { get; set; }
        public string AnalyticsData { get; set; }
        public QueueItemDtoStatusType Status { get; set; }
        public QueueItemDtoReviewStatusType ReviewStatus { get; set; }
        public int ReviewerUserId { get; set; }
        public string Key { get; set; }
        public string Reference { get; set; }
        public QueueItemDtoProcessingExceptionTypeType ProcessingExceptionType { get; set; }
        public string DueDate { get; set; }
        public string RiskSlaDate { get; set; }
        public QueueItemDtoPriorityType Priority { get; set; }
        public string DeferDate { get; set; }
        public string StartProcessing { get; set; }
        public string EndProcessing { get; set; }
        public int SecondsInPreviousAttempts { get; set; }
        public int AncestorId { get; set; }
        public int RetryNumber { get; set; }
        public string SpecificData { get; set; }
        public string CreationTime { get; set; }
        public string Progress { get; set; }
        public string RowVersion { get; set; }
        public int OrganizationUnitId { get; set; }
        public string OrganizationUnitFullyQualifiedName { get; set; }
        public int Id { get; set; }
    }

    public class ProcessingExceptionDto
    {
        public string Reason { get; set; }
        public string Details { get; set; }
        public ProcessingExceptionDtoTypeType Type { get; set; }
        public string AssociatedImageFilePath { get; set; }
        public string CreationTime { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ProcessingExceptionDtoTypeType
    {
        ApplicationException,
        BusinessException
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueueItemDtoStatusType
    {
        New,
        InProgress,
        Failed,
        Successful,
        Abandoned,
        Retried,
        Deleted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueueItemDtoReviewStatusType
    {
        None,
        InReview,
        Verified,
        Retried
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueueItemDtoProcessingExceptionTypeType
    {
        ApplicationException,
        BusinessException
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum QueueItemDtoPriorityType
    {
        High,
        Normal,
        Low
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum priorityInput
    {
        High,
        Normal,
        Low
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Uipath;

    public partial class WorkflowManagedActions
    {
        public UipathActions Uipath(string connectionId) => new UipathActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UipathTriggers Uipath(string connectionId) => new UipathTriggers(connectionId);
    }
}