//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cloudconvert
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CloudconvertActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertFile(Expression<Func<ConvertFileInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/jobs/convertfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> OptimizeFile(Expression<Func<OptimizeFileInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/jobs/optimize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CaptureWebsite(Expression<Func<CaptureWebsiteInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/jobs/capture-website";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cloudconvert")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergeFiles(Expression<Func<MergeFilesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/flow/jobs/merge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class CloudconvertTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConvertFileInput
    {
        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertFileInputTasksType Tasks { get; set; } = new ConvertFileInputTasksType();
    }

    public class ConvertFileInputTasksType
    {
        [JsonProperty("import", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertFileInputTasksTypeImportType Import { get; set; } = new ConvertFileInputTasksTypeImportType();

        [JsonProperty("convert", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertFileInputTasksTypeConvertType Convert { get; set; } = new ConvertFileInputTasksTypeConvertType();

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertFileInputTasksTypeExportType Export { get; set; } = new ConvertFileInputTasksTypeExportType();
    }

    public class ConvertFileInputTasksTypeImportType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "import/base64";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }
    }

    public class ConvertFileInputTasksTypeConvertType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "convert";

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Input { get; set; } = "import";

        [JsonProperty("input_format")]
        public string InputFormat { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFormat { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class ConvertFileInputTasksTypeExportType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "export/url";

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Input { get; set; } = "convert";

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Inline { get; set; } = false;

        [JsonProperty("archive_multiple_files", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool ArchiveMultipleFiles { get; set; } = true;
    }

    public class OptimizeFileInput
    {
        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeFileInputTasksType Tasks { get; set; } = new OptimizeFileInputTasksType();
    }

    public class OptimizeFileInputTasksType
    {
        [JsonProperty("import", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeFileInputTasksTypeImportType Import { get; set; } = new OptimizeFileInputTasksTypeImportType();

        [JsonProperty("convert", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeFileInputTasksTypeConvertType Convert { get; set; } = new OptimizeFileInputTasksTypeConvertType();

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeFileInputTasksTypeExportType Export { get; set; } = new OptimizeFileInputTasksTypeExportType();
    }

    public class OptimizeFileInputTasksTypeImportType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "import/base64";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }
    }

    public class OptimizeFileInputTasksTypeConvertType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "optimize";

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Input { get; set; } = "import";

        [JsonProperty("input_format")]
        public string InputFormat { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class OptimizeFileInputTasksTypeExportType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "export/url";

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Input { get; set; } = "convert";

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Inline { get; set; } = false;

        [JsonProperty("archive_multiple_files", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool ArchiveMultipleFiles { get; set; } = true;
    }

    public class CaptureWebsiteInput
    {
        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteInputTasksType Tasks { get; set; } = new CaptureWebsiteInputTasksType();
    }

    public class CaptureWebsiteInputTasksType
    {
        [JsonProperty("convert", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteInputTasksTypeConvertType Convert { get; set; } = new CaptureWebsiteInputTasksTypeConvertType();

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteInputTasksTypeExportType Export { get; set; } = new CaptureWebsiteInputTasksTypeExportType();
    }

    public class CaptureWebsiteInputTasksTypeConvertType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "capture-website";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Url { get; set; }

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFormat { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class CaptureWebsiteInputTasksTypeExportType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "export/url";

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Input { get; set; } = "convert";

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Inline { get; set; } = false;

        [JsonProperty("archive_multiple_files", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool ArchiveMultipleFiles { get; set; } = true;
    }

    public class MergeFilesInput
    {
        [JsonProperty("number_of_inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfInputs { get; set; } = 2;

        [JsonProperty("additional_inputs")]
        public JToken AdditionalInputs { get; set; }

        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeFilesInputTasksType Tasks { get; set; } = new MergeFilesInputTasksType();
    }

    public class MergeFilesInputTasksType
    {
        [JsonProperty("import-1", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeFilesInputTasksTypeImport1Type Import1 { get; set; } = new MergeFilesInputTasksTypeImport1Type();

        [JsonProperty("import-2", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeFilesInputTasksTypeImport2Type Import2 { get; set; } = new MergeFilesInputTasksTypeImport2Type();

        [JsonProperty("merge", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeFilesInputTasksTypeMergeType Merge { get; set; } = new MergeFilesInputTasksTypeMergeType();

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeFilesInputTasksTypeExportType Export { get; set; } = new MergeFilesInputTasksTypeExportType();
    }

    public class MergeFilesInputTasksTypeImport1Type
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "import/base64";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }
    }

    public class MergeFilesInputTasksTypeImport2Type
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "import/base64";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }
    }

    public class MergeFilesInputTasksTypeMergeType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "merge";

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string[] Input { get; set; } = new string[]
        {
            "import-1",
            "import-2"
        };

        [JsonProperty("output_format", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFormat { get; set; } = "pdf";

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("options")]
        public JToken Options { get; set; }
    }

    public class MergeFilesInputTasksTypeExportType
    {
        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "export/url";

        [JsonProperty("input", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Input { get; set; } = "merge";

        [JsonProperty("inline", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool Inline { get; set; } = false;

        [JsonProperty("archive_multiple_files", DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool ArchiveMultipleFiles { get; set; } = true;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cloudconvert;

    public partial class WorkflowManagedActions
    {
        public CloudconvertActions Cloudconvert(string connectionId) => new CloudconvertActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CloudconvertTriggers Cloudconvert(string connectionId) => new CloudconvertTriggers(connectionId);
    }
}