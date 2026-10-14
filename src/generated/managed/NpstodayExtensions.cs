//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Npstoday
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NpstodayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "npstoday")]
        public IWorkflowAction SendSurvey(Expression<Func<string>> campaign, Expression<Func<string>> bodyrespondentemailAddress = null, Expression<Func<string>> bodyrespondentfirstName = null, Expression<Func<string>> bodyrespondentlastName = null, Expression<Func<string>> bodyrespondentphoneNumber = null)
        {
            var __workflow_campaign = campaign == null ? null : WorkflowExpression.Compile(campaign);
            WorkflowExpression.Validate(__workflow_campaign, nameof(campaign), required: true);
            var __workflow_bodyrespondentemailAddress = bodyrespondentemailAddress == null ? null : WorkflowExpression.Compile(bodyrespondentemailAddress);
            WorkflowExpression.Validate(__workflow_bodyrespondentemailAddress, nameof(bodyrespondentemailAddress), required: false);
            var __workflow_bodyrespondentfirstName = bodyrespondentfirstName == null ? null : WorkflowExpression.Compile(bodyrespondentfirstName);
            WorkflowExpression.Validate(__workflow_bodyrespondentfirstName, nameof(bodyrespondentfirstName), required: false);
            var __workflow_bodyrespondentlastName = bodyrespondentlastName == null ? null : WorkflowExpression.Compile(bodyrespondentlastName);
            WorkflowExpression.Validate(__workflow_bodyrespondentlastName, nameof(bodyrespondentlastName), required: false);
            var __workflow_bodyrespondentphoneNumber = bodyrespondentphoneNumber == null ? null : WorkflowExpression.Compile(bodyrespondentphoneNumber);
            WorkflowExpression.Validate(__workflow_bodyrespondentphoneNumber, nameof(bodyrespondentphoneNumber), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/respondent", ExpressionConverter.ConvertWithUrlEncoding(__workflow_campaign, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var respondentObject = new JObject();
                var respondentObjectpropCount = 0;
                if (__workflow_bodyrespondentemailAddress != null)
                {
                    respondentObject["emailAddress"] = ExpressionConverter.ConvertO(__workflow_bodyrespondentemailAddress);
                    respondentObjectpropCount++;
                }

                if (__workflow_bodyrespondentfirstName != null)
                {
                    respondentObject["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyrespondentfirstName);
                    respondentObjectpropCount++;
                }

                if (__workflow_bodyrespondentlastName != null)
                {
                    respondentObject["lastName"] = ExpressionConverter.ConvertO(__workflow_bodyrespondentlastName);
                    respondentObjectpropCount++;
                }

                if (__workflow_bodyrespondentphoneNumber != null)
                {
                    respondentObject["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyrespondentphoneNumber);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "npstoday")]
        public IWorkflowAction AddEmployee(Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyteam = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<bool>> bodyactive = null)
        {
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = bodyfirstName == null ? null : WorkflowExpression.Compile(bodyfirstName);
            WorkflowExpression.Validate(__workflow_bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = bodylastName == null ? null : WorkflowExpression.Compile(bodylastName);
            WorkflowExpression.Validate(__workflow_bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydepartment = bodydepartment == null ? null : WorkflowExpression.Compile(bodydepartment);
            WorkflowExpression.Validate(__workflow_bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyteam = bodyteam == null ? null : WorkflowExpression.Compile(bodyteam);
            WorkflowExpression.Validate(__workflow_bodyteam, nameof(bodyteam), required: false);
            var __workflow_bodydivision = bodydivision == null ? null : WorkflowExpression.Compile(bodydivision);
            WorkflowExpression.Validate(__workflow_bodydivision, nameof(bodydivision), required: false);
            var __workflow_bodyphoneNumber = bodyphoneNumber == null ? null : WorkflowExpression.Compile(bodyphoneNumber);
            WorkflowExpression.Validate(__workflow_bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyactive = bodyactive == null ? null : WorkflowExpression.Compile(bodyactive);
            WorkflowExpression.Validate(__workflow_bodyactive, nameof(bodyactive), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/profile/employees";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["firstName"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["lastName"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodytitle != null)
                {
                    body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydepartment != null)
                {
                    body["department"] = ExpressionConverter.ConvertO(__workflow_bodydepartment);
                    bodypropCount++;
                }

                if (__workflow_bodyteam != null)
                {
                    body["team"] = ExpressionConverter.ConvertO(__workflow_bodyteam);
                    bodypropCount++;
                }

                if (__workflow_bodydivision != null)
                {
                    body["division"] = ExpressionConverter.ConvertO(__workflow_bodydivision);
                    bodypropCount++;
                }

                if (__workflow_bodyphoneNumber != null)
                {
                    body["phoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodyphoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyactive != null)
                {
                    body["active"] = ExpressionConverter.ConvertO(__workflow_bodyactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class NpstodayTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> NewResponse(Expression<Func<int>> bodycampaignId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycampaignId = bodycampaignId == null ? null : WorkflowExpression.Compile(bodycampaignId);
            WorkflowExpression.Validate(__workflow_bodycampaignId, nameof(bodycampaignId), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/webhooks/subscriptions/responses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycampaignId != null)
                {
                    body["campaignId"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> NewCampaignMember(Expression<Func<int>> bodycampaignId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycampaignId = bodycampaignId == null ? null : WorkflowExpression.Compile(bodycampaignId);
            WorkflowExpression.Validate(__workflow_bodycampaignId, nameof(bodycampaignId), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = "/webhooks/subscriptions/campaignmembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycampaignId != null)
                {
                    body["campaignId"] = ExpressionConverter.ConvertO(__workflow_bodycampaignId);
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
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
