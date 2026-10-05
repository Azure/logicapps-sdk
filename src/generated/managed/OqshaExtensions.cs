//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Oqsha
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OqshaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oqsha")]
        [WorkflowExpressionFactory(nameof(__BuildCreateIncident))]
        public IBodyWorkflowAction<CreateIncidentResponse> CreateIncident([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accessToken = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodylocationId = null, [WorkflowExpression] Func<double> bodylatitude = null, [WorkflowExpression] Func<double> bodylongitude = null, [WorkflowExpression] Func<string> bodydivisionId = null, [WorkflowExpression] Func<string> bodyuserId = null, [WorkflowExpression] Func<bool> bodyanonymouslyReported = null, [WorkflowExpression] Func<bodycheckListDataInputItem[]> bodycheckListData = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateIncidentResponse> __BuildCreateIncident(WorkflowValue<string> contentType = null, WorkflowValue<string> accessToken = null, WorkflowValue<string> bodylocation = null, WorkflowValue<string> bodylocationId = null, WorkflowValue<double> bodylatitude = null, WorkflowValue<double> bodylongitude = null, WorkflowValue<string> bodydivisionId = null, WorkflowValue<string> bodyuserId = null, WorkflowValue<bool> bodyanonymouslyReported = null, WorkflowValue<bodycheckListDataInputItem[]> bodycheckListData = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(accessToken, nameof(accessToken), required: false);
            WorkflowValue.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowValue.Validate(bodylocationId, nameof(bodylocationId), required: false);
            WorkflowValue.Validate(bodylatitude, nameof(bodylatitude), required: false);
            WorkflowValue.Validate(bodylongitude, nameof(bodylongitude), required: false);
            WorkflowValue.Validate(bodydivisionId, nameof(bodydivisionId), required: false);
            WorkflowValue.Validate(bodyuserId, nameof(bodyuserId), required: false);
            WorkflowValue.Validate(bodyanonymouslyReported, nameof(bodyanonymouslyReported), required: false);
            WorkflowValue.Validate(bodycheckListData, nameof(bodycheckListData), required: false);
            return new DeferredBodyAction<CreateIncidentResponse>(() =>
            {
                var apiCallPath = "/Organisations/3/Incidents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                if (accessToken != null)
                    callPayload.Headers["Access-Token"] = ExpressionConverter.Convert(accessToken);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylocation != null)
                {
                    body["Location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodylocationId != null)
                {
                    body["LocationId"] = ExpressionConverter.ConvertO(bodylocationId);
                    bodypropCount++;
                }

                if (bodylatitude != null)
                {
                    body["Latitude"] = ExpressionConverter.ConvertO(bodylatitude);
                    bodypropCount++;
                }

                if (bodylongitude != null)
                {
                    body["Longitude"] = ExpressionConverter.ConvertO(bodylongitude);
                    bodypropCount++;
                }

                if (bodydivisionId != null)
                {
                    body["DivisionId"] = ExpressionConverter.ConvertO(bodydivisionId);
                    bodypropCount++;
                }

                if (bodyuserId != null)
                {
                    body["UserId"] = ExpressionConverter.ConvertO(bodyuserId);
                    bodypropCount++;
                }

                if (bodyanonymouslyReported != null)
                {
                    body["AnonymouslyReported"] = ExpressionConverter.ConvertO(bodyanonymouslyReported);
                    bodypropCount++;
                }

                if (bodycheckListData != null)
                {
                    body["CheckListData"] = ExpressionConverter.ConvertO(bodycheckListData);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateIncidentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "oqsha")]
        [WorkflowExpressionFactory(nameof(__BuildLogin))]
        public IBodyWorkflowAction<LoginResponse> Login([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodyuserUid = null, [WorkflowExpression] Func<string> bodyappPassword = null, [WorkflowExpression] Func<bool> bodyacceptConditions = null, [WorkflowExpression] Func<bool> bodyisOqsha = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<LoginResponse> __BuildLogin(WorkflowValue<string> contentType = null, WorkflowValue<string> bodyuserUid = null, WorkflowValue<string> bodyappPassword = null, WorkflowValue<bool> bodyacceptConditions = null, WorkflowValue<bool> bodyisOqsha = null)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(bodyuserUid, nameof(bodyuserUid), required: false);
            WorkflowValue.Validate(bodyappPassword, nameof(bodyappPassword), required: false);
            WorkflowValue.Validate(bodyacceptConditions, nameof(bodyacceptConditions), required: false);
            WorkflowValue.Validate(bodyisOqsha, nameof(bodyisOqsha), required: false);
            return new DeferredBodyAction<LoginResponse>(() =>
            {
                var apiCallPath = "/App/Login";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserUid != null)
                {
                    body["UserUid"] = ExpressionConverter.ConvertO(bodyuserUid);
                    bodypropCount++;
                }

                if (bodyappPassword != null)
                {
                    body["AppPassword"] = ExpressionConverter.ConvertO(bodyappPassword);
                    bodypropCount++;
                }

                if (bodyacceptConditions != null)
                {
                    body["acceptConditions"] = ExpressionConverter.ConvertO(bodyacceptConditions);
                    bodypropCount++;
                }

                if (bodyisOqsha != null)
                {
                    body["IsOqsha"] = ExpressionConverter.ConvertO(bodyisOqsha);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<LoginResponse>(callPayload);
            });
        }
    }

    public class OqshaTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateIncidentResponse
    {
        public string Status { get; set; }
        public CreateIncidentResponseDataType Data { get; set; }
    }

    public class CreateIncidentResponseDataType
    {
        public CreateIncidentResponseDataTypeIncidentType Incident { get; set; }
    }

    public class CreateIncidentResponseDataTypeIncidentType
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ImageCount { get; set; }
        public int VideoCount { get; set; }
        public int AudioCount { get; set; }
        public int FileCount { get; set; }
        public string Location { get; set; }
        public int OrganisationId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string IncidentUid { get; set; }
        public string IncidentDescription { get; set; }
        public int DivisionId { get; set; }
        public bool AnonymouslyReported { get; set; }
        public int OwnerId { get; set; }
        public int LocationId { get; set; }
        public string IncidentCreatedOn { get; set; }
        public string Status { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }
        public bool CanEscalated { get; set; }
        public int EscalateCronType { get; set; }
        public string IncidentStatus { get; set; }
        public int CheckListId { get; set; }
        public bool ResolveSimilarIncidents { get; set; }
        public int CronId { get; set; }
        public int RetryCount { get; set; }
        public int CronStatus { get; set; }
        public int OrgOwnerId { get; set; }
    }

    public class bodycheckListDataInputItem
    {
        [JsonProperty("checkListId")]
        public string CheckListId { get; set; }
        public string Answer { get; set; }
    }

    public class LoginResponse
    {
        public string Status { get; set; }
        public LoginResponseDataType Data { get; set; }
    }

    public class LoginResponseDataType
    {
        public LoginResponseDataTypeLoginType Login { get; set; }
        public LoginResponseDataTypePackageType Package { get; set; }
    }

    public class LoginResponseDataTypeLoginType
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public string DisplayName { get; set; }
        public int OrganisationId { get; set; }
        public bool IsFieldStaff { get; set; }
        public bool IsOwner { get; set; }
        public LoginResponseDataTypeLoginTypeIncidentSitesTypeItem[] IncidentSites { get; set; }
        public bool ShowAllIncidents { get; set; }
    }

    public class LoginResponseDataTypeLoginTypeIncidentSitesTypeItem
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public string LocationAddress { get; set; }
        public string LocationName { get; set; }
        public int OrganisationId { get; set; }
        public double Longitude { get; set; }
        public int ZoomLevel { get; set; }
        public int AllowSiteAllUsers { get; set; }
    }

    public class LoginResponseDataTypePackageType
    {
        public int Id { get; set; }
        public string PackageName { get; set; }
        public double PricePerMonthUSD { get; set; }
        public double PricePerMonthINR { get; set; }
        public bool IsExpired { get; set; }
        public LoginResponseDataTypePackageTypeFeaturesTypeItem[] Features { get; set; }
        public int HighestPackageId { get; set; }
    }

    public class LoginResponseDataTypePackageTypeFeaturesTypeItem
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public string FeatureName { get; set; }
        public string FeatureThreshold { get; set; }
        public bool Enabled { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Oqsha;

    public partial class WorkflowManagedActions
    {
        public OqshaActions Oqsha(string connectionId) => new OqshaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OqshaTriggers Oqsha(string connectionId) => new OqshaTriggers(connectionId);
    }
}
