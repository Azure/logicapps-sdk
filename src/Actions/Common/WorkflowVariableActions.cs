// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections;

    /// <summary>
    /// Provides factory methods for creating variable actions
    /// (InitializeVariable, SetVariable, IncrementVariable, DecrementVariable,
    /// AppendToStringVariable, AppendToArrayVariable).
    /// </summary>
    public class WorkflowVariableActions
    {
        [WorkflowExpressionFactory(nameof(__BuildInitializeVariable))]
        /// <summary>
        /// Creates an InitializeVariable action that declares a workflow variable with an initial value.
        /// </summary>
        /// <typeparam name = "T">The type of the variable value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the initial value.</param>
        public IVariableWorkflowAction InitializeVariable<T>([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<T> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates an InitializeVariable action that declares a workflow variable with an initial value.
        /// </summary>
        /// <typeparam name = "T">The type of the variable value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the initial value.</param>
        public IVariableWorkflowAction __BuildInitializeVariable<T>(WorkflowExpression<string> name, WorkflowExpression<T> value)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            var nameStr = ExpressionConverter.LiteralName(name);
            var typeStr = InferVariableType(typeof(T));
            return new DeferredVariableAction(nameStr, () => new InitializeVariableAction(nameStr, typeStr, ExpressionConverter.ConvertO(value)));
        }

        [WorkflowExpressionFactory(nameof(__BuildSetVariable))]
        /// <summary>
        /// Creates a SetVariable action that sets a workflow variable to a new value.
        /// </summary>
        /// <typeparam name = "T">The type of the variable value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the new value.</param>
        public IVariableWorkflowAction SetVariable<T>([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<T> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a SetVariable action that sets a workflow variable to a new value.
        /// </summary>
        /// <typeparam name = "T">The type of the variable value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the new value.</param>
        public IVariableWorkflowAction __BuildSetVariable<T>(WorkflowExpression<string> name, WorkflowExpression<T> value)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            var nameStr = ExpressionConverter.LiteralName(name);
            return new DeferredVariableAction(nameStr, () => new SetVariableAction(nameStr, ExpressionConverter.ConvertO(value)));
        }

        [WorkflowExpressionFactory(nameof(__BuildIncrementVariable))]
        /// <summary>
        /// Creates an IncrementVariable action that increments a numeric variable.
        /// </summary>
        /// <typeparam name = "T">The numeric type of the increment value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the increment value.</param>
        public IVariableWorkflowAction IncrementVariable<T>([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<T> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates an IncrementVariable action that increments a numeric variable.
        /// </summary>
        /// <typeparam name = "T">The numeric type of the increment value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the increment value.</param>
        public IVariableWorkflowAction __BuildIncrementVariable<T>(WorkflowExpression<string> name, WorkflowExpression<T> value)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            var nameStr = ExpressionConverter.LiteralName(name);
            return new DeferredVariableAction(nameStr, () => new IncrementVariableAction(nameStr, ExpressionConverter.ConvertO(value)));
        }

        [WorkflowExpressionFactory(nameof(__BuildDecrementVariable))]
        /// <summary>
        /// Creates a DecrementVariable action that decrements a numeric variable.
        /// </summary>
        /// <typeparam name = "T">The numeric type of the decrement value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the decrement value.</param>
        public IVariableWorkflowAction DecrementVariable<T>([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<T> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a DecrementVariable action that decrements a numeric variable.
        /// </summary>
        /// <typeparam name = "T">The numeric type of the decrement value.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the decrement value.</param>
        public IVariableWorkflowAction __BuildDecrementVariable<T>(WorkflowExpression<string> name, WorkflowExpression<T> value)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            var nameStr = ExpressionConverter.LiteralName(name);
            return new DeferredVariableAction(nameStr, () => new DecrementVariableAction(nameStr, ExpressionConverter.ConvertO(value)));
        }

        [WorkflowExpressionFactory(nameof(__BuildAppendToStringVariable))]
        /// <summary>
        /// Creates an AppendToStringVariable action that appends text to a string variable.
        /// </summary>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the string to append.</param>
        public IVariableWorkflowAction AppendToStringVariable([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates an AppendToStringVariable action that appends text to a string variable.
        /// </summary>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the string to append.</param>
        public IVariableWorkflowAction __BuildAppendToStringVariable(WorkflowExpression<string> name, WorkflowExpression<string> value)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            var nameStr = ExpressionConverter.LiteralName(name);
            return new DeferredVariableAction(nameStr, () => new AppendToStringVariableAction(nameStr, ExpressionConverter.ConvertO(value)));
        }

        [WorkflowExpressionFactory(nameof(__BuildAppendToArrayVariable))]
        /// <summary>
        /// Creates an AppendToArrayVariable action that appends a value to an array variable.
        /// </summary>
        /// <typeparam name = "T">The type of the value to append.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the value to append.</param>
        public IVariableWorkflowAction AppendToArrayVariable<T>([WorkflowExpression] Func<string> name, [WorkflowExpression] Func<T> value)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates an AppendToArrayVariable action that appends a value to an array variable.
        /// </summary>
        /// <typeparam name = "T">The type of the value to append.</typeparam>
        /// <param name = "name">An expression for the variable name.</param>
        /// <param name = "value">An expression for the value to append.</param>
        public IVariableWorkflowAction __BuildAppendToArrayVariable<T>(WorkflowExpression<string> name, WorkflowExpression<T> value)
        {
            WorkflowExpression.Validate(name, nameof(name), required: true);
            WorkflowExpression.Validate(value, nameof(value), required: true);
            var nameStr = ExpressionConverter.LiteralName(name);
            return new DeferredVariableAction(nameStr, () => new AppendToArrayVariableAction(nameStr, ExpressionConverter.ConvertO(value)));
        }

        /// <summary>
        /// Infers the Logic Apps variable type string from a CLR type.
        /// </summary>
        /// <param name = "clrType">The CLR type to map.</param>
        private static string InferVariableType(Type clrType)
        {
            if (clrType == typeof(int) || clrType == typeof(long) || clrType == typeof(short) || clrType == typeof(byte))
                return "Integer";
            if (clrType == typeof(float) || clrType == typeof(double) || clrType == typeof(decimal))
                return "Float";
            if (clrType == typeof(bool))
                return "Boolean";
            if (clrType == typeof(string))
                return "String";
            if (clrType.IsArray || (clrType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(clrType)))
                return "Array";
            return "Object";
        }
    }
}