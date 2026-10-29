//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Allgeo
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AllgeoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<LoginResponse, ApiConnectionActionConfiguration> Login(Expression<Func<string>> contentType, Expression<Func<string>> body)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LoginResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/track/api/v1/login";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoginResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<CreateWorkOrdersResponse, ApiConnectionActionConfiguration> CreateWorkOrders(Expression<Func<string>> token, Expression<Func<bodyInputItem[]>> body)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateWorkOrdersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/track/api/v1/schedule";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateWorkOrdersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<CreateJobSiteResponse, ApiConnectionActionConfiguration> CreateJobSite(Expression<Func<string>> token, Expression<Func<bodyInputItem2[]>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateJobSiteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/track/api/v1/createSites";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateJobSiteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<CreateTimeClockResponse, ApiConnectionActionConfiguration> CreateTimeClock(Expression<Func<string>> token, Expression<Func<bodyInputItem22[]>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateTimeClockResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/track/api/v1/createTimeClock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateTimeClockResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<UpdateTimeClockResponse, ApiConnectionActionConfiguration> UpdateTimeClock(Expression<Func<string>> token, Expression<Func<bodyInputItem222[]>> body = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateTimeClockResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/track/api/v1/updateTimeClock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateTimeClockResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<DeleteJobSiteResponse, ApiConnectionActionConfiguration> DeleteJobSite(Expression<Func<string>> name, Expression<Func<string>> token)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            return new DeferredBodyAction<DeleteJobSiteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/track/api/v1/deleteSite/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                return new ApiConnectionAction<DeleteJobSiteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<GetBreadcrumbsReportResponse, ApiConnectionActionConfiguration> GetBreadcrumbsReport(Expression<Func<string>> token, Expression<Func<string>> account = null, Expression<Func<string>> group = null, Expression<Func<string>> reportName = null, Expression<Func<string>> reportRange = null, Expression<Func<string>> reportFormat = null)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: false);
            var __workflow_group = WorkflowExpression.Compile(group, nameof(group), required: false);
            var __workflow_reportName = WorkflowExpression.Compile(reportName, nameof(reportName), required: false);
            var __workflow_reportRange = WorkflowExpression.Compile(reportRange, nameof(reportRange), required: false);
            var __workflow_reportFormat = WorkflowExpression.Compile(reportFormat, nameof(reportFormat), required: false);
            return new DeferredBodyAction<GetBreadcrumbsReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/track/api/v1/jsonreports";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["token"] = ExpressionConverter.Convert(__workflow_token);
                if (__workflow_account != null)
                    callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                if (__workflow_group != null)
                    callPayload.Queries["group"] = ExpressionConverter.Convert(__workflow_group);
                if (__workflow_reportName != null)
                    callPayload.Queries["reportName"] = ExpressionConverter.Convert(__workflow_reportName);
                if (__workflow_reportRange != null)
                    callPayload.Queries["reportRange"] = ExpressionConverter.Convert(__workflow_reportRange);
                if (__workflow_reportFormat != null)
                    callPayload.Queries["reportFormat"] = ExpressionConverter.Convert(__workflow_reportFormat);
                return new ApiConnectionAction<GetBreadcrumbsReportResponse>(callPayload);
            });
        }
    }

    public class AllgeoTriggers([ConnectionName] string connectionId)
    {
    }

    public class LoginResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class CreateWorkOrdersResponse
    {
        public string Status { get; set; }
        public string SucessMsg { get; set; }
        public int StatusCode { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("workOrderNumber")]
        public string WorkOrderNumber { get; set; }

        [JsonProperty("workOrderType")]
        public string WorkOrderType { get; set; }

        [JsonProperty("deviceDesc")]
        public string DeviceDesc { get; set; }

        [JsonProperty("groupID")]
        public string GroupId { get; set; }

        [JsonProperty("deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty("locatable")]
        public string Locatable { get; set; }

        [JsonProperty("legNumber")]
        public string LegNumber { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("taskName")]
        public string TaskName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("formName")]
        public string FormName { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("createEmployee")]
        public string CreateEmployee { get; set; }

        [JsonProperty("prefillData")]
        public bodyInputItemPrefillDataTypeItem[] PrefillData { get; set; }
    }

    public class bodyInputItemPrefillDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateJobSiteResponse
    {
        public string Status { get; set; }
        public string SucessMsg { get; set; }
        public int StatusCode { get; set; }
    }

    public class bodyInputItem2
    {
        [JsonProperty("siteID")]
        public string SiteId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("radius")]
        public string Radius { get; set; }

        [JsonProperty("groupID")]
        public string GroupId { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }
    }

    public class CreateTimeClockResponse
    {
        public string Status { get; set; }
        public string SucessMsg { get; set; }
        public int StatusCode { get; set; }
    }

    public class bodyInputItem22
    {
        [JsonProperty("deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty("timeClockSentTime")]
        public string TimeClockSentTime { get; set; }

        [JsonProperty("stageName")]
        public string StageName { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("jobName")]
        public string JobName { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class UpdateTimeClockResponse
    {
        public string Status { get; set; }
        public string SucessMsg { get; set; }
        public int StatusCode { get; set; }
    }

    public class bodyInputItem222
    {
        [JsonProperty("txnID")]
        public string TxnId { get; set; }

        [JsonProperty("deviceID")]
        public string DeviceId { get; set; }

        [JsonProperty("timeClockSentTime")]
        public string TimeClockSentTime { get; set; }

        [JsonProperty("customerName")]
        public string CustomerName { get; set; }

        [JsonProperty("jobName")]
        public string JobName { get; set; }

        [JsonProperty("managerNotes")]
        public string ManagerNotes { get; set; }

        [JsonProperty("stageName")]
        public string StageName { get; set; }
    }

    public class DeleteJobSiteResponse
    {
        public string Status { get; set; }
        public string SucessMsg { get; set; }
        public int StatusCode { get; set; }
    }

    public class GetBreadcrumbsReportResponse
    {
        public string ReportName { get; set; }

        [JsonProperty("reportData")]
        public GetBreadcrumbsReportResponseReportDataTypeItem[] ReportData { get; set; }

        [JsonProperty("reportRange")]
        public string ReportRange { get; set; }
    }

    public class GetBreadcrumbsReportResponseReportDataTypeItem
    {
        public string DeviceName { get; set; }

        [JsonProperty("Trip #")]
        public string Trip { get; set; }

        [JsonProperty("Battery Level ")]
        public string BatteryLevel { get; set; }

        [JsonProperty("Site Status")]
        public string SiteStatus { get; set; }
        public string Time { get; set; }

        [JsonProperty("Lat/Long")]
        public string LatLong { get; set; }
        public string DeviceId { get; set; }
        public string Address { get; set; }
        public string Date { get; set; }

        [JsonProperty("Event Type ")]
        public string EventType { get; set; }

        [JsonProperty("Device Method")]
        public string DeviceMethod { get; set; }
        public string Accuracy { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Allgeo;

    public partial class WorkflowManagedActions
    {
        public AllgeoActions Allgeo(string connectionId) => new AllgeoActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AllgeoTriggers Allgeo(string connectionId) => new AllgeoTriggers(connectionId);
    }
}