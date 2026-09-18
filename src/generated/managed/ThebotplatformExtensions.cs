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
        public IBodyWorkflowAction<SimpleTextMessageResponse> SimpleTextMessage([WorkflowExpression] Func<bodydataattributesmessagesInputItem[]> bodydataattributesmessages = null, [WorkflowExpression] Func<string> bodydataattributesrecipient = null)
        {
            SourceExpression.Validate(bodydataattributesmessages, nameof(bodydataattributesmessages), required: false);
            SourceExpression.Validate(bodydataattributesrecipient, nameof(bodydataattributesrecipient), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    attributesObject["messages"] = SourceExpressionConverter.ConvertToken(bodydataattributesmessages);
                    attributesObjectpropCount++;
                }

                if (bodydataattributesrecipient != null)
                {
                    attributesObject["recipient"] = SourceExpressionConverter.ConvertToken(bodydataattributesrecipient);
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
                return callPayload;
            }

            return new ApiConnectionAction<SimpleTextMessageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IBodyWorkflowAction<CreateUserAttributeResponse> CreateUserAttribute([WorkflowExpression] Func<string> bodydataattributesname = null, [WorkflowExpression] Func<bodydataattributesisPiiInput> bodydataattributesisPii = null)
        {
            SourceExpression.Validate(bodydataattributesname, nameof(bodydataattributesname), required: false);
            SourceExpression.Validate(bodydataattributesisPii, nameof(bodydataattributesisPii), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    attributesObject["name"] = SourceExpressionConverter.ConvertToken(bodydataattributesname);
                    attributesObjectpropCount++;
                }

                if (bodydataattributesisPii != null)
                {
                    attributesObject["is_pii"] = SourceExpressionConverter.Convert(bodydataattributesisPii);
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
                return callPayload;
            }

            return new ApiConnectionAction<CreateUserAttributeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thebotplatform")]
        public IWorkflowAction SetUserAttribute([WorkflowExpression] Func<string> emailaddress, [WorkflowExpression] Func<bodydataattributesstateInputItem[]> bodydataattributesstate)
        {
            SourceExpression.Validate(emailaddress, nameof(emailaddress), required: true);
            SourceExpression.Validate(bodydataattributesstate, nameof(bodydataattributesstate), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailaddress, 1));
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
                attributesObject["state"] = SourceExpressionConverter.ConvertToken(bodydataattributesstate);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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