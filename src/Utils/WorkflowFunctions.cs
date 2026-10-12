// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;
    /// <summary>Workflow functions recognized by the source compiler, not executed during authoring.</summary>
    public static class WorkflowFunctions
    {
        public static T ToJson<T>(string input) => throw Uncompiled();
        public static JToken ToJson(string input) => throw Uncompiled();
        public static JToken Actions(string actionName) => throw Uncompiled();
        public static JToken Trigger() => throw Uncompiled();
        public static string ListCallbackUrl() => throw Uncompiled();
        public static JToken AppSetting(string name) => throw Uncompiled();
        public static JToken Action() => throw Uncompiled();
        public static JToken CurrentRequest() => throw Uncompiled();
        public static JToken Binary(object value) => throw Uncompiled();
        public static JToken Base64ToBinary(string value) => throw Uncompiled();
        public static JToken DataUriToBinary(string value) => throw Uncompiled();
        public static JToken MultipartBody(string name, long index) => throw Uncompiled();
        public static JToken FormDataValue(string name, string field) => throw Uncompiled();
        public static JToken FormDataMultiValues(string name, string field) => throw Uncompiled();
        public static JToken TriggerMultipartBody(long index) => throw Uncompiled();
        public static JToken TriggerFormDataValue(string field) => throw Uncompiled();
        public static JToken TriggerFormDataMultiValues(string field) => throw Uncompiled();
        private static InvalidOperationException Uncompiled() => new InvalidOperationException("Use workflow functions inside a source-compiled workflow value.");
    }
}
