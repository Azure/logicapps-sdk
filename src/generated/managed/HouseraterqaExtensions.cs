//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Houseraterqa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HouseraterqaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "houseraterqa")]
        public IBodyWorkflowAction<JToken> UpdateInspection([WorkflowExpression] Func<string> bodyinspectionTemplateId, [WorkflowExpression] Func<string> bodybuilderId, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string[]> bodyprograms = null, [WorkflowExpression] Func<string[]> bodyraters = null, [WorkflowExpression] Func<string> bodysharePointSubscriberId = null, [WorkflowExpression] Func<string> bodyoutlookEventId = null, [WorkflowExpression] Func<string> bodyaddress1 = null, [WorkflowExpression] Func<string> bodyaddress2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzip = null, [WorkflowExpression] Func<string> bodytimeZone = null)
        {
            SourceExpression.Validate(bodyinspectionTemplateId, nameof(bodyinspectionTemplateId), required: true);
            SourceExpression.Validate(bodybuilderId, nameof(bodybuilderId), required: true);
            SourceExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            SourceExpression.Validate(bodyendTime, nameof(bodyendTime), required: true);
            SourceExpression.Validate(bodyprograms, nameof(bodyprograms), required: false);
            SourceExpression.Validate(bodyraters, nameof(bodyraters), required: false);
            SourceExpression.Validate(bodysharePointSubscriberId, nameof(bodysharePointSubscriberId), required: false);
            SourceExpression.Validate(bodyoutlookEventId, nameof(bodyoutlookEventId), required: false);
            SourceExpression.Validate(bodyaddress1, nameof(bodyaddress1), required: false);
            SourceExpression.Validate(bodyaddress2, nameof(bodyaddress2), required: false);
            SourceExpression.Validate(bodycity, nameof(bodycity), required: false);
            SourceExpression.Validate(bodystate, nameof(bodystate), required: false);
            SourceExpression.Validate(bodyzip, nameof(bodyzip), required: false);
            SourceExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/updateInspection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inspectionTemplateId"] = SourceExpressionConverter.ConvertToken(bodyinspectionTemplateId);
                bodypropCount++;
                body["builderId"] = SourceExpressionConverter.ConvertToken(bodybuilderId);
                if (bodyprograms != null)
                {
                    body["programs"] = SourceExpressionConverter.ConvertToken(bodyprograms);
                    bodypropCount++;
                }

                if (bodyraters != null)
                {
                    body["raters"] = SourceExpressionConverter.ConvertToken(bodyraters);
                    bodypropCount++;
                }

                if (bodysharePointSubscriberId != null)
                {
                    body["sharePointSubscriberId"] = SourceExpressionConverter.ConvertToken(bodysharePointSubscriberId);
                    bodypropCount++;
                }

                if (bodyoutlookEventId != null)
                {
                    body["outlookEventId"] = SourceExpressionConverter.ConvertToken(bodyoutlookEventId);
                    bodypropCount++;
                }

                if (bodyaddress1 != null)
                {
                    body["address1"] = SourceExpressionConverter.ConvertToken(bodyaddress1);
                    bodypropCount++;
                }

                if (bodyaddress2 != null)
                {
                    body["address2"] = SourceExpressionConverter.ConvertToken(bodyaddress2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodyzip != null)
                {
                    body["zip"] = SourceExpressionConverter.ConvertToken(bodyzip);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startTime"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
                body["endTime"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                if (bodytimeZone != null)
                {
                    body["timeZone"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class HouseraterqaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InspectionStatusChange(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/createWebhook/onSVStatusChange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackURL"] = "@listCallbackUrl()";
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
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Houseraterqa;

    public partial class WorkflowManagedActions
    {
        public HouseraterqaActions Houseraterqa(string connectionId) => new HouseraterqaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HouseraterqaTriggers Houseraterqa(string connectionId) => new HouseraterqaTriggers(connectionId);
    }
}