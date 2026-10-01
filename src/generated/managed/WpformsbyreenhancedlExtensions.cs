//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wpformsbyreenhancedl
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WpformsbyreenhancedlActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        public IBodyWorkflowAction<GetEntriesResponseItem[]> GetEntries([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<object> body = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/entries/query";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = SourceExpressionConverter.ConvertO(formId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<GetEntriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wpformsbyreenhancedl")]
        public IBodyWorkflowAction<JToken> GetEntry([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> formId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/entries/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["form_id"] = SourceExpressionConverter.ConvertO(formId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class WpformsbyreenhancedlTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CreateFlow([WorkflowExpression] Func<string> bodyformId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/resources/flows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["form_id"] = SourceExpressionConverter.ConvertToken(bodyformId);
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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