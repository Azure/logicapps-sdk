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
            callPayload.Queries["downloadUrl"] = CSharpExpressionConverter.ConvertO(downloadUrl);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<string> SETFILEMETADATA(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<object>> items = null)
        {
            var apiCallPath = "/saveMetadataForUpload";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(items);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "asiteusgov")]
        public IBodyWorkflowAction<JToken> UPLOADBINARYFILE(Expression<Func<string>> projectId, Expression<Func<string>> folderId, Expression<Func<string>> fileName, Expression<Func<string>> metadataId, Expression<Func<string>> fileBinary = null)
        {
            var apiCallPath = "/uploadFileFromExternalSystem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Queries["folderId"] = CSharpExpressionConverter.ConvertO(folderId);
            callPayload.Queries["fileName"] = CSharpExpressionConverter.ConvertO(fileName);
            callPayload.Queries["metadataId"] = CSharpExpressionConverter.ConvertO(metadataId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(fileBinary);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class AsiteusgovTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ASITETRIGGEREVENT(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/asitePullDataWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["resourceId"] = CSharpExpressionConverter.ConvertToken(bodytriggerName);
            body["resourceType"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger ASITETRIGGEREVENTAPPFORM(Expression<Func<string>> projectId, Expression<Func<string>> bodytriggerName, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/asitePullAppFormDataWebhook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectId"] = CSharpExpressionConverter.ConvertO(projectId);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            var body = new JObject();
            var bodypropCount = 0;
            body["webhookUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["resourceId"] = CSharpExpressionConverter.ConvertToken(bodytriggerName);
            body["resourceType"] = 1;
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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