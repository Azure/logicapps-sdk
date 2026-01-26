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
        public IBodyWorkflowAction<EloketExport> EloketExport(Expression<Func<int>> formid, Expression<Func<int>> entryid = null, Expression<Func<string>> lastsynch = null, Expression<Func<bool>> includeFiles = null, Expression<Func<bool>> includePDF = null, Expression<Func<bool>> includeHTML = null, Expression<Func<int>> page = null)
        {
            var apiCallPath = "/api/Export/eloketjson";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["formid"] = ExpressionConverter.Convert(formid);
            if (entryid != null)
                callPayload.Queries["entryid"] = ExpressionConverter.Convert(entryid);
            if (lastsynch != null)
                callPayload.Queries["lastsynch"] = ExpressionConverter.Convert(lastsynch);
            if (includeFiles != null)
                callPayload.Queries["includeFiles"] = ExpressionConverter.Convert(includeFiles);
            if (includePDF != null)
                callPayload.Queries["includePDF"] = ExpressionConverter.Convert(includePDF);
            if (includeHTML != null)
                callPayload.Queries["includeHTML"] = ExpressionConverter.Convert(includeHTML);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            return new ApiConnectionAction<EloketExport>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lcpicordis")]
        public IBodyWorkflowAction<bool> TriggerUnsubscribe(Expression<Func<int>> formid, Expression<Func<string>> bodywebhookurl = null)
        {
            var apiCallPath = String.Format("/api/export/eloket/{0}/unsubscribe", ExpressionConverter.ConvertWithUrlEncoding(formid, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodywebhookurl != null)
            {
                body["webhookurl"] = ExpressionConverter.ConvertO(bodywebhookurl);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<bool>(callPayload);
        }
    }

    public class LcpicordisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<bool> NewEntry(Expression<Func<int>> formid, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/api/export/eloket/{0}/hooks", ExpressionConverter.ConvertWithUrlEncoding(formid, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookURL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<bool>(callPayload, triggerName, recurrence);
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