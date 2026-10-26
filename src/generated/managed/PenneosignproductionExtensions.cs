//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Penneosignproduction
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PenneosignproductionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "penneosignproduction")]
        public IBodyWorkflowAction<CaseFileDetails, ApiConnectionActionConfiguration> GetCaseFileDetails(Expression<Func<int>> caseFileId)
        {
            var __workflow_caseFileId = WorkflowExpression.Compile(caseFileId, nameof(caseFileId), required: true);
            return new DeferredBodyAction<CaseFileDetails, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v3/casefiles/{0}", __workflow_caseFileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CaseFileDetails>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "penneosignproduction")]
        public IBodyWorkflowAction<DocumentContentInfo, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<int>> documentId, Expression<Func<bool>> signed = null)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_signed = WorkflowExpression.Compile(signed, nameof(signed), required: false);
            return new DeferredBodyAction<DocumentContentInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/v1/documents/{0}/content", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["signed"] = Convert.ToString(true);
                if (__workflow_signed != null)
                    callPayload.Queries["signed"] = ExpressionConverter.Convert(__workflow_signed);
                return new ApiConnectionAction<DocumentContentInfo>(callPayload);
            });
        }
    }

    public class PenneosignproductionTriggers([ConnectionName] string connectionId)
    {
    }

    public class CaseFileDetails
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonProperty("signers")]
        public SignerDetails[] Signers { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("documents")]
        public DocumentDetails[] Documents { get; set; }

        [JsonProperty("expireAt")]
        public int ExpireAt { get; set; }

        [JsonProperty("ccRecipients")]
        public CcRecipient[] CcRecipients { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("activated")]
        public int Activated { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("completed")]
        public int Completed { get; set; }
    }

    public class SignerDetails
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("signingRequest")]
        public SigningRequestDetails SigningRequest { get; set; }
    }

    public class SigningRequestDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }
    }

    public class DocumentDetails
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("signable")]
        public bool Signable { get; set; }
    }

    public class CcRecipient
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class DocumentContentInfo
    {
        [JsonProperty("content")]
        public string DocumentContent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Penneosignproduction;

    public partial class WorkflowManagedActions
    {
        public PenneosignproductionActions Penneosignproduction(string connectionId) => new PenneosignproductionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PenneosignproductionTriggers Penneosignproduction(string connectionId) => new PenneosignproductionTriggers(connectionId);
    }
}