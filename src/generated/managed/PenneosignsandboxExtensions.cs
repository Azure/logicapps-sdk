//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Penneosignsandbox
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PenneosignsandboxActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "penneosignsandbox")]
        public IBodyWorkflowAction<CaseFileDetails> GetCaseFileDetails([WorkflowExpression] Func<int> caseFileId)
        {
            SourceExpression.Validate(caseFileId, nameof(caseFileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v3/casefiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(caseFileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CaseFileDetails>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "penneosignsandbox")]
        public IBodyWorkflowAction<DocumentContentInfo> DownloadDocument([WorkflowExpression] Func<int> documentId, [WorkflowExpression] Func<bool> signed = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(signed, nameof(signed), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/v1/documents/{0}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(documentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["signed"] = Convert.ToString(true);
                if (signed != null)
                    callPayload.Queries["signed"] = SourceExpressionConverter.ConvertO(signed);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentContentInfo>(BuildSourceInput);
        }
    }

    public class PenneosignsandboxTriggers([ConnectionName] string connectionId)
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Penneosignsandbox;

    public partial class WorkflowManagedActions
    {
        public PenneosignsandboxActions Penneosignsandbox(string connectionId) => new PenneosignsandboxActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PenneosignsandboxTriggers Penneosignsandbox(string connectionId) => new PenneosignsandboxTriggers(connectionId);
    }
}