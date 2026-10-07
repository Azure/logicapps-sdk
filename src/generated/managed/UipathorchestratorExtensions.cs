//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uipathorchestrator
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UipathorchestratorActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipathorchestrator")]
        [WorkflowExpressionFactory(nameof(__BuildStartJobs))]
        public IBodyWorkflowAction<ODataValueOfIEnumerableOfJobDto> StartJobs([WorkflowExpression] Func<int> xUIPATHOrganizationUnitId, [WorkflowExpression] Func<string> bodystartInfoprocessName = null, [WorkflowExpression] Func<int> bodystartInfojobsCount = null, [WorkflowExpression] Func<bodystartInfosourceInput> bodystartInfosource = null, [WorkflowExpression] Func<bodystartInfojobPriorityInput> bodystartInfojobPriority = null, [WorkflowExpression] Func<bodystartInforuntimeTypeInput> bodystartInforuntimeType = null, [WorkflowExpression] Func<string> bodystartInfoinputArguments = null, [WorkflowExpression] Func<string> bodystartInforeference = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipathorchestrator")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ODataValueOfIEnumerableOfJobDto> __BuildStartJobs(WorkflowExpression<int> xUIPATHOrganizationUnitId, WorkflowExpression<string> bodystartInfoprocessName = null, WorkflowExpression<int> bodystartInfojobsCount = null, WorkflowExpression<bodystartInfosourceInput> bodystartInfosource = null, WorkflowExpression<bodystartInfojobPriorityInput> bodystartInfojobPriority = null, WorkflowExpression<bodystartInforuntimeTypeInput> bodystartInforuntimeType = null, WorkflowExpression<string> bodystartInfoinputArguments = null, WorkflowExpression<string> bodystartInforeference = null)
        {
            WorkflowExpression.Validate(xUIPATHOrganizationUnitId, nameof(xUIPATHOrganizationUnitId), required: true);
            WorkflowExpression.Validate(bodystartInfoprocessName, nameof(bodystartInfoprocessName), required: false);
            WorkflowExpression.Validate(bodystartInfojobsCount, nameof(bodystartInfojobsCount), required: false);
            WorkflowExpression.Validate(bodystartInfosource, nameof(bodystartInfosource), required: false);
            WorkflowExpression.Validate(bodystartInfojobPriority, nameof(bodystartInfojobPriority), required: false);
            WorkflowExpression.Validate(bodystartInforuntimeType, nameof(bodystartInforuntimeType), required: false);
            WorkflowExpression.Validate(bodystartInfoinputArguments, nameof(bodystartInfoinputArguments), required: false);
            WorkflowExpression.Validate(bodystartInforeference, nameof(bodystartInforeference), required: false);
            return new DeferredBodyAction<ODataValueOfIEnumerableOfJobDto>(() =>
            {
                var apiCallPath = "/odata/Jobs/UiPath.Server.Configuration.OData.StartJobs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-UIPATH-OrganizationUnitId"] = ExpressionConverter.Convert(xUIPATHOrganizationUnitId);
                var body = new JObject();
                var bodypropCount = 0;
                var startInfoObject = new JObject();
                var startInfoObjectpropCount = 0;
                if (bodystartInfoprocessName != null)
                {
                    startInfoObject["ReleaseKey"] = ExpressionConverter.ConvertO(bodystartInfoprocessName);
                    startInfoObjectpropCount++;
                }

                startInfoObject["Strategy"] = "ModernJobsCount";
                startInfoObjectpropCount++;
                if (bodystartInfojobsCount != null)
                {
                    startInfoObject["JobsCount"] = ExpressionConverter.ConvertO(bodystartInfojobsCount);
                    startInfoObjectpropCount++;
                }

                if (bodystartInfosource != null)
                {
                    startInfoObject["Source"] = ExpressionConverter.ConvertO(bodystartInfosource);
                    startInfoObjectpropCount++;
                }

                if (bodystartInfojobPriority != null)
                {
                    startInfoObject["JobPriority"] = ExpressionConverter.ConvertO(bodystartInfojobPriority);
                    startInfoObjectpropCount++;
                }

                if (bodystartInforuntimeType != null)
                {
                    startInfoObject["RuntimeType"] = ExpressionConverter.ConvertO(bodystartInforuntimeType);
                    startInfoObjectpropCount++;
                }

                if (bodystartInfoinputArguments != null)
                {
                    startInfoObject["InputArguments"] = ExpressionConverter.ConvertO(bodystartInfoinputArguments);
                    startInfoObjectpropCount++;
                }

                if (bodystartInforeference != null)
                {
                    startInfoObject["Reference"] = ExpressionConverter.ConvertO(bodystartInforeference);
                    startInfoObjectpropCount++;
                }

                if (startInfoObjectpropCount > 0)
                {
                    body["startInfo"] = startInfoObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ODataValueOfIEnumerableOfJobDto>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipathorchestrator")]
        [WorkflowExpressionFactory(nameof(__BuildAddQueueItem))]
        public IBodyWorkflowAction<QueueItemDto> AddQueueItem([WorkflowExpression] Func<int> xUIPATHOrganizationUnitId, [WorkflowExpression] Func<string> bodyitemDataname = null, [WorkflowExpression] Func<bodyitemDatapriorityInput> bodyitemDatapriority = null, [WorkflowExpression] Func<string> bodyitemDatadeferDate = null, [WorkflowExpression] Func<string> bodyitemDatadueDate = null, [WorkflowExpression] Func<string> bodyitemDatariskSLADate = null, [WorkflowExpression] Func<string> bodyitemDatareference = null, [WorkflowExpression] Func<string> bodyitemDataprogress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipathorchestrator")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueueItemDto> __BuildAddQueueItem(WorkflowExpression<int> xUIPATHOrganizationUnitId, WorkflowExpression<string> bodyitemDataname = null, WorkflowExpression<bodyitemDatapriorityInput> bodyitemDatapriority = null, WorkflowExpression<string> bodyitemDatadeferDate = null, WorkflowExpression<string> bodyitemDatadueDate = null, WorkflowExpression<string> bodyitemDatariskSLADate = null, WorkflowExpression<string> bodyitemDatareference = null, WorkflowExpression<string> bodyitemDataprogress = null)
        {
            WorkflowExpression.Validate(xUIPATHOrganizationUnitId, nameof(xUIPATHOrganizationUnitId), required: true);
            WorkflowExpression.Validate(bodyitemDataname, nameof(bodyitemDataname), required: false);
            WorkflowExpression.Validate(bodyitemDatapriority, nameof(bodyitemDatapriority), required: false);
            WorkflowExpression.Validate(bodyitemDatadeferDate, nameof(bodyitemDatadeferDate), required: false);
            WorkflowExpression.Validate(bodyitemDatadueDate, nameof(bodyitemDatadueDate), required: false);
            WorkflowExpression.Validate(bodyitemDatariskSLADate, nameof(bodyitemDatariskSLADate), required: false);
            WorkflowExpression.Validate(bodyitemDatareference, nameof(bodyitemDatareference), required: false);
            WorkflowExpression.Validate(bodyitemDataprogress, nameof(bodyitemDataprogress), required: false);
            return new DeferredBodyAction<QueueItemDto>(() =>
            {
                var apiCallPath = "/odata/Queues/UiPathODataSvc.AddQueueItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-UIPATH-OrganizationUnitId"] = ExpressionConverter.Convert(xUIPATHOrganizationUnitId);
                var body = new JObject();
                var bodypropCount = 0;
                var itemDataObject = new JObject();
                var itemDataObjectpropCount = 0;
                if (bodyitemDataname != null)
                {
                    itemDataObject["Name"] = ExpressionConverter.ConvertO(bodyitemDataname);
                    itemDataObjectpropCount++;
                }

                if (bodyitemDatapriority != null)
                {
                    if (bodyitemDatapriority != null)
                    {
                        itemDataObject["Priority"] = ExpressionConverter.ConvertO(bodyitemDatapriority);
                        itemDataObjectpropCount++;
                    }

                    itemDataObjectpropCount++;
                }
                else
                {
                    itemDataObject["Priority"] = "Normal";
                    itemDataObjectpropCount++;
                }

                var specificContentObject = new JObject();
                var specificContentObjectpropCount = 0;
                if (specificContentObjectpropCount > 0)
                {
                    itemDataObject["SpecificContent"] = specificContentObject;
                    itemDataObjectpropCount++;
                }

                if (bodyitemDatadeferDate != null)
                {
                    itemDataObject["DeferDate"] = ExpressionConverter.ConvertO(bodyitemDatadeferDate);
                    itemDataObjectpropCount++;
                }

                if (bodyitemDatadueDate != null)
                {
                    itemDataObject["DueDate"] = ExpressionConverter.ConvertO(bodyitemDatadueDate);
                    itemDataObjectpropCount++;
                }

                if (bodyitemDatariskSLADate != null)
                {
                    itemDataObject["RiskSlaDate"] = ExpressionConverter.ConvertO(bodyitemDatariskSLADate);
                    itemDataObjectpropCount++;
                }

                if (bodyitemDatareference != null)
                {
                    itemDataObject["Reference"] = ExpressionConverter.ConvertO(bodyitemDatareference);
                    itemDataObjectpropCount++;
                }

                if (bodyitemDataprogress != null)
                {
                    itemDataObject["Progress"] = ExpressionConverter.ConvertO(bodyitemDataprogress);
                    itemDataObjectpropCount++;
                }

                if (itemDataObjectpropCount > 0)
                {
                    body["itemData"] = itemDataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueueItemDto>(callPayload);
            });
        }
    }

    public class UipathorchestratorTriggers([ConnectionName] string connectionId)
    {
    }

    public class ODataValueOfIEnumerableOfJobDto
    {
        [JsonProperty("value")]
        public JobDto[] Value { get; set; }
    }

    public class JobDto
    {
        public string Key { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public JobDtoStateType State { get; set; }
        public JobDtoJobPriorityType JobPriority { get; set; }
        public SimpleRobotDto Robot { get; set; }
        public SimpleReleaseDto Release { get; set; }
        public string Source { get; set; }
        public JobDtoSourceTypeType SourceType { get; set; }
        public string BatchExecutionKey { get; set; }
        public string Info { get; set; }
        public string CreationTime { get; set; }
        public int StartingScheduleId { get; set; }
        public string ReleaseName { get; set; }
        public JobDtoTypeType Type { get; set; }
        public string InputArguments { get; set; }
        public string OutputArguments { get; set; }
        public string HostMachineName { get; set; }
        public bool HasMediaRecorded { get; set; }
        public string PersistenceId { get; set; }
        public int ResumeVersion { get; set; }
        public JobDtoStopStrategyType StopStrategy { get; set; }
        public JobDtoRuntimeTypeType RuntimeType { get; set; }
        public bool RequiresUserInteraction { get; set; }
        public int ReleaseVersionId { get; set; }
        public string EntryPointPath { get; set; }
        public int OrganizationUnitId { get; set; }
        public string OrganizationUnitFullyQualifiedName { get; set; }
        public string Reference { get; set; }
        public JobDtoProcessTypeType ProcessType { get; set; }
        public MachineDto Machine { get; set; }
        public string ProfilingOptions { get; set; }
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobDtoStateType
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
        public ProcessSettingsDto ProcessSettings { get; set; }
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

    public class ProcessSettingsDto
    {
        public bool ErrorRecordingEnabled { get; set; }
        public int Duration { get; set; }
        public int Frequency { get; set; }
        public int Quality { get; set; }
        public bool AutoStartProcess { get; set; }
        public bool AlwaysRunning { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystartInfosourceInput
    {
        Manual,
        Schedule,
        Queue,
        StudioWeb
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystartInfojobPriorityInput
    {
        Low,
        Normal,
        High
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystartInforuntimeTypeInput
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

    public class QueueItemDto
    {
        public int QueueDefinitionId { get; set; }
        public QueueDefinitionDto QueueDefinition { get; set; }
        public ProcessingExceptionDto ProcessingException { get; set; }
        public JToken SpecificContent { get; set; }
        public JToken Output { get; set; }
        public string OutputData { get; set; }
        public JToken Analytics { get; set; }
        public string AnalyticsData { get; set; }
        public QueueItemDtoStatusType Status { get; set; }
        public QueueItemDtoReviewStatusType ReviewStatus { get; set; }
        public int ReviewerUserId { get; set; }
        public SimpleUserDto ReviewerUser { get; set; }
        public string Key { get; set; }
        public string Reference { get; set; }
        public QueueItemDtoProcessingExceptionTypeType ProcessingExceptionType { get; set; }
        public string DueDate { get; set; }
        public string RiskSlaDate { get; set; }
        public QueueItemDtoPriorityType Priority { get; set; }
        public SimpleRobotDto Robot { get; set; }
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

    public class QueueDefinitionDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxNumberOfRetries { get; set; }
        public bool AcceptAutomaticallyRetry { get; set; }
        public bool EnforceUniqueReference { get; set; }
        public string SpecificDataJsonSchema { get; set; }
        public string OutputDataJsonSchema { get; set; }
        public string AnalyticsDataJsonSchema { get; set; }
        public string CreationTime { get; set; }
        public int ProcessScheduleId { get; set; }
        public int SlaInMinutes { get; set; }
        public int RiskSlaInMinutes { get; set; }
        public int ReleaseId { get; set; }
        public bool IsProcessInCurrentFolder { get; set; }
        public int FoldersCount { get; set; }
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

    public class SimpleUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Domain { get; set; }
        public string DirectoryIdentifier { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string LastLoginTime { get; set; }
        public bool IsActive { get; set; }
        public string CreationTime { get; set; }
        public string AuthenticationSource { get; set; }
        public string Password { get; set; }
        public bool IsExternalLicensed { get; set; }
        public UserRoleDto[] UserRoles { get; set; }
        public string[] RolesList { get; set; }
        public string[] LoginProviders { get; set; }
        public OrganizationUnitDto[] OrganizationUnits { get; set; }
        public int TenantId { get; set; }
        public string TenancyName { get; set; }
        public string TenantDisplayName { get; set; }
        public string TenantKey { get; set; }
        public SimpleUserDtoTypeType Type { get; set; }
        public SimpleUserDtoProvisionTypeType ProvisionType { get; set; }
        public SimpleUserDtoLicenseTypeType LicenseType { get; set; }
        public AttendedRobotDto RobotProvision { get; set; }
        public UnattendedRobotDto UnattendedRobot { get; set; }
        public UserNotificationSubscription NotificationSubscription { get; set; }
        public string Key { get; set; }
        public bool MayHaveUserSession { get; set; }
        public bool MayHaveRobotSession { get; set; }
        public bool MayHaveUnattendedSession { get; set; }
        public bool BypassBasicAuthRestriction { get; set; }
        public bool MayHavePersonalWorkspace { get; set; }
        public int Id { get; set; }
    }

    public class UserRoleDto
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public UserRoleDtoRoleTypeType RoleType { get; set; }
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserRoleDtoRoleTypeType
    {
        Mixed,
        Tenant,
        Folder
    }

    public class OrganizationUnitDto
    {
        public string DisplayName { get; set; }
        public int Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleUserDtoTypeType
    {
        User,
        Robot,
        DirectoryUser,
        DirectoryGroup
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleUserDtoProvisionTypeType
    {
        Manual,
        Automatic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleUserDtoLicenseTypeType
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

    public class AttendedRobotDto
    {
        public string UserName { get; set; }
        public JToken ExecutionSettings { get; set; }
        public int RobotId { get; set; }
        public AttendedRobotDtoRobotTypeType RobotType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AttendedRobotDtoRobotTypeType
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

    public class UnattendedRobotDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CredentialStoreId { get; set; }
        public UnattendedRobotDtoCredentialTypeType CredentialType { get; set; }
        public string CredentialExternalName { get; set; }
        public JToken ExecutionSettings { get; set; }
        public bool LimitConcurrentExecution { get; set; }
        public int RobotId { get; set; }
        public int MachineMappingsCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UnattendedRobotDtoCredentialTypeType
    {
        Default,
        SmartCard,
        NCipher,
        SafeNet
    }

    public class UserNotificationSubscription
    {
        public bool Queues { get; set; }
        public bool Robots { get; set; }
        public bool Jobs { get; set; }
        public bool Schedules { get; set; }
        public bool Tasks { get; set; }
        public bool QueueItems { get; set; }
        public bool Insights { get; set; }
        public bool CloudRobots { get; set; }
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
    public enum bodyitemDatapriorityInput
    {
        High,
        Normal,
        Low
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Uipathorchestrator;

    public partial class WorkflowManagedActions
    {
        public UipathorchestratorActions Uipathorchestrator(string connectionId) => new UipathorchestratorActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UipathorchestratorTriggers Uipathorchestrator(string connectionId) => new UipathorchestratorTriggers(connectionId);
    }
}