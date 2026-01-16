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
            var apiCallPath = String.Format("/projects/{0}/service-cases/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(serviceCaseNumber, 1));
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
                body["priority"] = ExpressionConverter.ConvertO(bodypriority);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        public IWorkflowAction SendEventToForge(Expression<Func<string>> projectId, Expression<Func<string>> bodyeventName, Expression<Func<string>> bodyeventType, Expression<Func<string>> bodymessage, Expression<Func<string>> bodycorrelationID, Expression<Func<string>> bodysource, Expression<Func<string>> bodyconnectorID = null)
        {
            var apiCallPath = String.Format("/projects/{0}/transactionEvent", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1));
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
        }
    }

    public class HoneywellforgeTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ServiceCaseCreated(Expression<Func<string>> projectId, Expression<Func<string>> connectorId, string triggerName = null)
        {
            var apiCallPath = String.Format("/projects/{0}/webhooks/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(connectorId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
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