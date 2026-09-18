//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parseur
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParseurActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<ListMailboxItem[]> ListMailbox()
        {
            var apiCallPath = "/user/parser_set";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListMailboxItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<ListTableItem[]> ListTable()
        {
            var apiCallPath = "/user/table_set";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListTableItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<JToken> GetMailboxSchema([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> mailboxID)
        {
            var apiCallPath = String.Format("/parser/{0}/schema", ExpressionConverter.ConvertWithUrlEncoding(mailboxID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<JToken> GetTableSchema([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tableID)
        {
            var apiCallPath = String.Format("/table/{0}/schema", ExpressionConverter.ConvertWithUrlEncoding(tableID, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ParseurTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> NewDocumentExpanded([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> mailboxID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/parser/{0}/flow_webhook/document.processed", ExpressionConverter.ConvertWithUrlEncoding(mailboxID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> TemplateNeeded([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> mailboxID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/parser/{0}/flow_webhook/document.template_needed", ExpressionConverter.ConvertWithUrlEncoding(mailboxID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> TableProcessed([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> tableID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/table/{0}/flow_webhook/table.processed", ExpressionConverter.ConvertWithUrlEncoding(tableID, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["target"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
        }
    }

    public class ListMailboxItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListTableItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Parseur;

    public partial class WorkflowManagedActions
    {
        public ParseurActions Parseur(string connectionId) => new ParseurActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ParseurTriggers Parseur(string connectionId) => new ParseurTriggers(connectionId);
    }
}