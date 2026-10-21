//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easypostdocumentatio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasypostdocumentatioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        public IBodyWorkflowAction<GetSessionIdResponse> GetSessionId(Expression<Func<string>> account)
        {
            var __workflow_account = WorkflowExpression.Compile(account, nameof(account), required: true);
            return new DeferredBodyAction<GetSessionIdResponse>(() =>
            {
                var apiCallPath = "/publicinterface/get_session_id.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(__workflow_account);
                return new ApiConnectionAction<GetSessionIdResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        public IWorkflowAction PutSessionUpload(Expression<Func<string>> sessionId, Expression<Func<string>> fileName, Expression<Func<string>> fileContent = null)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_fileContent = WorkflowExpression.Compile(fileContent, nameof(fileContent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/direct_upload/{0}/{1}", __workflow_sessionId.WithUrlEncoding(1), __workflow_fileName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileContent);
                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        public IBodyWorkflowAction<EndSessionResponse> EndSession(Expression<Func<string>> sessionId)
        {
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<EndSessionResponse>(() =>
            {
                var apiCallPath = "/publicinterface/end_session.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["session_id"] = ExpressionConverter.Convert(__workflow_sessionId);
                return new ApiConnectionAction<EndSessionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class EasypostdocumentatioTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetSessionIdResponse
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }

    public class EndSessionResponse
    {
        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("files")]
        public EndSessionResponseFilesTypeItem[] Files { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errs")]
        public string[] Errs { get; set; }
    }

    public class EndSessionResponseFilesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sz")]
        public int Sz { get; set; }

        [JsonProperty("upld_sz")]
        public int UpldSz { get; set; }

        [JsonProperty("cl_sz")]
        public int ClSz { get; set; }

        [JsonProperty("chunks")]
        public int Chunks { get; set; }

        [JsonProperty("intent")]
        public int Intent { get; set; }

        [JsonProperty("first")]
        public double First { get; set; }

        [JsonProperty("last")]
        public double Last { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("apath")]
        public string Apath { get; set; }

        [JsonProperty("gpath")]
        public string Gpath { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Easypostdocumentatio;

    public partial class WorkflowManagedActions
    {
        public EasypostdocumentatioActions Easypostdocumentatio(string connectionId) => new EasypostdocumentatioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EasypostdocumentatioTriggers Easypostdocumentatio(string connectionId) => new EasypostdocumentatioTriggers(connectionId);
    }
}
