//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wpconnectrforwordpre
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WpconnectrforwordpreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> GetResourceById([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resource, [WorkflowExpression] Func<string> id)
        {
            var apiCallPath = String.Format("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> DeleteResource([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resource, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> UpdateResource([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken[]> GetItemsByResource([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/resources/{0}/query", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> UploadMedia([WorkflowExpression] Func<object> file)
        {
            var apiCallPath = "/resources/media";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> CreateResource([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/resources/{0}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> GetItemByResource([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = String.Format("/resources/{0}/fetch", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class WpconnectrforwordpreTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTrigger([WorkflowExpression] Func<string> bodyresourceType, [WorkflowExpression] Func<string> bodytriggerEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/triggers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["trigger_resource_schema"] = ExpressionConverter.ConvertO(bodyresourceType);
            bodypropCount++;
            body["topic"] = ExpressionConverter.ConvertO(bodytriggerEvent);
            body["delivery_url"] = "#{listCallbackUrl()}";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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