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
        [WorkflowExpressionFactory(nameof(__BuildSendSurvey))]
        public IWorkflowAction SendSurvey([WorkflowExpression] Func<string> campaign, [WorkflowExpression] Func<string> bodyrespondentemailAddress = null, [WorkflowExpression] Func<string> bodyrespondentfirstName = null, [WorkflowExpression] Func<string> bodyrespondentlastName = null, [WorkflowExpression] Func<string> bodyrespondentphoneNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendSurvey(WorkflowExpression<string> campaign, WorkflowExpression<string> bodyrespondentemailAddress = null, WorkflowExpression<string> bodyrespondentfirstName = null, WorkflowExpression<string> bodyrespondentlastName = null, WorkflowExpression<string> bodyrespondentphoneNumber = null)
        {
            WorkflowExpression.Validate(campaign, nameof(campaign), required: true);
            WorkflowExpression.Validate(bodyrespondentemailAddress, nameof(bodyrespondentemailAddress), required: false);
            WorkflowExpression.Validate(bodyrespondentfirstName, nameof(bodyrespondentfirstName), required: false);
            WorkflowExpression.Validate(bodyrespondentlastName, nameof(bodyrespondentlastName), required: false);
            WorkflowExpression.Validate(bodyrespondentphoneNumber, nameof(bodyrespondentphoneNumber), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/campaigns/{0}/respondent", ExpressionConverter.ConvertWithUrlEncoding(campaign, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "npstoday")]
        [WorkflowExpressionFactory(nameof(__BuildAddEmployee))]
        public IWorkflowAction AddEmployee([WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyteam = null, [WorkflowExpression] Func<string> bodydivision = null, [WorkflowExpression] Func<string> bodyphoneNumber = null, [WorkflowExpression] Func<bool> bodyactive = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddEmployee(WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydepartment = null, WorkflowExpression<string> bodyteam = null, WorkflowExpression<string> bodydivision = null, WorkflowExpression<string> bodyphoneNumber = null, WorkflowExpression<bool> bodyactive = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowExpression.Validate(bodyteam, nameof(bodyteam), required: false);
            WorkflowExpression.Validate(bodydivision, nameof(bodydivision), required: false);
            WorkflowExpression.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowExpression.Validate(bodyactive, nameof(bodyactive), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }
    }

    public class NpstodayTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildNewResponse))]
        public IBodyWorkflowTrigger<JToken> NewResponse([WorkflowExpression] Func<int> bodycampaignId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewResponse(WorkflowExpression<int> bodycampaignId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
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

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildNewCampaignMember))]
        public IBodyWorkflowTrigger<JToken> NewCampaignMember([WorkflowExpression] Func<int> bodycampaignId = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewCampaignMember(WorkflowExpression<int> bodycampaignId = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
            return new DeferredBodyTrigger<JToken>(() =>
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