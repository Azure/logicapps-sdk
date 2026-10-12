// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
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
        public IWorkflowAction Scope(Func<IChainableNode> actions)
        {
            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions), "Scope action requires non-null actions.");
            }

            var resolvedActions = actions.Invoke();
            return new ScopeAction(resolvedActions?.GetRootOperation() as IWorkflowAction);
        }

        [WorkflowExpressionFactory(nameof(__BuildCondition))]
        /// <summary>
        /// Creates a Condition (If) action that evaluates an expression and executes one of two branches.
        /// </summary>
        /// <param name = "expression">The boolean expression to evaluate.</param>
        /// <param name = "trueBranch">A factory that builds the true branch action graph and returns any node in the chain.</param>
        /// <param name = "falseBranch">A factory that builds the false branch action graph and returns any node in the chain.</param>
        public IWorkflowAction Condition([WorkflowExpression] Func<bool> expression, Func<IChainableNode> trueBranch, Func<IChainableNode> falseBranch)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a Condition (If) action that evaluates an expression and executes one of two branches.
        /// </summary>
        /// <param name = "expression">The boolean expression to evaluate.</param>
        /// <param name = "trueBranch">A factory that builds the true branch action graph and returns any node in the chain.</param>
        /// <param name = "falseBranch">A factory that builds the false branch action graph and returns any node in the chain.</param>
        public IWorkflowAction __BuildCondition(WorkflowExpression<bool> expression, Func<IChainableNode> trueBranch, Func<IChainableNode> falseBranch)
        {
            WorkflowExpression.Validate(expression, nameof(expression), required: true);
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression), "Condition action requires a non-null expression.");
            }

            var resolvedTrueBranch = trueBranch?.Invoke();
            var resolvedFalseBranch = falseBranch?.Invoke();
            if (resolvedTrueBranch == null && resolvedFalseBranch == null)
            {
                throw new ArgumentException("Condition action requires at least one non-null branch.");
            }

            return new DeferredWorkflowAction(() => new ConditionAction(ExpressionConverter.ConvertCondition(expression), resolvedTrueBranch?.GetRootOperation() as IWorkflowAction, resolvedFalseBranch?.GetRootOperation() as IWorkflowAction));
        }

        [WorkflowExpressionFactory(nameof(__BuildForEach))]
        /// <summary>
        /// Creates a ForEach action that iterates over a collection and executes actions for each item.
        /// </summary>
        /// <param name = "items">An expression for the collection to iterate over.</param>
        /// <param name = "actions">A factory that takes the current item token and builds the action graph, returning any node in the chain.</param>
        public IWorkflowAction ForEach([WorkflowExpression] Func<object> items, Func<JToken, IChainableNode> actions)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a ForEach action that iterates over a collection and executes actions for each item.
        /// </summary>
        /// <param name = "items">An expression for the collection to iterate over.</param>
        /// <param name = "actions">A factory that takes the current item token and builds the action graph, returning any node in the chain.</param>
        public IWorkflowAction __BuildForEach(WorkflowExpression<object> items, Func<JToken, IChainableNode> actions)
        {
            WorkflowExpression.Validate(items, nameof(items), required: true);
            if (items == null)
            {
                throw new ArgumentNullException(nameof(items), "ForEach action requires a non-null items expression.");
            }

            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions), "ForEach action requires non-null actions.");
            }

            var currentItemPlaceholder = new ForEachItemToken();
            var resolvedActions = actions.Invoke(currentItemPlaceholder);
            return new DeferredWorkflowAction(() => new ForEachAction(ExpressionConverter.ConvertO(items), resolvedActions?.GetRootOperation() as IWorkflowAction));
        }

        [WorkflowExpressionFactory(nameof(__BuildUntil))]
        /// <summary>
        /// Creates an Until action that repeats actions until a condition is met.
        /// </summary>
        /// <param name = "expression">The boolean expression for the exit condition.</param>
        /// <param name = "actions">A factory that builds the action graph to repeat and returns any node in the chain.</param>
        public IWorkflowAction Until([WorkflowExpression] Func<bool> expression, Func<IChainableNode> actions)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates an Until action that repeats actions until a condition is met.
        /// </summary>
        /// <param name = "expression">The boolean expression for the exit condition.</param>
        /// <param name = "actions">A factory that builds the action graph to repeat and returns any node in the chain.</param>
        public IWorkflowAction __BuildUntil(WorkflowExpression<bool> expression, Func<IChainableNode> actions)
        {
            WorkflowExpression.Validate(expression, nameof(expression), required: true);
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression), "Until action requires a non-null expression.");
            }

            if (actions == null)
            {
                throw new ArgumentNullException(nameof(actions), "Until action requires non-null actions.");
            }

            var resolvedActions = actions.Invoke();
            return new DeferredWorkflowAction(() => new UntilAction(ExpressionConverter.ConvertCondition(expression), resolvedActions?.GetRootOperation() as IWorkflowAction));
        }

        [WorkflowExpressionFactory(nameof(__BuildSwitch))]
        /// <summary>
        /// Creates a Switch action that evaluates an expression and routes execution to matching cases.
        /// </summary>
        /// <param name = "on">An expression for the value to switch on.</param>
        /// <param name = "cases">A factory that returns a dictionary mapping case labels to their SwitchCase entries.</param>
        /// <param name = "defaultCase">A factory that builds the default case action graph and returns any node in the chain (optional).</param>
        public IWorkflowAction Switch([WorkflowExpression] Func<JToken> on, Func<Dictionary<string, SwitchCase>> cases, Func<IChainableNode> defaultCase = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a Switch action that evaluates an expression and routes execution to matching cases.
        /// </summary>
        /// <param name = "on">An expression for the value to switch on.</param>
        /// <param name = "cases">A factory that returns a dictionary mapping case labels to their SwitchCase entries.</param>
        /// <param name = "defaultCase">A factory that builds the default case action graph and returns any node in the chain (optional).</param>
        public IWorkflowAction __BuildSwitch(WorkflowExpression<JToken> on, Func<Dictionary<string, SwitchCase>> cases, Func<IChainableNode> defaultCase = null)
        {
            WorkflowExpression.Validate(on, nameof(on), required: true);
            if (on == null)
            {
                throw new ArgumentNullException(nameof(on), "Switch action requires a non-null 'on' expression.");
            }

            if (cases == null)
            {
                throw new ArgumentNullException(nameof(cases), "Switch action requires a non-null cases factory.");
            }

            var resolvedCasesDict = cases.Invoke();
            var resolvedDefaultCase = defaultCase?.Invoke();
            return new DeferredWorkflowAction(() => new SwitchAction(ExpressionConverter.ConvertO(on), resolvedCasesDict, resolvedDefaultCase?.GetRootOperation() as IWorkflowAction));
        }

        [WorkflowExpressionFactory(nameof(__BuildTerminate))]
        /// <summary>
        /// Creates a Terminate action that stops workflow execution with a specified status.
        /// </summary>
        /// <param name = "status">An expression for the termination status (e.g., FlowStatus.Failed).</param>
        /// <param name = "message">An expression for the termination message (optional).</param>
        public IWorkflowAction Terminate([WorkflowExpression] Func<FlowStatus> status, [WorkflowExpression] Func<string> message = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        /// <summary>
        /// Creates a Terminate action that stops workflow execution with a specified status.
        /// </summary>
        /// <param name = "status">An expression for the termination status (e.g., FlowStatus.Failed).</param>
        /// <param name = "message">An expression for the termination message (optional).</param>
        public IWorkflowAction __BuildTerminate(WorkflowExpression<FlowStatus> status, WorkflowExpression<string> message = null)
        {
            WorkflowExpression.Validate(status, nameof(status), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: false);
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status), "Terminate action requires a non-null status expression.");
            }

            return new DeferredWorkflowAction(() => new TerminateAction(ExpressionConverter.Convert(status), ExpressionConverter.Convert(message)));
        }
    }
}