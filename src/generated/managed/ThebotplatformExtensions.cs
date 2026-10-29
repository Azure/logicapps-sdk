//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThebotplatformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IBodyWorkflowAction<SimpleTextMessageResponse, ApiConnectionActionConfiguration> SimpleTextMessage(Expression<Func<SimpleTextMessageInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<SimpleTextMessageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/activity/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SimpleTextMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IBodyWorkflowAction<CreateUserAttributeResponse, ApiConnectionActionConfiguration> CreateUserAttribute(Expression<Func<CreateUserAttributeInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateUserAttributeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1.0/userattributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateUserAttributeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetUserAttribute(Expression<Func<string>> emailaddress, Expression<Func<SetUserAttributeInput>> body)
        {
            var __workflow_emailaddress = WorkflowExpression.Compile(emailaddress, nameof(emailaddress), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}", __workflow_emailaddress.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ThebotplatformTriggers([ConnectionName] string connectionId)
    {
    }

    public class SimpleTextMessageResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class SimpleTextMessageInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SimpleTextMessageInputDataType Data { get; set; }
    }

    public class SimpleTextMessageInputDataType
    {
        [JsonProperty("attributes")]
        public SimpleTextMessageInputDataTypeAttributesType Attributes { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal SimpleTextMessageInputDataTypeTypeType Type { get; set; } = SimpleTextMessageInputDataTypeTypeType.ExternalActivity;
    }

    public class SimpleTextMessageInputDataTypeAttributesType
    {
        [JsonProperty("messages")]
        public SimpleTextMessageInputDataTypeAttributesTypeMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class SimpleTextMessageInputDataTypeAttributesTypeMessagesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleTextMessageInputDataTypeTypeType
    {
        [EnumMember(Value = "external-activity")]
        ExternalActivity
    }

    public class CreateUserAttributeResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class CreateUserAttributeInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserAttributeInputDataType Data { get; set; }
    }

    public class CreateUserAttributeInputDataType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "userattribute";

        [JsonProperty("attributes")]
        public CreateUserAttributeInputDataTypeAttributesType Attributes { get; set; }
    }

    public class CreateUserAttributeInputDataTypeAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_pii")]
        public CreateUserAttributeInputDataTypeAttributesTypeIsPiiType? IsPii { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserAttributeInputDataTypeAttributesTypeIsPiiType
    {
        Yes,
        No
    }

    public class SetUserAttributeInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUserAttributeInputDataType Data { get; set; }
    }

    public class SetUserAttributeInputDataType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal SetUserAttributeInputDataTypeTypeType Type { get; set; } = SetUserAttributeInputDataTypeTypeType.User;

        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUserAttributeInputDataTypeAttributesType Attributes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetUserAttributeInputDataTypeTypeType
    {
        [EnumMember(Value = "user")]
        User
    }

    public class SetUserAttributeInputDataTypeAttributesType
    {
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUserAttributeInputDataTypeAttributesTypeStateTypeItem[] State { get; set; }
    }

    public class SetUserAttributeInputDataTypeAttributesTypeStateTypeItem
    {
        [JsonProperty("userattribute", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUserAttributeInputDataTypeAttributesTypeStateTypeItemUserattributeType Userattribute { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class SetUserAttributeInputDataTypeAttributesTypeStateTypeItemUserattributeType
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform;

    public partial class WorkflowManagedActions
    {
        public ThebotplatformActions Thebotplatform(string connectionId) => new ThebotplatformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThebotplatformTriggers Thebotplatform(string connectionId) => new ThebotplatformTriggers(connectionId);
    }
}