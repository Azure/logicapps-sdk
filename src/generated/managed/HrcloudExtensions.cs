//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hrcloud
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HrcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetEmployeeResponseItem[], ApiConnectionActionConfiguration> GetEmployee(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetEmployeeResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xEmployeeNumber eq 'ENTER EMPLOYEE NUMBER HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetEmployeeResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddEmployee(Expression<Func<AddEmployeeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateEmployee(Expression<Func<UpdateEmployeeInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetDepartmentResponseItem[], ApiConnectionActionConfiguration> GetDepartment(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetDepartmentResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xDepartment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xDepartmentName eq 'ENTER DEPARTMENT NAME HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetDepartmentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetLocationResponseItem[], ApiConnectionActionConfiguration> GetLocation(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetLocationResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xLocation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xLocationName eq 'ENTER LOCATION NAME HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetLocationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetPositionResponseItem[], ApiConnectionActionConfiguration> GetPosition(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetPositionResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xPosition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xPositionTitle eq 'ENTER POSITION TITLE HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetPositionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetDivisionResponseItem[], ApiConnectionActionConfiguration> GetDivision(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetDivisionResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xDivision";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xDivisionName eq 'ENTER DIVISION NAME HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetDivisionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetEmploymentStatusResponseItem[], ApiConnectionActionConfiguration> GetEmploymentStatus(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetEmploymentStatusResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmploymentStatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xType eq 'ENTER EMPLOYMENT STATUS TYPE HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetEmploymentStatusResponseItem[]>(callPayload);
            });
        }
    }

    public class HrcloudTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetEmployeeResponseItem
    {
        public string Id { get; set; }

        [JsonProperty("xAddress1")]
        public string XAddress1 { get; set; }

        [JsonProperty("xAddress2")]
        public string XAddress2 { get; set; }

        [JsonProperty("xBonus")]
        public GetEmployeeResponseItemXBonusType XBonus { get; set; }

        [JsonProperty("xCellPhone")]
        public string XCellPhone { get; set; }

        [JsonProperty("xCity")]
        public string XCity { get; set; }

        [JsonProperty("xCountry")]
        public string XCountry { get; set; }

        [JsonProperty("xCreatedOn")]
        public string XCreatedOn { get; set; }

        [JsonProperty("xDateOfBirth")]
        public string XDateOfBirth { get; set; }

        [JsonProperty("xDepartmentLookup")]
        public GetEmployeeResponseItemXDepartmentLookupType XDepartmentLookup { get; set; }

        [JsonProperty("xDivisionLookup")]
        public GetEmployeeResponseItemXDivisionLookupType XDivisionLookup { get; set; }

        [JsonProperty("xEducationLevel")]
        public string XEducationLevel { get; set; }

        [JsonProperty("xEmail")]
        public string XEmail { get; set; }

        [JsonProperty("xEmployeeNumber")]
        public string XEmployeeNumber { get; set; }

        [JsonProperty("xEmploymentStatusLookup")]
        public GetEmployeeResponseItemXEmploymentStatusLookupType XEmploymentStatusLookup { get; set; }

        [JsonProperty("xEmploymentTypeLookup")]
        public GetEmployeeResponseItemXEmploymentTypeLookupType XEmploymentTypeLookup { get; set; }

        [JsonProperty("xEthnicity")]
        public string XEthnicity { get; set; }

        [JsonProperty("xFirstName")]
        public string XFirstName { get; set; }

        [JsonProperty("xFullName")]
        public string XFullName { get; set; }

        [JsonProperty("xGender")]
        public string XGender { get; set; }

        [JsonProperty("xLastName")]
        public string XLastName { get; set; }

        [JsonProperty("xLocationLookup")]
        public GetEmployeeResponseItemXLocationLookupType XLocationLookup { get; set; }

        [JsonProperty("xManagerLookup")]
        public GetEmployeeResponseItemXManagerLookupType XManagerLookup { get; set; }

        [JsonProperty("xMiddleName")]
        public string XMiddleName { get; set; }

        [JsonProperty("xNickname")]
        public string XNickname { get; set; }

        [JsonProperty("xNumberOfPoints")]
        public double XNumberOfPoints { get; set; }

        [JsonProperty("xOnboardingFinishedOn")]
        public string XOnboardingFinishedOn { get; set; }

        [JsonProperty("xPayFrequencyType")]
        public string XPayFrequencyType { get; set; }

        [JsonProperty("xPayRateLookup")]
        public GetEmployeeResponseItemXPayRateLookupType XPayRateLookup { get; set; }

        [JsonProperty("xPersonalEmail")]
        public string XPersonalEmail { get; set; }

        [JsonProperty("xPictures")]
        public GetEmployeeResponseItemXPicturesType XPictures { get; set; }

        [JsonProperty("xPositionLookup")]
        public GetEmployeeResponseItemXPositionLookupType XPositionLookup { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }

        [JsonProperty("xSalary")]
        public GetEmployeeResponseItemXSalaryType XSalary { get; set; }

        [JsonProperty("xSeparationDate")]
        public string XSeparationDate { get; set; }

        [JsonProperty("xSeparationReason")]
        public string XSeparationReason { get; set; }

        [JsonProperty("xStartDate")]
        public string XStartDate { get; set; }

        [JsonProperty("xState")]
        public string XState { get; set; }

        [JsonProperty("xUpdatedOn")]
        public string XUpdatedOn { get; set; }

        [JsonProperty("xVeteranStatus")]
        public string XVeteranStatus { get; set; }

        [JsonProperty("xWorkPhone")]
        public string XWorkPhone { get; set; }

        [JsonProperty("xZipCode")]
        public string XZipCode { get; set; }
    }

    public class GetEmployeeResponseItemXBonusType
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
    }

    public class GetEmployeeResponseItemXDepartmentLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xDepartmentCode")]
        public string XDepartmentCode { get; set; }

        [JsonProperty("xDepartmentName")]
        public string XDepartmentName { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetEmployeeResponseItemXDivisionLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xDivisionCode")]
        public string XDivisionCode { get; set; }

        [JsonProperty("xDivisionName")]
        public string XDivisionName { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetEmployeeResponseItemXEmploymentStatusLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }

        [JsonProperty("xType")]
        public string XType { get; set; }
    }

    public class GetEmployeeResponseItemXEmploymentTypeLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }

        [JsonProperty("xType")]
        public string XType { get; set; }
    }

    public class GetEmployeeResponseItemXLocationLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xAddress")]
        public string XAddress { get; set; }

        [JsonProperty("xDescription")]
        public string XDescription { get; set; }

        [JsonProperty("xLocationCode")]
        public string XLocationCode { get; set; }

        [JsonProperty("xLocationName")]
        public string XLocationName { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetEmployeeResponseItemXManagerLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xFullName")]
        public string XFullName { get; set; }

        [JsonProperty("xEmail")]
        public string XEmail { get; set; }

        [JsonProperty("xPictures")]
        public GetEmployeeResponseItemXManagerLookupTypeXPicturesType XPictures { get; set; }
    }

    public class GetEmployeeResponseItemXManagerLookupTypeXPicturesType
    {
        public string OriginalPictureResourceCropParameters { get; set; }
        public string SmallResourceId { get; set; }
        public string OriginalResourceId { get; set; }
        public string MediumResourceId { get; set; }
    }

    public class GetEmployeeResponseItemXPayRateLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xName")]
        public string XName { get; set; }

        [JsonProperty("xCode")]
        public string XCode { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetEmployeeResponseItemXPicturesType
    {
        public string OriginalPictureResourceCropParameters { get; set; }
        public string SmallResourceId { get; set; }
        public string OriginalResourceId { get; set; }
        public string MediumResourceId { get; set; }
    }

    public class GetEmployeeResponseItemXPositionLookupType
    {
        public string Id { get; set; }

        [JsonProperty("xDescription")]
        public string XDescription { get; set; }

        [JsonProperty("xPositionCode")]
        public string XPositionCode { get; set; }

        [JsonProperty("xPositionTitle")]
        public string XPositionTitle { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetEmployeeResponseItemXSalaryType
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
    }

    public class AddEmployeeInput
    {
        [JsonProperty("xAddress1")]
        public string XAddress1 { get; set; }

        [JsonProperty("xCity")]
        public string XCity { get; set; }

        [JsonProperty("xEmail", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XEmail { get; set; }

        [JsonProperty("xFirstName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XFirstName { get; set; }

        [JsonProperty("xLastName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XLastName { get; set; }

        [JsonProperty("xPersonalEmail")]
        public string XPersonalEmail { get; set; }

        [JsonProperty("xRecordStatus", DefaultValueHandling = DefaultValueHandling.Include)]
        public string XRecordStatus { get; set; } = "Active";

        [JsonProperty("xStartDate")]
        public string XStartDate { get; set; }

        [JsonProperty("xState")]
        public string XState { get; set; }

        [JsonProperty("xZipCode")]
        public string XZipCode { get; set; }

        [JsonProperty("xEmployeeNumber")]
        public string XEmployeeNumber { get; set; }

        [JsonProperty("xEmploymentStatusLookup")]
        public string XEmploymentStatusLookup { get; set; }

        [JsonProperty("xLocationLookup")]
        public string XLocationLookup { get; set; }

        [JsonProperty("xPositionLookup")]
        public string XPositionLookup { get; set; }

        [JsonProperty("xDivisionLookup")]
        public string XDivisionLookup { get; set; }

        [JsonProperty("xDepartmentLookup")]
        public string XDepartmentLookup { get; set; }
    }

    public class UpdateEmployeeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("xAddress1")]
        public string XAddress1 { get; set; }

        [JsonProperty("xCity")]
        public string XCity { get; set; }

        [JsonProperty("xEmail")]
        public string XEmail { get; set; }

        [JsonProperty("xFirstName")]
        public string XFirstName { get; set; }

        [JsonProperty("xLastName")]
        public string XLastName { get; set; }

        [JsonProperty("xPersonalEmail")]
        public string XPersonalEmail { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }

        [JsonProperty("xStartDate")]
        public string XStartDate { get; set; }

        [JsonProperty("xState")]
        public string XState { get; set; }

        [JsonProperty("xZipCode")]
        public string XZipCode { get; set; }

        [JsonProperty("xEmployeeNumber")]
        public string XEmployeeNumber { get; set; }

        [JsonProperty("xEmploymentStatusLookup")]
        public string XEmploymentStatusLookup { get; set; }

        [JsonProperty("xLocationLookup")]
        public string XLocationLookup { get; set; }

        [JsonProperty("xPositionLookup")]
        public string XPositionLookup { get; set; }

        [JsonProperty("xDivisionLookup")]
        public string XDivisionLookup { get; set; }

        [JsonProperty("xDepartmentLookup")]
        public string XDepartmentLookup { get; set; }
    }

    public class GetDepartmentResponseItem
    {
        public string Id { get; set; }

        [JsonProperty("xDepartmentCode")]
        public string XDepartmentCode { get; set; }

        [JsonProperty("xDepartmentName")]
        public string XDepartmentName { get; set; }

        [JsonProperty("xOverheadDepartment")]
        public string XOverheadDepartment { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetLocationResponseItem
    {
        public string Id { get; set; }

        [JsonProperty("xAddress")]
        public string XAddress { get; set; }

        [JsonProperty("xDescription")]
        public string XDescription { get; set; }

        [JsonProperty("xLocationCode")]
        public string XLocationCode { get; set; }

        [JsonProperty("xLocationName")]
        public string XLocationName { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetPositionResponseItem
    {
        public string Id { get; set; }

        [JsonProperty("xDescription")]
        public string XDescription { get; set; }

        [JsonProperty("xPositionCode")]
        public string XPositionCode { get; set; }

        [JsonProperty("xPositionTitle")]
        public string XPositionTitle { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetDivisionResponseItem
    {
        public string Id { get; set; }

        [JsonProperty("xDivisionCode")]
        public string XDivisionCode { get; set; }

        [JsonProperty("xDivisionName")]
        public string XDivisionName { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }
    }

    public class GetEmploymentStatusResponseItem
    {
        public string Id { get; set; }

        [JsonProperty("xRecordStatus")]
        public string XRecordStatus { get; set; }

        [JsonProperty("xType")]
        public string XType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hrcloud;

    public partial class WorkflowManagedActions
    {
        public HrcloudActions Hrcloud(string connectionId) => new HrcloudActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HrcloudTriggers Hrcloud(string connectionId) => new HrcloudTriggers(connectionId);
    }
}