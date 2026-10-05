//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Smtp
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Smtp")]
        [WorkflowExpressionFactory(nameof(__BuildSendEmail))]
        public IOutputWorkflowAction<SendEmailOutput> SendEmail([WorkflowExpression] Func<string> from, [WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<bool> isHTML = null, [WorkflowExpression] Func<string> bcc = null, [WorkflowExpression] Func<string> importance = null, [WorkflowExpression] Func<string> readReceipt = null, [WorkflowExpression] Func<string> deliveryReceipt = null, [WorkflowExpression] Func<SendEmailInputAttachmentTypeItem[]> attachment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IOutputWorkflowAction<SendEmailOutput> __BuildSendEmail(WorkflowValue<string> from, WorkflowValue<string> to, WorkflowValue<string> cc = null, WorkflowValue<string> subject = null, WorkflowValue<string> body = null, WorkflowValue<bool> isHTML = null, WorkflowValue<string> bcc = null, WorkflowValue<string> importance = null, WorkflowValue<string> readReceipt = null, WorkflowValue<string> deliveryReceipt = null, WorkflowValue<SendEmailInputAttachmentTypeItem[]> attachment = null)
        {
            WorkflowValue.Validate(from, nameof(from), required: true);
            WorkflowValue.Validate(to, nameof(to), required: true);
            WorkflowValue.Validate(cc, nameof(cc), required: false);
            WorkflowValue.Validate(subject, nameof(subject), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            WorkflowValue.Validate(isHTML, nameof(isHTML), required: false);
            WorkflowValue.Validate(bcc, nameof(bcc), required: false);
            WorkflowValue.Validate(importance, nameof(importance), required: false);
            WorkflowValue.Validate(readReceipt, nameof(readReceipt), required: false);
            WorkflowValue.Validate(deliveryReceipt, nameof(deliveryReceipt), required: false);
            WorkflowValue.Validate(attachment, nameof(attachment), required: false);
            return new DeferredOutputAction<SendEmailOutput>(() =>
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
                else
                {
                    serviceProviderParameters["importance"] = "Normal";
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
            });
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
