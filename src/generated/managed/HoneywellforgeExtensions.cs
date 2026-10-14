//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Honeywellforge
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HoneywellforgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        public IBodyWorkflowAction<CloseCaseResponse> CloseServiceCaseAtForge(Expression<Func<string>> projectId, Expression<Func<string>> serviceCaseNumber, Expression<Func<string>> bodysiteId, Expression<Func<string>> bodyresolutionText, Expression<Func<string>> bodyworkOrderIDs = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyresolutionCode = null, Expression<Func<string>> bodyrootCauseCode = null, Expression<Func<int>> bodyserviceCaseClosedOn = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_serviceCaseNumber = serviceCaseNumber == null ? null : WorkflowExpression.Compile(serviceCaseNumber);
            WorkflowExpression.Validate(__workflow_serviceCaseNumber, nameof(serviceCaseNumber), required: true);
            var __workflow_bodysiteId = bodysiteId == null ? null : WorkflowExpression.Compile(bodysiteId);
            WorkflowExpression.Validate(__workflow_bodysiteId, nameof(bodysiteId), required: true);
            var __workflow_bodyresolutionText = bodyresolutionText == null ? null : WorkflowExpression.Compile(bodyresolutionText);
            WorkflowExpression.Validate(__workflow_bodyresolutionText, nameof(bodyresolutionText), required: true);
            var __workflow_bodyworkOrderIDs = bodyworkOrderIDs == null ? null : WorkflowExpression.Compile(bodyworkOrderIDs);
            WorkflowExpression.Validate(__workflow_bodyworkOrderIDs, nameof(bodyworkOrderIDs), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyresolutionCode = bodyresolutionCode == null ? null : WorkflowExpression.Compile(bodyresolutionCode);
            WorkflowExpression.Validate(__workflow_bodyresolutionCode, nameof(bodyresolutionCode), required: false);
            var __workflow_bodyrootCauseCode = bodyrootCauseCode == null ? null : WorkflowExpression.Compile(bodyrootCauseCode);
            WorkflowExpression.Validate(__workflow_bodyrootCauseCode, nameof(bodyrootCauseCode), required: false);
            var __workflow_bodyserviceCaseClosedOn = bodyserviceCaseClosedOn == null ? null : WorkflowExpression.Compile(bodyserviceCaseClosedOn);
            WorkflowExpression.Validate(__workflow_bodyserviceCaseClosedOn, nameof(bodyserviceCaseClosedOn), required: false);
            return new DeferredBodyAction<CloseCaseResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/service-cases/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_serviceCaseNumber, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["siteId"] = ExpressionConverter.ConvertO(__workflow_bodysiteId);
                body["status"] = "Closed";
                bodypropCount++;
                if (__workflow_bodyworkOrderIDs != null)
                {
                    body["workOrderIDs"] = ExpressionConverter.ConvertO(__workflow_bodyworkOrderIDs);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    if (__workflow_bodypriority != null)
                    {
                        body["priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
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
                body["resolutionText"] = ExpressionConverter.ConvertO(__workflow_bodyresolutionText);
                if (__workflow_bodyresolutionCode != null)
                {
                    body["resolutionCode"] = ExpressionConverter.ConvertO(__workflow_bodyresolutionCode);
                    bodypropCount++;
                }

                if (__workflow_bodyrootCauseCode != null)
                {
                    body["rootCauseCode"] = ExpressionConverter.ConvertO(__workflow_bodyrootCauseCode);
                    bodypropCount++;
                }

                if (__workflow_bodyserviceCaseClosedOn != null)
                {
                    body["serviceCaseClosedOn"] = ExpressionConverter.ConvertO(__workflow_bodyserviceCaseClosedOn);
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
        public IWorkflowAction SendEventToForge(Expression<Func<string>> projectId, Expression<Func<string>> bodyeventName, Expression<Func<string>> bodyeventType, Expression<Func<string>> bodymessage, Expression<Func<string>> bodycorrelationID, Expression<Func<string>> bodysource, Expression<Func<string>> bodyconnectorID = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_bodyeventName = bodyeventName == null ? null : WorkflowExpression.Compile(bodyeventName);
            WorkflowExpression.Validate(__workflow_bodyeventName, nameof(bodyeventName), required: true);
            var __workflow_bodyeventType = bodyeventType == null ? null : WorkflowExpression.Compile(bodyeventType);
            WorkflowExpression.Validate(__workflow_bodyeventType, nameof(bodyeventType), required: true);
            var __workflow_bodymessage = bodymessage == null ? null : WorkflowExpression.Compile(bodymessage);
            WorkflowExpression.Validate(__workflow_bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodycorrelationID = bodycorrelationID == null ? null : WorkflowExpression.Compile(bodycorrelationID);
            WorkflowExpression.Validate(__workflow_bodycorrelationID, nameof(bodycorrelationID), required: true);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: true);
            var __workflow_bodyconnectorID = bodyconnectorID == null ? null : WorkflowExpression.Compile(bodyconnectorID);
            WorkflowExpression.Validate(__workflow_bodyconnectorID, nameof(bodyconnectorID), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/transactionEvent", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = ExpressionConverter.ConvertO(__workflow_bodyeventName);
                bodypropCount++;
                body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                bodypropCount++;
                body["corelationId"] = ExpressionConverter.ConvertO(__workflow_bodycorrelationID);
                if (__workflow_bodyconnectorID != null)
                {
                    body["connectorId"] = ExpressionConverter.ConvertO(__workflow_bodyconnectorID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
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
        public IWorkflowTrigger ServiceCaseCreated(Expression<Func<string>> projectId, Expression<Func<string>> connectorId, FlowRecurrence recurrence = null)
        {
            var __workflow_projectId = projectId == null ? null : WorkflowExpression.Compile(projectId);
            WorkflowExpression.Validate(__workflow_projectId, nameof(projectId), required: true);
            var __workflow_connectorId = connectorId == null ? null : WorkflowExpression.Compile(connectorId);
            WorkflowExpression.Validate(__workflow_connectorId, nameof(connectorId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/projects/{0}/webhooks/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_connectorId, 1));
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
