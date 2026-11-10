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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ConvertFile(Expression<Func<ConvertFileBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> OptimizeFile(Expression<Func<OptimizeFileBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CaptureWebsite(Expression<Func<CaptureWebsiteBodyInput>> body)
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
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MergeFiles(Expression<Func<MergeFilesBodyInput>> body)
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

    public class ConvertFileBodyInput
    {
        public ConvertFileBodyInput(ConvertFileBodyInputTasksType tasks)
        {
            this.Tasks = tasks;
        }

        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertFileBodyInputTasksType Tasks { get; set; }
    }

    public class ConvertFileBodyInputTasksType
    {
        public ConvertFileBodyInputTasksType(BodyInputTasksTypeImportType import, ConvertFileBodyInputTasksTypeConvertType convert)
        {
            this.Import = import;
            this.Convert = convert;
        }

        [JsonProperty("import", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTasksTypeImportType Import { get; set; }

        [JsonProperty("convert", DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertFileBodyInputTasksTypeConvertType Convert { get; set; }

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteBodyInputTasksTypeExportType Export { get; set; } = new CaptureWebsiteBodyInputTasksTypeExportType();
    }

    public class BodyInputTasksTypeImportType
    {
        public BodyInputTasksTypeImportType(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file, string filename)
        {
            this.File = @file;
            this.Filename = filename;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "import/base64";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }
    }

    public class ConvertFileBodyInputTasksTypeConvertType
    {
        public ConvertFileBodyInputTasksTypeConvertType(string outputFormat)
        {
            this.OutputFormat = outputFormat;
        }

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

    public class CaptureWebsiteBodyInputTasksTypeExportType
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

    public class OptimizeFileBodyInput
    {
        public OptimizeFileBodyInput(OptimizeFileBodyInputTasksType tasks)
        {
            this.Tasks = tasks;
        }

        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeFileBodyInputTasksType Tasks { get; set; }
    }

    public class OptimizeFileBodyInputTasksType
    {
        public OptimizeFileBodyInputTasksType(BodyInputTasksTypeImportType import)
        {
            this.Import = import;
        }

        [JsonProperty("import", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTasksTypeImportType Import { get; set; }

        [JsonProperty("convert", DefaultValueHandling = DefaultValueHandling.Include)]
        public OptimizeFileBodyInputTasksTypeConvertType Convert { get; set; } = new OptimizeFileBodyInputTasksTypeConvertType();

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteBodyInputTasksTypeExportType Export { get; set; } = new CaptureWebsiteBodyInputTasksTypeExportType();
    }

    public class OptimizeFileBodyInputTasksTypeConvertType
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

    public class CaptureWebsiteBodyInput
    {
        public CaptureWebsiteBodyInput(CaptureWebsiteBodyInputTasksType tasks)
        {
            this.Tasks = tasks;
        }

        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteBodyInputTasksType Tasks { get; set; }
    }

    public class CaptureWebsiteBodyInputTasksType
    {
        public CaptureWebsiteBodyInputTasksType(CaptureWebsiteBodyInputTasksTypeConvertType convert)
        {
            this.Convert = convert;
        }

        [JsonProperty("convert", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteBodyInputTasksTypeConvertType Convert { get; set; }

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public CaptureWebsiteBodyInputTasksTypeExportType Export { get; set; } = new CaptureWebsiteBodyInputTasksTypeExportType();
    }

    public class CaptureWebsiteBodyInputTasksTypeConvertType
    {
        public CaptureWebsiteBodyInputTasksTypeConvertType(string url, string outputFormat)
        {
            this.Url = url;
            this.OutputFormat = outputFormat;
        }

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

    public class MergeFilesBodyInput
    {
        public MergeFilesBodyInput(MergeFilesBodyInputTasksType tasks)
        {
            this.Tasks = tasks;
        }

        [JsonProperty("number_of_inputs", DefaultValueHandling = DefaultValueHandling.Include)]
        public int NumberOfInputs { get; set; } = 2;

        [JsonProperty("additional_inputs")]
        public JToken AdditionalInputs { get; set; }

        [JsonProperty("tasks", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeFilesBodyInputTasksType Tasks { get; set; }
    }

    public class MergeFilesBodyInputTasksType
    {
        public MergeFilesBodyInputTasksType(BodyInputTasksTypeImport1Type import1, BodyInputTasksTypeImport2Type import2)
        {
            this.Import1 = import1;
            this.Import2 = import2;
        }

        [JsonProperty("import-1", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTasksTypeImport1Type Import1 { get; set; }

        [JsonProperty("import-2", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTasksTypeImport2Type Import2 { get; set; }

        [JsonProperty("merge", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTasksTypeMergeType Merge { get; set; } = new BodyInputTasksTypeMergeType();

        [JsonProperty("export", DefaultValueHandling = DefaultValueHandling.Include)]
        public MergeFilesBodyInputTasksTypeExportType Export { get; set; } = new MergeFilesBodyInputTasksTypeExportType();
    }

    public class BodyInputTasksTypeImport1Type
    {
        public BodyInputTasksTypeImport1Type(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file, string filename)
        {
            this.File = @file;
            this.Filename = filename;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "import/base64";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }
    }

    public class BodyInputTasksTypeImport2Type
    {
        public BodyInputTasksTypeImport2Type(global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent @file, string filename)
        {
            this.File = @file;
            this.Filename = filename;
        }

        [JsonProperty("operation", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Operation { get; set; } = "import/base64";

        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Include)]
        public global::Microsoft.Azure.Workflows.Sdk.WorkflowBinaryContent File { get; set; }

        [JsonProperty("filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filename { get; set; }
    }

    public class BodyInputTasksTypeMergeType
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

    public class MergeFilesBodyInputTasksTypeExportType
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