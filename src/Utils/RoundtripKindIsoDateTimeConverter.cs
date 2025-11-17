// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Globalization;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A custom JSON date/time converter that ensures round-trip DateTime kind preservation
    /// and uses invariant culture for serialization and deserialization.
    /// </summary>
    public class RoundtripKindIsoDateTimeConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoundtripKindIsoDateTimeConverter"/> class.
        /// Sets the DateTimeStyles to RoundtripKind and uses invariant culture.
        /// </summary>
        public RoundtripKindIsoDateTimeConverter()
        {
            base.DateTimeStyles = DateTimeStyles.RoundtripKind;
            base.Culture = CultureInfo.InvariantCulture;
        }
    }
}
