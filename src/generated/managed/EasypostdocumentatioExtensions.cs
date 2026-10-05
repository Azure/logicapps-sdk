//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easypostdocumentatio
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasypostdocumentatioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        [WorkflowExpressionFactory(nameof(__BuildGetSessionId))]
        public IBodyWorkflowAction<GetSessionIdResponse> GetSessionId([WorkflowExpression] Func<string> account)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSessionIdResponse> __BuildGetSessionId(WorkflowValue<string> account)
        {
            WorkflowValue.Validate(account, nameof(account), required: true);
            return new DeferredBodyAction<GetSessionIdResponse>(() =>
            {
                var apiCallPath = "/publicinterface/get_session_id.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["account"] = ExpressionConverter.Convert(account);
                return new ApiConnectionAction<GetSessionIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        [WorkflowExpressionFactory(nameof(__BuildPutSessionUpload))]
        public IWorkflowAction PutSessionUpload([WorkflowExpression] Func<string> sessionId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> fileContent = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildPutSessionUpload(WorkflowValue<string> sessionId, WorkflowValue<string> fileName, WorkflowValue<string> fileContent = null)
        {
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            WorkflowValue.Validate(fileName, nameof(fileName), required: true);
            WorkflowValue.Validate(fileContent, nameof(fileContent), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/direct_upload/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(sessionId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileName, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(fileContent);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        [WorkflowExpressionFactory(nameof(__BuildEndSession))]
        public IBodyWorkflowAction<EndSessionResponse> EndSession([WorkflowExpression] Func<string> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EndSessionResponse> __BuildEndSession(WorkflowValue<string> sessionId)
        {
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<EndSessionResponse>(() =>
            {
                var apiCallPath = "/publicinterface/end_session.json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["session_id"] = ExpressionConverter.Convert(sessionId);
                return new ApiConnectionAction<EndSessionResponse>(callPayload);
            });
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
