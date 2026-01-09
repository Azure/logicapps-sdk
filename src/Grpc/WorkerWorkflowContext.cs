// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk
{
    using System.Threading.Tasks;
    using Microsoft.Azure.Workflows.Sdk.Grpc;
    using Newtonsoft.Json;

    /// <summary>
    /// The workflow context.
    /// </summary>
    public class WorkerWorkflowContext : WorkflowContext
    {
        /// <summary>
        /// Gets or sets the session cache.
        /// </summary>
        private IJobSessionService.IJobSessionServiceClient Session { get; set; }

        /// <summary>
        /// Gets or sets the session id.
        /// </summary>
        private string SessionId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowContext"/> class.
        /// </summary>
        /// <param name="sessionService">The session service.</param>
        /// <param name="sessionId">The session id.</param>
        public WorkerWorkflowContext(IJobSessionService.IJobSessionServiceClient sessionService, string sessionId)
        {
            this.Session = sessionService;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Get action results.
        /// </summary>
        /// <param name="actionName">The action name.</param>
        public override async Task<WorkflowOperationResult> GetActionResults(string actionName)
        {
            var actionResult = await this.Session.GetActionOutputsAsync(new ActionRequest { ActionName = actionName, SessionId = this.SessionId })
                .ConfigureAwait(continueOnCapturedContext: false);

            return JsonConvert.DeserializeObject<WorkflowOperationResult>(actionResult?.Outputs);
        }

        /// <summary>
        /// Get trigger results.
        /// </summary>
        public override async Task<WorkflowOperationResult> GetTriggerResults()
        {
            var triggerResult = await this.Session.GetTriggerOutputAsync(new TriggerRequest { SessionId = this.SessionId })
                .ConfigureAwait(continueOnCapturedContext: false);
            return JsonConvert.DeserializeObject<WorkflowOperationResult>(triggerResult?.Outputs);
        }
    }
}
