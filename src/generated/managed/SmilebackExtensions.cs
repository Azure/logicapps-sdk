//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smileback
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmilebackActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IWorkflowAction DeletePower([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/power/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<CSATCompaniesResponseItem[]> CSATCompanies()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/csat-companies/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CSATCompaniesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<CSATContactsResponseItem[]> CSATContacts()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/csat-contacts/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CSATContactsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<NPSCampaignsResponseItem[]> NPSCampaigns()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/nps-campaigns/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NPSCampaignsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smileback")]
        public IBodyWorkflowAction<PRJSurveysResponseItem[]> PRJSurveys()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/prj-surveys/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PRJSurveysResponseItem[]>(BuildSourceInput);
        }
    }

    public class SmilebackTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CSATReceived([WorkflowExpression] Func<fieldcsatFilterRaitingInputItem[]> fieldcsatFilterRaiting = null, [WorkflowExpression] Func<string[]> fieldcsatFilterAgents = null, [WorkflowExpression] Func<string[]> fieldcsatFilterSegments = null, [WorkflowExpression] Func<string[]> fieldcsatFilterCompanies = null, [WorkflowExpression] Func<string[]> fieldcsatFilterContacts = null, [WorkflowExpression] Func<fieldcsatFilterCommentsInput> fieldcsatFilterComments = null, [WorkflowExpression] Func<fieldcsatFilterMpInput> fieldcsatFilterMp = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(fieldcsatFilterRaiting, nameof(fieldcsatFilterRaiting), required: false);
            SourceExpression.Validate(fieldcsatFilterAgents, nameof(fieldcsatFilterAgents), required: false);
            SourceExpression.Validate(fieldcsatFilterSegments, nameof(fieldcsatFilterSegments), required: false);
            SourceExpression.Validate(fieldcsatFilterCompanies, nameof(fieldcsatFilterCompanies), required: false);
            SourceExpression.Validate(fieldcsatFilterContacts, nameof(fieldcsatFilterContacts), required: false);
            SourceExpression.Validate(fieldcsatFilterComments, nameof(fieldcsatFilterComments), required: false);
            SourceExpression.Validate(fieldcsatFilterMp, nameof(fieldcsatFilterMp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/power/CSAT/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("@listCallbackUrl()");
                var field = new JObject();
                var fieldpropCount = 0;
                if (fieldcsatFilterRaiting != null)
                {
                    field["csat_filter_raiting"] = SourceExpressionConverter.ConvertToken(fieldcsatFilterRaiting);
                    fieldpropCount++;
                }

                if (fieldcsatFilterAgents != null)
                {
                    field["csat_filter_agents"] = SourceExpressionConverter.ConvertToken(fieldcsatFilterAgents);
                    fieldpropCount++;
                }

                if (fieldcsatFilterSegments != null)
                {
                    field["csat_filter_segments"] = SourceExpressionConverter.ConvertToken(fieldcsatFilterSegments);
                    fieldpropCount++;
                }

                if (fieldcsatFilterCompanies != null)
                {
                    field["csat_filter_companies"] = SourceExpressionConverter.ConvertToken(fieldcsatFilterCompanies);
                    fieldpropCount++;
                }

                if (fieldcsatFilterContacts != null)
                {
                    field["csat_filter_contacts"] = SourceExpressionConverter.ConvertToken(fieldcsatFilterContacts);
                    fieldpropCount++;
                }

                if (fieldcsatFilterComments != null)
                {
                    field["csat_filter_comments"] = SourceExpressionConverter.Convert(fieldcsatFilterComments);
                    fieldpropCount++;
                }

                if (fieldcsatFilterMp != null)
                {
                    field["csat_filter_mp"] = SourceExpressionConverter.Convert(fieldcsatFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger NPSReceived([WorkflowExpression] Func<fieldnpsFilterScoreInputItem[]> fieldnpsFilterScore = null, [WorkflowExpression] Func<string[]> fieldnpsFilterCampaigns = null, [WorkflowExpression] Func<fieldnpsFilterCommentsInput> fieldnpsFilterComments = null, [WorkflowExpression] Func<fieldnpsFilterMpInput> fieldnpsFilterMp = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(fieldnpsFilterScore, nameof(fieldnpsFilterScore), required: false);
            SourceExpression.Validate(fieldnpsFilterCampaigns, nameof(fieldnpsFilterCampaigns), required: false);
            SourceExpression.Validate(fieldnpsFilterComments, nameof(fieldnpsFilterComments), required: false);
            SourceExpression.Validate(fieldnpsFilterMp, nameof(fieldnpsFilterMp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/power/NPS/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("@listCallbackUrl()");
                var field = new JObject();
                var fieldpropCount = 0;
                if (fieldnpsFilterScore != null)
                {
                    field["nps_filter_score"] = SourceExpressionConverter.ConvertToken(fieldnpsFilterScore);
                    fieldpropCount++;
                }

                if (fieldnpsFilterCampaigns != null)
                {
                    field["nps_filter_campaigns"] = SourceExpressionConverter.ConvertToken(fieldnpsFilterCampaigns);
                    fieldpropCount++;
                }

                if (fieldnpsFilterComments != null)
                {
                    field["nps_filter_comments"] = SourceExpressionConverter.Convert(fieldnpsFilterComments);
                    fieldpropCount++;
                }

                if (fieldnpsFilterMp != null)
                {
                    field["nps_filter_mp"] = SourceExpressionConverter.Convert(fieldnpsFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger PRJReceived([WorkflowExpression] Func<fieldprojectsFilterScoreInputItem[]> fieldprojectsFilterScore = null, [WorkflowExpression] Func<string[]> fieldprojectsFilterSurveys = null, [WorkflowExpression] Func<fieldprojectsFilterCommentsInput> fieldprojectsFilterComments = null, [WorkflowExpression] Func<fieldprojectsFilterMpInput> fieldprojectsFilterMp = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(fieldprojectsFilterScore, nameof(fieldprojectsFilterScore), required: false);
            SourceExpression.Validate(fieldprojectsFilterSurveys, nameof(fieldprojectsFilterSurveys), required: false);
            SourceExpression.Validate(fieldprojectsFilterComments, nameof(fieldprojectsFilterComments), required: false);
            SourceExpression.Validate(fieldprojectsFilterMp, nameof(fieldprojectsFilterMp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/v3/power/PRJ/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["x-ms-notification-url"] = Convert.ToString("@listCallbackUrl()");
                var field = new JObject();
                var fieldpropCount = 0;
                if (fieldprojectsFilterScore != null)
                {
                    field["projects_filter_score"] = SourceExpressionConverter.ConvertToken(fieldprojectsFilterScore);
                    fieldpropCount++;
                }

                if (fieldprojectsFilterSurveys != null)
                {
                    field["projects_filter_surveys"] = SourceExpressionConverter.ConvertToken(fieldprojectsFilterSurveys);
                    fieldpropCount++;
                }

                if (fieldprojectsFilterComments != null)
                {
                    field["projects_filter_comments"] = SourceExpressionConverter.Convert(fieldprojectsFilterComments);
                    fieldpropCount++;
                }

                if (fieldprojectsFilterMp != null)
                {
                    field["projects_filter_mp"] = SourceExpressionConverter.Convert(fieldprojectsFilterMp);
                    fieldpropCount++;
                }

                if (fieldpropCount > 0)
                {
                    callPayload.Body = field;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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