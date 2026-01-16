//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Uipathorchestrator
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UipathorchestratorActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "uipathorchestrator")]
        public IBodyWorkflowAction<QueueItemDto> AddQueueItem(Expression<Func<int>> xUIPATHOrganizationUnitId, Expression<Func<string>> bodyitemDataName = null, Expression<Func<bodyitemDataPriorityInput>> bodyitemDataPriority = null, Expression<Func<string>> bodyitemDatadeferDate = null, Expression<Func<string>> bodyitemDatadueDate = null, Expression<Func<string>> bodyitemDatariskSLADate = null, Expression<Func<string>> bodyitemDataReference = null, Expression<Func<string>> bodyitemDataProgress = null)
        {
            var apiCallPath = "/odata/Queues/UiPathODataSvc.AddQueueItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-UIPATH-OrganizationUnitId"] = ExpressionConverter.Convert(xUIPATHOrganizationUnitId);
            var body = new JObject();
            var bodypropCount = 0;
            var itemDataObject = new JObject();
            var itemDataObjectpropCount = 0;
            if (bodyitemDataName != null)
            {
                itemDataObject["Name"] = ExpressionConverter.ConvertO(bodyitemDataName);
                itemDataObjectpropCount++;
            }

            if (bodyitemDataPriority != null)
            {
                itemDataObject["Priority"] = ExpressionConverter.ConvertO(bodyitemDataPriority);
                itemDataObjectpropCount++;
            }

            var SpecificContentObject = new JObject();
            var SpecificContentObjectpropCount = 0;
            if (SpecificContentObjectpropCount > 0)
            {
                itemDataObject["SpecificContent"] = SpecificContentObject;
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

            if (bodyitemDataReference != null)
            {
                itemDataObject["Reference"] = ExpressionConverter.ConvertO(bodyitemDataReference);
                itemDataObjectpropCount++;
            }

            if (bodyitemDataProgress != null)
            {
                itemDataObject["Progress"] = ExpressionConverter.ConvertO(bodyitemDataProgress);
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
        }
    }

    public class UipathorchestratorTriggers([ConnectionName] string connectionId)
    {
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

    public enum ProcessingExceptionDtoTypeType
    {
        ApplicationException,
        BusinessException
    }

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

    public enum SimpleUserDtoTypeType
    {
        User,
        Robot,
        DirectoryUser,
        DirectoryGroup
    }

    public enum SimpleUserDtoProvisionTypeType
    {
        Manual,
        Automatic
    }

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

    public enum QueueItemDtoProcessingExceptionTypeType
    {
        ApplicationException,
        BusinessException
    }

    public enum QueueItemDtoPriorityType
    {
        High,
        Normal,
        Low
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

    public enum SimpleRobotDtoHostingTypeType
    {
        Standard,
        Floating
    }

    public enum SimpleRobotDtoProvisionTypeType
    {
        Manual,
        Automatic
    }

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

    public enum EnvironmentDtoTypeType
    {
        Dev,
        Test,
        Prod
    }

    public enum bodyitemDataPriorityInput
    {
        High,
        Normal,
        Low
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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