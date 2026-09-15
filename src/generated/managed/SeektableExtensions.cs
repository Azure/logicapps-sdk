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
        public IBodyWorkflowAction<string> CubeImportCsv(Expression<Func<string>> cubeId, Expression<Func<string>> filename = null)
        {
            var apiCallPath = "/api/cube/import/csv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cubeId"] = CSharpExpressionConverter.ConvertO(cubeId);
            if (filename != null)
                callPayload.Queries["filename"] = CSharpExpressionConverter.ConvertO(filename);
            var cSVContent = new JObject();
            var cSVContentpropCount = 0;
            if (cSVContentpropCount > 0)
            {
                callPayload.Body = cSVContent;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportExport(Expression<Func<string>> reportId, Expression<Func<formatInput>> format, Expression<Func<bool>> htmlInlineStyle = null, Expression<Func<bool>> chartOnly = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/report/{0}/export", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = CSharpExpressionConverter.Convert(format);
            if (htmlInlineStyle != null)
                callPayload.Queries["html_inline_style"] = CSharpExpressionConverter.ConvertO(htmlInlineStyle);
            if (chartOnly != null)
                callPayload.Queries["chart_only"] = CSharpExpressionConverter.ConvertO(chartOnly);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "seektable")]
        public IBodyWorkflowAction<string> ReportShareByEmail(Expression<Func<string>> reportId, Expression<Func<string>> to, Expression<Func<string>> subject, Expression<Func<string>> message = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/report/{0}/share/email", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(reportId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["to"] = CSharpExpressionConverter.ConvertO(to);
            callPayload.Queries["subject"] = CSharpExpressionConverter.ConvertO(subject);
            if (message != null)
                callPayload.Queries["message"] = CSharpExpressionConverter.ConvertO(message);
            return new ApiConnectionAction<string>(callPayload);
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