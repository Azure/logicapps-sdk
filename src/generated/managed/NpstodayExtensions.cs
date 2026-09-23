//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Npstoday
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NpstodayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "npstoday")]
        public IWorkflowAction SendSurvey([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> campaign, [WorkflowExpression] Func<string> bodyrespondentemailAddress = null, [WorkflowExpression] Func<string> bodyrespondentfirstName = null, [WorkflowExpression] Func<string> bodyrespondentlastName = null, [WorkflowExpression] Func<string> bodyrespondentphoneNumber = null)
        {
            var apiCallPath = String.Format("/campaigns/{0}/respondent", ExpressionConverter.ConvertWithUrlEncoding(campaign, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var respondentObject = new JObject();
            var respondentObjectpropCount = 0;
            if (bodyrespondentemailAddress != null)
            {
                respondentObject["emailAddress"] = ExpressionConverter.ConvertO(bodyrespondentemailAddress);
                respondentObjectpropCount++;
            }

            if (bodyrespondentfirstName != null)
            {
                respondentObject["firstName"] = ExpressionConverter.ConvertO(bodyrespondentfirstName);
                respondentObjectpropCount++;
            }

            if (bodyrespondentlastName != null)
            {
                respondentObject["lastName"] = ExpressionConverter.ConvertO(bodyrespondentlastName);
                respondentObjectpropCount++;
            }

            if (bodyrespondentphoneNumber != null)
            {
                respondentObject["phoneNumber"] = ExpressionConverter.ConvertO(bodyrespondentphoneNumber);
                respondentObjectpropCount++;
            }

            if (respondentObjectpropCount > 0)
            {
                body["respondent"] = respondentObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "npstoday")]
        public IWorkflowAction AddEmployee([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyteam = null, [WorkflowExpression] Func<string> bodydivision = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<bool> bodyactive = null)
        {
            var apiCallPath = "/profile/employees";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodyteam != null)
            {
                body["team"] = ExpressionConverter.ConvertO(bodyteam);
                bodypropCount++;
            }

            if (bodydivision != null)
            {
                body["division"] = ExpressionConverter.ConvertO(bodydivision);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phoneNumber"] = ExpressionConverter.ConvertO(bodyphoneNumber);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = ExpressionConverter.ConvertO(bodyactive);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class NpstodayTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> NewResponse([WorkflowExpression] Func<int> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscriptions/responses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaignId != null)
            {
                body["campaignId"] = ExpressionConverter.ConvertO(bodycampaignId);
                bodypropCount++;
            }

            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            body["eventType"] = "NewResponse";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> NewCampaignMember([WorkflowExpression] Func<int> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscriptions/campaignmembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaignId != null)
            {
                body["campaignId"] = ExpressionConverter.ConvertO(bodycampaignId);
                bodypropCount++;
            }

            body["targetUrl"] = "#{listCallbackUrl()}";
            bodypropCount++;
            body["eventType"] = "NewCampaignMember";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Npstoday;

    public partial class WorkflowManagedActions
    {
        public NpstodayActions Npstoday(string connectionId) => new NpstodayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NpstodayTriggers Npstoday(string connectionId) => new NpstodayTriggers(connectionId);
    }
}