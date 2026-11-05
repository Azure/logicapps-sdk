//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sms77io
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Sms77ioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sms77io")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Balance()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/balance";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sms77io")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Lookup(Expression<Func<TypeInput>> type, Expression<Func<string>> number, Expression<Func<string>> json = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_json = WorkflowExpression.Compile(json, nameof(json), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lookup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                callPayload.Queries["number"] = ExpressionConverter.Convert(__workflow_number);
                if (__workflow_json != null)
                    callPayload.Queries["json"] = ExpressionConverter.Convert(__workflow_json);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sms77io")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Pricing(Expression<Func<string>> country = null, Expression<Func<FormatInput>> format = null)
        {
            var __workflow_country = WorkflowExpression.Compile(country, nameof(country), required: false);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pricing";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_country != null)
                    callPayload.Queries["country"] = ExpressionConverter.Convert(__workflow_country);
                callPayload.Queries["format"] = Convert.ToString("csv");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sms77io")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Status(Expression<Func<string>> msgId)
        {
            var __workflow_msgId = WorkflowExpression.Compile(msgId, nameof(msgId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/status";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["msg_id"] = ExpressionConverter.Convert(__workflow_msgId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sms77io")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ValidateForVoice(Expression<Func<string>> number, Expression<Func<string>> callback = null)
        {
            var __workflow_number = WorkflowExpression.Compile(number, nameof(number), required: true);
            var __workflow_callback = WorkflowExpression.Compile(callback, nameof(callback), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/validate_for_voice";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["number"] = ExpressionConverter.Convert(__workflow_number);
                if (__workflow_callback != null)
                    callPayload.Queries["callback"] = ExpressionConverter.Convert(__workflow_callback);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class Sms77ioTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TypeInput
    {
        [EnumMember(Value = "cnam")]
        Cnam,
        [EnumMember(Value = "format")]
        Format,
        [EnumMember(Value = "hlr")]
        Hlr,
        [EnumMember(Value = "mnp")]
        Mnp
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FormatInput
    {
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "csv")]
        Csv
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sms77io;

    public partial class WorkflowManagedActions
    {
        public Sms77ioActions Sms77io(string connectionId) => new Sms77ioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Sms77ioTriggers Sms77io(string connectionId) => new Sms77ioTriggers(connectionId);
    }
}