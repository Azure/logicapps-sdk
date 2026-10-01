//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Serwersms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SerwersmsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddBlacklistResponse> AddBlacklist([WorkflowExpression] Func<string> bodyphone)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/add_blacklist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddBlacklistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<AddContactResponse> AddContact([WorkflowExpression] Func<string> bodyphone, [WorkflowExpression] Func<string> bodyaddress = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodytaxId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/add_contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyaddress);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodygroupId != null)
                {
                    body["group_id"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                if (bodytaxId != null)
                {
                    body["tax_id"] = SourceExpressionConverter.ConvertToken(bodytaxId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AddContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "serwersms")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms([WorkflowExpression] Func<string> bodymessage, [WorkflowExpression] Func<string> bodygroupId = null, [WorkflowExpression] Func<string> bodyphone = null, [WorkflowExpression] Func<string> bodysender = null, [WorkflowExpression] Func<bool> bodyutf = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/action/send_sms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodygroupId != null)
                {
                    body["group_id"] = SourceExpressionConverter.ConvertToken(bodygroupId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["message"] = SourceExpressionConverter.ConvertToken(bodymessage);
                if (bodyphone != null)
                {
                    body["phone"] = SourceExpressionConverter.ConvertToken(bodyphone);
                    bodypropCount++;
                }

                if (bodysender != null)
                {
                    body["sender"] = SourceExpressionConverter.ConvertToken(bodysender);
                    bodypropCount++;
                }

                if (bodyutf != null)
                {
                    body["utf"] = SourceExpressionConverter.ConvertToken(bodyutf);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SendSmsResponse>(BuildSourceInput);
        }
    }

    public class SerwersmsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewAnswerResponse> NewAnswer([WorkflowExpression] Func<bodytypeInput> bodytype, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/trigger/get_answer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<NewAnswerResponse>(BuildSourceInput, triggerName, recurrence);
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