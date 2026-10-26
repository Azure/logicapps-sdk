//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Rowshare
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RowshareActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rowshare")]
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> AssignRow(Expression<Func<AssignRowInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Row, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/row/assign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Row>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rowshare")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFileContent(Expression<Func<string>> blobId)
        {
            var __workflow_blobId = WorkflowExpression.Compile(blobId, nameof(blobId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/blob/{0}/4", __workflow_blobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rowshare")]
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> CreateRow(Expression<Func<CreateRowInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Row, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/row/create";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Row>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rowshare")]
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> EditRow(Expression<Func<EditRowInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Row, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/row/save";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Row>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rowshare")]
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> LinkRow(Expression<Func<LinkRowInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Row, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/row/saveLinkedRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Row>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rowshare")]
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> LoadRowById(Expression<Func<LoadRowByIdInput>> body, Expression<Func<string>> rowId)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_rowId = WorkflowExpression.Compile(rowId, nameof(rowId), required: true);
            return new DeferredBodyAction<Row, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/row/load/{0}", __workflow_rowId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Row>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "rowshare")]
        public IBodyWorkflowAction<Row[], ApiConnectionActionConfiguration> FindRows(Expression<Func<FindRowsInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Row[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/row/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Row[]>(callPayload);
            });
        }
    }

    public class RowshareTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<NewOrUpdatedRowResponse, ApiConnectionTriggerConfiguration> NewOrUpdatedRow(Expression<Func<string>> listId, FlowRecurrence recurrence = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<NewOrUpdatedRowResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/application/GetRecentlyModifiedRows/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                return new ApiConnectionTrigger<NewOrUpdatedRowResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<RowStatusChangedResponse, ApiConnectionTriggerConfiguration> RowStatusChanged(Expression<Func<RowStatusChangedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<RowStatusChangedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/application/subscribe/8";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<RowStatusChangedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ColumnChangedResponse, ApiConnectionTriggerConfiguration> ColumnChanged(Expression<Func<ColumnChangedInput>> body = null, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyTrigger<ColumnChangedResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/application/subscribe/16";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<ColumnChangedResponse>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<NewRowResponse, ApiConnectionTriggerConfiguration> NewRow(Expression<Func<string>> listId, FlowRecurrence recurrence = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<NewRowResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/application/GetRecentlyCreatedRows/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                return new ApiConnectionTrigger<NewRowResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class Row
    {
        public string Id { get; set; }
        public string ListId { get; set; }
        public int Index { get; set; }
        public string ModifiedDateUtc { get; set; }
        public string ModifiedByNickName { get; set; }
        public string ModifiedByEmail { get; set; }
        public string CreatedDateUtc { get; set; }
        public string CreatedByNickName { get; set; }
        public string CreatedByEmail { get; set; }
        public RowOwnerType Owner { get; set; }
        public string OwnerManagerName { get; set; }
        public int Status { get; set; }
        public string StatusDateUtc { get; set; }
        public string StatusChangeByUserName { get; set; }
        public JToken Values { get; set; }
    }

    public class RowOwnerType
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
    }

    public class AssignRowInput
    {
        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int OwnerIdType { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Version { get; set; }
    }

    public class CreateRowInput
    {
        public string ListId { get; set; }
        public JToken Values { get; set; }
    }

    public class EditRowInput
    {
        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Version { get; set; }
        public JToken Values { get; set; }
    }

    public class LinkRowInput
    {
        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Version { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Values { get; set; } = JToken.Parse("{}");

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public LinkRowInputParentRowsTypeItem[] ParentRows { get; set; }
    }

    public class LinkRowInputParentRowsTypeItem
    {
        public string ChildRowId { get; set; }
        public string ParentRowId { get; set; }
        public string RelationColumnId { get; set; }
    }

    public class LoadRowByIdInput
    {
        public string ListId { get; set; }
    }

    public class FindRowsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class NewOrUpdatedRowResponse
    {
        public string LastModifiedDate { get; set; }
        public NewOrUpdatedRowResponseRowsTypeItem[] Rows { get; set; }
    }

    public class NewOrUpdatedRowResponseRowsTypeItem
    {
        public string Id { get; set; }
        public string ListId { get; set; }
        public int Index { get; set; }
        public string ModifiedDateUtc { get; set; }
        public string ModifiedByNickName { get; set; }
        public string ModifiedByEmail { get; set; }
        public string CreatedDateUtc { get; set; }
        public string CreatedByNickName { get; set; }
        public string CreatedByEmail { get; set; }
        public NewOrUpdatedRowResponseRowsTypeItemOwnerType Owner { get; set; }
        public string OwnerManagerName { get; set; }
        public int Status { get; set; }
        public string StatusDateUtc { get; set; }
        public string StatusChangeByUserName { get; set; }
        public JToken Values { get; set; }
    }

    public class NewOrUpdatedRowResponseRowsTypeItemOwnerType
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
    }

    public class RowStatusChangedResponse
    {
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }
    }

    public class RowStatusChangedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int EventType { get; set; } = 8;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ApplicationId { get; set; } = "423c6b2d524a4c4a97c58c0952d30160";
    }

    public class ColumnChangedResponse
    {
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }
    }

    public class ColumnChangedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string TargetUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ColumnId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int EventType { get; set; } = 16;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string ApplicationId { get; set; } = "423c6b2d524a4c4a97c58c0952d30160";
    }

    public class NewRowResponse
    {
        public string LastCreatedDate { get; set; }
        public NewRowResponseRowsTypeItem[] Rows { get; set; }
    }

    public class NewRowResponseRowsTypeItem
    {
        public string Id { get; set; }
        public string ListId { get; set; }
        public int Index { get; set; }
        public string ModifiedDateUtc { get; set; }
        public string ModifiedByNickName { get; set; }
        public string ModifiedByEmail { get; set; }
        public string CreatedDateUtc { get; set; }
        public string CreatedByNickName { get; set; }
        public string CreatedByEmail { get; set; }
        public NewRowResponseRowsTypeItemOwnerType Owner { get; set; }
        public string OwnerManagerName { get; set; }
        public int Status { get; set; }
        public string StatusDateUtc { get; set; }
        public string StatusChangeByUserName { get; set; }
        public JToken Values { get; set; }
    }

    public class NewRowResponseRowsTypeItemOwnerType
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Rowshare;

    public partial class WorkflowManagedActions
    {
        public RowshareActions Rowshare(string connectionId) => new RowshareActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RowshareTriggers Rowshare(string connectionId) => new RowshareTriggers(connectionId);
    }
}