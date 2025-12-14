// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the connections.json structure for Azure Logic Apps.
    /// </summary>
    public class ConnectionsArtifacts
    {
        /// <summary>
        /// Gets or sets the managed API connections.
        /// </summary>
        [JsonProperty("managedApiConnections")]
        public Dictionary<string, ManagedApiConnection> ManagedApiConnections { get; set; }
            = new Dictionary<string, ManagedApiConnection>();
    }

    /// <summary>
    /// Represents a managed API connection configuration.
    /// </summary>
    public class ManagedApiConnection
    {
        /// <summary>
        /// Gets or sets the API information.
        /// </summary>
        [JsonProperty("api")]
        public ApiInfo Api { get; set; }

        /// <summary>
        /// Gets or sets the connection information.
        /// </summary>
        [JsonProperty("connection")]
        public ConnectionInfo Connection { get; set; }

        /// <summary>
        /// Gets or sets the connection runtime URL.
        /// </summary>
        [JsonProperty("connectionRuntimeUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionRuntimeUrl { get; set; }

        /// <summary>
        /// Gets or sets the authentication information.
        /// </summary>
        [JsonProperty("authentication")]
        public AuthenticationInfo Authentication { get; set; }
    }

    /// <summary>
    /// Represents API information for a connection.
    /// </summary>
    public class ApiInfo
    {
        /// <summary>
        /// Gets or sets the API resource ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    /// <summary>
    /// Represents connection information.
    /// </summary>
    public class ConnectionInfo
    {
        /// <summary>
        /// Gets or sets the connection resource ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    /// <summary>
    /// Represents authentication information for a connection.
    /// </summary>
    public class AuthenticationInfo
    {
        /// <summary>
        /// Gets or sets the authentication type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; } = "ManagedServiceIdentity";
    }
}
