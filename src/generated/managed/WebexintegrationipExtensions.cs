//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Webexintegrationip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WebexintegrationipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [WorkflowExpressionFactory(nameof(__BuildReadMeetings))]
        public IBodyWorkflowAction<ReadMeetingResponse> ReadMeetings([WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> password = null, [WorkflowExpression] Func<string> timezone = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadMeetingResponse> __BuildReadMeetings(WorkflowExpression<string> contentType = null, WorkflowExpression<string> password = null, WorkflowExpression<string> timezone = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(password, nameof(password), required: false);
            WorkflowExpression.Validate(timezone, nameof(timezone), required: false);
            return new DeferredBodyAction<ReadMeetingResponse>(() =>
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                if (password != null)
                    callPayload.Headers["password"] = ExpressionConverter.Convert(password);
                if (timezone != null)
                    callPayload.Headers["timezone"] = ExpressionConverter.Convert(timezone);
                return new ApiConnectionAction<ReadMeetingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAMeeting))]
        public IBodyWorkflowAction<CreateAMeetingResponse> CreateAMeeting([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodystart, [WorkflowExpression] Func<string> bodyend, [WorkflowExpression] Func<string> bodyagenda = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<bool> bodyenabledAutoRecordMeeting = null, [WorkflowExpression] Func<bool> bodyallowAnyUserToBeCoHost = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAMeetingResponse> __BuildCreateAMeeting(WorkflowExpression<string> contentType, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodystart, WorkflowExpression<string> bodyend, WorkflowExpression<string> bodyagenda = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<string> bodytimezone = null, WorkflowExpression<bool> bodyenabledAutoRecordMeeting = null, WorkflowExpression<bool> bodyallowAnyUserToBeCoHost = null)
        {
            WorkflowExpression.Validate(contentType, nameof(contentType), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodystart, nameof(bodystart), required: true);
            WorkflowExpression.Validate(bodyend, nameof(bodyend), required: true);
            WorkflowExpression.Validate(bodyagenda, nameof(bodyagenda), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            WorkflowExpression.Validate(bodyenabledAutoRecordMeeting, nameof(bodyenabledAutoRecordMeeting), required: false);
            WorkflowExpression.Validate(bodyallowAnyUserToBeCoHost, nameof(bodyallowAnyUserToBeCoHost), required: false);
            return new DeferredBodyAction<CreateAMeetingResponse>(() =>
            {
                var apiCallPath = "/meetings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodyagenda != null)
                {
                    body["agenda"] = ExpressionConverter.ConvertO(bodyagenda);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                bodypropCount++;
                body["start"] = ExpressionConverter.ConvertO(bodystart);
                bodypropCount++;
                body["end"] = ExpressionConverter.ConvertO(bodyend);
                if (bodytimezone != null)
                {
                    if (bodytimezone != null)
                    {
                        body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
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
                        body["enabledAutoRecordMeeting"] = ExpressionConverter.ConvertO(bodyenabledAutoRecordMeeting);
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
                        body["allowAnyUserToBeCoHost"] = ExpressionConverter.ConvertO(bodyallowAnyUserToBeCoHost);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateAInvitee))]
        public IWorkflowAction CreateAInvitee([WorkflowExpression] Func<string> bodymeetingId, [WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodydisplayName = null, [WorkflowExpression] Func<string> bodycoHost = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodysendEmail = null, [WorkflowExpression] Func<string> bodypanelist = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateAInvitee(WorkflowExpression<string> bodymeetingId, WorkflowExpression<string> bodyemail, WorkflowExpression<string> contentType = null, WorkflowExpression<string> bodydisplayName = null, WorkflowExpression<string> bodycoHost = null, WorkflowExpression<string> bodyhostEmail = null, WorkflowExpression<string> bodysendEmail = null, WorkflowExpression<string> bodypanelist = null)
        {
            WorkflowExpression.Validate(bodymeetingId, nameof(bodymeetingId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(bodydisplayName, nameof(bodydisplayName), required: false);
            WorkflowExpression.Validate(bodycoHost, nameof(bodycoHost), required: false);
            WorkflowExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            WorkflowExpression.Validate(bodysendEmail, nameof(bodysendEmail), required: false);
            WorkflowExpression.Validate(bodypanelist, nameof(bodypanelist), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/meetingInvitees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["meetingId"] = ExpressionConverter.ConvertO(bodymeetingId);
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                if (bodydisplayName != null)
                {
                    body["displayName"] = ExpressionConverter.ConvertO(bodydisplayName);
                    bodypropCount++;
                }

                if (bodycoHost != null)
                {
                    body["coHost"] = ExpressionConverter.ConvertO(bodycoHost);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodysendEmail != null)
                {
                    body["sendEmail"] = ExpressionConverter.ConvertO(bodysendEmail);
                    bodypropCount++;
                }

                if (bodypanelist != null)
                {
                    body["panelist"] = ExpressionConverter.ConvertO(bodypanelist);
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
        [WorkflowExpressionFactory(nameof(__BuildDeleteAMeeting))]
        public IWorkflowAction DeleteAMeeting([WorkflowExpression] Func<string> meetingId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteAMeeting(WorkflowExpression<string> meetingId)
        {
            WorkflowExpression.Validate(meetingId, nameof(meetingId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meetings/{0}", ExpressionConverter.ConvertWithUrlEncoding(meetingId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAMeeting))]
        public IWorkflowAction UpdateAMeeting([WorkflowExpression] Func<string> meetingId, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyagenda = null, [WorkflowExpression] Func<string> bodypassword = null, [WorkflowExpression] Func<string> bodytimezone = null, [WorkflowExpression] Func<string> bodystart = null, [WorkflowExpression] Func<string> bodyend = null, [WorkflowExpression] Func<bool> bodyenabledAutoRecordMeeting = null, [WorkflowExpression] Func<bool> bodyallowAnyUserToBeCoHost = null, [WorkflowExpression] Func<bool> bodyenabledJoinBeforeHost = null, [WorkflowExpression] Func<bool> bodyenableConnectAudioBeforeHost = null, [WorkflowExpression] Func<int> bodyjoinBeforeHostMinutes = null, [WorkflowExpression] Func<bool> bodyexcludePassword = null, [WorkflowExpression] Func<bool> bodypublicMeeting = null, [WorkflowExpression] Func<int> bodyreminderTime = null, [WorkflowExpression] Func<string> bodyunlockedMeetingJoinSecurity = null, [WorkflowExpression] Func<bool> bodyenableAutomaticLock = null, [WorkflowExpression] Func<int> bodyautomaticLockMinutes = null, [WorkflowExpression] Func<bool> bodyallowFirstUserToBeCoHost = null, [WorkflowExpression] Func<bool> bodyallowAuthenticatedDevices = null, [WorkflowExpression] Func<bool> bodysendEmail = null, [WorkflowExpression] Func<string> bodyhostEmail = null, [WorkflowExpression] Func<string> bodysiteUrl = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledChat = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledVideo = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledPolling = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledNote = null, [WorkflowExpression] Func<string> bodymeetingOptionsnoteType = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledClosedCaptions = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledFileTransfer = null, [WorkflowExpression] Func<bool> bodymeetingOptionsenabledUCFRichMedia = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledShareContent = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledSaveDocument = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledPrintDocument = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledAnnotate = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewParticipantList = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewThumbnails = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledRemoteControl = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewAnyDocument = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledViewAnyPage = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledContactOperatorPrivately = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledChatHost = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledChatPresenter = null, [WorkflowExpression] Func<bool> bodyattendeePrivilegesenabledChatOtherParticipants = null, [WorkflowExpression] Func<string[]> bodyintegrationTags = null, [WorkflowExpression] Func<bool> bodyenabledBreakoutSessions = null, [WorkflowExpression] Func<bodytrackingCodesInputItem[]> bodytrackingCodes = null, [WorkflowExpression] Func<string> bodyaudioConnectionOptionsaudioConnectionType = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsenabledTollFreeCallIn = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsenabledGlobalCallIn = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsenabledAudienceCallBack = null, [WorkflowExpression] Func<string> bodyaudioConnectionOptionsentryAndExitTone = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsallowHostToUnmuteParticipants = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf = null, [WorkflowExpression] Func<bool> bodyaudioConnectionOptionsmuteAttendeeUponEntry = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "webexintegrationip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateAMeeting(WorkflowExpression<string> meetingId, WorkflowExpression<string> contentType = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyagenda = null, WorkflowExpression<string> bodypassword = null, WorkflowExpression<string> bodytimezone = null, WorkflowExpression<string> bodystart = null, WorkflowExpression<string> bodyend = null, WorkflowExpression<bool> bodyenabledAutoRecordMeeting = null, WorkflowExpression<bool> bodyallowAnyUserToBeCoHost = null, WorkflowExpression<bool> bodyenabledJoinBeforeHost = null, WorkflowExpression<bool> bodyenableConnectAudioBeforeHost = null, WorkflowExpression<int> bodyjoinBeforeHostMinutes = null, WorkflowExpression<bool> bodyexcludePassword = null, WorkflowExpression<bool> bodypublicMeeting = null, WorkflowExpression<int> bodyreminderTime = null, WorkflowExpression<string> bodyunlockedMeetingJoinSecurity = null, WorkflowExpression<bool> bodyenableAutomaticLock = null, WorkflowExpression<int> bodyautomaticLockMinutes = null, WorkflowExpression<bool> bodyallowFirstUserToBeCoHost = null, WorkflowExpression<bool> bodyallowAuthenticatedDevices = null, WorkflowExpression<bool> bodysendEmail = null, WorkflowExpression<string> bodyhostEmail = null, WorkflowExpression<string> bodysiteUrl = null, WorkflowExpression<bool> bodymeetingOptionsenabledChat = null, WorkflowExpression<bool> bodymeetingOptionsenabledVideo = null, WorkflowExpression<bool> bodymeetingOptionsenabledPolling = null, WorkflowExpression<bool> bodymeetingOptionsenabledNote = null, WorkflowExpression<string> bodymeetingOptionsnoteType = null, WorkflowExpression<bool> bodymeetingOptionsenabledClosedCaptions = null, WorkflowExpression<bool> bodymeetingOptionsenabledFileTransfer = null, WorkflowExpression<bool> bodymeetingOptionsenabledUCFRichMedia = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledShareContent = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledSaveDocument = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledPrintDocument = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledAnnotate = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledViewParticipantList = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledViewThumbnails = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledRemoteControl = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledViewAnyDocument = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledViewAnyPage = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledContactOperatorPrivately = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledChatHost = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledChatPresenter = null, WorkflowExpression<bool> bodyattendeePrivilegesenabledChatOtherParticipants = null, WorkflowExpression<string[]> bodyintegrationTags = null, WorkflowExpression<bool> bodyenabledBreakoutSessions = null, WorkflowExpression<bodytrackingCodesInputItem[]> bodytrackingCodes = null, WorkflowExpression<string> bodyaudioConnectionOptionsaudioConnectionType = null, WorkflowExpression<bool> bodyaudioConnectionOptionsenabledTollFreeCallIn = null, WorkflowExpression<bool> bodyaudioConnectionOptionsenabledGlobalCallIn = null, WorkflowExpression<bool> bodyaudioConnectionOptionsenabledAudienceCallBack = null, WorkflowExpression<string> bodyaudioConnectionOptionsentryAndExitTone = null, WorkflowExpression<bool> bodyaudioConnectionOptionsallowHostToUnmuteParticipants = null, WorkflowExpression<bool> bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf = null, WorkflowExpression<bool> bodyaudioConnectionOptionsmuteAttendeeUponEntry = null)
        {
            WorkflowExpression.Validate(meetingId, nameof(meetingId), required: true);
            WorkflowExpression.Validate(contentType, nameof(contentType), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyagenda, nameof(bodyagenda), required: false);
            WorkflowExpression.Validate(bodypassword, nameof(bodypassword), required: false);
            WorkflowExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            WorkflowExpression.Validate(bodystart, nameof(bodystart), required: false);
            WorkflowExpression.Validate(bodyend, nameof(bodyend), required: false);
            WorkflowExpression.Validate(bodyenabledAutoRecordMeeting, nameof(bodyenabledAutoRecordMeeting), required: false);
            WorkflowExpression.Validate(bodyallowAnyUserToBeCoHost, nameof(bodyallowAnyUserToBeCoHost), required: false);
            WorkflowExpression.Validate(bodyenabledJoinBeforeHost, nameof(bodyenabledJoinBeforeHost), required: false);
            WorkflowExpression.Validate(bodyenableConnectAudioBeforeHost, nameof(bodyenableConnectAudioBeforeHost), required: false);
            WorkflowExpression.Validate(bodyjoinBeforeHostMinutes, nameof(bodyjoinBeforeHostMinutes), required: false);
            WorkflowExpression.Validate(bodyexcludePassword, nameof(bodyexcludePassword), required: false);
            WorkflowExpression.Validate(bodypublicMeeting, nameof(bodypublicMeeting), required: false);
            WorkflowExpression.Validate(bodyreminderTime, nameof(bodyreminderTime), required: false);
            WorkflowExpression.Validate(bodyunlockedMeetingJoinSecurity, nameof(bodyunlockedMeetingJoinSecurity), required: false);
            WorkflowExpression.Validate(bodyenableAutomaticLock, nameof(bodyenableAutomaticLock), required: false);
            WorkflowExpression.Validate(bodyautomaticLockMinutes, nameof(bodyautomaticLockMinutes), required: false);
            WorkflowExpression.Validate(bodyallowFirstUserToBeCoHost, nameof(bodyallowFirstUserToBeCoHost), required: false);
            WorkflowExpression.Validate(bodyallowAuthenticatedDevices, nameof(bodyallowAuthenticatedDevices), required: false);
            WorkflowExpression.Validate(bodysendEmail, nameof(bodysendEmail), required: false);
            WorkflowExpression.Validate(bodyhostEmail, nameof(bodyhostEmail), required: false);
            WorkflowExpression.Validate(bodysiteUrl, nameof(bodysiteUrl), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsenabledChat, nameof(bodymeetingOptionsenabledChat), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsenabledVideo, nameof(bodymeetingOptionsenabledVideo), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsenabledPolling, nameof(bodymeetingOptionsenabledPolling), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsenabledNote, nameof(bodymeetingOptionsenabledNote), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsnoteType, nameof(bodymeetingOptionsnoteType), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsenabledClosedCaptions, nameof(bodymeetingOptionsenabledClosedCaptions), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsenabledFileTransfer, nameof(bodymeetingOptionsenabledFileTransfer), required: false);
            WorkflowExpression.Validate(bodymeetingOptionsenabledUCFRichMedia, nameof(bodymeetingOptionsenabledUCFRichMedia), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledShareContent, nameof(bodyattendeePrivilegesenabledShareContent), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledSaveDocument, nameof(bodyattendeePrivilegesenabledSaveDocument), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledPrintDocument, nameof(bodyattendeePrivilegesenabledPrintDocument), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledAnnotate, nameof(bodyattendeePrivilegesenabledAnnotate), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledViewParticipantList, nameof(bodyattendeePrivilegesenabledViewParticipantList), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledViewThumbnails, nameof(bodyattendeePrivilegesenabledViewThumbnails), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledRemoteControl, nameof(bodyattendeePrivilegesenabledRemoteControl), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledViewAnyDocument, nameof(bodyattendeePrivilegesenabledViewAnyDocument), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledViewAnyPage, nameof(bodyattendeePrivilegesenabledViewAnyPage), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledContactOperatorPrivately, nameof(bodyattendeePrivilegesenabledContactOperatorPrivately), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledChatHost, nameof(bodyattendeePrivilegesenabledChatHost), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledChatPresenter, nameof(bodyattendeePrivilegesenabledChatPresenter), required: false);
            WorkflowExpression.Validate(bodyattendeePrivilegesenabledChatOtherParticipants, nameof(bodyattendeePrivilegesenabledChatOtherParticipants), required: false);
            WorkflowExpression.Validate(bodyintegrationTags, nameof(bodyintegrationTags), required: false);
            WorkflowExpression.Validate(bodyenabledBreakoutSessions, nameof(bodyenabledBreakoutSessions), required: false);
            WorkflowExpression.Validate(bodytrackingCodes, nameof(bodytrackingCodes), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsaudioConnectionType, nameof(bodyaudioConnectionOptionsaudioConnectionType), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsenabledTollFreeCallIn, nameof(bodyaudioConnectionOptionsenabledTollFreeCallIn), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsenabledGlobalCallIn, nameof(bodyaudioConnectionOptionsenabledGlobalCallIn), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsenabledAudienceCallBack, nameof(bodyaudioConnectionOptionsenabledAudienceCallBack), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsentryAndExitTone, nameof(bodyaudioConnectionOptionsentryAndExitTone), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsallowHostToUnmuteParticipants, nameof(bodyaudioConnectionOptionsallowHostToUnmuteParticipants), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf, nameof(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf), required: false);
            WorkflowExpression.Validate(bodyaudioConnectionOptionsmuteAttendeeUponEntry, nameof(bodyaudioConnectionOptionsmuteAttendeeUponEntry), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meetings/{0}", ExpressionConverter.ConvertWithUrlEncoding(meetingId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodyagenda != null)
                {
                    body["agenda"] = ExpressionConverter.ConvertO(bodyagenda);
                    bodypropCount++;
                }

                if (bodypassword != null)
                {
                    body["password"] = ExpressionConverter.ConvertO(bodypassword);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["timezone"] = ExpressionConverter.ConvertO(bodytimezone);
                    bodypropCount++;
                }

                if (bodystart != null)
                {
                    body["start"] = ExpressionConverter.ConvertO(bodystart);
                    bodypropCount++;
                }

                if (bodyend != null)
                {
                    body["end"] = ExpressionConverter.ConvertO(bodyend);
                    bodypropCount++;
                }

                if (bodyenabledAutoRecordMeeting != null)
                {
                    body["enabledAutoRecordMeeting"] = ExpressionConverter.ConvertO(bodyenabledAutoRecordMeeting);
                    bodypropCount++;
                }

                if (bodyallowAnyUserToBeCoHost != null)
                {
                    body["allowAnyUserToBeCoHost"] = ExpressionConverter.ConvertO(bodyallowAnyUserToBeCoHost);
                    bodypropCount++;
                }

                if (bodyenabledJoinBeforeHost != null)
                {
                    body["enabledJoinBeforeHost"] = ExpressionConverter.ConvertO(bodyenabledJoinBeforeHost);
                    bodypropCount++;
                }

                if (bodyenableConnectAudioBeforeHost != null)
                {
                    body["enableConnectAudioBeforeHost"] = ExpressionConverter.ConvertO(bodyenableConnectAudioBeforeHost);
                    bodypropCount++;
                }

                if (bodyjoinBeforeHostMinutes != null)
                {
                    body["joinBeforeHostMinutes"] = ExpressionConverter.ConvertO(bodyjoinBeforeHostMinutes);
                    bodypropCount++;
                }

                if (bodyexcludePassword != null)
                {
                    body["excludePassword"] = ExpressionConverter.ConvertO(bodyexcludePassword);
                    bodypropCount++;
                }

                if (bodypublicMeeting != null)
                {
                    body["publicMeeting"] = ExpressionConverter.ConvertO(bodypublicMeeting);
                    bodypropCount++;
                }

                if (bodyreminderTime != null)
                {
                    body["reminderTime"] = ExpressionConverter.ConvertO(bodyreminderTime);
                    bodypropCount++;
                }

                if (bodyunlockedMeetingJoinSecurity != null)
                {
                    body["unlockedMeetingJoinSecurity"] = ExpressionConverter.ConvertO(bodyunlockedMeetingJoinSecurity);
                    bodypropCount++;
                }

                if (bodyenableAutomaticLock != null)
                {
                    body["enableAutomaticLock"] = ExpressionConverter.ConvertO(bodyenableAutomaticLock);
                    bodypropCount++;
                }

                if (bodyautomaticLockMinutes != null)
                {
                    body["automaticLockMinutes"] = ExpressionConverter.ConvertO(bodyautomaticLockMinutes);
                    bodypropCount++;
                }

                if (bodyallowFirstUserToBeCoHost != null)
                {
                    body["allowFirstUserToBeCoHost"] = ExpressionConverter.ConvertO(bodyallowFirstUserToBeCoHost);
                    bodypropCount++;
                }

                if (bodyallowAuthenticatedDevices != null)
                {
                    body["allowAuthenticatedDevices"] = ExpressionConverter.ConvertO(bodyallowAuthenticatedDevices);
                    bodypropCount++;
                }

                if (bodysendEmail != null)
                {
                    body["sendEmail"] = ExpressionConverter.ConvertO(bodysendEmail);
                    bodypropCount++;
                }

                if (bodyhostEmail != null)
                {
                    body["hostEmail"] = ExpressionConverter.ConvertO(bodyhostEmail);
                    bodypropCount++;
                }

                if (bodysiteUrl != null)
                {
                    body["siteUrl"] = ExpressionConverter.ConvertO(bodysiteUrl);
                    bodypropCount++;
                }

                var meetingOptionsObject = new JObject();
                var meetingOptionsObjectpropCount = 0;
                if (bodymeetingOptionsenabledChat != null)
                {
                    meetingOptionsObject["enabledChat"] = ExpressionConverter.ConvertO(bodymeetingOptionsenabledChat);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledVideo != null)
                {
                    meetingOptionsObject["enabledVideo"] = ExpressionConverter.ConvertO(bodymeetingOptionsenabledVideo);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledPolling != null)
                {
                    meetingOptionsObject["enabledPolling"] = ExpressionConverter.ConvertO(bodymeetingOptionsenabledPolling);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledNote != null)
                {
                    meetingOptionsObject["enabledNote"] = ExpressionConverter.ConvertO(bodymeetingOptionsenabledNote);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsnoteType != null)
                {
                    meetingOptionsObject["noteType"] = ExpressionConverter.ConvertO(bodymeetingOptionsnoteType);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledClosedCaptions != null)
                {
                    meetingOptionsObject["enabledClosedCaptions"] = ExpressionConverter.ConvertO(bodymeetingOptionsenabledClosedCaptions);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledFileTransfer != null)
                {
                    meetingOptionsObject["enabledFileTransfer"] = ExpressionConverter.ConvertO(bodymeetingOptionsenabledFileTransfer);
                    meetingOptionsObjectpropCount++;
                }

                if (bodymeetingOptionsenabledUCFRichMedia != null)
                {
                    meetingOptionsObject["enabledUCFRichMedia"] = ExpressionConverter.ConvertO(bodymeetingOptionsenabledUCFRichMedia);
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
                    attendeePrivilegesObject["enabledShareContent"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledShareContent);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledSaveDocument != null)
                {
                    attendeePrivilegesObject["enabledSaveDocument"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledSaveDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledPrintDocument != null)
                {
                    attendeePrivilegesObject["enabledPrintDocument"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledPrintDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledAnnotate != null)
                {
                    attendeePrivilegesObject["enabledAnnotate"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledAnnotate);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewParticipantList != null)
                {
                    attendeePrivilegesObject["enabledViewParticipantList"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledViewParticipantList);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewThumbnails != null)
                {
                    attendeePrivilegesObject["enabledViewThumbnails"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledViewThumbnails);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledRemoteControl != null)
                {
                    attendeePrivilegesObject["enabledRemoteControl"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledRemoteControl);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewAnyDocument != null)
                {
                    attendeePrivilegesObject["enabledViewAnyDocument"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledViewAnyDocument);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledViewAnyPage != null)
                {
                    attendeePrivilegesObject["enabledViewAnyPage"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledViewAnyPage);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledContactOperatorPrivately != null)
                {
                    attendeePrivilegesObject["enabledContactOperatorPrivately"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledContactOperatorPrivately);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledChatHost != null)
                {
                    attendeePrivilegesObject["enabledChatHost"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledChatHost);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledChatPresenter != null)
                {
                    attendeePrivilegesObject["enabledChatPresenter"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledChatPresenter);
                    attendeePrivilegesObjectpropCount++;
                }

                if (bodyattendeePrivilegesenabledChatOtherParticipants != null)
                {
                    attendeePrivilegesObject["enabledChatOtherParticipants"] = ExpressionConverter.ConvertO(bodyattendeePrivilegesenabledChatOtherParticipants);
                    attendeePrivilegesObjectpropCount++;
                }

                if (attendeePrivilegesObjectpropCount > 0)
                {
                    body["attendeePrivileges"] = attendeePrivilegesObject;
                    bodypropCount++;
                }

                if (bodyintegrationTags != null)
                {
                    body["integrationTags"] = ExpressionConverter.ConvertO(bodyintegrationTags);
                    bodypropCount++;
                }

                if (bodyenabledBreakoutSessions != null)
                {
                    body["enabledBreakoutSessions"] = ExpressionConverter.ConvertO(bodyenabledBreakoutSessions);
                    bodypropCount++;
                }

                if (bodytrackingCodes != null)
                {
                    body["trackingCodes"] = ExpressionConverter.ConvertO(bodytrackingCodes);
                    bodypropCount++;
                }

                var audioConnectionOptionsObject = new JObject();
                var audioConnectionOptionsObjectpropCount = 0;
                if (bodyaudioConnectionOptionsaudioConnectionType != null)
                {
                    audioConnectionOptionsObject["audioConnectionType"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsaudioConnectionType);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsenabledTollFreeCallIn != null)
                {
                    audioConnectionOptionsObject["enabledTollFreeCallIn"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsenabledTollFreeCallIn);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsenabledGlobalCallIn != null)
                {
                    audioConnectionOptionsObject["enabledGlobalCallIn"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsenabledGlobalCallIn);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsenabledAudienceCallBack != null)
                {
                    audioConnectionOptionsObject["enabledAudienceCallBack"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsenabledAudienceCallBack);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsentryAndExitTone != null)
                {
                    audioConnectionOptionsObject["entryAndExitTone"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsentryAndExitTone);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsallowHostToUnmuteParticipants != null)
                {
                    audioConnectionOptionsObject["allowHostToUnmuteParticipants"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsallowHostToUnmuteParticipants);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf != null)
                {
                    audioConnectionOptionsObject["allowAttendeeToUnmuteSelf"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsallowAttendeeToUnmuteSelf);
                    audioConnectionOptionsObjectpropCount++;
                }

                if (bodyaudioConnectionOptionsmuteAttendeeUponEntry != null)
                {
                    audioConnectionOptionsObject["muteAttendeeUponEntry"] = ExpressionConverter.ConvertO(bodyaudioConnectionOptionsmuteAttendeeUponEntry);
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