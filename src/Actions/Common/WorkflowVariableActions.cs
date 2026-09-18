// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Provides factory methods for creating variable actions
    /// (InitializeVariable, SetVariable, IncrementVariable, DecrementVariable,
    /// AppendToStringVariable, AppendToArrayVariable).
    /// </summary>
    public class WorkflowVariableActions
    {
        /// <summary>
        /// Creates an InitializeVariable action that declares a workflow variable with an initial value.
        /// </summary>
        /// <typeparam name="T">The type of the variable value.</typeparam>
        /// <param name="name">An expression for the variable name.</param>
        /// <param name="value">An expression for the initial value.</param>
        public IVariableWorkflowAction InitializeVariable<T>(
            [WorkflowExpression] Func<string> name,
            [WorkflowExpression] Func<T> value)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            if (value == null) throw new ArgumentNullException(nameof(value));
            SourceExpression.Validate(value, nameof(value));
            var typeStr = InferVariableType(typeof(T));
            return new DeferredVariableAction(name, () => new InitializeVariableAction(SourceExpressionConverter.ConvertO(name), typeStr, SourceExpressionConverter.ConvertToken(value)));
        }

        /// <summary>
        /// Creates a SetVariable action that sets a workflow variable to a new value.
        /// </summary>
        /// <typeparam name="T">The type of the variable value.</typeparam>
        /// <param name="name">An expression for the variable name.</param>
        /// <param name="value">An expression for the new value.</param>
        public IVariableWorkflowAction SetVariable<T>(
            [WorkflowExpression] Func<string> name,
            [WorkflowExpression] Func<T> value)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            if (value == null) throw new ArgumentNullException(nameof(value));
            SourceExpression.Validate(value, nameof(value));
            return new DeferredVariableAction(name, () => new SetVariableAction(SourceExpressionConverter.ConvertO(name), SourceExpressionConverter.ConvertToken(value)));
        }

        /// <summary>
        /// Creates an IncrementVariable action that increments a numeric variable.
        /// </summary>
        /// <typeparam name="T">The numeric type of the increment value.</typeparam>
        /// <param name="name">An expression for the variable name.</param>
        /// <param name="value">An expression for the increment value.</param>
        public IVariableWorkflowAction IncrementVariable<T>(
            [WorkflowExpression] Func<string> name,
            [WorkflowExpression] Func<T> value)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            return new DeferredVariableAction(name, () => new IncrementVariableAction(SourceExpressionConverter.ConvertO(name), SourceExpressionConverter.ConvertToken(value)));
        }

        /// <summary>
        /// Creates a DecrementVariable action that decrements a numeric variable.
        /// </summary>
        /// <typeparam name="T">The numeric type of the decrement value.</typeparam>
        /// <param name="name">An expression for the variable name.</param>
        /// <param name="value">An expression for the decrement value.</param>
        public IVariableWorkflowAction DecrementVariable<T>(
            [WorkflowExpression] Func<string> name,
            [WorkflowExpression] Func<T> value)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            return new DeferredVariableAction(name, () => new DecrementVariableAction(SourceExpressionConverter.ConvertO(name), SourceExpressionConverter.ConvertToken(value)));
        }

        /// <summary>
        /// Creates an AppendToStringVariable action that appends text to a string variable.
        /// </summary>
        /// <param name="name">An expression for the variable name.</param>
        /// <param name="value">An expression for the string to append.</param>
        public IVariableWorkflowAction AppendToStringVariable(
            [WorkflowExpression] Func<string> name,
            [WorkflowExpression] Func<string> value)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            return new DeferredVariableAction(name, () => new AppendToStringVariableAction(SourceExpressionConverter.ConvertO(name), SourceExpressionConverter.ConvertToken(value)));
        }

        /// <summary>
        /// Creates an AppendToArrayVariable action that appends a value to an array variable.
        /// </summary>
        /// <typeparam name="T">The type of the value to append.</typeparam>
        /// <param name="name">An expression for the variable name.</param>
        /// <param name="value">An expression for the value to append.</param>
        public IVariableWorkflowAction AppendToArrayVariable<T>(
            [WorkflowExpression] Func<string> name,
            [WorkflowExpression] Func<T> value)
        {
            SourceExpression.Validate(name, nameof(name), required: true);
            if (value == null) throw new ArgumentNullException(nameof(value));
            SourceExpression.Validate(value, nameof(value));
            return new DeferredVariableAction(name, () => new AppendToArrayVariableAction(SourceExpressionConverter.ConvertO(name), SourceExpressionConverter.ConvertToken(value)));
        }

        /// <summary>
        /// Infers the Logic Apps variable type string from a CLR type.
        /// </summary>
        /// <param name="clrType">The CLR type to map.</param>
        private static string InferVariableType(Type clrType)
        {
            if (clrType == typeof(int) || clrType == typeof(long) || clrType == typeof(short) || clrType == typeof(byte))
                return "integer";
            if (clrType == typeof(float) || clrType == typeof(double) || clrType == typeof(decimal))
                return "float";
            if (clrType == typeof(bool))
                return "boolean";
            if (clrType == typeof(string))
                return "string";
            if (typeof(JObject).IsAssignableFrom(clrType))
                return "object";
            if (typeof(JArray).IsAssignableFrom(clrType))
                return "array";
            if (clrType.IsArray || (clrType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(clrType)))
                return "array";
            return "object";
        }
    }
}
