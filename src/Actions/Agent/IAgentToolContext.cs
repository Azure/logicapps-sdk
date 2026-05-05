// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Provides access to agent tool parameters for use in expression conversion.
    /// </summary>
    /// <typeparam name="T">The type of the parameters used to configure the agent tool.</typeparam>
    public interface IAgentToolContext<T>
    {
        /// <summary>
        /// The parameters used to configure the agent tool.
        /// </summary>
        T Parameters { get; }
    }

    /// <summary>
    /// Default implementation of <see cref="IAgentToolContext{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of the parameters.</typeparam>
    public class AgentToolContext<T> : IAgentToolContext<T>
    {
        /// <summary>
        /// Gets the parameters for the agent tool.
        /// </summary>
        public T Parameters { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentToolContext{T}"/> class.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        public AgentToolContext(T parameters)
        {
            this.Parameters = parameters;
        }
    }
}
