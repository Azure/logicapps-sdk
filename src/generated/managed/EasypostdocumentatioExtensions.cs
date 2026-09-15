//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Easypostdocumentatio
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EasypostdocumentatioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        public IBodyWorkflowAction<GetSessionIdResponse> GetSessionId(Expression<Func<string>> account)
        {
            var apiCallPath = "/publicinterface/get_session_id.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["account"] = CSharpExpressionConverter.ConvertO(account);
            return new ApiConnectionAction<GetSessionIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        public IWorkflowAction PutSessionUpload(Expression<Func<string>> sessionId, Expression<Func<string>> fileName, Expression<Func<string>> fileContent = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/direct_upload/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sessionId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileName, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fileContent);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "easypostdocumentatio")]
        public IBodyWorkflowAction<EndSessionResponse> EndSession(Expression<Func<string>> sessionId)
        {
            var apiCallPath = "/publicinterface/end_session.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["session_id"] = CSharpExpressionConverter.ConvertO(sessionId);
            return new ApiConnectionAction<EndSessionResponse>(callPayload);
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