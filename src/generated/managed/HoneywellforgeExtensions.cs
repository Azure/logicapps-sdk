//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Honeywellforge
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HoneywellforgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        [WorkflowExpressionFactory(nameof(__BuildCloseServiceCaseAtForge))]
        public IBodyWorkflowAction<CloseCaseResponse> CloseServiceCaseAtForge([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> serviceCaseNumber, [WorkflowExpression] Func<string> bodysiteId, [WorkflowExpression] Func<string> bodyresolutionText, [WorkflowExpression] Func<string> bodyworkOrderIDs = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyresolutionCode = null, [WorkflowExpression] Func<string> bodyrootCauseCode = null, [WorkflowExpression] Func<int> bodyserviceCaseClosedOn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CloseCaseResponse> __BuildCloseServiceCaseAtForge(WorkflowValue<string> projectId, WorkflowValue<string> serviceCaseNumber, WorkflowValue<string> bodysiteId, WorkflowValue<string> bodyresolutionText, WorkflowValue<string> bodyworkOrderIDs = null, WorkflowValue<string> bodypriority = null, WorkflowValue<string> bodyresolutionCode = null, WorkflowValue<string> bodyrootCauseCode = null, WorkflowValue<int> bodyserviceCaseClosedOn = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(serviceCaseNumber, nameof(serviceCaseNumber), required: true);
            WorkflowValue.Validate(bodysiteId, nameof(bodysiteId), required: true);
            WorkflowValue.Validate(bodyresolutionText, nameof(bodyresolutionText), required: true);
            WorkflowValue.Validate(bodyworkOrderIDs, nameof(bodyworkOrderIDs), required: false);
            WorkflowValue.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowValue.Validate(bodyresolutionCode, nameof(bodyresolutionCode), required: false);
            WorkflowValue.Validate(bodyrootCauseCode, nameof(bodyrootCauseCode), required: false);
            WorkflowValue.Validate(bodyserviceCaseClosedOn, nameof(bodyserviceCaseClosedOn), required: false);
            return new DeferredBodyAction<CloseCaseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/service-cases/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(serviceCaseNumber, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["siteId"] = ExpressionConverter.ConvertO(bodysiteId);
                body["status"] = "Closed";
                bodypropCount++;
                if (bodyworkOrderIDs != null)
                {
                    body["workOrderIDs"] = ExpressionConverter.ConvertO(bodyworkOrderIDs);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    if (bodypriority != null)
                    {
                        body["priority"] = ExpressionConverter.ConvertO(bodypriority);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["priority"] = "Medium";
                    bodypropCount++;
                }

                bodypropCount++;
                body["resolutionText"] = ExpressionConverter.ConvertO(bodyresolutionText);
                if (bodyresolutionCode != null)
                {
                    body["resolutionCode"] = ExpressionConverter.ConvertO(bodyresolutionCode);
                    bodypropCount++;
                }

                if (bodyrootCauseCode != null)
                {
                    body["rootCauseCode"] = ExpressionConverter.ConvertO(bodyrootCauseCode);
                    bodypropCount++;
                }

                if (bodyserviceCaseClosedOn != null)
                {
                    body["serviceCaseClosedOn"] = ExpressionConverter.ConvertO(bodyserviceCaseClosedOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CloseCaseResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        [WorkflowExpressionFactory(nameof(__BuildSendEventToForge))]
        public IWorkflowAction SendEventToForge([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodyeventName, [WorkflowExpression] Func<string> bodyeventType, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodycorrelationID, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodyconnectorID = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEventToForge(WorkflowValue<string> projectId, WorkflowValue<string> bodyeventName, WorkflowValue<string> bodyeventType, WorkflowValue<string> bodymessage, WorkflowValue<string> bodycorrelationID, WorkflowValue<string> bodysource, WorkflowValue<string> bodyconnectorID = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(bodyeventName, nameof(bodyeventName), required: true);
            WorkflowValue.Validate(bodyeventType, nameof(bodyeventType), required: true);
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowValue.Validate(bodycorrelationID, nameof(bodycorrelationID), required: true);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: true);
            WorkflowValue.Validate(bodyconnectorID, nameof(bodyconnectorID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/transactionEvent", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(bodyeventName);
                bodypropCount++;
                body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(bodymessage);
                bodypropCount++;
                body["corelationId"] = ExpressionConverter.ConvertO(bodycorrelationID);
                if (bodyconnectorID != null)
                {
                    body["connectorId"] = ExpressionConverter.ConvertO(bodyconnectorID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["source"] = ExpressionConverter.ConvertO(bodysource);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class HoneywellforgeTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildServiceCaseCreated))]
        public IWorkflowTrigger ServiceCaseCreated([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> connectorId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildServiceCaseCreated(WorkflowValue<string> projectId, WorkflowValue<string> connectorId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(projectId, nameof(projectId), required: true);
            WorkflowValue.Validate(connectorId, nameof(connectorId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/webhooks/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(connectorId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class CloseCaseResponse
    {
        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Honeywellforge;

    public partial class WorkflowManagedActions
    {
        public HoneywellforgeActions Honeywellforge(string connectionId) => new HoneywellforgeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HoneywellforgeTriggers Honeywellforge(string connectionId) => new HoneywellforgeTriggers(connectionId);
    }
}
