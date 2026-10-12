//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zellis
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZellisActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        [WorkflowExpressionFactory(nameof(__BuildValidateNotification))]
        public IWorkflowAction ValidateNotification([WorkflowExpression] Func<string> xZipSignature, [WorkflowExpression] Func<string> bodypayload)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildValidateNotification(WorkflowExpression<string> xZipSignature, WorkflowExpression<string> bodypayload)
        {
            WorkflowExpression.Validate(xZipSignature, nameof(xZipSignature), required: true);
            WorkflowExpression.Validate(bodypayload, nameof(bodypayload), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/ValidateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Zip-Signature"] = ExpressionConverter.Convert(xZipSignature);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["payload"] = ExpressionConverter.ConvertO(bodypayload);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        [WorkflowExpressionFactory(nameof(__BuildAmendObject))]
        public IBodyWorkflowAction<StaticResponseWriteSchema> AmendObject([WorkflowExpression] Func<entityInput> entity, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StaticResponseWriteSchema> __BuildAmendObject(WorkflowExpression<entityInput> entity, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<StaticResponseWriteSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<StaticResponseWriteSchema>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        [WorkflowExpressionFactory(nameof(__BuildGetZellisObjects))]
        public IBodyWorkflowAction<JToken> GetZellisObjects([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> select = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetZellisObjects(WorkflowExpression<string> entity, WorkflowExpression<string> filter = null, WorkflowExpression<string> expand = null, WorkflowExpression<string> orderby = null, WorkflowExpression<string> top = null, WorkflowExpression<string> skiptoken = null, WorkflowExpression<string> select = null)
        {
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = ExpressionConverter.Convert(skiptoken);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateObject))]
        public IBodyWorkflowAction<StaticResponseWriteSchema> UpdateObject([WorkflowExpression] Func<entityInput> entity, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StaticResponseWriteSchema> __BuildUpdateObject(WorkflowExpression<entityInput> entity, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(entity, nameof(entity), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<StaticResponseWriteSchema>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}", ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<StaticResponseWriteSchema>(callPayload);
            });
        }
    }

    public class ZellisTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCRUDEntitiy))]
        public IBodyWorkflowTrigger<JToken> CRUDEntitiy([WorkflowExpression] Func<string> bodyevent,[WorkflowExpression] Func<bool> bodyisEnabled,[WorkflowExpression] Func<bool> bodyeventTypecreate = null,[WorkflowExpression] Func<bool> bodyeventTypedelete = null,[WorkflowExpression] Func<bool> bodyeventTypeupdate = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildCRUDEntitiy(WorkflowExpression<string> bodyevent,WorkflowExpression<bool> bodyisEnabled,WorkflowExpression<bool> bodyeventTypecreate = null,WorkflowExpression<bool> bodyeventTypedelete = null,WorkflowExpression<bool> bodyeventTypeupdate = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyevent, nameof(bodyevent), required: true);
            WorkflowExpression.Validate(bodyisEnabled, nameof(bodyisEnabled), required: true);
            WorkflowExpression.Validate(bodyeventTypecreate, nameof(bodyeventTypecreate), required: false);
            WorkflowExpression.Validate(bodyeventTypedelete, nameof(bodyeventTypedelete), required: false);
            WorkflowExpression.Validate(bodyeventTypeupdate, nameof(bodyeventTypeupdate), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/v1/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Event"] = ExpressionConverter.ConvertO(bodyevent);
                var eventTypeObject = new JObject();
                var eventTypeObjectpropCount = 0;
                if (bodyeventTypecreate != null)
                {
                    if (bodyeventTypecreate != null)
                    {
                        eventTypeObject["Create"] = ExpressionConverter.ConvertO(bodyeventTypecreate);
                        eventTypeObjectpropCount++;
                    }

                    eventTypeObjectpropCount++;
                }
                else
                {
                    eventTypeObject["Create"] = true;
                    eventTypeObjectpropCount++;
                }

                if (bodyeventTypedelete != null)
                {
                    if (bodyeventTypedelete != null)
                    {
                        eventTypeObject["Delete"] = ExpressionConverter.ConvertO(bodyeventTypedelete);
                        eventTypeObjectpropCount++;
                    }

                    eventTypeObjectpropCount++;
                }
                else
                {
                    eventTypeObject["Delete"] = false;
                    eventTypeObjectpropCount++;
                }

                if (bodyeventTypeupdate != null)
                {
                    if (bodyeventTypeupdate != null)
                    {
                        eventTypeObject["Update"] = ExpressionConverter.ConvertO(bodyeventTypeupdate);
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
                body["IsEnabled"] = ExpressionConverter.ConvertO(bodyisEnabled);
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