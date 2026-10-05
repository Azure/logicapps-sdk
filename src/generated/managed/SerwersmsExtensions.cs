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
        [WorkflowExpressionFactory(nameof(__BuildAddBlacklist))]
        public IBodyWorkflowAction<AddBlacklistResponse> AddBlacklist([WorkflowExpression] Func<string> bodyphone)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddBlacklistResponse> __BuildAddBlacklist(WorkflowValue<string> bodyphone)
        {
            WorkflowValue.Validate(bodyphone, nameof(bodyphone), required: true);
            return new DeferredBodyAction<AddBlacklistResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        [WorkflowExpressionFactory(nameof(__BuildAddContact))]
        public IBodyWorkflowAction<AddContactResponse> AddContact([WorkflowExpression] Func<string> bodyphone, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytaxId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddContactResponse> __BuildAddContact(WorkflowValue<string> bodyphone, WorkflowValue<string> bodyaddress = null, WorkflowValue<string> bodycity = null, WorkflowValue<string> bodycompany = null, WorkflowValue<string> bodydescription = null, WorkflowValue<string> bodyemail = null, WorkflowValue<string> bodyfirstName = null, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodylastName = null, WorkflowValue<string> bodytaxId = null)
        {
            WorkflowValue.Validate(bodyphone, nameof(bodyphone), required: true);
            WorkflowValue.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowValue.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowValue.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowValue.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowValue.Validate(bodytaxId, nameof(bodytaxId), required: false);
            return new DeferredBodyAction<AddContactResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        [WorkflowExpressionFactory(nameof(__BuildSendSms))]
        public IBodyWorkflowAction<SendSmsResponse> SendSms([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodysender = null, [WorkflowExpression] Func<bool> bodyutf = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSmsResponse> __BuildSendSms(WorkflowValue<string> bodymessage, WorkflowValue<string> bodygroupId = null, WorkflowValue<string> bodyphone = null, WorkflowValue<string> bodysender = null, WorkflowValue<bool> bodyutf = null)
        {
            WorkflowValue.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowValue.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowValue.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowValue.Validate(bodysender, nameof(bodysender), required: false);
            WorkflowValue.Validate(bodyutf, nameof(bodyutf), required: false);
            return new DeferredBodyAction<SendSmsResponse>(() =>
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
            });
        }
    }

    public class SerwersmsTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildNewAnswer))]
        public IBodyWorkflowTrigger<NewAnswerResponse> NewAnswer([WorkflowExpression] Func<bodytypeInput> bodytype, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewAnswerResponse> __BuildNewAnswer(WorkflowValue<bodytypeInput> bodytype, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodytype, nameof(bodytype), required: true);
            return new DeferredBodyTrigger<NewAnswerResponse>(() =>
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
            }, triggerName);
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
