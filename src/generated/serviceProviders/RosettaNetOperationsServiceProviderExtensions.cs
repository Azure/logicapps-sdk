//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.RosettaNetOperations
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RosettaNetOperationsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rosettaNetOperations")]
        public IBodyWorkflowAction<RosettaNetEncodeOutput> RosettaNetEncode(Expression<Func<object>> messageToEncode, Expression<Func<string>> hostPartnerName, Expression<Func<string>> guestPartnerName, Expression<Func<string>> processConfigurationCode, Expression<Func<string>> processConfigurationVersion, Expression<Func<string>> processConfigurationInstanceIdentity, Expression<Func<RosettaNetEncodeMessageTypeType>> messageType, Expression<Func<RosettaNetEncodeHomeRoleType>> homeRole, Expression<Func<string>> trackingId = null, Expression<Func<RosettaNetEncodeAttachmentsTypeItem[]>> attachments = null)
        {
            var parameters = new JObject();
            parameters["messageToEncode"] = ExpressionConverter.ConvertO(messageToEncode);
            parameters["hostPartnerName"] = ExpressionConverter.ConvertO(hostPartnerName);
            parameters["guestPartnerName"] = ExpressionConverter.ConvertO(guestPartnerName);
            parameters["processConfigurationCode"] = ExpressionConverter.ConvertO(processConfigurationCode);
            parameters["processConfigurationVersion"] = ExpressionConverter.ConvertO(processConfigurationVersion);
            parameters["processConfigurationInstanceIdentity"] = ExpressionConverter.ConvertO(processConfigurationInstanceIdentity);
            parameters["messageType"] = ExpressionConverter.ConvertO(messageType);
            if (trackingId != null)
            {
                parameters["trackingId"] = ExpressionConverter.ConvertO(trackingId);
            }

            parameters["homeRole"] = ExpressionConverter.ConvertO(homeRole);
            if (attachments != null)
            {
                parameters["attachments"] = ExpressionConverter.ConvertO(attachments);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/rosettaNetOperations", operationId: "rosettaNetEncode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<RosettaNetEncodeOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rosettaNetOperations")]
        public IBodyWorkflowAction<RosettaNetDecodeOutput> RosettaNetDecode(Expression<Func<object>> messageToDecode, Expression<Func<object>> messageHeaders, Expression<Func<RosettaNetDecodeHomeRoleType>> homeRole)
        {
            var parameters = new JObject();
            parameters["messageToDecode"] = ExpressionConverter.ConvertO(messageToDecode);
            parameters["messageHeaders"] = ExpressionConverter.ConvertO(messageHeaders);
            parameters["homeRole"] = ExpressionConverter.ConvertO(homeRole);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/rosettaNetOperations", operationId: "rosettaNetDecode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<RosettaNetDecodeOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "rosettaNetOperations")]
        public IBodyWorkflowAction<RosettaNetWaitForResponseOutput> RosettaNetWaitForResponse(Expression<Func<object>> serviceContent, Expression<Func<string>> processInstanceIdentity, Expression<Func<int>> retryCount, Expression<Func<RosettaNetWaitForResponseHomeRoleType>> homeRole, Expression<Func<RosettaNetWaitForResponsePollingIntervalType>> pollingInterval = null)
        {
            var parameters = new JObject();
            parameters["serviceContent"] = ExpressionConverter.ConvertO(serviceContent);
            parameters["processInstanceIdentity"] = ExpressionConverter.ConvertO(processInstanceIdentity);
            parameters["retryCount"] = ExpressionConverter.ConvertO(retryCount);
            parameters["homeRole"] = ExpressionConverter.ConvertO(homeRole);
            if (pollingInterval != null)
            {
                parameters["pollingInterval"] = ExpressionConverter.ConvertO(pollingInterval);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "connectionProviders/rosettaNetOperations", operationId: "rosettaNetWaitForResponse", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<RosettaNetWaitForResponseOutput>(input);
        }
    }

    public class RosettaNetOperationsTriggers([ConnectionName] string connectionId)
    {
    }

    public class RosettaNetEncodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("messageHeaders")]
        public JToken MessageHeaders { get; set; }

        [JsonProperty("trackingId")]
        public string TrackingId { get; set; }

        [JsonProperty("responseType")]
        public string ResponseType { get; set; }

        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("outboundUri")]
        public string OutboundUri { get; set; }

        [JsonProperty("messageHash")]
        public string MessageHash { get; set; }
    }

    public enum RosettaNetEncodeMessageTypeType
    {
        Action,
        Response,
        Signal
    }

    public enum RosettaNetEncodeHomeRoleType
    {
        Initiator,
        Responder
    }

    public class RosettaNetEncodeAttachmentsTypeItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }
    }

    public class RosettaNetDecodeOutput
    {
        [JsonProperty("messageContent")]
        public JToken MessageContent { get; set; }

        [JsonProperty("hostPartnerName")]
        public string HostPartnerName { get; set; }

        [JsonProperty("guestPartnerName")]
        public string GuestPartnerName { get; set; }

        [JsonProperty("processConfigurationCode")]
        public string ProcessConfigurationCode { get; set; }

        [JsonProperty("processConfigurationInstanceIdentity")]
        public string ProcessConfigurationInstanceIdentity { get; set; }

        [JsonProperty("processConfigurationVersion")]
        public string ProcessConfigurationVersion { get; set; }

        [JsonProperty("actionType")]
        public string ActionType { get; set; }

        [JsonProperty("responseType")]
        public string ResponseType { get; set; }

        [JsonProperty("trackingId")]
        public string TrackingId { get; set; }

        [JsonProperty("outboundSignal")]
        public string OutboundSignal { get; set; }

        [JsonProperty("maxRetryCount")]
        public int MaxRetryCount { get; set; }

        [JsonProperty("micDigest")]
        public string MicDigest { get; set; }

        [JsonProperty("messageType")]
        public string MessageType { get; set; }

        [JsonProperty("attachments")]
        public RosettaNetDecodeOutputAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class RosettaNetDecodeOutputAttachmentsTypeItem
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("contentId")]
        public string ContentId { get; set; }
    }

    public enum RosettaNetDecodeHomeRoleType
    {
        Initiator,
        Responder
    }

    public class RosettaNetWaitForResponseOutput
    {
        [JsonProperty("notificationOfFailureMessage")]
        public JToken NotificationOfFailureMessage { get; set; }

        [JsonProperty("waitResult")]
        public string WaitResult { get; set; }
    }

    public enum RosettaNetWaitForResponseHomeRoleType
    {
        Initiator,
        Responder
    }

    public class RosettaNetWaitForResponsePollingIntervalType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("unit")]
        public RosettaNetWaitForResponsePollingIntervalTypeUnitType Unit { get; set; }
    }

    public enum RosettaNetWaitForResponsePollingIntervalTypeUnitType
    {
        Day,
        Hour,
        Minute,
        Second
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.RosettaNetOperations;

    public partial class WorkflowServiceProviderActions
    {
        public RosettaNetOperationsActions RosettaNetOperations(string connectionId) => new RosettaNetOperationsActions(connectionId);
    }

    public partial class WorkflowServiceProviderTriggers
    {
        public RosettaNetOperationsTriggers RosettaNetOperations(string connectionId) => new RosettaNetOperationsTriggers(connectionId);
    }
}