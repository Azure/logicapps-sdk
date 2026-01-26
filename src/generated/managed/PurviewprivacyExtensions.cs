//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Purviewprivacy
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PurviewprivacyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "purviewprivacy")]
        public IWorkflowAction UploadExportData(Expression<Func<string>> dsarId, Expression<Func<string>> taskId, Expression<Func<string>> bodyoutput, Expression<Func<string>> bodyfilename = null)
        {
            var apiCallPath = String.Format("/pa/dsars/{0}/tasks/{1}/upload", ExpressionConverter.ConvertWithUrlEncoding(dsarId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["output"] = ExpressionConverter.ConvertO(bodyoutput);
            if (bodyfilename != null)
            {
                body["filename"] = ExpressionConverter.ConvertO(bodyfilename);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "purviewprivacy")]
        public IWorkflowAction TaskStatus(Expression<Func<string>> dsarId, Expression<Func<string>> taskId, Expression<Func<int>> bodystatus, Expression<Func<string>> bodymessage = null)
        {
            var apiCallPath = String.Format("/pa/dsars/{0}/tasks/{1}/status", ExpressionConverter.ConvertWithUrlEncoding(dsarId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["status"] = ExpressionConverter.ConvertO(bodystatus);
            if (bodymessage != null)
            {
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "purviewprivacy")]
        public IBodyWorkflowAction<DsarDetailsSchema> GetDsarDetails(Expression<Func<string>> dsarId, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/pa/dsars/{0}/tasks/{1}/acquire", ExpressionConverter.ConvertWithUrlEncoding(dsarId, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DsarDetailsSchema>(callPayload);
        }
    }

    public class PurviewprivacyTriggers([ConnectionName] string connectionId)
    {
    }

    public class DsarDetailsSchema
    {
        [JsonProperty("dsarId")]
        public string DSARId { get; set; }

        [JsonProperty("taskId")]
        public string DSARTaskId { get; set; }

        [JsonProperty("assets")]
        public string[] Assets { get; set; }

        [JsonProperty("dataSubjectIdentifiers")]
        public DsarDetailsSchemaDataSubjectIdentifiersTypeItem[] DataSubjectIdentifiers { get; set; }
    }

    public class DsarDetailsSchemaDataSubjectIdentifiersTypeItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Purviewprivacy;

    public partial class WorkflowManagedActions
    {
        public PurviewprivacyActions Purviewprivacy(string connectionId) => new PurviewprivacyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PurviewprivacyTriggers Purviewprivacy(string connectionId) => new PurviewprivacyTriggers(connectionId);
    }
}