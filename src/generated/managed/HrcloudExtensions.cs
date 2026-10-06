//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hrcloud
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HrcloudActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmployee))]
        public IBodyWorkflowAction<GetEmployeeResponseItem[]> GetEmployee([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEmployeeResponseItem[]> __BuildGetEmployee(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetEmployeeResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xEmployeeNumber eq 'ENTER EMPLOYEE NUMBER HERE'");
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetEmployeeResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildAddEmployee))]
        public IWorkflowAction AddEmployee([WorkflowExpression] Func<string> bodyxEmail, [WorkflowExpression] Func<string> bodyxFirstName, [WorkflowExpression] Func<string> bodyxLastName, [WorkflowExpression] Func<string> bodyxAddress1 = null, [WorkflowExpression] Func<string> bodyxCity = null, [WorkflowExpression] Func<string> bodyxPersonalEmail = null, [WorkflowExpression] Func<string> bodyxRecordStatus = null, [WorkflowExpression] Func<string> bodyxStartDate = null, [WorkflowExpression] Func<string> bodyxState = null, [WorkflowExpression] Func<string> bodyxZipCode = null, [WorkflowExpression] Func<string> bodyxEmployeeNumber = null, [WorkflowExpression] Func<string> bodyxEmploymentStatusLookup = null, [WorkflowExpression] Func<string> bodyxLocationLookup = null, [WorkflowExpression] Func<string> bodyxPositionLookup = null, [WorkflowExpression] Func<string> bodyxDivisionLookup = null, [WorkflowExpression] Func<string> bodyxDepartmentLookup = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddEmployee(WorkflowExpression<string> bodyxEmail, WorkflowExpression<string> bodyxFirstName, WorkflowExpression<string> bodyxLastName, WorkflowExpression<string> bodyxAddress1 = null, WorkflowExpression<string> bodyxCity = null, WorkflowExpression<string> bodyxPersonalEmail = null, WorkflowExpression<string> bodyxRecordStatus = null, WorkflowExpression<string> bodyxStartDate = null, WorkflowExpression<string> bodyxState = null, WorkflowExpression<string> bodyxZipCode = null, WorkflowExpression<string> bodyxEmployeeNumber = null, WorkflowExpression<string> bodyxEmploymentStatusLookup = null, WorkflowExpression<string> bodyxLocationLookup = null, WorkflowExpression<string> bodyxPositionLookup = null, WorkflowExpression<string> bodyxDivisionLookup = null, WorkflowExpression<string> bodyxDepartmentLookup = null)
        {
            WorkflowExpression.Validate(bodyxEmail, nameof(bodyxEmail), required: true);
            WorkflowExpression.Validate(bodyxFirstName, nameof(bodyxFirstName), required: true);
            WorkflowExpression.Validate(bodyxLastName, nameof(bodyxLastName), required: true);
            WorkflowExpression.Validate(bodyxAddress1, nameof(bodyxAddress1), required: false);
            WorkflowExpression.Validate(bodyxCity, nameof(bodyxCity), required: false);
            WorkflowExpression.Validate(bodyxPersonalEmail, nameof(bodyxPersonalEmail), required: false);
            WorkflowExpression.Validate(bodyxRecordStatus, nameof(bodyxRecordStatus), required: false);
            WorkflowExpression.Validate(bodyxStartDate, nameof(bodyxStartDate), required: false);
            WorkflowExpression.Validate(bodyxState, nameof(bodyxState), required: false);
            WorkflowExpression.Validate(bodyxZipCode, nameof(bodyxZipCode), required: false);
            WorkflowExpression.Validate(bodyxEmployeeNumber, nameof(bodyxEmployeeNumber), required: false);
            WorkflowExpression.Validate(bodyxEmploymentStatusLookup, nameof(bodyxEmploymentStatusLookup), required: false);
            WorkflowExpression.Validate(bodyxLocationLookup, nameof(bodyxLocationLookup), required: false);
            WorkflowExpression.Validate(bodyxPositionLookup, nameof(bodyxPositionLookup), required: false);
            WorkflowExpression.Validate(bodyxDivisionLookup, nameof(bodyxDivisionLookup), required: false);
            WorkflowExpression.Validate(bodyxDepartmentLookup, nameof(bodyxDepartmentLookup), required: false);
            return new DeferredWorkflowAction(() =>
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
                    if (bodyxRecordStatus != null)
                    {
                        body["xRecordStatus"] = ExpressionConverter.ConvertO(bodyxRecordStatus);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["xRecordStatus"] = "Active";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateEmployee))]
        public IWorkflowAction UpdateEmployee([WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<string> bodyxAddress1 = null, [WorkflowExpression] Func<string> bodyxCity = null, [WorkflowExpression] Func<string> bodyxEmail = null, [WorkflowExpression] Func<string> bodyxFirstName = null, [WorkflowExpression] Func<string> bodyxLastName = null, [WorkflowExpression] Func<string> bodyxPersonalEmail = null, [WorkflowExpression] Func<string> bodyxRecordStatus = null, [WorkflowExpression] Func<string> bodyxStartDate = null, [WorkflowExpression] Func<string> bodyxState = null, [WorkflowExpression] Func<string> bodyxZipCode = null, [WorkflowExpression] Func<string> bodyxEmployeeNumber = null, [WorkflowExpression] Func<string> bodyxEmploymentStatusLookup = null, [WorkflowExpression] Func<string> bodyxLocationLookup = null, [WorkflowExpression] Func<string> bodyxPositionLookup = null, [WorkflowExpression] Func<string> bodyxDivisionLookup = null, [WorkflowExpression] Func<string> bodyxDepartmentLookup = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateEmployee(WorkflowExpression<string> bodyid, WorkflowExpression<string> bodyxAddress1 = null, WorkflowExpression<string> bodyxCity = null, WorkflowExpression<string> bodyxEmail = null, WorkflowExpression<string> bodyxFirstName = null, WorkflowExpression<string> bodyxLastName = null, WorkflowExpression<string> bodyxPersonalEmail = null, WorkflowExpression<string> bodyxRecordStatus = null, WorkflowExpression<string> bodyxStartDate = null, WorkflowExpression<string> bodyxState = null, WorkflowExpression<string> bodyxZipCode = null, WorkflowExpression<string> bodyxEmployeeNumber = null, WorkflowExpression<string> bodyxEmploymentStatusLookup = null, WorkflowExpression<string> bodyxLocationLookup = null, WorkflowExpression<string> bodyxPositionLookup = null, WorkflowExpression<string> bodyxDivisionLookup = null, WorkflowExpression<string> bodyxDepartmentLookup = null)
        {
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyxAddress1, nameof(bodyxAddress1), required: false);
            WorkflowExpression.Validate(bodyxCity, nameof(bodyxCity), required: false);
            WorkflowExpression.Validate(bodyxEmail, nameof(bodyxEmail), required: false);
            WorkflowExpression.Validate(bodyxFirstName, nameof(bodyxFirstName), required: false);
            WorkflowExpression.Validate(bodyxLastName, nameof(bodyxLastName), required: false);
            WorkflowExpression.Validate(bodyxPersonalEmail, nameof(bodyxPersonalEmail), required: false);
            WorkflowExpression.Validate(bodyxRecordStatus, nameof(bodyxRecordStatus), required: false);
            WorkflowExpression.Validate(bodyxStartDate, nameof(bodyxStartDate), required: false);
            WorkflowExpression.Validate(bodyxState, nameof(bodyxState), required: false);
            WorkflowExpression.Validate(bodyxZipCode, nameof(bodyxZipCode), required: false);
            WorkflowExpression.Validate(bodyxEmployeeNumber, nameof(bodyxEmployeeNumber), required: false);
            WorkflowExpression.Validate(bodyxEmploymentStatusLookup, nameof(bodyxEmploymentStatusLookup), required: false);
            WorkflowExpression.Validate(bodyxLocationLookup, nameof(bodyxLocationLookup), required: false);
            WorkflowExpression.Validate(bodyxPositionLookup, nameof(bodyxPositionLookup), required: false);
            WorkflowExpression.Validate(bodyxDivisionLookup, nameof(bodyxDivisionLookup), required: false);
            WorkflowExpression.Validate(bodyxDepartmentLookup, nameof(bodyxDepartmentLookup), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v1/cloud/xEmployee";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Id"] = ExpressionConverter.ConvertO(bodyid);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetDepartment))]
        public IBodyWorkflowAction<GetDepartmentResponseItem[]> GetDepartment([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDepartmentResponseItem[]> __BuildGetDepartment(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetDepartmentResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xDepartment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xDepartmentName eq 'ENTER DEPARTMENT NAME HERE'");
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetDepartmentResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocation))]
        public IBodyWorkflowAction<GetLocationResponseItem[]> GetLocation([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLocationResponseItem[]> __BuildGetLocation(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetLocationResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xLocation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xLocationName eq 'ENTER LOCATION NAME HERE'");
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetLocationResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetPosition))]
        public IBodyWorkflowAction<GetPositionResponseItem[]> GetPosition([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPositionResponseItem[]> __BuildGetPosition(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetPositionResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xPosition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xPositionTitle eq 'ENTER POSITION TITLE HERE'");
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetPositionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetDivision))]
        public IBodyWorkflowAction<GetDivisionResponseItem[]> GetDivision([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDivisionResponseItem[]> __BuildGetDivision(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetDivisionResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xDivision";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xDivisionName eq 'ENTER DIVISION NAME HERE'");
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
                return new ApiConnectionAction<GetDivisionResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [WorkflowExpressionFactory(nameof(__BuildGetEmploymentStatus))]
        public IBodyWorkflowAction<GetEmploymentStatusResponseItem[]> GetEmploymentStatus([WorkflowExpression] Func<string> filter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hrcloud")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEmploymentStatusResponseItem[]> __BuildGetEmploymentStatus(WorkflowExpression<string> filter = null)
        {
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            return new DeferredBodyAction<GetEmploymentStatusResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/cloud/xEmploymentStatus";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filter"] = Convert.ToString("xType eq 'ENTER EMPLOYMENT STATUS TYPE HERE'");
                if (filter != null)
                    callPayload.Queries["filter"] = ExpressionConverter.Convert(filter);
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