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
        public IBodyWorkflowAction<GenerateSecretResponse> GenerateSecret([WorkflowExpression] Func<string> passphrase = null, [WorkflowExpression] Func<int> ttl = null, [WorkflowExpression] Func<string> recipient = null)
        {
            SourceExpression.Validate(passphrase, nameof(passphrase), required: false);
            SourceExpression.Validate(ttl, nameof(ttl), required: false);
            SourceExpression.Validate(recipient, nameof(recipient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/generate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (passphrase != null)
                    callPayload.Queries["passphrase"] = SourceExpressionConverter.ConvertO(passphrase);
                if (ttl != null)
                    callPayload.Queries["ttl"] = SourceExpressionConverter.ConvertO(ttl);
                if (recipient != null)
                    callPayload.Queries["recipient"] = SourceExpressionConverter.ConvertO(recipient);
                return callPayload;
            }

            return new ApiConnectionAction<GenerateSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<CreateSecretResponse> CreateSecret([WorkflowExpression] Func<string> secret, [WorkflowExpression] Func<string> ttl = null, [WorkflowExpression] Func<string> passphrase = null, [WorkflowExpression] Func<string> recipient = null)
        {
            SourceExpression.Validate(secret, nameof(secret), required: true);
            SourceExpression.Validate(ttl, nameof(ttl), required: false);
            SourceExpression.Validate(passphrase, nameof(passphrase), required: false);
            SourceExpression.Validate(recipient, nameof(recipient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/share";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["secret"] = SourceExpressionConverter.ConvertO(secret);
                if (ttl != null)
                    callPayload.Queries["ttl"] = SourceExpressionConverter.ConvertO(ttl);
                if (passphrase != null)
                    callPayload.Queries["passphrase"] = SourceExpressionConverter.ConvertO(passphrase);
                if (recipient != null)
                    callPayload.Queries["recipient"] = SourceExpressionConverter.ConvertO(recipient);
                return callPayload;
            }

            return new ApiConnectionAction<CreateSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveSecretResponse> RetrieveSecret([WorkflowExpression] Func<string> sECRETKEY, [WorkflowExpression] Func<string> passphrase = null)
        {
            SourceExpression.Validate(sECRETKEY, nameof(sECRETKEY), required: true);
            SourceExpression.Validate(passphrase, nameof(passphrase), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/secret/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sECRETKEY, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (passphrase != null)
                    callPayload.Queries["passphrase"] = SourceExpressionConverter.ConvertO(passphrase);
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveSecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveMetadataResponse> RetrieveMetadata([WorkflowExpression] Func<string> mETADATAKEY)
        {
            SourceExpression.Validate(mETADATAKEY, nameof(mETADATAKEY), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/private/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mETADATAKEY, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<BurnASecretResponse> BurnASecret([WorkflowExpression] Func<string> mETADATAKEY)
        {
            SourceExpression.Validate(mETADATAKEY, nameof(mETADATAKEY), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/private/{0}/burn", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mETADATAKEY, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BurnASecretResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "onetimesecretip")]
        public IBodyWorkflowAction<RetrieveRecentMetadataResponseItem[]> RetrieveRecentMetadata()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/private/recent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RetrieveRecentMetadataResponseItem[]>(BuildSourceInput);
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