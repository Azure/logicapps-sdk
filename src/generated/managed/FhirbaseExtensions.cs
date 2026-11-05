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
        public IBodyWorkflowAction<GETAppointmentResponse, ApiConnectionActionConfiguration> GETAppointment(Expression<Func<string>> patient = null, Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null)
        {
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            return new DeferredBodyAction<GETAppointmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Appointment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                return new ApiConnectionAction<GETAppointmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTAppointmentResponse, ApiConnectionActionConfiguration> POSTAppointment(Expression<Func<POSTAppointmentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTAppointmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Appointment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTAppointmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIdResponse, ApiConnectionActionConfiguration> GETAppointmentId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETAppointmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETAppointmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEAppointmentIdResponse, ApiConnectionActionConfiguration> DELETEAppointmentId(Expression<Func<string>> id, Expression<Func<DELETEAppointmentIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEAppointmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEAppointmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTAppointmentIdResponse, ApiConnectionActionConfiguration> PUTAppointmentId(Expression<Func<string>> id, Expression<Func<DELETEAppointmentIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTAppointmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTAppointmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIdVERSIONResponse, ApiConnectionActionConfiguration> GETAppointmentIdVERSION(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETAppointmentIdVERSIONResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETAppointmentIdVERSIONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentIdHistoryResponse, ApiConnectionActionConfiguration> GETAppointmentIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETAppointmentIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Appointment/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETAppointmentIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentHistoryResponse, ApiConnectionActionConfiguration> GETAppointmentHistory(Expression<Func<string>> patient = null)
        {
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETAppointmentHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Appointment/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETAppointmentHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseResponse, ApiConnectionActionConfiguration> GETAppointmentResponse(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETAppointmentResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AppointmentResponse";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETAppointmentResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTAppointmentResponseResponse, ApiConnectionActionConfiguration> POSTAppointmentResponse(Expression<Func<POSTAppointmentResponseBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTAppointmentResponseResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AppointmentResponse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTAppointmentResponseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIdResponse, ApiConnectionActionConfiguration> GETAppointmentResponseId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETAppointmentResponseIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETAppointmentResponseIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEAppointmentResponseIdResponse, ApiConnectionActionConfiguration> DELETEAppointmentResponseId(Expression<Func<string>> id, Expression<Func<DELETEAppointmentResponseIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEAppointmentResponseIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEAppointmentResponseIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTAppointmentResponseIdResponse, ApiConnectionActionConfiguration> PUTAppointmentResponseId(Expression<Func<string>> id, Expression<Func<DELETEAppointmentResponseIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTAppointmentResponseIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTAppointmentResponseIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIdVersionResponse, ApiConnectionActionConfiguration> GETAppointmentResponseIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETAppointmentResponseIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETAppointmentResponseIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseIdHistoryResponse, ApiConnectionActionConfiguration> GETAppointmentResponseIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETAppointmentResponseIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AppointmentResponse/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETAppointmentResponseIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETAppointmentResponseHistoryResponse, ApiConnectionActionConfiguration> GETAppointmentResponseHistory()
        {
            return new DeferredBodyAction<GETAppointmentResponseHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AppointmentResponse/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETAppointmentResponseHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceResponse, ApiConnectionActionConfiguration> GETDevice(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETDeviceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Device";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTDeviceResponse, ApiConnectionActionConfiguration> POSTDevice(Expression<Func<POSTDeviceBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTDeviceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Device";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTDeviceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIdResponse, ApiConnectionActionConfiguration> GETDeviceId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETDeviceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETDeviceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEDeviceIdResponse, ApiConnectionActionConfiguration> DELETEDeviceId(Expression<Func<string>> id, Expression<Func<DELETEDeviceIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEDeviceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEDeviceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTDeviceIdResponse, ApiConnectionActionConfiguration> PUTDeviceId(Expression<Func<string>> id, Expression<Func<DELETEDeviceIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTDeviceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTDeviceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIdVERSIONResponse, ApiConnectionActionConfiguration> GETDeviceIdVERSION(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETDeviceIdVERSIONResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETDeviceIdVERSIONResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceIdHISTORYResponse, ApiConnectionActionConfiguration> GETDeviceIdHISTORY(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETDeviceIdHISTORYResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Device/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETDeviceIdHISTORYResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETDeviceHISTORYResponse, ApiConnectionActionConfiguration> GETDeviceHISTORY()
        {
            return new DeferredBodyAction<GETDeviceHISTORYResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Device/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETDeviceHISTORYResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterResponse, ApiConnectionActionConfiguration> GETEncounter(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETEncounterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Encounter";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETEncounterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTEncounterResponse, ApiConnectionActionConfiguration> POSTEncounter(Expression<Func<DELETEEncounterIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTEncounterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Encounter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTEncounterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIdResponse, ApiConnectionActionConfiguration> GETEncounterId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETEncounterIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETEncounterIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEEncounterIdResponse, ApiConnectionActionConfiguration> DELETEEncounterId(Expression<Func<string>> id, Expression<Func<DELETEEncounterIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEEncounterIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEEncounterIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTEncounterIdResponse, ApiConnectionActionConfiguration> PUTEncounterId(Expression<Func<string>> id, Expression<Func<DELETEEncounterIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTEncounterIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTEncounterIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIdVersionResponse, ApiConnectionActionConfiguration> GETEncounterIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETEncounterIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETEncounterIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterIdHISTORYResponse, ApiConnectionActionConfiguration> GETEncounterIdHISTORY(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETEncounterIdHISTORYResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Encounter/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETEncounterIdHISTORYResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETEncounterHISTORYResponse, ApiConnectionActionConfiguration> GETEncounterHISTORY()
        {
            return new DeferredBodyAction<GETEncounterHISTORYResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Encounter/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETEncounterHISTORYResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagResponse, ApiConnectionActionConfiguration> GETFlag(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETFlagResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Flag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETFlagResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTFLAGResponse, ApiConnectionActionConfiguration> POSTFLAG(Expression<Func<DELETEFlagIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTFLAGResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Flag";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTFLAGResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIdResponse, ApiConnectionActionConfiguration> GETFlagId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETFlagIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETFlagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEFlagIdResponse, ApiConnectionActionConfiguration> DELETEFlagId(Expression<Func<string>> id, Expression<Func<DELETEFlagIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEFlagIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEFlagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTFlagIdResponse, ApiConnectionActionConfiguration> PUTFlagId(Expression<Func<string>> id, Expression<Func<DELETEFlagIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTFlagIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTFlagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIdVersionResponse, ApiConnectionActionConfiguration> GETFlagIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETFlagIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETFlagIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagIdHistoryResponse, ApiConnectionActionConfiguration> GETFlagIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETFlagIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Flag/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETFlagIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETFlagHISTORYResponse, ApiConnectionActionConfiguration> GETFlagHISTORY()
        {
            return new DeferredBodyAction<GETFlagHISTORYResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Flag/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETFlagHISTORYResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationResponse, ApiConnectionActionConfiguration> GETLocation(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTLocationResponse, ApiConnectionActionConfiguration> POSTLocation(Expression<Func<DELETELocationIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIdResponse, ApiConnectionActionConfiguration> GETLocationId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETLocationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETLocationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETELocationIdResponse, ApiConnectionActionConfiguration> DELETELocationId(Expression<Func<string>> id, Expression<Func<DELETELocationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETELocationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETELocationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTLocationIdResponse, ApiConnectionActionConfiguration> PUTLocationId(Expression<Func<string>> id, Expression<Func<DELETELocationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTLocationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTLocationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIdVersionResponse, ApiConnectionActionConfiguration> GETLocationIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETLocationIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETLocationIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationIdHistoryResponse, ApiConnectionActionConfiguration> GETLocationIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETLocationIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Location/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETLocationIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETLocationHistoryResponse, ApiConnectionActionConfiguration> GETLocationHistory()
        {
            return new DeferredBodyAction<GETLocationHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Location/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETLocationHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientResponse, ApiConnectionActionConfiguration> GETPatient(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETPatientResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Patient";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETPatientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPatientResponse, ApiConnectionActionConfiguration> POSTPatient(Expression<Func<POSTPatientBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTPatientResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Patient";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTPatientResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIdResponse, ApiConnectionActionConfiguration> GETPatientId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETPatientIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPatientIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPatientIdResponse, ApiConnectionActionConfiguration> DELETEPatientId(Expression<Func<string>> id, Expression<Func<DELETEPatientIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEPatientIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEPatientIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPatientIdResponse, ApiConnectionActionConfiguration> PUTPatientId(Expression<Func<string>> id, Expression<Func<DELETEPatientIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTPatientIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTPatientIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIdVersionResponse, ApiConnectionActionConfiguration> GETPatientIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETPatientIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPatientIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientIdHistoryResponse, ApiConnectionActionConfiguration> GETPatientIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETPatientIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Patient/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPatientIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPatientHistoryResponse, ApiConnectionActionConfiguration> GETPatientHistory()
        {
            return new DeferredBodyAction<GETPatientHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Patient/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPatientHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonResponse, ApiConnectionActionConfiguration> GETPerson(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETPersonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Person";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETPersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPersonResponse, ApiConnectionActionConfiguration> POSTPerson(Expression<Func<DELETEPersonIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTPersonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Person";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTPersonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIdResponse, ApiConnectionActionConfiguration> GETPersonId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETPersonIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPersonIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPersonIdResponse, ApiConnectionActionConfiguration> DELETEPersonId(Expression<Func<string>> id, Expression<Func<DELETEPersonIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEPersonIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEPersonIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPersonIdResponse, ApiConnectionActionConfiguration> PUTPersonId(Expression<Func<string>> id, Expression<Func<DELETEPersonIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTPersonIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTPersonIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIdVersionResponse, ApiConnectionActionConfiguration> GETPersonIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETPersonIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPersonIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonIdHistoryResponse, ApiConnectionActionConfiguration> GETPersonIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETPersonIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Person/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPersonIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPersonHistoryResponse, ApiConnectionActionConfiguration> GETPersonHistory()
        {
            return new DeferredBodyAction<GETPersonHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Person/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPersonHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerResponse, ApiConnectionActionConfiguration> GETPractitioner(Expression<Func<string>> Count = null, Expression<Func<string>> Sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_Count = WorkflowExpression.Compile(Count, nameof(Count), required: false);
            var __workflow_Sort = WorkflowExpression.Compile(Sort, nameof(Sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GETPractitionerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Practitioner";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_Count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_Count);
                if (__workflow_Sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_Sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GETPractitionerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<POSTPractitionerResponse, ApiConnectionActionConfiguration> POSTPractitioner(Expression<Func<POSTPractitionerBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<POSTPractitionerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Practitioner";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<POSTPractitionerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIdResponse, ApiConnectionActionConfiguration> GETPractitionerId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETPractitionerIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPractitionerIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<DELETEPractitionerIdResponse, ApiConnectionActionConfiguration> DELETEPractitionerId(Expression<Func<string>> id, Expression<Func<DELETEPractitionerIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DELETEPractitionerIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DELETEPractitionerIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<PUTPractitionerIdResponse, ApiConnectionActionConfiguration> PUTPractitionerId(Expression<Func<string>> id, Expression<Func<DELETEPractitionerIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PUTPractitionerIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PUTPractitionerIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIdVersionResponse, ApiConnectionActionConfiguration> GETPractitionerIdVersion(Expression<Func<string>> id, Expression<Func<string>> vid)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_vid = WorkflowExpression.Compile(vid, nameof(vid), required: true);
            return new DeferredBodyAction<GETPractitionerIdVersionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}/_history/{1}", __workflow_id.WithUrlEncoding(1), __workflow_vid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPractitionerIdVersionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerIdHistoryResponse, ApiConnectionActionConfiguration> GETPractitionerIdHistory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GETPractitionerIdHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Practitioner/{0}/_history", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPractitionerIdHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirbase")]
        public IBodyWorkflowAction<GETPractitionerHistoryResponse, ApiConnectionActionConfiguration> GETPractitionerHistory()
        {
            return new DeferredBodyAction<GETPractitionerHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Practitioner/_history";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GETPractitionerHistoryResponse>(callPayload);
            });
        }
    }

    public class FhirbaseTriggers([ConnectionName] string connectionId)
    {
    }

    public class GETAppointmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETAppointmentResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETAppointmentResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETAppointmentResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETAppointmentResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETAppointmentResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("serviceCategory")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItem[] ServiceCategory { get; set; }

        [JsonProperty("serviceType")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItem[] ServiceType { get; set; }

        [JsonProperty("specialty")]
        public GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItem[] Specialty { get; set; }

        [JsonProperty("appointmentType")]
        public GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeType AppointmentType { get; set; }

        [JsonProperty("reasonReference")]
        public GETAppointmentResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }

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
        public GETAppointmentResponseEntryTypeItemResourceTypeBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeServiceTypeTypeItemCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeSpecialtyTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeType
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeAppointmentTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemResourceTypeParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTAppointmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTAppointmentResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTAppointmentResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public POSTAppointmentResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class POSTAppointmentResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTAppointmentResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public POSTAppointmentResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public POSTAppointmentResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public POSTAppointmentResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class POSTAppointmentResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTAppointmentBodyInput
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
        public DELETEAppointmentIdBodyInputParticipantTypeItem[] Participant { get; set; }
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

    public class DELETEAppointmentIdBodyInputParticipantTypeItem
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

    public class GETAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public DELETEAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class DELETEAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public DELETEAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DELETEAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEAppointmentIdBodyInput
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
        public DELETEAppointmentIdBodyInputParticipantTypeItem[] Participant { get; set; }
    }

    public class BodyInputMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAppointmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAppointmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTAppointmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public PUTAppointmentIdResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class PUTAppointmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAppointmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public PUTAppointmentIdResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public PUTAppointmentIdResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public PUTAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PUTAppointmentIdResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentIdVERSIONResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIdVERSIONResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIdVERSIONResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIdVERSIONResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentIdHistoryResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentIdHistoryResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentIdHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("participant")]
        public GETAppointmentHistoryResponseParticipantTypeItem[] Participant { get; set; }
    }

    public class GETAppointmentHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItem
    {
        [JsonProperty("actor")]
        public GETAppointmentHistoryResponseParticipantTypeItemActorType Actor { get; set; }

        [JsonProperty("required")]
        public string Required { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItem[] Type { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETAppointmentHistoryResponseParticipantTypeItemTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETAppointmentResponseResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETAppointmentResponseResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETAppointmentResponseResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class POSTAppointmentResponseResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTAppointmentResponseResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public POSTAppointmentResponseResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public POSTAppointmentResponseResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public POSTAppointmentResponseResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class POSTAppointmentResponseResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTAppointmentResponseResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTAppointmentResponseResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAppointmentResponseResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTAppointmentResponseBodyInput
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

    public class GETAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public DELETEAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public DELETEAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEAppointmentResponseIdBodyInput
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

    public class PUTAppointmentResponseIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTAppointmentResponseIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTAppointmentResponseIdResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public PUTAppointmentResponseIdResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public PUTAppointmentResponseIdResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class PUTAppointmentResponseIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTAppointmentResponseIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTAppointmentResponseIdResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTAppointmentResponseIdResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIdVersionResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIdVersionResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIdVersionResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdVersionResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseIdHistoryResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseIdHistoryResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseIdHistoryResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETAppointmentResponseHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETAppointmentResponseHistoryResponseTextType Text { get; set; }

        [JsonProperty("appointment")]
        public GETAppointmentResponseHistoryResponseAppointmentType Appointment { get; set; }

        [JsonProperty("actor")]
        public GETAppointmentResponseHistoryResponseActorType Actor { get; set; }

        [JsonProperty("participantStatus")]
        public string ParticipantStatus { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseAppointmentType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETAppointmentResponseHistoryResponseActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETDeviceResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETDeviceResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETDeviceResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETDeviceResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETDeviceResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETDeviceResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public GETDeviceResponseEntryTypeItemResourceTypeUdiCarrierTypeItem[] UdiCarrier { get; set; }

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
        public GETDeviceResponseEntryTypeItemResourceTypeDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public GETDeviceResponseEntryTypeItemResourceTypeTypeType Type { get; set; }

        [JsonProperty("patient")]
        public GETDeviceResponseEntryTypeItemResourceTypePatientType Patient { get; set; }

        [JsonProperty("text")]
        public GETDeviceResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeTypeType
    {
        [JsonProperty("coding")]
        public GETDeviceResponseEntryTypeItemResourceTypeTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTDeviceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTDeviceResponseMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public POSTDeviceResponseUdiCarrierTypeItem[] UdiCarrier { get; set; }

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
        public POSTDeviceResponseDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public POSTDeviceResponseTypeType Type { get; set; }

        [JsonProperty("patient")]
        public POSTDeviceResponsePatientType Patient { get; set; }
    }

    public class POSTDeviceResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTDeviceResponseUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class POSTDeviceResponseDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class POSTDeviceResponseTypeType
    {
        [JsonProperty("coding")]
        public POSTDeviceResponseTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTDeviceResponseTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTDeviceResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class POSTDeviceBodyInput
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
        public string CarrierHRF { get; set; }
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

    public class GETDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("udiCarrier")]
        public GETDeviceIdResponseUdiCarrierTypeItem[] UdiCarrier { get; set; }

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
        public GETDeviceIdResponseDeviceNameTypeItem[] DeviceName { get; set; }

        [JsonProperty("type")]
        public GETDeviceIdResponseTypeType Type { get; set; }

        [JsonProperty("patient")]
        public GETDeviceIdResponsePatientType Patient { get; set; }
    }

    public class GETDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIdResponseUdiCarrierTypeItem
    {
        [JsonProperty("deviceIdentifier")]
        public string DeviceIdentifier { get; set; }

        [JsonProperty("carrierHRF")]
        public string CarrierHRF { get; set; }
    }

    public class GETDeviceIdResponseDeviceNameTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GETDeviceIdResponseTypeType
    {
        [JsonProperty("coding")]
        public GETDeviceIdResponseTypeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETDeviceIdResponseTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETDeviceIdResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DELETEDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DELETEDeviceIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEDeviceIdResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class DELETEDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEDeviceIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEDeviceIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEDeviceIdBodyInput
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
        public DELETEDeviceIdBodyInputIdentifierTypeItem[] Identifier { get; set; }
    }

    public class DELETEDeviceIdBodyInputIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTDeviceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTDeviceIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PUTDeviceIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTDeviceIdResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class PUTDeviceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTDeviceIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTDeviceIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceIdVERSIONResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIdVERSIONResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceIdVERSIONResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceIdVERSIONResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceIdVERSIONResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIdVERSIONResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceIdVERSIONResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceIdHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceIdHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceIdHISTORYResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceIdHISTORYResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceIdHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceIdHISTORYResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceIdHISTORYResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETDeviceHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETDeviceHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETDeviceHISTORYResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETDeviceHISTORYResponseIdentifierTypeItem[] Identifier { get; set; }
    }

    public class GETDeviceHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETDeviceHISTORYResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETDeviceHISTORYResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETEncounterResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETEncounterResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETEncounterResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETEncounterResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETEncounterResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETEncounterResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETEncounterResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterResponseEntryTypeItemResourceTypeClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterResponseEntryTypeItemResourceTypePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterResponseEntryTypeItemResourceTypeServiceProviderType ServiceProvider { get; set; }

        [JsonProperty("reasonCode")]
        public GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTEncounterResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTEncounterResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public POSTEncounterResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public POSTEncounterResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public POSTEncounterResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public POSTEncounterResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public POSTEncounterResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public POSTEncounterResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class POSTEncounterResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTEncounterResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class POSTEncounterResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public POSTEncounterResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTEncounterResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTEncounterResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTEncounterResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public POSTEncounterResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class POSTEncounterResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTEncounterResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class POSTEncounterResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdBodyInput
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
        public DELETEEncounterIdBodyInputParticipantTypeItem[] Participant { get; set; }

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

    public class DELETEEncounterIdBodyInputParticipantTypeItem
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

    public class GETEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DELETEEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public DELETEEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public DELETEEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public DELETEEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DELETEEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public DELETEEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public DELETEEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class DELETEEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DELETEEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DELETEEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public DELETEEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public DELETEEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class DELETEEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTEncounterIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public PUTEncounterIdResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public PUTEncounterIdResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public PUTEncounterIdResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PUTEncounterIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public PUTEncounterIdResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public PUTEncounterIdResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class PUTEncounterIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTEncounterIdResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PUTEncounterIdResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public PUTEncounterIdResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTEncounterIdResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public PUTEncounterIdResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class PUTEncounterIdResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTEncounterIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTEncounterIdResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIdVersionResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIdVersionResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIdVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIdVersionResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIdVersionResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIdVersionResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIdVersionResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIdVersionResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIdVersionResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIdVersionResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIdVersionResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIdVersionResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIdVersionResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterIdHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterIdHISTORYResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterIdHISTORYResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterIdHISTORYResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterIdHISTORYResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterIdHISTORYResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterIdHISTORYResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterIdHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterIdHISTORYResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterIdHISTORYResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterIdHISTORYResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterIdHISTORYResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterIdHISTORYResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterIdHISTORYResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterIdHISTORYResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterIdHISTORYResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETEncounterHISTORYResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("class")]
        public GETEncounterHISTORYResponseClassType Class { get; set; }

        [JsonProperty("type")]
        public GETEncounterHISTORYResponseTypeTypeItem[] Type { get; set; }

        [JsonProperty("subject")]
        public GETEncounterHISTORYResponseSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public GETEncounterHISTORYResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("period")]
        public GETEncounterHISTORYResponsePeriodType Period { get; set; }

        [JsonProperty("serviceProvider")]
        public GETEncounterHISTORYResponseServiceProviderType ServiceProvider { get; set; }
    }

    public class GETEncounterHISTORYResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETEncounterHISTORYResponseClassType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GETEncounterHISTORYResponseTypeTypeItem
    {
        [JsonProperty("coding")]
        public GETEncounterHISTORYResponseTypeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETEncounterHISTORYResponseTypeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponseParticipantTypeItem
    {
        [JsonProperty("individual")]
        public GETEncounterHISTORYResponseParticipantTypeItemIndividualType Individual { get; set; }
    }

    public class GETEncounterHISTORYResponseParticipantTypeItemIndividualType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETEncounterHISTORYResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETEncounterHISTORYResponseServiceProviderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagResponseAuthorType Author { get; set; }
    }

    public class GETFlagResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public POSTFLAGResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public POSTFLAGResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public POSTFLAGResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public POSTFLAGResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public POSTFLAGResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public POSTFLAGResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public POSTFLAGResponseAuthorType Author { get; set; }
    }

    public class POSTFLAGResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTFLAGResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTFLAGResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public POSTFLAGResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTFLAGResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponseCodeType
    {
        [JsonProperty("coding")]
        public POSTFLAGResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class POSTFLAGResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTFLAGResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class POSTFLAGResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public BodyInputTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEFlagIdBodyInputIdentifierTypeItem[] Identifier { get; set; }

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

    public class DELETEFlagIdBodyInputIdentifierTypeItem
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

    public class GETFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIdResponseAuthorType Author { get; set; }
    }

    public class GETFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETEFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DELETEFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DELETEFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DELETEFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DELETEFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public DELETEFlagIdResponseAuthorType Author { get; set; }
    }

    public class DELETEFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DELETEFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DELETEFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DELETEFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PUTFlagIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PUTFlagIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PUTFlagIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PUTFlagIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PUTFlagIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PUTFlagIdResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public PUTFlagIdResponseAuthorType Author { get; set; }
    }

    public class PUTFlagIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTFlagIdResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTFlagIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PUTFlagIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTFlagIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PUTFlagIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PUTFlagIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTFlagIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PUTFlagIdResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIdVersionResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIdVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIdVersionResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIdVersionResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIdVersionResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIdVersionResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIdVersionResponseAuthorType Author { get; set; }
    }

    public class GETFlagIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIdVersionResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIdVersionResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIdVersionResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdVersionResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIdVersionResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdVersionResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdVersionResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIdVersionResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagIdHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagIdHistoryResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagIdHistoryResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagIdHistoryResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagIdHistoryResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagIdHistoryResponseAuthorType Author { get; set; }
    }

    public class GETFlagIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagIdHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagIdHistoryResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagIdHistoryResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdHistoryResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagIdHistoryResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagIdHistoryResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagIdHistoryResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagIdHistoryResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETFlagHISTORYResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GETFlagHISTORYResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GETFlagHISTORYResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GETFlagHISTORYResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GETFlagHISTORYResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public GETFlagHISTORYResponsePeriodType Period { get; set; }

        [JsonProperty("author")]
        public GETFlagHISTORYResponseAuthorType Author { get; set; }
    }

    public class GETFlagHISTORYResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETFlagHISTORYResponseIdentifierTypeItem
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETFlagHISTORYResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GETFlagHISTORYResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagHISTORYResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponseCodeType
    {
        [JsonProperty("coding")]
        public GETFlagHISTORYResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETFlagHISTORYResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETFlagHISTORYResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GETFlagHISTORYResponseAuthorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTLocationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public POSTLocationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public POSTLocationResponsePartOfType PartOf { get; set; }
    }

    public class POSTLocationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class POSTLocationResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETELocationIdBodyInput
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

    public class GETLocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIdResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETELocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETELocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public DELETELocationIdResponsePartOfType PartOf { get; set; }
    }

    public class DELETELocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETELocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTLocationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PUTLocationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public PUTLocationIdResponsePartOfType PartOf { get; set; }
    }

    public class PUTLocationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class PUTLocationIdResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIdVersionResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIdVersionResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIdVersionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIdVersionResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationIdHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationIdHistoryResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationIdHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationIdHistoryResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETLocationHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public GETLocationHistoryResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("partOf")]
        public GETLocationHistoryResponsePartOfType PartOf { get; set; }
    }

    public class GETLocationHistoryResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETLocationHistoryResponsePartOfType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTPatientResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public POSTPatientResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public POSTPatientResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public POSTPatientResponseAddressTypeItem[] Address { get; set; }
    }

    public class POSTPatientResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class POSTPatientResponseTelecomTypeItem
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

    public class POSTPatientResponseAddressTypeItem
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
        public POSTPatientResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class POSTPatientResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class POSTPatientBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DELETEPatientIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPatientIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool? DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DELETEPatientIdBodyInputAddressTypeItem[] Address { get; set; }
    }

    public class DELETEPatientIdBodyInputNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DELETEPatientIdBodyInputTelecomTypeItem
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

    public class DELETEPatientIdBodyInputAddressTypeItem
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

    public class GETPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIdResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIdResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIdResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIdResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIdResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientIdResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIdResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DELETEPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DELETEPatientIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPatientIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DELETEPatientIdResponseAddressTypeItem[] Address { get; set; }
    }

    public class DELETEPatientIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DELETEPatientIdResponseTelecomTypeItem
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

    public class DELETEPatientIdResponseAddressTypeItem
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
        public DELETEPatientIdResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class DELETEPatientIdResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DELETEPatientIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DELETEPatientIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPatientIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool? DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public DELETEPatientIdBodyInputAddressTypeItem[] Address { get; set; }
    }

    public class PUTPatientIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PUTPatientIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPatientIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("deceasedBoolean")]
        public bool DeceasedBoolean { get; set; }

        [JsonProperty("address")]
        public PUTPatientIdResponseAddressTypeItem[] Address { get; set; }
    }

    public class PUTPatientIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PUTPatientIdResponseTelecomTypeItem
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

    public class PUTPatientIdResponseAddressTypeItem
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
        public PUTPatientIdResponseAddressTypeItemPeriodType Period { get; set; }
    }

    public class PUTPatientIdResponseAddressTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GETPatientIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIdVersionResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIdVersionResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIdVersionResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdVersionResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIdVersionResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIdVersionResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIdVersionResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientIdVersionResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETPatientIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientIdHistoryResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientIdHistoryResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientIdHistoryResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdHistoryResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientIdHistoryResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientIdHistoryResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientIdHistoryResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETPatientHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPatientHistoryResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPatientHistoryResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPatientHistoryResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientHistoryResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPatientHistoryResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPatientHistoryResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("extension")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem[] Extension { get; set; }

        [JsonProperty("identifier")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("name")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("valueCodeableConcept")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType ValueCodeableConcept { get; set; }

        [JsonProperty("valueCode")]
        public string ValueCode { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptType
    {
        [JsonProperty("coding")]
        public GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeExtensionTypeItemValueCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeNameTypeItem
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

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPatientHistoryResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPatientHistoryResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GETPersonResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonResponseAddressTypeItem
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

    public class GETPersonResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTPersonResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public POSTPersonResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public POSTPersonResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public POSTPersonResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public POSTPersonResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public POSTPersonResponseLinkTypeItem[] Link { get; set; }
    }

    public class POSTPersonResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class POSTPersonResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class POSTPersonResponseAddressTypeItem
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

    public class POSTPersonResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class POSTPersonResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public POSTPersonResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class POSTPersonResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPersonIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public DELETEPatientIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPersonIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public DELETEPersonIdBodyInputAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public BodyInputManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("link")]
        public BodyInputLinkTypeItem[] Link { get; set; }
    }

    public class DELETEPersonIdBodyInputTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class DELETEPersonIdBodyInputAddressTypeItem
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

    public class GETPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIdResponseAddressTypeItem
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

    public class GETPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public DELETEPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public DELETEPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public DELETEPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public DELETEPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class DELETEPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class DELETEPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class DELETEPersonIdResponseAddressTypeItem
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

    public class DELETEPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public DELETEPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class DELETEPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTPersonIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public PUTPersonIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPersonIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public PUTPersonIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public PUTPersonIdResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public PUTPersonIdResponseLinkTypeItem[] Link { get; set; }
    }

    public class PUTPersonIdResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class PUTPersonIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PUTPersonIdResponseAddressTypeItem
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

    public class PUTPersonIdResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PUTPersonIdResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public PUTPersonIdResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class PUTPersonIdResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIdVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIdVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIdVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIdVersionResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIdVersionResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIdVersionResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIdVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIdVersionResponseAddressTypeItem
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

    public class GETPersonIdVersionResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdVersionResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIdVersionResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIdVersionResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonIdHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonIdHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonIdHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonIdHistoryResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonIdHistoryResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonIdHistoryResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonIdHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonIdHistoryResponseAddressTypeItem
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

    public class GETPersonIdHistoryResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonIdHistoryResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonIdHistoryResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonIdHistoryResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public GETPersonHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPersonHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("address")]
        public GETPersonHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("managingOrganization")]
        public GETPersonHistoryResponseManagingOrganizationType ManagingOrganization { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("link")]
        public GETPersonHistoryResponseLinkTypeItem[] Link { get; set; }
    }

    public class GETPersonHistoryResponseNameTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }
    }

    public class GETPersonHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPersonHistoryResponseAddressTypeItem
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

    public class GETPersonHistoryResponseManagingOrganizationType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPersonHistoryResponseLinkTypeItem
    {
        [JsonProperty("target")]
        public GETPersonHistoryResponseLinkTypeItemTargetType Target { get; set; }

        [JsonProperty("assurance")]
        public string Assurance { get; set; }
    }

    public class GETPersonHistoryResponseLinkTypeItemTargetType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GETPractitionerResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GETPractitionerResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GETPractitionerResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GETPractitionerResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GETPractitionerResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GETPractitionerResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerResponseEntryTypeItemResourceTypeNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerResponseEntryTypeItemResourceTypeTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerResponseEntryTypeItemResourceTypeAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerResponseEntryTypeItemResourceTypeAddressTypeItem
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

    public class GETPractitionerResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class POSTPractitionerResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public POSTPractitionerResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public POSTPractitionerResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public POSTPractitionerResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public POSTPractitionerResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public POSTPractitionerResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class POSTPractitionerResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class POSTPractitionerResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class POSTPractitionerResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class POSTPractitionerResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class POSTPractitionerResponseAddressTypeItem
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

    public class POSTPractitionerBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("identifier")]
        public DELETEDeviceIdBodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DELETEPractitionerIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("address")]
        public POSTPractitionerBodyInputAddressTypeItem[] Address { get; set; }

        [JsonProperty("qualification")]
        public BodyInputQualificationTypeItem[] Qualification { get; set; }
    }

    public class DELETEPractitionerIdBodyInputNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class POSTPractitionerBodyInputAddressTypeItem
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

    public class GETPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIdResponseAddressTypeItem
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

    public class DELETEPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DELETEPractitionerIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DELETEPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public DELETEPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("address")]
        public DELETEPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("qualification")]
        public DELETEPractitionerIdResponseQualificationTypeItem[] Qualification { get; set; }
    }

    public class DELETEPractitionerIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class DELETEPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class DELETEPractitionerIdResponseAddressTypeItem
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

    public class DELETEPractitionerIdResponseQualificationTypeItem
    {
        [JsonProperty("identifier")]
        public DELETEPractitionerIdResponseQualificationTypeItemIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("code")]
        public DELETEPractitionerIdResponseQualificationTypeItemCodeType Code { get; set; }

        [JsonProperty("period")]
        public DELETEPractitionerIdResponseQualificationTypeItemPeriodType Period { get; set; }

        [JsonProperty("issuer")]
        public DELETEPractitionerIdResponseQualificationTypeItemIssuerType Issuer { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemCodeType
    {
        [JsonProperty("coding")]
        public DELETEPractitionerIdResponseQualificationTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DELETEPractitionerIdResponseQualificationTypeItemIssuerType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DELETEPractitionerIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public DELETEDeviceIdBodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("name")]
        public DELETEPractitionerIdBodyInputNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public DELETEPersonIdBodyInputTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public DELETEPractitionerIdBodyInputAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class DELETEPractitionerIdBodyInputAddressTypeItem
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

    public class PUTPractitionerIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PUTPractitionerIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PUTPractitionerIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public PUTPractitionerIdResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public PUTPractitionerIdResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public PUTPractitionerIdResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class PUTPractitionerIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PUTPractitionerIdResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PUTPractitionerIdResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class PUTPractitionerIdResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class PUTPractitionerIdResponseAddressTypeItem
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

    public class GETPractitionerIdVersionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIdVersionResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIdVersionResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIdVersionResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIdVersionResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIdVersionResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIdVersionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIdVersionResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIdVersionResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIdVersionResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIdVersionResponseAddressTypeItem
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

    public class GETPractitionerIdHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerIdHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerIdHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerIdHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerIdHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerIdHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerIdHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerIdHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerIdHistoryResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerIdHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerIdHistoryResponseAddressTypeItem
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

    public class GETPractitionerHistoryResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GETPractitionerHistoryResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GETPractitionerHistoryResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("name")]
        public GETPractitionerHistoryResponseNameTypeItem[] Name { get; set; }

        [JsonProperty("telecom")]
        public GETPractitionerHistoryResponseTelecomTypeItem[] Telecom { get; set; }

        [JsonProperty("address")]
        public GETPractitionerHistoryResponseAddressTypeItem[] Address { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public class GETPractitionerHistoryResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GETPractitionerHistoryResponseIdentifierTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GETPractitionerHistoryResponseNameTypeItem
    {
        [JsonProperty("family")]
        public string Family { get; set; }

        [JsonProperty("given")]
        public string[] Given { get; set; }

        [JsonProperty("prefix")]
        public string[] Prefix { get; set; }
    }

    public class GETPractitionerHistoryResponseTelecomTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("use")]
        public string Use { get; set; }
    }

    public class GETPractitionerHistoryResponseAddressTypeItem
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