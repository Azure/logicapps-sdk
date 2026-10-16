// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    internal sealed class WorkflowFunctionAttribute : Attribute
    {
        internal WorkflowFunctionAttribute(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Workflow function name cannot be empty.", nameof(name));
            this.Name = name;
        }

        internal string Name { get; }
    }

    /// <summary>Workflow functions recognized by the source compiler, not executed during authoring.</summary>
    public static class WorkflowFunctions
    {
        [WorkflowFunction("json")]
        public static T ToJson<T>(string input) => throw Uncompiled();

        [WorkflowFunction("json")]
        public static JToken ToJson(string input) => throw Uncompiled();

        [WorkflowFunction("actions")]
        public static JToken Actions(string actionName) => throw Uncompiled();

        [WorkflowFunction("trigger")]
        public static JToken Trigger() => throw Uncompiled();

        [WorkflowFunction("listCallbackUrl")]
        public static string ListCallbackUrl() => throw Uncompiled();

        [WorkflowFunction("appsetting")]
        public static JToken AppSetting(string name) => throw Uncompiled();

        [WorkflowFunction("action")]
        public static JToken Action() => throw Uncompiled();

        [WorkflowFunction("currentRequest")]
        public static JToken CurrentRequest() => throw Uncompiled();

        [WorkflowFunction("binary")]
        public static JToken Binary(object value) => throw Uncompiled();

        [WorkflowFunction("base64ToBinary")]
        public static JToken Base64ToBinary(string value) => throw Uncompiled();

        [WorkflowFunction("dataUriToBinary")]
        public static JToken DataUriToBinary(string value) => throw Uncompiled();

        [WorkflowFunction("multipartBody")]
        public static JToken MultipartBody(string name, long index) => throw Uncompiled();

        [WorkflowFunction("formDataValue")]
        public static JToken FormDataValue(string name, string field) => throw Uncompiled();

        [WorkflowFunction("formDataMultiValues")]
        public static JToken FormDataMultiValues(string name, string field) => throw Uncompiled();

        [WorkflowFunction("triggerMultipartBody")]
        public static JToken TriggerMultipartBody(long index) => throw Uncompiled();

        [WorkflowFunction("triggerFormDataValue")]
        public static JToken TriggerFormDataValue(string field) => throw Uncompiled();

        [WorkflowFunction("triggerFormDataMultiValues")]
        public static JToken TriggerFormDataMultiValues(string field) => throw Uncompiled();

        private static InvalidOperationException Uncompiled() => new InvalidOperationException("Use workflow functions inside a source-compiled workflow value.");
    }
}
