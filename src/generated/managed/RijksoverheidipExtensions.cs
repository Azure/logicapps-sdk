//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rijksoverheidip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RijksoverheidipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rijksoverheidip")]
        public IBodyWorkflowAction<SchoolHolidaysResponseItem[]> SchoolHolidays(Expression<Func<int>> rows = null, Expression<Func<string>> output = null)
        {
            var __workflow_rows = WorkflowExpression.Compile(rows, nameof(rows), required: false);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            return new DeferredBodyAction<SchoolHolidaysResponseItem[]>(() =>
            {
                var apiCallPath = "/v1/sources/rijksoverheid/infotypes/schoolholidays/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["rows"] = Convert.ToString(200);
                if (__workflow_rows != null)
                    callPayload.Queries["rows"] = ExpressionConverter.Convert(__workflow_rows);
                callPayload.Queries["output"] = Convert.ToString("json");
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                return new ApiConnectionAction<SchoolHolidaysResponseItem[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rijksoverheidip")]
        public IBodyWorkflowAction<SchoolHolidaysPerSchoolYearResponse> SchoolHolidaysPerSchoolYear(Expression<Func<string>> schoolyear, Expression<Func<string>> output = null)
        {
            var __workflow_schoolyear = WorkflowExpression.Compile(schoolyear, nameof(schoolyear), required: true);
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            return new DeferredBodyAction<SchoolHolidaysPerSchoolYearResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/sources/rijksoverheid/infotypes/schoolholidays/schoolyear/{0}", __workflow_schoolyear.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["output"] = Convert.ToString("json");
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                return new ApiConnectionAction<SchoolHolidaysPerSchoolYearResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class RijksoverheidipTriggers([ConnectionName] string connectionId)
    {
    }

    public class SchoolHolidaysResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("canonical")]
        public string Canonical { get; set; }

        [JsonProperty("content")]
        public SchoolHolidaysResponseItemContentTypeItem[] Content { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("authorities")]
        public string[] Authorities { get; set; }

        [JsonProperty("creators")]
        public string[] Creators { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("rightsholders")]
        public string[] Rightsholders { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }
    }

    public class SchoolHolidaysResponseItemContentTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("schoolyear")]
        public string Schoolyear { get; set; }

        [JsonProperty("vacations")]
        public SchoolHolidaysResponseItemContentTypeItemVacationsTypeItem[] Vacations { get; set; }
    }

    public class SchoolHolidaysResponseItemContentTypeItemVacationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("compulsorydates")]
        public string Compulsorydates { get; set; }

        [JsonProperty("regions")]
        public SchoolHolidaysResponseItemContentTypeItemVacationsTypeItemRegionsTypeItem[] Regions { get; set; }
    }

    public class SchoolHolidaysResponseItemContentTypeItemVacationsTypeItemRegionsTypeItem
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }
    }

    public class SchoolHolidaysPerSchoolYearResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("canonical")]
        public string Canonical { get; set; }

        [JsonProperty("content")]
        public SchoolHolidaysPerSchoolYearResponseContentTypeItem[] Content { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("authorities")]
        public string[] Authorities { get; set; }

        [JsonProperty("creators")]
        public string[] Creators { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("rightsholders")]
        public string[] Rightsholders { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("lastmodified")]
        public string Lastmodified { get; set; }
    }

    public class SchoolHolidaysPerSchoolYearResponseContentTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("schoolyear")]
        public string Schoolyear { get; set; }

        [JsonProperty("vacations")]
        public SchoolHolidaysPerSchoolYearResponseContentTypeItemVacationsTypeItem[] Vacations { get; set; }
    }

    public class SchoolHolidaysPerSchoolYearResponseContentTypeItemVacationsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("compulsorydates")]
        public string Compulsorydates { get; set; }

        [JsonProperty("regions")]
        public SchoolHolidaysPerSchoolYearResponseContentTypeItemVacationsTypeItemRegionsTypeItem[] Regions { get; set; }
    }

    public class SchoolHolidaysPerSchoolYearResponseContentTypeItemVacationsTypeItemRegionsTypeItem
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("startdate")]
        public string Startdate { get; set; }

        [JsonProperty("enddate")]
        public string Enddate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rijksoverheidip;

    public partial class WorkflowManagedActions
    {
        public RijksoverheidipActions Rijksoverheidip(string connectionId) => new RijksoverheidipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RijksoverheidipTriggers Rijksoverheidip(string connectionId) => new RijksoverheidipTriggers(connectionId);
    }
}
