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
        public IWorkflowAction DeletePower(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/power/{0}/", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<CSATCompaniesResponseItem[]> CSATCompanies()
        {
            var apiCallPath = "/api/v3/csat-companies/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CSATCompaniesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<CSATContactsResponseItem[]> CSATContacts()
        {
            var apiCallPath = "/api/v3/csat-contacts/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CSATContactsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<NPSCampaignsResponseItem[]> NPSCampaigns()
        {
            var apiCallPath = "/api/v3/nps-campaigns/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NPSCampaignsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<PRJSurveysResponseItem[]> PRJSurveys()
        {
            var apiCallPath = "/api/v3/prj-surveys/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PRJSurveysResponseItem[]>(callPayload);
        }
    }

    public class SmilebackTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CSATReceived(Expression<Func<fieldcsatFilterRaitingInputItem[]>> fieldcsatFilterRaiting = null, Expression<Func<string[]>> fieldcsatFilterAgents = null, Expression<Func<string[]>> fieldcsatFilterSegments = null, Expression<Func<string[]>> fieldcsatFilterCompanies = null, Expression<Func<string[]>> fieldcsatFilterContacts = null, Expression<Func<fieldcsatFilterCommentsInput>> fieldcsatFilterComments = null, Expression<Func<fieldcsatFilterMpInput>> fieldcsatFilterMp = null, FlowRecurrence recurrence = null)
        {
            var __workflow_fieldcsatFilterRaiting = WorkflowExpression.Compile(fieldcsatFilterRaiting, nameof(fieldcsatFilterRaiting), required: false);
            var __workflow_fieldcsatFilterAgents = WorkflowExpression.Compile(fieldcsatFilterAgents, nameof(fieldcsatFilterAgents), required: false);
            var __workflow_fieldcsatFilterSegments = WorkflowExpression.Compile(fieldcsatFilterSegments, nameof(fieldcsatFilterSegments), required: false);
            var __workflow_fieldcsatFilterCompanies = WorkflowExpression.Compile(fieldcsatFilterCompanies, nameof(fieldcsatFilterCompanies), required: false);
            var __workflow_fieldcsatFilterContacts = WorkflowExpression.Compile(fieldcsatFilterContacts, nameof(fieldcsatFilterContacts), required: false);
            var __workflow_fieldcsatFilterComments = WorkflowExpression.Compile(fieldcsatFilterComments, nameof(fieldcsatFilterComments), required: false);
            var __workflow_fieldcsatFilterMp = WorkflowExpression.Compile(fieldcsatFilterMp, nameof(fieldcsatFilterMp), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v3/power/CSAT/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                var field = new JObject();
                var fieldpropCount = 0;
                if (__workflow_fieldcsatFilterRaiting != null)
                {
                    field["csat_filter_raiting"] = ExpressionConverter.ConvertO(__workflow_fieldcsatFilterRaiting);
                    fieldpropCount++;
                }

                if (__workflow_fieldcsatFilterAgents != null)
                {
                    field["csat_filter_agents"] = ExpressionConverter.ConvertO(__workflow_fieldcsatFilterAgents);
                    fieldpropCount++;
                }

                if (__workflow_fieldcsatFilterSegments != null)
                {
                    field["csat_filter_segments"] = ExpressionConverter.ConvertO(__workflow_fieldcsatFilterSegments);
                    fieldpropCount++;
                }

                if (__workflow_fieldcsatFilterCompanies != null)
                {
                    field["csat_filter_companies"] = ExpressionConverter.ConvertO(__workflow_fieldcsatFilterCompanies);
                    fieldpropCount++;
                }

                if (__workflow_fieldcsatFilterContacts != null)
                {
                    field["csat_filter_contacts"] = ExpressionConverter.ConvertO(__workflow_fieldcsatFilterContacts);
                    fieldpropCount++;
                }

                if (__workflow_fieldcsatFilterComments != null)
                {
                    field["csat_filter_comments"] = ExpressionConverter.ConvertO(__workflow_fieldcsatFilterComments);
                    fieldpropCount++;
                }

                if (__workflow_fieldcsatFilterMp != null)
                {
                    field["csat_filter_mp"] = ExpressionConverter.ConvertO(__workflow_fieldcsatFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger NPSReceived(Expression<Func<fieldnpsFilterScoreInputItem[]>> fieldnpsFilterScore = null, Expression<Func<string[]>> fieldnpsFilterCampaigns = null, Expression<Func<fieldnpsFilterCommentsInput>> fieldnpsFilterComments = null, Expression<Func<fieldnpsFilterMpInput>> fieldnpsFilterMp = null, FlowRecurrence recurrence = null)
        {
            var __workflow_fieldnpsFilterScore = WorkflowExpression.Compile(fieldnpsFilterScore, nameof(fieldnpsFilterScore), required: false);
            var __workflow_fieldnpsFilterCampaigns = WorkflowExpression.Compile(fieldnpsFilterCampaigns, nameof(fieldnpsFilterCampaigns), required: false);
            var __workflow_fieldnpsFilterComments = WorkflowExpression.Compile(fieldnpsFilterComments, nameof(fieldnpsFilterComments), required: false);
            var __workflow_fieldnpsFilterMp = WorkflowExpression.Compile(fieldnpsFilterMp, nameof(fieldnpsFilterMp), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v3/power/NPS/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                var field = new JObject();
                var fieldpropCount = 0;
                if (__workflow_fieldnpsFilterScore != null)
                {
                    field["nps_filter_score"] = ExpressionConverter.ConvertO(__workflow_fieldnpsFilterScore);
                    fieldpropCount++;
                }

                if (__workflow_fieldnpsFilterCampaigns != null)
                {
                    field["nps_filter_campaigns"] = ExpressionConverter.ConvertO(__workflow_fieldnpsFilterCampaigns);
                    fieldpropCount++;
                }

                if (__workflow_fieldnpsFilterComments != null)
                {
                    field["nps_filter_comments"] = ExpressionConverter.ConvertO(__workflow_fieldnpsFilterComments);
                    fieldpropCount++;
                }

                if (__workflow_fieldnpsFilterMp != null)
                {
                    field["nps_filter_mp"] = ExpressionConverter.ConvertO(__workflow_fieldnpsFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
        }

        public IWorkflowTrigger PRJReceived(Expression<Func<fieldprojectsFilterScoreInputItem[]>> fieldprojectsFilterScore = null, Expression<Func<string[]>> fieldprojectsFilterSurveys = null, Expression<Func<fieldprojectsFilterCommentsInput>> fieldprojectsFilterComments = null, Expression<Func<fieldprojectsFilterMpInput>> fieldprojectsFilterMp = null, FlowRecurrence recurrence = null)
        {
            var __workflow_fieldprojectsFilterScore = WorkflowExpression.Compile(fieldprojectsFilterScore, nameof(fieldprojectsFilterScore), required: false);
            var __workflow_fieldprojectsFilterSurveys = WorkflowExpression.Compile(fieldprojectsFilterSurveys, nameof(fieldprojectsFilterSurveys), required: false);
            var __workflow_fieldprojectsFilterComments = WorkflowExpression.Compile(fieldprojectsFilterComments, nameof(fieldprojectsFilterComments), required: false);
            var __workflow_fieldprojectsFilterMp = WorkflowExpression.Compile(fieldprojectsFilterMp, nameof(fieldprojectsFilterMp), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v3/power/PRJ/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                var field = new JObject();
                var fieldpropCount = 0;
                if (__workflow_fieldprojectsFilterScore != null)
                {
                    field["projects_filter_score"] = ExpressionConverter.ConvertO(__workflow_fieldprojectsFilterScore);
                    fieldpropCount++;
                }

                if (__workflow_fieldprojectsFilterSurveys != null)
                {
                    field["projects_filter_surveys"] = ExpressionConverter.ConvertO(__workflow_fieldprojectsFilterSurveys);
                    fieldpropCount++;
                }

                if (__workflow_fieldprojectsFilterComments != null)
                {
                    field["projects_filter_comments"] = ExpressionConverter.ConvertO(__workflow_fieldprojectsFilterComments);
                    fieldpropCount++;
                }

                if (__workflow_fieldprojectsFilterMp != null)
                {
                    field["projects_filter_mp"] = ExpressionConverter.ConvertO(__workflow_fieldprojectsFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            }, WorkflowTriggerSettingsProfiles.ManagedConnector);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldcsatFilterRaitingInputItem
    {
        Positive,
        Neutral,
        Negative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldcsatFilterCommentsInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldcsatFilterMpInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldnpsFilterScoreInputItem
    {
        [EnumMember(Value = "Detractor (0-6)")]
        Detractor06,
        [EnumMember(Value = "Passive (7-8)")]
        Passive78,
        [EnumMember(Value = "Promoter (9-10)")]
        Promoter910
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldnpsFilterCommentsInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldnpsFilterMpInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldprojectsFilterScoreInputItem
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
    public enum fieldprojectsFilterCommentsInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fieldprojectsFilterMpInput
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
