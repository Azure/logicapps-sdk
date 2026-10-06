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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddBlacklistResponse> __BuildAddBlacklist(WorkflowExpression<string> bodyphone)
        {
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: true);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddContactResponse> __BuildAddContact(WorkflowExpression<string> bodyphone, WorkflowExpression<string> bodyaddress = null, WorkflowExpression<string> bodycity = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodygroupId = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodytaxId = null)
        {
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: true);
            WorkflowExpression.Validate(bodyaddress, nameof(bodyaddress), required: false);
            WorkflowExpression.Validate(bodycity, nameof(bodycity), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodytaxId, nameof(bodytaxId), required: false);
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
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSmsResponse> __BuildSendSms(WorkflowExpression<string> bodymessage, WorkflowExpression<string> bodygroupId = null, WorkflowExpression<string> bodyphone = null, WorkflowExpression<string> bodysender = null, WorkflowExpression<bool> bodyutf = null)
        {
            WorkflowExpression.Validate(bodymessage, nameof(bodymessage), required: true);
            WorkflowExpression.Validate(bodygroupId, nameof(bodygroupId), required: false);
            WorkflowExpression.Validate(bodyphone, nameof(bodyphone), required: false);
            WorkflowExpression.Validate(bodysender, nameof(bodysender), required: false);
            WorkflowExpression.Validate(bodyutf, nameof(bodyutf), required: false);
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
        public IBodyWorkflowTrigger<NewAnswerResponse> NewAnswer([WorkflowExpression] Func<bodytypeInput> bodytype,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<NewAnswerResponse> __BuildNewAnswer(WorkflowExpression<bodytypeInput> bodytype,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
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