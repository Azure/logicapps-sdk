//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lcpicordis
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LcpicordisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lcpicordis")]
        public IBodyWorkflowAction<EloketExport> EloketExport([WorkflowExpression] Func<int> formid, [WorkflowExpression] Func<int> entryid = null, [WorkflowExpression] Func<string> lastsynch = null, [WorkflowExpression] Func<bool> includeFiles = null, [WorkflowExpression] Func<bool> includePDF = null, [WorkflowExpression] Func<bool> includeHTML = null, [WorkflowExpression] Func<int> page = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Export/eloketjson";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["formid"] = SourceExpressionConverter.ConvertO(formid);
                if (entryid != null)
                    callPayload.Queries["entryid"] = SourceExpressionConverter.ConvertO(entryid);
                if (lastsynch != null)
                    callPayload.Queries["lastsynch"] = SourceExpressionConverter.ConvertO(lastsynch);
                if (includeFiles != null)
                    callPayload.Queries["includeFiles"] = SourceExpressionConverter.ConvertO(includeFiles);
                if (includePDF != null)
                    callPayload.Queries["includePDF"] = SourceExpressionConverter.ConvertO(includePDF);
                if (includeHTML != null)
                    callPayload.Queries["includeHTML"] = SourceExpressionConverter.ConvertO(includeHTML);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                return callPayload;
            }

            return new ApiConnectionAction<EloketExport>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lcpicordis")]
        public IBodyWorkflowAction<bool> TriggerUnsubscribe([WorkflowExpression] Func<int> formid, [WorkflowExpression] Func<string> bodywebhookurl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/export/eloket/{0}/unsubscribe", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(formid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodywebhookurl != null)
                {
                    body["webhookurl"] = SourceExpressionConverter.ConvertToken(bodywebhookurl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<bool>(BuildSourceInput);
        }
    }

    public class LcpicordisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<bool> NewEntry([WorkflowExpression] Func<int> formid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/export/eloket/{0}/hooks", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(formid, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["webhookURL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<bool>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class EloketExport
    {
        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("formID")]
        public int FormID { get; set; }

        [JsonProperty("formTitle")]
        public string FormTitle { get; set; }

        [JsonProperty("responseStatus")]
        public string ResponseStatus { get; set; }

        [JsonProperty("data")]
        public JToken[] Data { get; set; }

        [JsonProperty("fields")]
        public EloketField[] Fields { get; set; }
    }

    public class EloketField
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("fieldDescription")]
        public string FieldDescription { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lcpicordis;

    public partial class WorkflowManagedActions
    {
        public LcpicordisActions Lcpicordis(string connectionId) => new LcpicordisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LcpicordisTriggers Lcpicordis(string connectionId) => new LcpicordisTriggers(connectionId);
    }
}