//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fhirbase
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FhirbaseActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentResponse, ApiConnectionActionConfiguration> GetAppointment(Expression<Func<string>> patient = null, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetAppointmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Appointment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetAppointmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostAppointmentResponse, ApiConnectionActionConfiguration> PostAppointment(Expression<Func<PostAppointmentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostAppointmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Appointment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostAppointmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentIdResponse, ApiConnectionActionConfiguration> GetAppointmentId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetAppointmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppointmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeleteAppointmentIdResponse, ApiConnectionActionConfiguration> DeleteAppointmentId(Expression<Func<string>> id, Expression<Func<DeleteAppointmentIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteAppointmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteAppointmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutAppointmentIdResponse, ApiConnectionActionConfiguration> PutAppointmentId(Expression<Func<string>> id, Expression<Func<DeleteAppointmentIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutAppointmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutAppointmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentIdVersionResponse, ApiConnectionActionConfiguration> GetAppointmentIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetAppointmentIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppointmentIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentIdHistoryResponse, ApiConnectionActionConfiguration> GetAppointmentIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetAppointmentIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppointmentIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentHistoryResponse, ApiConnectionActionConfiguration> GetAppointmentHistory(Expression<Func<string>> patient = null)
        {
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetAppointmentHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Appointment/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetAppointmentHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentResponseResponse, ApiConnectionActionConfiguration> GetAppointmentResponse(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetAppointmentResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AppointmentResponse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetAppointmentResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostAppointmentResponseResponse, ApiConnectionActionConfiguration> PostAppointmentResponse(Expression<Func<PostAppointmentResponseBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostAppointmentResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AppointmentResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostAppointmentResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentResponseIdResponse, ApiConnectionActionConfiguration> GetAppointmentResponseId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetAppointmentResponseIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppointmentResponseIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeleteAppointmentResponseIdResponse, ApiConnectionActionConfiguration> DeleteAppointmentResponseId(Expression<Func<string>> id, Expression<Func<DeleteAppointmentResponseIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteAppointmentResponseIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteAppointmentResponseIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutAppointmentResponseIdResponse, ApiConnectionActionConfiguration> PutAppointmentResponseId(Expression<Func<string>> id, Expression<Func<DeleteAppointmentResponseIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutAppointmentResponseIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutAppointmentResponseIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentResponseIdVersionResponse, ApiConnectionActionConfiguration> GetAppointmentResponseIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetAppointmentResponseIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppointmentResponseIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentResponseIdHistoryResponse, ApiConnectionActionConfiguration> GetAppointmentResponseIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetAppointmentResponseIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppointmentResponseIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetAppointmentResponseHistoryResponse, ApiConnectionActionConfiguration> GetAppointmentResponseHistory()
        {
            return new DeferredBodyAction<GetAppointmentResponseHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AppointmentResponse/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetAppointmentResponseHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetDeviceResponse, ApiConnectionActionConfiguration> GetDevice(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetDeviceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Device";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostDeviceResponse, ApiConnectionActionConfiguration> PostDevice(Expression<Func<PostDeviceBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostDeviceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Device";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetDeviceIdResponse, ApiConnectionActionConfiguration> GetDeviceId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDeviceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDeviceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeleteDeviceIdResponse, ApiConnectionActionConfiguration> DeleteDeviceId(Expression<Func<string>> id, Expression<Func<DeleteDeviceIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteDeviceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteDeviceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutDeviceIdResponse, ApiConnectionActionConfiguration> PutDeviceId(Expression<Func<string>> id, Expression<Func<DeleteDeviceIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutDeviceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutDeviceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetDeviceIdVersionResponse, ApiConnectionActionConfiguration> GetDeviceIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetDeviceIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDeviceIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetDeviceIdHistoryResponse, ApiConnectionActionConfiguration> GetDeviceIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDeviceIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDeviceIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetDeviceHistoryResponse, ApiConnectionActionConfiguration> GetDeviceHistory()
        {
            return new DeferredBodyAction<GetDeviceHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Device/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetDeviceHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetEncounterResponse, ApiConnectionActionConfiguration> GetEncounter(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetEncounterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Encounter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetEncounterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostEncounterResponse, ApiConnectionActionConfiguration> PostEncounter(Expression<Func<DeleteEncounterIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostEncounterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Encounter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostEncounterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetEncounterIdResponse, ApiConnectionActionConfiguration> GetEncounterId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetEncounterIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEncounterIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeleteEncounterIdResponse, ApiConnectionActionConfiguration> DeleteEncounterId(Expression<Func<string>> id, Expression<Func<DeleteEncounterIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteEncounterIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteEncounterIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutEncounterIdResponse, ApiConnectionActionConfiguration> PutEncounterId(Expression<Func<string>> id, Expression<Func<DeleteEncounterIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutEncounterIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutEncounterIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetEncounterIdVersionResponse, ApiConnectionActionConfiguration> GetEncounterIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetEncounterIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEncounterIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetEncounterIdHistoryResponse, ApiConnectionActionConfiguration> GetEncounterIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetEncounterIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEncounterIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetEncounterHistoryResponse, ApiConnectionActionConfiguration> GetEncounterHistory()
        {
            return new DeferredBodyAction<GetEncounterHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Encounter/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetEncounterHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetFlagResponse, ApiConnectionActionConfiguration> GetFlag(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetFlagResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Flag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetFlagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostFlagResponse, ApiConnectionActionConfiguration> PostFlag(Expression<Func<DeleteFlagIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostFlagResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Flag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostFlagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetFlagIdResponse, ApiConnectionActionConfiguration> GetFlagId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFlagIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFlagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeleteFlagIdResponse, ApiConnectionActionConfiguration> DeleteFlagId(Expression<Func<string>> id, Expression<Func<DeleteFlagIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteFlagIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteFlagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutFlagIdResponse, ApiConnectionActionConfiguration> PutFlagId(Expression<Func<string>> id, Expression<Func<DeleteFlagIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutFlagIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutFlagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetFlagIdVersionResponse, ApiConnectionActionConfiguration> GetFlagIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetFlagIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFlagIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetFlagIdHistoryResponse, ApiConnectionActionConfiguration> GetFlagIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetFlagIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFlagIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetFlagHistoryResponse, ApiConnectionActionConfiguration> GetFlagHistory()
        {
            return new DeferredBodyAction<GetFlagHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Flag/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetFlagHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetLocationResponse, ApiConnectionActionConfiguration> GetLocation(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostLocationResponse, ApiConnectionActionConfiguration> PostLocation(Expression<Func<DeleteLocationIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetLocationIdResponse, ApiConnectionActionConfiguration> GetLocationId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetLocationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLocationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeleteLocationIdResponse, ApiConnectionActionConfiguration> DeleteLocationId(Expression<Func<string>> id, Expression<Func<DeleteLocationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteLocationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteLocationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutLocationIdResponse, ApiConnectionActionConfiguration> PutLocationId(Expression<Func<string>> id, Expression<Func<DeleteLocationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutLocationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutLocationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetLocationIdVersionResponse, ApiConnectionActionConfiguration> GetLocationIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetLocationIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLocationIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetLocationIdHistoryResponse, ApiConnectionActionConfiguration> GetLocationIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetLocationIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLocationIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetLocationHistoryResponse, ApiConnectionActionConfiguration> GetLocationHistory()
        {
            return new DeferredBodyAction<GetLocationHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Location/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetLocationHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPatientResponse, ApiConnectionActionConfiguration> GetPatient(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetPatientResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Patient";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetPatientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostPatientResponse, ApiConnectionActionConfiguration> PostPatient(Expression<Func<PostPatientBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostPatientResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Patient";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostPatientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPatientIdResponse, ApiConnectionActionConfiguration> GetPatientId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetPatientIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPatientIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeletePatientIdResponse, ApiConnectionActionConfiguration> DeletePatientId(Expression<Func<string>> id, Expression<Func<DeletePatientIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeletePatientIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeletePatientIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutPatientIdResponse, ApiConnectionActionConfiguration> PutPatientId(Expression<Func<string>> id, Expression<Func<DeletePatientIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutPatientIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutPatientIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPatientIdVersionResponse, ApiConnectionActionConfiguration> GetPatientIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetPatientIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPatientIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPatientIdHistoryResponse, ApiConnectionActionConfiguration> GetPatientIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetPatientIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPatientIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPatientHistoryResponse, ApiConnectionActionConfiguration> GetPatientHistory()
        {
            return new DeferredBodyAction<GetPatientHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Patient/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPatientHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPersonResponse, ApiConnectionActionConfiguration> GetPerson(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetPersonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Person";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetPersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostPersonResponse, ApiConnectionActionConfiguration> PostPerson(Expression<Func<DeletePersonIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostPersonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Person";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostPersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPersonIdResponse, ApiConnectionActionConfiguration> GetPersonId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetPersonIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPersonIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeletePersonIdResponse, ApiConnectionActionConfiguration> DeletePersonId(Expression<Func<string>> id, Expression<Func<DeletePersonIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeletePersonIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeletePersonIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutPersonIdResponse, ApiConnectionActionConfiguration> PutPersonId(Expression<Func<string>> id, Expression<Func<DeletePersonIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutPersonIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutPersonIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPersonIdVersionResponse, ApiConnectionActionConfiguration> GetPersonIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetPersonIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPersonIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPersonIdHistoryResponse, ApiConnectionActionConfiguration> GetPersonIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetPersonIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPersonIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPersonHistoryResponse, ApiConnectionActionConfiguration> GetPersonHistory()
        {
            return new DeferredBodyAction<GetPersonHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Person/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPersonHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPractitionerResponse, ApiConnectionActionConfiguration> GetPractitioner(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetPractitionerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Practitioner";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetPractitionerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PostPractitionerResponse, ApiConnectionActionConfiguration> PostPractitioner(Expression<Func<PostPractitionerBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostPractitionerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Practitioner";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostPractitionerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPractitionerIdResponse, ApiConnectionActionConfiguration> GetPractitionerId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetPractitionerIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPractitionerIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DeletePractitionerIdResponse, ApiConnectionActionConfiguration> DeletePractitionerId(Expression<Func<string>> id, Expression<Func<DeletePractitionerIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeletePractitionerIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeletePractitionerIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PutPractitionerIdResponse, ApiConnectionActionConfiguration> PutPractitionerId(Expression<Func<string>> id, Expression<Func<DeletePractitionerIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutPractitionerIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutPractitionerIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPractitionerIdVersionResponse, ApiConnectionActionConfiguration> GetPractitionerIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GetPractitionerIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPractitionerIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPractitionerIdHistoryResponse, ApiConnectionActionConfiguration> GetPractitionerIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetPractitionerIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPractitionerIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GetPractitionerHistoryResponse, ApiConnectionActionConfiguration> GetPractitionerHistory()
        {
            return new DeferredBodyAction<GetPractitionerHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Practitioner/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetPractitionerHistoryResponse>(callPayload);
            });
        }
    }

    public class FhirbaseTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAppointmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetAppointmentResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetAppointmentResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetAppointmentResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetAppointmentResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetAppointmentResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("serviceCategory")]
        public GetAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItem[] ServiceCategory { get; set; }

        [JsonProperty("serviceType")]
        public GetAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItem[] ServiceType { get; set; }

        [JsonProperty("specialty")]
        public GetAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItem[] Specialty { get; set; }

        [JsonProperty("appointmentType")]
        public GetAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeType AppointmentType { get; set; }

        [JsonProperty("reasonReference")]
        public GetAppointmentResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("basedOn")]
        public GetAppointmentResponseEntryTypeItemResourceTypeBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("participant")]
        public GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItemCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeType
    {
        [JsonProperty("coding")]
        public GetAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAppointmentResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostAppointmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostAppointmentResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostAppointmentResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public PostAppointmentResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class PostAppointmentResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostAppointmentResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PostAppointmentResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public PostAppointmentResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public PostAppointmentResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class PostAppointmentResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAppointmentResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public PostAppointmentResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostAppointmentResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostAppointmentBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("serviceCategory")]
        public BodyInputServiceCategoryTypeItem[] ServiceCategory { get; set; }

        [JsonProperty("serviceType")]
        public BodyInputServiceTypeTypeItem[] ServiceType { get; set; }

        [JsonProperty("specialty")]
        public BodyInputSpecialtyTypeItem[] Specialty { get; set; }

        [JsonProperty("appointmentType")]
        public BodyInputAppointmentTypeType AppointmentType { get; set; }

        [JsonProperty("reasonReference")]
        public BodyInputReasonReferenceTypeItem[] ReasonReference { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("basedOn")]
        public BodyInputBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("participant")]
        public DeleteAppointmentIdBodyInputParticipantTypeItem[] Participant { get; set; }
    }

    public class BodyInputTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class BodyInputServiceCategoryTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputServiceCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputServiceCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputServiceTypeTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputServiceTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputServiceTypeTypeItemCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputSpecialtyTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputSpecialtyTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputSpecialtyTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputAppointmentTypeType
    {
        [JsonProperty("coding")]
        public BodyInputAppointmentTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputAppointmentTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteAppointmentIdBodyInputParticipantTypeItem
    {
        [JsonProperty("actor")]
        public BodyInputParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public BodyInputParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class BodyInputParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GetAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GetAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GetAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GetAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GetAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public DeleteAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class DeleteAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DeleteAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public DeleteAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public DeleteAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class DeleteAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public DeleteAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteAppointmentIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public DeleteAppointmentIdBodyInputParticipantTypeItem[] Participant { get; set; }
    }

    public class BodyInputMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public PutAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class PutAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PutAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public PutAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public PutAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class PutAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public PutAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PutAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAppointmentIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentIdVersionResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GetAppointmentIdVersionResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GetAppointmentIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentIdVersionResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GetAppointmentIdVersionResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GetAppointmentIdVersionResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GetAppointmentIdVersionResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentIdVersionResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentIdVersionResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentIdVersionResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAppointmentIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GetAppointmentIdHistoryResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GetAppointmentIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentIdHistoryResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GetAppointmentIdHistoryResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GetAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GetAppointmentIdHistoryResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAppointmentHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GetAppointmentHistoryResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GetAppointmentHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentHistoryResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GetAppointmentHistoryResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GetAppointmentHistoryResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GetAppointmentHistoryResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentHistoryResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetAppointmentHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAppointmentHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAppointmentResponseResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentResponseResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetAppointmentResponseResponseLinkTypeItem[] Link { get; set; }
    }

    public class GetAppointmentResponseResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentResponseResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PostAppointmentResponseResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostAppointmentResponseResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostAppointmentResponseResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public PostAppointmentResponseResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public PostAppointmentResponseResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class PostAppointmentResponseResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostAppointmentResponseResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PostAppointmentResponseResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAppointmentResponseResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAppointmentResponseBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("appointment")]
        public BodyInputAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public BodyInputActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class BodyInputAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GetAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GetAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GetAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public DeleteAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public DeleteAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class DeleteAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DeleteAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAppointmentResponseIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("appointment")]
        public BodyInputAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public BodyInputActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class PutAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public PutAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public PutAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class PutAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PutAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentResponseIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentResponseIdVersionResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GetAppointmentResponseIdVersionResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GetAppointmentResponseIdVersionResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GetAppointmentResponseIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentResponseIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentResponseIdVersionResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseIdVersionResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentResponseIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentResponseIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GetAppointmentResponseIdHistoryResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GetAppointmentResponseIdHistoryResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GetAppointmentResponseIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentResponseIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentResponseIdHistoryResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseIdHistoryResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAppointmentResponseHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetAppointmentResponseHistoryResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GetAppointmentResponseHistoryResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GetAppointmentResponseHistoryResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GetAppointmentResponseHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAppointmentResponseHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetAppointmentResponseHistoryResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAppointmentResponseHistoryResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDeviceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDeviceResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetDeviceResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetDeviceResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetDeviceResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDeviceResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetDeviceResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetDeviceResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetDeviceResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDeviceResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public GetDeviceResponseEntryTypeItemResourceTypeUdiCarrierTypeItem[] UdiCarrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distinctIdentifier")]
        public string DistinctIdentifier { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("deviceName")]
        public GetDeviceResponseEntryTypeItemResourceTypeDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public GetDeviceResponseEntryTypeItemResourceTypeTypeType Type { get; set; }

        [JsonProperty("patient")]
        public GetDeviceResponseEntryTypeItemResourceTypePatientType Patient { get; set; }

        [JsonProperty("text")]
        public GetDeviceResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetDeviceResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypeUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHrf { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypeDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypeTypeType
    {
        [JsonProperty("coding")]
        public GetDeviceResponseEntryTypeItemResourceTypeTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypeTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetDeviceResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostDeviceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostDeviceResponseMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public PostDeviceResponseUdiCarrierTypeItem[] UdiCarrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distinctIdentifier")]
        public string DistinctIdentifier { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("deviceName")]
        public PostDeviceResponseDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public PostDeviceResponseTypeType Type { get; set; }

        [JsonProperty("patient")]
        public PostDeviceResponsePatientType Patient { get; set; }
    }

    public class PostDeviceResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostDeviceResponseUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHrf { get; set; }
    }

    public class PostDeviceResponseDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class PostDeviceResponseTypeType
    {
        [JsonProperty("coding")]
        public PostDeviceResponseTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostDeviceResponseTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostDeviceResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostDeviceBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public BodyInputUdiCarrierTypeItem[] UdiCarrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distinctIdentifier")]
        public string DistinctIdentifier { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("deviceName")]
        public BodyInputDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public BodyInputTypeType Type { get; set; }

        [JsonProperty("patient")]
        public BodyInputPatientType Patient { get; set; }
    }

    public class BodyInputUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHrf { get; set; }
    }

    public class BodyInputDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class BodyInputTypeType
    {
        [JsonProperty("coding")]
        public BodyInputTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputPatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public GetDeviceIdResponseUdiCarrierTypeItem[] UdiCarrier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("distinctIdentifier")]
        public string DistinctIdentifier { get; set; }

        [JsonProperty("manufactureDate")]
        public string ManufactureDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [JsonProperty("deviceName")]
        public GetDeviceIdResponseDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public GetDeviceIdResponseTypeType Type { get; set; }

        [JsonProperty("patient")]
        public GetDeviceIdResponsePatientType Patient { get; set; }
    }

    public class GetDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDeviceIdResponseUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHrf { get; set; }
    }

    public class GetDeviceIdResponseDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetDeviceIdResponseTypeType
    {
        [JsonProperty("coding")]
        public GetDeviceIdResponseTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetDeviceIdResponseTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDeviceIdResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteDeviceIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DeleteDeviceIdResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class DeleteDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteDeviceIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DeleteDeviceIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeleteDeviceIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DeleteDeviceIdBodyInputIdentifierTypeItem[] Identifier { get; set; }
    }

    public class DeleteDeviceIdBodyInputIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PutDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutDeviceIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PutDeviceIdResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class PutDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutDeviceIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PutDeviceIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetDeviceIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDeviceIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetDeviceIdVersionResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetDeviceIdVersionResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GetDeviceIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDeviceIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetDeviceIdVersionResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetDeviceIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDeviceIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetDeviceIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetDeviceIdHistoryResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GetDeviceIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDeviceIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetDeviceIdHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetDeviceHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDeviceHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetDeviceHistoryResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetDeviceHistoryResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GetDeviceHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDeviceHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetDeviceHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetEncounterResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetEncounterResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetEncounterResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetEncounterResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetEncounterResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetEncounterResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetEncounterResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetEncounterResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetEncounterResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetEncounterResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GetEncounterResponseEntryTypeItemResourceTypeClassType Class { get; set; }

        [JsonProperty("type")]
        public GetEncounterResponseEntryTypeItemResourceTypeTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GetEncounterResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GetEncounterResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GetEncounterResponseEntryTypeItemResourceTypePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GetEncounterResponseEntryTypeItemResourceTypeServiceProviderType ServiceProvider { get; set; }

        [JsonProperty("reasonCode")]
        public GetEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetEncounterResponseEntryTypeItemResourceTypeTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GetEncounterResponseEntryTypeItemResourceTypeParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GetEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostEncounterResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostEncounterResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public PostEncounterResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public PostEncounterResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public PostEncounterResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PostEncounterResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public PostEncounterResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public PostEncounterResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class PostEncounterResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostEncounterResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostEncounterResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public PostEncounterResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostEncounterResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostEncounterResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostEncounterResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public PostEncounterResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class PostEncounterResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostEncounterResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PostEncounterResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteEncounterIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public BodyInputClassType Class { get; set; }

        [JsonProperty("type")]
        public BodyInputTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public BodyInputSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DeleteEncounterIdBodyInputParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public BodyInputPeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public BodyInputServiceProviderType ServiceProvider { get; set; }
    }

    public class BodyInputClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputTypeTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteEncounterIdBodyInputParticipantTypeItem
    {
        [JsonProperty("individual")]
        public BodyInputParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class BodyInputParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class BodyInputServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GetEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GetEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GetEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GetEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GetEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GetEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GetEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GetEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GetEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public DeleteEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public DeleteEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public DeleteEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DeleteEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public DeleteEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public DeleteEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class DeleteEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public DeleteEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public DeleteEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class DeleteEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DeleteEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public PutEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public PutEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public PutEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PutEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public PutEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public PutEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class PutEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public PutEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public PutEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class PutEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PutEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetEncounterIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GetEncounterIdVersionResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GetEncounterIdVersionResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GetEncounterIdVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GetEncounterIdVersionResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GetEncounterIdVersionResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GetEncounterIdVersionResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GetEncounterIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetEncounterIdVersionResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetEncounterIdVersionResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetEncounterIdVersionResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetEncounterIdVersionResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdVersionResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GetEncounterIdVersionResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GetEncounterIdVersionResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetEncounterIdVersionResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetEncounterIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GetEncounterIdHistoryResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GetEncounterIdHistoryResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GetEncounterIdHistoryResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GetEncounterIdHistoryResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GetEncounterIdHistoryResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GetEncounterIdHistoryResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GetEncounterIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetEncounterIdHistoryResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetEncounterIdHistoryResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetEncounterIdHistoryResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetEncounterIdHistoryResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdHistoryResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdHistoryResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GetEncounterIdHistoryResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GetEncounterIdHistoryResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterIdHistoryResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetEncounterIdHistoryResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetEncounterHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GetEncounterHistoryResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GetEncounterHistoryResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GetEncounterHistoryResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GetEncounterHistoryResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GetEncounterHistoryResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GetEncounterHistoryResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GetEncounterHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetEncounterHistoryResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetEncounterHistoryResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GetEncounterHistoryResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetEncounterHistoryResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterHistoryResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterHistoryResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GetEncounterHistoryResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GetEncounterHistoryResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetEncounterHistoryResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetEncounterHistoryResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetFlagResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetFlagResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetFlagResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetFlagResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetFlagResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GetFlagResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GetFlagResponseAuthorType Author { get; set; }
    }

    public class GetFlagResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetFlagResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFlagResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetFlagResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagResponseCodeType
    {
        [JsonProperty("coding")]
        public GetFlagResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetFlagResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostFlagResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PostFlagResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PostFlagResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PostFlagResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PostFlagResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PostFlagResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PostFlagResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public PostFlagResponseAuthorType Author { get; set; }
    }

    public class PostFlagResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PostFlagResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PostFlagResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PostFlagResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostFlagResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostFlagResponseCodeType
    {
        [JsonProperty("coding")]
        public PostFlagResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostFlagResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostFlagResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostFlagResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PostFlagResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteFlagIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DeleteFlagIdBodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public BodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public BodyInputCodeType Code { get; set; }

        [JsonProperty("subject")]
        public BodyInputSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public BodyInputPeriodType Period { get; set; }

        [JsonProperty("author")]
        public BodyInputAuthorType Author { get; set; }
    }

    public class DeleteFlagIdBodyInputIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputCategoryTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputCodeType
    {
        [JsonProperty("coding")]
        public BodyInputCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GetFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GetFlagIdResponseAuthorType Author { get; set; }
    }

    public class GetFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GetFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DeleteFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DeleteFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DeleteFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DeleteFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public DeleteFlagIdResponseAuthorType Author { get; set; }
    }

    public class DeleteFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DeleteFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeleteFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DeleteFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DeleteFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DeleteFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PutFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PutFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PutFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PutFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PutFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PutFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public PutFlagIdResponseAuthorType Author { get; set; }
    }

    public class PutFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PutFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PutFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PutFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PutFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PutFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetFlagIdVersionResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetFlagIdVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetFlagIdVersionResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetFlagIdVersionResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetFlagIdVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GetFlagIdVersionResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GetFlagIdVersionResponseAuthorType Author { get; set; }
    }

    public class GetFlagIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetFlagIdVersionResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFlagIdVersionResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetFlagIdVersionResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagIdVersionResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdVersionResponseCodeType
    {
        [JsonProperty("coding")]
        public GetFlagIdVersionResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagIdVersionResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetFlagIdVersionResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetFlagIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetFlagIdHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetFlagIdHistoryResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetFlagIdHistoryResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetFlagIdHistoryResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GetFlagIdHistoryResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GetFlagIdHistoryResponseAuthorType Author { get; set; }
    }

    public class GetFlagIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetFlagIdHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFlagIdHistoryResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetFlagIdHistoryResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagIdHistoryResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdHistoryResponseCodeType
    {
        [JsonProperty("coding")]
        public GetFlagIdHistoryResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagIdHistoryResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdHistoryResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagIdHistoryResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetFlagIdHistoryResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetFlagHistoryResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetFlagHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetFlagHistoryResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetFlagHistoryResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetFlagHistoryResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GetFlagHistoryResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GetFlagHistoryResponseAuthorType Author { get; set; }
    }

    public class GetFlagHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetFlagHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFlagHistoryResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetFlagHistoryResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagHistoryResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagHistoryResponseCodeType
    {
        [JsonProperty("coding")]
        public GetFlagHistoryResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetFlagHistoryResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagHistoryResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetFlagHistoryResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetFlagHistoryResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetLocationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetLocationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GetLocationResponsePartOfType PartOf { get; set; }
    }

    public class GetLocationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetLocationResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostLocationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PostLocationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public PostLocationResponsePartOfType PartOf { get; set; }
    }

    public class PostLocationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PostLocationResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteLocationIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public BodyInputPartOfType PartOf { get; set; }
    }

    public class BodyInputPartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetLocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetLocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GetLocationIdResponsePartOfType PartOf { get; set; }
    }

    public class GetLocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetLocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteLocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteLocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public DeleteLocationIdResponsePartOfType PartOf { get; set; }
    }

    public class DeleteLocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DeleteLocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutLocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PutLocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public PutLocationIdResponsePartOfType PartOf { get; set; }
    }

    public class PutLocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PutLocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetLocationIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetLocationIdVersionResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GetLocationIdVersionResponsePartOfType PartOf { get; set; }
    }

    public class GetLocationIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetLocationIdVersionResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetLocationIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetLocationIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GetLocationIdHistoryResponsePartOfType PartOf { get; set; }
    }

    public class GetLocationIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetLocationIdHistoryResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetLocationHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GetLocationHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GetLocationHistoryResponsePartOfType PartOf { get; set; }
    }

    public class GetLocationHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetLocationHistoryResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPatientResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetPatientResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetPatientResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetPatientResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPatientResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetPatientResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetPatientResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetPatientResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GetPatientResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GetPatientResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GetPatientResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPatientResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPatientResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GetPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPatientResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPatientResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostPatientResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PostPatientResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PostPatientResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public PostPatientResponseAddressTypeItem[] Address { get; set; }
    }

    public class PostPatientResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PostPatientResponseTelecomTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class PostPatientResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public PostPatientResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class PostPatientResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class PostPatientBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DeletePatientIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DeletePatientIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool? DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DeletePatientIdBodyInputAddressTypeItem[] Address { get; set; }
    }

    public class DeletePatientIdBodyInputNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DeletePatientIdBodyInputTelecomTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }
    }

    public class DeletePatientIdBodyInputAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public BodyInputAddressTypeItemPeriodType Period { get; set; }
    }

    public class BodyInputAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GetPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetPatientIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetPatientIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetPatientIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetPatientIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetPatientIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetPatientIdResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GetPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GetPatientIdResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GetPatientIdResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPatientIdResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPatientIdResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GetPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPatientIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DeletePatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DeletePatientIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DeletePatientIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DeletePatientIdResponseAddressTypeItem[] Address { get; set; }
    }

    public class DeletePatientIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DeletePatientIdResponseTelecomTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class DeletePatientIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public DeletePatientIdResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class DeletePatientIdResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DeletePatientIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DeletePatientIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DeletePatientIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool? DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DeletePatientIdBodyInputAddressTypeItem[] Address { get; set; }
    }

    public class PutPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PutPatientIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PutPatientIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public PutPatientIdResponseAddressTypeItem[] Address { get; set; }
    }

    public class PutPatientIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PutPatientIdResponseTelecomTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }
    }

    public class PutPatientIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("period")]
        public PutPatientIdResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class PutPatientIdResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GetPatientIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetPatientIdVersionResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetPatientIdVersionResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetPatientIdVersionResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientIdVersionResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetPatientIdVersionResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetPatientIdVersionResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPatientIdVersionResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GetPatientIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetPatientIdHistoryResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetPatientIdHistoryResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetPatientIdHistoryResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientIdHistoryResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetPatientIdHistoryResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPatientIdHistoryResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GetPatientHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetPatientHistoryResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetPatientHistoryResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetPatientHistoryResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientHistoryResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetPatientHistoryResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetPatientHistoryResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPatientHistoryResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GetPersonResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GetPersonResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPersonResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPersonResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GetPersonResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GetPersonResponseLinkTypeItem[] Link { get; set; }
    }

    public class GetPersonResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPersonResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPersonResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetPersonResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GetPersonResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GetPersonResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostPersonResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public PostPersonResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PostPersonResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public PostPersonResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public PostPersonResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public PostPersonResponseLinkTypeItem[] Link { get; set; }
    }

    public class PostPersonResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PostPersonResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PostPersonResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class PostPersonResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostPersonResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public PostPersonResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class PostPersonResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeletePersonIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public DeletePatientIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DeletePersonIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public DeletePersonIdBodyInputAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public BodyInputManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("link")]
        public BodyInputLinkTypeItem[] Link { get; set; }
    }

    public class DeletePersonIdBodyInputTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class DeletePersonIdBodyInputAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class BodyInputManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputLinkTypeItem
    {
        [JsonProperty("target")]
        public BodyInputLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class BodyInputLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GetPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GetPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GetPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class GetPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPersonIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GetPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GetPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeletePersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public DeletePersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DeletePersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public DeletePersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public DeletePersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public DeletePersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class DeletePersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DeletePersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class DeletePersonIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class DeletePersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeletePersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public DeletePersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class DeletePersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public PutPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PutPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public PutPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public PutPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public PutPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class PutPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PutPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PutPersonIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class PutPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public PutPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class PutPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GetPersonIdVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPersonIdVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPersonIdVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GetPersonIdVersionResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GetPersonIdVersionResponseLinkTypeItem[] Link { get; set; }
    }

    public class GetPersonIdVersionResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPersonIdVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPersonIdVersionResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetPersonIdVersionResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonIdVersionResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GetPersonIdVersionResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GetPersonIdVersionResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GetPersonIdHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPersonIdHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPersonIdHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GetPersonIdHistoryResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GetPersonIdHistoryResponseLinkTypeItem[] Link { get; set; }
    }

    public class GetPersonIdHistoryResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPersonIdHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPersonIdHistoryResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetPersonIdHistoryResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonIdHistoryResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GetPersonIdHistoryResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GetPersonIdHistoryResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GetPersonHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPersonHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GetPersonHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GetPersonHistoryResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GetPersonHistoryResponseLinkTypeItem[] Link { get; set; }
    }

    public class GetPersonHistoryResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GetPersonHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPersonHistoryResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }

    public class GetPersonHistoryResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPersonHistoryResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GetPersonHistoryResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GetPersonHistoryResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPractitionerResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPractitionerResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetPractitionerResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetPractitionerResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetPractitionerResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPractitionerResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetPractitionerResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetPractitionerResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPractitionerResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GetPractitionerResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GetPractitionerResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPractitionerResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GetPractitionerResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItemResourceTypeAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPractitionerResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostPractitionerResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostPractitionerResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PostPractitionerResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PostPractitionerResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PostPractitionerResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public PostPractitionerResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class PostPractitionerResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostPractitionerResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PostPractitionerResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class PostPractitionerResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PostPractitionerResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class PostPractitionerBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("identifier")]
        public DeleteDeviceIdBodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DeletePractitionerIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("address")]
        public PostPractitionerBodyInputAddressTypeItem[] Address { get; set; }

        [JsonProperty("qualification")]
        public BodyInputQualificationTypeItem[] Qualification { get; set; }
    }

    public class DeletePractitionerIdBodyInputNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class PostPractitionerBodyInputAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class BodyInputQualificationTypeItem
    {
        [JsonProperty("identifier")]
        public BodyInputQualificationTypeItemIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("code")]
        public BodyInputQualificationTypeItemCodeType Code { get; set; }

        [JsonProperty("period")]
        public BodyInputQualificationTypeItemPeriodType Period { get; set; }

        [JsonProperty("issuer")]
        public BodyInputQualificationTypeItemIssuerType Issuer { get; set; }
    }

    public class BodyInputQualificationTypeItemIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputQualificationTypeItemCodeType
    {
        [JsonProperty("coding")]
        public BodyInputQualificationTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputQualificationTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputQualificationTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class BodyInputQualificationTypeItemIssuerType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPractitionerIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GetPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GetPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPractitionerIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GetPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GetPractitionerIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GetPractitionerIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPractitionerIdResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class DeletePractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeletePractitionerIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DeletePractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DeletePractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("address")]
        public DeletePractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("qualification")]
        public DeletePractitionerIdResponseQualificationTypeItem[] Qualification { get; set; }
    }

    public class DeletePractitionerIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DeletePractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeletePractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class DeletePractitionerIdResponseAddressTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }

    public class DeletePractitionerIdResponseQualificationTypeItem
    {
        [JsonProperty("identifier")]
        public DeletePractitionerIdResponseQualificationTypeItemIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("code")]
        public DeletePractitionerIdResponseQualificationTypeItemCodeType Code { get; set; }

        [JsonProperty("period")]
        public DeletePractitionerIdResponseQualificationTypeItemPeriodType Period { get; set; }

        [JsonProperty("issuer")]
        public DeletePractitionerIdResponseQualificationTypeItemIssuerType Issuer { get; set; }
    }

    public class DeletePractitionerIdResponseQualificationTypeItemIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeletePractitionerIdResponseQualificationTypeItemCodeType
    {
        [JsonProperty("coding")]
        public DeletePractitionerIdResponseQualificationTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeletePractitionerIdResponseQualificationTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeletePractitionerIdResponseQualificationTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DeletePractitionerIdResponseQualificationTypeItemIssuerType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeletePractitionerIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public DeleteDeviceIdBodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DeletePractitionerIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DeletePersonIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public DeletePractitionerIdBodyInputAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class DeletePractitionerIdBodyInputAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class PutPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutPractitionerIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PutPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PutPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PutPractitionerIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public PutPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class PutPractitionerIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PutPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class PutPractitionerIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PutPractitionerIdResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPractitionerIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPractitionerIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GetPractitionerIdVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GetPractitionerIdVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPractitionerIdVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GetPractitionerIdVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GetPractitionerIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPractitionerIdVersionResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPractitionerIdVersionResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GetPractitionerIdVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPractitionerIdVersionResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPractitionerIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPractitionerIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GetPractitionerIdHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GetPractitionerIdHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPractitionerIdHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GetPractitionerIdHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GetPractitionerIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPractitionerIdHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPractitionerIdHistoryResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GetPractitionerIdHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPractitionerIdHistoryResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class GetPractitionerHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetPractitionerHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GetPractitionerHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GetPractitionerHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GetPractitionerHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GetPractitionerHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GetPractitionerHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetPractitionerHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetPractitionerHistoryResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GetPractitionerHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GetPractitionerHistoryResponseAddressTypeItem
    {
        [JsonProperty("line")]
        public string[] Line { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fhirbase;

    public partial class WorkflowManagedActions
    {
        public FhirbaseActions Fhirbase(string connectionId) => new FhirbaseActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FhirbaseTriggers Fhirbase(string connectionId) => new FhirbaseTriggers(connectionId);
    }
}