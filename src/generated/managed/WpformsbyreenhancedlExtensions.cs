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
        public IBodyWorkflowAction<GetEntriesResponseItem[]> GetEntries([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<object> body = null)
        {
            var apiCallPath = "/resources/entries/query";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<GetEntriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        public IBodyWorkflowAction<JToken> GetEntry([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> formId)
        {
            var apiCallPath = String.Format("/resources/entries/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["form_id"] = ExpressionConverter.Convert(formId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class WpformsbyreenhancedlTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateFlow([WorkflowExpression] Func<string> bodyformID, string triggerName = null, FlowRecurrence recurrence = null)
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
            metaObject["powerAutomateUrl"] = "@listCallbackUrl()";
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