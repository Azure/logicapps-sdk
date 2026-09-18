//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wpconnectrforwordpre
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WpconnectrforwordpreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> GetResourceById([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> DeleteResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> UpdateResource([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken[]> GetItemsByResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/{0}/query", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> UploadMedia([WorkflowExpression] Func<object> file)
        {
            SourceExpression.Validate(file, nameof(file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> CreateResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> GetItemByResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(resource, nameof(resource), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/{0}/fetch", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class WpconnectrforwordpreTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTrigger([WorkflowExpression] Func<string> bodyresourceType, [WorkflowExpression] Func<string> bodytriggerEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodyresourceType, nameof(bodyresourceType), required: true);
            SourceExpression.Validate(bodytriggerEvent, nameof(bodytriggerEvent), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/triggers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["trigger_resource_schema"] = SourceExpressionConverter.ConvertToken(bodyresourceType);
                bodypropCount++;
                body["topic"] = SourceExpressionConverter.ConvertToken(bodytriggerEvent);
                body["delivery_url"] = "@listCallbackUrl()";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wpconnectrforwordpre;

    public partial class WorkflowManagedActions
    {
        public WpconnectrforwordpreActions Wpconnectrforwordpre(string connectionId) => new WpconnectrforwordpreActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WpconnectrforwordpreTriggers Wpconnectrforwordpre(string connectionId) => new WpconnectrforwordpreTriggers(connectionId);
    }
}