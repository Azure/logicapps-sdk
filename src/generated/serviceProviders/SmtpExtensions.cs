//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Smtp
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Smtp")]
        public IOutputWorkflowAction<SendEmailOutput> SendEmail(Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<string>> cc = null, Expression<Func<string>> subject = null, Expression<Func<string>> body = null, Expression<Func<bool>> isHTML = null, Expression<Func<string>> bcc = null, Expression<Func<string>> importance = null, Expression<Func<string>> readReceipt = null, Expression<Func<string>> deliveryReceipt = null, Expression<Func<SendEmailInputAttachmentTypeItem[]>> attachment = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["from"] = CSharpExpressionConverter.ConvertToken(from);
            serviceProviderParameters["to"] = CSharpExpressionConverter.ConvertToken(to);
            if (cc != null)
            {
                serviceProviderParameters["cc"] = CSharpExpressionConverter.ConvertToken(cc);
            }

            if (subject != null)
            {
                serviceProviderParameters["subject"] = CSharpExpressionConverter.ConvertToken(subject);
            }

            if (body != null)
            {
                serviceProviderParameters["body"] = CSharpExpressionConverter.ConvertToken(body);
            }

            if (isHTML != null)
            {
                serviceProviderParameters["isHTML"] = CSharpExpressionConverter.ConvertToken(isHTML);
            }

            if (bcc != null)
            {
                serviceProviderParameters["bcc"] = CSharpExpressionConverter.ConvertToken(bcc);
            }

            if (importance != null)
            {
                serviceProviderParameters["importance"] = CSharpExpressionConverter.ConvertToken(importance);
            }
            else
            {
                serviceProviderParameters["importance"] = "Normal";
            }

            if (readReceipt != null)
            {
                serviceProviderParameters["readReceipt"] = CSharpExpressionConverter.ConvertToken(readReceipt);
            }

            if (deliveryReceipt != null)
            {
                serviceProviderParameters["deliveryReceipt"] = CSharpExpressionConverter.ConvertToken(deliveryReceipt);
            }

            if (attachment != null)
            {
                serviceProviderParameters["attachment"] = CSharpExpressionConverter.ConvertToken(attachment);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Smtp", operationId: "sendEmail", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderOutputAction<SendEmailOutput>(serviceProviderInput);
        }
    }

    public class SendEmailOutput
    {
        [JsonProperty("response")]
        public string Response { get; set; }
    }

    public class SendEmailInputAttachmentTypeItem
    {
        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken FileName { get; set; }

        [JsonProperty("contentData", DefaultValueHandling = DefaultValueHandling.Include)]
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
}