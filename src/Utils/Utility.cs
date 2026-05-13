// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Reflection;
    using System.Runtime.Serialization;

    /// <summary>
    /// Utility class for common functions.
    /// </summary>
    internal class Utility
    {
        /// <summary>
        /// Gets the unique operation name.
        /// </summary>
        public static string GetUniqueOperationName(bool isTrigger = false)
        {
            // Hash the current Unix timestamp and clip to 8 digits
            var unixTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            var guidBytes = Guid.NewGuid().ToByteArray();
            var timestampBytes = BitConverter.GetBytes(unixTimestamp);
            var combinedBytes = timestampBytes.Concat(guidBytes).ToArray();
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hash = sha256.ComputeHash(combinedBytes);
                // Take first 4 bytes and convert to UInt32, then clip to 8 digits
                var number = BitConverter.ToUInt32(hash, 0) % 100000000;

                return isTrigger
                    ? $"trigger_{number:D8}"
                    : $"action_{number:D8}";
            }
        }

        /// <summary>
        /// Gets the EnumMember value of an enum or name if none exists.
        /// </summary>
        /// <param name="value">The enum value</param>
        /// <returns>Either the value of EnumMember or the member name.</returns>
        public static string GetEnumMemberValue<T>(T value) where T : Enum
        {
            var type = value.GetType();
            var member = type.GetMember(value.ToString());
            if (member.Length > 0)
            {
                var attr = member[0].GetCustomAttribute<EnumMemberAttribute>(false);
                if (attr != null && !string.IsNullOrEmpty(attr.Value))
                    return attr.Value;
            }
            return value.ToString();
        }
        
        public static Dictionary<string, FlowStatus[]> GetRunAfterConfiguration(RunAfter[] runAfter)
        {
            return runAfter
                .Where(spec => spec?.Action?.Name != null && spec.Status != null)
                .ToDictionary(spec => spec.Action.Name, spec => spec.Status);
        }
    }
}
