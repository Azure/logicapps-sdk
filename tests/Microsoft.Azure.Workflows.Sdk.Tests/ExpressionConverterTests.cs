// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Runtime.Serialization;
    using Microsoft.Azure.Workflows.Sdk;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Xunit;

    /// <summary>
    /// Tests conversion of object expressions containing generated defaults.
    /// </summary>
    public class ExpressionConverterTests
    {
        /// <summary>
        /// Verifies unbound defaults are emitted while explicit values win.
        /// </summary>
        [Fact]
        public void ConvertO_ObjectDefaults_AppliesOnlyUnboundDefaults()
        {
            Expression<Func<DefaultedInput>> expression = () => new DefaultedInput
            {
                Enabled = false,
            };
            var converted = ExpressionConverterTests.Convert(expression);

            Assert.False(converted.Value<bool>("enabled"));
            Assert.Equal(5, converted.Value<int>("count"));
            Assert.Equal("replace", converted.Value<string>("mode"));
            Assert.Equal("default", converted["payload"].Value<string>("name"));
            Assert.Null(converted["unconfigured"]);
        }

        /// <summary>
        /// Verifies explicitly bound values override generated defaults.
        /// </summary>
        [Fact]
        public void ConvertO_ExplicitDefaultedValue_PreservesExplicitValue()
        {
            Expression<Func<DefaultedInput>> expression = () => new DefaultedInput
            {
                Count = 0,
            };
            var converted = ExpressionConverterTests.Convert(expression);

            Assert.True(converted.Value<bool>("enabled"));
            Assert.Equal(0, converted.Value<int>("count"));
            Assert.Equal("replace", converted.Value<string>("mode"));
            Assert.Equal("default", converted["payload"].Value<string>("name"));
        }

        /// <summary>
        /// Verifies a defaults-only generated object can be converted without member bindings.
        /// </summary>
        [Fact]
        public void ConvertO_DefaultsOnlyObject_EmitsGeneratedDefaults()
        {
            Expression<Func<DefaultedInput>> expression = () => new DefaultedInput();
            var converted = ExpressionConverterTests.Convert(expression);

            Assert.True(converted.Value<bool>("enabled"));
            Assert.Equal(5, converted.Value<int>("count"));
            Assert.Equal("replace", converted.Value<string>("mode"));
            Assert.Equal("default", converted["payload"].Value<string>("name"));
        }

        /// <summary>
        /// Verifies parameterized constructors remain unsupported instead of losing arguments.
        /// </summary>
        [Fact]
        public void ConvertO_ParameterizedDefaultedObject_ThrowsNotImplementedException()
        {
            Expression<Func<ParameterizedDefaultedInput>> expression =
                () => new ParameterizedDefaultedInput(42);

            var exception = Assert.Throws<TargetInvocationException>(
                () => ExpressionConverterTests.Convert(expression));

            Assert.IsType<NotImplementedException>(exception.InnerException);
        }

        private static JToken Convert<T>(Expression<Func<T>> expression)
        {
            var converterType = typeof(WorkflowOperationResult).Assembly.GetType(
                "Microsoft.Azure.Workflows.Sdk.ExpressionConverter",
                throwOnError: true);
            var convertMethod = converterType
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Single(
                    method =>
                        string.Equals(method.Name, "ConvertO", StringComparison.Ordinal) &&
                        method.IsGenericMethodDefinition)
                .MakeGenericMethod(typeof(T));

            var converted = (JToken)convertMethod.Invoke(
                obj: null,
                parameters:
                [
                    expression,
                ]);
            return converted;
        }

        private sealed class DefaultedInput
        {
            [JsonProperty("enabled")]
            [DefaultValue(true)]
            public bool? Enabled { get; set; } = true;

            [JsonProperty("count")]
            [DefaultValue(5)]
            public int? Count { get; set; } = 5;

            [JsonProperty("mode")]
            [DefaultValue(DefaultMode.Replace)]
            public DefaultMode? Mode { get; set; } = DefaultMode.Replace;

            [JsonProperty("payload")]
            [DefaultValue("{\"name\":\"default\"}")]
            public JToken Payload { get; set; } = JToken.Parse("{\"name\":\"default\"}");

            [JsonProperty("unconfigured")]
            public string Unconfigured { get; set; }
        }

        private sealed class ParameterizedDefaultedInput
        {
            public ParameterizedDefaultedInput(int value)
            {
                this.Value = value;
            }

            [DefaultValue(5)]
            public int Value { get; set; } = 5;
        }

        private enum DefaultMode
        {
            [EnumMember(Value = "merge")]
            Merge,

            [EnumMember(Value = "replace")]
            Replace,
        }
    }
}
