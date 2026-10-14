//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seektable
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SeektableActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> CubeImportCsv(Expression<Func<string>> cubeId, Expression<Func<string>> filename = null)
        {
            var __workflow_cubeId = cubeId == null ? null : WorkflowExpression.Compile(cubeId);
            WorkflowExpression.Validate(__workflow_cubeId, nameof(cubeId), required: true);
            var __workflow_filename = filename == null ? null : WorkflowExpression.Compile(filename);
            WorkflowExpression.Validate(__workflow_filename, nameof(filename), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportExport(Expression<Func<string>> reportId, Expression<Func<formatInput>> format, Expression<Func<bool>> htmlInlineStyle = null, Expression<Func<bool>> chartOnly = null)
        {
            var __workflow_reportId = reportId == null ? null : WorkflowExpression.Compile(reportId);
            WorkflowExpression.Validate(__workflow_reportId, nameof(reportId), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: true);
            var __workflow_htmlInlineStyle = htmlInlineStyle == null ? null : WorkflowExpression.Compile(htmlInlineStyle);
            WorkflowExpression.Validate(__workflow_htmlInlineStyle, nameof(htmlInlineStyle), required: false);
            var __workflow_chartOnly = chartOnly == null ? null : WorkflowExpression.Compile(chartOnly);
            WorkflowExpression.Validate(__workflow_chartOnly, nameof(chartOnly), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/report/{0}/export", ExpressionConverter.ConvertWithUrlEncoding(__workflow_reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_htmlInlineStyle != null)
                    callPayload.Queries["html_inline_style"] = ExpressionConverter.Convert(__workflow_htmlInlineStyle);
                if (__workflow_chartOnly != null)
                    callPayload.Queries["chart_only"] = ExpressionConverter.Convert(__workflow_chartOnly);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportShareByEmail(Expression<Func<string>> reportId, Expression<Func<string>> to, Expression<Func<string>> subject, Expression<Func<string>> message = null)
        {
            var __workflow_reportId = reportId == null ? null : WorkflowExpression.Compile(reportId);
            WorkflowExpression.Validate(__workflow_reportId, nameof(reportId), required: true);
            var __workflow_to = to == null ? null : WorkflowExpression.Compile(to);
            WorkflowExpression.Validate(__workflow_to, nameof(to), required: true);
            var __workflow_subject = subject == null ? null : WorkflowExpression.Compile(subject);
            WorkflowExpression.Validate(__workflow_subject, nameof(subject), required: true);
            var __workflow_message = message == null ? null : WorkflowExpression.Compile(message);
            WorkflowExpression.Validate(__workflow_message, nameof(message), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/report/{0}/share/email", ExpressionConverter.ConvertWithUrlEncoding(__workflow_reportId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = ExpressionConverter.Convert(__workflow_to);
                callPayload.Queries["subject"] = ExpressionConverter.Convert(__workflow_subject);
                if (__workflow_message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(__workflow_message);
                return new ApiConnectionAction<string>(callPayload);
            });
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
