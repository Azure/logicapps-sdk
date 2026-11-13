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
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> AssignRow(Expression<Func<AssignRowBodyInput>> body)
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
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> CreateRow(Expression<Func<CreateRowBodyInput>> body)
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
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> EditRow(Expression<Func<EditRowBodyInput>> body)
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
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> LinkRow(Expression<Func<LinkRowBodyInput>> body)
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
        public IBodyWorkflowAction<Row, ApiConnectionActionConfiguration> LoadRowById(Expression<Func<LoadRowByIdBodyInput>> body, Expression<Func<string>> rowId)
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
        public IBodyWorkflowAction<Row[], ApiConnectionActionConfiguration> FindRows(Expression<Func<FindRowsBodyInput>> body)
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
        public IBodyWorkflowTrigger<NewOrUpdatedRowResponse, ApiConnectionPollingTriggerConfiguration> NewOrUpdatedRow(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<NewOrUpdatedRowResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/application/GetRecentlyModifiedRows/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                return new ApiConnectionPollingTrigger<NewOrUpdatedRowResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<RowStatusChangedResponse, ApiConnectionPollingTriggerConfiguration> RowStatusChanged(Expression<Func<RowStatusChangedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<RowStatusChangedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/application/subscribe/8";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<RowStatusChangedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<ColumnChangedResponse, ApiConnectionPollingTriggerConfiguration> ColumnChanged(Expression<Func<ColumnChangedBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<ColumnChangedResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/api/application/subscribe/16";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<ColumnChangedResponse>(callPayload);
            });
        }

        public IBodyWorkflowTrigger<NewRowResponse, ApiConnectionPollingTriggerConfiguration> NewRow(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyTrigger<NewRowResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/application/GetRecentlyCreatedRows/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["v3"] = Convert.ToString(true);
                return new ApiConnectionPollingTrigger<NewRowResponse>(callPayload);
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

    public class AssignRowBodyInput
    {
        public AssignRowBodyInput(string id, string ownerId)
        {
            this.Id = id;
            this.OwnerId = ownerId;
        }

        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OwnerId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal int OwnerIdType { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Version { get; set; } = "0000000000000000";
    }

    public class CreateRowBodyInput
    {
        public string ListId { get; set; }
        public JToken Values { get; set; }
    }

    public class EditRowBodyInput
    {
        public EditRowBodyInput(string id)
        {
            this.Id = id;
        }

        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Version { get; set; } = "0000000000000000";
        public JToken Values { get; set; }
    }

    public class LinkRowBodyInput
    {
        public LinkRowBodyInput(string id, BodyInputParentRowsTypeItem[] parentRows)
        {
            this.Id = id;
            this.ParentRows = parentRows;
        }

        public string ListId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Version { get; set; } = "0000000000000000";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal JToken Values { get; set; } = JToken.Parse("{}");

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputParentRowsTypeItem[] ParentRows { get; set; }
    }

    public class BodyInputParentRowsTypeItem
    {
        public string ChildRowId { get; set; }
        public string ParentRowId { get; set; }
        public string RelationColumnId { get; set; }
    }

    public class LoadRowByIdBodyInput
    {
        public string ListId { get; set; }
    }

    public class FindRowsBodyInput
    {
        public FindRowsBodyInput(string listId, string columnName, string value)
        {
            this.ListId = listId;
            this.ColumnName = columnName;
            this.Value = value;
        }

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

    public class RowStatusChangedBodyInput
    {
        public RowStatusChangedBodyInput(string listId)
        {
            this.ListId = listId;
        }

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

    public class ColumnChangedBodyInput
    {
        public ColumnChangedBodyInput(string listId, string columnId)
        {
            this.ListId = listId;
            this.ColumnId = columnId;
        }

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