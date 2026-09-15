//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Honeywellforge
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HoneywellforgeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        public IBodyWorkflowAction<CloseCaseResponse> CloseServiceCaseAtForge(Expression<Func<string>> projectId, Expression<Func<string>> serviceCaseNumber, Expression<Func<string>> bodysiteId, Expression<Func<string>> bodyresolutionText, Expression<Func<string>> bodyworkOrderIDs = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyresolutionCode = null, Expression<Func<string>> bodyrootCauseCode = null, Expression<Func<int>> bodyserviceCaseClosedOn = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/projects/{0}/service-cases/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(serviceCaseNumber, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["siteId"] = CSharpExpressionConverter.ConvertToken(bodysiteId);
            body["status"] = "Closed";
            bodypropCount++;
            if (bodyworkOrderIDs != null)
            {
                body["workOrderIDs"] = CSharpExpressionConverter.ConvertToken(bodyworkOrderIDs);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                if (bodypriority != null)
                {
                    body["priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
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
            body["resolutionText"] = CSharpExpressionConverter.ConvertToken(bodyresolutionText);
            if (bodyresolutionCode != null)
            {
                body["resolutionCode"] = CSharpExpressionConverter.ConvertToken(bodyresolutionCode);
                bodypropCount++;
            }

            if (bodyrootCauseCode != null)
            {
                body["rootCauseCode"] = CSharpExpressionConverter.ConvertToken(bodyrootCauseCode);
                bodypropCount++;
            }

            if (bodyserviceCaseClosedOn != null)
            {
                body["serviceCaseClosedOn"] = CSharpExpressionConverter.ConvertToken(bodyserviceCaseClosedOn);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CloseCaseResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        public IWorkflowAction SendEventToForge(Expression<Func<string>> projectId, Expression<Func<string>> bodyeventName, Expression<Func<string>> bodyeventType, Expression<Func<string>> bodymessage, Expression<Func<string>> bodycorrelationID, Expression<Func<string>> bodysource, Expression<Func<string>> bodyconnectorID = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/projects/{0}/transactionEvent", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["event"] = CSharpExpressionConverter.ConvertToken(bodyeventName);
            bodypropCount++;
            body["eventType"] = CSharpExpressionConverter.ConvertToken(bodyeventType);
            bodypropCount++;
            body["message"] = CSharpExpressionConverter.ConvertToken(bodymessage);
            bodypropCount++;
            body["corelationId"] = CSharpExpressionConverter.ConvertToken(bodycorrelationID);
            if (bodyconnectorID != null)
            {
                body["connectorId"] = CSharpExpressionConverter.ConvertToken(bodyconnectorID);
                bodypropCount++;
            }

            bodypropCount++;
            body["source"] = CSharpExpressionConverter.ConvertToken(bodysource);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class HoneywellforgeTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ServiceCaseCreated(Expression<Func<string>> projectId, Expression<Func<string>> connectorId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/projects/{0}/webhooks/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(connectorId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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