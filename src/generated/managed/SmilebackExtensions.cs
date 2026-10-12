//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smileback
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmilebackActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        [WorkflowExpressionFactory(nameof(__BuildDeletePower))]
        public IWorkflowAction DeletePower([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeletePower(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/v3/power/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
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

        [WorkflowExpressionFactory(nameof(__BuildCSATReceived))]
        public IWorkflowTrigger CSATReceived([WorkflowExpression] Func<fieldcsatFilterRaitingInputItem[]> fieldcsatFilterRaiting = null,[WorkflowExpression] Func<string[]> fieldcsatFilterAgents = null,[WorkflowExpression] Func<string[]> fieldcsatFilterSegments = null,[WorkflowExpression] Func<string[]> fieldcsatFilterCompanies = null,[WorkflowExpression] Func<string[]> fieldcsatFilterContacts = null,[WorkflowExpression] Func<fieldcsatFilterCommentsInput> fieldcsatFilterComments = null,[WorkflowExpression] Func<fieldcsatFilterMpInput> fieldcsatFilterMp = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCSATReceived(WorkflowExpression<fieldcsatFilterRaitingInputItem[]> fieldcsatFilterRaiting = null,WorkflowExpression<string[]> fieldcsatFilterAgents = null,WorkflowExpression<string[]> fieldcsatFilterSegments = null,WorkflowExpression<string[]> fieldcsatFilterCompanies = null,WorkflowExpression<string[]> fieldcsatFilterContacts = null,WorkflowExpression<fieldcsatFilterCommentsInput> fieldcsatFilterComments = null,WorkflowExpression<fieldcsatFilterMpInput> fieldcsatFilterMp = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(fieldcsatFilterRaiting, nameof(fieldcsatFilterRaiting), required: false);
            WorkflowExpression.Validate(fieldcsatFilterAgents, nameof(fieldcsatFilterAgents), required: false);
            WorkflowExpression.Validate(fieldcsatFilterSegments, nameof(fieldcsatFilterSegments), required: false);
            WorkflowExpression.Validate(fieldcsatFilterCompanies, nameof(fieldcsatFilterCompanies), required: false);
            WorkflowExpression.Validate(fieldcsatFilterContacts, nameof(fieldcsatFilterContacts), required: false);
            WorkflowExpression.Validate(fieldcsatFilterComments, nameof(fieldcsatFilterComments), required: false);
            WorkflowExpression.Validate(fieldcsatFilterMp, nameof(fieldcsatFilterMp), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v3/power/CSAT/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                var field = new JObject();
                var fieldpropCount = 0;
                if (fieldcsatFilterRaiting != null)
                {
                    field["csat_filter_raiting"] = ExpressionConverter.ConvertO(fieldcsatFilterRaiting);
                    fieldpropCount++;
                }

                if (fieldcsatFilterAgents != null)
                {
                    field["csat_filter_agents"] = ExpressionConverter.ConvertO(fieldcsatFilterAgents);
                    fieldpropCount++;
                }

                if (fieldcsatFilterSegments != null)
                {
                    field["csat_filter_segments"] = ExpressionConverter.ConvertO(fieldcsatFilterSegments);
                    fieldpropCount++;
                }

                if (fieldcsatFilterCompanies != null)
                {
                    field["csat_filter_companies"] = ExpressionConverter.ConvertO(fieldcsatFilterCompanies);
                    fieldpropCount++;
                }

                if (fieldcsatFilterContacts != null)
                {
                    field["csat_filter_contacts"] = ExpressionConverter.ConvertO(fieldcsatFilterContacts);
                    fieldpropCount++;
                }

                if (fieldcsatFilterComments != null)
                {
                    field["csat_filter_comments"] = ExpressionConverter.ConvertO(fieldcsatFilterComments);
                    fieldpropCount++;
                }

                if (fieldcsatFilterMp != null)
                {
                    field["csat_filter_mp"] = ExpressionConverter.ConvertO(fieldcsatFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildNPSReceived))]
        public IWorkflowTrigger NPSReceived([WorkflowExpression] Func<fieldnpsFilterScoreInputItem[]> fieldnpsFilterScore = null,[WorkflowExpression] Func<string[]> fieldnpsFilterCampaigns = null,[WorkflowExpression] Func<fieldnpsFilterCommentsInput> fieldnpsFilterComments = null,[WorkflowExpression] Func<fieldnpsFilterMpInput> fieldnpsFilterMp = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNPSReceived(WorkflowExpression<fieldnpsFilterScoreInputItem[]> fieldnpsFilterScore = null,WorkflowExpression<string[]> fieldnpsFilterCampaigns = null,WorkflowExpression<fieldnpsFilterCommentsInput> fieldnpsFilterComments = null,WorkflowExpression<fieldnpsFilterMpInput> fieldnpsFilterMp = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(fieldnpsFilterScore, nameof(fieldnpsFilterScore), required: false);
            WorkflowExpression.Validate(fieldnpsFilterCampaigns, nameof(fieldnpsFilterCampaigns), required: false);
            WorkflowExpression.Validate(fieldnpsFilterComments, nameof(fieldnpsFilterComments), required: false);
            WorkflowExpression.Validate(fieldnpsFilterMp, nameof(fieldnpsFilterMp), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v3/power/NPS/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                var field = new JObject();
                var fieldpropCount = 0;
                if (fieldnpsFilterScore != null)
                {
                    field["nps_filter_score"] = ExpressionConverter.ConvertO(fieldnpsFilterScore);
                    fieldpropCount++;
                }

                if (fieldnpsFilterCampaigns != null)
                {
                    field["nps_filter_campaigns"] = ExpressionConverter.ConvertO(fieldnpsFilterCampaigns);
                    fieldpropCount++;
                }

                if (fieldnpsFilterComments != null)
                {
                    field["nps_filter_comments"] = ExpressionConverter.ConvertO(fieldnpsFilterComments);
                    fieldpropCount++;
                }

                if (fieldnpsFilterMp != null)
                {
                    field["nps_filter_mp"] = ExpressionConverter.ConvertO(fieldnpsFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildPRJReceived))]
        public IWorkflowTrigger PRJReceived([WorkflowExpression] Func<fieldprojectsFilterScoreInputItem[]> fieldprojectsFilterScore = null,[WorkflowExpression] Func<string[]> fieldprojectsFilterSurveys = null,[WorkflowExpression] Func<fieldprojectsFilterCommentsInput> fieldprojectsFilterComments = null,[WorkflowExpression] Func<fieldprojectsFilterMpInput> fieldprojectsFilterMp = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildPRJReceived(WorkflowExpression<fieldprojectsFilterScoreInputItem[]> fieldprojectsFilterScore = null,WorkflowExpression<string[]> fieldprojectsFilterSurveys = null,WorkflowExpression<fieldprojectsFilterCommentsInput> fieldprojectsFilterComments = null,WorkflowExpression<fieldprojectsFilterMpInput> fieldprojectsFilterMp = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(fieldprojectsFilterScore, nameof(fieldprojectsFilterScore), required: false);
            WorkflowExpression.Validate(fieldprojectsFilterSurveys, nameof(fieldprojectsFilterSurveys), required: false);
            WorkflowExpression.Validate(fieldprojectsFilterComments, nameof(fieldprojectsFilterComments), required: false);
            WorkflowExpression.Validate(fieldprojectsFilterMp, nameof(fieldprojectsFilterMp), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/api/v3/power/PRJ/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("#{listCallbackUrl()}");
                var field = new JObject();
                var fieldpropCount = 0;
                if (fieldprojectsFilterScore != null)
                {
                    field["projects_filter_score"] = ExpressionConverter.ConvertO(fieldprojectsFilterScore);
                    fieldpropCount++;
                }

                if (fieldprojectsFilterSurveys != null)
                {
                    field["projects_filter_surveys"] = ExpressionConverter.ConvertO(fieldprojectsFilterSurveys);
                    fieldpropCount++;
                }

                if (fieldprojectsFilterComments != null)
                {
                    field["projects_filter_comments"] = ExpressionConverter.ConvertO(fieldprojectsFilterComments);
                    fieldpropCount++;
                }

                if (fieldprojectsFilterMp != null)
                {
                    field["projects_filter_mp"] = ExpressionConverter.ConvertO(fieldprojectsFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }

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