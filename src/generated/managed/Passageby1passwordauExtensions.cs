//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Passageby1passwordau
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Passageby1passwordauActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "passageby1passwordau")]
        [WorkflowExpressionFactory(nameof(__BuildGetOpenIdConfiguration))]
        public IBodyWorkflowAction<OpenIdConfiguration> GetOpenIdConfiguration([WorkflowExpression] Func<string> appId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OpenIdConfiguration> __BuildGetOpenIdConfiguration(WorkflowExpression<string> appId)
        {
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            return new DeferredBodyAction<OpenIdConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/apps/{0}/.well-known/openid-configuration", ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OpenIdConfiguration>(callPayload);
            });
        }
    }

    public class Passageby1passwordauTriggers([ConnectionName] string connectionId)
    {
    }

    public class OpenIdConfiguration
    {
        [JsonProperty("authorization_endpoint")]
        public string AuthorizationEndpoint { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("jwks_uri")]
        public string JwksUri { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Passageby1passwordau;

    public partial class WorkflowManagedActions
    {
        public Passageby1passwordauActions Passageby1passwordau(string connectionId) => new Passageby1passwordauActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Passageby1passwordauTriggers Passageby1passwordau(string connectionId) => new Passageby1passwordauTriggers(connectionId);
    }
}