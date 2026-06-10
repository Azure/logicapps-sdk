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
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["from"] = ExpressionConverter.ConvertO(from);
            serviceProviderParameters["to"] = ExpressionConverter.ConvertO(to);
            if (cc != null)
            {
                serviceProviderParameters["cc"] = ExpressionConverter.ConvertO(cc);
            }

            if (subject != null)
            {
                serviceProviderParameters["subject"] = ExpressionConverter.ConvertO(subject);
            }

            if (body != null)
            {
                serviceProviderParameters["body"] = ExpressionConverter.ConvertO(body);
            }

            if (isHTML != null)
            {
                serviceProviderParameters["isHTML"] = ExpressionConverter.ConvertO(isHTML);
            }

            if (bcc != null)
            {
                serviceProviderParameters["bcc"] = ExpressionConverter.ConvertO(bcc);
            }

            if (importance != null)
            {
                serviceProviderParameters["importance"] = ExpressionConverter.ConvertO(importance);
            }

            if (readReceipt != null)
            {
                serviceProviderParameters["readReceipt"] = ExpressionConverter.ConvertO(readReceipt);
            }

            if (deliveryReceipt != null)
            {
                serviceProviderParameters["deliveryReceipt"] = ExpressionConverter.ConvertO(deliveryReceipt);
            }

            if (attachment != null)
            {
                serviceProviderParameters["attachment"] = ExpressionConverter.ConvertO(attachment);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Smtp", operationId: "sendEmail", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<SendEmailOutput>(serviceProviderInput);
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