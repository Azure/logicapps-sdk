//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serwersms
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SerwersmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddBlacklistResponse, ApiConnectionActionConfiguration> AddBlacklist(Expression<Func<AddBlacklistBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddBlacklistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/add_blacklist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddBlacklistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddContactResponse, ApiConnectionActionConfiguration> AddContact(Expression<Func<AddContactBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddContactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/add_contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<SendSmsResponse, ApiConnectionActionConfiguration> SendSms(Expression<Func<SendSmsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SendSmsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/action/send_sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            });
        }
    }

    public class SerwersmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewAnswerResponse, ApiConnectionPollingTriggerConfiguration> NewAnswer(Expression<Func<NewAnswerBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<NewAnswerResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/get_answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<NewAnswerResponse>(callPayload);
            });
        }
    }

    public class AddBlacklistResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AddBlacklistBodyInput
    {
        public AddBlacklistBodyInput(string phone)
        {
            this.Phone = phone;
        }

        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Phone { get; set; }
    }

    public class AddContactResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AddContactBodyInput
    {
        public AddContactBodyInput(string phone)
        {
            this.Phone = phone;
        }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("phone", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Phone { get; set; }

        [JsonProperty("tax_id")]
        public string TaxId { get; set; }
    }

    public class SendSmsResponse
    {
        [JsonProperty("queued")]
        public int Queued { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("unsent")]
        public int Unsent { get; set; }
    }

    public class SendSmsBodyInput
    {
        public SendSmsBodyInput(string message)
        {
            this.Message = message;
        }

        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Message { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("utf")]
        public bool? Utf { get; set; }
    }

    public class NewAnswerResponse
    {
        [JsonProperty("items")]
        public NewAnswerResponseItemsTypeItem[] Items { get; set; }
    }

    public class NewAnswerResponseItemsTypeItem
    {
        [JsonProperty("blacklist")]
        public bool Blacklist { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("recived")]
        public string Recived { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class NewAnswerBodyInput
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Serwersms.BodyInputTypeType.Ndi;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTypeType
    {
        [EnumMember(Value = "ECO")]
        Eco,
        ND,
        [EnumMember(Value = "NDI")]
        Ndi,
        [EnumMember(Value = "MMS")]
        Mms,
        [EnumMember(Value = "2WAY")]
        _2Way
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Serwersms;

    public partial class WorkflowManagedActions
    {
        public SerwersmsActions Serwersms(string connectionId) => new SerwersmsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SerwersmsTriggers Serwersms(string connectionId) => new SerwersmsTriggers(connectionId);
    }
}