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
    using System.Linq.Expressions;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Smtp")]
        public IOutputWorkflowAction<SendEmailOutput> SendEmail(Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<string>> cc = null, Expression<Func<string>> subject = null, Expression<Func<string>> body = null, Expression<Func<bool>> isHTML = null, Expression<Func<string>> bcc = null, Expression<Func<string>> importance = null, Expression<Func<string>> readReceipt = null, Expression<Func<string>> deliveryReceipt = null, Expression<Func<SendEmailInputAttachmentTypeItem[]>> attachment = null)
        {
            var __workflow_from = from == null ? null : WorkflowExpression.Compile(from);
            WorkflowExpression.Validate(__workflow_from, nameof(from), required: true);
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: true);
            var __workflow_cc = cc == null ? null : WorkflowExpression.Compile(cc);
            WorkflowExpression.Validate(__workflow_cc, nameof(cc), required: false);
            var __workflow_subject = subject == null ? null : WorkflowExpression.Compile(subject);
            WorkflowExpression.Validate(__workflow_subject, nameof(subject), required: false);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            var __workflow_isHTML = isHTML == null ? null : WorkflowExpression.Compile(isHTML);
            WorkflowExpression.Validate(__workflow_isHTML, nameof(isHTML), required: false);
            var __workflow_bcc = bcc == null ? null : WorkflowExpression.Compile(bcc);
            WorkflowExpression.Validate(__workflow_bcc, nameof(bcc), required: false);
            var __workflow_importance = importance == null ? null : WorkflowExpression.Compile(importance);
            WorkflowExpression.Validate(__workflow_importance, nameof(importance), required: false);
            var __workflow_readReceipt = readReceipt == null ? null : WorkflowExpression.Compile(readReceipt);
            WorkflowExpression.Validate(__workflow_readReceipt, nameof(readReceipt), required: false);
            var __workflow_deliveryReceipt = deliveryReceipt == null ? null : WorkflowExpression.Compile(deliveryReceipt);
            WorkflowExpression.Validate(__workflow_deliveryReceipt, nameof(deliveryReceipt), required: false);
            var __workflow_attachment = attachment == null ? null : WorkflowExpression.Compile(attachment);
            WorkflowExpression.Validate(__workflow_attachment, nameof(attachment), required: false);
            return new DeferredOutputAction<SendEmailOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["from"] = ExpressionConverter.ConvertO(__workflow_from);
                serviceProviderParameters["to"] = ExpressionConverter.ConvertO(__workflow_to);
                if (__workflow_cc != null)
                {
                    serviceProviderParameters["cc"] = ExpressionConverter.ConvertO(__workflow_cc);
                }

                if (__workflow_subject != null)
                {
                    serviceProviderParameters["subject"] = ExpressionConverter.ConvertO(__workflow_subject);
                }

                if (__workflow_body != null)
                {
                    serviceProviderParameters["body"] = ExpressionConverter.ConvertO(__workflow_body);
                }

                if (__workflow_isHTML != null)
                {
                    serviceProviderParameters["isHTML"] = ExpressionConverter.ConvertO(__workflow_isHTML);
                }

                if (__workflow_bcc != null)
                {
                    serviceProviderParameters["bcc"] = ExpressionConverter.ConvertO(__workflow_bcc);
                }

                if (__workflow_importance != null)
                {
                    serviceProviderParameters["importance"] = ExpressionConverter.ConvertO(__workflow_importance);
                }
                else
                {
                    serviceProviderParameters["importance"] = "Normal";
                }

                if (__workflow_readReceipt != null)
                {
                    serviceProviderParameters["readReceipt"] = ExpressionConverter.ConvertO(__workflow_readReceipt);
                }

                if (__workflow_deliveryReceipt != null)
                {
                    serviceProviderParameters["deliveryReceipt"] = ExpressionConverter.ConvertO(__workflow_deliveryReceipt);
                }

                if (__workflow_attachment != null)
                {
                    serviceProviderParameters["attachment"] = ExpressionConverter.ConvertO(__workflow_attachment);
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
