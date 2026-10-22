//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Smtp
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class SmtpActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "Smtp")]
        public IOutputWorkflowAction<SendEmailOutput, SendEmailActionConfiguration> SendEmail(Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<string>> cc = null, Expression<Func<string>> subject = null, Expression<Func<string>> body = null, Expression<Func<bool>> isHTML = null, Expression<Func<string>> bcc = null, Expression<Func<string>> importance = null, Expression<Func<string>> readReceipt = null, Expression<Func<string>> deliveryReceipt = null, Expression<Func<SendEmailInputAttachmentTypeItem[]>> attachment = null)
        {
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: true);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_cc = WorkflowExpression.Compile(cc, nameof(cc), required: false);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            var __workflow_isHTML = WorkflowExpression.Compile(isHTML, nameof(isHTML), required: false);
            var __workflow_bcc = WorkflowExpression.Compile(bcc, nameof(bcc), required: false);
            var __workflow_importance = WorkflowExpression.Compile(importance, nameof(importance), required: false);
            var __workflow_readReceipt = WorkflowExpression.Compile(readReceipt, nameof(readReceipt), required: false);
            var __workflow_deliveryReceipt = WorkflowExpression.Compile(deliveryReceipt, nameof(deliveryReceipt), required: false);
            var __workflow_attachment = WorkflowExpression.Compile(attachment, nameof(attachment), required: false);
            return new DeferredOutputAction<SendEmailOutput, SendEmailActionConfiguration>(() =>
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
                return new ServiceProviderOutputAction<SendEmailOutput, SendEmailActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class SendEmailActionConfiguration : IWorkflowOperationConfiguration, ITrackedPropertiesConfigurationHolder, ISecureInputsConfigurationHolder, ISecureOutputsConfigurationHolder
    {
        public IDictionary<string, JToken> TrackedProperties { get; } = new Dictionary<string, JToken>(StringComparer.Ordinal);
        public bool SecureInputs { get; set; }
        public bool SecureOutputs { get; set; }
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