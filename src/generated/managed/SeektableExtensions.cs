//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seektable
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeektableActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> CubeImportCsv(Expression<Func<string>> cubeId, Expression<Func<string>> filename = null)
        {
            var __workflow_cubeId = WorkflowExpression.Compile(cubeId, nameof(cubeId), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/cube/import/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cubeId"] = ExpressionConverter.Convert(__workflow_cubeId);
                if (__workflow_filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                var cSVContent = new JObject();
                var cSVContentpropCount = 0;
                if (cSVContentpropCount > 0)
                {
                    callPayload.Body = cSVContent;
                }

                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportExport(Expression<Func<string>> reportId, Expression<Func<formatInput>> format, Expression<Func<bool>> htmlInlineStyle = null, Expression<Func<bool>> chartOnly = null)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_format = WorkflowExpression.Compile(format, nameof(format), required: true);
            var __workflow_htmlInlineStyle = WorkflowExpression.Compile(htmlInlineStyle, nameof(htmlInlineStyle), required: false);
            var __workflow_chartOnly = WorkflowExpression.Compile(chartOnly, nameof(chartOnly), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/report/{0}/export", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_htmlInlineStyle != null)
                    callPayload.Queries["html_inline_style"] = ExpressionConverter.Convert(__workflow_htmlInlineStyle);
                if (__workflow_chartOnly != null)
                    callPayload.Queries["chart_only"] = ExpressionConverter.Convert(__workflow_chartOnly);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportShareByEmail(Expression<Func<string>> reportId, Expression<Func<string>> to, Expression<Func<string>> subject, Expression<Func<string>> message = null)
        {
            var __workflow_reportId = WorkflowExpression.Compile(reportId, nameof(reportId), required: true);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_subject = WorkflowExpression.Compile(subject, nameof(subject), required: true);
            var __workflow_message = WorkflowExpression.Compile(message, nameof(message), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/report/{0}/share/email", __workflow_reportId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                if (__workflow_message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                return new ApiConnectionAction<string>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class SeektableTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        [EnumMember(Value = "pdf")]
        Pdf,
        [EnumMember(Value = "csv")]
        Csv,
        [EnumMember(Value = "excel")]
        Excel,
        [EnumMember(Value = "excelpivottable")]
        Excelpivottable,
        [EnumMember(Value = "json")]
        Json,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "png")]
        Png
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Seektable;

    public partial class WorkflowManagedActions
    {
        public SeektableActions Seektable(string connectionId) => new SeektableActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SeektableTriggers Seektable(string connectionId) => new SeektableTriggers(connectionId);
    }
}
