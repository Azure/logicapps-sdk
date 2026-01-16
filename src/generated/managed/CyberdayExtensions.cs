//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cyberday
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CyberdayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberday")]
        public IBodyWorkflowAction<GetSystemsResponseItem[]> GetSystems()
        {
            var apiCallPath = "/api/external/systems/topics/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetSystemsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberday")]
        public IBodyWorkflowAction<AddSystemResponse> AddSystem(Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = "/api/external/systems/topics/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddSystemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cyberday")]
        public IWorkflowAction AddSystemAdvanced(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyfieldssystemNickname = null, Expression<Func<string>> bodyfieldssystemOwner = null, Expression<Func<string>> bodyfieldssystemAdministrator = null, Expression<Func<string>> bodyfieldscostCenter = null, Expression<Func<string[]>> bodyfieldslinkedSystems = null, Expression<Func<string>> bodyfieldsdataSystemPurpose = null, Expression<Func<string[]>> bodyfieldslinkedSystemProviders = null, Expression<Func<string>> bodyfieldspartnerResponsibilityDetails = null)
        {
            var apiCallPath = "/api/external/systems/topics/advanced/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            var fieldsObject = new JObject();
            var fieldsObjectpropCount = 0;
            if (bodyfieldssystemNickname != null)
            {
                fieldsObject["additional-name"] = ExpressionConverter.ConvertO(bodyfieldssystemNickname);
                fieldsObjectpropCount++;
            }

            if (bodyfieldssystemOwner != null)
            {
                fieldsObject["additional-owner"] = ExpressionConverter.ConvertO(bodyfieldssystemOwner);
                fieldsObjectpropCount++;
            }

            if (bodyfieldssystemAdministrator != null)
            {
                fieldsObject["additional-admin"] = ExpressionConverter.ConvertO(bodyfieldssystemAdministrator);
                fieldsObjectpropCount++;
            }

            if (bodyfieldscostCenter != null)
            {
                fieldsObject["additional-cost"] = ExpressionConverter.ConvertO(bodyfieldscostCenter);
                fieldsObjectpropCount++;
            }

            if (bodyfieldslinkedSystems != null)
            {
                fieldsObject["additional-linksystems"] = ExpressionConverter.ConvertO(bodyfieldslinkedSystems);
                fieldsObjectpropCount++;
            }

            if (bodyfieldsdataSystemPurpose != null)
            {
                fieldsObject["units-purpose"] = ExpressionConverter.ConvertO(bodyfieldsdataSystemPurpose);
                fieldsObjectpropCount++;
            }

            if (bodyfieldslinkedSystemProviders != null)
            {
                fieldsObject["processors-block"] = ExpressionConverter.ConvertO(bodyfieldslinkedSystemProviders);
                fieldsObjectpropCount++;
            }

            if (bodyfieldspartnerResponsibilityDetails != null)
            {
                fieldsObject["processors-resptext"] = ExpressionConverter.ConvertO(bodyfieldspartnerResponsibilityDetails);
                fieldsObjectpropCount++;
            }

            if (fieldsObjectpropCount > 0)
            {
                body["fields"] = fieldsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class CyberdayTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSystemsResponseItem
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("assigned_user")]
        public GetSystemsResponseItemAssignedUserType AssignedUser { get; set; }

        [JsonProperty("child_stats")]
        public GetSystemsResponseItemChildStatsType ChildStats { get; set; }

        [JsonProperty("cia_importance")]
        public string CiaImportance { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("goals")]
        public string[] Frameworks { get; set; }

        [JsonProperty("importance")]
        public int Priority { get; set; }

        [JsonProperty("is_draft")]
        public bool Draft { get; set; }

        [JsonProperty("next_review_date")]
        public string NextReviewDate { get; set; }

        [JsonProperty("review_interval")]
        public int ReviewInterval { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("week_num")]
        public string WeekNumber { get; set; }

        [JsonProperty("workflow_status")]
        public GetSystemsResponseItemStatusType Status { get; set; }

        [JsonProperty("text___system-template-location-hostingtype")]
        public string TextSystemTemplateLocationHostingtype { get; set; }

        [JsonProperty("text___system-template-search-criteria")]
        public string TextSystemTemplateSearchCriteria { get; set; }

        [JsonProperty("user_text___system-template-additional-year")]
        public string UserTextSystemTemplateAdditionalYear { get; set; }

        [JsonProperty("text___system-template-processors-yesno")]
        public string TextSystemTemplateProcessorsYesno { get; set; }

        [JsonProperty("text___situation-template-datasources-integrations")]
        public string TextSituationTemplateDatasourcesIntegrations { get; set; }

        [JsonProperty("text___system-template-accessandauth-accessblock")]
        public string TextSystemTemplateAccessandauthAccessblock { get; set; }

        [JsonProperty("text___system-template-units-authority")]
        public string TextSystemTemplateUnitsAuthority { get; set; }

        [JsonProperty("user_text___system-template-additional-ip")]
        public string UserTextSystemTemplateAdditionalIp { get; set; }

        [JsonProperty("text___system-template-accessandauth-authblock")]
        public string TextSystemTemplateAccessandauthAuthblock { get; set; }

        [JsonProperty("user_text___system-template-units-purpose")]
        public string UserTextSystemTemplateUnitsPurpose { get; set; }

        [JsonProperty("text___situation-template-datasources-block")]
        public string TextSituationTemplateDatasourcesBlock { get; set; }

        [JsonProperty("text___system-template-processors-block")]
        public string TextSystemTemplateProcessorsBlock { get; set; }

        [JsonProperty("text___system-template-location-block")]
        public string TextSystemTemplateLocationBlock { get; set; }

        [JsonProperty("text___system-template-location-explain")]
        public string TextSystemTemplateLocationExplain { get; set; }

        [JsonProperty("user_text___system-template-additional-name")]
        public string UserTextSystemTemplateAdditionalName { get; set; }

        [JsonProperty("text___system-template-units-block")]
        public string TextSystemTemplateUnitsBlock { get; set; }

        [JsonProperty("text___system-template-product")]
        public string TextSystemTemplateProduct { get; set; }

        [JsonProperty("text___system-template-units-authessentialyesno")]
        public string TextSystemTemplateUnitsAuthessentialyesno { get; set; }

        [JsonProperty("user_text___system-template-additional-id")]
        public string UserTextSystemTemplateAdditionalId { get; set; }

        [JsonProperty("user_text___system-template-additional-cost")]
        public string UserTextSystemTemplateAdditionalCost { get; set; }

        [JsonProperty("text___system-template-additional-critical")]
        public string TextSystemTemplateAdditionalCritical { get; set; }

        [JsonProperty("text___system-template-location-explaintext")]
        public string TextSystemTemplateLocationExplaintext { get; set; }

        [JsonProperty("user_text___system-template-additional-users")]
        public string UserTextSystemTemplateAdditionalUsers { get; set; }

        [JsonProperty("user_text___system-template-additional-os")]
        public string UserTextSystemTemplateAdditionalOs { get; set; }

        [JsonProperty("text___system-template-additional-linksystems")]
        public string TextSystemTemplateAdditionalLinksystems { get; set; }

        [JsonProperty("text___system-template-processors-otherparties")]
        public string TextSystemTemplateProcessorsOtherparties { get; set; }
    }

    public class GetSystemsResponseItemAssignedUserType
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class GetSystemsResponseItemChildStatsType
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("done")]
        public int Done { get; set; }

        [JsonProperty("active")]
        public int Active { get; set; }
    }

    public class GetSystemsResponseItemStatusType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class AddSystemResponse
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cyberday;

    public partial class WorkflowManagedActions
    {
        public CyberdayActions Cyberday(string connectionId) => new CyberdayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CyberdayTriggers Cyberday(string connectionId) => new CyberdayTriggers(connectionId);
    }
}