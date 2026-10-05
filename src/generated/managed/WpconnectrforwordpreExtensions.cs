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
        [WorkflowExpressionFactory(nameof(__BuildGetResourceById))]
        public IBodyWorkflowAction<JToken> GetResourceById([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetResourceById(WorkflowValue<string> resource, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(resource, nameof(resource), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteResource))]
        public IBodyWorkflowAction<JToken> DeleteResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildDeleteResource(WorkflowValue<string> resource, WorkflowValue<string> id, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(resource, nameof(resource), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateResource))]
        public IBodyWorkflowAction<JToken> UpdateResource([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUpdateResource(WorkflowValue<string> id, WorkflowValue<string> resource, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(resource, nameof(resource), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemsByResource))]
        public IBodyWorkflowAction<JToken[]> GetItemsByResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGetItemsByResource(WorkflowValue<string> resource, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(resource, nameof(resource), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/query", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        [WorkflowExpressionFactory(nameof(__BuildUploadMedia))]
        public IBodyWorkflowAction<JToken> UploadMedia([WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildUploadMedia(WorkflowValue<object> file)
        {
            WorkflowValue.Validate(file, nameof(file), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = "/resources/media";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        [WorkflowExpressionFactory(nameof(__BuildCreateResource))]
        public IBodyWorkflowAction<JToken> CreateResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildCreateResource(WorkflowValue<string> resource, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(resource, nameof(resource), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpconnectrforwordpre")]
        [WorkflowExpressionFactory(nameof(__BuildGetItemByResource))]
        public IBodyWorkflowAction<JToken> GetItemByResource([WorkflowExpression] Func<string> resource, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetItemByResource(WorkflowValue<string> resource, WorkflowValue<object> body = null)
        {
            WorkflowValue.Validate(resource, nameof(resource), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/{0}/fetch", ExpressionConverter.ConvertWithUrlEncoding(resource, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WpconnectrforwordpreTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildCreateTrigger))]
        public IWorkflowTrigger CreateTrigger([WorkflowExpression] Func<string> bodyresourceType, [WorkflowExpression] Func<string> bodytriggerEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateTrigger(WorkflowValue<string> bodyresourceType, WorkflowValue<string> bodytriggerEvent, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(bodyresourceType, nameof(bodyresourceType), required: true);
            WorkflowValue.Validate(bodytriggerEvent, nameof(bodytriggerEvent), required: true);
            return new DeferredWorkflowTrigger(() =>
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
            }, triggerName);
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
