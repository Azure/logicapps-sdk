//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Acasession
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class AcasessionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<ExecuteCodeOutput, ExecuteCodeActionConfiguration> ExecuteCode(Expression<Func<object>> pythonCode, Expression<Func<object>> sessionId = null)
        {
            var __workflow_pythonCode = WorkflowExpression.Compile(pythonCode, nameof(pythonCode), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<ExecuteCodeOutput, ExecuteCodeActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["pythonCode"] = ExpressionConverter.ConvertO(__workflow_pythonCode);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "executeCode", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<ExecuteCodeOutput, ExecuteCodeActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<FileUploadOutput, FileUploadActionConfiguration> FileUpload(Expression<Func<FileUploadInputFilesTypeItem[]>> files, Expression<Func<object>> sessionId = null)
        {
            var __workflow_files = WorkflowExpression.Compile(files, nameof(files), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<FileUploadOutput, FileUploadActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["files"] = ExpressionConverter.ConvertO(__workflow_files);
                if (__workflow_sessionId != null)
                {
                    serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                }

                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileUpload", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<FileUploadOutput, FileUploadActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<JToken, FileDownloadActionConfiguration> FileDownload(Expression<Func<string>> fileName, Expression<Func<object>> sessionId)
        {
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken, FileDownloadActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileName"] = ExpressionConverter.ConvertO(__workflow_fileName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileDownload", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken, FileDownloadActionConfiguration>(serviceProviderInput);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<JToken, FileDeleteActionConfiguration> FileDelete(Expression<Func<string>> fileName, Expression<Func<object>> sessionId)
        {
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: true);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: true);
            return new DeferredBodyAction<JToken, FileDeleteActionConfiguration>(() =>
            {
                var serviceProviderParameters = new JObject();
                serviceProviderParameters["fileName"] = ExpressionConverter.ConvertO(__workflow_fileName);
                serviceProviderParameters["sessionId"] = ExpressionConverter.ConvertO(__workflow_sessionId);
                var serviceProviderInput = new ServiceProviderOperationInput
                {
                    ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileDelete", connectionName: connectionId),
                    Parameters = serviceProviderParameters
                };
                return new ServiceProviderBodyAction<JToken, FileDeleteActionConfiguration>(serviceProviderInput);
            });
        }
    }

    public sealed class ExecuteCodeActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class FileUploadActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class FileDownloadActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
    }

    public sealed class FileDeleteActionConfiguration : IRetryPolicyConfiguration, ITrackedPropertiesConfiguration, ISecureInputsConfiguration, ISecureOutputsConfiguration
    {
        RetryPolicy IRetryPolicyConfiguration.RetryPolicy { get; set; }

        IDictionary<string, Func<JToken>> ITrackedPropertiesConfiguration.TrackedProperties { get; } = new Dictionary<string, Func<JToken>>(StringComparer.Ordinal);

        bool ISecureInputsConfiguration.SecureInputs { get; set; }

        bool ISecureOutputsConfiguration.SecureOutputs { get; set; }
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