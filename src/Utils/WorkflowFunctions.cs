// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk;

using Newtonsoft.Json.Linq;

/// <summary>
/// The workflow source compiler replaces these methods with host context accessors.
/// </summary>
public static class WorkflowFunctions
{
    /// <summary>Parses a JSON string as the requested type.</summary>
    public static T ToJson<T>(string input) => throw Uncompiled();

    /// <summary>Parses a JSON string.</summary>
    public static JToken ToJson(string input) => throw Uncompiled();

    /// <summary>Gets a full action record.</summary>
    public static JToken Actions(string actionName) => throw Uncompiled();

    /// <summary>Gets the full trigger record.</summary>
    public static JToken Trigger() => throw Uncompiled();

    /// <summary>Lists the current trigger callback URL.</summary>
    public static string ListCallbackUrl() => throw Uncompiled();

    /// <summary>Gets an application setting.</summary>
    public static JToken AppSetting(string name) => throw Uncompiled();

    /// <summary>Gets the current action record.</summary>
    public static JToken Action() => throw Uncompiled();

    /// <summary>Gets the current agent request.</summary>
    public static JToken CurrentRequest() => throw Uncompiled();

    /// <summary>Converts a value to a binary content envelope.</summary>
    public static JToken Binary(object value) => throw Uncompiled();

    /// <summary>Converts a Base64 string to a binary content envelope.</summary>
    public static JToken Base64ToBinary(string value) => throw Uncompiled();

    /// <summary>Converts a data URI to a binary content envelope.</summary>
    public static JToken DataUriToBinary(string value) => throw Uncompiled();

    /// <summary>Gets an action multipart body by index.</summary>
    public static JToken MultipartBody(string actionName, long index) => throw Uncompiled();

    /// <summary>Gets a form-data value from an action body.</summary>
    public static JToken FormDataValue(string actionName, string fieldName) => throw Uncompiled();

    /// <summary>Gets all matching form-data values from an action body.</summary>
    public static JToken FormDataMultiValues(string actionName, string fieldName) => throw Uncompiled();

    /// <summary>Gets a trigger multipart body by index.</summary>
    public static JToken TriggerMultipartBody(long index) => throw Uncompiled();

    /// <summary>Gets a form-data value from the trigger body.</summary>
    public static JToken TriggerFormDataValue(string fieldName) => throw Uncompiled();

    /// <summary>Gets all matching form-data values from the trigger body.</summary>
    public static JToken TriggerFormDataMultiValues(string fieldName) => throw Uncompiled();

    private static NotSupportedException Uncompiled() =>
        new NotSupportedException("Workflow context accessors require a source-compiled workflow expression.");

    internal static string GetExpressionFunctionName(string methodName) =>
        methodName switch
        {
            nameof(ToJson) => "json",
            nameof(Actions) => "actions",
            nameof(Trigger) => "trigger",
            nameof(ListCallbackUrl) => "listCallbackUrl",
            nameof(AppSetting) => "appsetting",
            nameof(Action) => "action",
            nameof(CurrentRequest) => "currentRequest",
            nameof(Binary) => "binary",
            nameof(Base64ToBinary) => "base64ToBinary",
            nameof(DataUriToBinary) => "dataUriToBinary",
            nameof(MultipartBody) => "multipartBody",
            nameof(FormDataValue) => "formDataValue",
            nameof(FormDataMultiValues) => "formDataMultiValues",
            nameof(TriggerMultipartBody) => "triggerMultipartBody",
            nameof(TriggerFormDataValue) => "triggerFormDataValue",
            nameof(TriggerFormDataMultiValues) => "triggerFormDataMultiValues",
            _ => throw new NotSupportedException(
                $"Workflow function '{methodName}' is not mapped."),
        };
}