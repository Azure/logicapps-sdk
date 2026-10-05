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
        [WorkflowExpressionFactory(nameof(__BuildGetMailboxSchema))]
        public IBodyWorkflowAction<JToken> GetMailboxSchema([WorkflowExpression] Func<string> mailboxID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetMailboxSchema(WorkflowValue<string> mailboxID)
        {
            WorkflowValue.Validate(mailboxID, nameof(mailboxID), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parser/{0}/schema", ExpressionConverter.ConvertWithUrlEncoding(mailboxID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        [WorkflowExpressionFactory(nameof(__BuildGetTableSchema))]
        public IBodyWorkflowAction<JToken> GetTableSchema([WorkflowExpression] Func<string> tableID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGetTableSchema(WorkflowValue<string> tableID)
        {
            WorkflowValue.Validate(tableID, nameof(tableID), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/table/{0}/schema", ExpressionConverter.ConvertWithUrlEncoding(tableID, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class ParseurTriggers([ConnectionName] string connectionId)
    {
        [WorkflowExpressionFactory(nameof(__BuildNewDocumentExpanded))]
        public IBodyWorkflowTrigger<JToken> NewDocumentExpanded([WorkflowExpression] Func<string> mailboxID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildNewDocumentExpanded(WorkflowValue<string> mailboxID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(mailboxID, nameof(mailboxID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parser/{0}/flow_webhook/document.processed", ExpressionConverter.ConvertWithUrlEncoding(mailboxID, 1));
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

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTemplateNeeded))]
        public IBodyWorkflowTrigger<JToken> TemplateNeeded([WorkflowExpression] Func<string> mailboxID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildTemplateNeeded(WorkflowValue<string> mailboxID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(mailboxID, nameof(mailboxID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/parser/{0}/flow_webhook/document.template_needed", ExpressionConverter.ConvertWithUrlEncoding(mailboxID, 1));
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

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildTableProcessed))]
        public IBodyWorkflowTrigger<JToken> TableProcessed([WorkflowExpression] Func<string> tableID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<JToken> __BuildTableProcessed(WorkflowValue<string> tableID, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowValue.Validate(tableID, nameof(tableID), required: true);
            return new DeferredBodyTrigger<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/table/{0}/flow_webhook/table.processed", ExpressionConverter.ConvertWithUrlEncoding(tableID, 1));
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

                return new ApiConnectionTrigger<JToken>(callPayload, triggerName, recurrence);
            }, triggerName);
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
