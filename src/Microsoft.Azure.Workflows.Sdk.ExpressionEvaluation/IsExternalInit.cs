// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

#if !NET5_0_OR_GREATER
namespace System.Runtime.CompilerServices
{
    using System.ComponentModel;

    /// <summary>
    /// Polyfill required by the C# compiler to emit <c>init</c>-only property setters (used by
    /// positional records) when targeting frameworks (e.g. netstandard2.0) that do not ship this
    /// type. Not needed on net5.0+.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit
    {
    }
}
#endif
