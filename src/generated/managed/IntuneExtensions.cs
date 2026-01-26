//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Intune
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntuneActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction GetTotalAssignedDeviceCountForPayload(Expression<Func<string>> bodyFilter)
        {
            var apiCallPath = "/beta/deviceManagement/reports/getHistoricalReport";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["name"] = "TotalTargetedDeviceCountForPayload";
            bodypropCount++;
            bodypropCount++;
            body["Filter"] = ExpressionConverter.ConvertO(bodyFilter);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction GetAppStatusOverviewReport(Expression<Func<string>> bodyFilter)
        {
            var apiCallPath = "/beta/deviceManagement/reports/getAppStatusOverviewReport";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Filter"] = ExpressionConverter.ConvertO(bodyFilter);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IBodyWorkflowAction<GetElevationRequestsResponse> GetElevationRequests(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/beta/deviceManagement/elevationRequests";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetElevationRequestsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction ApproveEPMElevationRequest(Expression<Func<string>> elevationRequestId, Expression<Func<string>> bodyreviewerJustification)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/elevationRequests('{0}')/approve", ExpressionConverter.ConvertWithUrlEncoding(elevationRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["reviewerJustification"] = ExpressionConverter.ConvertO(bodyreviewerJustification);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction DenyEPMElevationRequest(Expression<Func<string>> elevationRequestId, Expression<Func<string>> bodyreviewerJustification)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/elevationRequests('{0}')/deny", ExpressionConverter.ConvertWithUrlEncoding(elevationRequestId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["reviewerJustification"] = ExpressionConverter.ConvertO(bodyreviewerJustification);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction RetireDevice(Expression<Func<string>> managedDeviceId)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/managedDevices('{0}')/retire", ExpressionConverter.ConvertWithUrlEncoding(managedDeviceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction WipeDevice(Expression<Func<string>> managedDeviceId, Expression<Func<bool>> bodykeepEnrollmentData = null, Expression<Func<bool>> bodykeepUserData = null, Expression<Func<bool>> bodyuseProtectedWipe = null, Expression<Func<bool>> bodypersistEsimDataPlan = null, Expression<Func<bodyobliterationBehaviorInput>> bodyobliterationBehavior = null, Expression<Func<string>> bodymacOsUnlockCode = null)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/managedDevices('{0}')/wipe", ExpressionConverter.ConvertWithUrlEncoding(managedDeviceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykeepEnrollmentData != null)
            {
                body["keepEnrollmentData"] = ExpressionConverter.ConvertO(bodykeepEnrollmentData);
                bodypropCount++;
            }

            if (bodykeepUserData != null)
            {
                body["keepUserData"] = ExpressionConverter.ConvertO(bodykeepUserData);
                bodypropCount++;
            }

            if (bodyuseProtectedWipe != null)
            {
                body["useProtectedWipe"] = ExpressionConverter.ConvertO(bodyuseProtectedWipe);
                bodypropCount++;
            }

            if (bodypersistEsimDataPlan != null)
            {
                body["persistEsimDataPlan"] = ExpressionConverter.ConvertO(bodypersistEsimDataPlan);
                bodypropCount++;
            }

            if (bodyobliterationBehavior != null)
            {
                body["obliterationBehavior"] = ExpressionConverter.ConvertO(bodyobliterationBehavior);
                bodypropCount++;
            }

            if (bodymacOsUnlockCode != null)
            {
                body["macOsUnlockCode"] = ExpressionConverter.ConvertO(bodymacOsUnlockCode);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction DeleteDevice(Expression<Func<string>> managedDeviceId)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/managedDevices/{0}", ExpressionConverter.ConvertWithUrlEncoding(managedDeviceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction UpdateStatus(Expression<Func<string>> taskId, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<string>> bodynote)
        {
            var apiCallPath = String.Format("/beta/DeviceAppManagement/deviceAppManagementTasks('{0}')/updateStatus", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            bodypropCount++;
            body["note"] = ExpressionConverter.ConvertO(bodynote);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IBodyWorkflowAction<WindowsQualityUpdateCatalogItemResponse> ListWindowsUpdateCatalogItems(Expression<Func<filterInput>> filter, Expression<Func<string>> select = null)
        {
            var apiCallPath = "/beta/deviceManagement/windowsUpdateCatalogItems";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<WindowsQualityUpdateCatalogItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IWorkflowAction SetDeviceName(Expression<Func<string>> managedDeviceId, Expression<Func<string>> bodynewDeviceName)
        {
            var apiCallPath = String.Format("/beta/deviceManagement/managedDevices('{0}')/setDeviceName", ExpressionConverter.ConvertWithUrlEncoding(managedDeviceId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["deviceName"] = ExpressionConverter.ConvertO(bodynewDeviceName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "intune")]
        public IBodyWorkflowAction<GetDeviceDetailsResponse> GetDeviceDetails(Expression<Func<string>> aADDeviceId, Expression<Func<string>> select = null)
        {
            var apiCallPath = String.Format("/beta/devices(deviceId='{0}')", ExpressionConverter.ConvertWithUrlEncoding(aADDeviceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["$select"] = Convert.ToString("id,deviceId");
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            return new ApiConnectionAction<GetDeviceDetailsResponse>(callPayload);
        }
    }

    public class IntuneTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<DeviceAppManagementTasksResponse> CheckPendingWindows11SecurityTask(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/beta/DeviceAppManagement/deviceAppManagementTasks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<DeviceAppManagementTasksResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetElevationRequestsResponse> GetEPMElevationRequests(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/beta/deviceManagement/elevationRequests";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetElevationRequestsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetManagedDeviceDetailsResponse> GetNonCompliantDevices(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/beta/deviceManagement/managedDevices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetManagedDeviceDetailsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetManagedDeviceDetailsResponse> GetJailBrokenDevices(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger1/beta/deviceManagement/managedDevices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetManagedDeviceDetailsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetManagedDeviceDetailsResponse> GetNewlyEnrolledDevices(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger2/beta/deviceManagement/managedDevices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<GetManagedDeviceDetailsResponse>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<GetManagedDeviceDetailsResponse> GetInactiveDevices(Expression<Func<int>> inactiveDays, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger3/beta/deviceManagement/managedDevices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["InactiveDays"] = ExpressionConverter.Convert(inactiveDays);
            return new ApiConnectionTrigger<GetManagedDeviceDetailsResponse>(callPayload, triggerName, recurrence);
        }
    }

    public class GetElevationRequestsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetElevationRequestsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetElevationRequestsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("requestedByUserId")]
        public string RequestedByUserId { get; set; }

        [JsonProperty("requestedOnDeviceId")]
        public string RequestedOnDeviceId { get; set; }

        [JsonProperty("requestedByUserPrincipalName")]
        public string RequestedByUserPrincipalName { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("requestCreatedDateTime")]
        public string RequestCreatedDateTime { get; set; }

        [JsonProperty("requestLastModifiedDateTime")]
        public string RequestLastModifiedDateTime { get; set; }

        [JsonProperty("requestJustification")]
        public string RequestJustification { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reviewCompletedByUserId")]
        public string ReviewCompletedByUserId { get; set; }

        [JsonProperty("reviewCompletedByUserPrincipalName")]
        public string ReviewCompletedByUserPrincipalName { get; set; }

        [JsonProperty("reviewCompletedDateTime")]
        public string ReviewCompletedDateTime { get; set; }

        [JsonProperty("requestExpiryDateTime")]
        public string RequestExpiryDateTime { get; set; }

        [JsonProperty("reviewerJustification")]
        public string ReviewerJustification { get; set; }

        [JsonProperty("applicationDetail")]
        public GetElevationRequestsResponseValueTypeItemApplicationDetailType ApplicationDetail { get; set; }
    }

    public class GetElevationRequestsResponseValueTypeItemApplicationDetailType
    {
        [JsonProperty("fileHash")]
        public string FileHash { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileDescription")]
        public string FileDescription { get; set; }

        [JsonProperty("publisherName")]
        public string PublisherName { get; set; }

        [JsonProperty("publisherCert")]
        public string PublisherCert { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productInternalName")]
        public string ProductInternalName { get; set; }

        [JsonProperty("productVersion")]
        public string ProductVersion { get; set; }
    }

    public enum bodyobliterationBehaviorInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "doNotObliterate")]
        DoNotObliterate,
        [EnumMember(Value = "obliterateWithWarning")]
        ObliterateWithWarning,
        [EnumMember(Value = "always")]
        Always
    }

    public enum bodystatusInput
    {
        Pending,
        Active,
        Completed,
        Rejected
    }

    public class WindowsQualityUpdateCatalogItemResponse
    {
        [JsonProperty("value")]
        public WindowsQualityUpdateCatalogItemResponseValueTypeItem[] Value { get; set; }
    }

    public class WindowsQualityUpdateCatalogItemResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("releaseDateTime")]
        public string ReleaseDateTime { get; set; }

        [JsonProperty("endOfSupportDate")]
        public string EndOfSupportDate { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }
    }

    public enum filterInput
    {
        [EnumMember(Value = "isof('microsoft.graph.windowsFeatureUpdateCatalogItem')")]
        WindowsFeatureUpdate,
        [EnumMember(Value = "isof('microsoft.graph.windowsQualityUpdateCatalogItem')")]
        WindowsQualityUpdate
    }

    public class GetDeviceDetailsResponse
    {
        [JsonProperty("id")]
        public string EntraObjectId { get; set; }

        [JsonProperty("deviceId")]
        public string EntraDeviceId { get; set; }
    }

    public class DeviceAppManagementTasksResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public DeviceAppManagementTasksResponseValueTypeItem[] Value { get; set; }
    }

    public class DeviceAppManagementTasksResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }

        [JsonProperty("dueDateTime")]
        public string DueDateTime { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creatorNotes")]
        public string CreatorNotes { get; set; }

        [JsonProperty("assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("appName")]
        public string AppName { get; set; }

        [JsonProperty("appPublisher")]
        public string AppPublisher { get; set; }

        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        [JsonProperty("mitigationType")]
        public string MitigationType { get; set; }

        [JsonProperty("insights")]
        public string Insights { get; set; }

        [JsonProperty("managedDeviceCount")]
        public int ManagedDeviceCount { get; set; }

        [JsonProperty("mobileAppCount")]
        public int MobileAppCount { get; set; }

        [JsonProperty("remediation")]
        public string Remediation { get; set; }
    }

    public class GetManagedDeviceDetailsResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GetManagedDeviceDetailsResponseValueTypeItem[] Value { get; set; }
    }

    public class GetManagedDeviceDetailsResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string IntuneDeviceId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("ownerType")]
        public string OwnerType { get; set; }

        [JsonProperty("managedDeviceOwnerType")]
        public string ManagedDeviceOwnerType { get; set; }

        [JsonProperty("managementState")]
        public string ManagementState { get; set; }

        [JsonProperty("enrolledDateTime")]
        public string EnrolledDateTime { get; set; }

        [JsonProperty("lastSyncDateTime")]
        public string LastSyncDateTime { get; set; }

        [JsonProperty("deviceType")]
        public string DeviceType { get; set; }

        [JsonProperty("complianceState")]
        public string ComplianceState { get; set; }

        [JsonProperty("jailBroken")]
        public string JailBroken { get; set; }

        [JsonProperty("aadRegistered")]
        public bool AadRegistered { get; set; }

        [JsonProperty("azureADRegistered")]
        public bool AzureADRegistered { get; set; }

        [JsonProperty("deviceEnrollmentType")]
        public string DeviceEnrollmentType { get; set; }

        [JsonProperty("azureADDeviceId")]
        public string EntraDeviceID { get; set; }

        [JsonProperty("deviceRegistrationState")]
        public string DeviceRegistrationState { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("imei")]
        public string Imei { get; set; }

        [JsonProperty("complianceGracePeriodExpirationDateTime")]
        public string ComplianceGracePeriodExpirationDateTime { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("managedDeviceName")]
        public string ManagedDeviceName { get; set; }

        [JsonProperty("joinType")]
        public string JoinType { get; set; }

        [JsonProperty("skuFamily")]
        public string SkuFamily { get; set; }

        [JsonProperty("skuNumber")]
        public int SkuNumber { get; set; }

        [JsonProperty("enrollmentProfileName")]
        public string EnrollmentProfileName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Intune;

    public partial class WorkflowManagedActions
    {
        public IntuneActions Intune(string connectionId) => new IntuneActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntuneTriggers Intune(string connectionId) => new IntuneTriggers(connectionId);
    }
}