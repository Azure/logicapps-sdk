//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.Acasession
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AcasessionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<ExecuteCodeOutput> ExecuteCode(Expression<Func<object>> pythonCode, Expression<Func<object>> sessionId = null)
        {
            var parameters = new JObject();
            parameters["pythonCode"] = ExpressionConverter.ConvertO(pythonCode);
            if (sessionId != null)
            {
                parameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "executeCode", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<ExecuteCodeOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<FileUploadOutput> FileUpload(Expression<Func<FileUploadFilesTypeItem[]>> files, Expression<Func<object>> sessionId = null)
        {
            var parameters = new JObject();
            parameters["files"] = ExpressionConverter.ConvertO(files);
            if (sessionId != null)
            {
                parameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileUpload", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<FileUploadOutput>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<JToken> FileDownload(Expression<Func<string>> fileName, Expression<Func<object>> sessionId)
        {
            var parameters = new JObject();
            parameters["fileName"] = ExpressionConverter.ConvertO(fileName);
            parameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileDownload", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }

        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "acasession")]
        public IBodyWorkflowAction<JToken> FileDelete(Expression<Func<string>> fileName, Expression<Func<object>> sessionId)
        {
            var parameters = new JObject();
            parameters["fileName"] = ExpressionConverter.ConvertO(fileName);
            parameters["sessionId"] = ExpressionConverter.ConvertO(sessionId);
            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/acasession", operationId: "fileDelete", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<JToken>(input);
        }
    }

    public class AcasessionTriggers([ConnectionName] string connectionId)
    {
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

    public class FileUploadFilesTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileContent")]
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

    public partial class WorkflowServiceProviderTriggers
    {
        public AcasessionTriggers Acasession(string connectionId) => new AcasessionTriggers(connectionId);
    }
}