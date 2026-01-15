//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Npstoday
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
        public IOutputWorkflowTrigger<JToken> NewResponse(Expression<Func<int>> bodycampaignId = null)
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

            body["targetUrl"] = "@listcallbackurl()";
            bodypropCount++;
            body["eventType"] = "NewResponse";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }

        public IOutputWorkflowTrigger<JToken> NewCampaignMember(Expression<Func<int>> bodycampaignId = null)
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

            body["targetUrl"] = "@listcallbackurl()";
            bodypropCount++;
            body["eventType"] = "NewCampaignMember";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Npstoday;

    public partial class WorkflowManagedActions
    {
        public NpstodayActions Npstoday(string connectionId) => new NpstodayActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NpstodayTriggers Npstoday(string connectionId) => new NpstodayTriggers(connectionId);
    }
}