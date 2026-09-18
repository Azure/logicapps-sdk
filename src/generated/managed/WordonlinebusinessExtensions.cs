//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wordonlinebusiness
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WordonlinebusinessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string> CreateFileItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<object> dynamicFileSchema = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(dynamicFileSchema, nameof(dynamicFileSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/templates/getFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["drive"] = SourceExpressionConverter.ConvertO(drive);
                callPayload.Queries["file"] = SourceExpressionConverter.ConvertO(file);
                callPayload.Body = SourceExpressionConverter.ConvertToken(dynamicFileSchema);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string> CreateWordFileWithContent([WorkflowExpression] Func<string> contentcontent, [WorkflowExpression] Func<string> fileName = null)
        {
            SourceExpression.Validate(contentcontent, nameof(contentcontent), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/templates/createWordFileWithContent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileName"] = Convert.ToString("");
                if (fileName != null)
                    callPayload.Queries["fileName"] = SourceExpressionConverter.ConvertO(fileName);
                var content = new JObject();
                var contentpropCount = 0;
                contentpropCount++;
                content["content"] = SourceExpressionConverter.ConvertToken(contentcontent);
                if (contentpropCount > 0)
                {
                    callPayload.Body = content;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string> GetFilePDF([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/templates/convertFile";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["drive"] = SourceExpressionConverter.ConvertO(drive);
                callPayload.Queries["file"] = SourceExpressionConverter.ConvertO(file);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                callPayload.Queries["format"] = Convert.ToString("pdf");
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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