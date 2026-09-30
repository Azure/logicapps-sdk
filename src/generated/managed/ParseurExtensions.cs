//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Parseur
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ParseurActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<ListMailboxItem[]> ListMailbox()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/parser_set";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListMailboxItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<ListTableItem[]> ListTable()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/table_set";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListTableItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<JToken> GetMailboxSchema([WorkflowExpression] Func<string> mailboxId)
        {
            SourceExpression.Validate(mailboxId, nameof(mailboxId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/parser/{0}/schema", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailboxId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "parseur")]
        public IBodyWorkflowAction<JToken> GetTableSchema([WorkflowExpression] Func<string> tableId)
        {
            SourceExpression.Validate(tableId, nameof(tableId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/table/{0}/schema", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class ParseurTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<JToken> NewDocumentExpanded([WorkflowExpression] Func<string> mailboxId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(mailboxId, nameof(mailboxId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/parser/{0}/flow_webhook/document.processed", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailboxId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> TemplateNeeded([WorkflowExpression] Func<string> mailboxId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(mailboxId, nameof(mailboxId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/parser/{0}/flow_webhook/document.template_needed", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(mailboxId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<JToken> TableProcessed([WorkflowExpression] Func<string> tableId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(tableId, nameof(tableId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/table/{0}/flow_webhook/table.processed", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger<JToken>(BuildSourceInput, triggerName, recurrence);
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