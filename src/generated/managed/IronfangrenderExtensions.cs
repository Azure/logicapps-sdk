//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IronfangrenderActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ironfangrender")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CaptureScreenshot(Expression<Func<CaptureScreenshotBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/screenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ironfangrender")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreatePdf(Expression<Func<CreatePdfBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ironfangrender")]
        public IBodyWorkflowAction<Job, ApiConnectionActionConfiguration> StartScreenshotJob(Expression<Func<StartScreenshotJobBodyInput>> body, Expression<Func<string>> idempotencyKey = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idempotencyKey = WorkflowExpression.Compile(idempotencyKey, nameof(idempotencyKey), required: false);
            return new DeferredBodyAction<Job, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/jobs/screenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idempotencyKey != null)
                    callPayload.Headers["Idempotency-Key"] = ExpressionConverter.Convert(__workflow_idempotencyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Job>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ironfangrender")]
        public IBodyWorkflowAction<Job, ApiConnectionActionConfiguration> StartPdfJob(Expression<Func<StartPdfJobBodyInput>> body, Expression<Func<string>> idempotencyKey = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            var __workflow_idempotencyKey = WorkflowExpression.Compile(idempotencyKey, nameof(idempotencyKey), required: false);
            return new DeferredBodyAction<Job, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v1/jobs/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_idempotencyKey != null)
                    callPayload.Headers["Idempotency-Key"] = ExpressionConverter.Convert(__workflow_idempotencyKey);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Job>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ironfangrender")]
        public IBodyWorkflowAction<Job, ApiConnectionActionConfiguration> GetJob(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Job, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/jobs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Job>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ironfangrender")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadJobResult(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/jobs/{0}/result", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["redirect"] = Convert.ToString("false");
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class IronfangrenderTriggers([ConnectionName] string connectionId)
    {
    }

    public class CaptureScreenshotBodyInput
    {
        [JsonProperty("url")]
        public string PageUrl { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputImageFormatType? ImageFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.BodyInputImageFormatType.Png;

        [JsonProperty("full_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FullPage { get; set; } = false;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Width { get; set; } = 1280;

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Height { get; set; } = 800;

        [JsonProperty("device")]
        public BodyInputDeviceType? Device { get; set; }

        [JsonProperty("dark_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DarkMode { get; set; } = false;

        [JsonProperty("quality", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Quality { get; set; } = 85;

        [JsonProperty("selector")]
        public string ElementSelector { get; set; }

        [JsonProperty("delay_ms")]
        public int? DelayMilliseconds { get; set; }

        [JsonProperty("wait_until", DefaultValueHandling = DefaultValueHandling.Include)]
        public WaitUntil? WaitUntil { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.WaitUntil.Load;

        [JsonProperty("block_cookie_banners", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideCookieBanners { get; set; } = false;

        [JsonProperty("block_ads", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BlockAds { get; set; } = false;

        [JsonProperty("no_cache", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SkipTheCache { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputImageFormatType
    {
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "webp")]
        Webp
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputDeviceType
    {
        [EnumMember(Value = "desktop")]
        Desktop,
        [EnumMember(Value = "tablet")]
        Tablet,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WaitUntil
    {
        [EnumMember(Value = "load")]
        Load,
        [EnumMember(Value = "domcontentloaded")]
        Domcontentloaded,
        [EnumMember(Value = "networkidle")]
        Networkidle
    }

    public class CreatePdfBodyInput
    {
        [JsonProperty("url")]
        public string PageUrl { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("paper_format")]
        public BodyInputPaperSizeType? PaperSize { get; set; }

        [JsonProperty("landscape", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Landscape { get; set; } = false;

        [JsonProperty("print_background", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintBackgrounds { get; set; } = false;

        [JsonProperty("margin")]
        public BodyInputMarginsType Margins { get; set; }

        [JsonProperty("header_html")]
        public string HeaderHtml { get; set; }

        [JsonProperty("footer_html")]
        public string FooterHtml { get; set; }

        [JsonProperty("scale")]
        public double? Scale { get; set; }

        [JsonProperty("wait_until", DefaultValueHandling = DefaultValueHandling.Include)]
        public WaitUntil? WaitUntil { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.WaitUntil.Load;

        [JsonProperty("block_cookie_banners", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideCookieBanners { get; set; } = false;

        [JsonProperty("block_ads", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BlockAds { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPaperSizeType
    {
        [EnumMember(Value = "a4")]
        A4,
        [EnumMember(Value = "letter")]
        Letter,
        [EnumMember(Value = "a3")]
        A3,
        [EnumMember(Value = "a5")]
        A5,
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "tabloid")]
        Tabloid
    }

    public class BodyInputMarginsType
    {
        [JsonProperty("top")]
        public double? TopMarginInches { get; set; }

        [JsonProperty("right")]
        public double? RightMarginInches { get; set; }

        [JsonProperty("bottom")]
        public double? BottomMarginInches { get; set; }

        [JsonProperty("left")]
        public double? LeftMarginInches { get; set; }
    }

    public class Job
    {
        [JsonProperty("id")]
        public string JobId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("status")]
        public JobStatusType Status { get; set; }

        [JsonProperty("external_id")]
        public string YourReference { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("completed_at")]
        public string CompletedAt { get; set; }

        [JsonProperty("error")]
        public JobErrorType Error { get; set; }

        [JsonProperty("result")]
        public JobResultType Result { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JobStatusType
    {
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "cancellation_requested")]
        CancellationRequested,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "cancelled")]
        Cancelled
    }

    public class JobErrorType
    {
        [JsonProperty("code")]
        public string ErrorCode { get; set; }

        [JsonProperty("message")]
        public string ErrorMessage { get; set; }
    }

    public class JobResultType
    {
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("bytes")]
        public int SizeBytes { get; set; }

        [JsonProperty("sha256")]
        public string Sha256Hash { get; set; }

        [JsonProperty("available")]
        public bool Available { get; set; }

        [JsonProperty("expires_at")]
        public string ResultExpiresAt { get; set; }

        [JsonProperty("url")]
        public string DownloadLink { get; set; }

        [JsonProperty("url_expires_at")]
        public string DownloadLinkExpiresAt { get; set; }
    }

    public class StartScreenshotJobBodyInput
    {
        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal StartScreenshotJobBodyInputKindType Kind { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.StartScreenshotJobBodyInputKindType.Screenshot;

        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Include)]
        public ScreenshotRequest Request { get; set; } = new ScreenshotRequest();

        [JsonProperty("external_id")]
        public string YourReference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartScreenshotJobBodyInputKindType
    {
        [EnumMember(Value = "screenshot")]
        Screenshot
    }

    public class ScreenshotRequest
    {
        [JsonProperty("url")]
        public string PageUrl { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public ScreenshotRequestImageFormatType? ImageFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.ScreenshotRequestImageFormatType.Png;

        [JsonProperty("full_page", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FullPage { get; set; } = false;

        [JsonProperty("width", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Width { get; set; } = 1280;

        [JsonProperty("height", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Height { get; set; } = 800;

        [JsonProperty("device")]
        public ScreenshotRequestDeviceType? Device { get; set; }

        [JsonProperty("dark_mode", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DarkMode { get; set; } = false;

        [JsonProperty("quality", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Quality { get; set; } = 85;

        [JsonProperty("selector")]
        public string ElementSelector { get; set; }

        [JsonProperty("delay_ms")]
        public int? DelayMilliseconds { get; set; }

        [JsonProperty("wait_until", DefaultValueHandling = DefaultValueHandling.Include)]
        public WaitUntil? WaitUntil { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.WaitUntil.Load;

        [JsonProperty("block_cookie_banners", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideCookieBanners { get; set; } = false;

        [JsonProperty("block_ads", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BlockAds { get; set; } = false;

        [JsonProperty("no_cache", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SkipTheCache { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScreenshotRequestImageFormatType
    {
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "jpeg")]
        Jpeg,
        [EnumMember(Value = "webp")]
        Webp
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScreenshotRequestDeviceType
    {
        [EnumMember(Value = "desktop")]
        Desktop,
        [EnumMember(Value = "tablet")]
        Tablet,
        [EnumMember(Value = "mobile")]
        Mobile
    }

    public class StartPdfJobBodyInput
    {
        [JsonProperty("kind", DefaultValueHandling = DefaultValueHandling.Include)]
        internal StartPdfJobBodyInputKindType Kind { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.StartPdfJobBodyInputKindType.Pdf;

        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Include)]
        public PdfRequest Request { get; set; } = new PdfRequest();

        [JsonProperty("external_id")]
        public string YourReference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StartPdfJobBodyInputKindType
    {
        [EnumMember(Value = "pdf")]
        Pdf
    }

    public class PdfRequest
    {
        [JsonProperty("url")]
        public string PageUrl { get; set; }

        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("paper_format")]
        public PdfRequestPaperSizeType? PaperSize { get; set; }

        [JsonProperty("landscape", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Landscape { get; set; } = false;

        [JsonProperty("print_background", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintBackgrounds { get; set; } = false;

        [JsonProperty("margin")]
        public PdfRequestMarginsType Margins { get; set; }

        [JsonProperty("header_html")]
        public string HeaderHtml { get; set; }

        [JsonProperty("footer_html")]
        public string FooterHtml { get; set; }

        [JsonProperty("scale")]
        public double? Scale { get; set; }

        [JsonProperty("wait_until", DefaultValueHandling = DefaultValueHandling.Include)]
        public WaitUntil? WaitUntil { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender.WaitUntil.Load;

        [JsonProperty("block_cookie_banners", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideCookieBanners { get; set; } = false;

        [JsonProperty("block_ads", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BlockAds { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PdfRequestPaperSizeType
    {
        [EnumMember(Value = "a4")]
        A4,
        [EnumMember(Value = "letter")]
        Letter,
        [EnumMember(Value = "a3")]
        A3,
        [EnumMember(Value = "a5")]
        A5,
        [EnumMember(Value = "legal")]
        Legal,
        [EnumMember(Value = "tabloid")]
        Tabloid
    }

    public class PdfRequestMarginsType
    {
        [JsonProperty("top")]
        public double? TopMarginInches { get; set; }

        [JsonProperty("right")]
        public double? RightMarginInches { get; set; }

        [JsonProperty("bottom")]
        public double? BottomMarginInches { get; set; }

        [JsonProperty("left")]
        public double? LeftMarginInches { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ironfangrender;

    public partial class WorkflowManagedActions
    {
        public IronfangrenderActions Ironfangrender(string connectionId) => new IronfangrenderActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IronfangrenderTriggers Ironfangrender(string connectionId) => new IronfangrenderTriggers(connectionId);
    }
}