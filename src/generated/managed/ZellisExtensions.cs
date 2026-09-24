//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zellis
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZellisActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IWorkflowAction ValidateNotification([WorkflowExpression] Func<string> xZipSignature, [WorkflowExpression] Func<string> bodypayload)
        {
            SourceExpression.Validate(xZipSignature, nameof(xZipSignature), required: true);
            SourceExpression.Validate(bodypayload, nameof(bodypayload), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ValidateNotification";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Zip-Signature"] = SourceExpressionConverter.ConvertO(xZipSignature);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["payload"] = SourceExpressionConverter.ConvertToken(bodypayload);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<StaticResponseWriteSchema> AmendObject([WorkflowExpression] Func<entityInput> entity, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<StaticResponseWriteSchema>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<JToken> GetZellisObjects([WorkflowExpression] Func<string> entity, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<string> top = null, [WorkflowExpression] Func<string> skiptoken = null, [WorkflowExpression] Func<string> select = null)
        {
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(expand, nameof(expand), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skiptoken, nameof(skiptoken), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (expand != null)
                    callPayload.Queries["$expand"] = SourceExpressionConverter.ConvertO(expand);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skiptoken != null)
                    callPayload.Queries["$skiptoken"] = SourceExpressionConverter.ConvertO(skiptoken);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zellis")]
        public IBodyWorkflowAction<StaticResponseWriteSchema> UpdateObject([WorkflowExpression] Func<entityInput> entity, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(entity, nameof(entity), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entity, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<StaticResponseWriteSchema>(BuildSourceInput);
        }
    }

    public class ZellisTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> CRUDEntitiy([WorkflowExpression] Func<string> bodyevent, [WorkflowExpression] Func<bool> bodyisEnabled, [WorkflowExpression] Func<bool> bodyeventTypecreate = null, [WorkflowExpression] Func<bool> bodyeventTypedelete = null, [WorkflowExpression] Func<bool> bodyeventTypeupdate = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyevent, nameof(bodyevent), required: true);
            SourceExpression.Validate(bodyisEnabled, nameof(bodyisEnabled), required: true);
            SourceExpression.Validate(bodyeventTypecreate, nameof(bodyeventTypecreate), required: false);
            SourceExpression.Validate(bodyeventTypedelete, nameof(bodyeventTypedelete), required: false);
            SourceExpression.Validate(bodyeventTypeupdate, nameof(bodyeventTypeupdate), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/subscription";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Event"] = SourceExpressionConverter.ConvertToken(bodyevent);
                var eventTypeObject = new JObject();
                var eventTypeObjectpropCount = 0;
                if (bodyeventTypecreate != null)
                {
                    if (bodyeventTypecreate != null)
                    {
                        eventTypeObject["Create"] = SourceExpressionConverter.ConvertToken(bodyeventTypecreate);
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
                        eventTypeObject["Delete"] = SourceExpressionConverter.ConvertToken(bodyeventTypedelete);
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
                        eventTypeObject["Update"] = SourceExpressionConverter.ConvertToken(bodyeventTypeupdate);
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
                body["IsEnabled"] = SourceExpressionConverter.ConvertToken(bodyisEnabled);
                body["URL"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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