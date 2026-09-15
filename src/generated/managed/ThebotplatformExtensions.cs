//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thebotplatform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThebotplatformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IBodyWorkflowAction<SimpleTextMessageResponse> SimpleTextMessage(Expression<Func<bodydataattributesmessagesInputItem[]>> bodydataattributesmessages = null, Expression<Func<string>> bodydataattributesrecipient = null)
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
                attributesObject["messages"] = CSharpExpressionConverter.ConvertToken(bodydataattributesmessages);
                attributesObjectpropCount++;
            }

            if (bodydataattributesrecipient != null)
            {
                attributesObject["recipient"] = CSharpExpressionConverter.ConvertToken(bodydataattributesrecipient);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IBodyWorkflowAction<CreateUserAttributeResponse> CreateUserAttribute(Expression<Func<string>> bodydataattributesname = null, Expression<Func<bodydataattributesisPiiInput>> bodydataattributesisPii = null)
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
                attributesObject["name"] = CSharpExpressionConverter.ConvertToken(bodydataattributesname);
                attributesObjectpropCount++;
            }

            if (bodydataattributesisPii != null)
            {
                attributesObject["is_pii"] = CSharpExpressionConverter.Convert(bodydataattributesisPii);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IWorkflowAction SetUserAttribute(Expression<Func<string>> emailaddress, Expression<Func<bodydataattributesstateInputItem[]>> bodydataattributesstate)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailaddress, 1));
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
            attributesObject["state"] = CSharpExpressionConverter.ConvertToken(bodydataattributesstate);
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