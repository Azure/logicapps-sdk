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
        public IWorkflowAction ValidateNotification([WorkflowExpression] Func<string> xZipSignature, [WorkflowExpression] Func<string> bodypayload)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<StaticResponseWriteSchema> AmendObject([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<entityInput> entity, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<StaticResponseWriteSchema>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<JToken> GetZellisObjects([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> entity, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> select = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<StaticResponseWriteSchema> UpdateObject([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<entityInput> entity, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/{0}", ExpressionConverter.ConvertWithUrlEncoding(entity, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<StaticResponseWriteSchema>(callPayload);
        }
    }

    public class ZellisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CRUDEntitiy([WorkflowExpression] Func<string> bodyevent, [WorkflowExpression] Func<bool> bodyisEnabled, [WorkflowExpression] Func<bool> bodyeventTypecreate = null, [WorkflowExpression] Func<bool> bodyeventTypedelete = null, [WorkflowExpression] Func<bool> bodyeventTypeupdate = null, string triggerName = null, FlowRecurrence recurrence = null)
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
            body["URL"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
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