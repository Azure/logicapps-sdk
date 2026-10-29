//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobilistotele
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobilistoteleActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetContactsByIdResponse, ApiConnectionActionConfiguration> GetContactsById(Expression<Func<int>> contactId)
        {
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: true);
            return new DeferredBodyAction<GetContactsByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/contacts/{0}", __workflow_contactId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetContactsByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetGroupByIdResponse, ApiConnectionActionConfiguration> GetGroupById(Expression<Func<int>> groupId)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            return new DeferredBodyAction<GetGroupByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetGroupByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetCallRecordingByIdResponse, ApiConnectionActionConfiguration> GetCallRecordingById(Expression<Func<int>> recordId)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<GetCallRecordingByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/call_records/{0}", __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCallRecordingByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetCallHistoryItemByIdResponse, ApiConnectionActionConfiguration> GetCallHistoryItemById(Expression<Func<int>> callId)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: true);
            return new DeferredBodyAction<GetCallHistoryItemByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/call_history/{0}", __workflow_callId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCallHistoryItemByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetVoicemailBoxByIdResponse, ApiConnectionActionConfiguration> GetVoicemailBoxById(Expression<Func<int>> boxId)
        {
            var __workflow_boxId = WorkflowExpression.Compile(boxId, nameof(boxId), required: true);
            return new DeferredBodyAction<GetVoicemailBoxByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/voicemail_boxes/{0}", __workflow_boxId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetVoicemailBoxByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetVoicemailByIdResponse, ApiConnectionActionConfiguration> GetVoicemailById(Expression<Func<int>> voicemailId)
        {
            var __workflow_voicemailId = WorkflowExpression.Compile(voicemailId, nameof(voicemailId), required: true);
            return new DeferredBodyAction<GetVoicemailByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/voicemails/{0}", __workflow_voicemailId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetVoicemailByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetAudioPromptByIdResponse, ApiConnectionActionConfiguration> GetAudioPromptById(Expression<Func<int>> promptId)
        {
            var __workflow_promptId = WorkflowExpression.Compile(promptId, nameof(promptId), required: true);
            return new DeferredBodyAction<GetAudioPromptByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audio_prompts/{0}", __workflow_promptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAudioPromptByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetVoipEndpointByIdResponse, ApiConnectionActionConfiguration> GetVoipEndpointById(Expression<Func<int>> endpointId)
        {
            var __workflow_endpointId = WorkflowExpression.Compile(endpointId, nameof(endpointId), required: true);
            return new DeferredBodyAction<GetVoipEndpointByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/voip_endpoints/{0}", __workflow_endpointId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetVoipEndpointByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<DialResponse, ApiConnectionActionConfiguration> Dial(Expression<Func<DialInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DialResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/dial";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DialResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobilistotele")]
        public IBodyWorkflowAction<GetLostCallsResponse, ApiConnectionActionConfiguration> GetLostCalls(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> destination = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: false);
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: false);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: false);
            return new DeferredBodyAction<GetLostCallsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lost_calls";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_destination != null)
                    callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                if (__workflow_dateFrom != null)
                    callPayload.Queries["date_from"] = ExpressionConverter.Convert(__workflow_dateFrom);
                if (__workflow_dateTo != null)
                    callPayload.Queries["date_to"] = ExpressionConverter.Convert(__workflow_dateTo);
                return new ApiConnectionAction<GetLostCallsResponse>(callPayload);
            });
        }
    }

    public class MobilistoteleTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<GetCallRecordingsResponse, ApiConnectionTriggerConfiguration> GetCallRecordings(Expression<Func<int>> recordId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> destination = null, Expression<Func<string>> source = null, Expression<Func<string>> direction = null, Expression<Func<int>> contactId = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null, FlowRecurrence recurrence = null)
        {
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: false);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: false);
            return new DeferredBodyTrigger<GetCallRecordingsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/call_records";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recordId != null)
                    callPayload.Queries["record_id"] = ExpressionConverter.Convert(__workflow_recordId);
                callPayload.Queries["initial_record_id"] = Convert.ToString(0);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_destination != null)
                    callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_contactId != null)
                    callPayload.Queries["contact_id"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_dateFrom != null)
                    callPayload.Queries["date_from"] = ExpressionConverter.Convert(__workflow_dateFrom);
                if (__workflow_dateTo != null)
                    callPayload.Queries["date_to"] = ExpressionConverter.Convert(__workflow_dateTo);
                return new ApiConnectionTrigger<GetCallRecordingsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetCallHistoryResponse, ApiConnectionTriggerConfiguration> GetCallHistory(Expression<Func<int>> callId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> destination = null, Expression<Func<string>> source = null, Expression<Func<string>> direction = null, Expression<Func<int>> contactId = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null, FlowRecurrence recurrence = null)
        {
            var __workflow_callId = WorkflowExpression.Compile(callId, nameof(callId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_direction = WorkflowExpression.Compile(direction, nameof(direction), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: false);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: false);
            return new DeferredBodyTrigger<GetCallHistoryResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/call_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_callId != null)
                    callPayload.Queries["call_id"] = ExpressionConverter.Convert(__workflow_callId);
                callPayload.Queries["initial_call_id"] = Convert.ToString(0);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_destination != null)
                    callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_direction != null)
                    callPayload.Queries["direction"] = ExpressionConverter.Convert(__workflow_direction);
                if (__workflow_contactId != null)
                    callPayload.Queries["contact_id"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_dateFrom != null)
                    callPayload.Queries["date_from"] = ExpressionConverter.Convert(__workflow_dateFrom);
                if (__workflow_dateTo != null)
                    callPayload.Queries["date_to"] = ExpressionConverter.Convert(__workflow_dateTo);
                return new ApiConnectionTrigger<GetCallHistoryResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetVoicemailBoxesResponse, ApiConnectionTriggerConfiguration> GetVoicemailBoxes(Expression<Func<int>> boxId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, FlowRecurrence recurrence = null)
        {
            var __workflow_boxId = WorkflowExpression.Compile(boxId, nameof(boxId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetVoicemailBoxesResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/voicemail_boxes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_boxId != null)
                    callPayload.Queries["box_id"] = ExpressionConverter.Convert(__workflow_boxId);
                callPayload.Queries["initial_box_id"] = Convert.ToString(0);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionTrigger<GetVoicemailBoxesResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetVoicemailsResponse, ApiConnectionTriggerConfiguration> GetVoicemails(Expression<Func<int>> voicemailId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> source = null, Expression<Func<int>> contactId = null, Expression<Func<int>> boxId = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null, FlowRecurrence recurrence = null)
        {
            var __workflow_voicemailId = WorkflowExpression.Compile(voicemailId, nameof(voicemailId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_boxId = WorkflowExpression.Compile(boxId, nameof(boxId), required: false);
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: false);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: false);
            return new DeferredBodyTrigger<GetVoicemailsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/voicemails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_voicemailId != null)
                    callPayload.Queries["voicemail_id"] = ExpressionConverter.Convert(__workflow_voicemailId);
                callPayload.Queries["initial_voicemail_id"] = Convert.ToString(0);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_contactId != null)
                    callPayload.Queries["contact_id"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_boxId != null)
                    callPayload.Queries["box_id"] = ExpressionConverter.Convert(__workflow_boxId);
                if (__workflow_dateFrom != null)
                    callPayload.Queries["date_from"] = ExpressionConverter.Convert(__workflow_dateFrom);
                if (__workflow_dateTo != null)
                    callPayload.Queries["date_to"] = ExpressionConverter.Convert(__workflow_dateTo);
                return new ApiConnectionTrigger<GetVoicemailsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetAudioPromptsResponse, ApiConnectionTriggerConfiguration> GetAudioPrompts(Expression<Func<int>> promptId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, FlowRecurrence recurrence = null)
        {
            var __workflow_promptId = WorkflowExpression.Compile(promptId, nameof(promptId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetAudioPromptsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/audio_prompts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_promptId != null)
                    callPayload.Queries["prompt_id"] = ExpressionConverter.Convert(__workflow_promptId);
                callPayload.Queries["initial_prompt_id"] = Convert.ToString(0);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionTrigger<GetAudioPromptsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetVoipEndpointsResponse, ApiConnectionTriggerConfiguration> GetVoipEndpoints(Expression<Func<int>> endpointId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, FlowRecurrence recurrence = null)
        {
            var __workflow_endpointId = WorkflowExpression.Compile(endpointId, nameof(endpointId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetVoipEndpointsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/voip_endpoints";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_endpointId != null)
                    callPayload.Queries["endpoint_id"] = ExpressionConverter.Convert(__workflow_endpointId);
                callPayload.Queries["initial_endpoint_id"] = Convert.ToString(0);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionTrigger<GetVoipEndpointsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallConnectedResponse, ApiConnectionTriggerConfiguration> CallConnected(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<CallConnectedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallConnected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallConnectedInput().ToJToken();
                return new ApiConnectionTrigger<CallConnectedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallCompletedResponse, ApiConnectionTriggerConfiguration> CallCompleted(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<CallCompletedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedInput().ToJToken();
                return new ApiConnectionTrigger<CallCompletedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VoicemailCreatedResponse, ApiConnectionTriggerConfiguration> VoicemailCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<VoicemailCreatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/VoicemailCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new VoicemailCreatedInput().ToJToken();
                return new ApiConnectionTrigger<VoicemailCreatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<VoicemailDeletedResponse, ApiConnectionTriggerConfiguration> VoicemailDeleted(Expression<Func<VoicemailDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<VoicemailDeletedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/VoicemailDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<VoicemailDeletedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<LostCallerAddedResponse, ApiConnectionTriggerConfiguration> LostCallerAdded(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<LostCallerAddedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/LostCallerAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new LostCallerAddedInput().ToJToken();
                return new ApiConnectionTrigger<LostCallerAddedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<LostCallerUpdatedResponse, ApiConnectionTriggerConfiguration> LostCallerUpdated(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<LostCallerUpdatedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/LostCallerUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new LostCallerUpdatedInput().ToJToken();
                return new ApiConnectionTrigger<LostCallerUpdatedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<LostCallerRemovedResponse, ApiConnectionTriggerConfiguration> LostCallerRemoved(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<LostCallerRemovedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/LostCallerRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new LostCallerRemovedInput().ToJToken();
                return new ApiConnectionTrigger<LostCallerRemovedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallRecordedResponse, ApiConnectionTriggerConfiguration> CallRecorded(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<CallRecordedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallRecorded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallRecordedInput().ToJToken();
                return new ApiConnectionTrigger<CallRecordedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallTransferedResponse, ApiConnectionTriggerConfiguration> CallTransfered(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<CallTransferedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallTransfered";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallTransferedInput().ToJToken();
                return new ApiConnectionTrigger<CallTransferedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<CallStartedResponse, ApiConnectionTriggerConfiguration> CallStarted(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<CallStartedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallStarted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallStartedInput().ToJToken();
                return new ApiConnectionTrigger<CallStartedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetGroupsResponse, ApiConnectionTriggerConfiguration> GetGroups(Expression<Func<int>> groupId = null, Expression<Func<int>> contactId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, FlowRecurrence recurrence = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetGroupsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_groupId != null)
                    callPayload.Queries["group_id"] = ExpressionConverter.Convert(__workflow_groupId);
                callPayload.Queries["initial_group_id"] = Convert.ToString(0);
                if (__workflow_contactId != null)
                    callPayload.Queries["contact_id"] = ExpressionConverter.Convert(__workflow_contactId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionTrigger<GetGroupsResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<GetContactsResponse, ApiConnectionTriggerConfiguration> GetContacts(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int>> contactId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            return new DeferredBodyTrigger<GetContactsResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_contactId != null)
                    callPayload.Queries["contact_id"] = ExpressionConverter.Convert(__workflow_contactId);
                callPayload.Queries["initial_contact_id"] = Convert.ToString(0);
                return new ApiConnectionTrigger<GetContactsResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class GetContactsByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetContactsByIdResponseDataType Data { get; set; }
    }

    public class GetContactsByIdResponseDataType
    {
        [JsonProperty("current_callerid")]
        public string CurrentCallerid { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("group_membership")]
        public GetContactsByIdResponseDataTypeGroupMembershipTypeItem[] GroupMembership { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class GetContactsByIdResponseDataTypeGroupMembershipTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("groupID")]
        public int GroupId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public GetContactsByIdResponseDataTypeGroupMembershipTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class GetContactsByIdResponseDataTypeGroupMembershipTypeItemMembersTypeItem
    {
        [JsonProperty("contactID")]
        public int ContactId { get; set; }
    }

    public class GetGroupByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetGroupByIdResponseDataType Data { get; set; }
    }

    public class GetGroupByIdResponseDataType
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("groupID")]
        public int GroupId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public GetGroupByIdResponseDataTypeMembersTypeItem[] Members { get; set; }
    }

    public class GetGroupByIdResponseDataTypeMembersTypeItem
    {
        [JsonProperty("contactID")]
        public int ContactId { get; set; }
    }

    public class GetCallRecordingByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetCallRecordingByIdResponseDataType Data { get; set; }
    }

    public class GetCallRecordingByIdResponseDataType
    {
        [JsonProperty("recordingID")]
        public int RecordingId { get; set; }

        [JsonProperty("callID")]
        public int CallId { get; set; }

        [JsonProperty("caller")]
        public string Caller { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("callStarted")]
        public string CallStarted { get; set; }

        [JsonProperty("callConnected")]
        public string CallConnected { get; set; }

        [JsonProperty("callEnded")]
        public string CallEnded { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("recordingURL")]
        public string RecordingURL { get; set; }
    }

    public class GetCallHistoryItemByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetCallHistoryItemByIdResponseDataType Data { get; set; }
    }

    public class GetCallHistoryItemByIdResponseDataType
    {
        [JsonProperty("callID")]
        public int CallId { get; set; }

        [JsonProperty("caller")]
        public string Caller { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("callStarted")]
        public string CallStarted { get; set; }

        [JsonProperty("callConnected")]
        public string CallConnected { get; set; }

        [JsonProperty("callEnded")]
        public string CallEnded { get; set; }

        [JsonProperty("connectionTime")]
        public int ConnectionTime { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("recordingID")]
        public int RecordingId { get; set; }
    }

    public class GetVoicemailBoxByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetVoicemailBoxByIdResponseDataType Data { get; set; }
    }

    public class GetVoicemailBoxByIdResponseDataType
    {
        [JsonProperty("clientID")]
        public int ClientId { get; set; }

        [JsonProperty("boxName")]
        public string BoxName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("voicemailBoxID")]
        public int VoicemailBoxId { get; set; }
    }

    public class GetVoicemailByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetVoicemailByIdResponseDataType Data { get; set; }
    }

    public class GetVoicemailByIdResponseDataType
    {
        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("voicemailID")]
        public int VoicemailId { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("callStarted")]
        public string CallStarted { get; set; }

        [JsonProperty("voicemailBoxID")]
        public int VoicemailBoxId { get; set; }

        [JsonProperty("voicemailBoxName")]
        public string VoicemailBoxName { get; set; }

        [JsonProperty("messageURL")]
        public string MessageURL { get; set; }
    }

    public class GetAudioPromptByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetAudioPromptByIdResponseDataType Data { get; set; }
    }

    public class GetAudioPromptByIdResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }

    public class GetVoipEndpointByIdResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetVoipEndpointByIdResponseDataType Data { get; set; }
    }

    public class GetVoipEndpointByIdResponseDataType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("employee_id")]
        public int EmployeeId { get; set; }
    }

    public class DialResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class DialInput
    {
        [JsonProperty("destination", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Destination { get; set; }

        [JsonProperty("contactID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ContactId { get; set; }
    }

    public class GetLostCallsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetLostCallsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetLostCallsResponseDataTypeItem
    {
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("callerid")]
        public string Callerid { get; set; }

        [JsonProperty("last_contact")]
        public string LastContact { get; set; }
    }

    public class GetCallRecordingsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetCallRecordingsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetCallRecordingsResponseDataTypeItem
    {
        [JsonProperty("recordingID")]
        public int RecordingId { get; set; }

        [JsonProperty("callID")]
        public int CallId { get; set; }

        [JsonProperty("caller")]
        public string Caller { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("callStarted")]
        public string CallStarted { get; set; }

        [JsonProperty("callConnected")]
        public string CallConnected { get; set; }

        [JsonProperty("callEnded")]
        public string CallEnded { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("recordingURL")]
        public string RecordingURL { get; set; }
    }

    public class GetCallHistoryResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetCallHistoryResponseDataTypeItem[] Data { get; set; }
    }

    public class GetCallHistoryResponseDataTypeItem
    {
        [JsonProperty("callID")]
        public int CallId { get; set; }

        [JsonProperty("caller")]
        public string Caller { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("callStarted")]
        public string CallStarted { get; set; }

        [JsonProperty("callConnected")]
        public string CallConnected { get; set; }

        [JsonProperty("callEnded")]
        public string CallEnded { get; set; }

        [JsonProperty("connectionTime")]
        public int ConnectionTime { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("recordingID")]
        public int RecordingId { get; set; }
    }

    public class GetVoicemailBoxesResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetVoicemailBoxesResponseDataTypeItem[] Data { get; set; }
    }

    public class GetVoicemailBoxesResponseDataTypeItem
    {
        [JsonProperty("clientID")]
        public int ClientId { get; set; }

        [JsonProperty("boxName")]
        public string BoxName { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("voicemailBoxID")]
        public int VoicemailBoxId { get; set; }
    }

    public class GetVoicemailsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetVoicemailsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetVoicemailsResponseDataTypeItem
    {
        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("voicemailID")]
        public int VoicemailId { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("callStarted")]
        public string CallStarted { get; set; }

        [JsonProperty("voicemailBoxID")]
        public int VoicemailBoxId { get; set; }

        [JsonProperty("voicemailBoxName")]
        public string VoicemailBoxName { get; set; }

        [JsonProperty("messageURL")]
        public string MessageURL { get; set; }
    }

    public class GetAudioPromptsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetAudioPromptsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetAudioPromptsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }
    }

    public class GetVoipEndpointsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetVoipEndpointsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetVoipEndpointsResponseDataTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("employee_id")]
        public int EmployeeId { get; set; }
    }

    public class CallConnectedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class CallConnectedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class CallCompletedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class CallCompletedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class VoicemailCreatedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class VoicemailCreatedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class VoicemailDeletedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class VoicemailDeletedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class LostCallerAddedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class LostCallerAddedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class LostCallerUpdatedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class LostCallerUpdatedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class LostCallerRemovedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class LostCallerRemovedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class CallRecordedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class CallRecordedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class CallTransferedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class CallTransferedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class CallStartedResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }

    public class CallStartedInput
    {
        [JsonProperty("endpoint", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Endpoint { get; set; } = "#{listCallbackUrl()}";
    }

    public class GetGroupsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetGroupsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetGroupsResponseDataTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("groupID")]
        public int GroupId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public GetGroupsResponseDataTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class GetGroupsResponseDataTypeItemMembersTypeItem
    {
        [JsonProperty("contactID")]
        public int ContactId { get; set; }
    }

    public class GetContactsResponse
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public GetContactsResponseDataTypeItem[] Data { get; set; }
    }

    public class GetContactsResponseDataTypeItem
    {
        [JsonProperty("current_callerid")]
        public string CurrentCallerid { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }

        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("contactID")]
        public int ContactId { get; set; }

        [JsonProperty("group_membership")]
        public GetContactsResponseDataTypeItemGroupMembershipTypeItem[] GroupMembership { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    public class GetContactsResponseDataTypeItemGroupMembershipTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("groupID")]
        public int GroupId { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public GetContactsResponseDataTypeItemGroupMembershipTypeItemMembersTypeItem[] Members { get; set; }
    }

    public class GetContactsResponseDataTypeItemGroupMembershipTypeItemMembersTypeItem
    {
        [JsonProperty("contactID")]
        public int ContactId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mobilistotele;

    public partial class WorkflowManagedActions
    {
        public MobilistoteleActions Mobilistotele(string connectionId) => new MobilistoteleActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MobilistoteleTriggers Mobilistotele(string connectionId) => new MobilistoteleTriggers(connectionId);
    }
}