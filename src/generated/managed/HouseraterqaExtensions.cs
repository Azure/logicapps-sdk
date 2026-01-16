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
        public IBodyWorkflowAction<JToken> UpdateInspection(Expression<Func<string>> bodyinspectionTemplateId, Expression<Func<string>> bodybuilderId, Expression<Func<string>> bodystartTime, Expression<Func<string>> bodyendTime, Expression<Func<string[]>> bodyprograms = null, Expression<Func<string[]>> bodyraters = null, Expression<Func<string>> bodysharePointSubscriberId = null, Expression<Func<string>> bodyoutlookEventId = null, Expression<Func<string>> bodyaddress1 = null, Expression<Func<string>> bodyaddress2 = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodyzip = null, Expression<Func<string>> bodytimeZone = null)
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
        }
    }

    public class HouseraterqaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger InspectionStatusChange()
        {
            var apiCallPath = "/createWebhook/onSVStatusChange";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackURL"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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