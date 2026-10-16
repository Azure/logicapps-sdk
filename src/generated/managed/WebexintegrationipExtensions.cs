//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webexintegrationip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class WebexintegrationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<ReadMeetingResponse> ReadMeetings(Expression<Func<string>> contentType = null, Expression<Func<string>> password = null, Expression<Func<string>> timezone = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_password = WorkflowExpression.Compile(password, nameof(password), required: false);
            var __workflow_timezone = WorkflowExpression.Compile(timezone, nameof(timezone), required: false);
            return new DeferredBodyAction<ReadMeetingResponse>(() =>
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_password != null)
                    callPayload.Headers["password"] = ExpressionConverter.Convert(__workflow_password);
                if (__workflow_timezone != null)
                    callPayload.Headers["timezone"] = ExpressionConverter.Convert(__workflow_timezone);
                return new ApiConnectionAction<ReadMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<CreateAMeetingResponse> CreateAMeeting(Expression<Func<string>> contentType, Expression<Func<string>> bodytitle, Expression<Func<string>> bodystart, Expression<Func<string>> bodyend, Expression<Func<string>> bodyagenda = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodytimezone = null, Expression<Func<bool>> bodyenabledAutoRecordMeeting = null, Expression<Func<bool>> bodyallowAnyUserToBeCoHost = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: true);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: true);
            var __workflow_bodyagenda = WorkflowExpression.Compile(bodyagenda, nameof(bodyagenda), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodyenabledAutoRecordMeeting = WorkflowExpression.Compile(bodyenabledAutoRecordMeeting, nameof(bodyenabledAutoRecordMeeting), required: false);
            var __workflow_bodyallowAnyUserToBeCoHost = WorkflowExpression.Compile(bodyallowAnyUserToBeCoHost, nameof(bodyallowAnyUserToBeCoHost), required: false);
            return new DeferredBodyAction<CreateAMeetingResponse>(() =>
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (__workflow_bodyagenda != null)
                {
                    body["agenda"] = ExpressionConverter.ConvertO(__workflow_bodyagenda);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                bodypropCount++;
                body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                bodypropCount++;
                body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                if (__workflow_bodytimezone != null)
                {
                    if (__workflow_bodytimezone != null)
                    {
                        body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["timezone"] = "Europe/London";
                    bodypropCount++;
                }

                if (__workflow_bodyenabledAutoRecordMeeting != null)
                {
                    if (__workflow_bodyenabledAutoRecordMeeting != null)
                    {
                        body["enabledAutoRecordMeeting"] = ExpressionConverter.ConvertO(__workflow_bodyenabledAutoRecordMeeting);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enabledAutoRecordMeeting"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodyallowAnyUserToBeCoHost != null)
                {
                    if (__workflow_bodyallowAnyUserToBeCoHost != null)
                    {
                        body["allowAnyUserToBeCoHost"] = ExpressionConverter.ConvertO(__workflow_bodyallowAnyUserToBeCoHost);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["allowAnyUserToBeCoHost"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction CreateAInvitee(Expression<Func<string>> bodymeetingId, Expression<Func<string>> bodyemail, Expression<Func<string>> contentType = null, Expression<Func<string>> bodydisplayName = null, Expression<Func<string>> bodycoHost = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodysendEmail = null, Expression<Func<string>> bodypanelist = null)
        {
            var __workflow_bodymeetingId = WorkflowExpression.Compile(bodymeetingId, nameof(bodymeetingId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_bodydisplayName = WorkflowExpression.Compile(bodydisplayName, nameof(bodydisplayName), required: false);
            var __workflow_bodycoHost = WorkflowExpression.Compile(bodycoHost, nameof(bodycoHost), required: false);
            var __workflow_bodyhostEmail = WorkflowExpression.Compile(bodyhostEmail, nameof(bodyhostEmail), required: false);
            var __workflow_bodysendEmail = WorkflowExpression.Compile(bodysendEmail, nameof(bodysendEmail), required: false);
            var __workflow_bodypanelist = WorkflowExpression.Compile(bodypanelist, nameof(bodypanelist), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/meetingInvitees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["meetingId"] = ExpressionConverter.ConvertO(__workflow_bodymeetingId);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (__workflow_bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(__workflow_bodydisplayName);
                    bodypropCount++;
                }

                if (__workflow_bodycoHost != null)
                {
                    body["coHost"] = ExpressionConverter.ConvertO(__workflow_bodycoHost);
                    bodypropCount++;
                }

                if (__workflow_bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhostEmail);
                    bodypropCount++;
                }

                if (__workflow_bodysendEmail != null)
                {
                    body["sendEmail"] = ExpressionConverter.ConvertO(__workflow_bodysendEmail);
                    bodypropCount++;
                }

                if (__workflow_bodypanelist != null)
                {
                    body["panelist"] = ExpressionConverter.ConvertO(__workflow_bodypanelist);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction DeleteAMeeting(Expression<Func<string>> meetingId)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meetings/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_meetingId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction UpdateAMeeting(Expression<Func<string>> meetingId, Expression<Func<string>> contentType = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyagenda = null, Expression<Func<string>> bodypassword = null, Expression<Func<string>> bodytimezone = null, Expression<Func<string>> bodystart = null, Expression<Func<string>> bodyend = null, Expression<Func<bool>> bodyenabledAutoRecordMeeting = null, Expression<Func<bool>> bodyallowAnyUserToBeCoHost = null, Expression<Func<bool>> bodyenabledJoinBeforeHost = null, Expression<Func<bool>> bodyenableConnectAudioBeforeHost = null, Expression<Func<int>> bodyjoinBeforeHostMinutes = null, Expression<Func<bool>> bodyexcludePassword = null, Expression<Func<bool>> bodypublicMeeting = null, Expression<Func<int>> bodyreminderTime = null, Expression<Func<string>> bodyunlockedMeetingJoinSecurity = null, Expression<Func<bool>> bodyenableAutomaticLock = null, Expression<Func<int>> bodyautomaticLockMinutes = null, Expression<Func<bool>> bodyallowFirstUserToBeCoHost = null, Expression<Func<bool>> bodyallowAuthenticatedDevices = null, Expression<Func<bool>> bodysendEmail = null, Expression<Func<string>> bodyhostEmail = null, Expression<Func<string>> bodysiteUrl = null, Expression<Func<bool>> bodymeetingOptionsenabledChat = null, Expression<Func<bool>> bodymeetingOptionsenabledVideo = null, Expression<Func<bool>> bodymeetingOptionsenabledPolling = null, Expression<Func<bool>> bodymeetingOptionsenabledNote = null, Expression<Func<string>> bodymeetingOptionsnoteType = null, Expression<Func<bool>> bodymeetingOptionsenabledClosedCaptions = null, Expression<Func<bool>> bodymeetingOptionsenabledFileTransfer = null, Expression<Func<bool>> bodymeetingOptionsenabledUCFRichMedia = null, Expression<Func<bool>> bodyattendeePrivilegesenabledShareContent = null, Expression<Func<bool>> bodyattendeePrivilegesenabledSaveDocument = null, Expression<Func<bool>> bodyattendeePrivilegesenabledPrintDocument = null, Expression<Func<bool>> bodyattendeePrivilegesenabledAnnotate = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewParticipantList = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewThumbnails = null, Expression<Func<bool>> bodyattendeePrivilegesenabledRemoteControl = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewAnyDocument = null, Expression<Func<bool>> bodyattendeePrivilegesenabledViewAnyPage = null, Expression<Func<bool>> bodyattendeePrivilegesenabledContactOperatorPrivately = null, Expression<Func<bool>> bodyattendeePrivilegesenabledChatHost = null, Expression<Func<bool>> bodyattendeePrivilegesenabledChatPresenter = null, Expression<Func<bool>> bodyattendeePrivilegesenabledChatOtherParticipants = null, Expression<Func<string[]>> bodyintegrationTags = null, Expression<Func<bool>> bodyenabledBreakoutSessions = null, Expression<Func<bodytrackingCodesInputItem[]>> bodytrackingCodes = null, Expression<Func<string>> bodyaudioConnectionOptionsaudioConnectionType = null, Expression<Func<bool>> bodyaudioConnectionOptionsenabledTollFreeCallIn = null, Expression<Func<bool>> bodyaudioConnectionOptionsenabledGlobalCallIn = null, Expression<Func<bool>> bodyaudioConnectionOptionsenabledAudienceCallBack = null, Expression<Func<string>> bodyaudioConnectionOptionsentryAndExitTone = null, Expression<Func<bool>> bodyaudioConnectionOptionsallowHostToUnmuteParticipants = null, Expression<Func<bool>> bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf = null, Expression<Func<bool>> bodyaudioConnectionOptionsmuteAttendeeUponEntry = null)
        {
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyagenda = WorkflowExpression.Compile(bodyagenda, nameof(bodyagenda), required: false);
            var __workflow_bodypassword = WorkflowExpression.Compile(bodypassword, nameof(bodypassword), required: false);
            var __workflow_bodytimezone = WorkflowExpression.Compile(bodytimezone, nameof(bodytimezone), required: false);
            var __workflow_bodystart = WorkflowExpression.Compile(bodystart, nameof(bodystart), required: false);
            var __workflow_bodyend = WorkflowExpression.Compile(bodyend, nameof(bodyend), required: false);
            var __workflow_bodyenabledAutoRecordMeeting = WorkflowExpression.Compile(bodyenabledAutoRecordMeeting, nameof(bodyenabledAutoRecordMeeting), required: false);
            var __workflow_bodyallowAnyUserToBeCoHost = WorkflowExpression.Compile(bodyallowAnyUserToBeCoHost, nameof(bodyallowAnyUserToBeCoHost), required: false);
            var __workflow_bodyenabledJoinBeforeHost = WorkflowExpression.Compile(bodyenabledJoinBeforeHost, nameof(bodyenabledJoinBeforeHost), required: false);
            var __workflow_bodyenableConnectAudioBeforeHost = WorkflowExpression.Compile(bodyenableConnectAudioBeforeHost, nameof(bodyenableConnectAudioBeforeHost), required: false);
            var __workflow_bodyjoinBeforeHostMinutes = WorkflowExpression.Compile(bodyjoinBeforeHostMinutes, nameof(bodyjoinBeforeHostMinutes), required: false);
            var __workflow_bodyexcludePassword = WorkflowExpression.Compile(bodyexcludePassword, nameof(bodyexcludePassword), required: false);
            var __workflow_bodypublicMeeting = WorkflowExpression.Compile(bodypublicMeeting, nameof(bodypublicMeeting), required: false);
            var __workflow_bodyreminderTime = WorkflowExpression.Compile(bodyreminderTime, nameof(bodyreminderTime), required: false);
            var __workflow_bodyunlockedMeetingJoinSecurity = WorkflowExpression.Compile(bodyunlockedMeetingJoinSecurity, nameof(bodyunlockedMeetingJoinSecurity), required: false);
            var __workflow_bodyenableAutomaticLock = WorkflowExpression.Compile(bodyenableAutomaticLock, nameof(bodyenableAutomaticLock), required: false);
            var __workflow_bodyautomaticLockMinutes = WorkflowExpression.Compile(bodyautomaticLockMinutes, nameof(bodyautomaticLockMinutes), required: false);
            var __workflow_bodyallowFirstUserToBeCoHost = WorkflowExpression.Compile(bodyallowFirstUserToBeCoHost, nameof(bodyallowFirstUserToBeCoHost), required: false);
            var __workflow_bodyallowAuthenticatedDevices = WorkflowExpression.Compile(bodyallowAuthenticatedDevices, nameof(bodyallowAuthenticatedDevices), required: false);
            var __workflow_bodysendEmail = WorkflowExpression.Compile(bodysendEmail, nameof(bodysendEmail), required: false);
            var __workflow_bodyhostEmail = WorkflowExpression.Compile(bodyhostEmail, nameof(bodyhostEmail), required: false);
            var __workflow_bodysiteUrl = WorkflowExpression.Compile(bodysiteUrl, nameof(bodysiteUrl), required: false);
            var __workflow_bodymeetingOptionsenabledChat = WorkflowExpression.Compile(bodymeetingOptionsenabledChat, nameof(bodymeetingOptionsenabledChat), required: false);
            var __workflow_bodymeetingOptionsenabledVideo = WorkflowExpression.Compile(bodymeetingOptionsenabledVideo, nameof(bodymeetingOptionsenabledVideo), required: false);
            var __workflow_bodymeetingOptionsenabledPolling = WorkflowExpression.Compile(bodymeetingOptionsenabledPolling, nameof(bodymeetingOptionsenabledPolling), required: false);
            var __workflow_bodymeetingOptionsenabledNote = WorkflowExpression.Compile(bodymeetingOptionsenabledNote, nameof(bodymeetingOptionsenabledNote), required: false);
            var __workflow_bodymeetingOptionsnoteType = WorkflowExpression.Compile(bodymeetingOptionsnoteType, nameof(bodymeetingOptionsnoteType), required: false);
            var __workflow_bodymeetingOptionsenabledClosedCaptions = WorkflowExpression.Compile(bodymeetingOptionsenabledClosedCaptions, nameof(bodymeetingOptionsenabledClosedCaptions), required: false);
            var __workflow_bodymeetingOptionsenabledFileTransfer = WorkflowExpression.Compile(bodymeetingOptionsenabledFileTransfer, nameof(bodymeetingOptionsenabledFileTransfer), required: false);
            var __workflow_bodymeetingOptionsenabledUCFRichMedia = WorkflowExpression.Compile(bodymeetingOptionsenabledUCFRichMedia, nameof(bodymeetingOptionsenabledUCFRichMedia), required: false);
            var __workflow_bodyattendeePrivilegesenabledShareContent = WorkflowExpression.Compile(bodyattendeePrivilegesenabledShareContent, nameof(bodyattendeePrivilegesenabledShareContent), required: false);
            var __workflow_bodyattendeePrivilegesenabledSaveDocument = WorkflowExpression.Compile(bodyattendeePrivilegesenabledSaveDocument, nameof(bodyattendeePrivilegesenabledSaveDocument), required: false);
            var __workflow_bodyattendeePrivilegesenabledPrintDocument = WorkflowExpression.Compile(bodyattendeePrivilegesenabledPrintDocument, nameof(bodyattendeePrivilegesenabledPrintDocument), required: false);
            var __workflow_bodyattendeePrivilegesenabledAnnotate = WorkflowExpression.Compile(bodyattendeePrivilegesenabledAnnotate, nameof(bodyattendeePrivilegesenabledAnnotate), required: false);
            var __workflow_bodyattendeePrivilegesenabledViewParticipantList = WorkflowExpression.Compile(bodyattendeePrivilegesenabledViewParticipantList, nameof(bodyattendeePrivilegesenabledViewParticipantList), required: false);
            var __workflow_bodyattendeePrivilegesenabledViewThumbnails = WorkflowExpression.Compile(bodyattendeePrivilegesenabledViewThumbnails, nameof(bodyattendeePrivilegesenabledViewThumbnails), required: false);
            var __workflow_bodyattendeePrivilegesenabledRemoteControl = WorkflowExpression.Compile(bodyattendeePrivilegesenabledRemoteControl, nameof(bodyattendeePrivilegesenabledRemoteControl), required: false);
            var __workflow_bodyattendeePrivilegesenabledViewAnyDocument = WorkflowExpression.Compile(bodyattendeePrivilegesenabledViewAnyDocument, nameof(bodyattendeePrivilegesenabledViewAnyDocument), required: false);
            var __workflow_bodyattendeePrivilegesenabledViewAnyPage = WorkflowExpression.Compile(bodyattendeePrivilegesenabledViewAnyPage, nameof(bodyattendeePrivilegesenabledViewAnyPage), required: false);
            var __workflow_bodyattendeePrivilegesenabledContactOperatorPrivately = WorkflowExpression.Compile(bodyattendeePrivilegesenabledContactOperatorPrivately, nameof(bodyattendeePrivilegesenabledContactOperatorPrivately), required: false);
            var __workflow_bodyattendeePrivilegesenabledChatHost = WorkflowExpression.Compile(bodyattendeePrivilegesenabledChatHost, nameof(bodyattendeePrivilegesenabledChatHost), required: false);
            var __workflow_bodyattendeePrivilegesenabledChatPresenter = WorkflowExpression.Compile(bodyattendeePrivilegesenabledChatPresenter, nameof(bodyattendeePrivilegesenabledChatPresenter), required: false);
            var __workflow_bodyattendeePrivilegesenabledChatOtherParticipants = WorkflowExpression.Compile(bodyattendeePrivilegesenabledChatOtherParticipants, nameof(bodyattendeePrivilegesenabledChatOtherParticipants), required: false);
            var __workflow_bodyintegrationTags = WorkflowExpression.Compile(bodyintegrationTags, nameof(bodyintegrationTags), required: false);
            var __workflow_bodyenabledBreakoutSessions = WorkflowExpression.Compile(bodyenabledBreakoutSessions, nameof(bodyenabledBreakoutSessions), required: false);
            var __workflow_bodytrackingCodes = WorkflowExpression.Compile(bodytrackingCodes, nameof(bodytrackingCodes), required: false);
            var __workflow_bodyaudioConnectionOptionsaudioConnectionType = WorkflowExpression.Compile(bodyaudioConnectionOptionsaudioConnectionType, nameof(bodyaudioConnectionOptionsaudioConnectionType), required: false);
            var __workflow_bodyaudioConnectionOptionsenabledTollFreeCallIn = WorkflowExpression.Compile(bodyaudioConnectionOptionsenabledTollFreeCallIn, nameof(bodyaudioConnectionOptionsenabledTollFreeCallIn), required: false);
            var __workflow_bodyaudioConnectionOptionsenabledGlobalCallIn = WorkflowExpression.Compile(bodyaudioConnectionOptionsenabledGlobalCallIn, nameof(bodyaudioConnectionOptionsenabledGlobalCallIn), required: false);
            var __workflow_bodyaudioConnectionOptionsenabledAudienceCallBack = WorkflowExpression.Compile(bodyaudioConnectionOptionsenabledAudienceCallBack, nameof(bodyaudioConnectionOptionsenabledAudienceCallBack), required: false);
            var __workflow_bodyaudioConnectionOptionsentryAndExitTone = WorkflowExpression.Compile(bodyaudioConnectionOptionsentryAndExitTone, nameof(bodyaudioConnectionOptionsentryAndExitTone), required: false);
            var __workflow_bodyaudioConnectionOptionsallowHostToUnmuteParticipants = WorkflowExpression.Compile(bodyaudioConnectionOptionsallowHostToUnmuteParticipants, nameof(bodyaudioConnectionOptionsallowHostToUnmuteParticipants), required: false);
            var __workflow_bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf = WorkflowExpression.Compile(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf, nameof(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf), required: false);
            var __workflow_bodyaudioConnectionOptionsmuteAttendeeUponEntry = WorkflowExpression.Compile(bodyaudioConnectionOptionsmuteAttendeeUponEntry, nameof(bodyaudioConnectionOptionsmuteAttendeeUponEntry), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meetings/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_meetingId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyagenda != null)
                {
                    body["agenda"] = ExpressionConverter.ConvertO(__workflow_bodyagenda);
                    bodypropCount++;
                }

                if (__workflow_bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(__workflow_bodypassword);
                    bodypropCount++;
                }

                if (__workflow_bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (__workflow_bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(__workflow_bodystart);
                    bodypropCount++;
                }

                if (__workflow_bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(__workflow_bodyend);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledAutoRecordMeeting != null)
                {
                    body["enabledAutoRecordMeeting"] = ExpressionConverter.ConvertO(__workflow_bodyenabledAutoRecordMeeting);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAnyUserToBeCoHost != null)
                {
                    body["allowAnyUserToBeCoHost"] = ExpressionConverter.ConvertO(__workflow_bodyallowAnyUserToBeCoHost);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledJoinBeforeHost != null)
                {
                    body["enabledJoinBeforeHost"] = ExpressionConverter.ConvertO(__workflow_bodyenabledJoinBeforeHost);
                    bodypropCount++;
                }

                if (__workflow_bodyenableConnectAudioBeforeHost != null)
                {
                    body["enableConnectAudioBeforeHost"] = ExpressionConverter.ConvertO(__workflow_bodyenableConnectAudioBeforeHost);
                    bodypropCount++;
                }

                if (__workflow_bodyjoinBeforeHostMinutes != null)
                {
                    body["joinBeforeHostMinutes"] = ExpressionConverter.ConvertO(__workflow_bodyjoinBeforeHostMinutes);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludePassword != null)
                {
                    body["excludePassword"] = ExpressionConverter.ConvertO(__workflow_bodyexcludePassword);
                    bodypropCount++;
                }

                if (__workflow_bodypublicMeeting != null)
                {
                    body["publicMeeting"] = ExpressionConverter.ConvertO(__workflow_bodypublicMeeting);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderTime != null)
                {
                    body["reminderTime"] = ExpressionConverter.ConvertO(__workflow_bodyreminderTime);
                    bodypropCount++;
                }

                if (__workflow_bodyunlockedMeetingJoinSecurity != null)
                {
                    body["unlockedMeetingJoinSecurity"] = ExpressionConverter.ConvertO(__workflow_bodyunlockedMeetingJoinSecurity);
                    bodypropCount++;
                }

                if (__workflow_bodyenableAutomaticLock != null)
                {
                    body["enableAutomaticLock"] = ExpressionConverter.ConvertO(__workflow_bodyenableAutomaticLock);
                    bodypropCount++;
                }

                if (__workflow_bodyautomaticLockMinutes != null)
                {
                    body["automaticLockMinutes"] = ExpressionConverter.ConvertO(__workflow_bodyautomaticLockMinutes);
                    bodypropCount++;
                }

                if (__workflow_bodyallowFirstUserToBeCoHost != null)
                {
                    body["allowFirstUserToBeCoHost"] = ExpressionConverter.ConvertO(__workflow_bodyallowFirstUserToBeCoHost);
                    bodypropCount++;
                }

                if (__workflow_bodyallowAuthenticatedDevices != null)
                {
                    body["allowAuthenticatedDevices"] = ExpressionConverter.ConvertO(__workflow_bodyallowAuthenticatedDevices);
                    bodypropCount++;
                }

                if (__workflow_bodysendEmail != null)
                {
                    body["sendEmail"] = ExpressionConverter.ConvertO(__workflow_bodysendEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(__workflow_bodyhostEmail);
                    bodypropCount++;
                }

                if (__workflow_bodysiteUrl != null)
                {
                    body["siteUrl"] = ExpressionConverter.ConvertO(__workflow_bodysiteUrl);
                    bodypropCount++;
                }

                var meetingOptionsObject = new JObject();
                var meetingOptionsObjectpropCount = 0;
                if (__workflow_bodymeetingOptionsenabledChat != null)
                {
                    meetingOptionsObject["enabledChat"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsenabledChat);
                    meetingOptionsObjectpropCount++;
                }

                if (__workflow_bodymeetingOptionsenabledVideo != null)
                {
                    meetingOptionsObject["enabledVideo"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsenabledVideo);
                    meetingOptionsObjectpropCount++;
                }

                if (__workflow_bodymeetingOptionsenabledPolling != null)
                {
                    meetingOptionsObject["enabledPolling"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsenabledPolling);
                    meetingOptionsObjectpropCount++;
                }

                if (__workflow_bodymeetingOptionsenabledNote != null)
                {
                    meetingOptionsObject["enabledNote"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsenabledNote);
                    meetingOptionsObjectpropCount++;
                }

                if (__workflow_bodymeetingOptionsnoteType != null)
                {
                    meetingOptionsObject["noteType"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsnoteType);
                    meetingOptionsObjectpropCount++;
                }

                if (__workflow_bodymeetingOptionsenabledClosedCaptions != null)
                {
                    meetingOptionsObject["enabledClosedCaptions"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsenabledClosedCaptions);
                    meetingOptionsObjectpropCount++;
                }

                if (__workflow_bodymeetingOptionsenabledFileTransfer != null)
                {
                    meetingOptionsObject["enabledFileTransfer"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsenabledFileTransfer);
                    meetingOptionsObjectpropCount++;
                }

                if (__workflow_bodymeetingOptionsenabledUCFRichMedia != null)
                {
                    meetingOptionsObject["enabledUCFRichMedia"] = ExpressionConverter.ConvertO(__workflow_bodymeetingOptionsenabledUCFRichMedia);
                    meetingOptionsObjectpropCount++;
                }

                if (meetingOptionsObjectpropCount > 0)
                {
                    body["meetingOptions"] = meetingOptionsObject;
                    bodypropCount++;
                }

                var attendeePrivilegesObject = new JObject();
                var attendeePrivilegesObjectpropCount = 0;
                if (__workflow_bodyattendeePrivilegesenabledShareContent != null)
                {
                    attendeePrivilegesObject["enabledShareContent"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledShareContent);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledSaveDocument != null)
                {
                    attendeePrivilegesObject["enabledSaveDocument"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledSaveDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledPrintDocument != null)
                {
                    attendeePrivilegesObject["enabledPrintDocument"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledPrintDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledAnnotate != null)
                {
                    attendeePrivilegesObject["enabledAnnotate"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledAnnotate);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledViewParticipantList != null)
                {
                    attendeePrivilegesObject["enabledViewParticipantList"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledViewParticipantList);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledViewThumbnails != null)
                {
                    attendeePrivilegesObject["enabledViewThumbnails"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledViewThumbnails);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledRemoteControl != null)
                {
                    attendeePrivilegesObject["enabledRemoteControl"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledRemoteControl);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledViewAnyDocument != null)
                {
                    attendeePrivilegesObject["enabledViewAnyDocument"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledViewAnyDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledViewAnyPage != null)
                {
                    attendeePrivilegesObject["enabledViewAnyPage"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledViewAnyPage);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledContactOperatorPrivately != null)
                {
                    attendeePrivilegesObject["enabledContactOperatorPrivately"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledContactOperatorPrivately);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledChatHost != null)
                {
                    attendeePrivilegesObject["enabledChatHost"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledChatHost);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledChatPresenter != null)
                {
                    attendeePrivilegesObject["enabledChatPresenter"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledChatPresenter);
                    attendeePrivilegesObjectpropCount++;
                }

                if (__workflow_bodyattendeePrivilegesenabledChatOtherParticipants != null)
                {
                    attendeePrivilegesObject["enabledChatOtherParticipants"] = ExpressionConverter.ConvertO(__workflow_bodyattendeePrivilegesenabledChatOtherParticipants);
                    attendeePrivilegesObjectpropCount++;
                }

                if (attendeePrivilegesObjectpropCount > 0)
                {
                    body["attendeePrivileges"] = attendeePrivilegesObject;
                    bodypropCount++;
                }

                if (__workflow_bodyintegrationTags != null)
                {
                    body["integrationTags"] = ExpressionConverter.ConvertO(__workflow_bodyintegrationTags);
                    bodypropCount++;
                }

                if (__workflow_bodyenabledBreakoutSessions != null)
                {
                    body["enabledBreakoutSessions"] = ExpressionConverter.ConvertO(__workflow_bodyenabledBreakoutSessions);
                    bodypropCount++;
                }

                if (__workflow_bodytrackingCodes != null)
                {
                    body["trackingCodes"] = ExpressionConverter.ConvertO(__workflow_bodytrackingCodes);
                    bodypropCount++;
                }

                var audioConnectionOptionsObject = new JObject();
                var audioConnectionOptionsObjectpropCount = 0;
                if (__workflow_bodyaudioConnectionOptionsaudioConnectionType != null)
                {
                    audioConnectionOptionsObject["audioConnectionType"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsaudioConnectionType);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (__workflow_bodyaudioConnectionOptionsenabledTollFreeCallIn != null)
                {
                    audioConnectionOptionsObject["enabledTollFreeCallIn"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsenabledTollFreeCallIn);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (__workflow_bodyaudioConnectionOptionsenabledGlobalCallIn != null)
                {
                    audioConnectionOptionsObject["enabledGlobalCallIn"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsenabledGlobalCallIn);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (__workflow_bodyaudioConnectionOptionsenabledAudienceCallBack != null)
                {
                    audioConnectionOptionsObject["enabledAudienceCallBack"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsenabledAudienceCallBack);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (__workflow_bodyaudioConnectionOptionsentryAndExitTone != null)
                {
                    audioConnectionOptionsObject["entryAndExitTone"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsentryAndExitTone);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (__workflow_bodyaudioConnectionOptionsallowHostToUnmuteParticipants != null)
                {
                    audioConnectionOptionsObject["allowHostToUnmuteParticipants"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsallowHostToUnmuteParticipants);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (__workflow_bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf != null)
                {
                    audioConnectionOptionsObject["allowAttendeeToUnmuteSelf"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (__workflow_bodyaudioConnectionOptionsmuteAttendeeUponEntry != null)
                {
                    audioConnectionOptionsObject["muteAttendeeUponEntry"] = ExpressionConverter.ConvertO(__workflow_bodyaudioConnectionOptionsmuteAttendeeUponEntry);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (audioConnectionOptionsObjectpropCount > 0)
                {
                    body["audioConnectionOptions"] = audioConnectionOptionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class WebexintegrationipTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReadMeetingResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meetingNumber")]
        public string MeetingNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("agenda")]
        public string Agenda { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phoneAndVideoSystemPassword")]
        public string PhoneAndVideoSystemPassword { get; set; }

        [JsonProperty("meetingType")]
        public string MeetingType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }

        [JsonProperty("hostUserId")]
        public string HostUserId { get; set; }

        [JsonProperty("hostDisplayName")]
        public string HostDisplayName { get; set; }

        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        [JsonProperty("hostKey")]
        public string HostKey { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }

        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        [JsonProperty("sipAddress")]
        public string SipAddress { get; set; }

        [JsonProperty("dialInIpAddress")]
        public string DialInIpAddress { get; set; }

        [JsonProperty("enabledAutoRecordMeeting")]
        public bool EnabledAutoRecordMeeting { get; set; }

        [JsonProperty("allowAnyUserToBeCoHost")]
        public bool AllowAnyUserToBeCoHost { get; set; }

        [JsonProperty("enabledJoinBeforeHost")]
        public bool EnabledJoinBeforeHost { get; set; }

        [JsonProperty("enableConnectAudioBeforeHost")]
        public bool EnableConnectAudioBeforeHost { get; set; }

        [JsonProperty("joinBeforeHostMinutes")]
        public int JoinBeforeHostMinutes { get; set; }

        [JsonProperty("excludePassword")]
        public bool ExcludePassword { get; set; }

        [JsonProperty("publicMeeting")]
        public bool PublicMeeting { get; set; }

        [JsonProperty("reminderTime")]
        public int ReminderTime { get; set; }

        [JsonProperty("unlockedMeetingJoinSecurity")]
        public string UnlockedMeetingJoinSecurity { get; set; }

        [JsonProperty("sessionTypeId")]
        public int SessionTypeId { get; set; }

        [JsonProperty("enableAutomaticLock")]
        public bool EnableAutomaticLock { get; set; }

        [JsonProperty("automaticLockMinutes")]
        public int AutomaticLockMinutes { get; set; }

        [JsonProperty("allowFirstUserToBeCoHost")]
        public bool AllowFirstUserToBeCoHost { get; set; }

        [JsonProperty("allowAuthenticatedDevices")]
        public bool AllowAuthenticatedDevices { get; set; }

        [JsonProperty("telephony")]
        public ReadMeetingResponseTelephonyType Telephony { get; set; }

        [JsonProperty("meetingOptions")]
        public ReadMeetingResponseMeetingOptionsType MeetingOptions { get; set; }

        [JsonProperty("attendeePrivileges")]
        public ReadMeetingResponseAttendeePrivilegesType AttendeePrivileges { get; set; }

        [JsonProperty("registration")]
        public ReadMeetingResponseRegistrationType Registration { get; set; }

        [JsonProperty("integrationTags")]
        public string[] IntegrationTags { get; set; }

        [JsonProperty("scheduledType")]
        public string ScheduledType { get; set; }

        [JsonProperty("simultaneousInterpretation")]
        public ReadMeetingResponseSimultaneousInterpretationType SimultaneousInterpretation { get; set; }

        [JsonProperty("enabledBreakoutSessions")]
        public bool EnabledBreakoutSessions { get; set; }

        [JsonProperty("links")]
        public ReadMeetingResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("trackingCodes")]
        public ReadMeetingResponseTrackingCodesTypeItem[] TrackingCodes { get; set; }

        [JsonProperty("audioConnectionOptions")]
        public ReadMeetingResponseAudioConnectionOptionsType AudioConnectionOptions { get; set; }
    }

    public class ReadMeetingResponseTelephonyType
    {
        [JsonProperty("accessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("callInNumbers")]
        public ReadMeetingResponseTelephonyTypeCallInNumbersTypeItem[] CallInNumbers { get; set; }

        [JsonProperty("links")]
        public ReadMeetingResponseTelephonyTypeLinksTypeItem[] Links { get; set; }
    }

    public class ReadMeetingResponseTelephonyTypeCallInNumbersTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("callInNumber")]
        public string CallInNumber { get; set; }

        [JsonProperty("tollType")]
        public string TollType { get; set; }
    }

    public class ReadMeetingResponseTelephonyTypeLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class ReadMeetingResponseMeetingOptionsType
    {
        [JsonProperty("enabledChat")]
        public bool EnabledChat { get; set; }

        [JsonProperty("enabledVideo")]
        public bool EnabledVideo { get; set; }

        [JsonProperty("enabledPolling")]
        public bool EnabledPolling { get; set; }

        [JsonProperty("enabledNote")]
        public bool EnabledNote { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("enabledClosedCaptions")]
        public bool EnabledClosedCaptions { get; set; }

        [JsonProperty("enabledFileTransfer")]
        public bool EnabledFileTransfer { get; set; }

        [JsonProperty("enabledUCFRichMedia")]
        public bool EnabledUCFRichMedia { get; set; }
    }

    public class ReadMeetingResponseAttendeePrivilegesType
    {
        [JsonProperty("enabledShareContent")]
        public bool EnabledShareContent { get; set; }

        [JsonProperty("enabledSaveDocument")]
        public bool EnabledSaveDocument { get; set; }

        [JsonProperty("enabledPrintDocument")]
        public bool EnabledPrintDocument { get; set; }

        [JsonProperty("enabledAnnotate")]
        public bool EnabledAnnotate { get; set; }

        [JsonProperty("enabledViewParticipantList")]
        public bool EnabledViewParticipantList { get; set; }

        [JsonProperty("enabledViewThumbnails")]
        public bool EnabledViewThumbnails { get; set; }

        [JsonProperty("enabledRemoteControl")]
        public bool EnabledRemoteControl { get; set; }

        [JsonProperty("enabledViewAnyDocument")]
        public bool EnabledViewAnyDocument { get; set; }

        [JsonProperty("enabledViewAnyPage")]
        public bool EnabledViewAnyPage { get; set; }

        [JsonProperty("enabledContactOperatorPrivately")]
        public bool EnabledContactOperatorPrivately { get; set; }

        [JsonProperty("enabledChatHost")]
        public bool EnabledChatHost { get; set; }

        [JsonProperty("enabledChatPresenter")]
        public bool EnabledChatPresenter { get; set; }

        [JsonProperty("enabledChatOtherParticipants")]
        public bool EnabledChatOtherParticipants { get; set; }
    }

    public class ReadMeetingResponseRegistrationType
    {
        [JsonProperty("autoAcceptRequest")]
        public bool AutoAcceptRequest { get; set; }

        [JsonProperty("requireFirstName")]
        public bool RequireFirstName { get; set; }

        [JsonProperty("requireLastName")]
        public bool RequireLastName { get; set; }

        [JsonProperty("requireEmail")]
        public bool RequireEmail { get; set; }

        [JsonProperty("requireCompanyName")]
        public bool RequireCompanyName { get; set; }

        [JsonProperty("requireCountryRegion")]
        public bool RequireCountryRegion { get; set; }

        [JsonProperty("requireWorkPhone")]
        public bool RequireWorkPhone { get; set; }

        [JsonProperty("customizedQuestions")]
        public ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem[] CustomizedQuestions { get; set; }

        [JsonProperty("rules")]
        public ReadMeetingResponseRegistrationTypeRulesTypeItem[] Rules { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("rules")]
        public ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem[] Rules { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class ReadMeetingResponseRegistrationTypeRulesTypeItem
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class ReadMeetingResponseSimultaneousInterpretationType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("interpreters")]
        public ReadMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem[] Interpreters { get; set; }
    }

    public class ReadMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageCode1")]
        public string LanguageCode1 { get; set; }

        [JsonProperty("languageCode2")]
        public string LanguageCode2 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ReadMeetingResponseLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class ReadMeetingResponseTrackingCodesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReadMeetingResponseAudioConnectionOptionsType
    {
        [JsonProperty("audioConnectionType")]
        public string AudioConnectionType { get; set; }

        [JsonProperty("enabledTollFreeCallIn")]
        public bool EnabledTollFreeCallIn { get; set; }

        [JsonProperty("enabledGlobalCallIn")]
        public bool EnabledGlobalCallIn { get; set; }

        [JsonProperty("enabledAudienceCallBack")]
        public bool EnabledAudienceCallBack { get; set; }

        [JsonProperty("entryAndExitTone")]
        public string EntryAndExitTone { get; set; }

        [JsonProperty("allowHostToUnmuteParticipants")]
        public bool AllowHostToUnmuteParticipants { get; set; }

        [JsonProperty("allowAttendeeToUnmuteSelf")]
        public bool AllowAttendeeToUnmuteSelf { get; set; }

        [JsonProperty("muteAttendeeUponEntry")]
        public bool MuteAttendeeUponEntry { get; set; }
    }

    public class CreateAMeetingResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meetingNumber")]
        public string MeetingNumber { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("agenda")]
        public string Agenda { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phoneAndVideoSystemPassword")]
        public string PhoneAndVideoSystemPassword { get; set; }

        [JsonProperty("meetingType")]
        public string MeetingType { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("recurrence")]
        public string Recurrence { get; set; }

        [JsonProperty("hostUserId")]
        public string HostUserId { get; set; }

        [JsonProperty("hostDisplayName")]
        public string HostDisplayName { get; set; }

        [JsonProperty("hostEmail")]
        public string HostEmail { get; set; }

        [JsonProperty("hostKey")]
        public string HostKey { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }

        [JsonProperty("webLink")]
        public string WebLink { get; set; }

        [JsonProperty("sipAddress")]
        public string SipAddress { get; set; }

        [JsonProperty("dialInIpAddress")]
        public string DialInIpAddress { get; set; }

        [JsonProperty("enabledAutoRecordMeeting")]
        public bool EnabledAutoRecordMeeting { get; set; }

        [JsonProperty("allowAnyUserToBeCoHost")]
        public bool AllowAnyUserToBeCoHost { get; set; }

        [JsonProperty("enabledJoinBeforeHost")]
        public bool EnabledJoinBeforeHost { get; set; }

        [JsonProperty("enableConnectAudioBeforeHost")]
        public bool EnableConnectAudioBeforeHost { get; set; }

        [JsonProperty("joinBeforeHostMinutes")]
        public int JoinBeforeHostMinutes { get; set; }

        [JsonProperty("excludePassword")]
        public bool ExcludePassword { get; set; }

        [JsonProperty("publicMeeting")]
        public bool PublicMeeting { get; set; }

        [JsonProperty("reminderTime")]
        public int ReminderTime { get; set; }

        [JsonProperty("unlockedMeetingJoinSecurity")]
        public string UnlockedMeetingJoinSecurity { get; set; }

        [JsonProperty("sessionTypeId")]
        public int SessionTypeId { get; set; }

        [JsonProperty("enableAutomaticLock")]
        public bool EnableAutomaticLock { get; set; }

        [JsonProperty("automaticLockMinutes")]
        public int AutomaticLockMinutes { get; set; }

        [JsonProperty("allowFirstUserToBeCoHost")]
        public bool AllowFirstUserToBeCoHost { get; set; }

        [JsonProperty("allowAuthenticatedDevices")]
        public bool AllowAuthenticatedDevices { get; set; }

        [JsonProperty("telephony")]
        public CreateAMeetingResponseTelephonyType Telephony { get; set; }

        [JsonProperty("meetingOptions")]
        public CreateAMeetingResponseMeetingOptionsType MeetingOptions { get; set; }

        [JsonProperty("attendeePrivileges")]
        public CreateAMeetingResponseAttendeePrivilegesType AttendeePrivileges { get; set; }

        [JsonProperty("registration")]
        public CreateAMeetingResponseRegistrationType Registration { get; set; }

        [JsonProperty("integrationTags")]
        public string[] IntegrationTags { get; set; }

        [JsonProperty("scheduledType")]
        public string ScheduledType { get; set; }

        [JsonProperty("simultaneousInterpretation")]
        public CreateAMeetingResponseSimultaneousInterpretationType SimultaneousInterpretation { get; set; }

        [JsonProperty("enabledBreakoutSessions")]
        public bool EnabledBreakoutSessions { get; set; }

        [JsonProperty("links")]
        public CreateAMeetingResponseLinksTypeItem[] Links { get; set; }

        [JsonProperty("trackingCodes")]
        public CreateAMeetingResponseTrackingCodesTypeItem[] TrackingCodes { get; set; }

        [JsonProperty("audioConnectionOptions")]
        public CreateAMeetingResponseAudioConnectionOptionsType AudioConnectionOptions { get; set; }
    }

    public class CreateAMeetingResponseTelephonyType
    {
        [JsonProperty("accessCode")]
        public string AccessCode { get; set; }

        [JsonProperty("callInNumbers")]
        public CreateAMeetingResponseTelephonyTypeCallInNumbersTypeItem[] CallInNumbers { get; set; }

        [JsonProperty("links")]
        public CreateAMeetingResponseTelephonyTypeLinksTypeItem[] Links { get; set; }
    }

    public class CreateAMeetingResponseTelephonyTypeCallInNumbersTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("callInNumber")]
        public string CallInNumber { get; set; }

        [JsonProperty("tollType")]
        public string TollType { get; set; }
    }

    public class CreateAMeetingResponseTelephonyTypeLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class CreateAMeetingResponseMeetingOptionsType
    {
        [JsonProperty("enabledChat")]
        public bool EnabledChat { get; set; }

        [JsonProperty("enabledVideo")]
        public bool EnabledVideo { get; set; }

        [JsonProperty("enabledPolling")]
        public bool EnabledPolling { get; set; }

        [JsonProperty("enabledNote")]
        public bool EnabledNote { get; set; }

        [JsonProperty("noteType")]
        public string NoteType { get; set; }

        [JsonProperty("enabledClosedCaptions")]
        public bool EnabledClosedCaptions { get; set; }

        [JsonProperty("enabledFileTransfer")]
        public bool EnabledFileTransfer { get; set; }

        [JsonProperty("enabledUCFRichMedia")]
        public bool EnabledUCFRichMedia { get; set; }
    }

    public class CreateAMeetingResponseAttendeePrivilegesType
    {
        [JsonProperty("enabledShareContent")]
        public bool EnabledShareContent { get; set; }

        [JsonProperty("enabledSaveDocument")]
        public bool EnabledSaveDocument { get; set; }

        [JsonProperty("enabledPrintDocument")]
        public bool EnabledPrintDocument { get; set; }

        [JsonProperty("enabledAnnotate")]
        public bool EnabledAnnotate { get; set; }

        [JsonProperty("enabledViewParticipantList")]
        public bool EnabledViewParticipantList { get; set; }

        [JsonProperty("enabledViewThumbnails")]
        public bool EnabledViewThumbnails { get; set; }

        [JsonProperty("enabledRemoteControl")]
        public bool EnabledRemoteControl { get; set; }

        [JsonProperty("enabledViewAnyDocument")]
        public bool EnabledViewAnyDocument { get; set; }

        [JsonProperty("enabledViewAnyPage")]
        public bool EnabledViewAnyPage { get; set; }

        [JsonProperty("enabledContactOperatorPrivately")]
        public bool EnabledContactOperatorPrivately { get; set; }

        [JsonProperty("enabledChatHost")]
        public bool EnabledChatHost { get; set; }

        [JsonProperty("enabledChatPresenter")]
        public bool EnabledChatPresenter { get; set; }

        [JsonProperty("enabledChatOtherParticipants")]
        public bool EnabledChatOtherParticipants { get; set; }
    }

    public class CreateAMeetingResponseRegistrationType
    {
        [JsonProperty("autoAcceptRequest")]
        public bool AutoAcceptRequest { get; set; }

        [JsonProperty("requireFirstName")]
        public bool RequireFirstName { get; set; }

        [JsonProperty("requireLastName")]
        public bool RequireLastName { get; set; }

        [JsonProperty("requireEmail")]
        public bool RequireEmail { get; set; }

        [JsonProperty("requireCompanyName")]
        public bool RequireCompanyName { get; set; }

        [JsonProperty("requireCountryRegion")]
        public bool RequireCountryRegion { get; set; }

        [JsonProperty("requireWorkPhone")]
        public bool RequireWorkPhone { get; set; }

        [JsonProperty("customizedQuestions")]
        public CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem[] CustomizedQuestions { get; set; }

        [JsonProperty("rules")]
        public CreateAMeetingResponseRegistrationTypeRulesTypeItem[] Rules { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("rules")]
        public CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem[] Rules { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemOptionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeCustomizedQuestionsTypeItemRulesTypeItem
    {
        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class CreateAMeetingResponseRegistrationTypeRulesTypeItem
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("matchCase")]
        public bool MatchCase { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class CreateAMeetingResponseSimultaneousInterpretationType
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("interpreters")]
        public CreateAMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem[] Interpreters { get; set; }
    }

    public class CreateAMeetingResponseSimultaneousInterpretationTypeInterpretersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("languageCode1")]
        public string LanguageCode1 { get; set; }

        [JsonProperty("languageCode2")]
        public string LanguageCode2 { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class CreateAMeetingResponseLinksTypeItem
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }
    }

    public class CreateAMeetingResponseTrackingCodesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateAMeetingResponseAudioConnectionOptionsType
    {
        [JsonProperty("audioConnectionType")]
        public string AudioConnectionType { get; set; }

        [JsonProperty("enabledTollFreeCallIn")]
        public bool EnabledTollFreeCallIn { get; set; }

        [JsonProperty("enabledGlobalCallIn")]
        public bool EnabledGlobalCallIn { get; set; }

        [JsonProperty("enabledAudienceCallBack")]
        public bool EnabledAudienceCallBack { get; set; }

        [JsonProperty("entryAndExitTone")]
        public string EntryAndExitTone { get; set; }

        [JsonProperty("allowHostToUnmuteParticipants")]
        public bool AllowHostToUnmuteParticipants { get; set; }

        [JsonProperty("allowAttendeeToUnmuteSelf")]
        public bool AllowAttendeeToUnmuteSelf { get; set; }

        [JsonProperty("muteAttendeeUponEntry")]
        public bool MuteAttendeeUponEntry { get; set; }
    }

    public class bodytrackingCodesInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Webexintegrationip;

    public partial class WorkflowManagedActions
    {
        public WebexintegrationipActions Webexintegrationip(string connectionId) => new WebexintegrationipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WebexintegrationipTriggers Webexintegrationip(string connectionId) => new WebexintegrationipTriggers(connectionId);
    }
}
