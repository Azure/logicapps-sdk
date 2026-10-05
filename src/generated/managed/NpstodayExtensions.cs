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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendSurvey(WorkflowValue<string> campaign, WorkflowValue<string> bodyrespondentemailAddress = null, WorkflowValue<string> bodyrespondentfirstName = null, WorkflowValue<string> bodyrespondentlastName = null, WorkflowValue<string> bodyrespondentphoneNumber = null)
        {
            WorkflowValue.Validate(campaign, nameof(campaign), required: true);
            WorkflowValue.Validate(bodyrespondentemailAddress, nameof(bodyrespondentemailAddress), required: false);
            WorkflowValue.Validate(bodyrespondentfirstName, nameof(bodyrespondentfirstName), required: false);
            WorkflowValue.Validate(bodyrespondentlastName, nameof(bodyrespondentlastName), required: false);
            WorkflowValue.Validate(bodyrespondentphoneNumber, nameof(bodyrespondentphoneNumber), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddEmployee(WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodytitle = null, WorkflowValue<string> bodydepartment = null, WorkflowValue<string> bodyteam = null, WorkflowValue<string> bodydivision = null, WorkflowValue<string> bodyphoneNumber = null, WorkflowValue<bool> bodyactive = null)
        {
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowValue.Validate(bodydepartment, nameof(bodydepartment), required: false);
            WorkflowValue.Validate(bodyteam, nameof(bodyteam), required: false);
            WorkflowValue.Validate(bodydivision, nameof(bodydivision), required: false);
            WorkflowValue.Validate(bodyphoneNumber, nameof(bodyphoneNumber), required: false);
            WorkflowValue.Validate(bodyactive, nameof(bodyactive), required: false);
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
        public IBodyWorkflowTrigger<JToken> NewResponse([WorkflowExpression] Func<int> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewResponse(WorkflowValue<int> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildNewCampaignMember))]
        public IBodyWorkflowTrigger<JToken> NewCampaignMember([WorkflowExpression] Func<int> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewCampaignMember(WorkflowValue<int> bodycampaignId = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodycampaignId, nameof(bodycampaignId), required: false);
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

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
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
