//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zellis
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZellisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ValidateNotification(Expression<Func<string>> xZipSignature, Expression<Func<string>> bodypayload)
        {
            var __workflow_xZipSignature = WorkflowExpression.Compile(xZipSignature, nameof(xZipSignature), required: true);
            var __workflow_bodypayload = WorkflowExpression.Compile(bodypayload, nameof(bodypayload), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ValidateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Zip-Signature"] = ExpressionConverter.Convert(__workflow_xZipSignature);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["payload"] = ExpressionConverter.ConvertO(__workflow_bodypayload);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<StaticResponseWriteSchema, ApiConnectionActionConfiguration> AmendObject(Expression<Func<entityInput>> entity, Expression<Func<object>> body = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StaticResponseWriteSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_entity.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StaticResponseWriteSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> GetZellisObjects(Expression<Func<string>> entity, Expression<Func<string>> filter = null, Expression<Func<string>> expand = null, Expression<Func<string>> orderby = null, Expression<Func<string>> top = null, Expression<Func<string>> skiptoken = null, Expression<Func<string>> select = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skiptoken = WorkflowExpression.Compile(skiptoken, nameof(skiptoken), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_entity.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(__workflow_expand);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(__workflow_skiptoken);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<StaticResponseWriteSchema, ApiConnectionActionConfiguration> UpdateObject(Expression<Func<entityInput>> entity, Expression<Func<object>> body = null)
        {
            var __workflow_entity = WorkflowExpression.Compile(entity, nameof(entity), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<StaticResponseWriteSchema, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_entity.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<StaticResponseWriteSchema>(callPayload);
            });
        }
    }

    public class ZellisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> CRUDEntitiy(Expression<Func<string>> bodyEvent, Expression<Func<bool>> bodyisEnabled, Expression<Func<bool>> bodyeventTypecreate = null, Expression<Func<bool>> bodyeventTypedelete = null, Expression<Func<bool>> bodyeventTypeupdate = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyEvent = WorkflowExpression.Compile(bodyEvent, nameof(bodyEvent), required: true);
            var __workflow_bodyisEnabled = WorkflowExpression.Compile(bodyisEnabled, nameof(bodyisEnabled), required: true);
            var __workflow_bodyeventTypecreate = WorkflowExpression.Compile(bodyeventTypecreate, nameof(bodyeventTypecreate), required: false);
            var __workflow_bodyeventTypedelete = WorkflowExpression.Compile(bodyeventTypedelete, nameof(bodyeventTypedelete), required: false);
            var __workflow_bodyeventTypeupdate = WorkflowExpression.Compile(bodyeventTypeupdate, nameof(bodyeventTypeupdate), required: false);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v1/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Event"] = ExpressionConverter.ConvertO(__workflow_bodyEvent);
                var eventTypeObject = new JObject();
                var eventTypeObjectpropCount = 0;
                if (__workflow_bodyeventTypecreate != null)
                {
                    if (__workflow_bodyeventTypecreate != null)
                    {
                        eventTypeObject["Create"] = ExpressionConverter.ConvertO(__workflow_bodyeventTypecreate);
                        eventTypeObjectpropCount++;
                    }

                    eventTypeObjectpropCount++;
                }
                else
                {
                    eventTypeObject["Create"] = true;
                    eventTypeObjectpropCount++;
                }

                if (__workflow_bodyeventTypedelete != null)
                {
                    if (__workflow_bodyeventTypedelete != null)
                    {
                        eventTypeObject["Delete"] = ExpressionConverter.ConvertO(__workflow_bodyeventTypedelete);
                        eventTypeObjectpropCount++;
                    }

                    eventTypeObjectpropCount++;
                }
                else
                {
                    eventTypeObject["Delete"] = false;
                    eventTypeObjectpropCount++;
                }

                if (__workflow_bodyeventTypeupdate != null)
                {
                    if (__workflow_bodyeventTypeupdate != null)
                    {
                        eventTypeObject["Update"] = ExpressionConverter.ConvertO(__workflow_bodyeventTypeupdate);
                        eventTypeObjectpropCount++;
                    }

                    eventTypeObjectpropCount++;
                }
                else
                {
                    eventTypeObject["Update"] = true;
                    eventTypeObjectpropCount++;
                }

                if (eventTypeObjectpropCount > 0)
                {
                    body["EventType"] = eventTypeObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["IsEnabled"] = ExpressionConverter.ConvertO(__workflow_bodyisEnabled);
                body["URL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class StaticResponseWriteSchema
    {
        [JsonProperty("payload")]
        public StaticResponseWriteSchemaPayloadType Payload { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("errors")]
        public StaticResponseWriteSchemaErrorsTypeItem[] Errors { get; set; }

        [JsonProperty("processingStatus")]
        public StaticResponseWriteSchemaProcessingStatusType ProcessingStatus { get; set; }

        [JsonProperty("worker")]
        public StaticResponseWriteSchemaWorkerType Worker { get; set; }
    }

    public class StaticResponseWriteSchemaPayloadType
    {
        [JsonProperty("timeTaken")]
        public string TimeTaken { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
    }

    public class StaticResponseWriteSchemaErrorsTypeItem
    {
        [JsonProperty("errorType")]
        public string ErrorType { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class StaticResponseWriteSchemaProcessingStatusType
    {
        [JsonProperty("success")]
        public string Success { get; set; }
    }

    public class StaticResponseWriteSchemaWorkerType
    {
        [JsonProperty("workerNumber")]
        public string WorkerNumber { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum entityInput
    {
        AbsenceDailyDetails,
        AbsenceHeaders,
        BankAccounts,
        CostCentres,
        CostCentreSplits,
        FixedPayElements,
        Grades,
        Jobs,
        Locations,
        OperatorMessage,
        ParentalLeaveKITDays,
        Posts,
        ProspectiveWorkers,
        SharedParentalLeave,
        StructureUnit,
        TemporaryPayElements,
        UserDefinedFields,
        WorkerAttainments,
        WorkerDrivingLicences,
        WorkPatterns,
        Workers,
        WorkerNICategories,
        WorkerPRSIDetails,
        WorkerParentalLeave,
        WorkerPassportVisas,
        WorkerPensionSchemes,
        WorkerPosts,
        WorkerRelationships,
        WorkerTaxCodeHistories,
        WorkerUSCDetails
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zellis;

    public partial class WorkflowManagedActions
    {
        public ZellisActions Zellis(string connectionId) => new ZellisActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZellisTriggers Zellis(string connectionId) => new ZellisTriggers(connectionId);
    }
}