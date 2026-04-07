// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace la1
{
    using Microsoft.Azure.Workflows.Sdk;

    /// <summary>
    /// Control flow example workflows.
    /// </summary>
    public class ControlWorkflows
    {
        /// <summary>
        /// Adds the scope workflow.
        /// </summary>
        public void AddScopeWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Scope example
            var scope = WorkflowActions.BuiltIn.Control.Scope(actions: () =>
            {
                var compose1 = WorkflowActions.BuiltIn.Compose(inputs: () => "Scope compose 1");
                var compose2 = WorkflowActions.BuiltIn.Compose(inputs: () => "Scope compose 2");
                return compose1.Then(compose2);
            });

            // Nested scope example
            var nestedScope = WorkflowActions.BuiltIn.Control.Scope(actions: () =>
            {
                var composeOuter = WorkflowActions.BuiltIn.Compose(inputs: () => "Outer scope compose");
                var innerScope = WorkflowActions.BuiltIn.Control.Scope(actions: () =>
                {
                    var composeInner = WorkflowActions.BuiltIn.Compose(inputs: () => "Inner scope compose");
                    return composeInner;
                });
                return composeOuter.Then(innerScope);
            });

            trigger
                .Then(scope)
                .Then(nestedScope);
            
            WorkflowFactory.CreateStatefulWorkflow("scope", trigger);
        }

        /// <summary>
        /// Adds the condition workflow.
        /// </summary>
        public void AddConditionWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Condition example
            var condition = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => trigger.TriggerOutput.Body["condition"].ToString() == "foo",
                trueBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Condition true branch"),
                falseBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Condition false branch"));

            // Nested condition example
            var nestedCondition = WorkflowActions.BuiltIn.Control.Condition(
                expression: () => trigger.TriggerOutput.Body["outerCondition"].ToString() == "foo",
                trueBranch: () =>
                {
                    var innerCondition = WorkflowActions.BuiltIn.Control.Condition(
                        expression: () => trigger.TriggerOutput.Body["innerCondition"].ToString() == "bar",
                        trueBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Nested inner condition true branch"),
                        falseBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Nested inner condition false branch"));
                    return innerCondition;
                },
                falseBranch: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Nested condition false branch"));
            
            trigger
                .Then(condition)
                .Then(nestedCondition);

            WorkflowFactory.CreateStatefulWorkflow("condition", trigger);
        }

        /// <summary>
        /// Adds the ForEach workflow.
        /// </summary>
        public void AddForEachWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // ForEach example
            var forEach = WorkflowActions.BuiltIn.Control.ForEach(
                items: () => trigger.TriggerOutput.Body["items"]!,
                actions: (currentItem) =>
                {
                    return WorkflowActions.BuiltIn.Compose(inputs: () => $"Processing item: {currentItem}");
                });

            // Nested ForEach example
            var nestedForEach = WorkflowActions.BuiltIn.Control.ForEach(
                items: () => trigger.TriggerOutput.Body["outerItems"]!,
                actions: (currentOuterItem) =>
                {
                    var composeOuter = WorkflowActions.BuiltIn.Compose(inputs: () => $"Processing outer item: {currentOuterItem}");
                    var innerForEach = WorkflowActions.BuiltIn.Control.ForEach(
                        items: () => trigger.TriggerOutput.Body["innerItems"]!,
                        actions: (currentInnerItem) =>
                        {
                            return WorkflowActions.BuiltIn.Compose(inputs: () => $"Processing outer item: {currentOuterItem}, inner item: {currentInnerItem}");
                        });
                    return composeOuter.Then(innerForEach);
                });
            
            trigger
                .Then(forEach)
                .Then(nestedForEach);

            WorkflowFactory.CreateStatefulWorkflow("foreach", trigger);
        }

        /// <summary>
        /// Adds the Until workflow.
        /// </summary>
        public void AddUntilWorkflow()
        {
            // TODO: Uncomment when WorkflowActions.BuiltIn.Variables is implemented.
            /*
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Until example
            var counter = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: "counter", value: 0);
            var until = WorkflowActions.BuiltIn.Control.Until(
                expression: () => counter.Value.ToObject<int>() == 5,
                actions: () =>
                {
                    return WorkflowActions.BuiltIn.Variables.IncrementVariable(name: "counter", value: 1);
                });

            // Nested Until example
            var outerCounter = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: "outerCounter", value: 0);
            var innerCounter = WorkflowActions.BuiltIn.Variables.InitializeVariable(name: "innerCounter", value: 0);
            var nestedUntil = WorkflowActions.BuiltIn.Control.Until(
                expression: () => outerCounter.Value.ToObject<int>() == 3,
                actions: () =>
                {
                    var incrementOuter = WorkflowActions.BuiltIn.Variables.IncrementVariable(name: "outerCounter", value: 1);
                    var innerUntil = WorkflowActions.BuiltIn.Control.Until(
                        expression: () => innerCounter.Value.ToObject<int>() == 2,
                        actions: () =>
                        {
                            return WorkflowActions.BuiltIn.Variables.IncrementVariable(name: "innerCounter", value: 1);
                        });
                    return incrementOuter.Then(innerUntil);
                });

            trigger
                .Then(counter)
                .Then(until)
                .Then(outerCounter)
                .Then(innerCounter)
                .Then(nestedUntil);
            
            WorkflowFactory.CreateStatefulWorkflow("until", trigger);
            */
        }

        /// <summary>
        /// Adds the Switch workflow.
        /// </summary>
        public void AddSwitchWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Switch example
            var switchAction = WorkflowActions.BuiltIn.Control.Switch(
                on: () => trigger.TriggerOutput.Body["status"]!.ToString(),
                cases: () =>
                {
                    var case1Action1 = WorkflowActions.BuiltIn.Compose(inputs: () => "Case 1");
                    var case1Action2 = WorkflowActions.BuiltIn.Compose(inputs: () => "Case 1 - second action");
                    var case2Action1 = WorkflowActions.BuiltIn.Compose(inputs: () => "Case 2");

                    return new Dictionary<string, SwitchCase>
                    {
                        { "case1_label", new SwitchCase(caseValue: "case1", actions: case1Action1.Then(case1Action2)) },
                        { "case2_label", new SwitchCase(caseValue: "case2", actions: case2Action1) }
                    };
                },
                defaultCase: () => WorkflowActions.BuiltIn.Compose(inputs: () => "Default case"));

            WorkflowFactory.CreateStatefulWorkflow("switch", trigger);
        }

        /// <summary>
        /// Adds the Terminate workflow.
        /// </summary>
        public void AddTerminateWorkflow()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            // Terminate example
            var terminate = WorkflowActions.BuiltIn.Control.Terminate(
                status: () => FlowStatus.Failed,
                message: () => "Terminating workflow");

            trigger.Then(terminate);

            WorkflowFactory.CreateStatefulWorkflow("terminate", trigger);
        }
    }
}