//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Asiteusgov
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AsiteusgovActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<string> FILEDOWNLOADBYURL(Expression<Func<string>> downloadUrl)
        {
            var apiCallPath = "/downloadFileByUrl";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["downloadUrl"] = ExpressionConverter.Convert(downloadUrl);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<string> SETFILEMETADATA(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<object>> items = null)
        {
            var apiCallPath = "/saveMetadataForUpload";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Body = ExpressionConverter.ConvertO(items);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> metadataId, Expression<Func<string>> fileBinary = null)
        {
            var apiCallPath = "/uploadFileFromExternalSystem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
            callPayload.Queries["metadataId"] = ExpressionConverter.Convert(metadataId);
            callPayload.Body = ExpressionConverter.ConvertO(fileBinary);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class AsiteusgovTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASITETRIGGEREVENT(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, string triggerName = null)
        {
            var apiCallPath = "/asitePullDataWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listcallbackurl()";
            bodypropCount++;
            bodypropCount++;
            body["resourceId"] = ExpressionConverter.ConvertO(bodytriggerName);
            body["resourceType"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, string triggerName = null)
        {
            var apiCallPath = "/asitePullAppFormDataWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = ExpressionConverter.Convert(projectId);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listcallbackurl()";
            bodypropCount++;
            bodypropCount++;
            body["resourceId"] = ExpressionConverter.ConvertO(bodytriggerName);
            body["resourceType"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Asiteusgov;

    public partial class WorkflowManagedActions
    {
        public AsiteusgovActions Asiteusgov(string connectionId) => new AsiteusgovActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AsiteusgovTriggers Asiteusgov(string connectionId) => new AsiteusgovTriggers(connectionId);
    }
}