//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wpformsbyreenhancedl
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class WpformsbyreenhancedlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        public IBodyWorkflowAction<GetEntriesResponseItem[]> GetEntries(Expression<Func<string>> formId, Expression<Func<object>> body = null)
        {
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<GetEntriesResponseItem[]>(() =>
            {
                var apiCallPath = "/resources/entries/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetEntriesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        public IBodyWorkflowAction<JToken> GetEntry(Expression<Func<string>> id, Expression<Func<string>> formId)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_formId = formId == null ? null : WorkflowExpression.Compile(formId);
            WorkflowExpression.Validate(__workflow_formId, nameof(formId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/resources/entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = ExpressionConverter.Convert(__workflow_formId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class WpformsbyreenhancedlTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateFlow(Expression<Func<string>> bodyformID, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyformID = bodyformID == null ? null : WorkflowExpression.Compile(bodyformID);
            WorkflowExpression.Validate(__workflow_bodyformID, nameof(bodyformID), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/resources/flows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["form_id"] = ExpressionConverter.ConvertO(__workflow_bodyformID);
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

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
