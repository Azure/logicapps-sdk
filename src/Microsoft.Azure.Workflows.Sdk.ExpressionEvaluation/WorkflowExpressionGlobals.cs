// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ExpressionEvaluation
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// The set of "free functions" that a serialized C# workflow expression may reference.
    /// The public members of this object are placed in scope by the Roslyn script host, which
    /// is exactly the runtime model the <c>CSharpExpressionConverter</c> targets — e.g.
    /// <c>variables("myVar")</c>, <c>triggerOutputs()?["Body"]</c>, <c>encodeURIComponent("s")</c>.
    ///
    /// Method names are intentionally lowercase to mirror the Logic App function names.
    ///
    /// Workflow-data accessors return <see cref="JToken"/> so that C# indexers (<c>?[...]</c>),
    /// string concatenation, and typed reads (<c>ToObject&lt;T&gt;()</c> / <c>Value&lt;T&gt;()</c>)
    /// compose naturally.
    ///
    /// PROTOTYPE NOTE: this concrete implementation is fed an in-memory data snapshot. In the
    /// real worker the snapshot would be produced by pre-fetching from <c>WorkflowContext</c>
    /// (dependency pre-scan -&gt; parallel async fetch -&gt; immutable snapshot); see the design doc.
    /// </summary>
    public class WorkflowExpressionGlobals
    {
        private readonly JToken triggerResult;
        private readonly IReadOnlyDictionary<string, JToken> actionOutputs;
        private readonly IReadOnlyDictionary<string, JToken> variableValues;
        private readonly IReadOnlyDictionary<string, JToken> agentParameterValues;

        public WorkflowExpressionGlobals(
            JToken triggerOutputs = null,
            IReadOnlyDictionary<string, JToken> actionOutputs = null,
            IReadOnlyDictionary<string, JToken> variables = null,
            IReadOnlyDictionary<string, JToken> agentParameters = null)
        {
            this.triggerResult = triggerOutputs;
            this.actionOutputs = actionOutputs ?? new Dictionary<string, JToken>();
            this.variableValues = variables ?? new Dictionary<string, JToken>();
            this.agentParameterValues = agentParameters ?? new Dictionary<string, JToken>();
        }

        // -------------------- Workflow data --------------------

        public JToken triggerOutputs() => this.triggerResult ?? JValue.CreateNull();

        public JToken triggerBody() => (this.triggerResult?["body"]) ?? JValue.CreateNull();

        public JToken outputs(string actionName) => Lookup(this.actionOutputs, actionName);

        public JToken body(string actionName) => (Lookup(this.actionOutputs, actionName)?["body"]) ?? JValue.CreateNull();

        public JToken variables(string name) => Lookup(this.variableValues, name);

        public JToken agentparameters(string name) => Lookup(this.agentParameterValues, name);

        // -------------------- Helper functions --------------------
        // Accept object so the converter can pass workflow data / non-string values
        // (e.g. encodeURIComponent(42)) without an explicit cast.

        public string encodeURIComponent(object value) =>
            Uri.EscapeDataString(AsString(value));

        public string base64(object value) =>
            Convert.ToBase64String(Encoding.UTF8.GetBytes(AsString(value)));

        public JToken json(string value) => JToken.Parse(value);

        // -------------------- Helpers --------------------

        private static JToken Lookup(IReadOnlyDictionary<string, JToken> map, string key) =>
            (map != null && key != null && map.TryGetValue(key, out var value)) ? value : JValue.CreateNull();

        private static string AsString(object value) =>
            value == null ? string.Empty : Convert.ToString(value, CultureInfo.InvariantCulture);
    }
}
