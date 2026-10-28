//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onetimesecretip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnetimesecretipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<GenerateSecretResponse> GenerateSecret(Expression<Func<string>> passphrase = null, Expression<Func<int>> ttl = null, Expression<Func<string>> recipient = null)
        {
            var __workflow_passphrase = WorkflowExpression.Compile(passphrase, nameof(passphrase), required: false);
            var __workflow_ttl = WorkflowExpression.Compile(ttl, nameof(ttl), required: false);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            return new DeferredBodyAction<GenerateSecretResponse>(() =>
            {
                var apiCallPath = "/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_passphrase != null)
                    callPayload.Queries["passphrase"] = ExpressionConverter.Convert(__workflow_passphrase);
                if (__workflow_ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(__workflow_ttl);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                return new ApiConnectionAction<GenerateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<CreateSecretResponse> CreateSecret(Expression<Func<string>> secret, Expression<Func<string>> ttl = null, Expression<Func<string>> passphrase = null, Expression<Func<string>> recipient = null)
        {
            var __workflow_secret = WorkflowExpression.Compile(secret, nameof(secret), required: true);
            var __workflow_ttl = WorkflowExpression.Compile(ttl, nameof(ttl), required: false);
            var __workflow_passphrase = WorkflowExpression.Compile(passphrase, nameof(passphrase), required: false);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            return new DeferredBodyAction<CreateSecretResponse>(() =>
            {
                var apiCallPath = "/share";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["secret"] = ExpressionConverter.Convert(__workflow_secret);
                if (__workflow_ttl != null)
                    callPayload.Queries["ttl"] = ExpressionConverter.Convert(__workflow_ttl);
                if (__workflow_passphrase != null)
                    callPayload.Queries["passphrase"] = ExpressionConverter.Convert(__workflow_passphrase);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                return new ApiConnectionAction<CreateSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveSecretResponse> RetrieveSecret(Expression<Func<string>> sECRETKEY, Expression<Func<string>> passphrase = null)
        {
            var __workflow_sECRETKEY = WorkflowExpression.Compile(sECRETKEY, nameof(sECRETKEY), required: true);
            var __workflow_passphrase = WorkflowExpression.Compile(passphrase, nameof(passphrase), required: false);
            return new DeferredBodyAction<RetrieveSecretResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/secret/{0}", __workflow_sECRETKEY.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_passphrase != null)
                    callPayload.Queries["passphrase"] = ExpressionConverter.Convert(__workflow_passphrase);
                return new ApiConnectionAction<RetrieveSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveMetadataResponse> RetrieveMetadata(Expression<Func<string>> mETADATAKEY)
        {
            var __workflow_mETADATAKEY = WorkflowExpression.Compile(mETADATAKEY, nameof(mETADATAKEY), required: true);
            return new DeferredBodyAction<RetrieveMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/private/{0}", __workflow_mETADATAKEY.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RetrieveMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<BurnASecretResponse> BurnASecret(Expression<Func<string>> mETADATAKEY)
        {
            var __workflow_mETADATAKEY = WorkflowExpression.Compile(mETADATAKEY, nameof(mETADATAKEY), required: true);
            return new DeferredBodyAction<BurnASecretResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/private/{0}/burn", __workflow_mETADATAKEY.WithUrlEncoding(1)));
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
