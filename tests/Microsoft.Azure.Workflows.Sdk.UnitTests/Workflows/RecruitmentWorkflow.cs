// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tests
{
    using Microsoft.Azure.Workflows.Sdk;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365;
    using Newtonsoft.Json;

    /// <summary>
    /// Recruitment workflow class.
    /// </summary>
    public static class RecruitmentWorkflow
    {
        /// <summary>
        /// Adds the recruitment workflow.
        /// </summary>
        public static void AddRecruitmentWorkflow()
        {
            var builder = WorkflowBuilderFactory.CreateConversationalAgent("RecruitmentWorkflow");

            var agent = new AgentBuilder
            {
                AgentModelType = AgentModelType.AzureOpenAI,
                DeploymentId = "gpt-4.1",
                AgentModelSettings = new AgentModelSettings
                {
                    AgentChatCompletionSettings = new AgentChatCompletionSettings
                    {
                        MaxTokens = 3000,
                        Temperature = 0.7,
                        FrequencyPenalty = 0.1,
                        PresencePenalty = 0.1,
                        TopP = 0.1,
                    },
                    DeploymentModelProperties = new AgentDeploymentModelProperties
                    {
                        Name = "gpt-4o",
                        Format = "OpenAI",
                        Version = "2024-11-20"
                    }
                },
                Messages = new AgentPromptMessage[]
                    {
            new AgentPromptMessage
            {
                Role = MessageRole.System,
                Content = "You are a recruitment agent whose role is to help recuriters identify candidates and subsequently help them book interviews using the tools that are provided.\n\nA recruiter may ask the following questions to you:\n\nShow me my job postings. If your are unsure which recruiter you are chatting with, you can use apseth@microsoft.com as the user name.\nSelect top candidates for a particular Job Posting ID\nWhat does my candidate schedule look like for a specific date. Ensure this value is provided by the recuiter and assume the current year comes from this value: @{utcNow()}.\n\nIf user is not logged in, send the tool response as HTML with the consent link to the user to login. Please schedule interviews with candidates based upon my schedule availability. \nAfter the meeting is booked we need to communicate to the interview team that the meeting is booked\n\nUnless specificed othwerwise, please assume all timezone related querys are in (UTC-07:00) Mountain Time (US & Canada). So that includes when displaying dates for the user and when booking meetings.\nSend a teams message"
            }
                    },
                ConnectionName = "agent-2",
            };

            var toolBuilder = new AgentTool<MyObject>();

            agent.AddTool(b =>
            {
                var getCandidates = WorkflowActions.ManagedConnectors.Commondataservice("commondataservice").ListRecords(
                    organization: () => "https://org7a3fb188.crm.dynamics.com",
                    entityName: () => "cred1_recruitmentcandiateses",
                    select: () => "cred1_candidatename,cred1_candidateid,cred1_jobpostingid, cred1_candidateemail,cred1_candidateprofilelink",
                    filter: () => $"cred1_jobpostingid eq '{b.Parameters.JobPostingId}'");
                b.AddAction(getCandidates);
            },
               description: "This tool will get a list of job candidates based upon a Posting ID",
               parameters: new JobPostingAgentParameter());

            agent.AddTool(b =>
            {
                var getCandidates = WorkflowActions.ManagedConnectors.Commondataservice("commondataservice").ListRecords(
                    organization: () => "https://org7a3fb188.crm.dynamics.com",
                    entityName: () => "cred1_recruitmentpostingses",
                    select: () => "cred1_postingenddate,cred1_postingowner,cred1_postingid,cred1_postingstatus",
                    filter: () => $"cred1_postingowner eq '{b.Parameters.JobPostingOwner}'");
                b.AddAction(getCandidates);
            },
               description: "This tool will retreive all of the job postings that are owned by a particular recruiter",
               parameters: new RecruiterParameterObject());

            agent.AddTool(b =>
            {
                var getCalendar = WorkflowActions.ManagedConnectors.Office365("office365").CalendarGetTablesV2();
                b.AddAction(getCalendar);

                var createEvent = WorkflowActions.ManagedConnectors.Office365("office365").V4CalendarPostItem(
                    table: () => getCalendar.Body.Value[1].ID, // "body('Get_calendars_for_meeting')?['value'][1]['id']",
                    itemsubject: () => $"Job Interview with Contoso - {b.Parameters.CandidateName}",
                    itemstartTime: () => "@agentParameters('MeetingStartTime')",
                    itemendTime: () => "@agentParameters('MeetingEndTime')",
                    itemtimeZone: () => itemtimeZoneInput.UTC0800PacificTimeUSCanada,
                    itemrequiredAttendees: () => b.Parameters.CandidateEmail,
                    itembody: () => $"<p class=\"editor-paragraph\">Hi {b.Parameters.CandidateName} ,</p><p class=\"editor-paragraph\"><br>I would like to invite you to interview for a position at Contoso.<br><br>Please accept or decline this meeting invite.<br><br>Regards,<br><br>Contoso Hiring Team</p>");
                b.AddAction(createEvent);
            },
               description: "This tool will book a meeting between the recruiter and the job candidate",
               parameters: new CandidateDetailsObject());

            agent.AddTool(b =>
            {
                var upcomingInterviews = WorkflowActions.ManagedConnectors.Commondataservice("commondataservice").ListRecords(
                    organization: () => "https://org7a3fb188.crm.dynamics.com",
                    entityName: () => "cred1_recruitmentmeetingses",
                    select: () => "cred1_meetingid,cred1_candidateemail,cred1_candidatename,cred1_intervieweremail,cred1_interviewdatetime",
                    filter: () => string.Concat("cred1_intervieweremail eq '", b.Parameters.JobPostingOwner, "'"));
                b.AddAction(upcomingInterviews);
            },
               description: "This tool will get the upcoming interview meetings",
               parameters: new RecruiterParameterObject());

            /*
                agent.AddTool(b =>
                    {
                        var action = b.GetManagedConnectors().Teams.PostMessageToConversation(
                            connectionId: "teams",
                            // groupId: b => "f5e981ba-0fae-4515-a907-cce34c49e11d",
                            channelId: b => "19:f79df695687141348f95d044ad4a2648@thread.skype",
                            body: b => new PostMessageToChannelV3bodyInput
                            {
                                Body = new PostMessageToChannelV3bodyInputBodyType
                                {
                                    Content = string.Concat("Interview Details:\nCandidate Name: ", b.Parameters.CandidateName, "\nCandidate Email: ", b.Parameters.CandidateEmail, "\nInterview DateTime: ", b.Parameters.InterviewDateTime, "\nInterviewer Email: ", b.Parameters.InterviewerEmail),
                                    ContentType = "Text"
                                }
                            });
                        b.AddAction(action);
                    },
                   description: "Notify interview team with interview details",
                   parameters: new CandidateDetailsObject());
        */
            builder.AddAgent(agent);
        }
    }

    /// <summary>
    /// My object class.
    /// </summary>
    public class RecruiterParameterObject
    {
        /// <summary>
        /// posting owner property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string JobPostingOwner { get; set; } = string.Empty;
    }

    /// <summary>
    /// My object class.
    /// </summary>
    public class JobPostingAgentParameter
    {
        /// <summary>
        /// posting owner property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string JobPostingId { get; set; } = string.Empty;
    }

    /// <summary>
    /// My object class.
    /// </summary>
    public class MyObject
    {
        /// <summary>
        /// current weather location property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string CurrentWeatherLocation { get; set; } = string.Empty;
    }

    /// <summary>
    /// Candidate details class.
    /// </summary>
    public class CandidateDetailsObject
    {
        /// <summary>
        /// Candidate email property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string CandidateEmail { get; set; } = string.Empty;

        /// <summary>
        /// Candidate name property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string CandidateName { get; set; } = string.Empty;

        /// <summary>
        /// Candidate interview date time property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string InterviewDateTime { get; set; } = string.Empty;

        /// <summary>
        /// Candidate interviewer email property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string InterviewerEmail { get; set; } = string.Empty;

        /// <summary>
        /// Meeting start time property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string MeetingStartTime { get; set; } = string.Empty;

        /// <summary>
        /// Meeting end time property.
        /// </summary>
        [JsonProperty(Required = Required.Default)]
        public string MeetingEndTime { get; set; } = string.Empty;
    }
}
