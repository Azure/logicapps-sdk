//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Smtp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Smtp")]
        public IOutputWorkflowAction<SendEmailOutput> SendEmail(Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<string>> cc = null, Expression<Func<string>> subject = null, Expression<Func<string>> body = null, Expression<Func<bool>> isHTML = null, Expression<Func<string>> bcc = null, Expression<Func<string>> importance = null, Expression<Func<string>> readReceipt = null, Expression<Func<string>> deliveryReceipt = null, Expression<Func<SendEmailAttachmentTypeItem[]>> attachment = null)
        {
            var parameters = new JObject();
            parameters["from"] = ExpressionConverter.ConvertO(from);
            parameters["to"] = ExpressionConverter.ConvertO(to);
            if (cc != null)
            {
                parameters["cc"] = ExpressionConverter.ConvertO(cc);
            }

            if (subject != null)
            {
                parameters["subject"] = ExpressionConverter.ConvertO(subject);
            }

            if (body != null)
            {
                parameters["body"] = ExpressionConverter.ConvertO(body);
            }

            if (isHTML != null)
            {
                parameters["isHTML"] = ExpressionConverter.ConvertO(isHTML);
            }

            if (bcc != null)
            {
                parameters["bcc"] = ExpressionConverter.ConvertO(bcc);
            }

            if (importance != null)
            {
                parameters["importance"] = ExpressionConverter.ConvertO(importance);
            }

            if (readReceipt != null)
            {
                parameters["readReceipt"] = ExpressionConverter.ConvertO(readReceipt);
            }

            if (deliveryReceipt != null)
            {
                parameters["deliveryReceipt"] = ExpressionConverter.ConvertO(deliveryReceipt);
            }

            if (attachment != null)
            {
                parameters["attachment"] = ExpressionConverter.ConvertO(attachment);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Smtp", operationId: "sendEmail", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderOutputAction<SendEmailOutput>(input);
        }
    }

    public class SmtpTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendEmailOutput
    {
        [JsonProperty("response")]
        public string Response { get; set; }
    }

    public class SendEmailAttachmentTypeItem
    {
        [JsonProperty("fileName")]
        public JToken FileName { get; set; }

        [JsonProperty("contentData")]
        public string ContentData { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Smtp;

    public partial class WorkflowServiceProviderActions
    {
        public SmtpActions Smtp(string connectionId) => new SmtpActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public SmtpTriggers Smtp(string connectionId) => new SmtpTriggers(connectionId);
    }
}