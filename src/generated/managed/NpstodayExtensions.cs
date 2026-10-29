//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Npstoday
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NpstodayActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "npstoday")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendSurvey(Expression<Func<string>> campaign, Expression<Func<string>> bodyrespondentemailAddress = null, Expression<Func<string>> bodyrespondentfirstName = null, Expression<Func<string>> bodyrespondentlastName = null, Expression<Func<string>> bodyrespondentphoneNumber = null)
        {
            var __workflow_campaign = WorkflowExpression.Compile(campaign, nameof(campaign), required: true);
            var __workflow_bodyrespondentemailAddress = WorkflowExpression.Compile(bodyrespondentemailAddress, nameof(bodyrespondentemailAddress), required: false);
            var __workflow_bodyrespondentfirstName = WorkflowExpression.Compile(bodyrespondentfirstName, nameof(bodyrespondentfirstName), required: false);
            var __workflow_bodyrespondentlastName = WorkflowExpression.Compile(bodyrespondentlastName, nameof(bodyrespondentlastName), required: false);
            var __workflow_bodyrespondentphoneNumber = WorkflowExpression.Compile(bodyrespondentphoneNumber, nameof(bodyrespondentphoneNumber), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/campaigns/{0}/respondent", __workflow_campaign.WithUrlEncoding(1)));
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
        public IWorkflowAction<ApiConnectionActionConfiguration> AddEmployee(Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyteam = null, Expression<Func<string>> bodydivision = null, Expression<Func<string>> bodyphoneNumber = null, Expression<Func<bool>> bodyactive = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydepartment = WorkflowExpression.Compile(bodydepartment, nameof(bodydepartment), required: false);
            var __workflow_bodyteam = WorkflowExpression.Compile(bodyteam, nameof(bodyteam), required: false);
            var __workflow_bodydivision = WorkflowExpression.Compile(bodydivision, nameof(bodydivision), required: false);
            var __workflow_bodyphoneNumber = WorkflowExpression.Compile(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            var __workflow_bodyactive = WorkflowExpression.Compile(bodyactive, nameof(bodyactive), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> NewResponse(Expression<Func<int>> bodycampaignId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
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

        public IBodyWorkflowTrigger<JToken, ApiConnectionTriggerConfiguration> NewCampaignMember(Expression<Func<int>> bodycampaignId = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodycampaignId = WorkflowExpression.Compile(bodycampaignId, nameof(bodycampaignId), required: false);
            return new DeferredBodyTrigger<JToken, ApiConnectionTriggerConfiguration>(() =>
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