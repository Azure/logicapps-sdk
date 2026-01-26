//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Allgeo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AllgeoActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<LoginResponse> Login(Expression<Func<string>> contentType, Expression<Func<string>> body = null)
        {
            var apiCallPath = "/track/api/v1/login";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<LoginResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<DeleteJobSiteResponse> DeleteJobSite(Expression<Func<string>> name, Expression<Func<string>> token)
        {
            var apiCallPath = String.Format("/track/api/v1/deleteSite/{0}", ExpressionConverter.ConvertWithUrlEncoding(name, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = ExpressionConverter.Convert(token);
            return new ApiConnectionAction<DeleteJobSiteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "allgeo")]
        public IBodyWorkflowAction<GetBreadcrumbsReportResponse> GetBreadcrumbsReport(Expression<Func<string>> token, Expression<Func<string>> account = null, Expression<Func<string>> group = null, Expression<Func<string>> reportName = null, Expression<Func<string>> reportRange = null, Expression<Func<string>> reportFormat = null)
        {
            var apiCallPath = "/track/api/v1/jsonreports";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["token"] = ExpressionConverter.Convert(token);
            if (account != null)
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
            if (group != null)
                callPayload.Queries["group"] = ExpressionConverter.Convert(group);
            if (reportName != null)
                callPayload.Queries["reportName"] = ExpressionConverter.Convert(reportName);
            if (reportRange != null)
                callPayload.Queries["reportRange"] = ExpressionConverter.Convert(reportRange);
            if (reportFormat != null)
                callPayload.Queries["reportFormat"] = ExpressionConverter.Convert(reportFormat);
            return new ApiConnectionAction<GetBreadcrumbsReportResponse>(callPayload);
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