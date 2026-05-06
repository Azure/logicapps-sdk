// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice;

    /// <summary>
    /// ServiceNow workflow class.
    /// </summary>
    public class SerivceNowWorkflow : IWorkflowProvider
    {
        /// <summary>
        /// Gets the ServiceNow workflow definitions.
        /// </summary>
        public FlowDefinition[] GetWorkflows()
        {
            var inTrig = WorkflowTriggers.BuiltIn.CreateHttpTrigger();

            var assignGroup = WorkflowActions.ManagedConnectors.ServiceNow("service-now").GetRecords(
                () => "sys_user_group",
                sysparmQuery: () => "sys_id=" + inTrig.TriggerOutput.Headers["assignment_group"]
            );

            var getCustomers = WorkflowActions.ManagedConnectors.ServiceNow("service-now").GetRecords(
                () => "sys_user",
                sysparmQuery: () => "sys_id=" + inTrig.TriggerOutput.Headers["caller_id"]
            );

            var ticketDetails = WorkflowActions.BuiltIn.Compose(() => new
            {
                TicketNumber = inTrig.TriggerOutput.Headers["number"],
                CallerId = getCustomers.Body.Result[0]["name"],
                State = inTrig.TriggerOutput.Headers["state"] == "1" ? "New Ticket" : "Update Ticket",
                AssignmentGroup = assignGroup.Body.Result[0]["name"],
                ShortDescription = inTrig.TriggerOutput.Headers["short_description"],
                EmailAddress = getCustomers.Body.Result[0]["email"]
            });

            var email = WorkflowActions.BuiltIn.Compose(() => "text");

            var sendEmail = WorkflowActions.ManagedConnectors.Outlook("office365").SendEmailV2(
                emailMessageto: () => (string)email.Output["to"],
                emailMessagesubject: () => (string)email.Output["subject"],
                emailMessagebody: () => "<p class=\"editor-paragraph\">" + email.Output["body"] + "</p?"
            );

            var response = WorkflowActions.BuiltIn.Response(statusCode: () => System.Net.HttpStatusCode.Created);

            inTrig
                .Then(assignGroup)
                .Then(getCustomers)
                .Then(ticketDetails)
                .Then(email)
                .Then(sendEmail)
                .Then(response);

            return new[] { WorkflowFactory.CreateStatefulWorkflow("TicketEventCodeful", inTrig) };
        }
    }
}
