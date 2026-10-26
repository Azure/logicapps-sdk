//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zippydoc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZippydocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Execute(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/document/power-automate/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<int, ApiConnectionActionConfiguration> UploadTable(Expression<Func<UploadTableInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<int, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/excel/table/power-automate/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<int>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetTableById(Expression<Func<int>> tableId)
        {
            var __workflow_tableId = WorkflowExpression.Compile(tableId, nameof(tableId), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/excel/table/power-automate/id/{0}", __workflow_tableId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zippydoc")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetTableByName(Expression<Func<string>> name)
        {
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/excel/table/power-automate/name/{0}", __workflow_name.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }
    }

    public class ZippydocTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> OnTableChange(Expression<Func<OnTableChangeInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/power-automate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class UploadTableInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public JToken[] Content { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("replace")]
        public bool? Replace { get; set; }

        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }
    }

    public class OnTableChangeInput
    {
        [JsonProperty("x-ms-notification-url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string XMsNotificationUrl { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("type")]
        public OnTableChangeInputTypeType? Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnTableChangeInputTypeType
    {
        [EnumMember(Value = "ON_TABLE_CHANGE")]
        ONTABLECHANGE
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zippydoc;

    public partial class WorkflowManagedActions
    {
        public ZippydocActions Zippydoc(string connectionId) => new ZippydocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZippydocTriggers Zippydoc(string connectionId) => new ZippydocTriggers(connectionId);
    }
}