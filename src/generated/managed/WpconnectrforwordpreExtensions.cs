//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wpconnectrforwordpre
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class WpconnectrforwordpreActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> GetResourceById(Expression<Func<string>> resource, Expression<Func<string>> id)
        {
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_resource, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> DeleteResource(Expression<Func<string>> resource, Expression<Func<string>> id, Expression<Func<object>> body = null)
        {
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_resource, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> UpdateResource(Expression<Func<string>> id, Expression<Func<string>> resource, Expression<Func<object>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_resource, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken[]> GetItemsByResource(Expression<Func<string>> resource, Expression<Func<object>> body = null)
        {
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/query", ExpressionConverter.ConvertWithUrlEncoding(__workflow_resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> UploadMedia(Expression<Func<object>> file)
        {
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/resources/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> CreateResource(Expression<Func<string>> resource, Expression<Func<object>> body = null)
        {
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        public IBodyWorkflowAction<JToken> GetItemByResource(Expression<Func<string>> resource, Expression<Func<object>> body = null)
        {
            var __workflow_resource = WorkflowExpression.Compile(resource, nameof(resource), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/fetch", ExpressionConverter.ConvertWithUrlEncoding(__workflow_resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WpconnectrforwordpreTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateTrigger(Expression<Func<string>> bodyresourceType, Expression<Func<string>> bodytriggerEvent, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyresourceType = WorkflowExpression.Compile(bodyresourceType, nameof(bodyresourceType), required: true);
            var __workflow_bodytriggerEvent = WorkflowExpression.Compile(bodytriggerEvent, nameof(bodytriggerEvent), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/triggers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["trigger_resource_schema"] = ExpressionConverter.ConvertO(__workflow_bodyresourceType);
                bodypropCount++;
                body["topic"] = ExpressionConverter.ConvertO(__workflow_bodytriggerEvent);
                body["delivery_url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
