// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Represents a single case in a Switch action, containing the case match value and its actions.
    /// </summary>
    public class SwitchCase
    {
        /// <summary>
        /// Gets or sets the case match value.
        /// </summary>
        public JToken Case { get; set; }

        /// <summary>
        /// Gets or sets the root action node for this case.
        /// </summary>
        public IWorkflowAction Actions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SwitchCase"/> class.
        /// </summary>
        /// <param name="caseValue">The value to match for this case.</param>
        /// <param name="actions">The actions node for this case.</param>
        public SwitchCase(JToken caseValue, IChainableNode actions)
        {
            this.Case = caseValue;
            this.Actions = actions?.GetRootOperation() as IWorkflowAction;
        }
    }
}
