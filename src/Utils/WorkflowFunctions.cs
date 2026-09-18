// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk;

using Newtonsoft.Json.Linq;

/// <summary>
/// SDK intrinsics recognized by the workflow source compiler inside annotated authoring expressions.
/// These methods are not executable generation-time helpers.
/// </summary>
public static class WorkflowFunctions
{
    public static T ToJson<T>(string input) =>
        throw new NotSupportedException("WorkflowFunctions.ToJson requires the SDK workflow source compiler; it cannot be invoked directly.");

    public static JToken ToJson(string input) =>
        throw new NotSupportedException("WorkflowFunctions.ToJson requires the SDK workflow source compiler; it cannot be invoked directly.");
}