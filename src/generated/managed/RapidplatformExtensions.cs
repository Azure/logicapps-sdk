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
        public IBodyWorkflowAction<JToken> GetAllItems(Expression<Func<string>> listNameDynamic, Expression<Func<string>> skip = null, Expression<Func<string>> filter = null, Expression<Func<string>> select = null, Expression<Func<string>> linkedTo = null)
        {
            var apiCallPath = String.Format("/lists/{0}/All/items", ExpressionConverter.ConvertWithUrlEncoding(listNameDynamic, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (skip != null)
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
            if (filter != null)
                callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
            if (select != null)
                callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
            if (linkedTo != null)
                callPayload.Queries["linkedTo"] = ExpressionConverter.Convert(linkedTo);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken[]> CreateListItem(Expression<Func<string>> listNameDynamic, Expression<Func<object>> dynamicListSchema = null)
        {
            var apiCallPath = String.Format("/lists/{0}/All/items", ExpressionConverter.ConvertWithUrlEncoding(listNameDynamic, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicListSchema);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId)
        {
            var apiCallPath = String.Format("/lists/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listNameDynamic, 1), ExpressionConverter.ConvertWithUrlEncoding(itemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IWorkflowAction UpdateListItem(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId, Expression<Func<object>> dynamicListSchema = null)
        {
            var apiCallPath = String.Format("/lists/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(listNameDynamic, 1), ExpressionConverter.ConvertWithUrlEncoding(itemId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicListSchema);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<string[]> GetInheritLinks(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId, Expression<Func<string>> type)
        {
            var apiCallPath = String.Format("/lists/{0}/items/{1}/inherited-links", ExpressionConverter.ConvertWithUrlEncoding(listNameDynamic, 1), ExpressionConverter.ConvertWithUrlEncoding(itemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<string[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rapidplatform")]
        public IBodyWorkflowAction<JToken> SetAttachments(Expression<Func<string>> listNameDynamic, Expression<Func<int>> itemId, Expression<Func<attachmentsInputItem[]>> attachments = null)
        {
            var apiCallPath = String.Format("/lists/{0}/items/{1}/attachments", ExpressionConverter.ConvertWithUrlEncoding(listNameDynamic, 1), ExpressionConverter.ConvertWithUrlEncoding(itemId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(attachments);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class RapidplatformTriggers([ConnectionName] string connectionId)
    {
    }

    public class attachmentsInputItem
    {
        [JsonProperty("drive_id")]
        public string DriveID { get; set; }

        [JsonProperty("drive_item_id")]
        public string DriveItemID { get; set; }
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