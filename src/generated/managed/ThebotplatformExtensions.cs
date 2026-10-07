//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThebotplatformActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        [WorkflowExpressionFactory(nameof(__BuildSimpleTextMessage))]
        public IBodyWorkflowAction<SimpleTextMessageResponse> SimpleTextMessage([WorkflowExpression] Func<bodydataattributesmessagesInputItem[]> bodydataattributesmessages = null, [WorkflowExpression] Func<string> bodydataattributesrecipient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SimpleTextMessageResponse> __BuildSimpleTextMessage(WorkflowExpression<bodydataattributesmessagesInputItem[]> bodydataattributesmessages = null, WorkflowExpression<string> bodydataattributesrecipient = null)
        {
            WorkflowExpression.Validate(bodydataattributesmessages, nameof(bodydataattributesmessages), required: false);
            WorkflowExpression.Validate(bodydataattributesrecipient, nameof(bodydataattributesrecipient), required: false);
            return new DeferredBodyAction<SimpleTextMessageResponse>(() =>
            {
                var apiCallPath = "/v1.0/activity/external";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                if (bodydataattributesmessages != null)
                {
                    attributesObject["messages"] = ExpressionConverter.ConvertO(bodydataattributesmessages);
                    attributesObjectpropCount++;
                }

                if (bodydataattributesrecipient != null)
                {
                    attributesObject["recipient"] = ExpressionConverter.ConvertO(bodydataattributesrecipient);
                    attributesObjectpropCount++;
                }

                if (attributesObjectpropCount > 0)
                {
                    dataObject["attributes"] = attributesObject;
                    dataObjectpropCount++;
                }

                dataObject["type"] = "external-activity";
                dataObjectpropCount++;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SimpleTextMessageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        [WorkflowExpressionFactory(nameof(__BuildCreateUserAttribute))]
        public IBodyWorkflowAction<CreateUserAttributeResponse> CreateUserAttribute([WorkflowExpression] Func<string> bodydataattributesname = null, [WorkflowExpression] Func<bodydataattributesisPiiInput> bodydataattributesisPii = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateUserAttributeResponse> __BuildCreateUserAttribute(WorkflowExpression<string> bodydataattributesname = null, WorkflowExpression<bodydataattributesisPiiInput> bodydataattributesisPii = null)
        {
            WorkflowExpression.Validate(bodydataattributesname, nameof(bodydataattributesname), required: false);
            WorkflowExpression.Validate(bodydataattributesisPii, nameof(bodydataattributesisPii), required: false);
            return new DeferredBodyAction<CreateUserAttributeResponse>(() =>
            {
                var apiCallPath = "/v1.0/userattributes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                dataObject["type"] = "userattribute";
                dataObjectpropCount++;
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                if (bodydataattributesname != null)
                {
                    attributesObject["name"] = ExpressionConverter.ConvertO(bodydataattributesname);
                    attributesObjectpropCount++;
                }

                if (bodydataattributesisPii != null)
                {
                    attributesObject["is_pii"] = ExpressionConverter.ConvertO(bodydataattributesisPii);
                    attributesObjectpropCount++;
                }

                if (attributesObjectpropCount > 0)
                {
                    dataObject["attributes"] = attributesObject;
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateUserAttributeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        [WorkflowExpressionFactory(nameof(__BuildSetUserAttribute))]
        public IWorkflowAction SetUserAttribute([WorkflowExpression] Func<string> emailaddress, [WorkflowExpression] Func<bodydataattributesstateInputItem[]> bodydataattributesstate)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSetUserAttribute(WorkflowExpression<string> emailaddress, WorkflowExpression<bodydataattributesstateInputItem[]> bodydataattributesstate)
        {
            WorkflowExpression.Validate(emailaddress, nameof(emailaddress), required: true);
            WorkflowExpression.Validate(bodydataattributesstate, nameof(bodydataattributesstate), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}", ExpressionConverter.ConvertWithUrlEncoding(emailaddress, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                dataObject["type"] = "user";
                dataObjectpropCount++;
                var attributesObject = new JObject();
                var attributesObjectpropCount = 0;
                attributesObjectpropCount++;
                attributesObject["state"] = ExpressionConverter.ConvertO(bodydataattributesstate);
                if (attributesObjectpropCount > 0)
                {
                    dataObject["attributes"] = attributesObject;
                    dataObjectpropCount++;
                }

                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    public class bodydataattributesmessagesInputItem
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateUserAttributeResponse
    {
        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodydataattributesisPiiInput
    {
        Yes,
        No
    }

    public class bodydataattributesstateInputItem
    {
        [JsonProperty("userattribute")]
        public bodydataattributesstateInputItemUserattributeType Userattribute { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodydataattributesstateInputItemUserattributeType
    {
        [JsonProperty("id")]
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