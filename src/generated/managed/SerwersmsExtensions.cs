//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serwersms
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SerwersmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddBlacklistResponse> AddBlacklist([WorkflowExpression] Func<string> bodyphone)
        {
            var apiCallPath = "/action/add_blacklist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["phone"] = ExpressionConverter.ConvertO(bodyphone);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddBlacklistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddContactResponse> AddContact([WorkflowExpression] Func<string> bodyphone, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytaxId = null)
        {
            var apiCallPath = "/action/add_contact";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyaddress != null)
            {
                body["address"] = ExpressionConverter.ConvertO(bodyaddress);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = ExpressionConverter.ConvertO(bodycompany);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                bodypropCount++;
            }

            if (bodygroupId != null)
            {
                body["group_id"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                bodypropCount++;
            }

            bodypropCount++;
            body["phone"] = ExpressionConverter.ConvertO(bodyphone);
            if (bodytaxId != null)
            {
                body["tax_id"] = ExpressionConverter.ConvertO(bodytaxId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodysender = null, [WorkflowExpression] Func<bool> bodyutf = null)
        {
            var apiCallPath = "/action/send_sms";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodygroupId != null)
            {
                body["group_id"] = ExpressionConverter.ConvertO(bodygroupId);
                bodypropCount++;
            }

            bodypropCount++;
            body["message"] = ExpressionConverter.ConvertO(bodymessage);
            if (bodyphone != null)
            {
                body["phone"] = ExpressionConverter.ConvertO(bodyphone);
                bodypropCount++;
            }

            if (bodysender != null)
            {
                body["sender"] = ExpressionConverter.ConvertO(bodysender);
                bodypropCount++;
            }

            if (bodyutf != null)
            {
                body["utf"] = ExpressionConverter.ConvertO(bodyutf);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SendSmsResponse>(callPayload);
        }
    }

    public class SerwersmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewAnswerResponse> NewAnswer([WorkflowExpression] Func<bodytypeInput> bodytype, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/get_answer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<NewAnswerResponse>(callPayload, triggerName, recurrence);
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