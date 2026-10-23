// Copyright (c) Microsoft Corporation. All rights reserved.
namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    internal sealed class WorkflowFunctionAttribute : Attribute
    {
        internal string Name { get; }
        internal bool ReturnsToken { get; }

        internal WorkflowFunctionAttribute(
            string name,
            bool returnsToken)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Workflow function name cannot be empty.", nameof(name));
            this.Name = name;
            this.ReturnsToken = returnsToken;
        }
    }

    /// <summary>Workflow functions recognized by the source compiler, not executed during authoring.</summary>
    public static class WorkflowFunctions
    {
        [WorkflowFunction("json", returnsToken: true)]
        public static T ParseJson<T>(string input) => throw Uncompiled();

        [WorkflowFunction("json", returnsToken: true)]
        public static JToken ParseJson(string input) => throw Uncompiled();

        [WorkflowFunction("parameters", returnsToken: true)]
        public static JToken Parameters(string name) => throw Uncompiled();

        [WorkflowFunction("workflow", returnsToken: true)]
        public static JToken Workflow() => throw Uncompiled();

        [WorkflowFunction("result", returnsToken: true)]
        public static JToken Result(string scopeName) => throw Uncompiled();

        [WorkflowFunction("items", returnsToken: true)]
        public static JToken Items(string loopName) => throw Uncompiled();

        [WorkflowFunction("iterationIndexes", returnsToken: true)]
        public static JToken IterationIndexes(string loopName) => throw Uncompiled();

        [WorkflowFunction("actions", returnsToken: true)]
        public static JToken Actions(string actionName) => throw Uncompiled();

        [WorkflowFunction("trigger", returnsToken: true)]
        public static JToken Trigger() => throw Uncompiled();

        [WorkflowFunction("listCallbackUrl", returnsToken: false)]
        public static string ListCallbackUrl() => throw Uncompiled();

        [WorkflowFunction("appsetting", returnsToken: true)]
        public static JToken AppSetting(string name) => throw Uncompiled();

        [WorkflowFunction("action", returnsToken: true)]
        public static JToken Action() => throw Uncompiled();

        [WorkflowFunction("currentRequest", returnsToken: true)]
        public static JToken CurrentRequest() => throw Uncompiled();

        [WorkflowFunction("binary", returnsToken: true)]
        public static JToken Binary(object value) => throw Uncompiled();

        [WorkflowFunction("base64ToBinary", returnsToken: true)]
        public static JToken Base64ToBinary(string value) => throw Uncompiled();

        [WorkflowFunction("dataUriToBinary", returnsToken: true)]
        public static JToken DataUriToBinary(string value) => throw Uncompiled();

        [WorkflowFunction("multipartBody", returnsToken: true)]
        public static JToken MultipartBody(string name, long index) => throw Uncompiled();

        [WorkflowFunction("formDataValue", returnsToken: true)]
        public static JToken FormDataValue(string name, string field) => throw Uncompiled();

        [WorkflowFunction("formDataMultiValues", returnsToken: true)]
        public static JToken FormDataMultiValues(string name, string field) => throw Uncompiled();

        [WorkflowFunction("triggerMultipartBody", returnsToken: true)]
        public static JToken TriggerMultipartBody(long index) => throw Uncompiled();

        [WorkflowFunction("triggerFormDataValue", returnsToken: true)]
        public static JToken TriggerFormDataValue(string field) => throw Uncompiled();

        [WorkflowFunction("triggerFormDataMultiValues", returnsToken: true)]
        public static JToken TriggerFormDataMultiValues(string field) => throw Uncompiled();

        private static InvalidOperationException Uncompiled() => new InvalidOperationException("Use workflow functions inside a source-compiled workflow value.");
    }
}
