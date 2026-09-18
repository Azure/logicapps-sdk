//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webexintegrationip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebexintegrationipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<ReadMeetingResponse> ReadMeetings([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<string> timezone = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(password, nameof(password), required: false);
            SourceExpression.Validate(timezone, nameof(timezone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                if (password != null)
                    callPayload.Headers["password"] = SourceExpressionConverter.ConvertO(password);
                if (timezone != null)
                    callPayload.Headers["timezone"] = SourceExpressionConverter.ConvertO(timezone);
                return callPayload;
            }

            return new ApiConnectionAction<ReadMeetingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IBodyWorkflowAction<CreateAMeetingResponse> CreateAMeeting([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodystart, [WorkflowExpression] Func<string> bodyend, [WorkflowExpression] Func<string> bodyagenda = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<bool> bodyenabledAutoRecordMeeting = null, [WorkflowExpression] Func<bool> bodyallowAnyUserToBeCoHost = null)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: true);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: true);
            SourceExpression.Validate(bodyagenda, nameof(bodyagenda), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            SourceExpression.Validate(bodyenabledAutoRecordMeeting, nameof(bodyenabledAutoRecordMeeting), required: false);
            SourceExpression.Validate(bodyallowAnyUserToBeCoHost, nameof(bodyallowAnyUserToBeCoHost), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodyagenda != null)
                {
                    body["agenda"] = SourceExpressionConverter.ConvertToken(bodyagenda);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                bodypropCount++;
                body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                bodypropCount++;
                body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                if (bodytimezone != null)
                {
                    if (bodytimezone != null)
                    {
                        body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["timezone"] = "Europe/London";
                    bodypropCount++;
                }

                if (bodyenabledAutoRecordMeeting != null)
                {
                    if (bodyenabledAutoRecordMeeting != null)
                    {
                        body["enabledAutoRecordMeeting"] = SourceExpressionConverter.ConvertToken(bodyenabledAutoRecordMeeting);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["enabledAutoRecordMeeting"] = false;
                    bodypropCount++;
                }

                if (bodyallowAnyUserToBeCoHost != null)
                {
                    if (bodyallowAnyUserToBeCoHost != null)
                    {
                        body["allowAnyUserToBeCoHost"] = SourceExpressionConverter.ConvertToken(bodyallowAnyUserToBeCoHost);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateAMeetingResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction CreateAInvitee([WorkflowExpression] Func<string> bodymeetingId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodycoHost = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodysendEmail = null, [WorkflowExpression] Func<string> bodypanelist = null)
        {
            SourceExpression.Validate(bodymeetingId, nameof(bodymeetingId), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            SourceExpression.Validate(bodycoHost, nameof(bodycoHost), required: false);
            SourceExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            SourceExpression.Validate(bodysendEmail, nameof(bodysendEmail), required: false);
            SourceExpression.Validate(bodypanelist, nameof(bodypanelist), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/meetingInvitees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["meetingId"] = SourceExpressionConverter.ConvertToken(bodymeetingId);
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodydisplayName != null)
                {
                    body["displayName"] = SourceExpressionConverter.ConvertToken(bodydisplayName);
                    bodypropCount++;
                }

                if (bodycoHost != null)
                {
                    body["coHost"] = SourceExpressionConverter.ConvertToken(bodycoHost);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = SourceExpressionConverter.ConvertToken(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodysendEmail != null)
                {
                    body["sendEmail"] = SourceExpressionConverter.ConvertToken(bodysendEmail);
                    bodypropCount++;
                }

                if (bodypanelist != null)
                {
                    body["panelist"] = SourceExpressionConverter.ConvertToken(bodypanelist);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction DeleteAMeeting([WorkflowExpression] Func<string> meetingId)
        {
            SourceExpression.Validate(meetingId, nameof(meetingId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meetings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        public IWorkflowAction UpdateAMeeting([WorkflowExpression] Func<string> meetingId, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyagenda = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<bool> bodyenabledAutoRecordMeeting = null, [WorkflowExpression] Func<bool> bodyallowAnyUserToBeCoHost = null, [WorkflowExpression] Func<bool> bodyenabledJoinBeforeHost = null, [WorkflowExpression] Func<bool> bodyenableConnectAudioBeforeHost = null, [WorkflowExpression] Func<int> bodyjoinBeforeHostMinutes = null, [WorkflowExpression] Func<bool> bodyexcludePassword = null, [WorkflowExpression] Func<bool> bodypublicMeeting = null, [WorkflowExpression] Func<int> bodyreminderTime = null, [WorkflowExpression] Func<string> bodyunlockedMeetingJoinSecurity = null, [WorkflowExpression] Func<bool> bodyenableAutomaticLock = null, [WorkflowExpression] Func<int> bodyautomaticLockMinutes = null, [WorkflowExpression] Func<bool> bodyallowFirstUserToBeCoHost = null, [WorkflowExpression] Func<bool> bodyallowAuthenticatedDevices = null, [WorkflowExpression] Func<bool> bodysendEmail = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodysiteUrl = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledChat = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledVideo = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledPolling = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledNote = null, [WorkflowExpression] Func<string> bodymeetingOptionsnoteType = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledClosedCaptions = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledFileTransfer = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledUCFRichMedia = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledShareContent = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledSaveDocument = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledPrintDocument = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledAnnotate = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewParticipantList = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewThumbnails = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledRemoteControl = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewAnyDocument = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewAnyPage = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledContactOperatorPrivately = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledChatHost = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledChatPresenter = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledChatOtherParticipants = null, [WorkflowExpression] Func<string[]> bodyintegrationTags = null, [WorkflowExpression] Func<bool> bodyenabledBreakoutSessions = null, [WorkflowExpression] Func<bodytrackingCodesInputItem[]> bodytrackingCodes = null, [WorkflowExpression] Func<string> bodyaudioConnectionOptionsaudioConnectionType = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsenabledTollFreeCallIn = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsenabledGlobalCallIn = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsenabledAudienceCallBack = null, [WorkflowExpression] Func<string> bodyaudioConnectionOptionsentryAndExitTone = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsallowHostToUnmuteParticipants = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsmuteAttendeeUponEntry = null)
        {
            SourceExpression.Validate(meetingId, nameof(meetingId), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyagenda, nameof(bodyagenda), required: false);
            SourceExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            SourceExpression.Validate(bodystart, nameof(bodystart), required: false);
            SourceExpression.Validate(bodyend, nameof(bodyend), required: false);
            SourceExpression.Validate(bodyenabledAutoRecordMeeting, nameof(bodyenabledAutoRecordMeeting), required: false);
            SourceExpression.Validate(bodyallowAnyUserToBeCoHost, nameof(bodyallowAnyUserToBeCoHost), required: false);
            SourceExpression.Validate(bodyenabledJoinBeforeHost, nameof(bodyenabledJoinBeforeHost), required: false);
            SourceExpression.Validate(bodyenableConnectAudioBeforeHost, nameof(bodyenableConnectAudioBeforeHost), required: false);
            SourceExpression.Validate(bodyjoinBeforeHostMinutes, nameof(bodyjoinBeforeHostMinutes), required: false);
            SourceExpression.Validate(bodyexcludePassword, nameof(bodyexcludePassword), required: false);
            SourceExpression.Validate(bodypublicMeeting, nameof(bodypublicMeeting), required: false);
            SourceExpression.Validate(bodyreminderTime, nameof(bodyreminderTime), required: false);
            SourceExpression.Validate(bodyunlockedMeetingJoinSecurity, nameof(bodyunlockedMeetingJoinSecurity), required: false);
            SourceExpression.Validate(bodyenableAutomaticLock, nameof(bodyenableAutomaticLock), required: false);
            SourceExpression.Validate(bodyautomaticLockMinutes, nameof(bodyautomaticLockMinutes), required: false);
            SourceExpression.Validate(bodyallowFirstUserToBeCoHost, nameof(bodyallowFirstUserToBeCoHost), required: false);
            SourceExpression.Validate(bodyallowAuthenticatedDevices, nameof(bodyallowAuthenticatedDevices), required: false);
            SourceExpression.Validate(bodysendEmail, nameof(bodysendEmail), required: false);
            SourceExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            SourceExpression.Validate(bodysiteUrl, nameof(bodysiteUrl), required: false);
            SourceExpression.Validate(bodymeetingOptionsenabledChat, nameof(bodymeetingOptionsenabledChat), required: false);
            SourceExpression.Validate(bodymeetingOptionsenabledVideo, nameof(bodymeetingOptionsenabledVideo), required: false);
            SourceExpression.Validate(bodymeetingOptionsenabledPolling, nameof(bodymeetingOptionsenabledPolling), required: false);
            SourceExpression.Validate(bodymeetingOptionsenabledNote, nameof(bodymeetingOptionsenabledNote), required: false);
            SourceExpression.Validate(bodymeetingOptionsnoteType, nameof(bodymeetingOptionsnoteType), required: false);
            SourceExpression.Validate(bodymeetingOptionsenabledClosedCaptions, nameof(bodymeetingOptionsenabledClosedCaptions), required: false);
            SourceExpression.Validate(bodymeetingOptionsenabledFileTransfer, nameof(bodymeetingOptionsenabledFileTransfer), required: false);
            SourceExpression.Validate(bodymeetingOptionsenabledUCFRichMedia, nameof(bodymeetingOptionsenabledUCFRichMedia), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledShareContent, nameof(bodyattendeePrivilegesenabledShareContent), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledSaveDocument, nameof(bodyattendeePrivilegesenabledSaveDocument), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledPrintDocument, nameof(bodyattendeePrivilegesenabledPrintDocument), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledAnnotate, nameof(bodyattendeePrivilegesenabledAnnotate), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledViewParticipantList, nameof(bodyattendeePrivilegesenabledViewParticipantList), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledViewThumbnails, nameof(bodyattendeePrivilegesenabledViewThumbnails), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledRemoteControl, nameof(bodyattendeePrivilegesenabledRemoteControl), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledViewAnyDocument, nameof(bodyattendeePrivilegesenabledViewAnyDocument), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledViewAnyPage, nameof(bodyattendeePrivilegesenabledViewAnyPage), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledContactOperatorPrivately, nameof(bodyattendeePrivilegesenabledContactOperatorPrivately), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledChatHost, nameof(bodyattendeePrivilegesenabledChatHost), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledChatPresenter, nameof(bodyattendeePrivilegesenabledChatPresenter), required: false);
            SourceExpression.Validate(bodyattendeePrivilegesenabledChatOtherParticipants, nameof(bodyattendeePrivilegesenabledChatOtherParticipants), required: false);
            SourceExpression.Validate(bodyintegrationTags, nameof(bodyintegrationTags), required: false);
            SourceExpression.Validate(bodyenabledBreakoutSessions, nameof(bodyenabledBreakoutSessions), required: false);
            SourceExpression.Validate(bodytrackingCodes, nameof(bodytrackingCodes), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsaudioConnectionType, nameof(bodyaudioConnectionOptionsaudioConnectionType), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsenabledTollFreeCallIn, nameof(bodyaudioConnectionOptionsenabledTollFreeCallIn), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsenabledGlobalCallIn, nameof(bodyaudioConnectionOptionsenabledGlobalCallIn), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsenabledAudienceCallBack, nameof(bodyaudioConnectionOptionsenabledAudienceCallBack), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsentryAndExitTone, nameof(bodyaudioConnectionOptionsentryAndExitTone), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsallowHostToUnmuteParticipants, nameof(bodyaudioConnectionOptionsallowHostToUnmuteParticipants), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf, nameof(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf), required: false);
            SourceExpression.Validate(bodyaudioConnectionOptionsmuteAttendeeUponEntry, nameof(bodyaudioConnectionOptionsmuteAttendeeUponEntry), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meetings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(meetingId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyagenda != null)
                {
                    body["agenda"] = SourceExpressionConverter.ConvertToken(bodyagenda);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyend);
                    bodypropCount++;
                }

                if (bodyenabledAutoRecordMeeting != null)
                {
                    body["enabledAutoRecordMeeting"] = SourceExpressionConverter.ConvertToken(bodyenabledAutoRecordMeeting);
                    bodypropCount++;
                }

                if (bodyallowAnyUserToBeCoHost != null)
                {
                    body["allowAnyUserToBeCoHost"] = SourceExpressionConverter.ConvertToken(bodyallowAnyUserToBeCoHost);
                    bodypropCount++;
                }

                if (bodyenabledJoinBeforeHost != null)
                {
                    body["enabledJoinBeforeHost"] = SourceExpressionConverter.ConvertToken(bodyenabledJoinBeforeHost);
                    bodypropCount++;
                }

                if (bodyenableConnectAudioBeforeHost != null)
                {
                    body["enableConnectAudioBeforeHost"] = SourceExpressionConverter.ConvertToken(bodyenableConnectAudioBeforeHost);
                    bodypropCount++;
                }

                if (bodyjoinBeforeHostMinutes != null)
                {
                    body["joinBeforeHostMinutes"] = SourceExpressionConverter.ConvertToken(bodyjoinBeforeHostMinutes);
                    bodypropCount++;
                }

                if (bodyexcludePassword != null)
                {
                    body["excludePassword"] = SourceExpressionConverter.ConvertToken(bodyexcludePassword);
                    bodypropCount++;
                }

                if (bodypublicMeeting != null)
                {
                    body["publicMeeting"] = SourceExpressionConverter.ConvertToken(bodypublicMeeting);
                    bodypropCount++;
                }

                if (bodyreminderTime != null)
                {
                    body["reminderTime"] = SourceExpressionConverter.ConvertToken(bodyreminderTime);
                    bodypropCount++;
                }

                if (bodyunlockedMeetingJoinSecurity != null)
                {
                    body["unlockedMeetingJoinSecurity"] = SourceExpressionConverter.ConvertToken(bodyunlockedMeetingJoinSecurity);
                    bodypropCount++;
                }

                if (bodyenableAutomaticLock != null)
                {
                    body["enableAutomaticLock"] = SourceExpressionConverter.ConvertToken(bodyenableAutomaticLock);
                    bodypropCount++;
                }

                if (bodyautomaticLockMinutes != null)
                {
                    body["automaticLockMinutes"] = SourceExpressionConverter.ConvertToken(bodyautomaticLockMinutes);
                    bodypropCount++;
                }

                if (bodyallowFirstUserToBeCoHost != null)
                {
                    body["allowFirstUserToBeCoHost"] = SourceExpressionConverter.ConvertToken(bodyallowFirstUserToBeCoHost);
                    bodypropCount++;
                }

                if (bodyallowAuthenticatedDevices != null)
                {
                    body["allowAuthenticatedDevices"] = SourceExpressionConverter.ConvertToken(bodyallowAuthenticatedDevices);
                    bodypropCount++;
                }

                if (bodysendEmail != null)
                {
                    body["sendEmail"] = SourceExpressionConverter.ConvertToken(bodysendEmail);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = SourceExpressionConverter.ConvertToken(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodysiteUrl != null)
                {
                    body["siteUrl"] = SourceExpressionConverter.ConvertToken(bodysiteUrl);
                    bodypropCount++;
                }

                var meetingOptionsObject = new JObject();
                var meetingOptionsObjectpropCount = 0;
                if (bodymeetingOptionsenabledChat != null)
                {
                    meetingOptionsObject["enabledChat"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsenabledChat);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledVideo != null)
                {
                    meetingOptionsObject["enabledVideo"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsenabledVideo);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledPolling != null)
                {
                    meetingOptionsObject["enabledPolling"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsenabledPolling);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledNote != null)
                {
                    meetingOptionsObject["enabledNote"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsenabledNote);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsnoteType != null)
                {
                    meetingOptionsObject["noteType"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsnoteType);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledClosedCaptions != null)
                {
                    meetingOptionsObject["enabledClosedCaptions"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsenabledClosedCaptions);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledFileTransfer != null)
                {
                    meetingOptionsObject["enabledFileTransfer"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsenabledFileTransfer);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledUCFRichMedia != null)
                {
                    meetingOptionsObject["enabledUCFRichMedia"] = SourceExpressionConverter.ConvertToken(bodymeetingOptionsenabledUCFRichMedia);
                    meetingOptionsObjectpropCount++;
                }

                if (meetingOptionsObjectpropCount > 0)
                {
                    body["meetingOptions"] = meetingOptionsObject;
                    bodypropCount++;
                }

                var attendeePrivilegesObject = new JObject();
                var attendeePrivilegesObjectpropCount = 0;
                if (bodyattendeePrivilegesenabledShareContent != null)
                {
                    attendeePrivilegesObject["enabledShareContent"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledShareContent);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledSaveDocument != null)
                {
                    attendeePrivilegesObject["enabledSaveDocument"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledSaveDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledPrintDocument != null)
                {
                    attendeePrivilegesObject["enabledPrintDocument"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledPrintDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledAnnotate != null)
                {
                    attendeePrivilegesObject["enabledAnnotate"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledAnnotate);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewParticipantList != null)
                {
                    attendeePrivilegesObject["enabledViewParticipantList"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewParticipantList);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewThumbnails != null)
                {
                    attendeePrivilegesObject["enabledViewThumbnails"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewThumbnails);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledRemoteControl != null)
                {
                    attendeePrivilegesObject["enabledRemoteControl"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledRemoteControl);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewAnyDocument != null)
                {
                    attendeePrivilegesObject["enabledViewAnyDocument"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewAnyDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewAnyPage != null)
                {
                    attendeePrivilegesObject["enabledViewAnyPage"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledViewAnyPage);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledContactOperatorPrivately != null)
                {
                    attendeePrivilegesObject["enabledContactOperatorPrivately"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledContactOperatorPrivately);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledChatHost != null)
                {
                    attendeePrivilegesObject["enabledChatHost"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledChatHost);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledChatPresenter != null)
                {
                    attendeePrivilegesObject["enabledChatPresenter"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledChatPresenter);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledChatOtherParticipants != null)
                {
                    attendeePrivilegesObject["enabledChatOtherParticipants"] = SourceExpressionConverter.ConvertToken(bodyattendeePrivilegesenabledChatOtherParticipants);
                    attendeePrivilegesObjectpropCount++;
                }

                if (attendeePrivilegesObjectpropCount > 0)
                {
                    body["attendeePrivileges"] = attendeePrivilegesObject;
                    bodypropCount++;
                }

                if (bodyintegrationTags != null)
                {
                    body["integrationTags"] = SourceExpressionConverter.ConvertToken(bodyintegrationTags);
                    bodypropCount++;
                }

                if (bodyenabledBreakoutSessions != null)
                {
                    body["enabledBreakoutSessions"] = SourceExpressionConverter.ConvertToken(bodyenabledBreakoutSessions);
                    bodypropCount++;
                }

                if (bodytrackingCodes != null)
                {
                    body["trackingCodes"] = SourceExpressionConverter.ConvertToken(bodytrackingCodes);
                    bodypropCount++;
                }

                var audioConnectionOptionsObject = new JObject();
                var audioConnectionOptionsObjectpropCount = 0;
                if (bodyaudioConnectionOptionsaudioConnectionType != null)
                {
                    audioConnectionOptionsObject["audioConnectionType"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsaudioConnectionType);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsenabledTollFreeCallIn != null)
                {
                    audioConnectionOptionsObject["enabledTollFreeCallIn"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsenabledTollFreeCallIn);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsenabledGlobalCallIn != null)
                {
                    audioConnectionOptionsObject["enabledGlobalCallIn"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsenabledGlobalCallIn);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsenabledAudienceCallBack != null)
                {
                    audioConnectionOptionsObject["enabledAudienceCallBack"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsenabledAudienceCallBack);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsentryAndExitTone != null)
                {
                    audioConnectionOptionsObject["entryAndExitTone"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsentryAndExitTone);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsallowHostToUnmuteParticipants != null)
                {
                    audioConnectionOptionsObject["allowHostToUnmuteParticipants"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsallowHostToUnmuteParticipants);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf != null)
                {
                    audioConnectionOptionsObject["allowAttendeeToUnmuteSelf"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsmuteAttendeeUponEntry != null)
                {
                    audioConnectionOptionsObject["muteAttendeeUponEntry"] = SourceExpressionConverter.ConvertToken(bodyaudioConnectionOptionsmuteAttendeeUponEntry);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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