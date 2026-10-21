//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smsapi
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmsapiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smsapi")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms(Expression<Func<string>> bodymessage, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodygroup = null, Expression<Func<int>> bodyfast = null)
        {
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodygroup = WorkflowExpression.Compile(bodygroup, nameof(bodygroup), required: false);
            var __workflow_bodyfast = WorkflowExpression.Compile(bodyfast, nameof(bodyfast), required: false);
            return new DeferredBodyAction<SendSmsResponse>(() =>
            {
                var apiCallPath = "/sms.do";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                body["format"] = "json";
                bodypropCount++;
                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                body["encoding"] = "utf-8";
                bodypropCount++;
                if (__workflow_bodygroup != null)
                {
                    body["group"] = ExpressionConverter.ConvertO(__workflow_bodygroup);
                    bodypropCount++;
                }

                if (__workflow_bodyfast != null)
                {
                    if (__workflow_bodyfast != null)
                    {
                        body["fast"] = ExpressionConverter.ConvertO(__workflow_bodyfast);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["fast"] = 0;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class SmsapiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSmsResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("list")]
        public SendSmsResponseListTypeItem[] List { get; set; }
    }

    public class SendSmsResponseListTypeItem
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }

        [JsonProperty("date_sent")]
        public int DateSent { get; set; }

        [JsonProperty("points")]
        public double Points { get; set; }

        [JsonProperty("parts")]
        public int Parts { get; set; }

        [JsonProperty("idx")]
        public string Idx { get; set; }

        [JsonProperty("submitted_number")]
        public string SubmittedNumber { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smsapi;

    public partial class WorkflowManagedActions
    {
        public SmsapiActions Smsapi(string connectionId) => new SmsapiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmsapiTriggers Smsapi(string connectionId) => new SmsapiTriggers(connectionId);
    }
}
