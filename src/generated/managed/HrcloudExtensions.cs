//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hrcloud
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HrcloudActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetEmployeeResponseItem[]> GetEmployee(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/cloud/xEmployee";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("xEmployeeNumber eq 'ENTER EMPLOYEE NUMBER HERE'");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetEmployeeResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IWorkflowAction AddEmployee(Expression<Func<string>> bodyxEmail, Expression<Func<string>> bodyxFirstName, Expression<Func<string>> bodyxLastName, Expression<Func<string>> bodyxAddress1 = null, Expression<Func<string>> bodyxCity = null, Expression<Func<string>> bodyxPersonalEmail = null, Expression<Func<string>> bodyxRecordStatus = null, Expression<Func<string>> bodyxStartDate = null, Expression<Func<string>> bodyxState = null, Expression<Func<string>> bodyxZipCode = null, Expression<Func<string>> bodyxEmployeeNumber = null, Expression<Func<string>> bodyxEmploymentStatusLookup = null, Expression<Func<string>> bodyxLocationLookup = null, Expression<Func<string>> bodyxPositionLookup = null, Expression<Func<string>> bodyxDivisionLookup = null, Expression<Func<string>> bodyxDepartmentLookup = null)
        {
            var apiCallPath = "/v1/cloud/xEmployee";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyxAddress1 != null)
            {
                body["xAddress1"] = ExpressionConverter.ConvertO(bodyxAddress1);
                bodypropCount++;
            }

            if (bodyxCity != null)
            {
                body["xCity"] = ExpressionConverter.ConvertO(bodyxCity);
                bodypropCount++;
            }

            bodypropCount++;
            body["xEmail"] = ExpressionConverter.ConvertO(bodyxEmail);
            bodypropCount++;
            body["xFirstName"] = ExpressionConverter.ConvertO(bodyxFirstName);
            bodypropCount++;
            body["xLastName"] = ExpressionConverter.ConvertO(bodyxLastName);
            if (bodyxPersonalEmail != null)
            {
                body["xPersonalEmail"] = ExpressionConverter.ConvertO(bodyxPersonalEmail);
                bodypropCount++;
            }

            if (bodyxRecordStatus != null)
            {
                body["xRecordStatus"] = ExpressionConverter.ConvertO(bodyxRecordStatus);
                bodypropCount++;
            }

            if (bodyxStartDate != null)
            {
                body["xStartDate"] = ExpressionConverter.ConvertO(bodyxStartDate);
                bodypropCount++;
            }

            if (bodyxState != null)
            {
                body["xState"] = ExpressionConverter.ConvertO(bodyxState);
                bodypropCount++;
            }

            if (bodyxZipCode != null)
            {
                body["xZipCode"] = ExpressionConverter.ConvertO(bodyxZipCode);
                bodypropCount++;
            }

            if (bodyxEmployeeNumber != null)
            {
                body["xEmployeeNumber"] = ExpressionConverter.ConvertO(bodyxEmployeeNumber);
                bodypropCount++;
            }

            if (bodyxEmploymentStatusLookup != null)
            {
                body["xEmploymentStatusLookup"] = ExpressionConverter.ConvertO(bodyxEmploymentStatusLookup);
                bodypropCount++;
            }

            if (bodyxLocationLookup != null)
            {
                body["xLocationLookup"] = ExpressionConverter.ConvertO(bodyxLocationLookup);
                bodypropCount++;
            }

            if (bodyxPositionLookup != null)
            {
                body["xPositionLookup"] = ExpressionConverter.ConvertO(bodyxPositionLookup);
                bodypropCount++;
            }

            if (bodyxDivisionLookup != null)
            {
                body["xDivisionLookup"] = ExpressionConverter.ConvertO(bodyxDivisionLookup);
                bodypropCount++;
            }

            if (bodyxDepartmentLookup != null)
            {
                body["xDepartmentLookup"] = ExpressionConverter.ConvertO(bodyxDepartmentLookup);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IWorkflowAction UpdateEmployee(Expression<Func<string>> bodyId, Expression<Func<string>> bodyxAddress1 = null, Expression<Func<string>> bodyxCity = null, Expression<Func<string>> bodyxEmail = null, Expression<Func<string>> bodyxFirstName = null, Expression<Func<string>> bodyxLastName = null, Expression<Func<string>> bodyxPersonalEmail = null, Expression<Func<string>> bodyxRecordStatus = null, Expression<Func<string>> bodyxStartDate = null, Expression<Func<string>> bodyxState = null, Expression<Func<string>> bodyxZipCode = null, Expression<Func<string>> bodyxEmployeeNumber = null, Expression<Func<string>> bodyxEmploymentStatusLookup = null, Expression<Func<string>> bodyxLocationLookup = null, Expression<Func<string>> bodyxPositionLookup = null, Expression<Func<string>> bodyxDivisionLookup = null, Expression<Func<string>> bodyxDepartmentLookup = null)
        {
            var apiCallPath = "/v1/cloud/xEmployee";
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Id"] = ExpressionConverter.ConvertO(bodyId);
            if (bodyxAddress1 != null)
            {
                body["xAddress1"] = ExpressionConverter.ConvertO(bodyxAddress1);
                bodypropCount++;
            }

            if (bodyxCity != null)
            {
                body["xCity"] = ExpressionConverter.ConvertO(bodyxCity);
                bodypropCount++;
            }

            if (bodyxEmail != null)
            {
                body["xEmail"] = ExpressionConverter.ConvertO(bodyxEmail);
                bodypropCount++;
            }

            if (bodyxFirstName != null)
            {
                body["xFirstName"] = ExpressionConverter.ConvertO(bodyxFirstName);
                bodypropCount++;
            }

            if (bodyxLastName != null)
            {
                body["xLastName"] = ExpressionConverter.ConvertO(bodyxLastName);
                bodypropCount++;
            }

            if (bodyxPersonalEmail != null)
            {
                body["xPersonalEmail"] = ExpressionConverter.ConvertO(bodyxPersonalEmail);
                bodypropCount++;
            }

            if (bodyxRecordStatus != null)
            {
                body["xRecordStatus"] = ExpressionConverter.ConvertO(bodyxRecordStatus);
                bodypropCount++;
            }

            if (bodyxStartDate != null)
            {
                body["xStartDate"] = ExpressionConverter.ConvertO(bodyxStartDate);
                bodypropCount++;
            }

            if (bodyxState != null)
            {
                body["xState"] = ExpressionConverter.ConvertO(bodyxState);
                bodypropCount++;
            }

            if (bodyxZipCode != null)
            {
                body["xZipCode"] = ExpressionConverter.ConvertO(bodyxZipCode);
                bodypropCount++;
            }

            if (bodyxEmployeeNumber != null)
            {
                body["xEmployeeNumber"] = ExpressionConverter.ConvertO(bodyxEmployeeNumber);
                bodypropCount++;
            }

            if (bodyxEmploymentStatusLookup != null)
            {
                body["xEmploymentStatusLookup"] = ExpressionConverter.ConvertO(bodyxEmploymentStatusLookup);
                bodypropCount++;
            }

            if (bodyxLocationLookup != null)
            {
                body["xLocationLookup"] = ExpressionConverter.ConvertO(bodyxLocationLookup);
                bodypropCount++;
            }

            if (bodyxPositionLookup != null)
            {
                body["xPositionLookup"] = ExpressionConverter.ConvertO(bodyxPositionLookup);
                bodypropCount++;
            }

            if (bodyxDivisionLookup != null)
            {
                body["xDivisionLookup"] = ExpressionConverter.ConvertO(bodyxDivisionLookup);
                bodypropCount++;
            }

            if (bodyxDepartmentLookup != null)
            {
                body["xDepartmentLookup"] = ExpressionConverter.ConvertO(bodyxDepartmentLookup);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetDepartmentResponseItem[]> GetDepartment(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/cloud/xDepartment";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("xDepartmentName eq 'ENTER DEPARTMENT NAME HERE'");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetDepartmentResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetLocationResponseItem[]> GetLocation(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/cloud/xLocation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("xLocationName eq 'ENTER LOCATION NAME HERE'");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetLocationResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetPositionResponseItem[]> GetPosition(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/cloud/xPosition";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("xPositionTitle eq 'ENTER POSITION TITLE HERE'");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetPositionResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetDivisionResponseItem[]> GetDivision(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/cloud/xDivision";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("xDivisionName eq 'ENTER DIVISION NAME HERE'");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetDivisionResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        public IBodyWorkflowAction<GetEmploymentStatusResponseItem[]> GetEmploymentStatus(Expression<Func<string>> filter = null)
        {
            var apiCallPath = "/v1/cloud/xEmploymentStatus";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filter"] = Convert.ToString("xType eq 'ENTER EMPLOYMENT STATUS TYPE HERE'");
            if (filter != null)
                callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
            return new ApiConnectionAction<GetEmploymentStatusResponseItem[]>(callPayload);
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