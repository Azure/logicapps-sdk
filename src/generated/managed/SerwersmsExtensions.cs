//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serwersms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SerwersmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddBlacklistResponse> AddBlacklist(Expression<Func<string>> bodyphone)
        {
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: true);
            return new DeferredBodyAction<AddBlacklistResponse>(() =>
            {
                var apiCallPath = "/action/add_blacklist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddBlacklistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddContactResponse> AddContact(Expression<Func<string>> bodyphone, Expression<Func<string>> bodyaddress = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodytaxId = null)
        {
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: true);
            var __workflow_bodyaddress = WorkflowExpression.Compile(bodyaddress, nameof(bodyaddress), required: false);
            var __workflow_bodycity = WorkflowExpression.Compile(bodycity, nameof(bodycity), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodytaxId = WorkflowExpression.Compile(bodytaxId, nameof(bodytaxId), required: false);
            return new DeferredBodyAction<AddContactResponse>(() =>
            {
                var apiCallPath = "/action/add_contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyaddress != null)
                {
                    body["address"] = ExpressionConverter.ConvertO(__workflow_bodyaddress);
                    bodypropCount++;
                }

                if (__workflow_bodycity != null)
                {
                    body["city"] = ExpressionConverter.ConvertO(__workflow_bodycity);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodygroupId != null)
                {
                    body["group_id"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                if (__workflow_bodytaxId != null)
                {
                    body["tax_id"] = ExpressionConverter.ConvertO(__workflow_bodytaxId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms(Expression<Func<string>> bodymessage, Expression<Func<string>> bodygroupId = null, Expression<Func<string>> bodyphone = null, Expression<Func<string>> bodysender = null, Expression<Func<bool>> bodyutf = null)
        {
            var __workflow_bodymessage = WorkflowExpression.Compile(bodymessage, nameof(bodymessage), required: true);
            var __workflow_bodygroupId = WorkflowExpression.Compile(bodygroupId, nameof(bodygroupId), required: false);
            var __workflow_bodyphone = WorkflowExpression.Compile(bodyphone, nameof(bodyphone), required: false);
            var __workflow_bodysender = WorkflowExpression.Compile(bodysender, nameof(bodysender), required: false);
            var __workflow_bodyutf = WorkflowExpression.Compile(bodyutf, nameof(bodyutf), required: false);
            return new DeferredBodyAction<SendSmsResponse>(() =>
            {
                var apiCallPath = "/action/send_sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodygroupId != null)
                {
                    body["group_id"] = ExpressionConverter.ConvertO(__workflow_bodygroupId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["message"] = ExpressionConverter.ConvertO(__workflow_bodymessage);
                if (__workflow_bodyphone != null)
                {
                    body["phone"] = ExpressionConverter.ConvertO(__workflow_bodyphone);
                    bodypropCount++;
                }

                if (__workflow_bodysender != null)
                {
                    body["sender"] = ExpressionConverter.ConvertO(__workflow_bodysender);
                    bodypropCount++;
                }

                if (__workflow_bodyutf != null)
                {
                    body["utf"] = ExpressionConverter.ConvertO(__workflow_bodyutf);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            });
        }
    }

    public class SerwersmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewAnswerResponse> NewAnswer(Expression<Func<bodytypeInput>> bodytype, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            return new DeferredBodyTrigger<NewAnswerResponse>(() =>
            {
                var apiCallPath = "/trigger/get_answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<NewAnswerResponse>(callPayload, recurrence: recurrence);
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

    public class AddContactResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        ECO,
        ND,
        NDI,
        MMS,
        [EnumMember(Value = "2WAY")]
        _2WAY
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
