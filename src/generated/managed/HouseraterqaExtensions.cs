//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Houseraterqa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HouseraterqaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "houseraterqa")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateInspection))]
        public IBodyWorkflowAction<JToken> UpdateInspection([WorkflowExpression] Func<string> bodyinspectionTemplateId, [WorkflowExpression] Func<string> bodybuilderId, [WorkflowExpression] Func<string> bodystartTime, [WorkflowExpression] Func<string> bodyendTime, [WorkflowExpression] Func<string[]> bodyprograms = null, [WorkflowExpression] Func<string[]> bodyraters = null, [WorkflowExpression] Func<string> bodysharePointSubscriberId = null, [WorkflowExpression] Func<string> bodyoutlookEventId = null, [WorkflowExpression] Func<string> bodyaddress1 = null, [WorkflowExpression] Func<string> bodyaddress2 = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodyzip = null, [WorkflowExpression] Func<string> bodytimeZone = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "houseraterqa")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateInspection(WorkflowExpression<string> bodyinspectionTemplateId, WorkflowExpression<string> bodybuilderId, WorkflowExpression<string> bodystartTime, WorkflowExpression<string> bodyendTime, WorkflowExpression<string[]> bodyprograms = null, WorkflowExpression<string[]> bodyraters = null, WorkflowExpression<string> bodysharePointSubscriberId = null, WorkflowExpression<string> bodyoutlookEventId = null, WorkflowExpression<string> bodyaddress1 = null, WorkflowExpression<string> bodyaddress2 = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodystate = null, WorkflowExpression<string> bodyzip = null, WorkflowExpression<string> bodytimeZone = null)
        {
            WorkflowExpression.Validate(bodyinspectionTemplateId, nameof(bodyinspectionTemplateId), required: true);
            WorkflowExpression.Validate(bodybuilderId, nameof(bodybuilderId), required: true);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: true);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: true);
            WorkflowExpression.Validate(bodyprograms, nameof(bodyprograms), required: false);
            WorkflowExpression.Validate(bodyraters, nameof(bodyraters), required: false);
            WorkflowExpression.Validate(bodysharePointSubscriberId, nameof(bodysharePointSubscriberId), required: false);
            WorkflowExpression.Validate(bodyoutlookEventId, nameof(bodyoutlookEventId), required: false);
            WorkflowExpression.Validate(bodyaddress1, nameof(bodyaddress1), required: false);
            WorkflowExpression.Validate(bodyaddress2, nameof(bodyaddress2), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodystate, nameof(bodystate), required: false);
            WorkflowExpression.Validate(bodyzip, nameof(bodyzip), required: false);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/updateInspection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inspectionTemplateId"] = ExpressionConverter.ConvertO(bodyinspectionTemplateId);
                bodypropCount++;
                body["builderId"] = ExpressionConverter.ConvertO(bodybuilderId);
                if (bodyprograms != null)
                {
                    body["programs"] = ExpressionConverter.ConvertO(bodyprograms);
                    bodypropCount++;
                }

                if (bodyraters != null)
                {
                    body["raters"] = ExpressionConverter.ConvertO(bodyraters);
                    bodypropCount++;
                }

                if (bodysharePointSubscriberId != null)
                {
                    body["sharePointSubscriberId"] = ExpressionConverter.ConvertO(bodysharePointSubscriberId);
                    bodypropCount++;
                }

                if (bodyoutlookEventId != null)
                {
                    body["outlookEventId"] = ExpressionConverter.ConvertO(bodyoutlookEventId);
                    bodypropCount++;
                }

                if (bodyaddress1 != null)
                {
                    body["address1"] = ExpressionConverter.ConvertO(bodyaddress1);
                    bodypropCount++;
                }

                if (bodyaddress2 != null)
                {
                    body["address2"] = ExpressionConverter.ConvertO(bodyaddress2);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(bodystate);
                    bodypropCount++;
                }

                if (bodyzip != null)
                {
                    body["zip"] = ExpressionConverter.ConvertO(bodyzip);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(bodyendTime);
                if (bodytimeZone != null)
                {
                    body["timeZone"] = ExpressionConverter.ConvertO(bodytimeZone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class HouseraterqaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InspectionStatusChange(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/createWebhook/onSVStatusChange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackURL"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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