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
        public IBodyWorkflowAction<SimpleTextMessageResponse, ApiConnectionActionConfiguration> SimpleTextMessage(Expression<Func<SimpleTextMessageBodyInput>> body)
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
        public IBodyWorkflowAction<CreateUserAttributeResponse, ApiConnectionActionConfiguration> CreateUserAttribute(Expression<Func<CreateUserAttributeBodyInput>> body)
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
        public IWorkflowAction<ApiConnectionActionConfiguration> SetUserAttribute(Expression<Func<string>> emailaddress, Expression<Func<SetUserAttributeBodyInput>> body)
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

    public class SimpleTextMessageBodyInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SimpleTextMessageBodyInputDataType Data { get; set; } = new SimpleTextMessageBodyInputDataType();
    }

    public class SimpleTextMessageBodyInputDataType
    {
        [JsonProperty("attributes")]
        public SimpleTextMessageBodyInputDataTypeAttributesType Attributes { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal SimpleTextMessageBodyInputDataTypeTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform.SimpleTextMessageBodyInputDataTypeTypeType.ExternalActivity;
    }

    public class SimpleTextMessageBodyInputDataTypeAttributesType
    {
        [JsonProperty("messages")]
        public BodyInputDataTypeAttributesTypeMessagesTypeItem[] Messages { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class BodyInputDataTypeAttributesTypeMessagesTypeItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleTextMessageBodyInputDataTypeTypeType
    {
        [EnumMember(Value = "external-activity")]
        ExternalActivity
    }

    public class CreateUserAttributeResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    public class CreateUserAttributeBodyInput
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateUserAttributeBodyInputDataType Data { get; set; } = new CreateUserAttributeBodyInputDataType();
    }

    public class CreateUserAttributeBodyInputDataType
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "userattribute";

        [JsonProperty("attributes")]
        public CreateUserAttributeBodyInputDataTypeAttributesType Attributes { get; set; }
    }

    public class CreateUserAttributeBodyInputDataTypeAttributesType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_pii")]
        public BodyInputDataTypeAttributesTypeIsPiiType? IsPii { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDataTypeAttributesTypeIsPiiType
    {
        Yes,
        No
    }

    public class SetUserAttributeBodyInput
    {
        public SetUserAttributeBodyInput(SetUserAttributeBodyInputDataType data)
        {
            this.Data = data;
        }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUserAttributeBodyInputDataType Data { get; set; }
    }

    public class SetUserAttributeBodyInputDataType
    {
        public SetUserAttributeBodyInputDataType(SetUserAttributeBodyInputDataTypeAttributesType attributes)
        {
            this.Attributes = attributes;
        }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal SetUserAttributeBodyInputDataTypeTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform.SetUserAttributeBodyInputDataTypeTypeType.User;

        [JsonProperty("attributes", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUserAttributeBodyInputDataTypeAttributesType Attributes { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetUserAttributeBodyInputDataTypeTypeType
    {
        [EnumMember(Value = "user")]
        User
    }

    public class SetUserAttributeBodyInputDataTypeAttributesType
    {
        public SetUserAttributeBodyInputDataTypeAttributesType(BodyInputDataTypeAttributesTypeStateTypeItem[] state)
        {
            this.State = state;
        }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDataTypeAttributesTypeStateTypeItem[] State { get; set; }
    }

    public class BodyInputDataTypeAttributesTypeStateTypeItem
    {
        public BodyInputDataTypeAttributesTypeStateTypeItem(BodyInputDataTypeAttributesTypeStateTypeItemUserattributeType userattribute)
        {
            this.Userattribute = userattribute;
        }

        [JsonProperty("userattribute", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDataTypeAttributesTypeStateTypeItemUserattributeType Userattribute { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class BodyInputDataTypeAttributesTypeStateTypeItemUserattributeType
    {
        public BodyInputDataTypeAttributesTypeStateTypeItemUserattributeType(string id)
        {
            this.Id = id;
        }

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