// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    /// <summary>
    /// Defines the fluent chaining contract that enables composing workflow operations into sequential
    /// and parallel execution pipelines using the <c>.Then()</c> method pattern.
    /// </summary>
    /// <remarks>
    /// <para>
    /// <see cref="IChainableNode"/> is the core building block of the Azure Logic Apps SDK fluent API.
    /// Both individual operations (<see cref="IWorkflowOperation"/>) and operation chains
    /// (<see cref="OperationChain"/>) implement this interface, allowing calls to <c>.Then()</c>
    /// to be chained indefinitely to build complex workflow graphs.
    /// </para>
    /// <para>
    /// The interface provides four overloads of <c>Then</c>:
    /// <list type="bullet">
    ///   <item><description>Simple sequential chaining (runs after the previous action succeeds).</description></item>
    ///   <item><description>Sequential chaining with explicit <see cref="FlowStatus"/> conditions (e.g., run on failure).</description></item>
    ///   <item><description>Sequential chaining with per-predecessor <see cref="RunAfter"/> configurations for fan-in scenarios.</description></item>
    ///   <item><description>Parallel branching via a callback that produces multiple chains from a shared root.</description></item>
    /// </list>
    /// </para>
    /// </remarks>
    /// <seealso cref="IWorkflowOperation"/>
    /// <seealso cref="OperationChain"/>
    /// <seealso cref="RunAfter"/>
    public interface IChainableNode
    {
        /// <summary>
        /// Chains a subsequent action to run after this node completes successfully.
        /// This is the most common chaining method, used to build simple sequential workflows.
        /// </summary>
        /// <param name="action">The action to append to the chain. Must not be <see langword="null"/>.</param>
        /// <returns>An <see cref="OperationChain"/> tracking the chain from this node's start to the appended action.</returns>
        /// <example>
        /// Build a linear workflow that composes a value and then returns an HTTP response:
        /// <code>
        /// var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
        /// var compose = WorkflowActions.BuiltIn.Compose(inputs: () => "Hello").WithName("Greet");
        /// var response = WorkflowActions.BuiltIn.Response(responseBody: () => $"{compose.Output}").WithName("Reply");
        ///
        /// trigger
        ///     .Then(compose)
        ///     .Then(response);
        /// </code>
        /// </example>
        OperationChain Then(IWorkflowAction action);

        /// <summary>
        /// Chains a subsequent action to run after this node with the specified run-after status conditions.
        /// Use this overload to execute an action only when the preceding operation reaches a particular status,
        /// such as <see cref="FlowStatus.Failed"/> or <see cref="FlowStatus.TimedOut"/>.
        /// </summary>
        /// <param name="action">The action to append to the chain. Must not be <see langword="null"/>.</param>
        /// <param name="runAfter">
        /// An array of <see cref="FlowStatus"/> values that determine when <paramref name="action"/> should execute.
        /// If <see langword="null"/>, defaults to <see cref="FlowStatus.Succeeded"/>.
        /// </param>
        /// <returns>An <see cref="OperationChain"/> tracking the chain from this node's start to the appended action.</returns>
        /// <remarks>
        /// This overload cannot be used on the first action directly after a trigger.
        /// Run-after conditions apply only between actions.
        /// </remarks>
        /// <example>
        /// Run an error-handling action when the previous action fails:
        /// <code>
        /// var process = WorkflowActions.BuiltIn.Compose(inputs: () => "Process").WithName("Process");
        /// var errorHandler = WorkflowActions.BuiltIn.Compose(inputs: () => "Error occurred").WithName("HandleError");
        ///
        /// trigger
        ///     .Then(process)
        ///     .Then(errorHandler, runAfter: new[] { FlowStatus.Failed, FlowStatus.TimedOut });
        /// </code>
        /// </example>
        OperationChain Then(IWorkflowAction action, FlowStatus[] runAfter);

        /// <summary>
        /// Chains a subsequent action to run after this node with explicit per-predecessor run-after configurations.
        /// Use this overload in fan-in scenarios where the action must wait for multiple predecessor chains,
        /// each with its own required completion status.
        /// </summary>
        /// <param name="action">The action to append to the chain. Must not be <see langword="null"/>.</param>
        /// <param name="runAfter">
        /// An array of <see cref="RunAfter"/> objects, each specifying a predecessor chain and the
        /// <see cref="FlowStatus"/> values required for the action to execute.
        /// </param>
        /// <returns>An <see cref="OperationChain"/> tracking the chain from this node's start to the appended action.</returns>
        /// <remarks>
        /// This overload cannot be used on the first action directly after a trigger.
        /// Each <see cref="RunAfter"/> must reference a chain with exactly one end node.
        /// </remarks>
        /// <example>
        /// Join two parallel branches and run a final action after both complete:
        /// <code>
        /// var leftChain = trigger
        ///     .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Left").WithName("Left"));
        /// var rightChain = trigger
        ///     .Then(WorkflowActions.BuiltIn.Compose(inputs: () => "Right").WithName("Right"));
        /// var merged = WorkflowActions.BuiltIn.Compose(inputs: () => "Done").WithName("Merged");
        ///
        /// leftChain
        ///     .Join(rightChain)
        ///     .Then(merged, runAfter: new[]
        ///     {
        ///         new RunAfter(leftChain, FlowStatus.Succeeded),
        ///         new RunAfter(rightChain, FlowStatus.Succeeded),
        ///     });
        /// </code>
        /// </example>
        OperationChain Then(IWorkflowAction action, RunAfter[] runAfter);

        /// <summary>
        /// Splits the chain into multiple parallel branches that all originate from this node.
        /// Each branch executes independently, and the resulting <see cref="OperationChain"/> tracks
        /// all branch endpoints, enabling subsequent <c>.Then()</c> calls to fan back in.
        /// </summary>
        /// <param name="branches">
        /// A callback that receives the current node as an <see cref="IChainableNode"/> and returns an array of
        /// <see cref="OperationChain"/> instances. Each chain must share the same root as the parent—that is,
        /// each branch must be created by calling <c>.Then()</c> on the provided parent node.
        /// </param>
        /// <returns>
        /// A new <see cref="OperationChain"/> with the same start node and the combined end nodes of all branches.
        /// </returns>
        /// <example>
        /// Fan out into parallel branches and then fan back in with a merged action:
        /// <code>
        /// var branch1 = WorkflowActions.BuiltIn.Compose(inputs: () => "Branch 1").WithName("Branch1");
        /// var branch2 = WorkflowActions.BuiltIn.Compose(inputs: () => "Branch 2").WithName("Branch2");
        /// var merged = WorkflowActions.BuiltIn.Compose(inputs: () => "Merged").WithName("Merged");
        ///
        /// trigger
        ///     .Then(parent => new[]
        ///     {
        ///         parent.Then(branch1),
        ///         parent.Then(branch2),
        ///     })
        ///     .Then(merged);
        /// </code>
        /// </example>
        OperationChain Then(Func<IChainableNode, OperationChain[]> branches);

        /// <summary>
        /// Gets the root operation (trigger or actions) of this chain.
        /// </summary>
        IWorkflowOperation GetRootOperation();
    }
}
