//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parseur
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<JToken> GetMailboxSchema(Expression<Func<string>> mailboxID)
        {
            var __workflow_mailboxID = WorkflowExpression.Compile(mailboxID, nameof(mailboxID), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parser/{0}/schema", ExpressionConverter.ConvertWithUrlEncoding(__workflow_mailboxID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<JToken> GetTableSchema(Expression<Func<string>> tableID)
        {
            var __workflow_tableID = WorkflowExpression.Compile(tableID, nameof(tableID), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/table/{0}/schema", ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ParseurTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> NewDocumentExpanded(Expression<Func<string>> mailboxID, FlowRecurrence recurrence = null)
        {
            var __workflow_mailboxID = WorkflowExpression.Compile(mailboxID, nameof(mailboxID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parser/{0}/flow_webhook/document.processed", ExpressionConverter.ConvertWithUrlEncoding(__workflow_mailboxID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> TemplateNeeded(Expression<Func<string>> mailboxID, FlowRecurrence recurrence = null)
        {
            var __workflow_mailboxID = WorkflowExpression.Compile(mailboxID, nameof(mailboxID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parser/{0}/flow_webhook/document.template_needed", ExpressionConverter.ConvertWithUrlEncoding(__workflow_mailboxID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<JToken> TableProcessed(Expression<Func<string>> tableID, FlowRecurrence recurrence = null)
        {
            var __workflow_tableID = WorkflowExpression.Compile(tableID, nameof(tableID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/table/{0}/flow_webhook/table.processed", ExpressionConverter.ConvertWithUrlEncoding(__workflow_tableID, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["target"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<JToken>(callPayload, recurrence: recurrence);
            });
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
