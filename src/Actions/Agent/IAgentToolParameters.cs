// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides access to agent tool parameters for use in expression conversion.
    /// </summary>
    /// <typeparam name="T">The type of the parameters used to configure the agent tool.</typeparam>
    public interface IAgentToolParameters<T>
    {
        /// <summary>
        /// The parameters used to configure the agent tool.
        /// </summary>
        T Parameters { get; }
    }

    /// <summary>
    /// Default implementation of <see cref="IAgentToolParameters{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the parameters.</typeparam>
    public class AgentToolParameters<T> : IAgentToolParameters<T>
    {
        /// <summary>
        /// Gets the parameters for the agent tool.
        /// </summary>
        public T Parameters { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolParameters{T}"/> class.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        public AgentToolParameters(T parameters)
        {
            this.Parameters = parameters;
        }
    }
}
