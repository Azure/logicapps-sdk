//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Onetimesecretip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OnetimesecretipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<GenerateSecretResponse> GenerateSecret(Expression<Func<string>> passphrase = null, Expression<Func<int>> ttl = null, Expression<Func<string>> recipient = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<CreateSecretResponse> CreateSecret(Expression<Func<string>> secret, Expression<Func<string>> ttl = null, Expression<Func<string>> passphrase = null, Expression<Func<string>> recipient = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveSecretResponse> RetrieveSecret(Expression<Func<string>> sECRETKEY, Expression<Func<string>> passphrase = null)
        {
            var apiCallPath = String.Format("/secret/{0}", ExpressionConverter.ConvertWithUrlEncoding(sECRETKEY, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (passphrase != null)
                callPayload.Queries["passphrase"] = ExpressionConverter.Convert(passphrase);
            return new ApiConnectionAction<RetrieveSecretResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveMetadataResponse> RetrieveMetadata(Expression<Func<string>> mETADATAKEY)
        {
            var apiCallPath = String.Format("/private/{0}", ExpressionConverter.ConvertWithUrlEncoding(mETADATAKEY, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RetrieveMetadataResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<BurnASecretResponse> BurnASecret(Expression<Func<string>> mETADATAKEY)
        {
            var apiCallPath = String.Format("/private/{0}/burn", ExpressionConverter.ConvertWithUrlEncoding(mETADATAKEY, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BurnASecretResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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