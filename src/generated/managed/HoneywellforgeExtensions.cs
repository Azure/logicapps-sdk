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
        public IBodyWorkflowAction<CloseCaseResponse> CloseServiceCaseAtForge([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> serviceCaseNumber, [WorkflowExpression] Func<string> bodysiteId, [WorkflowExpression] Func<string> bodyresolutionText, [WorkflowExpression] Func<string> bodyworkOrderIDs = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyresolutionCode = null, [WorkflowExpression] Func<string> bodyrootCauseCode = null, [WorkflowExpression] Func<int> bodyserviceCaseClosedOn = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(serviceCaseNumber, nameof(serviceCaseNumber), required: true);
            SourceExpression.Validate(bodysiteId, nameof(bodysiteId), required: true);
            SourceExpression.Validate(bodyresolutionText, nameof(bodyresolutionText), required: true);
            SourceExpression.Validate(bodyworkOrderIDs, nameof(bodyworkOrderIDs), required: false);
            SourceExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            SourceExpression.Validate(bodyresolutionCode, nameof(bodyresolutionCode), required: false);
            SourceExpression.Validate(bodyrootCauseCode, nameof(bodyrootCauseCode), required: false);
            SourceExpression.Validate(bodyserviceCaseClosedOn, nameof(bodyserviceCaseClosedOn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/service-cases/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(serviceCaseNumber, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["siteId"] = SourceExpressionConverter.ConvertToken(bodysiteId);
                body["status"] = "Closed";
                bodypropCount++;
                if (bodyworkOrderIDs != null)
                {
                    body["workOrderIDs"] = SourceExpressionConverter.ConvertToken(bodyworkOrderIDs);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    if (bodypriority != null)
                    {
                        body["priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
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
                body["resolutionText"] = SourceExpressionConverter.ConvertToken(bodyresolutionText);
                if (bodyresolutionCode != null)
                {
                    body["resolutionCode"] = SourceExpressionConverter.ConvertToken(bodyresolutionCode);
                    bodypropCount++;
                }

                if (bodyrootCauseCode != null)
                {
                    body["rootCauseCode"] = SourceExpressionConverter.ConvertToken(bodyrootCauseCode);
                    bodypropCount++;
                }

                if (bodyserviceCaseClosedOn != null)
                {
                    body["serviceCaseClosedOn"] = SourceExpressionConverter.ConvertToken(bodyserviceCaseClosedOn);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseCaseResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "honeywellforge")]
        public IWorkflowAction SendEventToForge([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> bodyeventName, [WorkflowExpression] Func<string> bodyeventType, [WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodycorrelationID, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodyconnectorID = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(bodyeventName, nameof(bodyeventName), required: true);
            SourceExpression.Validate(bodyeventType, nameof(bodyeventType), required: true);
            SourceExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            SourceExpression.Validate(bodycorrelationID, nameof(bodycorrelationID), required: true);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: true);
            SourceExpression.Validate(bodyconnectorID, nameof(bodyconnectorID), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/transactionEvent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["event"] = SourceExpressionConverter.ConvertToken(bodyeventName);
                bodypropCount++;
                body["eventType"] = SourceExpressionConverter.ConvertToken(bodyeventType);
                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                bodypropCount++;
                body["corelationId"] = SourceExpressionConverter.ConvertToken(bodycorrelationID);
                if (bodyconnectorID != null)
                {
                    body["connectorId"] = SourceExpressionConverter.ConvertToken(bodyconnectorID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class HoneywellforgeTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ServiceCaseCreated([WorkflowExpression] Func<string> projectId, [WorkflowExpression] Func<string> connectorId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(projectId, nameof(projectId), required: true);
            SourceExpression.Validate(connectorId, nameof(connectorId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/webhooks/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(connectorId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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