//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Seektable
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SeektableActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> CubeImportCsv([WorkflowExpression] Func<string> cubeId, [WorkflowExpression] Func<string> filename = null)
        {
            SourceExpression.Validate(cubeId, nameof(cubeId), required: true);
            SourceExpression.Validate(filename, nameof(filename), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/cube/import/csv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cubeId"] = SourceExpressionConverter.ConvertO(cubeId);
                if (filename != null)
                    callPayload.Queries["filename"] = SourceExpressionConverter.ConvertO(filename);
                var cSVContent = new JObject();
                var cSVContentpropCount = 0;
                if (cSVContentpropCount > 0)
                {
                    callPayload.Body = cSVContent;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportExport([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> htmlInlineStyle = null, [WorkflowExpression] Func<bool> chartOnly = null)
        {
            SourceExpression.Validate(reportId, nameof(reportId), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(htmlInlineStyle, nameof(htmlInlineStyle), required: false);
            SourceExpression.Validate(chartOnly, nameof(chartOnly), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/report/{0}/export", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (htmlInlineStyle != null)
                    callPayload.Queries["html_inline_style"] = SourceExpressionConverter.ConvertO(htmlInlineStyle);
                if (chartOnly != null)
                    callPayload.Queries["chart_only"] = SourceExpressionConverter.ConvertO(chartOnly);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportShareByEmail([WorkflowExpression] Func<string> reportId, [WorkflowExpression] Func<string> to, [WorkflowExpression] Func<string> subject, [WorkflowExpression] Func<string> message = null)
        {
            SourceExpression.Validate(reportId, nameof(reportId), required: true);
            SourceExpression.Validate(to, nameof(to), required: true);
            SourceExpression.Validate(subject, nameof(subject), required: true);
            SourceExpression.Validate(message, nameof(message), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/report/{0}/share/email", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["to"] = SourceExpressionConverter.ConvertO(to);
                callPayload.Queries["subject"] = SourceExpressionConverter.ConvertO(subject);
                if (message != null)
                    callPayload.Queries["message"] = SourceExpressionConverter.ConvertO(message);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class SeektableTriggers([ConnectionName] string connectionId)
    {
    }

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