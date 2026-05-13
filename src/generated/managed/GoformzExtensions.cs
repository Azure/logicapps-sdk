//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Goformz
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoformzActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IBodyWorkflowAction<string> ExportForm(Expression<Func<string>> formId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodypages = null)
        {
            var apiCallPath = String.Format("/v2/formz/{0}/exports", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodypages != null)
            {
                body["pages"] = ExpressionConverter.ConvertO(bodypages);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IWorkflowAction CreateForm(Expression<Func<bool>> runCalculations = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyoverrideDefaultFormName = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodyassignmentid = null, Expression<Func<string>> bodyassignmenttype = null, Expression<Func<string>> bodyassignmenturl = null)
        {
            var apiCallPath = "/v2/formz";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["runCalculations"] = Convert.ToString(false);
            if (runCalculations != null)
                callPayload.Queries["runCalculations"] = ExpressionConverter.Convert(runCalculations);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyoverrideDefaultFormName != null)
            {
                body["overrideDefaultFormName"] = ExpressionConverter.ConvertO(bodyoverrideDefaultFormName);
                bodypropCount++;
            }

            if (bodytemplateId != null)
            {
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
            }

            var assignmentObject = new JObject();
            var assignmentObjectpropCount = 0;
            if (bodyassignmentid != null)
            {
                assignmentObject["id"] = ExpressionConverter.ConvertO(bodyassignmentid);
                assignmentObjectpropCount++;
            }

            if (bodyassignmenttype != null)
            {
                assignmentObject["type"] = ExpressionConverter.ConvertO(bodyassignmenttype);
                assignmentObjectpropCount++;
            }

            if (bodyassignmenturl != null)
            {
                assignmentObject["url"] = ExpressionConverter.ConvertO(bodyassignmenturl);
                assignmentObjectpropCount++;
            }

            if (assignmentObjectpropCount > 0)
            {
                body["assignment"] = assignmentObject;
                bodypropCount++;
            }

            var fieldsObject = new JObject();
            var fieldsObjectpropCount = 0;
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IBodyWorkflowAction<FormDto> GetForm(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/v2/formz/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FormDto>(callPayload);
        }
    }

    public class GoformzTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FormCompleted(Expression<Func<string>> bodyentityId, Expression<Func<string>> bodyeventType = null, Expression<Func<bool>> bodyenabled = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/webhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyeventType != null)
            {
                body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                bodypropCount++;
            }

            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["entityId"] = ExpressionConverter.ConvertO(bodyentityId);
            if (bodyenabled != null)
            {
                body["enabled"] = ExpressionConverter.ConvertO(bodyenabled);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class FormDto
    {
        [JsonProperty("formId")]
        public string FormId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("overrideDefaultFormName")]
        public bool OverrideDefaultFormName { get; set; }

        [JsonProperty("status")]
        public FormStatusDto Status { get; set; }

        [JsonProperty("lastUpdateDate")]
        public string LastUpdateDate { get; set; }

        [JsonProperty("assignment")]
        public AssignmentDto Assignment { get; set; }

        [JsonProperty("location")]
        public LocationDto Location { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("templateUrl")]
        public string TemplateUrl { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class FormStatusDto
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("changeDate")]
        public string ChangeDate { get; set; }
    }

    public class AssignmentDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class LocationDto
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Goformz;

    public partial class WorkflowManagedActions
    {
        public GoformzActions Goformz(string connectionId) => new GoformzActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public GoformzTriggers Goformz(string connectionId) => new GoformzTriggers(connectionId);
    }
}