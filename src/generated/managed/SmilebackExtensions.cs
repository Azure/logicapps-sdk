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
        public IWorkflowAction DeletePower([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id)
        {
            var apiCallPath = String.Format("/api/v3/power/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
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
        public IWorkflowTrigger CSATReceived([WorkflowExpression] Func<fieldcsatFilterRaitingInputItem[]> fieldcsatFilterRaiting = null, [WorkflowExpression] Func<string[]> fieldcsatFilterAgents = null, [WorkflowExpression] Func<string[]> fieldcsatFilterSegments = null, [WorkflowExpression] Func<string[]> fieldcsatFilterCompanies = null, [WorkflowExpression] Func<string[]> fieldcsatFilterContacts = null, [WorkflowExpression] Func<fieldcsatFilterCommentsInput> fieldcsatFilterComments = null, [WorkflowExpression] Func<fieldcsatFilterMpInput> fieldcsatFilterMp = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v3/power/CSAT/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ms-notification-url"] = Convert.ToString("@listCallbackUrl()");
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger NPSReceived([WorkflowExpression] Func<fieldnpsFilterScoreInputItem[]> fieldnpsFilterScore = null, [WorkflowExpression] Func<string[]> fieldnpsFilterCampaigns = null, [WorkflowExpression] Func<fieldnpsFilterCommentsInput> fieldnpsFilterComments = null, [WorkflowExpression] Func<fieldnpsFilterMpInput> fieldnpsFilterMp = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v3/power/NPS/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ms-notification-url"] = Convert.ToString("@listCallbackUrl()");
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger PRJReceived([WorkflowExpression] Func<fieldprojectsFilterScoreInputItem[]> fieldprojectsFilterScore = null, [WorkflowExpression] Func<string[]> fieldprojectsFilterSurveys = null, [WorkflowExpression] Func<fieldprojectsFilterCommentsInput> fieldprojectsFilterComments = null, [WorkflowExpression] Func<fieldprojectsFilterMpInput> fieldprojectsFilterMp = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/api/v3/power/PRJ/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["x-ms-notification-url"] = Convert.ToString("@listCallbackUrl()");
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

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public enum fieldcsatFilterRaitingInputItem
    {
        Positive,
        Neutral,
        Negative
    }

    public enum fieldcsatFilterCommentsInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    public enum fieldcsatFilterMpInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    public enum fieldnpsFilterScoreInputItem
    {
        [EnumMember(Value = "Detractor (0-6)")]
        Detractor06,
        [EnumMember(Value = "Passive (7-8)")]
        Passive78,
        [EnumMember(Value = "Promoter (9-10)")]
        Promoter910
    }

    public enum fieldnpsFilterCommentsInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

    public enum fieldnpsFilterMpInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

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

    public enum fieldprojectsFilterCommentsInput
    {
        [EnumMember(Value = "")]
        None,
        Yes
    }

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