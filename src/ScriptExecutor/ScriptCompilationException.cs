// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;

    /// <summary>
    /// The script compilation exception.
    /// </summary>
    public class ScriptCompilationException :  Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptCompilationException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public ScriptCompilationException(string message)
            : base(message)
        {
        }
    }
}
