//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seektable
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeektableActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        [WorkflowExpressionFactory(nameof(__BuildCubeImportCsv))]
        public IBodyWorkflowAction<string> CubeImportCsv([WorkflowExpression] Func<string> cubeId, [WorkflowExpression] Func<string> filename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCubeImportCsv(WorkflowExpression<string> cubeId, WorkflowExpression<string> filename = null)
        {
            WorkflowExpression.Validate(cubeId, nameof(cubeId), required: true);
            WorkflowExpression.Validate(filename, nameof(filename), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/cube/import/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cubeId"] = ExpressionConverter.Convert(cubeId);
                if (filename != null)
                    callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
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
        [WorkflowExpressionFactory(nameof(__BuildReportExport))]
        public IBodyWorkflowAction<string> ReportExport([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> htmlInlineStyle = null, [WorkflowExpression] Func<bool> chartOnly = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildReportExport(WorkflowExpression<string> reportId, WorkflowExpression<formatInput> format, WorkflowExpression<bool> htmlInlineStyle = null, WorkflowExpression<bool> chartOnly = null)
        {
            WorkflowExpression.Validate(reportId, nameof(reportId), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(htmlInlineStyle, nameof(htmlInlineStyle), required: false);
            WorkflowExpression.Validate(chartOnly, nameof(chartOnly), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/report/{0}/export", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (htmlInlineStyle != null)
                    callPayload.Queries["html_inline_style"] = ExpressionConverter.Convert(htmlInlineStyle);
                if (chartOnly != null)
                    callPayload.Queries["chart_only"] = ExpressionConverter.Convert(chartOnly);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        [WorkflowExpressionFactory(nameof(__BuildReportShareByEmail))]
        public IBodyWorkflowAction<string> ReportShareByEmail([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> subject, [WorkflowExpression] Func<string> message = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildReportShareByEmail(WorkflowExpression<string> reportId, WorkflowExpression<string> to, WorkflowExpression<string> subject, WorkflowExpression<string> message = null)
        {
            WorkflowExpression.Validate(reportId, nameof(reportId), required: true);
            WorkflowExpression.Validate(to, nameof(to), required: true);
            WorkflowExpression.Validate(subject, nameof(subject), required: true);
            WorkflowExpression.Validate(message, nameof(message), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/report/{0}/share/email", ExpressionConverter.ConvertWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = ExpressionConverter.Convert(to);
                callPayload.Queries["subject"] = ExpressionConverter.Convert(subject);
                if (message != null)
                    callPayload.Queries["message"] = ExpressionConverter.Convert(message);
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