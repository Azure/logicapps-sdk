//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Passageby1passwordau
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Passageby1passwordauActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "passageby1passwordau")]
        public IBodyWorkflowAction<OpenIdConfiguration> GetOpenIdConfiguration([WorkflowExpression] Func<string> appId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/apps/{0}/.well-known/openid-configuration", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<OpenIdConfiguration>(BuildSourceInput);
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