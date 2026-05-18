// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// A marker token representing the current item in a ForEach loop.
    /// The expression converter recognizes this type and emits a <c>item()</c> function call.
    /// </summary>
    internal class ForEachItemToken : JValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForEachItemToken"/> class.
        /// </summary>
        internal ForEachItemToken() : base((object)null)
        {
        }
    }
}
