//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fhirclinical
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FhirclinicalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetAdverseEventResponse, ApiConnectionActionConfiguration> GetAdverseEvent(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetAdverseEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AdverseEvent";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetAdverseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostAdverseEventResponse, ApiConnectionActionConfiguration> PostAdverseEvent(Expression<Func<PostAdverseEventBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostAdverseEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AdverseEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostAdverseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetAdverseEventIdResponse, ApiConnectionActionConfiguration> GetAdverseEventId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetAdverseEventIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AdverseEvent/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetAdverseEventIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteAdverseEventIdResponse, ApiConnectionActionConfiguration> DeleteAdverseEventId(Expression<Func<string>> id, Expression<Func<DeleteAdverseEventIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteAdverseEventIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AdverseEvent/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteAdverseEventIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutAdverseEventIdResponse, ApiConnectionActionConfiguration> PutAdverseEventId(Expression<Func<string>> id, Expression<Func<DeleteAdverseEventIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutAdverseEventIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AdverseEvent/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutAdverseEventIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetAllergyIntoleranceResponse, ApiConnectionActionConfiguration> GetAllergyIntolerance(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetAllergyIntoleranceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AllergyIntolerance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetAllergyIntoleranceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostAllergyIntoleranceResponse, ApiConnectionActionConfiguration> PostAllergyIntolerance(Expression<Func<PostAllergyIntoleranceBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostAllergyIntoleranceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AllergyIntolerance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostAllergyIntoleranceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration> GetAllergyIntoleranceId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AllergyIntolerance/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetAllergyIntoleranceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration> DeleteAllergyIntoleranceId(Expression<Func<string>> id, Expression<Func<DeleteAllergyIntoleranceIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AllergyIntolerance/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteAllergyIntoleranceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration> PutAllergyIntoleranceId(Expression<Func<string>> id, Expression<Func<DeleteAllergyIntoleranceIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutAllergyIntoleranceIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/AllergyIntolerance/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutAllergyIntoleranceIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetCarePlanResponse, ApiConnectionActionConfiguration> GetCarePlan(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetCarePlanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarePlan";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetCarePlanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostCarePlanResponse, ApiConnectionActionConfiguration> PostCarePlan(Expression<Func<PostCarePlanBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostCarePlanResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CarePlan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostCarePlanResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetCarePlanIdResponse, ApiConnectionActionConfiguration> GetCarePlanId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetCarePlanIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CarePlan/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetCarePlanIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteCarePlanIdResponse, ApiConnectionActionConfiguration> DeleteCarePlanId(Expression<Func<string>> id, Expression<Func<DeleteCarePlanIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteCarePlanIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CarePlan/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteCarePlanIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutCarePlanIdResponse, ApiConnectionActionConfiguration> PutCarePlanId(Expression<Func<string>> id, Expression<Func<DeleteCarePlanIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutCarePlanIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CarePlan/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutCarePlanIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetConditionResponse, ApiConnectionActionConfiguration> GetCondition(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetConditionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Condition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetConditionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostConditionResponse, ApiConnectionActionConfiguration> PostCondition(Expression<Func<PostConditionBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostConditionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Condition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostConditionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetConditionIdResponse, ApiConnectionActionConfiguration> GetConditionId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetConditionIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Condition/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetConditionIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteConditionIdResponse, ApiConnectionActionConfiguration> DeleteConditionId(Expression<Func<string>> id, Expression<Func<DeleteConditionIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteConditionIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Condition/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteConditionIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutConditionIdResponse, ApiConnectionActionConfiguration> PutConditionId(Expression<Func<string>> id, Expression<Func<DeleteConditionIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutConditionIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Condition/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutConditionIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetDiagnosticReportResponse, ApiConnectionActionConfiguration> GetDiagnosticReport(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetDiagnosticReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DiagnosticReport";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetDiagnosticReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostDiagnosticReportResponse, ApiConnectionActionConfiguration> PostDiagnosticReport(Expression<Func<PostDiagnosticReportBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostDiagnosticReportResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DiagnosticReport";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostDiagnosticReportResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetDiagnosticReportIdResponse, ApiConnectionActionConfiguration> GetDiagnosticReportId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetDiagnosticReportIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DiagnosticReport/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetDiagnosticReportIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteDiagnosticReportIdResponse, ApiConnectionActionConfiguration> DeleteDiagnosticReportId(Expression<Func<string>> id, Expression<Func<DeleteDiagnosticReportIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteDiagnosticReportIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DiagnosticReport/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteDiagnosticReportIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutDiagnosticReportIdResponse, ApiConnectionActionConfiguration> PutDiagnosticReportId(Expression<Func<string>> id, Expression<Func<DeleteDiagnosticReportIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutDiagnosticReportIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/DiagnosticReport/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutDiagnosticReportIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetMedicationResponse, ApiConnectionActionConfiguration> GetMedication(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetMedicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Medication";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetMedicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostMedicationResponse, ApiConnectionActionConfiguration> PostMedication(Expression<Func<PostMedicationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostMedicationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Medication";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostMedicationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetMedicationIdResponse, ApiConnectionActionConfiguration> GetMedicationId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetMedicationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Medication/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetMedicationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteMedicationIdResponse, ApiConnectionActionConfiguration> DeleteMedicationId(Expression<Func<string>> id, Expression<Func<DeleteMedicationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteMedicationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Medication/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteMedicationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutMedicationIdResponse, ApiConnectionActionConfiguration> PutMedicationId(Expression<Func<string>> id, Expression<Func<PutMedicationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutMedicationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Medication/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutMedicationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetMedicationRequestResponse, ApiConnectionActionConfiguration> GetMedicationRequest(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetMedicationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationRequest";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetMedicationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostMedicationRequestResponse, ApiConnectionActionConfiguration> PostMedicationRequest(Expression<Func<PostMedicationRequestBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostMedicationRequestResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostMedicationRequestResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetMedicationRequestIdResponse, ApiConnectionActionConfiguration> GetMedicationRequestId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetMedicationRequestIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetMedicationRequestIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteMedicationRequestIdResponse, ApiConnectionActionConfiguration> DeleteMedicationRequestId(Expression<Func<string>> id, Expression<Func<DeleteMedicationRequestIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteMedicationRequestIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteMedicationRequestIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutMedicationRequestIdResponse, ApiConnectionActionConfiguration> PutMedicationRequestId(Expression<Func<string>> id, Expression<Func<DeleteMedicationRequestIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutMedicationRequestIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationRequest/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutMedicationRequestIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetMedicationStatementResponse, ApiConnectionActionConfiguration> GetMedicationStatement(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetMedicationStatementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationStatement";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetMedicationStatementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostMedicationStatementResponse, ApiConnectionActionConfiguration> PostMedicationStatement(Expression<Func<DeleteMedicationStatementIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostMedicationStatementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/MedicationStatement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostMedicationStatementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetMedicationStatementIdResponse, ApiConnectionActionConfiguration> GetMedicationStatementId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetMedicationStatementIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationStatement/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetMedicationStatementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteMedicationStatementId(Expression<Func<string>> id, Expression<Func<DeleteMedicationStatementIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationStatement/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutMedicationStatementIdResponse, ApiConnectionActionConfiguration> PutMedicationStatementId(Expression<Func<string>> id, Expression<Func<DeleteMedicationStatementIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutMedicationStatementIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/MedicationStatement/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutMedicationStatementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetObservationResponse, ApiConnectionActionConfiguration> GetObservation(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null, Expression<Func<string>> encounter = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            var __workflow_encounter = WorkflowExpression.Compile(encounter, nameof(encounter), required: false);
            return new DeferredBodyAction<GetObservationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Observation";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                if (__workflow_encounter != null)
                    callPayload.Queries["encounter"] = ExpressionConverter.Convert(__workflow_encounter);
                return new ApiConnectionAction<GetObservationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostObservationResponse, ApiConnectionActionConfiguration> PostObservation(Expression<Func<PostObservationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostObservationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Observation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostObservationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetObservationIdResponse, ApiConnectionActionConfiguration> GetObservationId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetObservationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Observation/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetObservationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteObservationIdResponse, ApiConnectionActionConfiguration> DeleteObservationId(Expression<Func<string>> id, Expression<Func<DeleteObservationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteObservationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Observation/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteObservationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutObservationIdResponse, ApiConnectionActionConfiguration> PutObservationId(Expression<Func<string>> id, Expression<Func<DeleteObservationIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutObservationIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Observation/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutObservationIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetProcedureResponse, ApiConnectionActionConfiguration> GetProcedure(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetProcedureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Procedure";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetProcedureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostProcedureResponse, ApiConnectionActionConfiguration> PostProcedure(Expression<Func<PostProcedureBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostProcedureResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Procedure";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostProcedureResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetProcedureIdResponse, ApiConnectionActionConfiguration> GetProcedureId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetProcedureIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Procedure/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetProcedureIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteProcedureIdResponse, ApiConnectionActionConfiguration> DeleteProcedureId(Expression<Func<string>> id, Expression<Func<DeleteProcedureIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteProcedureIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Procedure/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteProcedureIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutProcedureIdResponse, ApiConnectionActionConfiguration> PutProcedureId(Expression<Func<string>> id, Expression<Func<DeleteProcedureIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutProcedureIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Procedure/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutProcedureIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetRiskAssessmentResponse, ApiConnectionActionConfiguration> GetRiskAssessment(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetRiskAssessmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RiskAssessment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetRiskAssessmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PostRiskAssessmentResponse, ApiConnectionActionConfiguration> PostRiskAssessment(Expression<Func<DeleteRiskAssessmentIdBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PostRiskAssessmentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RiskAssessment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PostRiskAssessmentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetRiskAssessmentIdResponse, ApiConnectionActionConfiguration> GetRiskAssessmentId(Expression<Func<string>> id, Expression<Func<string>> count = null, Expression<Func<string>> sort = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            return new DeferredBodyAction<GetRiskAssessmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RiskAssessment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                return new ApiConnectionAction<GetRiskAssessmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<DeleteRiskAssessmentIdResponse, ApiConnectionActionConfiguration> DeleteRiskAssessmentId(Expression<Func<string>> id, Expression<Func<DeleteRiskAssessmentIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteRiskAssessmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RiskAssessment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteRiskAssessmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<PutRiskAssessmentIdResponse, ApiConnectionActionConfiguration> PutRiskAssessmentId(Expression<Func<string>> id, Expression<Func<DeleteRiskAssessmentIdBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PutRiskAssessmentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/RiskAssessment/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PutRiskAssessmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetCareTeamResponse, ApiConnectionActionConfiguration> GetCareTeam(Expression<Func<string>> count = null, Expression<Func<string>> sort = null, Expression<Func<string>> patient = null)
        {
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_patient = WorkflowExpression.Compile(patient, nameof(patient), required: false);
            return new DeferredBodyAction<GetCareTeamResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CareTeam";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["_count"] = ExpressionConverter.Convert(__workflow_count);
                if (__workflow_sort != null)
                    callPayload.Queries["_sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_patient != null)
                    callPayload.Queries["patient"] = ExpressionConverter.Convert(__workflow_patient);
                return new ApiConnectionAction<GetCareTeamResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fhirclinical")]
        public IBodyWorkflowAction<GetCareTeamIdResponse, ApiConnectionActionConfiguration> GetCareTeamId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetCareTeamIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/CareTeam/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetCareTeamIdResponse>(callPayload);
            });
        }
    }

    public class FhirclinicalTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAdverseEventResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAdverseEventResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetAdverseEventResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetAdverseEventResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetAdverseEventResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAdverseEventResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetAdverseEventResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetAdverseEventResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeEventType Event { get; set; }

        [JsonProperty("subject")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeEventType
    {
        [JsonProperty("coding")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeSeriousnessType
    {
        [JsonProperty("coding")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeSeverityType
    {
        [JsonProperty("coding")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public GetAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemResourceTypeSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAdverseEventResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostAdverseEventResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostAdverseEventResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PostAdverseEventResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public PostAdverseEventResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public PostAdverseEventResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public PostAdverseEventResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public PostAdverseEventResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public PostAdverseEventResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public PostAdverseEventResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public PostAdverseEventResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class PostAdverseEventResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostAdverseEventResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PostAdverseEventResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PostAdverseEventResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostAdverseEventResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAdverseEventResponseEventType
    {
        [JsonProperty("coding")]
        public PostAdverseEventResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostAdverseEventResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAdverseEventResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostAdverseEventResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public PostAdverseEventResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostAdverseEventResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAdverseEventResponseSeverityType
    {
        [JsonProperty("coding")]
        public PostAdverseEventResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostAdverseEventResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAdverseEventResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostAdverseEventResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public PostAdverseEventResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class PostAdverseEventResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostAdverseEventBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("identifier")]
        public BodyInputIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public BodyInputEventType Event { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public BodyInputSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public BodyInputSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public DeleteAdverseEventIdBodyInputRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public BodyInputSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class BodyInputIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeleteAdverseEventIdBodyInputCategoryTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputCategoryTypeItemCodingTypeItem[] Coding { get; set; }
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

    public class BodyInputEventType
    {
        [JsonProperty("coding")]
        public BodyInputEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAdverseEventIdBodyInputSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputSeriousnessType
    {
        [JsonProperty("coding")]
        public BodyInputSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputSeverityType
    {
        [JsonProperty("coding")]
        public BodyInputSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAdverseEventIdBodyInputRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public BodyInputSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class BodyInputSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAdverseEventIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAdverseEventIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public GetAdverseEventIdResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public GetAdverseEventIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public GetAdverseEventIdResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public GetAdverseEventIdResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public GetAdverseEventIdResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public GetAdverseEventIdResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public GetAdverseEventIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public GetAdverseEventIdResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class GetAdverseEventIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAdverseEventIdResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetAdverseEventIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetAdverseEventIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetAdverseEventIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventIdResponseEventType
    {
        [JsonProperty("coding")]
        public GetAdverseEventIdResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetAdverseEventIdResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAdverseEventIdResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public GetAdverseEventIdResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAdverseEventIdResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public GetAdverseEventIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAdverseEventIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAdverseEventIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAdverseEventIdResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public GetAdverseEventIdResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class GetAdverseEventIdResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteAdverseEventIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteAdverseEventIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public DeleteAdverseEventIdResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public DeleteAdverseEventIdResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public DeleteAdverseEventIdResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public DeleteAdverseEventIdResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public DeleteAdverseEventIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public DeleteAdverseEventIdResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class DeleteAdverseEventIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteAdverseEventIdResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeleteAdverseEventIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DeleteAdverseEventIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAdverseEventIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAdverseEventIdResponseEventType
    {
        [JsonProperty("coding")]
        public DeleteAdverseEventIdResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteAdverseEventIdResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAdverseEventIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteAdverseEventIdResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public DeleteAdverseEventIdResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAdverseEventIdResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAdverseEventIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public DeleteAdverseEventIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAdverseEventIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAdverseEventIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteAdverseEventIdResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public DeleteAdverseEventIdResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class DeleteAdverseEventIdResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteAdverseEventIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public BodyInputIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public BodyInputEventType Event { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public BodyInputSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public BodyInputSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public DeleteAdverseEventIdBodyInputRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public BodyInputSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class BodyInputMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutAdverseEventIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutAdverseEventIdResponseMetaType Meta { get; set; }

        [JsonProperty("identifier")]
        public PutAdverseEventIdResponseIdentifierType Identifier { get; set; }

        [JsonProperty("actuality")]
        public string Actuality { get; set; }

        [JsonProperty("category")]
        public PutAdverseEventIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("event")]
        public PutAdverseEventIdResponseEventType Event { get; set; }

        [JsonProperty("subject")]
        public PutAdverseEventIdResponseSubjectType Subject { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("seriousness")]
        public PutAdverseEventIdResponseSeriousnessType Seriousness { get; set; }

        [JsonProperty("severity")]
        public PutAdverseEventIdResponseSeverityType Severity { get; set; }

        [JsonProperty("recorder")]
        public PutAdverseEventIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("suspectEntity")]
        public PutAdverseEventIdResponseSuspectEntityTypeItem[] SuspectEntity { get; set; }
    }

    public class PutAdverseEventIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutAdverseEventIdResponseIdentifierType
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PutAdverseEventIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PutAdverseEventIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PutAdverseEventIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutAdverseEventIdResponseEventType
    {
        [JsonProperty("coding")]
        public PutAdverseEventIdResponseEventTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutAdverseEventIdResponseEventTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutAdverseEventIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutAdverseEventIdResponseSeriousnessType
    {
        [JsonProperty("coding")]
        public PutAdverseEventIdResponseSeriousnessTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutAdverseEventIdResponseSeriousnessTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutAdverseEventIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public PutAdverseEventIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutAdverseEventIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutAdverseEventIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutAdverseEventIdResponseSuspectEntityTypeItem
    {
        [JsonProperty("instance")]
        public PutAdverseEventIdResponseSuspectEntityTypeItemInstanceType Instance { get; set; }
    }

    public class PutAdverseEventIdResponseSuspectEntityTypeItemInstanceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAllergyIntoleranceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAllergyIntoleranceResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetAllergyIntoleranceResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetAllergyIntoleranceResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetAllergyIntoleranceResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAllergyIntoleranceResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetAllergyIntoleranceResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("patient")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusType
    {
        [JsonProperty("coding")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusType
    {
        [JsonProperty("coding")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GetAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemResourceTypePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetAllergyIntoleranceResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostAllergyIntoleranceResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostAllergyIntoleranceResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostAllergyIntoleranceResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public PostAllergyIntoleranceResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PostAllergyIntoleranceResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public PostAllergyIntoleranceResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public PostAllergyIntoleranceResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }

        [JsonProperty("recorder")]
        public PostAllergyIntoleranceResponseRecorderType Recorder { get; set; }

        [JsonProperty("reaction")]
        public PostAllergyIntoleranceResponseReactionTypeItem[] Reaction { get; set; }
    }

    public class PostAllergyIntoleranceResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostAllergyIntoleranceResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostAllergyIntoleranceResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PostAllergyIntoleranceResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostAllergyIntoleranceResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAllergyIntoleranceResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PostAllergyIntoleranceResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostAllergyIntoleranceResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAllergyIntoleranceResponseCodeType
    {
        [JsonProperty("coding")]
        public PostAllergyIntoleranceResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostAllergyIntoleranceResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAllergyIntoleranceResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostAllergyIntoleranceResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostAllergyIntoleranceResponseReactionTypeItem
    {
        [JsonProperty("manifestation")]
        public PostAllergyIntoleranceResponseReactionTypeItemManifestationTypeItem[] Manifestation { get; set; }
    }

    public class PostAllergyIntoleranceResponseReactionTypeItemManifestationTypeItem
    {
        [JsonProperty("coding")]
        public PostAllergyIntoleranceResponseReactionTypeItemManifestationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostAllergyIntoleranceResponseReactionTypeItemManifestationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAllergyIntoleranceBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public PostAllergyIntoleranceBodyInputClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PostAllergyIntoleranceBodyInputVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public DeleteDiagnosticReportIdBodyInputCodeType Code { get; set; }

        [JsonProperty("patient")]
        public BodyInputPatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }

        [JsonProperty("recorder")]
        public DeleteAdverseEventIdBodyInputRecorderType Recorder { get; set; }

        [JsonProperty("reaction")]
        public BodyInputReactionTypeItem[] Reaction { get; set; }
    }

    public class DeleteCarePlanIdBodyInputTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostAllergyIntoleranceBodyInputClinicalStatusType
    {
        [JsonProperty("coding")]
        public PostAllergyIntoleranceBodyInputClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostAllergyIntoleranceBodyInputClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostAllergyIntoleranceBodyInputVerificationStatusType
    {
        [JsonProperty("coding")]
        public PostAllergyIntoleranceBodyInputVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostAllergyIntoleranceBodyInputVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteDiagnosticReportIdBodyInputCodeType
    {
        [JsonProperty("coding")]
        public BodyInputCodeTypeCodingTypeItem[] Coding { get; set; }
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

    public class BodyInputPatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputReactionTypeItem
    {
        [JsonProperty("manifestation")]
        public BodyInputReactionTypeItemManifestationTypeItem[] Manifestation { get; set; }
    }

    public class BodyInputReactionTypeItemManifestationTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputReactionTypeItemManifestationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputReactionTypeItemManifestationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAllergyIntoleranceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetAllergyIntoleranceIdResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public GetAllergyIntoleranceIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GetAllergyIntoleranceIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public GetAllergyIntoleranceIdResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public GetAllergyIntoleranceIdResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class GetAllergyIntoleranceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetAllergyIntoleranceIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public GetAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAllergyIntoleranceIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public GetAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetAllergyIntoleranceIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GetAllergyIntoleranceIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetAllergyIntoleranceIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetAllergyIntoleranceIdResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteAllergyIntoleranceIdResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public DeleteAllergyIntoleranceIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DeleteAllergyIntoleranceIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public DeleteAllergyIntoleranceIdResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public DeleteAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public DeleteAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DeleteAllergyIntoleranceIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteAllergyIntoleranceIdResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteAllergyIntoleranceIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public DeleteAllergyIntoleranceIdBodyInputClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DeleteAllergyIntoleranceIdBodyInputVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdBodyInputCodeType Code { get; set; }

        [JsonProperty("patient")]
        public BodyInputPatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class DeleteAllergyIntoleranceIdBodyInputClinicalStatusType
    {
        [JsonProperty("coding")]
        public DeleteAllergyIntoleranceIdBodyInputClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAllergyIntoleranceIdBodyInputClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteAllergyIntoleranceIdBodyInputVerificationStatusType
    {
        [JsonProperty("coding")]
        public DeleteAllergyIntoleranceIdBodyInputVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteAllergyIntoleranceIdBodyInputVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteAllergyIntoleranceIdBodyInputCodeType
    {
        [JsonProperty("coding")]
        public BodyInputCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutAllergyIntoleranceIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutAllergyIntoleranceIdResponseMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public PutAllergyIntoleranceIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PutAllergyIntoleranceIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("category")]
        public string[] Category { get; set; }

        [JsonProperty("criticality")]
        public string Criticality { get; set; }

        [JsonProperty("code")]
        public PutAllergyIntoleranceIdResponseCodeType Code { get; set; }

        [JsonProperty("patient")]
        public PutAllergyIntoleranceIdResponsePatientType Patient { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }
    }

    public class PutAllergyIntoleranceIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutAllergyIntoleranceIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PutAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutAllergyIntoleranceIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutAllergyIntoleranceIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PutAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutAllergyIntoleranceIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutAllergyIntoleranceIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PutAllergyIntoleranceIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutAllergyIntoleranceIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutAllergyIntoleranceIdResponsePatientType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetCarePlanResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetCarePlanResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetCarePlanResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetCarePlanResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetCarePlanResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetCarePlanResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetCarePlanResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetCarePlanResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetCarePlanResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("category")]
        public GetCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("subject")]
        public GetCarePlanResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetCarePlanResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GetCarePlanResponseEntryTypeItemResourceTypePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public GetCarePlanResponseEntryTypeItemResourceTypeCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public GetCarePlanResponseEntryTypeItemResourceTypeAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public GetCarePlanResponseEntryTypeItemResourceTypeGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItem[] Activity { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItem
    {
        [JsonProperty("detail")]
        public GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailType Detail { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailType
    {
        [JsonProperty("code")]
        public GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("location")]
        public GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeLocationType Location { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemResourceTypeActivityTypeItemDetailTypeLocationType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCarePlanResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostCarePlanResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostCarePlanResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostCarePlanResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PostCarePlanResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public PostCarePlanResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PostCarePlanResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public PostCarePlanResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public PostCarePlanResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public PostCarePlanResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public PostCarePlanResponseActivityTypeItem[] Activity { get; set; }
    }

    public class PostCarePlanResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostCarePlanResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public PostCarePlanResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PostCarePlanResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public PostCarePlanResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PostCarePlanResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PostCarePlanResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public PostCarePlanResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public PostCarePlanResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public PostCarePlanResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public PostCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public PostCarePlanResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public PostCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostCarePlanResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostCarePlanResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostCarePlanResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class PostCarePlanResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostCarePlanResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostCarePlanResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostCarePlanResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public PostCarePlanResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public PostCarePlanResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class PostCarePlanResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostCarePlanResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public PostCarePlanResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public PostCarePlanResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public PostCarePlanResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class PostCarePlanResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public PostCarePlanResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostCarePlanResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostCarePlanResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PostCarePlanResponseActivityTypeItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostCarePlanBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("category")]
        public PostCarePlanBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public PostCarePlanBodyInputEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public PostCarePlanBodyInputPeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public BodyInputCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public PostCarePlanBodyInputAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("activity")]
        public PostCarePlanBodyInputActivityTypeItem[] Activity { get; set; }
    }

    public class PostCarePlanBodyInputCategoryTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostCarePlanBodyInputEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostCarePlanBodyInputPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class BodyInputCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostCarePlanBodyInputAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostCarePlanBodyInputActivityTypeItem
    {
        [JsonProperty("detail")]
        public PostCarePlanBodyInputActivityTypeItemDetailType Detail { get; set; }
    }

    public class PostCarePlanBodyInputActivityTypeItemDetailType
    {
        [JsonProperty("code")]
        public PostCarePlanBodyInputActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("location")]
        public BodyInputActivityTypeItemDetailTypeLocationType Location { get; set; }
    }

    public class PostCarePlanBodyInputActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public PostCarePlanBodyInputActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostCarePlanBodyInputActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputActivityTypeItemDetailTypeLocationType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCarePlanIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetCarePlanIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetCarePlanIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("category")]
        public GetCarePlanIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("subject")]
        public GetCarePlanIdResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetCarePlanIdResponseEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GetCarePlanIdResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public GetCarePlanIdResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public GetCarePlanIdResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("activity")]
        public GetCarePlanIdResponseActivityTypeItem[] Activity { get; set; }
    }

    public class GetCarePlanIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetCarePlanIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetCarePlanIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetCarePlanIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCarePlanIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCarePlanIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanIdResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetCarePlanIdResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanIdResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCarePlanIdResponseActivityTypeItem
    {
        [JsonProperty("detail")]
        public GetCarePlanIdResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class GetCarePlanIdResponseActivityTypeItemDetailType
    {
        [JsonProperty("code")]
        public GetCarePlanIdResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("location")]
        public GetCarePlanIdResponseActivityTypeItemDetailTypeLocationType Location { get; set; }
    }

    public class GetCarePlanIdResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public GetCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCarePlanIdResponseActivityTypeItemDetailTypeLocationType
    {
        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteCarePlanIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteCarePlanIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteCarePlanIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DeleteCarePlanIdResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public DeleteCarePlanIdResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public DeleteCarePlanIdResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public DeleteCarePlanIdResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public DeleteCarePlanIdResponseActivityTypeItem[] Activity { get; set; }
    }

    public class DeleteCarePlanIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteCarePlanIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public DeleteCarePlanIdResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DeleteCarePlanIdResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public DeleteCarePlanIdResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public DeleteCarePlanIdResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public DeleteCarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public DeleteCarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteCarePlanIdResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteCarePlanIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteCarePlanIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DeleteCarePlanIdResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteCarePlanIdResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteCarePlanIdResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteCarePlanIdResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public DeleteCarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public DeleteCarePlanIdResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class DeleteCarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteCarePlanIdResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public DeleteCarePlanIdResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public DeleteCarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public DeleteCarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class DeleteCarePlanIdResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public DeleteCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteCarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DeleteCarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteCarePlanIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteCarePlanIdBodyInputContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public DeleteCarePlanIdBodyInputPeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public BodyInputCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public DeleteCarePlanIdBodyInputAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public BodyInputGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public DeleteCarePlanIdBodyInputActivityTypeItem[] Activity { get; set; }
    }

    public class DeleteCarePlanIdBodyInputContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public BodyInputContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public BodyInputContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public DeleteCarePlanIdBodyInputContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public BodyInputContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public BodyInputContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public BodyInputContainedTypeItemDescriptionType Description { get; set; }
    }

    public class BodyInputContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public BodyInputContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public BodyInputContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteCarePlanIdBodyInputContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public BodyInputContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public BodyInputContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class BodyInputContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteCarePlanIdBodyInputSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteCarePlanIdBodyInputPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class DeleteCarePlanIdBodyInputAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteCarePlanIdBodyInputActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public BodyInputActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public DeleteCarePlanIdBodyInputActivityTypeItemDetailType Detail { get; set; }
    }

    public class BodyInputActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteCarePlanIdBodyInputActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public DeleteCarePlanIdBodyInputActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool? DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public BodyInputActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public BodyInputActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class DeleteCarePlanIdBodyInputActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public DeleteCarePlanIdBodyInputActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteCarePlanIdBodyInputActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class BodyInputActivityTypeItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutCarePlanIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutCarePlanIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutCarePlanIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PutCarePlanIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("subject")]
        public PutCarePlanIdResponseSubjectType Subject { get; set; }

        [JsonProperty("period")]
        public PutCarePlanIdResponsePeriodType Period { get; set; }

        [JsonProperty("careTeam")]
        public PutCarePlanIdResponseCareTeamTypeItem[] CareTeam { get; set; }

        [JsonProperty("addresses")]
        public PutCarePlanIdResponseAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("goal")]
        public PutCarePlanIdResponseGoalTypeItem[] Goal { get; set; }

        [JsonProperty("activity")]
        public PutCarePlanIdResponseActivityTypeItem[] Activity { get; set; }
    }

    public class PutCarePlanIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutCarePlanIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clinicalStatus")]
        public PutCarePlanIdResponseContainedTypeItemClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PutCarePlanIdResponseContainedTypeItemVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public PutCarePlanIdResponseContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PutCarePlanIdResponseContainedTypeItemSubjectType Subject { get; set; }

        [JsonProperty("participant")]
        public PutCarePlanIdResponseContainedTypeItemParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("lifecycleStatus")]
        public string LifecycleStatus { get; set; }

        [JsonProperty("description")]
        public PutCarePlanIdResponseContainedTypeItemDescriptionType Description { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemClinicalStatusType
    {
        [JsonProperty("coding")]
        public PutCarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemVerificationStatusType
    {
        [JsonProperty("coding")]
        public PutCarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemParticipantTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("role")]
        public PutCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public PutCarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType Member { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public PutCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutCarePlanIdResponseContainedTypeItemDescriptionType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutCarePlanIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutCarePlanIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class PutCarePlanIdResponseCareTeamTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutCarePlanIdResponseAddressesTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutCarePlanIdResponseGoalTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutCarePlanIdResponseActivityTypeItem
    {
        [JsonProperty("outcomeReference")]
        public PutCarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem[] OutcomeReference { get; set; }

        [JsonProperty("detail")]
        public PutCarePlanIdResponseActivityTypeItemDetailType Detail { get; set; }
    }

    public class PutCarePlanIdResponseActivityTypeItemOutcomeReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutCarePlanIdResponseActivityTypeItemDetailType
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("code")]
        public PutCarePlanIdResponseActivityTypeItemDetailTypeCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("doNotPerform")]
        public bool DoNotPerform { get; set; }

        [JsonProperty("scheduledPeriod")]
        public PutCarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType ScheduledPeriod { get; set; }

        [JsonProperty("performer")]
        public PutCarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem[] Performer { get; set; }
    }

    public class PutCarePlanIdResponseActivityTypeItemDetailTypeCodeType
    {
        [JsonProperty("coding")]
        public PutCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutCarePlanIdResponseActivityTypeItemDetailTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutCarePlanIdResponseActivityTypeItemDetailTypeScheduledPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PutCarePlanIdResponseActivityTypeItemDetailTypePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetConditionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetConditionResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetConditionResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetConditionResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetConditionResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetConditionResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetConditionResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetConditionResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetConditionResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetConditionResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("clinicalStatus")]
        public GetConditionResponseEntryTypeItemResourceTypeClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GetConditionResponseEntryTypeItemResourceTypeVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("code")]
        public GetConditionResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetConditionResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetConditionResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }

        [JsonProperty("recordedDate")]
        public string RecordedDate { get; set; }

        [JsonProperty("abatementDateTime")]
        public string AbatementDateTime { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeClinicalStatusType
    {
        [JsonProperty("coding")]
        public GetConditionResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeVerificationStatusType
    {
        [JsonProperty("coding")]
        public GetConditionResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GetConditionResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetConditionResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetConditionResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostConditionResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostConditionResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostConditionResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public PostConditionResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PostConditionResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public PostConditionResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public PostConditionResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public PostConditionResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public PostConditionResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public PostConditionResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class PostConditionResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostConditionResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostConditionResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PostConditionResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostConditionResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostConditionResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PostConditionResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostConditionResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostConditionResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PostConditionResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostConditionResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostConditionResponseSeverityType
    {
        [JsonProperty("coding")]
        public PostConditionResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostConditionResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostConditionResponseCodeType
    {
        [JsonProperty("coding")]
        public PostConditionResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostConditionResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostConditionResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public PostConditionResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostConditionResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostConditionResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostConditionBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public DeleteAllergyIntoleranceIdBodyInputClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DeleteAllergyIntoleranceIdBodyInputVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public BodyInputSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdBodyInputCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public BodyInputBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class BodyInputBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetConditionIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetConditionIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetConditionIdResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public GetConditionIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public GetConditionIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public GetConditionIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public GetConditionIdResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public GetConditionIdResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public GetConditionIdResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public GetConditionIdResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class GetConditionIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetConditionIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetConditionIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public GetConditionIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetConditionIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetConditionIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public GetConditionIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetConditionIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetConditionIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetConditionIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetConditionIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetConditionIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public GetConditionIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetConditionIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetConditionIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GetConditionIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetConditionIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetConditionIdResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public GetConditionIdResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetConditionIdResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetConditionIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteConditionIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteConditionIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteConditionIdResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public DeleteConditionIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DeleteConditionIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public DeleteConditionIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public DeleteConditionIdResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public DeleteConditionIdResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public DeleteConditionIdResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public DeleteConditionIdResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class DeleteConditionIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteConditionIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DeleteConditionIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public DeleteConditionIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteConditionIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteConditionIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public DeleteConditionIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteConditionIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteConditionIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DeleteConditionIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteConditionIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteConditionIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public DeleteConditionIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteConditionIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteConditionIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DeleteConditionIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteConditionIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteConditionIdResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public DeleteConditionIdResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteConditionIdResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteConditionIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteConditionIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public DeleteAllergyIntoleranceIdBodyInputClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public DeleteAllergyIntoleranceIdBodyInputVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public BodyInputSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdBodyInputCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public BodyInputBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class PutConditionIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutConditionIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutConditionIdResponseTextType Text { get; set; }

        [JsonProperty("clinicalStatus")]
        public PutConditionIdResponseClinicalStatusType ClinicalStatus { get; set; }

        [JsonProperty("verificationStatus")]
        public PutConditionIdResponseVerificationStatusType VerificationStatus { get; set; }

        [JsonProperty("category")]
        public PutConditionIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("severity")]
        public PutConditionIdResponseSeverityType Severity { get; set; }

        [JsonProperty("code")]
        public PutConditionIdResponseCodeType Code { get; set; }

        [JsonProperty("bodySite")]
        public PutConditionIdResponseBodySiteTypeItem[] BodySite { get; set; }

        [JsonProperty("subject")]
        public PutConditionIdResponseSubjectType Subject { get; set; }

        [JsonProperty("onsetDateTime")]
        public string OnsetDateTime { get; set; }
    }

    public class PutConditionIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutConditionIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutConditionIdResponseClinicalStatusType
    {
        [JsonProperty("coding")]
        public PutConditionIdResponseClinicalStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutConditionIdResponseClinicalStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutConditionIdResponseVerificationStatusType
    {
        [JsonProperty("coding")]
        public PutConditionIdResponseVerificationStatusTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutConditionIdResponseVerificationStatusTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutConditionIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PutConditionIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PutConditionIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutConditionIdResponseSeverityType
    {
        [JsonProperty("coding")]
        public PutConditionIdResponseSeverityTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutConditionIdResponseSeverityTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutConditionIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PutConditionIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutConditionIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutConditionIdResponseBodySiteTypeItem
    {
        [JsonProperty("coding")]
        public PutConditionIdResponseBodySiteTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutConditionIdResponseBodySiteTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutConditionIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetDiagnosticReportResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDiagnosticReportResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetDiagnosticReportResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetDiagnosticReportResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetDiagnosticReportResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDiagnosticReportResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetDiagnosticReportResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetDiagnosticReportResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("result")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeResultTypeItem[] Result { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GetDiagnosticReportResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemResourceTypeResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDiagnosticReportResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostDiagnosticReportResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostDiagnosticReportResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostDiagnosticReportResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PostDiagnosticReportResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public PostDiagnosticReportResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PostDiagnosticReportResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PostDiagnosticReportResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PostDiagnosticReportResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PostDiagnosticReportResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public PostDiagnosticReportResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class PostDiagnosticReportResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostDiagnosticReportResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostDiagnosticReportResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PostDiagnosticReportResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostDiagnosticReportResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PostDiagnosticReportResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostDiagnosticReportResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostDiagnosticReportResponseCodeType
    {
        [JsonProperty("coding")]
        public PostDiagnosticReportResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostDiagnosticReportResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostDiagnosticReportResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostDiagnosticReportResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostDiagnosticReportResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostDiagnosticReportBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("identifier")]
        public BodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public BodyInputBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DeleteDiagnosticReportIdBodyInputCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DeleteDiagnosticReportIdBodyInputPerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public BodyInputResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class BodyInputIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteDiagnosticReportIdBodyInputPerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetDiagnosticReportIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetDiagnosticReportIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetDiagnosticReportIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public GetDiagnosticReportIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public GetDiagnosticReportIdResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetDiagnosticReportIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetDiagnosticReportIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetDiagnosticReportIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public GetDiagnosticReportIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public GetDiagnosticReportIdResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class GetDiagnosticReportIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetDiagnosticReportIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetDiagnosticReportIdResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetDiagnosticReportIdResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetDiagnosticReportIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDiagnosticReportIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GetDiagnosticReportIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetDiagnosticReportIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDiagnosticReportIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDiagnosticReportIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetDiagnosticReportIdResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteDiagnosticReportIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteDiagnosticReportIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteDiagnosticReportIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public DeleteDiagnosticReportIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public DeleteDiagnosticReportIdResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DeleteDiagnosticReportIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DeleteDiagnosticReportIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteDiagnosticReportIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DeleteDiagnosticReportIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public DeleteDiagnosticReportIdResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DeleteDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DeleteDiagnosticReportIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteDiagnosticReportIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteDiagnosticReportIdResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteDiagnosticReportIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("identifier")]
        public BodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public BodyInputBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DeleteDiagnosticReportIdBodyInputCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DeleteDiagnosticReportIdBodyInputPerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public BodyInputResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class PutDiagnosticReportIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutDiagnosticReportIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutDiagnosticReportIdResponseTextType Text { get; set; }

        [JsonProperty("identifier")]
        public PutDiagnosticReportIdResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("basedOn")]
        public PutDiagnosticReportIdResponseBasedOnTypeItem[] BasedOn { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PutDiagnosticReportIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PutDiagnosticReportIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PutDiagnosticReportIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PutDiagnosticReportIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("result")]
        public PutDiagnosticReportIdResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }
    }

    public class PutDiagnosticReportIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutDiagnosticReportIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutDiagnosticReportIdResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PutDiagnosticReportIdResponseBasedOnTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutDiagnosticReportIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PutDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PutDiagnosticReportIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutDiagnosticReportIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PutDiagnosticReportIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutDiagnosticReportIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutDiagnosticReportIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutDiagnosticReportIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutDiagnosticReportIdResponseResultTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetMedicationResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetMedicationResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetMedicationResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMedicationResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetMedicationResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetMedicationResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetMedicationResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("code")]
        public GetMedicationResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("form")]
        public GetMedicationResponseEntryTypeItemResourceTypeFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItem[] Ingredient { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeFormType
    {
        [JsonProperty("coding")]
        public GetMedicationResponseEntryTypeItemResourceTypeFormTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemResourceTypeIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostMedicationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostMedicationResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostMedicationResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PostMedicationResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public PostMedicationResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public PostMedicationResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public PostMedicationResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PostMedicationResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PostMedicationResponseBatchType Batch { get; set; }
    }

    public class PostMedicationResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostMedicationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostMedicationResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PostMedicationResponseCodeType
    {
        [JsonProperty("coding")]
        public PostMedicationResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostMedicationResponseFormType
    {
        [JsonProperty("coding")]
        public PostMedicationResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PostMedicationResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public PostMedicationResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PostMedicationResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PostMedicationResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PostMedicationResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PostMedicationResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PostMedicationResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PostMedicationBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteMedicationIdBodyInputContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public DeleteDiagnosticReportIdBodyInputCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public BodyInputManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public BodyInputFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public BodyInputIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public BodyInputBatchType Batch { get; set; }
    }

    public class DeleteMedicationIdBodyInputContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class BodyInputManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputFormType
    {
        [JsonProperty("coding")]
        public BodyInputFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public BodyInputIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool? IsActive { get; set; }

        [JsonProperty("strength")]
        public BodyInputIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class BodyInputIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public BodyInputIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public BodyInputIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public BodyInputIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class BodyInputIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GetMedicationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetMedicationIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public GetMedicationIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public GetMedicationIdResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public GetMedicationIdResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public GetMedicationIdResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GetMedicationIdResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GetMedicationIdResponseBatchType Batch { get; set; }
    }

    public class GetMedicationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetMedicationIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetMedicationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GetMedicationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationIdResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationIdResponseFormType
    {
        [JsonProperty("coding")]
        public GetMedicationIdResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationIdResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationIdResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GetMedicationIdResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public GetMedicationIdResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GetMedicationIdResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationIdResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GetMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GetMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GetMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationIdResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class DeleteMedicationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteMedicationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteMedicationIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteMedicationIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public DeleteMedicationIdResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public DeleteMedicationIdResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public DeleteMedicationIdResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public DeleteMedicationIdResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public DeleteMedicationIdResponseBatchType Batch { get; set; }
    }

    public class DeleteMedicationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteMedicationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DeleteMedicationIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DeleteMedicationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DeleteMedicationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteMedicationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationIdResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteMedicationIdResponseFormType
    {
        [JsonProperty("coding")]
        public DeleteMedicationIdResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteMedicationIdResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationIdResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public DeleteMedicationIdResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public DeleteMedicationIdResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class DeleteMedicationIdResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public DeleteMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationIdResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public DeleteMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public DeleteMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class DeleteMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteMedicationIdResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class DeleteMedicationIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteMedicationIdBodyInputContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public DeleteDiagnosticReportIdBodyInputCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public BodyInputManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public BodyInputFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public BodyInputIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public BodyInputBatchType Batch { get; set; }
    }

    public class PutMedicationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutMedicationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutMedicationIdResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PutMedicationIdResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public PutMedicationIdResponseCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public PutMedicationIdResponseManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public PutMedicationIdResponseFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PutMedicationIdResponseIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PutMedicationIdResponseBatchType Batch { get; set; }
    }

    public class PutMedicationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutMedicationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutMedicationIdResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PutMedicationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PutMedicationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationIdResponseManufacturerType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationIdResponseFormType
    {
        [JsonProperty("coding")]
        public PutMedicationIdResponseFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationIdResponseFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationIdResponseIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PutMedicationIdResponseIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("strength")]
        public PutMedicationIdResponseIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PutMedicationIdResponseIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PutMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationIdResponseIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationIdResponseIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PutMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PutMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PutMedicationIdResponseIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationIdResponseIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationIdResponseBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PutMedicationIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public PutMedicationIdBodyInputTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteMedicationIdBodyInputContainedTypeItem[] Contained { get; set; }

        [JsonProperty("code")]
        public DeleteDiagnosticReportIdBodyInputCodeType Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("manufacturer")]
        public BodyInputManufacturerType Manufacturer { get; set; }

        [JsonProperty("form")]
        public BodyInputFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public BodyInputIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public BodyInputBatchType Batch { get; set; }
    }

    public class PutMedicationIdBodyInputTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("div")]
        public string Div { get; set; }
    }

    public class GetMedicationRequestResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationRequestResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetMedicationRequestResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetMedicationRequestResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetMedicationRequestResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationRequestResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetMedicationRequestResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetMedicationRequestResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationRequestResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostMedicationRequestResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostMedicationRequestResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostMedicationRequestResponseTextType Text { get; set; }

        [JsonProperty("contained")]
        public PostMedicationRequestResponseContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public PostMedicationRequestResponseIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PostMedicationRequestResponseMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public PostMedicationRequestResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public PostMedicationRequestResponseEncounterType Encounter { get; set; }

        [JsonProperty("supportingInformation")]
        public PostMedicationRequestResponseSupportingInformationTypeItem[] SupportingInformation { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public PostMedicationRequestResponseRequesterType Requester { get; set; }

        [JsonProperty("reasonCode")]
        public PostMedicationRequestResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public PostMedicationRequestResponseNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosageInstruction")]
        public PostMedicationRequestResponseDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("dispenseRequest")]
        public PostMedicationRequestResponseDispenseRequestType DispenseRequest { get; set; }

        [JsonProperty("substitution")]
        public PostMedicationRequestResponseSubstitutionType Substitution { get; set; }
    }

    public class PostMedicationRequestResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostMedicationRequestResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostMedicationRequestResponseContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public PostMedicationRequestResponseContainedTypeItemCodeType Code { get; set; }
    }

    public class PostMedicationRequestResponseContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PostMedicationRequestResponseMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseSupportingInformationTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostMedicationRequestResponseRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public PostMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public PostMedicationRequestResponseDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("route")]
        public PostMedicationRequestResponseDosageInstructionTypeItemRouteType Route { get; set; }

        [JsonProperty("method")]
        public PostMedicationRequestResponseDosageInstructionTypeItemMethodType Method { get; set; }

        [JsonProperty("doseAndRate")]
        public PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemAdditionalInstructionTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PostMedicationRequestResponseDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemRouteType
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseDosageInstructionTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemMethodType
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseDosageInstructionTypeItemMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestResponseDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationRequestResponseDispenseRequestType
    {
        [JsonProperty("validityPeriod")]
        public PostMedicationRequestResponseDispenseRequestTypeValidityPeriodType ValidityPeriod { get; set; }

        [JsonProperty("numberOfRepeatsAllowed")]
        public int NumberOfRepeatsAllowed { get; set; }

        [JsonProperty("quantity")]
        public PostMedicationRequestResponseDispenseRequestTypeQuantityType Quantity { get; set; }

        [JsonProperty("expectedSupplyDuration")]
        public PostMedicationRequestResponseDispenseRequestTypeExpectedSupplyDurationType ExpectedSupplyDuration { get; set; }
    }

    public class PostMedicationRequestResponseDispenseRequestTypeValidityPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class PostMedicationRequestResponseDispenseRequestTypeQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationRequestResponseDispenseRequestTypeExpectedSupplyDurationType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationRequestResponseSubstitutionType
    {
        [JsonProperty("allowedBoolean")]
        public bool AllowedBoolean { get; set; }

        [JsonProperty("reason")]
        public PostMedicationRequestResponseSubstitutionTypeReasonType Reason { get; set; }
    }

    public class PostMedicationRequestResponseSubstitutionTypeReasonType
    {
        [JsonProperty("coding")]
        public PostMedicationRequestResponseSubstitutionTypeReasonTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationRequestResponseSubstitutionTypeReasonTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteMedicationRequestIdBodyInputContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public BodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PostMedicationRequestBodyInputMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public DeleteMedicationRequestIdBodyInputEncounterType Encounter { get; set; }

        [JsonProperty("supportingInformation")]
        public BodyInputSupportingInformationTypeItem[] SupportingInformation { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public BodyInputRequesterType Requester { get; set; }

        [JsonProperty("reasonCode")]
        public DeleteMedicationRequestIdBodyInputReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public BodyInputNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosageInstruction")]
        public BodyInputDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("dispenseRequest")]
        public BodyInputDispenseRequestType DispenseRequest { get; set; }

        [JsonProperty("substitution")]
        public BodyInputSubstitutionType Substitution { get; set; }
    }

    public class DeleteMedicationRequestIdBodyInputContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public DeleteMedicationRequestIdBodyInputContainedTypeItemCodeType Code { get; set; }
    }

    public class DeleteMedicationRequestIdBodyInputContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public BodyInputContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationRequestBodyInputMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public BodyInputMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationRequestIdBodyInputEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputSupportingInformationTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationRequestIdBodyInputReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public BodyInputDosageInstructionTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public BodyInputDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("route")]
        public BodyInputDosageInstructionTypeItemRouteType Route { get; set; }

        [JsonProperty("method")]
        public BodyInputDosageInstructionTypeItemMethodType Method { get; set; }

        [JsonProperty("doseAndRate")]
        public BodyInputDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputDosageInstructionTypeItemAdditionalInstructionTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemAdditionalInstructionTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public BodyInputDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int? Frequency { get; set; }

        [JsonProperty("period")]
        public int? Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemRouteType
    {
        [JsonProperty("coding")]
        public BodyInputDosageInstructionTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemMethodType
    {
        [JsonProperty("coding")]
        public BodyInputDosageInstructionTypeItemMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public BodyInputDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public BodyInputDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public BodyInputDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputDispenseRequestType
    {
        [JsonProperty("validityPeriod")]
        public BodyInputDispenseRequestTypeValidityPeriodType ValidityPeriod { get; set; }

        [JsonProperty("numberOfRepeatsAllowed")]
        public int? NumberOfRepeatsAllowed { get; set; }

        [JsonProperty("quantity")]
        public BodyInputDispenseRequestTypeQuantityType Quantity { get; set; }

        [JsonProperty("expectedSupplyDuration")]
        public BodyInputDispenseRequestTypeExpectedSupplyDurationType ExpectedSupplyDuration { get; set; }
    }

    public class BodyInputDispenseRequestTypeValidityPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class BodyInputDispenseRequestTypeQuantityType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputDispenseRequestTypeExpectedSupplyDurationType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputSubstitutionType
    {
        [JsonProperty("allowedBoolean")]
        public bool? AllowedBoolean { get; set; }

        [JsonProperty("reason")]
        public BodyInputSubstitutionTypeReasonType Reason { get; set; }
    }

    public class BodyInputSubstitutionTypeReasonType
    {
        [JsonProperty("coding")]
        public BodyInputSubstitutionTypeReasonTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputSubstitutionTypeReasonTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationRequestIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationRequestIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetMedicationRequestIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetMedicationRequestIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetMedicationRequestIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationRequestIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetMedicationRequestIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationRequestIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DeleteMedicationRequestIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteMedicationRequestIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public DeleteMedicationRequestIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public DeleteMedicationRequestIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class DeleteMedicationRequestIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteMedicationRequestIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public DeleteMedicationRequestIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteMedicationRequestIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DeleteMedicationRequestIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("contained")]
        public DeleteMedicationRequestIdBodyInputContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public BodyInputIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationReference")]
        public BodyInputMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public DeleteMedicationRequestIdBodyInputEncounterType Encounter { get; set; }

        [JsonProperty("supportingInformation")]
        public BodyInputSupportingInformationTypeItem[] SupportingInformation { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public BodyInputRequesterType Requester { get; set; }

        [JsonProperty("reasonCode")]
        public DeleteMedicationRequestIdBodyInputReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public BodyInputNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosageInstruction")]
        public BodyInputDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("dispenseRequest")]
        public BodyInputDispenseRequestType DispenseRequest { get; set; }

        [JsonProperty("substitution")]
        public BodyInputSubstitutionType Substitution { get; set; }
    }

    public class BodyInputMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationRequestIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutMedicationRequestIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public PutMedicationRequestIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public PutMedicationRequestIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class PutMedicationRequestIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutMedicationRequestIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public PutMedicationRequestIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("intent")]
        public string Intent { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("authoredOn")]
        public string AuthoredOn { get; set; }

        [JsonProperty("requester")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType Requester { get; set; }

        [JsonProperty("dosageInstruction")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem[] DosageInstruction { get; set; }

        [JsonProperty("reasonReference")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeRequesterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("timing")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType Timing { get; set; }

        [JsonProperty("doseAndRate")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeDosageInstructionTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationRequestIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GetMedicationStatementResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationStatementResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetMedicationStatementResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetMedicationStatementResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetMedicationStatementResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationStatementResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetMedicationStatementResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetMedicationStatementResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationStatementResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostMedicationStatementResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostMedicationStatementResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public PostMedicationStatementResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public PostMedicationStatementResponseEntryTypeItem[] Entry { get; set; }
    }

    public class PostMedicationStatementResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostMedicationStatementResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public PostMedicationStatementResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public PostMedicationStatementResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("coding")]
        public PostMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeMedicationCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostMedicationStatementResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class DeleteMedicationStatementIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public DeleteMedicationStatementIdBodyInputMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public BodyInputInformationSourceType InformationSource { get; set; }

        [JsonProperty("reasonReference")]
        public BodyInputReasonReferenceTypeItem[] ReasonReference { get; set; }

        [JsonProperty("note")]
        public BodyInputNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public BodyInputDosageTypeItem[] Dosage { get; set; }
    }

    public class DeleteMedicationStatementIdBodyInputMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool? AsNeededBoolean { get; set; }

        [JsonProperty("route")]
        public BodyInputDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public BodyInputDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public BodyInputDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class BodyInputDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public BodyInputDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public BodyInputDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseQuantity")]
        public BodyInputDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class BodyInputDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public BodyInputDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public BodyInputDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public BodyInputDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class BodyInputDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }
    }

    public class BodyInputDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationStatementIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetMedicationStatementIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetMedicationStatementIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetMedicationStatementIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationStatementIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetMedicationStatementIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetMedicationStatementIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PutMedicationStatementIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutMedicationStatementIdResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public PutMedicationStatementIdResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public PutMedicationStatementIdResponseEntryTypeItem[] Entry { get; set; }
    }

    public class PutMedicationStatementIdResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutMedicationStatementIdResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public PutMedicationStatementIdResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeTextType Text { get; set; }

        [JsonProperty("contained")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem[] Contained { get; set; }

        [JsonProperty("identifier")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem[] Identifier { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType Category { get; set; }

        [JsonProperty("medicationReference")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType MedicationReference { get; set; }

        [JsonProperty("subject")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("dateAsserted")]
        public string DateAsserted { get; set; }

        [JsonProperty("informationSource")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType InformationSource { get; set; }

        [JsonProperty("derivedFrom")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem[] DerivedFrom { get; set; }

        [JsonProperty("reasonCode")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("note")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem[] Note { get; set; }

        [JsonProperty("dosage")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem[] Dosage { get; set; }

        [JsonProperty("medicationCodeableConcept")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType MedicationCodeableConcept { get; set; }

        [JsonProperty("reasonReference")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItem
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType Code { get; set; }

        [JsonProperty("form")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType Form { get; set; }

        [JsonProperty("ingredient")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem[] Ingredient { get; set; }

        [JsonProperty("batch")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType Batch { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeType
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormType
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemFormTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItem
    {
        [JsonProperty("itemCodeableConcept")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType ItemCodeableConcept { get; set; }

        [JsonProperty("strength")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType Strength { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptType
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemItemCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthType
    {
        [JsonProperty("numerator")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType Denominator { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemIngredientTypeItemStrengthTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeContainedTypeItemBatchType
    {
        [JsonProperty("lotNumber")]
        public string LotNumber { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeIdentifierTypeItem
    {
        [JsonProperty("use")]
        public string Use { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryType
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeCategoryTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationReferenceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeInformationSourceType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDerivedFromTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItem
    {
        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("additionalInstruction")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem[] AdditionalInstruction { get; set; }

        [JsonProperty("timing")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType Timing { get; set; }

        [JsonProperty("asNeededCodeableConcept")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType AsNeededCodeableConcept { get; set; }

        [JsonProperty("route")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType Route { get; set; }

        [JsonProperty("doseAndRate")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem[] DoseAndRate { get; set; }

        [JsonProperty("asNeededBoolean")]
        public bool AsNeededBoolean { get; set; }

        [JsonProperty("maxDosePerPeriod")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType MaxDosePerPeriod { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAdditionalInstructionTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingType
    {
        [JsonProperty("repeat")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType Repeat { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemTimingTypeRepeatType
    {
        [JsonProperty("frequency")]
        public int Frequency { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("periodUnit")]
        public string PeriodUnit { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptType
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemAsNeededCodeableConceptTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteType
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemRouteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItem
    {
        [JsonProperty("type")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType Type { get; set; }

        [JsonProperty("doseRange")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType DoseRange { get; set; }

        [JsonProperty("doseQuantity")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType DoseQuantity { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeType
    {
        [JsonProperty("coding")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemTypeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeType
    {
        [JsonProperty("low")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType Low { get; set; }

        [JsonProperty("high")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType High { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemDoseAndRateTypeItemDoseQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodType
    {
        [JsonProperty("numerator")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType Numerator { get; set; }

        [JsonProperty("denominator")]
        public PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType Denominator { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeNumeratorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeDosageTypeItemMaxDosePerPeriodTypeDenominatorType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeMedicationCodeableConceptType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutMedicationStatementIdResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GetObservationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetObservationResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetObservationResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetObservationResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetObservationResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetObservationResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetObservationResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetObservationResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetObservationResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetObservationResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetObservationResponseEntryTypeItemResourceTypeCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetObservationResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetObservationResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetObservationResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("effectiveDateTime")]
        public string EffectiveDateTime { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("valueQuantity")]
        public GetObservationResponseEntryTypeItemResourceTypeValueQuantityType ValueQuantity { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetObservationResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GetObservationResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetObservationResponseEntryTypeItemResourceTypeValueQuantityType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetObservationResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostObservationResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostObservationResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostObservationResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PostObservationResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PostObservationResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PostObservationResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public PostObservationResponseEncounterType Encounter { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PostObservationResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public PostObservationResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public PostObservationResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public PostObservationResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public PostObservationResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public PostObservationResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class PostObservationResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostObservationResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostObservationResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PostObservationResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostObservationResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostObservationResponseCodeType
    {
        [JsonProperty("coding")]
        public PostObservationResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostObservationResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostObservationResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostObservationResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostObservationResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostObservationResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostObservationResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public PostObservationResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PostObservationResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostObservationResponseBodySiteType
    {
        [JsonProperty("coding")]
        public PostObservationResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostObservationResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostObservationResponseMethodType
    {
        [JsonProperty("coding")]
        public PostObservationResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostObservationResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostObservationResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public PostObservationResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class PostObservationResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class PostObservationBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdBodyInputCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public PostCarePlanBodyInputEncounterType Encounter { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DeleteObservationIdBodyInputPerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public BodyInputValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public BodyInputInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public BodyInputBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public DeleteObservationIdBodyInputMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public BodyInputReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class DeleteObservationIdBodyInputPerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputValueQuantityType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public BodyInputInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputBodySiteType
    {
        [JsonProperty("coding")]
        public BodyInputBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class BodyInputBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteObservationIdBodyInputMethodType
    {
        [JsonProperty("coding")]
        public DeleteObservationIdBodyInputMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteObservationIdBodyInputMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public BodyInputReferenceRangeTypeItemHighType High { get; set; }
    }

    public class BodyInputReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class GetObservationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetObservationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetObservationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public GetObservationIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public GetObservationIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetObservationIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public GetObservationIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public GetObservationIdResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public GetObservationIdResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public GetObservationIdResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public GetObservationIdResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public GetObservationIdResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class GetObservationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetObservationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetObservationIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public GetObservationIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetObservationIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetObservationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GetObservationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetObservationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetObservationIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetObservationIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetObservationIdResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetObservationIdResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public GetObservationIdResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class GetObservationIdResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetObservationIdResponseBodySiteType
    {
        [JsonProperty("coding")]
        public GetObservationIdResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetObservationIdResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetObservationIdResponseMethodType
    {
        [JsonProperty("coding")]
        public GetObservationIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetObservationIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetObservationIdResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public GetObservationIdResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class GetObservationIdResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class DeleteObservationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteObservationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteObservationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DeleteObservationIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DeleteObservationIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteObservationIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DeleteObservationIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public DeleteObservationIdResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public DeleteObservationIdResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public DeleteObservationIdResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public DeleteObservationIdResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public DeleteObservationIdResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class DeleteObservationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteObservationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DeleteObservationIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public DeleteObservationIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteObservationIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteObservationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DeleteObservationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteObservationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteObservationIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteObservationIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteObservationIdResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteObservationIdResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public DeleteObservationIdResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteObservationIdResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteObservationIdResponseBodySiteType
    {
        [JsonProperty("coding")]
        public DeleteObservationIdResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteObservationIdResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteObservationIdResponseMethodType
    {
        [JsonProperty("coding")]
        public DeleteObservationIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteObservationIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteObservationIdResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public DeleteObservationIdResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class DeleteObservationIdResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class DeleteObservationIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public DeleteAdverseEventIdBodyInputCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdBodyInputCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteCarePlanIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public DeleteObservationIdBodyInputPerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public BodyInputValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public BodyInputInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public BodyInputBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public DeleteObservationIdBodyInputMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public BodyInputReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class PutObservationIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutObservationIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutObservationIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("category")]
        public PutObservationIdResponseCategoryTypeItem[] Category { get; set; }

        [JsonProperty("code")]
        public PutObservationIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PutObservationIdResponseSubjectType Subject { get; set; }

        [JsonProperty("issued")]
        public string Issued { get; set; }

        [JsonProperty("performer")]
        public PutObservationIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("valueQuantity")]
        public PutObservationIdResponseValueQuantityType ValueQuantity { get; set; }

        [JsonProperty("interpretation")]
        public PutObservationIdResponseInterpretationTypeItem[] Interpretation { get; set; }

        [JsonProperty("bodySite")]
        public PutObservationIdResponseBodySiteType BodySite { get; set; }

        [JsonProperty("method")]
        public PutObservationIdResponseMethodType Method { get; set; }

        [JsonProperty("referenceRange")]
        public PutObservationIdResponseReferenceRangeTypeItem[] ReferenceRange { get; set; }
    }

    public class PutObservationIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutObservationIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutObservationIdResponseCategoryTypeItem
    {
        [JsonProperty("coding")]
        public PutObservationIdResponseCategoryTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PutObservationIdResponseCategoryTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutObservationIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PutObservationIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutObservationIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutObservationIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutObservationIdResponsePerformerTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutObservationIdResponseValueQuantityType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutObservationIdResponseInterpretationTypeItem
    {
        [JsonProperty("coding")]
        public PutObservationIdResponseInterpretationTypeItemCodingTypeItem[] Coding { get; set; }
    }

    public class PutObservationIdResponseInterpretationTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutObservationIdResponseBodySiteType
    {
        [JsonProperty("coding")]
        public PutObservationIdResponseBodySiteTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutObservationIdResponseBodySiteTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutObservationIdResponseMethodType
    {
        [JsonProperty("coding")]
        public PutObservationIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutObservationIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutObservationIdResponseReferenceRangeTypeItem
    {
        [JsonProperty("high")]
        public PutObservationIdResponseReferenceRangeTypeItemHighType High { get; set; }
    }

    public class PutObservationIdResponseReferenceRangeTypeItemHighType
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class GetProcedureResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetProcedureResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetProcedureResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetProcedureResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetProcedureResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetProcedureResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetProcedureResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetProcedureResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetProcedureResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetProcedureResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public GetProcedureResponseEntryTypeItemResourceTypeCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetProcedureResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetProcedureResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("performedPeriod")]
        public GetProcedureResponseEntryTypeItemResourceTypePerformedPeriodType PerformedPeriod { get; set; }

        [JsonProperty("reasonReference")]
        public GetProcedureResponseEntryTypeItemResourceTypeReasonReferenceTypeItem[] ReasonReference { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceTypeCodeType
    {
        [JsonProperty("coding")]
        public GetProcedureResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceTypeCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceTypePerformedPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemResourceTypeReasonReferenceTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetProcedureResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class PostProcedureResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostProcedureResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostProcedureResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public PostProcedureResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PostProcedureResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public PostProcedureResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public PostProcedureResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public PostProcedureResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public PostProcedureResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public PostProcedureResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public PostProcedureResponseNoteTypeItem[] Note { get; set; }
    }

    public class PostProcedureResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostProcedureResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostProcedureResponseCodeType
    {
        [JsonProperty("coding")]
        public PostProcedureResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostProcedureResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostProcedureResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostProcedureResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostProcedureResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostProcedureResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public PostProcedureResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class PostProcedureResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PostProcedureResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostProcedureResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostProcedureResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostProcedureBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdBodyInputCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public DeleteProcedureIdBodyInputRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public BodyInputAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public DeleteProcedureIdBodyInputPerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public DeleteProcedureIdBodyInputReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public BodyInputFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public BodyInputNoteTypeItem[] Note { get; set; }
    }

    public class DeleteProcedureIdBodyInputRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class BodyInputAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteProcedureIdBodyInputPerformerTypeItem
    {
        [JsonProperty("actor")]
        public BodyInputPerformerTypeItemActorType Actor { get; set; }
    }

    public class BodyInputPerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteProcedureIdBodyInputReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetProcedureIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetProcedureIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public GetProcedureIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public GetProcedureIdResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetProcedureIdResponseEncounterType Encounter { get; set; }

        [JsonProperty("performedPeriod")]
        public GetProcedureIdResponsePerformedPeriodType PerformedPeriod { get; set; }
    }

    public class GetProcedureIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetProcedureIdResponseCodeType
    {
        [JsonProperty("coding")]
        public GetProcedureIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetProcedureIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetProcedureIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetProcedureIdResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetProcedureIdResponsePerformedPeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class DeleteProcedureIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteProcedureIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteProcedureIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public DeleteProcedureIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteProcedureIdResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public DeleteProcedureIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public DeleteProcedureIdResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public DeleteProcedureIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public DeleteProcedureIdResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public DeleteProcedureIdResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public DeleteProcedureIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class DeleteProcedureIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteProcedureIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DeleteProcedureIdResponseCodeType
    {
        [JsonProperty("coding")]
        public DeleteProcedureIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteProcedureIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteProcedureIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteProcedureIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteProcedureIdResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteProcedureIdResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public DeleteProcedureIdResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class DeleteProcedureIdResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class DeleteProcedureIdResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteProcedureIdResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteProcedureIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteProcedureIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public BodyInputMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public DeleteAllergyIntoleranceIdBodyInputCodeType Code { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public DeleteProcedureIdBodyInputRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public BodyInputAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public DeleteProcedureIdBodyInputPerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public DeleteProcedureIdBodyInputReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public BodyInputFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public BodyInputNoteTypeItem[] Note { get; set; }
    }

    public class PutProcedureIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutProcedureIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutProcedureIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("code")]
        public PutProcedureIdResponseCodeType Code { get; set; }

        [JsonProperty("subject")]
        public PutProcedureIdResponseSubjectType Subject { get; set; }

        [JsonProperty("performedDateTime")]
        public string PerformedDateTime { get; set; }

        [JsonProperty("recorder")]
        public PutProcedureIdResponseRecorderType Recorder { get; set; }

        [JsonProperty("asserter")]
        public PutProcedureIdResponseAsserterType Asserter { get; set; }

        [JsonProperty("performer")]
        public PutProcedureIdResponsePerformerTypeItem[] Performer { get; set; }

        [JsonProperty("reasonCode")]
        public PutProcedureIdResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("followUp")]
        public PutProcedureIdResponseFollowUpTypeItem[] FollowUp { get; set; }

        [JsonProperty("note")]
        public PutProcedureIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class PutProcedureIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutProcedureIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutProcedureIdResponseCodeType
    {
        [JsonProperty("coding")]
        public PutProcedureIdResponseCodeTypeCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutProcedureIdResponseCodeTypeCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutProcedureIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutProcedureIdResponseRecorderType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutProcedureIdResponseAsserterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutProcedureIdResponsePerformerTypeItem
    {
        [JsonProperty("actor")]
        public PutProcedureIdResponsePerformerTypeItemActorType Actor { get; set; }
    }

    public class PutProcedureIdResponsePerformerTypeItemActorType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class PutProcedureIdResponseReasonCodeTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutProcedureIdResponseFollowUpTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutProcedureIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetRiskAssessmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetRiskAssessmentResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetRiskAssessmentResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public GetRiskAssessmentResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public GetRiskAssessmentResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public GetRiskAssessmentResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public GetRiskAssessmentResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public GetRiskAssessmentResponseNoteTypeItem[] Note { get; set; }
    }

    public class GetRiskAssessmentResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetRiskAssessmentResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetRiskAssessmentResponseMethodType
    {
        [JsonProperty("coding")]
        public GetRiskAssessmentResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetRiskAssessmentResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetRiskAssessmentResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetRiskAssessmentResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetRiskAssessmentResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public GetRiskAssessmentResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public GetRiskAssessmentResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class GetRiskAssessmentResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetRiskAssessmentResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public GetRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public GetRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class GetRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetRiskAssessmentResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostRiskAssessmentResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PostRiskAssessmentResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PostRiskAssessmentResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public PostRiskAssessmentResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public PostRiskAssessmentResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public PostRiskAssessmentResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public PostRiskAssessmentResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public PostRiskAssessmentResponseNoteTypeItem[] Note { get; set; }
    }

    public class PostRiskAssessmentResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PostRiskAssessmentResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PostRiskAssessmentResponseMethodType
    {
        [JsonProperty("coding")]
        public PostRiskAssessmentResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PostRiskAssessmentResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostRiskAssessmentResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostRiskAssessmentResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PostRiskAssessmentResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public PostRiskAssessmentResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public PostRiskAssessmentResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class PostRiskAssessmentResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PostRiskAssessmentResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public PostRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public PostRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class PostRiskAssessmentResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostRiskAssessmentResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PostRiskAssessmentResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteRiskAssessmentIdBodyInput
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public DeleteCarePlanIdBodyInputTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public DeleteRiskAssessmentIdBodyInputMethodType Method { get; set; }

        [JsonProperty("subject")]
        public DeleteAdverseEventIdBodyInputSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public BodyInputBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public BodyInputPredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public BodyInputNoteTypeItem[] Note { get; set; }
    }

    public class DeleteRiskAssessmentIdBodyInputMethodType
    {
        [JsonProperty("coding")]
        public DeleteRiskAssessmentIdBodyInputMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteRiskAssessmentIdBodyInputMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class BodyInputPredictionTypeItem
    {
        [JsonProperty("outcome")]
        public BodyInputPredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double? ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public BodyInputPredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class BodyInputPredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class BodyInputPredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public BodyInputPredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public BodyInputPredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class BodyInputPredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class BodyInputPredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetRiskAssessmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetRiskAssessmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public GetRiskAssessmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public GetRiskAssessmentIdResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public GetRiskAssessmentIdResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public GetRiskAssessmentIdResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public GetRiskAssessmentIdResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public GetRiskAssessmentIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class GetRiskAssessmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetRiskAssessmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GetRiskAssessmentIdResponseMethodType
    {
        [JsonProperty("coding")]
        public GetRiskAssessmentIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class GetRiskAssessmentIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetRiskAssessmentIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetRiskAssessmentIdResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetRiskAssessmentIdResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public GetRiskAssessmentIdResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public GetRiskAssessmentIdResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class GetRiskAssessmentIdResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetRiskAssessmentIdResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public GetRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public GetRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class GetRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class GetRiskAssessmentIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteRiskAssessmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public DeleteRiskAssessmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public DeleteRiskAssessmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public DeleteRiskAssessmentIdResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public DeleteRiskAssessmentIdResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public DeleteRiskAssessmentIdResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public DeleteRiskAssessmentIdResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public DeleteRiskAssessmentIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class DeleteRiskAssessmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class DeleteRiskAssessmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class DeleteRiskAssessmentIdResponseMethodType
    {
        [JsonProperty("coding")]
        public DeleteRiskAssessmentIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class DeleteRiskAssessmentIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteRiskAssessmentIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteRiskAssessmentIdResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class DeleteRiskAssessmentIdResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public DeleteRiskAssessmentIdResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public DeleteRiskAssessmentIdResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class DeleteRiskAssessmentIdResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class DeleteRiskAssessmentIdResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public DeleteRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public DeleteRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class DeleteRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class DeleteRiskAssessmentIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutRiskAssessmentIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public PutRiskAssessmentIdResponseMetaType Meta { get; set; }

        [JsonProperty("text")]
        public PutRiskAssessmentIdResponseTextType Text { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("method")]
        public PutRiskAssessmentIdResponseMethodType Method { get; set; }

        [JsonProperty("subject")]
        public PutRiskAssessmentIdResponseSubjectType Subject { get; set; }

        [JsonProperty("occurrenceDateTime")]
        public string OccurrenceDateTime { get; set; }

        [JsonProperty("basis")]
        public PutRiskAssessmentIdResponseBasisTypeItem[] Basis { get; set; }

        [JsonProperty("prediction")]
        public PutRiskAssessmentIdResponsePredictionTypeItem[] Prediction { get; set; }

        [JsonProperty("note")]
        public PutRiskAssessmentIdResponseNoteTypeItem[] Note { get; set; }
    }

    public class PutRiskAssessmentIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class PutRiskAssessmentIdResponseTextType
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class PutRiskAssessmentIdResponseMethodType
    {
        [JsonProperty("coding")]
        public PutRiskAssessmentIdResponseMethodTypeCodingTypeItem[] Coding { get; set; }
    }

    public class PutRiskAssessmentIdResponseMethodTypeCodingTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutRiskAssessmentIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutRiskAssessmentIdResponseBasisTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class PutRiskAssessmentIdResponsePredictionTypeItem
    {
        [JsonProperty("outcome")]
        public PutRiskAssessmentIdResponsePredictionTypeItemOutcomeType Outcome { get; set; }

        [JsonProperty("probabilityDecimal")]
        public double ProbabilityDecimal { get; set; }

        [JsonProperty("whenRange")]
        public PutRiskAssessmentIdResponsePredictionTypeItemWhenRangeType WhenRange { get; set; }
    }

    public class PutRiskAssessmentIdResponsePredictionTypeItemOutcomeType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class PutRiskAssessmentIdResponsePredictionTypeItemWhenRangeType
    {
        [JsonProperty("high")]
        public PutRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType High { get; set; }

        [JsonProperty("low")]
        public PutRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType Low { get; set; }
    }

    public class PutRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeHighType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutRiskAssessmentIdResponsePredictionTypeItemWhenRangeTypeLowType
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class PutRiskAssessmentIdResponseNoteTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCareTeamResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetCareTeamResponseMetaType Meta { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("link")]
        public GetCareTeamResponseLinkTypeItem[] Link { get; set; }

        [JsonProperty("entry")]
        public GetCareTeamResponseEntryTypeItem[] Entry { get; set; }
    }

    public class GetCareTeamResponseMetaType
    {
        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetCareTeamResponseLinkTypeItem
    {
        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItem
    {
        [JsonProperty("fullUrl")]
        public string FullUrl { get; set; }

        [JsonProperty("resource")]
        public GetCareTeamResponseEntryTypeItemResourceType Resource { get; set; }

        [JsonProperty("search")]
        public GetCareTeamResponseEntryTypeItemSearchType Search { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceType
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetCareTeamResponseEntryTypeItemResourceTypeMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public GetCareTeamResponseEntryTypeItemResourceTypeSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetCareTeamResponseEntryTypeItemResourceTypeEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GetCareTeamResponseEntryTypeItemResourceTypePeriodType Period { get; set; }

        [JsonProperty("participant")]
        public GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("reasonCode")]
        public GetCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("managingOrganization")]
        public GetCareTeamResponseEntryTypeItemResourceTypeManagingOrganizationTypeItem[] ManagingOrganization { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItem
    {
        [JsonProperty("role")]
        public GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemMemberType Member { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GetCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemResourceTypeManagingOrganizationTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCareTeamResponseEntryTypeItemSearchType
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class GetCareTeamIdResponse
    {
        [JsonProperty("resourceType")]
        public string ResourceType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("meta")]
        public GetCareTeamIdResponseMetaType Meta { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subject")]
        public GetCareTeamIdResponseSubjectType Subject { get; set; }

        [JsonProperty("encounter")]
        public GetCareTeamIdResponseEncounterType Encounter { get; set; }

        [JsonProperty("period")]
        public GetCareTeamIdResponsePeriodType Period { get; set; }

        [JsonProperty("participant")]
        public GetCareTeamIdResponseParticipantTypeItem[] Participant { get; set; }

        [JsonProperty("reasonCode")]
        public GetCareTeamIdResponseReasonCodeTypeItem[] ReasonCode { get; set; }

        [JsonProperty("managingOrganization")]
        public GetCareTeamIdResponseManagingOrganizationTypeItem[] ManagingOrganization { get; set; }
    }

    public class GetCareTeamIdResponseMetaType
    {
        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("lastUpdated")]
        public string LastUpdated { get; set; }
    }

    public class GetCareTeamIdResponseSubjectType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCareTeamIdResponseEncounterType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }

    public class GetCareTeamIdResponsePeriodType
    {
        [JsonProperty("start")]
        public string Start { get; set; }
    }

    public class GetCareTeamIdResponseParticipantTypeItem
    {
        [JsonProperty("role")]
        public GetCareTeamIdResponseParticipantTypeItemRoleTypeItem[] Role { get; set; }

        [JsonProperty("member")]
        public GetCareTeamIdResponseParticipantTypeItemMemberType Member { get; set; }
    }

    public class GetCareTeamIdResponseParticipantTypeItemRoleTypeItem
    {
        [JsonProperty("coding")]
        public GetCareTeamIdResponseParticipantTypeItemRoleTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCareTeamIdResponseParticipantTypeItemRoleTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCareTeamIdResponseParticipantTypeItemMemberType
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCareTeamIdResponseReasonCodeTypeItem
    {
        [JsonProperty("coding")]
        public GetCareTeamIdResponseReasonCodeTypeItemCodingTypeItem[] Coding { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetCareTeamIdResponseReasonCodeTypeItemCodingTypeItem
    {
        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }

    public class GetCareTeamIdResponseManagingOrganizationTypeItem
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("display")]
        public string Display { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fhirclinical;

    public partial class WorkflowManagedActions
    {
        public FhirclinicalActions Fhirclinical(string connectionId) => new FhirclinicalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FhirclinicalTriggers Fhirclinical(string connectionId) => new FhirclinicalTriggers(connectionId);
    }
}