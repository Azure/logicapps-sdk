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
        public IOutputWorkflowAction<SendEmailOutput> SendEmail([WorkflowExpression] Func<string> from, [WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> subject = null, [WorkflowExpression] Func<string> body = null, [WorkflowExpression] Func<bool> isHTML = null, [WorkflowExpression] Func<string> bcc = null, [WorkflowExpression] Func<string> importance = null, [WorkflowExpression] Func<string> readReceipt = null, [WorkflowExpression] Func<string> deliveryReceipt = null, [WorkflowExpression] Func<SendEmailInputAttachmentTypeItem[]> attachment = null)
        {
            SourceExpression.Validate(from, nameof(from), required: true);
            SourceExpression.Validate(to, nameof(to), required: true);
            SourceExpression.Validate(cc, nameof(cc), required: false);
            SourceExpression.Validate(subject, nameof(subject), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(isHTML, nameof(isHTML), required: false);
            SourceExpression.Validate(bcc, nameof(bcc), required: false);
            SourceExpression.Validate(importance, nameof(importance), required: false);
            SourceExpression.Validate(readReceipt, nameof(readReceipt), required: false);
            SourceExpression.Validate(deliveryReceipt, nameof(deliveryReceipt), required: false);
            SourceExpression.Validate(attachment, nameof(attachment), required: false);
            ServiceProviderOperationInput BuildSourceInput()
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["from"] = SourceExpressionConverter.ConvertToken(from);
                serviceProviderParameters["to"] = SourceExpressionConverter.ConvertToken(to);
                if (cc != null)
                {
                    serviceProviderParameters["cc"] = SourceExpressionConverter.ConvertToken(cc);
                }

                if (subject != null)
                {
                    serviceProviderParameters["subject"] = SourceExpressionConverter.ConvertToken(subject);
                }

                if (body != null)
                {
                    serviceProviderParameters["body"] = SourceExpressionConverter.ConvertToken(body);
                }

                if (isHTML != null)
                {
                    serviceProviderParameters["isHTML"] = SourceExpressionConverter.ConvertToken(isHTML);
                }

                if (bcc != null)
                {
                    serviceProviderParameters["bcc"] = SourceExpressionConverter.ConvertToken(bcc);
                }

                if (importance != null)
                {
                    serviceProviderParameters["importance"] = SourceExpressionConverter.ConvertToken(importance);
                }
                else
                {
                    serviceProviderParameters["importance"] = "Normal";
                }

                if (readReceipt != null)
                {
                    serviceProviderParameters["readReceipt"] = SourceExpressionConverter.ConvertToken(readReceipt);
                }

                if (deliveryReceipt != null)
                {
                    serviceProviderParameters["deliveryReceipt"] = SourceExpressionConverter.ConvertToken(deliveryReceipt);
                }

                if (attachment != null)
                {
                    serviceProviderParameters["attachment"] = SourceExpressionConverter.ConvertToken(attachment);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/Smtp", operationId: "sendEmail", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return serviceProviderInput;
            }

            return new ServiceProviderOutputAction<SendEmailOutput>(BuildSourceInput);
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