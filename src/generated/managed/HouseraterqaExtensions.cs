//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Houseraterqa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class HouseraterqaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "houseraterqa")]
        public IBodyWorkflowAction<JToken> UpdateInspection(Expression<Func<string>> bodyinspectionTemplateId, Expression<Func<string>> bodybuilderId, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<string[]>> bodyprograms = null, Expression<Func<string[]>> bodyraters = null, Expression<Func<string>> bodysharePointSubscriberId = null, Expression<Func<string>> bodyoutlookEventId = null, Expression<Func<string>> bodyaddress1 = null, Expression<Func<string>> bodyaddress2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzip = null, Expression<Func<string>> bodytimeZone = null)
        {
            var __workflow_bodyinspectionTemplateId = bodyinspectionTemplateId == null ? null : WorkflowExpression.Compile(bodyinspectionTemplateId);
            WorkflowExpression.Validate(__workflow_bodyinspectionTemplateId, nameof(bodyinspectionTemplateId), required: true);
            var __workflow_bodybuilderId = bodybuilderId == null ? null : WorkflowExpression.Compile(bodybuilderId);
            WorkflowExpression.Validate(__workflow_bodybuilderId, nameof(bodybuilderId), required: true);
            var __workflow_bodystartTime = bodystartTime == null ? null : WorkflowExpression.Compile(bodystartTime);
            WorkflowExpression.Validate(__workflow_bodystartTime, nameof(bodystartTime), required: true);
            var __workflow_bodyendTime = bodyendTime == null ? null : WorkflowExpression.Compile(bodyendTime);
            WorkflowExpression.Validate(__workflow_bodyendTime, nameof(bodyendTime), required: true);
            var __workflow_bodyprograms = bodyprograms == null ? null : WorkflowExpression.Compile(bodyprograms);
            WorkflowExpression.Validate(__workflow_bodyprograms, nameof(bodyprograms), required: false);
            var __workflow_bodyraters = bodyraters == null ? null : WorkflowExpression.Compile(bodyraters);
            WorkflowExpression.Validate(__workflow_bodyraters, nameof(bodyraters), required: false);
            var __workflow_bodysharePointSubscriberId = bodysharePointSubscriberId == null ? null : WorkflowExpression.Compile(bodysharePointSubscriberId);
            WorkflowExpression.Validate(__workflow_bodysharePointSubscriberId, nameof(bodysharePointSubscriberId), required: false);
            var __workflow_bodyoutlookEventId = bodyoutlookEventId == null ? null : WorkflowExpression.Compile(bodyoutlookEventId);
            WorkflowExpression.Validate(__workflow_bodyoutlookEventId, nameof(bodyoutlookEventId), required: false);
            var __workflow_bodyaddress1 = bodyaddress1 == null ? null : WorkflowExpression.Compile(bodyaddress1);
            WorkflowExpression.Validate(__workflow_bodyaddress1, nameof(bodyaddress1), required: false);
            var __workflow_bodyaddress2 = bodyaddress2 == null ? null : WorkflowExpression.Compile(bodyaddress2);
            WorkflowExpression.Validate(__workflow_bodyaddress2, nameof(bodyaddress2), required: false);
            var __workflow_bodycity = bodycity == null ? null : WorkflowExpression.Compile(bodycity);
            WorkflowExpression.Validate(__workflow_bodycity, nameof(bodycity), required: false);
            var __workflow_bodystate = bodystate == null ? null : WorkflowExpression.Compile(bodystate);
            WorkflowExpression.Validate(__workflow_bodystate, nameof(bodystate), required: false);
            var __workflow_bodyzip = bodyzip == null ? null : WorkflowExpression.Compile(bodyzip);
            WorkflowExpression.Validate(__workflow_bodyzip, nameof(bodyzip), required: false);
            var __workflow_bodytimeZone = bodytimeZone == null ? null : WorkflowExpression.Compile(bodytimeZone);
            WorkflowExpression.Validate(__workflow_bodytimeZone, nameof(bodytimeZone), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/updateInspection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["inspectionTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyinspectionTemplateId);
                bodypropCount++;
                body["builderId"] = ExpressionConverter.ConvertO(__workflow_bodybuilderId);
                if (__workflow_bodyprograms != null)
                {
                    body["programs"] = ExpressionConverter.ConvertO(__workflow_bodyprograms);
                    bodypropCount++;
                }

                if (__workflow_bodyraters != null)
                {
                    body["raters"] = ExpressionConverter.ConvertO(__workflow_bodyraters);
                    bodypropCount++;
                }

                if (__workflow_bodysharePointSubscriberId != null)
                {
                    body["sharePointSubscriberId"] = ExpressionConverter.ConvertO(__workflow_bodysharePointSubscriberId);
                    bodypropCount++;
                }

                if (__workflow_bodyoutlookEventId != null)
                {
                    body["outlookEventId"] = ExpressionConverter.ConvertO(__workflow_bodyoutlookEventId);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress1 != null)
                {
                    body["address1"] = ExpressionConverter.ConvertO(__workflow_bodyaddress1);
                    bodypropCount++;
                }

                if (__workflow_bodyaddress2 != null)
                {
                    body["address2"] = ExpressionConverter.ConvertO(__workflow_bodyaddress2);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodystate != null)
                {
                    body["state"] = ExpressionConverter.ConvertO(__workflow_bodystate);
                    bodypropCount++;
                }

                if (__workflow_bodyzip != null)
                {
                    body["zip"] = ExpressionConverter.ConvertO(__workflow_bodyzip);
                    bodypropCount++;
                }

                bodypropCount++;
                body["startTime"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                bodypropCount++;
                body["endTime"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                if (__workflow_bodytimeZone != null)
                {
                    body["timeZone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
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
        public IWorkflowTrigger InspectionStatusChange(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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
