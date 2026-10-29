// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Provides factory methods for creating control flow actions (Scope, Condition, ForEach, Until, Switch, Terminate).
    /// </summary>
    public class WorkflowControlActions
    {
        /// <summary>
        /// Creates a Scope action that groups nested actions together.
        /// </summary>
        /// <param name = "actions">A factory that builds the nested action graph and returns any node in the chain.</param>
        public IWorkflowAction<ControlActionConfiguration> Scope(Func<IChainableNode> actions)
        {
            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions), "Scope action requires non-null actions.");
            }

            var resolvedActions = actions.Invoke();
            return new DeferredWorkflowAction<ControlActionConfiguration>(
                () => new ScopeAction(resolvedActions?.GetRootOperation() as IWorkflowAction));
        }

        /// <summary>
        /// Creates a Condition (If) action that evaluates an expression and executes one of two branches.
        /// </summary>
        /// <param name = "expression">The boolean expression to evaluate.</param>
        /// <param name = "trueBranch">A factory that builds the true branch action graph and returns any node in the chain.</param>
        /// <param name = "falseBranch">A factory that builds the false branch action graph and returns any node in the chain.</param>
        public IWorkflowAction<ControlActionConfiguration> Condition(Expression<Func<bool>> expression, Func<IChainableNode> trueBranch, Func<IChainableNode> falseBranch)
        {
            var descriptor = WorkflowExpression.Compile(expression, nameof(expression), required: true);

            var resolvedTrueBranch = trueBranch?.Invoke();
            var resolvedFalseBranch = falseBranch?.Invoke();
            if (resolvedTrueBranch == null && resolvedFalseBranch == null)
            {
                throw new ArgumentException("Condition action requires at least one non-null branch.");
            }

            return new DeferredWorkflowAction<ControlActionConfiguration>(
                () => new ConditionAction(ExpressionConverter.ConvertCondition(descriptor), resolvedTrueBranch?.GetRootOperation() as IWorkflowAction, resolvedFalseBranch?.GetRootOperation() as IWorkflowAction));
        }

        /// <summary>
        /// Creates a ForEach action that iterates over a collection and executes actions for each item.
        /// </summary>
        /// <param name = "items">An expression for the collection to iterate over.</param>
        /// <param name = "actions">A factory that takes the current item token and builds the action graph, returning any node in the chain.</param>
        public IWorkflowAction<ForEachActionConfiguration> ForEach(Expression<Func<object>> items, Func<JToken, IChainableNode> actions)
        {
            var descriptor = WorkflowExpression.Compile(items, nameof(items), required: true);

            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions), "ForEach action requires non-null actions.");
            }

            var currentItemPlaceholder = new ForEachItemToken();
            var resolvedActions = actions.Invoke(currentItemPlaceholder);
            return new DeferredWorkflowAction<ForEachActionConfiguration>(
                () => new ForEachAction(ExpressionConverter.ConvertO(descriptor), resolvedActions?.GetRootOperation() as IWorkflowAction));
        }

        /// <summary>
        /// Creates an Until action that repeats actions until a condition is met.
        /// </summary>
        /// <param name = "expression">The boolean expression for the exit condition.</param>
        /// <param name = "actions">A factory that builds the action graph to repeat and returns any node in the chain.</param>
        public IWorkflowAction<ControlActionConfiguration> Until(Expression<Func<bool>> expression, Func<IChainableNode> actions)
        {
            var descriptor = WorkflowExpression.Compile(expression, nameof(expression), required: true);

            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions), "Until action requires non-null actions.");
            }

            var resolvedActions = actions.Invoke();
            return new DeferredWorkflowAction<ControlActionConfiguration>(
                () => new UntilAction(ExpressionConverter.ConvertCondition(descriptor), resolvedActions?.GetRootOperation() as IWorkflowAction));
        }

        /// <summary>
        /// Creates a Switch action that evaluates an expression and routes execution to matching cases.
        /// </summary>
        /// <param name = "on">An expression for the value to switch on.</param>
        /// <param name = "cases">A factory that returns a dictionary mapping case labels to their SwitchCase entries.</param>
        /// <param name = "defaultCase">A factory that builds the default case action graph and returns any node in the chain (optional).</param>
        public IWorkflowAction<ControlActionConfiguration> Switch(Expression<Func<JToken>> on, Func<Dictionary<string, SwitchCase>> cases, Func<IChainableNode> defaultCase = null)
        {
            var descriptor = WorkflowExpression.Compile(on, nameof(on), required: true);

            if (cases == null)
            {
                throw new ArgumentNullException(nameof(cases), "Switch action requires a non-null cases factory.");
            }

            var resolvedCasesDict = cases.Invoke();
            var resolvedDefaultCase = defaultCase?.Invoke();
            return new DeferredWorkflowAction<ControlActionConfiguration>(
                () => new SwitchAction(ExpressionConverter.ConvertO(descriptor), resolvedCasesDict, resolvedDefaultCase?.GetRootOperation() as IWorkflowAction));
        }

        /// <summary>
        /// Creates a Terminate action that stops workflow execution with a specified status.
        /// </summary>
        /// <param name = "status">An expression for the termination status (e.g., FlowStatus.Failed).</param>
        /// <param name = "message">An expression for the termination message (optional).</param>
        public IWorkflowAction<ControlActionConfiguration> Terminate(Expression<Func<FlowStatus>> status, Expression<Func<string>> message = null)
        {
            var statusDescriptor = WorkflowExpression.Compile(status, nameof(status), required: true);
            var messageDescriptor = WorkflowExpression.Compile(message, nameof(message), required: false);

            return new DeferredWorkflowAction<ControlActionConfiguration>(
                () => new TerminateAction(ExpressionConverter.Convert(statusDescriptor), ExpressionConverter.Convert(messageDescriptor)));
        }
    }
}