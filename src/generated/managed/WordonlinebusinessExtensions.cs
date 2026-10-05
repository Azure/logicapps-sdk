//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordonlinebusiness
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordonlinebusinessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCreateFileItem))]
        public IBodyWorkflowAction<string> CreateFileItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<object> dynamicFileSchema = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateFileItem(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<object> dynamicFileSchema = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(dynamicFileSchema, nameof(dynamicFileSchema), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/templates/getFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["drive"] = ExpressionConverter.Convert(drive);
                callPayload.Queries["file"] = ExpressionConverter.Convert(file);
                callPayload.Body = ExpressionConverter.ConvertO(dynamicFileSchema);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWordFileWithContent))]
        public IBodyWorkflowAction<string> CreateWordFileWithContent([WorkflowExpression] Func<string> contentcontent, [WorkflowExpression] Func<string> fileName = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildCreateWordFileWithContent(WorkflowValue<string> contentcontent, WorkflowValue<string> fileName = null)
        {
            WorkflowValue.Validate(contentcontent, nameof(contentcontent), required: true);
            WorkflowValue.Validate(fileName, nameof(fileName), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/templates/createWordFileWithContent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileName"] = Convert.ToString("");
                if (fileName != null)
                    callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["content"] = ExpressionConverter.ConvertO(contentcontent);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetFilePDF))]
        public IBodyWorkflowAction<string> GetFilePDF([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetFilePDF(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/api/templates/convertFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["drive"] = ExpressionConverter.Convert(drive);
                callPayload.Queries["file"] = ExpressionConverter.Convert(file);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                callPayload.Queries["format"] = Convert.ToString("pdf");
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class WordonlinebusinessTriggers([ConnectionName] string connectionId)
    {
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
