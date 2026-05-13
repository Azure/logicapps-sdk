// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk;

using Newtonsoft.Json.Linq;

/// <summary>
/// These functions are meant to be used inside an expression tree for conversion to a Logic App expression string.
/// </summary>
public static class WorkflowFunctions
{
    public static T ToJson<T>(string input) => default;
    public static JToken ToJson(string input) => default;
}