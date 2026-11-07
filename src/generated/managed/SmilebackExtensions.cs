//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smileback
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmilebackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletePower(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/power/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<CSATCompaniesResponseItem[], ApiConnectionActionConfiguration> CSATCompanies()
        {
            return new DeferredBodyAction<CSATCompaniesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/csat-companies/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CSATCompaniesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<CSATContactsResponseItem[], ApiConnectionActionConfiguration> CSATContacts()
        {
            return new DeferredBodyAction<CSATContactsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/csat-contacts/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CSATContactsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<NPSCampaignsResponseItem[], ApiConnectionActionConfiguration> NPSCampaigns()
        {
            return new DeferredBodyAction<NPSCampaignsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/nps-campaigns/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NPSCampaignsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<PRJSurveysResponseItem[], ApiConnectionActionConfiguration> PRJSurveys()
        {
            return new DeferredBodyAction<PRJSurveysResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/prj-surveys/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PRJSurveysResponseItem[]>(callPayload);
            });
        }
    }

    public class SmilebackTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> CSATReceived(Expression<Func<CSATReceivedFieldInput>> field = null)
        {
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/power/CSAT/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                if (__workflow_field != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_field);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> NPSReceived(Expression<Func<NPSReceivedFieldInput>> field = null)
        {
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/power/NPS/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                if (__workflow_field != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_field);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }

        public IWorkflowTrigger<ApiConnectionPollingTriggerConfiguration> PRJReceived(Expression<Func<PRJReceivedFieldInput>> field = null)
        {
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/power/PRJ/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                if (__workflow_field != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_field);
                return new ApiConnectionPollingTrigger(callPayload);
            });
        }
    }

    public class CSATCompaniesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CSATContactsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class NPSCampaignsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PRJSurveysResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CSATReceivedFieldInput
    {
        [JsonProperty("csat_filter_raiting")]
        public FieldInputCsatFilterRaitingTypeItem[] CsatFilterRaiting { get; set; }

        [JsonProperty("csat_filter_agents")]
        public string[] CsatFilterAgents { get; set; }

        [JsonProperty("csat_filter_segments")]
        public string[] CsatFilterSegments { get; set; }

        [JsonProperty("csat_filter_companies")]
        public string[] CsatFilterCompanies { get; set; }

        [JsonProperty("csat_filter_contacts")]
        public string[] CsatFilterContacts { get; set; }

        [JsonProperty("csat_filter_comments")]
        public FieldInputCsatFilterCommentsType? CsatFilterComments { get; set; }

        [JsonProperty("csat_filter_mp")]
        public FieldInputCsatFilterMpType? CsatFilterMp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputCsatFilterRaitingTypeItem
    {
        Positive,
        Neutral,
        Negative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputCsatFilterCommentsType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputCsatFilterMpType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    public class NPSReceivedFieldInput
    {
        [JsonProperty("nps_filter_score")]
        public FieldInputNpsFilterScoreTypeItem[] NpsFilterScore { get; set; }

        [JsonProperty("nps_filter_campaigns")]
        public string[] NpsFilterCampaigns { get; set; }

        [JsonProperty("nps_filter_comments")]
        public FieldInputNpsFilterCommentsType? NpsFilterComments { get; set; }

        [JsonProperty("nps_filter_mp")]
        public FieldInputNpsFilterMpType? NpsFilterMp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputNpsFilterScoreTypeItem
    {
        [EnumMember(Value = "Detractor (0-6)")]
        Detractor06,
        [EnumMember(Value = "Passive (7-8)")]
        Passive78,
        [EnumMember(Value = "Promoter (9-10)")]
        Promoter910
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputNpsFilterCommentsType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputNpsFilterMpType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    public class PRJReceivedFieldInput
    {
        [JsonProperty("projects_filter_score")]
        public FieldInputProjectsFilterScoreTypeItem[] ProjectsFilterScore { get; set; }

        [JsonProperty("projects_filter_surveys")]
        public string[] ProjectsFilterSurveys { get; set; }

        [JsonProperty("projects_filter_comments")]
        public FieldInputProjectsFilterCommentsType? ProjectsFilterComments { get; set; }

        [JsonProperty("projects_filter_mp")]
        public FieldInputProjectsFilterMpType? ProjectsFilterMp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputProjectsFilterScoreTypeItem
    {
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3,
        [EnumMember(Value = "4")]
        _4,
        [EnumMember(Value = "5")]
        _5
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputProjectsFilterCommentsType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FieldInputProjectsFilterMpType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smileback;

    public partial class WorkflowManagedActions
    {
        public SmilebackActions Smileback(string connectionId) => new SmilebackActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmilebackTriggers Smileback(string connectionId) => new SmilebackTriggers(connectionId);
    }
}