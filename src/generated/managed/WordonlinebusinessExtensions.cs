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
        public IBodyWorkflowAction<string> CreateFileItem(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<object>> dynamicFileSchema = null)
        {
            var apiCallPath = "/api/templates/getFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["source"] = ExpressionConverter.Convert(source);
            callPayload.Queries["drive"] = ExpressionConverter.Convert(drive);
            callPayload.Queries["file"] = ExpressionConverter.Convert(file);
            callPayload.Body = ExpressionConverter.ConvertO(dynamicFileSchema);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string> CreateWordFileWithContent(Expression<Func<string>> contentcontent, Expression<Func<string>> fileName = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wordonlinebusiness")]
        public IBodyWorkflowAction<string> GetFilePDF(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
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
        }
    }

    public class WordonlinebusinessTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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