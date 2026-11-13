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
        public IBodyWorkflowAction<DialResponse, ApiConnectionActionConfiguration> Dial(Expression<Func<DialBodyInput>> body)
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
        public IBodyWorkflowTrigger<GetCallRecordingsResponse, ApiConnectionPollingTriggerConfiguration> GetCallRecordings(Expression<Func<int>> recordId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> destination = null, Expression<Func<string>> source = null, Expression<Func<string>> direction = null, Expression<Func<int>> contactId = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null)
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
            return new DeferredBodyTrigger<GetCallRecordingsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetCallRecordingsResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetCallHistoryResponse, ApiConnectionPollingTriggerConfiguration> GetCallHistory(Expression<Func<int>> callId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> destination = null, Expression<Func<string>> source = null, Expression<Func<string>> direction = null, Expression<Func<int>> contactId = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null)
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
            return new DeferredBodyTrigger<GetCallHistoryResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetCallHistoryResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetVoicemailBoxesResponse, ApiConnectionPollingTriggerConfiguration> GetVoicemailBoxes(Expression<Func<int>> boxId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_boxId = WorkflowExpression.Compile(boxId, nameof(boxId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetVoicemailBoxesResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetVoicemailBoxesResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetVoicemailsResponse, ApiConnectionPollingTriggerConfiguration> GetVoicemails(Expression<Func<int>> voicemailId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> source = null, Expression<Func<int>> contactId = null, Expression<Func<int>> boxId = null, Expression<Func<string>> dateFrom = null, Expression<Func<string>> dateTo = null)
        {
            var __workflow_voicemailId = WorkflowExpression.Compile(voicemailId, nameof(voicemailId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_boxId = WorkflowExpression.Compile(boxId, nameof(boxId), required: false);
            var __workflow_dateFrom = WorkflowExpression.Compile(dateFrom, nameof(dateFrom), required: false);
            var __workflow_dateTo = WorkflowExpression.Compile(dateTo, nameof(dateTo), required: false);
            return new DeferredBodyTrigger<GetVoicemailsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetVoicemailsResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetAudioPromptsResponse, ApiConnectionPollingTriggerConfiguration> GetAudioPrompts(Expression<Func<int>> promptId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_promptId = WorkflowExpression.Compile(promptId, nameof(promptId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetAudioPromptsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetAudioPromptsResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetVoipEndpointsResponse, ApiConnectionPollingTriggerConfiguration> GetVoipEndpoints(Expression<Func<int>> endpointId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_endpointId = WorkflowExpression.Compile(endpointId, nameof(endpointId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetVoipEndpointsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetVoipEndpointsResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<CallConnectedResponse, ApiConnectionPollingTriggerConfiguration> CallConnected()
        {
            return new DeferredBodyTrigger<CallConnectedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallConnected";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<CallConnectedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<CallCompletedResponse, ApiConnectionPollingTriggerConfiguration> CallCompleted()
        {
            return new DeferredBodyTrigger<CallCompletedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<CallCompletedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<VoicemailCreatedResponse, ApiConnectionPollingTriggerConfiguration> VoicemailCreated()
        {
            return new DeferredBodyTrigger<VoicemailCreatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/VoicemailCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<VoicemailCreatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<VoicemailDeletedResponse, ApiConnectionPollingTriggerConfiguration> VoicemailDeleted()
        {
            return new DeferredBodyTrigger<VoicemailDeletedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/VoicemailDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<VoicemailDeletedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<LostCallerAddedResponse, ApiConnectionPollingTriggerConfiguration> LostCallerAdded()
        {
            return new DeferredBodyTrigger<LostCallerAddedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/LostCallerAdded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<LostCallerAddedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<LostCallerUpdatedResponse, ApiConnectionPollingTriggerConfiguration> LostCallerUpdated()
        {
            return new DeferredBodyTrigger<LostCallerUpdatedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/LostCallerUpdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<LostCallerUpdatedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<LostCallerRemovedResponse, ApiConnectionPollingTriggerConfiguration> LostCallerRemoved()
        {
            return new DeferredBodyTrigger<LostCallerRemovedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/LostCallerRemoved";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<LostCallerRemovedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<CallRecordedResponse, ApiConnectionPollingTriggerConfiguration> CallRecorded()
        {
            return new DeferredBodyTrigger<CallRecordedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallRecorded";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<CallRecordedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<CallTransferedResponse, ApiConnectionPollingTriggerConfiguration> CallTransfered()
        {
            return new DeferredBodyTrigger<CallTransferedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallTransfered";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<CallTransferedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<CallStartedResponse, ApiConnectionPollingTriggerConfiguration> CallStarted()
        {
            return new DeferredBodyTrigger<CallStartedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/webhooks/CallStarted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = new CallCompletedBodyInput().ToJToken();
                return new ApiConnectionPollingTrigger<CallStartedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetGroupsResponse, ApiConnectionPollingTriggerConfiguration> GetGroups(Expression<Func<int>> groupId = null, Expression<Func<int>> contactId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyTrigger<GetGroupsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetGroupsResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<GetContactsResponse, ApiConnectionPollingTriggerConfiguration> GetContacts(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<int>> contactId = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_contactId = WorkflowExpression.Compile(contactId, nameof(contactId), required: false);
            return new DeferredBodyTrigger<GetContactsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
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
                return new ApiConnectionPollingTrigger<GetContactsResponse>(callPayload);
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
        public string RecordingUrl { get; set; }
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
        public string MessageUrl { get; set; }
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

    public class DialBodyInput
    {
        public DialBodyInput(string destination, int contactId)
        {
            this.Destination = destination;
            this.ContactId = contactId;
        }

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
        public string RecordingUrl { get; set; }
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
        public string MessageUrl { get; set; }
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

    public class CallCompletedBodyInput
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