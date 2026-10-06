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
        public IBodyWorkflowAction<string> ExportForm([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodypages = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/formz/{0}/exports", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypages != null)
                {
                    body["pages"] = SourceExpressionConverter.ConvertToken(bodypages);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IWorkflowAction CreateForm([WorkflowExpression] Func<bool> runCalculations = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<bool> bodyoverrideDefaultFormName = null, [WorkflowExpression] Func<string> bodytemplateId = null, [WorkflowExpression] Func<string> bodyassignmentid = null, [WorkflowExpression] Func<string> bodyassignmenttype = null, [WorkflowExpression] Func<string> bodyassignmenturl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/formz";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["runCalculations"] = Convert.ToString(false);
                if (runCalculations != null)
                    callPayload.Queries["runCalculations"] = SourceExpressionConverter.ConvertO(runCalculations);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyoverrideDefaultFormName != null)
                {
                    body["overrideDefaultFormName"] = SourceExpressionConverter.ConvertToken(bodyoverrideDefaultFormName);
                    bodypropCount++;
                }

                if (bodytemplateId != null)
                {
                    body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                var assignmentObject = new JObject();
                var assignmentObjectpropCount = 0;
                if (bodyassignmentid != null)
                {
                    assignmentObject["id"] = SourceExpressionConverter.ConvertToken(bodyassignmentid);
                    assignmentObjectpropCount++;
                }

                if (bodyassignmenttype != null)
                {
                    assignmentObject["type"] = SourceExpressionConverter.ConvertToken(bodyassignmenttype);
                    assignmentObjectpropCount++;
                }

                if (bodyassignmenturl != null)
                {
                    assignmentObject["url"] = SourceExpressionConverter.ConvertToken(bodyassignmenturl);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "goformz")]
        public IBodyWorkflowAction<FormDto> GetForm([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/formz/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<FormDto>(BuildSourceInput);
        }
    }

    public class GoformzTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger FormCompleted([WorkflowExpression] Func<string> bodyentityId, [WorkflowExpression] Func<string> bodyeventType = null, [WorkflowExpression] Func<bool> bodyenabled = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventType != null)
                {
                    body["eventType"] = SourceExpressionConverter.ConvertToken(bodyeventType);
                    bodypropCount++;
                }

                body["targetUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["entityId"] = SourceExpressionConverter.ConvertToken(bodyentityId);
                if (bodyenabled != null)
                {
                    body["enabled"] = SourceExpressionConverter.ConvertToken(bodyenabled);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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