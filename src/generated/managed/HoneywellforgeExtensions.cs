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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CloseCaseResponse> __BuildCloseServiceCaseAtForge(WorkflowExpression<string> projectId, WorkflowExpression<string> serviceCaseNumber, WorkflowExpression<string> bodysiteId, WorkflowExpression<string> bodyresolutionText, WorkflowExpression<string> bodyworkOrderIDs = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodyresolutionCode = null, WorkflowExpression<string> bodyrootCauseCode = null, WorkflowExpression<int> bodyserviceCaseClosedOn = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(serviceCaseNumber, nameof(serviceCaseNumber), required: true);
            WorkflowExpression.Validate(bodysiteId, nameof(bodysiteId), required: true);
            WorkflowExpression.Validate(bodyresolutionText, nameof(bodyresolutionText), required: true);
            WorkflowExpression.Validate(bodyworkOrderIDs, nameof(bodyworkOrderIDs), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyresolutionCode, nameof(bodyresolutionCode), required: false);
            WorkflowExpression.Validate(bodyrootCauseCode, nameof(bodyrootCauseCode), required: false);
            WorkflowExpression.Validate(bodyserviceCaseClosedOn, nameof(bodyserviceCaseClosedOn), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendEventToForge(WorkflowExpression<string> projectId, WorkflowExpression<string> bodyeventName, WorkflowExpression<string> bodyeventType, WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodycorrelationID, WorkflowExpression<string> bodysource, WorkflowExpression<string> bodyconnectorID = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(bodyeventName, nameof(bodyeventName), required: true);
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: true);
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodycorrelationID, nameof(bodycorrelationID), required: true);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: true);
            WorkflowExpression.Validate(bodyconnectorID, nameof(bodyconnectorID), required: false);
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
        public IWorkflowTrigger ServiceCaseCreated([WorkflowExpression] Func<string> projectId,[WorkflowExpression] Func<string> connectorId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildServiceCaseCreated(WorkflowExpression<string> projectId,WorkflowExpression<string> connectorId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(projectId, nameof(projectId), required: true);
            WorkflowExpression.Validate(connectorId, nameof(connectorId), required: true);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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