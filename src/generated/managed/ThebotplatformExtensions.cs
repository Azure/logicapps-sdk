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
        public IBodyWorkflowAction<SimpleTextMessageResponse> SimpleTextMessage(Expression<Func<bodydataattributesmessagesInputItem[]>> bodydataattributesmessages = null, Expression<Func<string>> bodydataattributesrecipient = null)
        {
            var __workflow_bodydataattributesmessages = WorkflowExpression.Compile(bodydataattributesmessages, nameof(bodydataattributesmessages), required: false);
            var __workflow_bodydataattributesrecipient = WorkflowExpression.Compile(bodydataattributesrecipient, nameof(bodydataattributesrecipient), required: false);
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
                if (__workflow_bodydataattributesmessages != null)
                {
                    attributesObject["messages"] = ExpressionConverter.ConvertO(__workflow_bodydataattributesmessages);
                    attributesObjectpropCount++;
                }

                if (__workflow_bodydataattributesrecipient != null)
                {
                    attributesObject["recipient"] = ExpressionConverter.ConvertO(__workflow_bodydataattributesrecipient);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IBodyWorkflowAction<CreateUserAttributeResponse> CreateUserAttribute(Expression<Func<string>> bodydataattributesname = null, Expression<Func<bodydataattributesisPiiInput>> bodydataattributesisPii = null)
        {
            var __workflow_bodydataattributesname = WorkflowExpression.Compile(bodydataattributesname, nameof(bodydataattributesname), required: false);
            var __workflow_bodydataattributesisPii = WorkflowExpression.Compile(bodydataattributesisPii, nameof(bodydataattributesisPii), required: false);
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
                if (__workflow_bodydataattributesname != null)
                {
                    attributesObject["name"] = ExpressionConverter.ConvertO(__workflow_bodydataattributesname);
                    attributesObjectpropCount++;
                }

                if (__workflow_bodydataattributesisPii != null)
                {
                    attributesObject["is_pii"] = ExpressionConverter.ConvertO(__workflow_bodydataattributesisPii);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IWorkflowAction SetUserAttribute(Expression<Func<string>> emailaddress, Expression<Func<bodydataattributesstateInputItem[]>> bodydataattributesstate)
        {
            var __workflow_emailaddress = WorkflowExpression.Compile(emailaddress, nameof(emailaddress), required: true);
            var __workflow_bodydataattributesstate = WorkflowExpression.Compile(bodydataattributesstate, nameof(bodydataattributesstate), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}", __workflow_emailaddress.WithUrlEncoding(1)));
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
                attributesObject["state"] = ExpressionConverter.ConvertO(__workflow_bodydataattributesstate);
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
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
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
