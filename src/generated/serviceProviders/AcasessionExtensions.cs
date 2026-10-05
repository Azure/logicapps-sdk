//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Acasession
{
    using System;
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AcasessionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteCode))]
        public IBodyWorkflowAction<ExecuteCodeOutput> ExecuteCode([WorkflowExpression] Func<object> pythonCode, [WorkflowExpression] Func<object> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExecuteCodeOutput> __BuildExecuteCode(WorkflowValue<object> pythonCode, WorkflowValue<object> sessionId = null)
        {
            WorkflowValue.Validate(pythonCode, nameof(pythonCode), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ExecuteCodeOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["pythonCode"] = ExpressionConverter.ConvertO(pythonCode);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "executeCode", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<ExecuteCodeOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        [WorkflowExpressionFactory(nameof(__BuildFileUpload))]
        public IBodyWorkflowAction<FileUploadOutput> FileUpload([WorkflowExpression] Func<FileUploadInputFilesTypeItem[]> files, [WorkflowExpression] Func<object> sessionId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FileUploadOutput> __BuildFileUpload(WorkflowValue<FileUploadInputFilesTypeItem[]> files, WorkflowValue<object> sessionId = null)
        {
            WorkflowValue.Validate(files, nameof(files), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<FileUploadOutput>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["files"] = ExpressionConverter.ConvertO(files);
                if (sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileUpload", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<FileUploadOutput>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        [WorkflowExpressionFactory(nameof(__BuildFileDownload))]
        public IBodyWorkflowAction<JToken> FileDownload([WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<object> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFileDownload(WorkflowValue<string> fileName, WorkflowValue<object> sessionId)
        {
            WorkflowValue.Validate(fileName, nameof(fileName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileName"] = ExpressionConverter.ConvertO(fileName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileDownload", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        [WorkflowExpressionFactory(nameof(__BuildFileDelete))]
        public IBodyWorkflowAction<JToken> FileDelete([WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<object> sessionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFileDelete(WorkflowValue<string> fileName, WorkflowValue<object> sessionId)
        {
            WorkflowValue.Validate(fileName, nameof(fileName), required: true);
            WorkflowValue.Validate(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileName"] = ExpressionConverter.ConvertO(fileName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileDelete", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderAction<JToken>(serviceProviderInput);
            });
        }
    }

    public class ExecuteCodeOutput
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("stdout")]
        public string Stdout { get; set; }

        [JsonProperty("stderr")]
        public string Stderr { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }

    public class FileUploadOutput
    {
        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("lastModifiedTime")]
        public string LastModifiedTime { get; set; }

        [JsonProperty("sessionId")]
        public string SessionId { get; set; }
    }

    public class FileUploadInputFilesTypeItem
    {
        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty("fileContent", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken FileContent { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.Acasession;

    public partial class WorkflowServiceProviderActions
    {
        public AcasessionActions Acasession(string connectionId) => new AcasessionActions(connectionId);
    }
}
