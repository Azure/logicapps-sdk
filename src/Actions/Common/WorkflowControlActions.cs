// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Provides factory methods for creating control flow actions (Scope, Condition, ForEach, Until, Switch, Terminate).
    /// </summary>
    public class WorkflowControlActions
    {
        /// <summary>
        /// Creates a Scope action that groups nested actions together.
        /// </summary>
        /// <param name="actions">A factory that builds the nested action graph and returns the root action node.</param>
        public IWorkflowAction Scope(Func<IWorkflowAction> actions)
        {
            var actionsRoot = actions();
            return new ScopeAction(actionsRoot);
        }

        /// <summary>
        /// Creates a Condition (If) action that evaluates an expression and executes one of two branches.
        /// </summary>
        /// <param name="expression">The boolean expression to evaluate.</param>
        /// <param name="trueBranch">A factory that builds the true branch action graph and returns the root action node.</param>
        /// <param name="falseBranch">A factory that builds the false branch action graph and returns the root action node.</param>
        public IWorkflowAction Condition(
            Expression<Func<bool>> expression,
            Func<IWorkflowAction> trueBranch,
            Func<IWorkflowAction> falseBranch)
        {
            var expressionStr = ExpressionConverter.Convert(expression);
            var trueBranchRoot = trueBranch?.Invoke();
            var falseBranchRoot = falseBranch?.Invoke();
            return new ConditionAction(expressionStr, trueBranchRoot, falseBranchRoot);
        }

        /// <summary>
        /// Creates a ForEach action that iterates over a collection and executes actions for each item.
        /// </summary>
        /// <param name="items">An expression for the collection to iterate over.</param>
        /// <param name="actions">A factory that takes the current item token and builds the action graph, returning the root action node.</param>
        public IWorkflowAction ForEach(
            Expression<Func<JToken>> items,
            Func<JToken, IWorkflowAction> actions)
        {
            var itemsExpression = ExpressionConverter.ConvertO(items);
            var currentItemPlaceholder = new JValue("@item()");
            var actionsRoot = actions?.Invoke(currentItemPlaceholder);
            return new ForEachAction(itemsExpression, actionsRoot);
        }

        /// <summary>
        /// Creates an Until action that repeats actions until a condition is met.
        /// </summary>
        /// <param name="expression">The boolean expression for the exit condition.</param>
        /// <param name="actions">A factory that builds the action graph to repeat and returns the root action node.</param>
        public IWorkflowAction Until(
            Expression<Func<bool>> expression,
            Func<IWorkflowAction> actions)
        {
            var expressionStr = ExpressionConverter.Convert(expression);
            var actionsRoot = actions();
            return new UntilAction(expressionStr, actionsRoot);
        }

        /// <summary>
        /// Creates a Switch action that evaluates an expression and routes execution to matching cases.
        /// </summary>
        /// <param name="on">An expression for the value to switch on.</param>
        /// <param name="cases">A factory that returns a dictionary mapping case labels to their SwitchCase entries.</param>
        /// <param name="defaultCase">A factory that builds the default case action graph and returns the root action node (optional).</param>
        public IWorkflowAction Switch(
            Expression<Func<string>> on,
            Func<Dictionary<string, SwitchCase>> cases,
            Func<IWorkflowAction> defaultCase = null)
        {
            var onExpression = ExpressionConverter.Convert(on);
            var casesDict = cases();
            var defaultCaseRoot = defaultCase?.Invoke();
            return new SwitchAction(onExpression, casesDict, defaultCaseRoot);
        }

        /// <summary>
        /// Creates a Terminate action that stops workflow execution with a specified status.
        /// </summary>
        /// <param name="status">An expression for the termination status (e.g., FlowStatus.Failed).</param>
        /// <param name="message">An expression for the termination message (optional).</param>
        public IWorkflowAction Terminate(
            Expression<Func<FlowStatus>> status,
            Expression<Func<string>> message = null)
        {
            var statusStr = ExpressionConverter.Convert(status);
            var messageStr = message != null ? ExpressionConverter.Convert(message) : null;
            return new TerminateAction(statusStr, messageStr);
        }
    }
}
