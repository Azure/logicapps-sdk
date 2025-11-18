//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// The role of prompt message.
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// The placeholder unspecified role.
        /// </summary>
        Unspecified,

        /// <summary>
        /// The internal role that instructs or sets the behavior of the agent.
        /// </summary>
        InternalSystem,

        /// <summary>
        /// The role that instructs or sets the behavior of the agent.
        /// </summary>
        System,

        /// <summary>
        /// The role that provides input from user to agent.
        /// </summary>
        User,

        /// <summary>
        /// The tool invocation role.
        /// </summary>
        ToolInvocation,

        /// <summary>
        /// The role that provides additional information and references for chat completion.
        /// </summary>
        Tool,

        /// <summary>
        /// The role that provides the response from the agent.
        /// </summary>
        Assistant,
    }
}
