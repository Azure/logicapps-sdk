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
        public IBodyWorkflowAction<GetEmployeeResponseItem[]> GetEmployee(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetEmployeeResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xEmployeeNumber eq 'ENTER EMPLOYEE NUMBER HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetEmployeeResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IWorkflowAction AddEmployee(Expression<Func<string>> bodyxEmail, Expression<Func<string>> bodyxFirstName, Expression<Func<string>> bodyxLastName, Expression<Func<string>> bodyxAddress1 = null, Expression<Func<string>> bodyxCity = null, Expression<Func<string>> bodyxPersonalEmail = null, Expression<Func<string>> bodyxRecordStatus = null, Expression<Func<string>> bodyxStartDate = null, Expression<Func<string>> bodyxState = null, Expression<Func<string>> bodyxZipCode = null, Expression<Func<string>> bodyxEmployeeNumber = null, Expression<Func<string>> bodyxEmploymentStatusLookup = null, Expression<Func<string>> bodyxLocationLookup = null, Expression<Func<string>> bodyxPositionLookup = null, Expression<Func<string>> bodyxDivisionLookup = null, Expression<Func<string>> bodyxDepartmentLookup = null)
        {
            var __workflow_bodyxEmail = WorkflowExpression.Compile(bodyxEmail, nameof(bodyxEmail), required: true);
            var __workflow_bodyxFirstName = WorkflowExpression.Compile(bodyxFirstName, nameof(bodyxFirstName), required: true);
            var __workflow_bodyxLastName = WorkflowExpression.Compile(bodyxLastName, nameof(bodyxLastName), required: true);
            var __workflow_bodyxAddress1 = WorkflowExpression.Compile(bodyxAddress1, nameof(bodyxAddress1), required: false);
            var __workflow_bodyxCity = WorkflowExpression.Compile(bodyxCity, nameof(bodyxCity), required: false);
            var __workflow_bodyxPersonalEmail = WorkflowExpression.Compile(bodyxPersonalEmail, nameof(bodyxPersonalEmail), required: false);
            var __workflow_bodyxRecordStatus = WorkflowExpression.Compile(bodyxRecordStatus, nameof(bodyxRecordStatus), required: false);
            var __workflow_bodyxStartDate = WorkflowExpression.Compile(bodyxStartDate, nameof(bodyxStartDate), required: false);
            var __workflow_bodyxState = WorkflowExpression.Compile(bodyxState, nameof(bodyxState), required: false);
            var __workflow_bodyxZipCode = WorkflowExpression.Compile(bodyxZipCode, nameof(bodyxZipCode), required: false);
            var __workflow_bodyxEmployeeNumber = WorkflowExpression.Compile(bodyxEmployeeNumber, nameof(bodyxEmployeeNumber), required: false);
            var __workflow_bodyxEmploymentStatusLookup = WorkflowExpression.Compile(bodyxEmploymentStatusLookup, nameof(bodyxEmploymentStatusLookup), required: false);
            var __workflow_bodyxLocationLookup = WorkflowExpression.Compile(bodyxLocationLookup, nameof(bodyxLocationLookup), required: false);
            var __workflow_bodyxPositionLookup = WorkflowExpression.Compile(bodyxPositionLookup, nameof(bodyxPositionLookup), required: false);
            var __workflow_bodyxDivisionLookup = WorkflowExpression.Compile(bodyxDivisionLookup, nameof(bodyxDivisionLookup), required: false);
            var __workflow_bodyxDepartmentLookup = WorkflowExpression.Compile(bodyxDepartmentLookup, nameof(bodyxDepartmentLookup), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyxAddress1 != null)
                {
                    body["xAddress1"] = ExpressionConverter.ConvertO(__workflow_bodyxAddress1);
                    bodypropCount++;
                }

                if (__workflow_bodyxCity != null)
                {
                    body["xCity"] = ExpressionConverter.ConvertO(__workflow_bodyxCity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["xEmail"] = ExpressionConverter.ConvertO(__workflow_bodyxEmail);
                bodypropCount++;
                body["xFirstName"] = ExpressionConverter.ConvertO(__workflow_bodyxFirstName);
                bodypropCount++;
                body["xLastName"] = ExpressionConverter.ConvertO(__workflow_bodyxLastName);
                if (__workflow_bodyxPersonalEmail != null)
                {
                    body["xPersonalEmail"] = ExpressionConverter.ConvertO(__workflow_bodyxPersonalEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyxRecordStatus != null)
                {
                    if (__workflow_bodyxRecordStatus != null)
                    {
                        body["xRecordStatus"] = ExpressionConverter.ConvertO(__workflow_bodyxRecordStatus);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["xRecordStatus"] = "Active";
                    bodypropCount++;
                }

                if (__workflow_bodyxStartDate != null)
                {
                    body["xStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyxStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyxState != null)
                {
                    body["xState"] = ExpressionConverter.ConvertO(__workflow_bodyxState);
                    bodypropCount++;
                }

                if (__workflow_bodyxZipCode != null)
                {
                    body["xZipCode"] = ExpressionConverter.ConvertO(__workflow_bodyxZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodyxEmployeeNumber != null)
                {
                    body["xEmployeeNumber"] = ExpressionConverter.ConvertO(__workflow_bodyxEmployeeNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyxEmploymentStatusLookup != null)
                {
                    body["xEmploymentStatusLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxEmploymentStatusLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxLocationLookup != null)
                {
                    body["xLocationLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxLocationLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxPositionLookup != null)
                {
                    body["xPositionLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxPositionLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxDivisionLookup != null)
                {
                    body["xDivisionLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxDivisionLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxDepartmentLookup != null)
                {
                    body["xDepartmentLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxDepartmentLookup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IWorkflowAction UpdateEmployee(Expression<Func<string>> bodyid, Expression<Func<string>> bodyxAddress1 = null, Expression<Func<string>> bodyxCity = null, Expression<Func<string>> bodyxEmail = null, Expression<Func<string>> bodyxFirstName = null, Expression<Func<string>> bodyxLastName = null, Expression<Func<string>> bodyxPersonalEmail = null, Expression<Func<string>> bodyxRecordStatus = null, Expression<Func<string>> bodyxStartDate = null, Expression<Func<string>> bodyxState = null, Expression<Func<string>> bodyxZipCode = null, Expression<Func<string>> bodyxEmployeeNumber = null, Expression<Func<string>> bodyxEmploymentStatusLookup = null, Expression<Func<string>> bodyxLocationLookup = null, Expression<Func<string>> bodyxPositionLookup = null, Expression<Func<string>> bodyxDivisionLookup = null, Expression<Func<string>> bodyxDepartmentLookup = null)
        {
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyxAddress1 = WorkflowExpression.Compile(bodyxAddress1, nameof(bodyxAddress1), required: false);
            var __workflow_bodyxCity = WorkflowExpression.Compile(bodyxCity, nameof(bodyxCity), required: false);
            var __workflow_bodyxEmail = WorkflowExpression.Compile(bodyxEmail, nameof(bodyxEmail), required: false);
            var __workflow_bodyxFirstName = WorkflowExpression.Compile(bodyxFirstName, nameof(bodyxFirstName), required: false);
            var __workflow_bodyxLastName = WorkflowExpression.Compile(bodyxLastName, nameof(bodyxLastName), required: false);
            var __workflow_bodyxPersonalEmail = WorkflowExpression.Compile(bodyxPersonalEmail, nameof(bodyxPersonalEmail), required: false);
            var __workflow_bodyxRecordStatus = WorkflowExpression.Compile(bodyxRecordStatus, nameof(bodyxRecordStatus), required: false);
            var __workflow_bodyxStartDate = WorkflowExpression.Compile(bodyxStartDate, nameof(bodyxStartDate), required: false);
            var __workflow_bodyxState = WorkflowExpression.Compile(bodyxState, nameof(bodyxState), required: false);
            var __workflow_bodyxZipCode = WorkflowExpression.Compile(bodyxZipCode, nameof(bodyxZipCode), required: false);
            var __workflow_bodyxEmployeeNumber = WorkflowExpression.Compile(bodyxEmployeeNumber, nameof(bodyxEmployeeNumber), required: false);
            var __workflow_bodyxEmploymentStatusLookup = WorkflowExpression.Compile(bodyxEmploymentStatusLookup, nameof(bodyxEmploymentStatusLookup), required: false);
            var __workflow_bodyxLocationLookup = WorkflowExpression.Compile(bodyxLocationLookup, nameof(bodyxLocationLookup), required: false);
            var __workflow_bodyxPositionLookup = WorkflowExpression.Compile(bodyxPositionLookup, nameof(bodyxPositionLookup), required: false);
            var __workflow_bodyxDivisionLookup = WorkflowExpression.Compile(bodyxDivisionLookup, nameof(bodyxDivisionLookup), required: false);
            var __workflow_bodyxDepartmentLookup = WorkflowExpression.Compile(bodyxDepartmentLookup, nameof(bodyxDepartmentLookup), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                if (__workflow_bodyxAddress1 != null)
                {
                    body["xAddress1"] = ExpressionConverter.ConvertO(__workflow_bodyxAddress1);
                    bodypropCount++;
                }

                if (__workflow_bodyxCity != null)
                {
                    body["xCity"] = ExpressionConverter.ConvertO(__workflow_bodyxCity);
                    bodypropCount++;
                }

                if (__workflow_bodyxEmail != null)
                {
                    body["xEmail"] = ExpressionConverter.ConvertO(__workflow_bodyxEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyxFirstName != null)
                {
                    body["xFirstName"] = ExpressionConverter.ConvertO(__workflow_bodyxFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodyxLastName != null)
                {
                    body["xLastName"] = ExpressionConverter.ConvertO(__workflow_bodyxLastName);
                    bodypropCount++;
                }

                if (__workflow_bodyxPersonalEmail != null)
                {
                    body["xPersonalEmail"] = ExpressionConverter.ConvertO(__workflow_bodyxPersonalEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyxRecordStatus != null)
                {
                    body["xRecordStatus"] = ExpressionConverter.ConvertO(__workflow_bodyxRecordStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyxStartDate != null)
                {
                    body["xStartDate"] = ExpressionConverter.ConvertO(__workflow_bodyxStartDate);
                    bodypropCount++;
                }

                if (__workflow_bodyxState != null)
                {
                    body["xState"] = ExpressionConverter.ConvertO(__workflow_bodyxState);
                    bodypropCount++;
                }

                if (__workflow_bodyxZipCode != null)
                {
                    body["xZipCode"] = ExpressionConverter.ConvertO(__workflow_bodyxZipCode);
                    bodypropCount++;
                }

                if (__workflow_bodyxEmployeeNumber != null)
                {
                    body["xEmployeeNumber"] = ExpressionConverter.ConvertO(__workflow_bodyxEmployeeNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyxEmploymentStatusLookup != null)
                {
                    body["xEmploymentStatusLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxEmploymentStatusLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxLocationLookup != null)
                {
                    body["xLocationLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxLocationLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxPositionLookup != null)
                {
                    body["xPositionLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxPositionLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxDivisionLookup != null)
                {
                    body["xDivisionLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxDivisionLookup);
                    bodypropCount++;
                }

                if (__workflow_bodyxDepartmentLookup != null)
                {
                    body["xDepartmentLookup"] = ExpressionConverter.ConvertO(__workflow_bodyxDepartmentLookup);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetDepartmentResponseItem[]> GetDepartment(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetDepartmentResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xDepartment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xDepartmentName eq 'ENTER DEPARTMENT NAME HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetDepartmentResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetLocationResponseItem[]> GetLocation(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetLocationResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xLocation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xLocationName eq 'ENTER LOCATION NAME HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetLocationResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetPositionResponseItem[]> GetPosition(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetPositionResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xPosition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xPositionTitle eq 'ENTER POSITION TITLE HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetPositionResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetDivisionResponseItem[]> GetDivision(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetDivisionResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xDivision";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xDivisionName eq 'ENTER DIVISION NAME HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetDivisionResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetEmploymentStatusResponseItem[]> GetEmploymentStatus(Expression<Func<string>> filter = null)
        {
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetEmploymentStatusResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmploymentStatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xType eq 'ENTER EMPLOYMENT STATUS TYPE HERE'");
                if (__workflow_filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(__workflow_filter);
                return new ApiConnectionAction<GetEmploymentStatusResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
