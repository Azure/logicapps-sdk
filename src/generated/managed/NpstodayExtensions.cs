//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Npstoday
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NpstodayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "npstoday")]
        public IWorkflowAction SendSurvey(Expression<Func<string>> campaign, Expression<Func<string>> bodyrespondentemailAddress = null, Expression<Func<string>> bodyrespondentfirstName = null, Expression<Func<string>> bodyrespondentlastName = null, Expression<Func<string>> bodyrespondentphoneNumber = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/respondent", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaign, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var respondentObject = new JObject();
            var respondentObjectpropCount = 0;
            if (bodyrespondentemailAddress != null)
            {
                respondentObject["emailAddress"] = CSharpExpressionConverter.ConvertToken(bodyrespondentemailAddress);
                respondentObjectpropCount++;
            }

            if (bodyrespondentfirstName != null)
            {
                respondentObject["firstName"] = CSharpExpressionConverter.ConvertToken(bodyrespondentfirstName);
                respondentObjectpropCount++;
            }

            if (bodyrespondentlastName != null)
            {
                respondentObject["lastName"] = CSharpExpressionConverter.ConvertToken(bodyrespondentlastName);
                respondentObjectpropCount++;
            }

            if (bodyrespondentphoneNumber != null)
            {
                respondentObject["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyrespondentphoneNumber);
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
        public IWorkflowAction AddEmployee(Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyteam = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<bool>> bodyactive = null)
        {
            var apiCallPath = "/profile/employees";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["firstName"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["lastName"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = CSharpExpressionConverter.ConvertToken(bodydepartment);
                bodypropCount++;
            }

            if (bodyteam != null)
            {
                body["team"] = CSharpExpressionConverter.ConvertToken(bodyteam);
                bodypropCount++;
            }

            if (bodydivision != null)
            {
                body["division"] = CSharpExpressionConverter.ConvertToken(bodydivision);
                bodypropCount++;
            }

            if (bodyphoneNumber != null)
            {
                body["phoneNumber"] = CSharpExpressionConverter.ConvertToken(bodyphoneNumber);
                bodypropCount++;
            }

            if (bodyactive != null)
            {
                body["active"] = CSharpExpressionConverter.ConvertToken(bodyactive);
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
        public IBodyWorkflowTrigger<JToken> NewResponse(Expression<Func<int>> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscriptions/responses";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaignId != null)
            {
                body["campaignId"] = CSharpExpressionConverter.ConvertToken(bodycampaignId);
                bodypropCount++;
            }

            body["targetUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            body["eventType"] = "NewResponse";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> NewCampaignMember(Expression<Func<int>> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/webhooks/subscriptions/campaignmembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycampaignId != null)
            {
                body["campaignId"] = CSharpExpressionConverter.ConvertToken(bodycampaignId);
                bodypropCount++;
            }

            body["targetUrl"] = "@listCallbackUrl()";
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