//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordonlinebusiness
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordonlinebusinessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateFileItem(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> @file, Expression<Func<object>> dynamicFileSchema = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_dynamicFileSchema = WorkflowExpression.Compile(dynamicFileSchema, nameof(dynamicFileSchema), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/templates/getFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["drive"] = ExpressionConverter.Convert(__workflow_drive);
                callPayload.Queries["file"] = ExpressionConverter.Convert(__workflow_file);
                if (__workflow_dynamicFileSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicFileSchema);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> CreateWordFileWithContent(Expression<Func<CreateWordFileWithContentInput>> content, Expression<Func<string>> fileName = null)
        {
            var __workflow_content = WorkflowExpression.Compile(content, nameof(content), required: true);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/templates/createWordFileWithContent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileName"] = Convert.ToString("");
                if (__workflow_fileName != null)
                    callPayload.Queries["fileName"] = ExpressionConverter.Convert(__workflow_fileName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_content);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetFilePDF(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> @file, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/templates/convertFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["drive"] = ExpressionConverter.Convert(__workflow_drive);
                callPayload.Queries["file"] = ExpressionConverter.Convert(__workflow_file);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                callPayload.Queries["format"] = Convert.ToString("pdf");
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WordonlinebusinessTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateWordFileWithContentInput
    {
        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wordonlinebusiness;

    public partial class WorkflowManagedActions
    {
        public WordonlinebusinessActions Wordonlinebusiness(string connectionId) => new WordonlinebusinessActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WordonlinebusinessTriggers Wordonlinebusiness(string connectionId) => new WordonlinebusinessTriggers(connectionId);
    }
}