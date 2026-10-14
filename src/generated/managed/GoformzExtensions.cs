//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Goformz
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class GoformzActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IBodyWorkflowAction<string> ExportForm(Expression<Func<string>> formId, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodypages = null)
        {
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            var __workflow_bodypages = bodypages == null ? null : WorkflowExpression.Compile(bodypages);
            WorkflowExpression.Validate(__workflow_bodypages, nameof(bodypages), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/formz/{0}/exports", ExpressionConverter.ConvertWithUrlEncoding(__workflow_formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodypages != null)
                {
                    body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IWorkflowAction CreateForm(Expression<Func<bool>> runCalculations = null, Expression<Func<string>> bodyname = null, Expression<Func<bool>> bodyoverrideDefaultFormName = null, Expression<Func<string>> bodytemplateId = null, Expression<Func<string>> bodyassignmentid = null, Expression<Func<string>> bodyassignmenttype = null, Expression<Func<string>> bodyassignmenturl = null)
        {
            var __workflow_runCalculations = runCalculations == null ? null : WorkflowExpression.Compile(runCalculations);
            WorkflowExpression.Validate(__workflow_runCalculations, nameof(runCalculations), required: false);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyoverrideDefaultFormName = bodyoverrideDefaultFormName == null ? null : WorkflowExpression.Compile(bodyoverrideDefaultFormName);
            WorkflowExpression.Validate(__workflow_bodyoverrideDefaultFormName, nameof(bodyoverrideDefaultFormName), required: false);
            var __workflow_bodytemplateId = bodytemplateId == null ? null : WorkflowExpression.Compile(bodytemplateId);
            WorkflowExpression.Validate(__workflow_bodytemplateId, nameof(bodytemplateId), required: false);
            var __workflow_bodyassignmentid = bodyassignmentid == null ? null : WorkflowExpression.Compile(bodyassignmentid);
            WorkflowExpression.Validate(__workflow_bodyassignmentid, nameof(bodyassignmentid), required: false);
            var __workflow_bodyassignmenttype = bodyassignmenttype == null ? null : WorkflowExpression.Compile(bodyassignmenttype);
            WorkflowExpression.Validate(__workflow_bodyassignmenttype, nameof(bodyassignmenttype), required: false);
            var __workflow_bodyassignmenturl = bodyassignmenturl == null ? null : WorkflowExpression.Compile(bodyassignmenturl);
            WorkflowExpression.Validate(__workflow_bodyassignmenturl, nameof(bodyassignmenturl), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/v2/formz";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["runCalculations"] = Convert.ToString(false);
                if (__workflow_runCalculations != null)
                    callPayload.Queries["runCalculations"] = ExpressionConverter.Convert(__workflow_runCalculations);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyoverrideDefaultFormName != null)
                {
                    body["overrideDefaultFormName"] = ExpressionConverter.ConvertO(__workflow_bodyoverrideDefaultFormName);
                    bodypropCount++;
                }

                if (__workflow_bodytemplateId != null)
                {
                    body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                    bodypropCount++;
                }

                var assignmentObject = new JObject();
                var assignmentObjectpropCount = 0;
                if (__workflow_bodyassignmentid != null)
                {
                    assignmentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyassignmentid);
                    assignmentObjectpropCount++;
                }

                if (__workflow_bodyassignmenttype != null)
                {
                    assignmentObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyassignmenttype);
                    assignmentObjectpropCount++;
                }

                if (__workflow_bodyassignmenturl != null)
                {
                    assignmentObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyassignmenturl);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IBodyWorkflowAction<FormDto> GetForm(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<FormDto>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/formz/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FormDto>(callPayload);
            });
        }
    }

    public class GoformzTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FormCompleted(Expression<Func<string>> bodyentityId, Expression<Func<string>> bodyeventType = null, Expression<Func<bool>> bodyenabled = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyentityId = bodyentityId == null ? null : WorkflowExpression.Compile(bodyentityId);
            WorkflowExpression.Validate(__workflow_bodyentityId, nameof(bodyentityId), required: true);
            var __workflow_bodyeventType = bodyeventType == null ? null : WorkflowExpression.Compile(bodyeventType);
            WorkflowExpression.Validate(__workflow_bodyeventType, nameof(bodyeventType), required: false);
            var __workflow_bodyenabled = bodyenabled == null ? null : WorkflowExpression.Compile(bodyenabled);
            WorkflowExpression.Validate(__workflow_bodyenabled, nameof(bodyenabled), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                    bodypropCount++;
                }

                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["entityId"] = ExpressionConverter.ConvertO(__workflow_bodyentityId);
                if (__workflow_bodyenabled != null)
                {
                    body["enabled"] = ExpressionConverter.ConvertO(__workflow_bodyenabled);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
