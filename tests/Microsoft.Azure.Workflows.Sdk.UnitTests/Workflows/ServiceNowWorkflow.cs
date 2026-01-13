// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureagentservice;

    /// <summary>
    /// Weather workflow class.
    /// </summary>
    public static class SerivceNowWorkflow
    {
        /// <summary>
        /// Adds the weather workflow.
        /// </summary>
        public static void AddWorkflow()
        {
            var inTrig = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("TicketEventCodeful", inTrig);

            var assignGroup = WorkflowActions.ManagedConnectors.ServiceNow("service-now").GetRecords(
                () => "sys_user_group",
                sysparmQuery: () => "sys_id=" + inTrig.TriggerOutput.Headers["assignment_group"]
            );
            builder.AddAction(assignGroup);

            var getCustomers = WorkflowActions.ManagedConnectors.ServiceNow("service-now").GetRecords(
                () => "sys_user",
                sysparmQuery: () => "sys_id=" + inTrig.TriggerOutput.Headers["caller_id"]
            );
            builder.AddAction(getCustomers);

            var ticketDetails = WorkflowActions.BuiltIn.Compose(() => new
            {
                TicketNumber = inTrig.TriggerOutput.Headers["number"],
                CallerId = getCustomers.Body.Result[0]["name"],
                State = inTrig.TriggerOutput.Headers["state"] == "1" ? "New Ticket" : "Update Ticket",
                AssignmentGroup = assignGroup.Body.Result[0]["name"],
                ShortDescription = inTrig.TriggerOutput.Headers["short_description"],
                EmailAddress = getCustomers.Body.Result[0]["email"]
            });
            builder.AddAction(ticketDetails);

            var agentInvoke = WorkflowActions.ManagedConnectors.Azureagentservice("azureagentservice").InvokeAgent(
                apiVersion: () => apiVersionInput._20251115Preview,
                bodyagentname: () => "customer-retention-agent",
                bodyagenttype: () => bodyagenttypeInput.AgentReference,
                bodyagentversion: () => "4",
                bodybackground: () => false,
                bodyparallelToolCalls: () => true,
                bodystore: () => true,
                bodyconversationid: () => "conv_930386e58adfe3dc00cIPHWgShJlBJNNyLsAa6ekOBzmhtqT85", // startConversation.Body["id"],
                bodyinput: () => ticketDetails.Output.ToString()
            );
            builder.AddAction(agentInvoke);

            var email = WorkflowActions.BuiltIn.Compose(() => WorkflowFunctions.ToJson(agentInvoke.Body.Output[0].Content[0].Text));
            builder.AddAction(email);

            var sendEmail = WorkflowActions.ManagedConnectors.Outlook("office365").SendEmailV2(
                emailMessageto: () => (string)email.Output["to"],
                emailMessagesubject: () => (string)email.Output["subject"],
                emailMessagebody: () => "<p class=\"editor-paragraph\">" + email.Output["body"] + "</p?"
            );
            builder.AddAction(sendEmail);

            var response = WorkflowActions.BuiltIn.Response(statusCode: () => System.Net.HttpStatusCode.Created);
            builder.AddAction(response);

            /*
            var agentInvoke = WorkflowActions.ManagedConnectors.Azureagentservice("").InvokeAgent(
                apiVersion: () => Microsoft.Azure.Workflows.Sdk.Agents.Connectors.Azureagentservice.apiVersionInput._20251115Preview,
                bodyagentname: () => "customer-retention-agent",
                bodyagenttype: () => Microsoft.Azure.Workflows.Sdk.Agents.Connectors.Azureagentservice.bodyagenttypeInput.AgentReference,
                bodybackground: () => false,
                bodyparallelToolCalls: () => true,
                bodystore: () => true
            ); 
            builder.AddAction(agentInvoke);

            /*

            var compose = WorkflowActions.BuiltIn.Compose(() => WorkflowConvert.ToJson<T>(agentInvoke.Body.Output[0]));
            /*
            var trigger = WorkflowTriggers.Managed.Msnweather("msnweather").OnCurrentWeatherChange(
                location: () => "Seattle, WA",
                measure: () => measureInput.Temperature,
                when: () => whenInput.IsEqualTo,
                target: () => 70,
                units: () => "I"
            );

            trigger.WithName("weather_trigger");
            trigger.WithRecurrence(new FlowRecurrence
            {
                Frequency = FlowRecurrenceFrequency.Minute,
                Interval = 1
            });

            var builder = WorkflowBuilderFactory.CreateStatefulWorkflow("MyWeatherWorkflow", trigger);

            var msg = WorkflowActions.ManagedConnectors.Teams("teams").PostMessageToConversation(
                poster: () => posterInput.User,
                location: () => "Group chat",
                body: () => new
                {
                    recipient = "19:meeting_Y2IyMGY4YmEtNTk1Mi00NjM0LWI4YTYtNDg4M2E3ZTIwMTk1@thread.v2",
                    messageBody = $"The weather changed! The new temperature is °F" + $"{builder.TriggerOutput.Responses.Weather.Current.Temperature}"
                });
            builder.AddAction(msg);
            */
        }
    }
}
