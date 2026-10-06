//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Goformz
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class GoformzActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        [WorkflowExpressionFactory(nameof(__BuildExportForm))]
        public IBodyWorkflowAction<string> ExportForm([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodypages = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExportForm(WorkflowExpression<string> formId, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodypages = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodypages, nameof(bodypages), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/formz/{0}/exports", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        [WorkflowExpressionFactory(nameof(__BuildCreateForm))]
        public IWorkflowAction CreateForm([WorkflowExpression] Func<bool> runCalculations = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodyoverrideDefaultFormName = null, [WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<string> bodyassignmentid = null, [WorkflowExpression] Func<string> bodyassignmenttype = null, [WorkflowExpression] Func<string> bodyassignmenturl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateForm(WorkflowExpression<bool> runCalculations = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<bool> bodyoverrideDefaultFormName = null, WorkflowExpression<string> bodytemplateId = null, WorkflowExpression<string> bodyassignmentid = null, WorkflowExpression<string> bodyassignmenttype = null, WorkflowExpression<string> bodyassignmenturl = null)
        {
            WorkflowExpression.Validate(runCalculations, nameof(runCalculations), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyoverrideDefaultFormName, nameof(bodyoverrideDefaultFormName), required: false);
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            WorkflowExpression.Validate(bodyassignmentid, nameof(bodyassignmentid), required: false);
            WorkflowExpression.Validate(bodyassignmenttype, nameof(bodyassignmenttype), required: false);
            WorkflowExpression.Validate(bodyassignmenturl, nameof(bodyassignmenturl), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        [WorkflowExpressionFactory(nameof(__BuildGetForm))]
        public IBodyWorkflowAction<FormDto> GetForm([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FormDto> __BuildGetForm(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<FormDto>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/formz/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FormDto>(callPayload);
            });
        }
    }

    public class GoformzTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildFormCompleted))]
        public IWorkflowTrigger FormCompleted([WorkflowExpression] Func<string> bodyentityId,[WorkflowExpression] Func<string> bodyeventType = null,[WorkflowExpression] Func<bool> bodyenabled = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildFormCompleted(WorkflowExpression<string> bodyentityId,WorkflowExpression<string> bodyeventType = null,WorkflowExpression<bool> bodyenabled = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyentityId, nameof(bodyentityId), required: true);
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: false);
            WorkflowExpression.Validate(bodyenabled, nameof(bodyenabled), required: false);
            return new DeferredWorkflowTrigger(() =>
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

                body["targetUrl"] = "#{listCallbackUrl()}";
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