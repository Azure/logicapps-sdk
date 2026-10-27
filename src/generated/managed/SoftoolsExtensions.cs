//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Softools
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SoftoolsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<RecordResponse, ApiConnectionActionConfiguration> GetRecord(Expression<Func<string>> appIdentifier, Expression<Func<string>> recordId, Expression<Func<string>> tenant)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            return new DeferredBodyAction<RecordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data/{1}", __workflow_appIdentifier.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                return new ApiConnectionAction<RecordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<MessageInfo, ApiConnectionActionConfiguration> ArchiveRecord(Expression<Func<string>> appIdentifier, Expression<Func<string>> recordId, Expression<Func<string>> tenant)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            return new DeferredBodyAction<MessageInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data/{1}", __workflow_appIdentifier.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                return new ApiConnectionAction<MessageInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<MessageInfo, ApiConnectionActionConfiguration> PatchARecord(Expression<Func<string>> appIdentifier, Expression<Func<string>> recordId, Expression<Func<string>> tenant, Expression<Func<object>> updateRecord = null)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            var __workflow_updateRecord = WorkflowExpression.Compile(updateRecord, nameof(updateRecord), required: false);
            return new DeferredBodyAction<MessageInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data/{1}", __workflow_appIdentifier.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                if (__workflow_updateRecord != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateRecord);
                return new ApiConnectionAction<MessageInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetReportRecords(Expression<Func<string>> appIdentifier, Expression<Func<double>> reportId, Expression<Func<double>> skip, Expression<Func<double>> top, Expression<Func<string>> tenant, Expression<Func<string>> orderby = null, Expression<Func<string>> filter = null)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data/Report/{1}", __workflow_appIdentifier.WithUrlEncoding(1), __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<MessageInfo, ApiConnectionActionConfiguration> PostARecord(Expression<Func<string>> appIdentifier, Expression<Func<string>> tenant, Expression<Func<object>> records = null)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            var __workflow_records = WorkflowExpression.Compile(records, nameof(records), required: false);
            return new DeferredBodyAction<MessageInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data", __workflow_appIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                if (__workflow_records != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_records);
                return new ApiConnectionAction<MessageInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<BasicFieldsResponseItem[], ApiConnectionActionConfiguration> GetBasicFieldInfo(Expression<Func<string>> appIdentifier, Expression<Func<string>> tenant)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            return new DeferredBodyAction<BasicFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Fields", __workflow_appIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                return new ApiConnectionAction<BasicFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetAllRecords(Expression<Func<string>> appIdentifier, Expression<Func<double>> skip, Expression<Func<double>> top, Expression<Func<string>> tenant, Expression<Func<string>> orderby = null, Expression<Func<string>> filter = null)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: true);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data/", __workflow_appIdentifier.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<MessageInfo, ApiConnectionActionConfiguration> DeleteRecord(Expression<Func<string>> appIdentifier, Expression<Func<string>> recordId, Expression<Func<string>> tenant)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            return new DeferredBodyAction<MessageInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data/{1}/Archived", __workflow_appIdentifier.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                return new ApiConnectionAction<MessageInfo>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "softools")]
        public IBodyWorkflowAction<MessageInfo, ApiConnectionActionConfiguration> UnarchivedRecord(Expression<Func<string>> appIdentifier, Expression<Func<string>> recordId, Expression<Func<string>> tenant)
        {
            var __workflow_appIdentifier = WorkflowExpression.Compile(appIdentifier, nameof(appIdentifier), required: true);
            var __workflow_recordId = WorkflowExpression.Compile(recordId, nameof(recordId), required: true);
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            return new DeferredBodyAction<MessageInfo, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Api/Apps/{0}/Data/{1}/Unarchive", __workflow_appIdentifier.WithUrlEncoding(1), __workflow_recordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                return new ApiConnectionAction<MessageInfo>(callPayload);
            });
        }
    }

    public class SoftoolsTriggers([ConnectionName] string connectionId)
    {
    }

    public class RecordResponse
    {
        public string Id { get; set; }
        public string AppIdentifier { get; set; }
        public string CreatedByUserId { get; set; }
        public string CreatedByUser { get; set; }
        public RecordResponseCreatedDateType CreatedDate { get; set; }
        public string UpdatedByUserId { get; set; }
        public string UpdatedByUser { get; set; }
        public RecordResponseUpdatedDateType UpdatedDate { get; set; }
        public string Identifier { get; set; }
        public string QuickFilterSearchText { get; set; }
        public bool EditableAccessForUser { get; set; }
    }

    public class RecordResponseCreatedDateType
    {
        [JsonProperty("$date")]
        public int Date { get; set; }
    }

    public class RecordResponseUpdatedDateType
    {
        [JsonProperty("$date")]
        public int Date { get; set; }
    }

    public class MessageInfo
    {
        public string Message { get; set; }
    }

    public class BasicFieldsResponseItem
    {
        public string Identifier { get; set; }
        public int Type { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Softools;

    public partial class WorkflowManagedActions
    {
        public SoftoolsActions Softools(string connectionId) => new SoftoolsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SoftoolsTriggers Softools(string connectionId) => new SoftoolsTriggers(connectionId);
    }
}