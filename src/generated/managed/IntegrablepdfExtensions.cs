//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Integrablepdf
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IntegrablepdfActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> LockPdf(Expression<Func<LockPdfInputInput>> lockPdfInput)
        {
            var __workflow_lockPdfInput = WorkflowExpression.Compile(lockPdfInput, nameof(lockPdfInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/lock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lockPdfInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergePdf(Expression<Func<MergePdfInputInput>> mergePdfInput)
        {
            var __workflow_mergePdfInput = WorkflowExpression.Compile(mergePdfInput, nameof(mergePdfInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_mergePdfInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> PasswordProtectPdf(Expression<Func<PasswordProtectPdfInputInput>> passwordProtectPdfInput)
        {
            var __workflow_passwordProtectPdfInput = WorkflowExpression.Compile(passwordProtectPdfInput, nameof(passwordProtectPdfInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/password_protect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_passwordProtectPdfInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SplitPdf(Expression<Func<SplitPdfInputInput>> splitPdfInput)
        {
            var __workflow_splitPdfInput = WorkflowExpression.Compile(splitPdfInput, nameof(splitPdfInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_splitPdfInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> UnlockPdf(Expression<Func<UnlockPdfInputInput>> unlockPdfInput)
        {
            var __workflow_unlockPdfInput = WorkflowExpression.Compile(unlockPdfInput, nameof(unlockPdfInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/unlock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_unlockPdfInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> WatermarkPdfBackground(Expression<Func<WatermarkPdfBackgroundInputInput>> watermarkPdfBackgroundInput)
        {
            var __workflow_watermarkPdfBackgroundInput = WorkflowExpression.Compile(watermarkPdfBackgroundInput, nameof(watermarkPdfBackgroundInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/watermark/background";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_watermarkPdfBackgroundInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> WatermarkPdfCustom(Expression<Func<WatermarkPdfCustomInputInput>> watermarkPdfCustomInput)
        {
            var __workflow_watermarkPdfCustomInput = WorkflowExpression.Compile(watermarkPdfCustomInput, nameof(watermarkPdfCustomInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/watermark/custom";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_watermarkPdfCustomInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "integrablepdf")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> WatermarkPdfOverlay(Expression<Func<WatermarkPdfOverlayInputInput>> watermarkPdfOverlayInput)
        {
            var __workflow_watermarkPdfOverlayInput = WorkflowExpression.Compile(watermarkPdfOverlayInput, nameof(watermarkPdfOverlayInput), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/pdf/watermark/overlay";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/octet-stream");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_watermarkPdfOverlayInput);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class IntegrablepdfTriggers([ConnectionName] string connectionId)
    {
    }

    public class LockPdfInputInput
    {
        public LockPdfInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, string permissionsPassword)
        {
            this.FileContent = fileContent;
            this.PermissionsPassword = permissionsPassword;
        }

        [JsonProperty("allowAccessibility")]
        public bool? AllowAccessibility { get; set; }

        [JsonProperty("allowCopy")]
        public bool? AllowCopy { get; set; }

        [JsonProperty("allowDocumentAssembly")]
        public bool? AllowDocumentAssembly { get; set; }

        [JsonProperty("allowEdit")]
        public bool? AllowEdit { get; set; }

        [JsonProperty("allowFormFilling")]
        public bool? AllowFormFilling { get; set; }

        [JsonProperty("allowPrint")]
        public bool? AllowPrint { get; set; }

        [JsonProperty("allowUpdateAnnotationsAndFields")]
        public bool? AllowUpdateAnnotationsAndFields { get; set; }

        [JsonProperty("documentOpenPassword")]
        public string DocumentOpenPassword { get; set; }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("permissionsPassword", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PermissionsPassword { get; set; }
    }

    public class MergePdfInputInput
    {
        public MergePdfInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent _1stFileContent, global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent _2ndFileContent)
        {
            this._1stFileContent = _1stFileContent;
            this._2ndFileContent = _2ndFileContent;
        }

        [JsonProperty("fileContent1", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent _1stFileContent { get; set; }

        [JsonProperty("fileContent2", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent _2ndFileContent { get; set; }

        [JsonProperty("fileContent3")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent _3rdFileContent { get; set; }

        [JsonProperty("fileContent4")]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent _4thFileContent { get; set; }
    }

    public class PasswordProtectPdfInputInput
    {
        public PasswordProtectPdfInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, string password)
        {
            this.FileContent = fileContent;
            this.Password = password;
        }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class SplitPdfInputInput
    {
        public SplitPdfInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent)
        {
            this.FileContent = fileContent;
        }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("firstPage")]
        public int? FirstPage { get; set; }

        [JsonProperty("lastPage")]
        public int? LastPage { get; set; }
    }

    public class UnlockPdfInputInput
    {
        public UnlockPdfInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, string password)
        {
            this.FileContent = fileContent;
            this.Password = password;
        }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }
    }

    public class WatermarkPdfBackgroundInputInput
    {
        public WatermarkPdfBackgroundInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, string _1stLine)
        {
            this.FileContent = fileContent;
            this._1stLine = _1stLine;
        }

        [JsonProperty("color")]
        public WatermarkPdfBackgroundInputInputColorType? Color { get; set; }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("line1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string _1stLine { get; set; }

        [JsonProperty("line2")]
        public string _2ndLine { get; set; }

        [JsonProperty("line3")]
        public string _3rdLine { get; set; }

        [JsonProperty("margin")]
        public double? Margin { get; set; }

        [JsonProperty("orientation")]
        public WatermarkPdfBackgroundInputInputOrientationType? Orientation { get; set; }

        [JsonProperty("style")]
        public WatermarkPdfBackgroundInputInputStyleType? Style { get; set; }

        [JsonProperty("transparency")]
        public double? Transparency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WatermarkPdfBackgroundInputInputColorType
    {
        Gray,
        Red,
        Blue
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WatermarkPdfBackgroundInputInputOrientationType
    {
        Upward,
        Downward
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WatermarkPdfBackgroundInputInputStyleType
    {
        Solid,
        Outline
    }

    public class WatermarkPdfCustomInputInput
    {
        public WatermarkPdfCustomInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, string templateId)
        {
            this.FileContent = fileContent;
            this.TemplateId = templateId;
        }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("line1")]
        public string _1stLine { get; set; }

        [JsonProperty("line2")]
        public string _2ndLine { get; set; }

        [JsonProperty("line3")]
        public string _3rdLine { get; set; }

        [JsonProperty("line4")]
        public string _4thLine { get; set; }

        [JsonProperty("line5")]
        public string _5thLine { get; set; }

        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }
    }

    public class WatermarkPdfOverlayInputInput
    {
        public WatermarkPdfOverlayInputInput(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent fileContent, string _1stLine)
        {
            this.FileContent = fileContent;
            this._1stLine = _1stLine;
        }

        [JsonProperty("color")]
        public WatermarkPdfOverlayInputInputColorType? Color { get; set; }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent FileContent { get; set; }

        [JsonProperty("line1", DefaultValueHandling = DefaultValueHandling.Include)]
        public string _1stLine { get; set; }

        [JsonProperty("line2")]
        public string _2ndLine { get; set; }

        [JsonProperty("line3")]
        public string _3rdLine { get; set; }

        [JsonProperty("margin")]
        public double? Margin { get; set; }

        [JsonProperty("orientation")]
        public WatermarkPdfOverlayInputInputOrientationType? Orientation { get; set; }

        [JsonProperty("style")]
        public WatermarkPdfOverlayInputInputStyleType? Style { get; set; }

        [JsonProperty("transparency")]
        public double? Transparency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WatermarkPdfOverlayInputInputColorType
    {
        Gray,
        Red,
        Blue
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WatermarkPdfOverlayInputInputOrientationType
    {
        Upward,
        Downward
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WatermarkPdfOverlayInputInputStyleType
    {
        Solid,
        Outline
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Integrablepdf;

    public partial class WorkflowManagedActions
    {
        public IntegrablepdfActions Integrablepdf(string connectionId) => new IntegrablepdfActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IntegrablepdfTriggers Integrablepdf(string connectionId) => new IntegrablepdfTriggers(connectionId);
    }
}