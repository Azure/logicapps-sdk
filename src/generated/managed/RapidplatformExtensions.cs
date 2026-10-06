//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rapidplatform
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RapidplatformActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken> GetAllItems([WorkflowExpression] Func<string> listNameDynamic, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> linkedTo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/All/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listNameDynamic, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (linkedTo != null)
                    callPayload.Queries["linkedTo"] = SourceExpressionConverter.ConvertO(linkedTo);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken[]> CreateListItem([WorkflowExpression] Func<string> listNameDynamic, [WorkflowExpression] Func<object> dynamicListSchema = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/All/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listNameDynamic, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicListSchema);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> listNameDynamic, [WorkflowExpression] Func<int> itemId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listNameDynamic, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IWorkflowAction UpdateListItem([WorkflowExpression] Func<string> listNameDynamic, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<object> dynamicListSchema = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/items/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listNameDynamic, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicListSchema);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<string[]> GetInheritLinks([WorkflowExpression] Func<string> listNameDynamic, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> type)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/items/{1}/inherited-links", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listNameDynamic, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                return callPayload;
            }

            return new ApiConnectionAction<string[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken> SetAttachments([WorkflowExpression] Func<string> listNameDynamic, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<attachmentsInputItem[]> attachments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/items/{1}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listNameDynamic, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(attachments);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }
    }

    public class RapidplatformTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ListHookTrigger([WorkflowExpression] Func<string> requestBodyOfWebhookconfigtable = null, [WorkflowExpression] Func<requestBodyOfWebhookconfigtriggerTypeInput> requestBodyOfWebhookconfigtriggerType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                var configObject = new JObject();
                var configObjectpropCount = 0;
                configObject["url"] = "#{listCallbackUrl()}";
                configObjectpropCount++;
                if (requestBodyOfWebhookconfigtable != null)
                {
                    configObject["list"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookconfigtable);
                    configObjectpropCount++;
                }

                if (requestBodyOfWebhookconfigtriggerType != null)
                {
                    configObject["trigger"] = SourceExpressionConverter.Convert(requestBodyOfWebhookconfigtriggerType);
                    configObjectpropCount++;
                }

                if (configObjectpropCount > 0)
                {
                    requestBodyOfWebhook["config"] = configObject;
                    requestBodyOfWebhookpropCount++;
                }

                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class attachmentsInputItem
    {
        [JsonProperty("drive_id")]
        public string DriveID { get; set; }

        [JsonProperty("drive_item_id")]
        public string DriveItemID { get; set; }
    }

    public enum requestBodyOfWebhookconfigtriggerTypeInput
    {
        [EnumMember(Value = "Item Created")]
        ItemCreated,
        [EnumMember(Value = "Item Updated")]
        ItemUpdated,
        [EnumMember(Value = "Item Deleted")]
        ItemDeleted
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rapidplatform;

    public partial class WorkflowManagedActions
    {
        public RapidplatformActions Rapidplatform(string connectionId) => new RapidplatformActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RapidplatformTriggers Rapidplatform(string connectionId) => new RapidplatformTriggers(connectionId);
    }
}