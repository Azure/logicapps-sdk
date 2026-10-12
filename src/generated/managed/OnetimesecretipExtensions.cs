//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onetimesecretip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnetimesecretipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateSecret))]
        public IBodyWorkflowAction<GenerateSecretResponse> GenerateSecret([WorkflowExpression] Func<string> passphrase = null, [WorkflowExpression] Func<int> ttl = null, [WorkflowExpression] Func<string> recipient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateSecretResponse> __BuildGenerateSecret(WorkflowExpression<string> passphrase = null, WorkflowExpression<int> ttl = null, WorkflowExpression<string> recipient = null)
        {
            WorkflowExpression.Validate(passphrase, nameof(passphrase), required: false);
            WorkflowExpression.Validate(ttl, nameof(ttl), required: false);
            WorkflowExpression.Validate(recipient, nameof(recipient), required: false);
            return new DeferredBodyAction<GenerateSecretResponse>(() =>
            {
                var apiCallPath = "/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (passphrase != null)
                    callPayload.Queries["passphrase"] = ExpressionConverter.Convert(passphrase);
                if (ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(ttl);
                if (recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(recipient);
                return new ApiConnectionAction<GenerateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSecret))]
        public IBodyWorkflowAction<CreateSecretResponse> CreateSecret([WorkflowExpression] Func<string> secret, [WorkflowExpression] Func<string> ttl = null, [WorkflowExpression] Func<string> passphrase = null, [WorkflowExpression] Func<string> recipient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSecretResponse> __BuildCreateSecret(WorkflowExpression<string> secret, WorkflowExpression<string> ttl = null, WorkflowExpression<string> passphrase = null, WorkflowExpression<string> recipient = null)
        {
            WorkflowExpression.Validate(secret, nameof(secret), required: true);
            WorkflowExpression.Validate(ttl, nameof(ttl), required: false);
            WorkflowExpression.Validate(passphrase, nameof(passphrase), required: false);
            WorkflowExpression.Validate(recipient, nameof(recipient), required: false);
            return new DeferredBodyAction<CreateSecretResponse>(() =>
            {
                var apiCallPath = "/share";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["secret"] = ExpressionConverter.Convert(secret);
                if (ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(ttl);
                if (passphrase != null)
                    callPayload.Queries["passphrase"] = ExpressionConverter.Convert(passphrase);
                if (recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(recipient);
                return new ApiConnectionAction<CreateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveSecret))]
        public IBodyWorkflowAction<RetrieveSecretResponse> RetrieveSecret([WorkflowExpression] Func<string> sECRETKEY, [WorkflowExpression] Func<string> passphrase = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveSecretResponse> __BuildRetrieveSecret(WorkflowExpression<string> sECRETKEY, WorkflowExpression<string> passphrase = null)
        {
            WorkflowExpression.Validate(sECRETKEY, nameof(sECRETKEY), required: true);
            WorkflowExpression.Validate(passphrase, nameof(passphrase), required: false);
            return new DeferredBodyAction<RetrieveSecretResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/secret/{0}", ExpressionConverter.ConvertWithUrlEncoding(sECRETKEY, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (passphrase != null)
                    callPayload.Queries["passphrase"] = ExpressionConverter.Convert(passphrase);
                return new ApiConnectionAction<RetrieveSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveMetadata))]
        public IBodyWorkflowAction<RetrieveMetadataResponse> RetrieveMetadata([WorkflowExpression] Func<string> mETADATAKEY)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveMetadataResponse> __BuildRetrieveMetadata(WorkflowExpression<string> mETADATAKEY)
        {
            WorkflowExpression.Validate(mETADATAKEY, nameof(mETADATAKEY), required: true);
            return new DeferredBodyAction<RetrieveMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/private/{0}", ExpressionConverter.ConvertWithUrlEncoding(mETADATAKEY, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        [WorkflowExpressionFactory(nameof(__BuildBurnASecret))]
        public IBodyWorkflowAction<BurnASecretResponse> BurnASecret([WorkflowExpression] Func<string> mETADATAKEY)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BurnASecretResponse> __BuildBurnASecret(WorkflowExpression<string> mETADATAKEY)
        {
            WorkflowExpression.Validate(mETADATAKEY, nameof(mETADATAKEY), required: true);
            return new DeferredBodyAction<BurnASecretResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/private/{0}/burn", ExpressionConverter.ConvertWithUrlEncoding(mETADATAKEY, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BurnASecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveRecentMetadataResponseItem[]> RetrieveRecentMetadata()
        {
            var apiCallPath = "/private/recent";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RetrieveRecentMetadataResponseItem[]>(callPayload);
        }
    }

    public class OnetimesecretipTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateSecretResponse
    {
        [JsonProperty("custid")]
        public string Custid { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata_key")]
        public string MetadataKey { get; set; }

        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }
    }

    public class CreateSecretResponse
    {
        [JsonProperty("custid")]
        public string Custid { get; set; }

        [JsonProperty("metadata_key")]
        public string MetadataKey { get; set; }

        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("metadata_ttl")]
        public int MetadataTtl { get; set; }

        [JsonProperty("secret_ttl")]
        public int SecretTtl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("recipient")]
        public JToken[] Recipient { get; set; }

        [JsonProperty("passphrase_required")]
        public bool PassphraseRequired { get; set; }
    }

    public class RetrieveSecretResponse
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }
    }

    public class RetrieveMetadataResponse
    {
        [JsonProperty("custid")]
        public string Custid { get; set; }

        [JsonProperty("metadata_key")]
        public string MetadataKey { get; set; }

        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("metadata_ttl")]
        public int MetadataTtl { get; set; }

        [JsonProperty("secret_ttl")]
        public int SecretTtl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("recipient")]
        public JToken[] Recipient { get; set; }

        [JsonProperty("passphrase_required")]
        public bool PassphraseRequired { get; set; }
    }

    public class BurnASecretResponse
    {
        [JsonProperty("state")]
        public BurnASecretResponseStateType State { get; set; }

        [JsonProperty("secret_shortkey")]
        public string SecretShortkey { get; set; }
    }

    public class BurnASecretResponseStateType
    {
        [JsonProperty("custid")]
        public string Custid { get; set; }

        [JsonProperty("metadata_key")]
        public string MetadataKey { get; set; }

        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("metadata_ttl")]
        public int MetadataTtl { get; set; }

        [JsonProperty("secret_ttl")]
        public int SecretTtl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("recipient")]
        public JToken[] Recipient { get; set; }
    }

    public class RetrieveRecentMetadataResponseItem
    {
        [JsonProperty("custid")]
        public string Custid { get; set; }

        [JsonProperty("metadata_key")]
        public string MetadataKey { get; set; }

        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonProperty("metadata_ttl")]
        public int MetadataTtl { get; set; }

        [JsonProperty("secret_ttl")]
        public int SecretTtl { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("recipient")]
        public JToken[] Recipient { get; set; }

        [JsonProperty("received")]
        public int Received { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Onetimesecretip;

    public partial class WorkflowManagedActions
    {
        public OnetimesecretipActions Onetimesecretip(string connectionId) => new OnetimesecretipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OnetimesecretipTriggers Onetimesecretip(string connectionId) => new OnetimesecretipTriggers(connectionId);
    }
}