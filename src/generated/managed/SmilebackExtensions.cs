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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CSATReceived(Expression<Func<CSATReceivedInput>> field = null, FlowRecurrence recurrence = null)
        {
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/power/CSAT/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                if (__workflow_field != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_field);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> NPSReceived(Expression<Func<NPSReceivedInput>> field = null, FlowRecurrence recurrence = null)
        {
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/power/NPS/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                if (__workflow_field != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_field);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> PRJReceived(Expression<Func<PRJReceivedInput>> field = null, FlowRecurrence recurrence = null)
        {
            var __workflow_field = WorkflowExpression.Compile(field, nameof(field), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/v3/power/PRJ/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                if (__workflow_field != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_field);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

    public class CSATReceivedInput
    {
        [JsonProperty("csat_filter_raiting")]
        public CSATReceivedInputCsatFilterRaitingTypeItem[] CsatFilterRaiting { get; set; }

        [JsonProperty("csat_filter_agents")]
        public string[] CsatFilterAgents { get; set; }

        [JsonProperty("csat_filter_segments")]
        public string[] CsatFilterSegments { get; set; }

        [JsonProperty("csat_filter_companies")]
        public string[] CsatFilterCompanies { get; set; }

        [JsonProperty("csat_filter_contacts")]
        public string[] CsatFilterContacts { get; set; }

        [JsonProperty("csat_filter_comments")]
        public CSATReceivedInputCsatFilterCommentsType? CsatFilterComments { get; set; }

        [JsonProperty("csat_filter_mp")]
        public CSATReceivedInputCsatFilterMpType? CsatFilterMp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CSATReceivedInputCsatFilterRaitingTypeItem
    {
        Positive,
        Neutral,
        Negative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CSATReceivedInputCsatFilterCommentsType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CSATReceivedInputCsatFilterMpType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    public class NPSReceivedInput
    {
        [JsonProperty("nps_filter_score")]
        public NPSReceivedInputNpsFilterScoreTypeItem[] NpsFilterScore { get; set; }

        [JsonProperty("nps_filter_campaigns")]
        public string[] NpsFilterCampaigns { get; set; }

        [JsonProperty("nps_filter_comments")]
        public NPSReceivedInputNpsFilterCommentsType? NpsFilterComments { get; set; }

        [JsonProperty("nps_filter_mp")]
        public NPSReceivedInputNpsFilterMpType? NpsFilterMp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NPSReceivedInputNpsFilterScoreTypeItem
    {
        [EnumMember(Value = "Detractor (0-6)")]
        Detractor06,
        [EnumMember(Value = "Passive (7-8)")]
        Passive78,
        [EnumMember(Value = "Promoter (9-10)")]
        Promoter910
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NPSReceivedInputNpsFilterCommentsType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NPSReceivedInputNpsFilterMpType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    public class PRJReceivedInput
    {
        [JsonProperty("projects_filter_score")]
        public PRJReceivedInputProjectsFilterScoreTypeItem[] ProjectsFilterScore { get; set; }

        [JsonProperty("projects_filter_surveys")]
        public string[] ProjectsFilterSurveys { get; set; }

        [JsonProperty("projects_filter_comments")]
        public PRJReceivedInputProjectsFilterCommentsType? ProjectsFilterComments { get; set; }

        [JsonProperty("projects_filter_mp")]
        public PRJReceivedInputProjectsFilterMpType? ProjectsFilterMp { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PRJReceivedInputProjectsFilterScoreTypeItem
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
    public enum PRJReceivedInputProjectsFilterCommentsType
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PRJReceivedInputProjectsFilterMpType
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