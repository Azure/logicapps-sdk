//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wpformsbyreenhancedl
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WpformsbyreenhancedlActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntries))]
        public IBodyWorkflowAction<GetEntriesResponseItem[]> GetEntries([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<object> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetEntriesResponseItem[]> __BuildGetEntries(WorkflowExpression<string> formId, WorkflowExpression<object> body = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<GetEntriesResponseItem[]>(() =>
            {
                var apiCallPath = "/resources/entries/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<GetEntriesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        [WorkflowExpressionFactory(nameof(__BuildGetEntry))]
        public IBodyWorkflowAction<JToken> GetEntry([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> formId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetEntry(WorkflowExpression<string> id, WorkflowExpression<string> formId)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WpformsbyreenhancedlTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCreateFlow))]
        public IWorkflowTrigger CreateFlow([WorkflowExpression] Func<string> bodyformID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildCreateFlow(WorkflowExpression<string> bodyformID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyformID, nameof(bodyformID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/resources/flows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["form_id"] = ExpressionConverter.ConvertO(bodyformID);
                var metaObject = new JObject();
                var metaObjectpropCount = 0;
                metaObject["powerAutomateUrl"] = "#{listCallbackUrl()}";
                metaObjectpropCount++;
                if (metaObjectpropCount > 0)
                {
                    body["meta"] = metaObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
            }, triggerName);
        }
    }

    public class GetEntriesResponseItem
    {
        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wpformsbyreenhancedl;

    public partial class WorkflowManagedActions
    {
        public WpformsbyreenhancedlActions Wpformsbyreenhancedl(string connectionId) => new WpformsbyreenhancedlActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WpformsbyreenhancedlTriggers Wpformsbyreenhancedl(string connectionId) => new WpformsbyreenhancedlTriggers(connectionId);
    }
}