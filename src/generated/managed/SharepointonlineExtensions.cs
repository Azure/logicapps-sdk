//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SharepointonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetAllTables(Expression<Func<string>> dataset)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/alltables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApproveHubSiteJoinResponse> ApproveHubSiteJoin(Expression<Func<string>> dataset, Expression<Func<string>> joiningSiteId)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_joiningSiteId = WorkflowExpression.Compile(joiningSiteId, nameof(joiningSiteId), required: true);
            return new DeferredBodyAction<ApproveHubSiteJoinResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/approvehubsitejoin", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["joiningSiteId"] = ExpressionConverter.Convert(__workflow_joiningSiteId);
                return new ApiConnectionAction<ApproveHubSiteJoinResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CancelHubSiteJoinApproval(Expression<Func<string>> dataset, Expression<Func<string>> approvalCorrelationId = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_approvalCorrelationId = WorkflowExpression.Compile(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/cancelhubsitejoinapproval", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(__workflow_approvalCorrelationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SharingLinkPermission> CreateSharingLink(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> permissionlinkType, Expression<Func<string>> permissionlinkScope, Expression<Func<string>> permissionlinkExpiration = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_permissionlinkType = WorkflowExpression.Compile(permissionlinkType, nameof(permissionlinkType), required: true);
            var __workflow_permissionlinkScope = WorkflowExpression.Compile(permissionlinkScope, nameof(permissionlinkScope), required: true);
            var __workflow_permissionlinkExpiration = WorkflowExpression.Compile(permissionlinkExpiration, nameof(permissionlinkExpiration), required: false);
            return new DeferredBodyAction<SharingLinkPermission>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/codeless/_api/v2.0/sites/root/lists/{1}/items/{2}/driveItem/createLink", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var permission = new JObject();
                var permissionpropCount = 0;
                permissionpropCount++;
                permission["type"] = ExpressionConverter.ConvertO(__workflow_permissionlinkType);
                permissionpropCount++;
                permission["scope"] = ExpressionConverter.ConvertO(__workflow_permissionlinkScope);
                if (__workflow_permissionlinkExpiration != null)
                {
                    permission["expirationDateTime"] = ExpressionConverter.ConvertO(__workflow_permissionlinkExpiration);
                    permissionpropCount++;
                }

                if (permissionpropCount > 0)
                {
                    callPayload.Body = permission;
                }

                return new ApiConnectionAction<SharingLinkPermission>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFileAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfileToCopy, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFileIsAlreadyThere)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_parametersfileToCopy = WorkflowExpression.Compile(parametersfileToCopy, nameof(parametersfileToCopy), required: true);
            var __workflow_parametersdestinationSiteAddress = WorkflowExpression.Compile(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            var __workflow_parametersdestinationFolder = WorkflowExpression.Compile(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            var __workflow_parametersifAnotherFileIsAlreadyThere = WorkflowExpression.Compile(parametersifAnotherFileIsAlreadyThere, nameof(parametersifAnotherFileIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFileAsync", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFileId"] = ExpressionConverter.ConvertO(__workflow_parametersfileToCopy);
                parameterspropCount++;
                parameters["destinationDataset"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(__workflow_parametersifAnotherFileIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFolderAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfolderToCopy, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFolderIsAlreadyThere)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_parametersfolderToCopy = WorkflowExpression.Compile(parametersfolderToCopy, nameof(parametersfolderToCopy), required: true);
            var __workflow_parametersdestinationSiteAddress = WorkflowExpression.Compile(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            var __workflow_parametersdestinationFolder = WorkflowExpression.Compile(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            var __workflow_parametersifAnotherFolderIsAlreadyThere = WorkflowExpression.Compile(parametersifAnotherFolderIsAlreadyThere, nameof(parametersifAnotherFolderIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFolderAsync", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFolderId"] = ExpressionConverter.ConvertO(__workflow_parametersfolderToCopy);
                parameterspropCount++;
                parameters["destinationDataset"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(__workflow_parametersifAnotherFolderIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateFile(Expression<Func<string>> dataset, Expression<Func<string>> folderPath, Expression<Func<string>> name, Expression<Func<string>> body = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadataResponse> UpdateFile(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<string>> body = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteFile(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContent(Expression<Func<string>> dataset, Expression<Func<string>> id, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}/content", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder(Expression<Func<string>> dataset)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileByPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContentByPath(Expression<Func<string>> dataset, Expression<Func<string>> path, Expression<Func<bool>> inferContentType = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileContentByPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadata(Expression<Func<string>> dataset, Expression<Func<string>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolder", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadataByPath(Expression<Func<string>> dataset, Expression<Func<string>> path)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_path = WorkflowExpression.Compile(path, nameof(path), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolderByPath", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = ExpressionConverter.Convert(__workflow_path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction HttpRequest(Expression<Func<string>> dataset, Expression<Func<parametersmethodInput>> parametersmethod, Expression<Func<string>> parametersuri, Expression<Func<string>> parametersbody = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_parametersmethod = WorkflowExpression.Compile(parametersmethod, nameof(parametersmethod), required: true);
            var __workflow_parametersuri = WorkflowExpression.Compile(parametersuri, nameof(parametersuri), required: true);
            var __workflow_parametersbody = WorkflowExpression.Compile(parametersbody, nameof(parametersbody), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/httprequest", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["method"] = ExpressionConverter.ConvertO(__workflow_parametersmethod);
                parameterspropCount++;
                parameters["uri"] = ExpressionConverter.ConvertO(__workflow_parametersuri);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["headers"] = headersObject;
                    parameterspropCount++;
                }

                if (__workflow_parametersbody != null)
                {
                    parameters["body"] = ExpressionConverter.ConvertO(__workflow_parametersbody);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction JoinHubSite(Expression<Func<string>> dataset, Expression<Func<string>> hubSiteId, Expression<Func<string>> approvalToken = null, Expression<Func<string>> approvalCorrelationId = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_hubSiteId = WorkflowExpression.Compile(hubSiteId, nameof(hubSiteId), required: true);
            var __workflow_approvalToken = WorkflowExpression.Compile(approvalToken, nameof(approvalToken), required: false);
            var __workflow_approvalCorrelationId = WorkflowExpression.Compile(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/joinhubsite", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hubSiteId"] = ExpressionConverter.Convert(__workflow_hubSiteId);
                if (__workflow_approvalToken != null)
                    callPayload.Queries["approvalToken"] = ExpressionConverter.Convert(__workflow_approvalToken);
                if (__workflow_approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(__workflow_approvalCorrelationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFileAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfileToMove, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFileIsAlreadyThere)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_parametersfileToMove = WorkflowExpression.Compile(parametersfileToMove, nameof(parametersfileToMove), required: true);
            var __workflow_parametersdestinationSiteAddress = WorkflowExpression.Compile(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            var __workflow_parametersdestinationFolder = WorkflowExpression.Compile(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            var __workflow_parametersifAnotherFileIsAlreadyThere = WorkflowExpression.Compile(parametersifAnotherFileIsAlreadyThere, nameof(parametersifAnotherFileIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFileAsync", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFileId"] = ExpressionConverter.ConvertO(__workflow_parametersfileToMove);
                parameterspropCount++;
                parameters["destinationDataset"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(__workflow_parametersifAnotherFileIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFolderAsync(Expression<Func<string>> dataset, Expression<Func<string>> parametersfolderToMove, Expression<Func<string>> parametersdestinationSiteAddress, Expression<Func<string>> parametersdestinationFolder, Expression<Func<int>> parametersifAnotherFolderIsAlreadyThere)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_parametersfolderToMove = WorkflowExpression.Compile(parametersfolderToMove, nameof(parametersfolderToMove), required: true);
            var __workflow_parametersdestinationSiteAddress = WorkflowExpression.Compile(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            var __workflow_parametersdestinationFolder = WorkflowExpression.Compile(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            var __workflow_parametersifAnotherFolderIsAlreadyThere = WorkflowExpression.Compile(parametersifAnotherFolderIsAlreadyThere, nameof(parametersifAnotherFolderIsAlreadyThere), required: true);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFolderAsync", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFolderId"] = ExpressionConverter.ConvertO(__workflow_parametersfolderToMove);
                parameterspropCount++;
                parameters["destinationDataset"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = ExpressionConverter.ConvertO(__workflow_parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = ExpressionConverter.ConvertO(__workflow_parametersifAnotherFolderIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction NotifyHubSiteJoinApprovalStarted(Expression<Func<string>> dataset, Expression<Func<string>> approvalCorrelationId = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_approvalCorrelationId = WorkflowExpression.Compile(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/notifyhubsitejoinapprovalstarted", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = ExpressionConverter.Convert(__workflow_approvalCorrelationId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetTables(Expression<Func<string>> dataset)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            return new DeferredBodyAction<TablesList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TablesList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewDocumentSet(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> parametersdocumentSetPath, Expression<Func<string>> parameterscontentTypeId, Expression<Func<object>> parametersdynamicProperties = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_parametersdocumentSetPath = WorkflowExpression.Compile(parametersdocumentSetPath, nameof(parametersdocumentSetPath), required: true);
            var __workflow_parameterscontentTypeId = WorkflowExpression.Compile(parameterscontentTypeId, nameof(parameterscontentTypeId), required: true);
            var __workflow_parametersdynamicProperties = WorkflowExpression.Compile(parametersdynamicProperties, nameof(parametersdynamicProperties), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewdocumentset", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["path"] = ExpressionConverter.ConvertO(__workflow_parametersdocumentSetPath);
                parameterspropCount++;
                parameters["contentTypeId"] = ExpressionConverter.ConvertO(__workflow_parameterscontentTypeId);
                if (__workflow_parametersdynamicProperties != null)
                {
                    parameters["DynamicProperties"] = ExpressionConverter.ConvertO(__workflow_parametersdynamicProperties);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewFolder(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> parametersfolderPath, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_parametersfolderPath = WorkflowExpression.Compile(parametersfolderPath, nameof(parametersfolderPath), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewfolder", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["path"] = ExpressionConverter.ConvertO(__workflow_parametersfolderPath);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListExpandedUser> SearchForUser(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> entityId, Expression<Func<string>> searchValue, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_searchValue = WorkflowExpression.Compile(searchValue, nameof(searchValue), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<SPListExpandedUser>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/entities/{2}/searchforuser", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_entityId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchValue"] = ExpressionConverter.Convert(__workflow_searchValue);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionAction<SPListExpandedUser>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> viewScopeOption = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_viewScopeOption = WorkflowExpression.Compile(viewScopeOption, nameof(viewScopeOption), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/getfileitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_viewScopeOption != null)
                    callPayload.Queries["viewScopeOption"] = ExpressionConverter.Convert(__workflow_viewScopeOption);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> viewScopeOption = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_viewScopeOption = WorkflowExpression.Compile(viewScopeOption, nameof(viewScopeOption), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_viewScopeOption != null)
                    callPayload.Queries["viewScopeOption"] = ExpressionConverter.Convert(__workflow_viewScopeOption);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PostItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApprovalData> CreateApprovalRequest(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<int>> approvalType, Expression<Func<object>> approvalSchema = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_approvalType = WorkflowExpression.Compile(approvalType, nameof(approvalType), required: true);
            var __workflow_approvalSchema = WorkflowExpression.Compile(approvalSchema, nameof(approvalSchema), required: false);
            return new DeferredBodyAction<ApprovalData>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/approval", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["approvalType"] = ExpressionConverter.Convert(__workflow_approvalType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_approvalSchema);
                return new ApiConnectionAction<ApprovalData>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItemChanges(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> since, Expression<Func<string>> until = null, Expression<Func<bool>> includeDrafts = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_since = WorkflowExpression.Compile(since, nameof(since), required: true);
            var __workflow_until = WorkflowExpression.Compile(until, nameof(until), required: false);
            var __workflow_includeDrafts = WorkflowExpression.Compile(includeDrafts, nameof(includeDrafts), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/changes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["since"] = ExpressionConverter.Convert(__workflow_since);
                if (__workflow_until != null)
                    callPayload.Queries["until"] = ExpressionConverter.Convert(__workflow_until);
                callPayload.Queries["includeDrafts"] = Convert.ToString(false);
                if (__workflow_includeDrafts != null)
                    callPayload.Queries["includeDrafts"] = ExpressionConverter.Convert(__workflow_includeDrafts);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckInFile(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parametercomments, Expression<Func<int>> parametercheckInType)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parametercomments = WorkflowExpression.Compile(parametercomments, nameof(parametercomments), required: true);
            var __workflow_parametercheckInType = WorkflowExpression.Compile(parametercheckInType, nameof(parametercheckInType), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkinfile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameter = new JObject();
                var parameterpropCount = 0;
                parameterpropCount++;
                parameter["comment"] = ExpressionConverter.ConvertO(__workflow_parametercomments);
                parameterpropCount++;
                parameter["checkinType"] = ExpressionConverter.ConvertO(__workflow_parametercheckInType);
                if (parameterpropCount > 0)
                {
                    callPayload.Body = parameter;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckOutFile(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkoutfile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DiscardFileCheckOut(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/discardfilecheckout", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> GetFileItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/getfileitem", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction GrantAccess(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parameterrecipients, Expression<Func<string>> parameterroles, Expression<Func<string>> parametermessage = null, Expression<Func<bool>> parameternotifyRecipients = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parameterrecipients = WorkflowExpression.Compile(parameterrecipients, nameof(parameterrecipients), required: true);
            var __workflow_parameterroles = WorkflowExpression.Compile(parameterroles, nameof(parameterroles), required: true);
            var __workflow_parametermessage = WorkflowExpression.Compile(parametermessage, nameof(parametermessage), required: false);
            var __workflow_parameternotifyRecipients = WorkflowExpression.Compile(parameternotifyRecipients, nameof(parameternotifyRecipients), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/grantaccess", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameter = new JObject();
                var parameterpropCount = 0;
                parameterpropCount++;
                parameter["recipients"] = ExpressionConverter.ConvertO(__workflow_parameterrecipients);
                parameterpropCount++;
                parameter["roleValue"] = ExpressionConverter.ConvertO(__workflow_parameterroles);
                if (__workflow_parametermessage != null)
                {
                    parameter["emailBody"] = ExpressionConverter.ConvertO(__workflow_parametermessage);
                    parameterpropCount++;
                }

                if (__workflow_parameternotifyRecipients != null)
                {
                    parameter["sendEmail"] = ExpressionConverter.ConvertO(__workflow_parameternotifyRecipients);
                    parameterpropCount++;
                }

                if (parameterpropCount > 0)
                {
                    callPayload.Body = parameter;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchFileItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<object>> item = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitem", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> PatchFileItemWithPredictedValues(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<string>> parametersmodelId = null, Expression<Func<string>> parameterspredictResult = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_parametersmodelId = WorkflowExpression.Compile(parametersmodelId, nameof(parametersmodelId), required: false);
            var __workflow_parameterspredictResult = WorkflowExpression.Compile(parameterspredictResult, nameof(parameterspredictResult), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitemwithpredictedvalues", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                if (__workflow_parametersmodelId != null)
                {
                    parameters["modelId"] = ExpressionConverter.ConvertO(__workflow_parametersmodelId);
                    parameterspropCount++;
                }

                if (__workflow_parameterspredictResult != null)
                {
                    parameters["predictResult"] = ExpressionConverter.ConvertO(__workflow_parameterspredictResult);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }

                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SetApprovalStatusOutput> SetApprovalStatus(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id, Expression<Func<approvalActionInput>> approvalAction, Expression<Func<string>> comments = null, Expression<Func<string>> entityTag = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_approvalAction = WorkflowExpression.Compile(approvalAction, nameof(approvalAction), required: true);
            var __workflow_comments = WorkflowExpression.Compile(comments, nameof(comments), required: false);
            var __workflow_entityTag = WorkflowExpression.Compile(entityTag, nameof(entityTag), required: false);
            return new DeferredBodyAction<SetApprovalStatusOutput>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/setapprovalstatus", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["approvalAction"] = ExpressionConverter.Convert(__workflow_approvalAction);
                callPayload.Queries["comments"] = Convert.ToString("");
                if (__workflow_comments != null)
                    callPayload.Queries["comments"] = ExpressionConverter.Convert(__workflow_comments);
                callPayload.Queries["entityTag"] = Convert.ToString("");
                if (__workflow_entityTag != null)
                    callPayload.Queries["entityTag"] = ExpressionConverter.Convert(__workflow_entityTag);
                return new ApiConnectionAction<SetApprovalStatusOutput>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction UnshareItem(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> id)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/unshare", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment[]> GetItemAttachments(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> itemId)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            return new DeferredBodyAction<SPListItemAttachment[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_itemId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SPListItemAttachment[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment> CreateAttachment(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> displayName, Expression<Func<string>> body = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_displayName = WorkflowExpression.Compile(displayName, nameof(displayName), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SPListItemAttachment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_itemId, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["displayName"] = ExpressionConverter.Convert(__workflow_displayName);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SPListItemAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteAttachment(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> attachmentId)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_attachmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetAttachmentContent(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<int>> itemId, Expression<Func<string>> attachmentId)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_itemId = WorkflowExpression.Compile(itemId, nameof(itemId), required: true);
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}/$value", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_itemId, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateContentAssemblyDocument(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> template, Expression<Func<object>> item = null, Expression<Func<string>> folderPath = null, Expression<Func<string>> fileName = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_fileName = WorkflowExpression.Compile(fileName, nameof(fileName), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/templates/{2}/createnewdocument", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_template, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_fileName != null)
                    callPayload.Queries["fileName"] = ExpressionConverter.Convert(__workflow_fileName);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Table[]> GetTableViews(Expression<Func<string>> dataset, Expression<Func<string>> table)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyAction<Table[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/views", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Table[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateAgreementsSolutionDocument(Expression<Func<string>> dataset, Expression<Func<string>> template, Expression<Func<object>> item = null, Expression<Func<string>> documentName = null, Expression<Func<string>> table = null, Expression<Func<string>> view = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_template = WorkflowExpression.Compile(template, nameof(template), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_documentName = WorkflowExpression.Compile(documentName, nameof(documentName), required: false);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyAction<SPBlobMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/agreements/templates/{1}/createnewdocument", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_template, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_documentName != null)
                    callPayload.Queries["documentName"] = ExpressionConverter.Convert(__workflow_documentName);
                if (__workflow_table != null)
                    callPayload.Queries["table"] = ExpressionConverter.Convert(__workflow_table);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<SPBlobMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder(Expression<Func<string>> dataset, Expression<Func<string>> source, Expression<Func<string>> destination, Expression<Func<bool>> overwrite = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_destination = WorkflowExpression.Compile(destination, nameof(destination), required: true);
            var __workflow_overwrite = WorkflowExpression.Compile(overwrite, nameof(overwrite), required: false);
            return new DeferredBodyAction<BlobMetadata[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/extractFolderV2", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["destination"] = ExpressionConverter.Convert(__workflow_destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (__workflow_overwrite != null)
                    callPayload.Queries["overwrite"] = ExpressionConverter.Convert(__workflow_overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionAction<BlobMetadata[]>(callPayload);
            });
        }
    }

    public class SharepointonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnChangedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onchangeditems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            return new DeferredBodyTrigger<DeletedItemList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeletedfileitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                return new ApiConnectionTrigger<DeletedItemList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            return new DeferredBodyTrigger<DeletedItemList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeleteditems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<DeletedItemList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList> OnNewFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewfileitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList> OnNewItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> view = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileClassifiedTimes(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileclassifiedtimes", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> folderPath = null, Expression<Func<string>> view = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_folderPath = WorkflowExpression.Compile(folderPath, nameof(folderPath), required: false);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileitems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_folderPath != null)
                    callPayload.Queries["folderPath"] = ExpressionConverter.Convert(__workflow_folderPath);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems(Expression<Func<string>> dataset, Expression<Func<string>> table, Expression<Func<string>> view = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_view = WorkflowExpression.Compile(view, nameof(view), required: false);
            return new DeferredBodyTrigger<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdateditems", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_view != null)
                    callPayload.Queries["view"] = ExpressionConverter.Convert(__workflow_view);
                return new ApiConnectionTrigger<ItemsList>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string> OnNewFile(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onnewfile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile(Expression<Func<string>> dataset, Expression<Func<string>> folderId, Expression<Func<bool>> inferContentType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_dataset = WorkflowExpression.Compile(dataset, nameof(dataset), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_inferContentType = WorkflowExpression.Compile(inferContentType, nameof(inferContentType), required: false);
            return new DeferredBodyTrigger<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onupdatedfile", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (__workflow_inferContentType != null)
                    callPayload.Queries["inferContentType"] = ExpressionConverter.Convert(__workflow_inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return new ApiConnectionTrigger<string>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TablesList
    {
        [JsonProperty("value")]
        public Table[] Value { get; set; }
    }

    public class Table
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public JToken DynamicProperties { get; set; }
    }

    public class ApproveHubSiteJoinResponse
    {
        public string ApprovalToken { get; set; }
    }

    public class SharingLinkPermission
    {
        [JsonProperty("link")]
        public SharingLinkInfo Link { get; set; }
    }

    public class SharingLinkInfo
    {
        [JsonProperty("webUrl")]
        public string SharingLink { get; set; }
    }

    public class BlobMetadata
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    public class SPBlobMetadataResponse
    {
        public int ItemId { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    public class BlobMetadataResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Path { get; set; }
        public string LastModified { get; set; }
        public int Size { get; set; }
        public string MediaType { get; set; }
        public bool IsFolder { get; set; }
        public string ETag { get; set; }
        public string FileLocator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum parametersmethodInput
    {
        GET,
        PUT,
        POST,
        PATCH,
        DELETE
    }

    public class SPListExpandedUser
    {
        public string Claims { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }

        [JsonProperty("@odata.type")]
        public string Type { get; set; }
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class ApprovalData
    {
        [JsonProperty("ApprovalId")]
        public string ApprovalRequestID { get; set; }
    }

    public class SetApprovalStatusOutput
    {
        public string ETag { get; set; }
        public string ApprovalLink { get; set; }
        public string PublishStartDate { get; set; }
        public string ContentApprovalStatus { get; set; }
        public string ScheduledVersion { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum approvalActionInput
    {
        Submit,
        Approve,
        Reject
    }

    public class SPListItemAttachment
    {
        public string Id { get; set; }
        public string AbsoluteUri { get; set; }
        public string DisplayName { get; set; }
    }

    public class DeletedItemList
    {
        [JsonProperty("value")]
        public DeletedItem[] Value { get; set; }
    }

    public class DeletedItem
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [JsonProperty("FileNameWithExtension")]
        public string FilenameWithExtension { get; set; }

        [JsonProperty("DeletedByUserName")]
        public string DeletedBy { get; set; }
        public string TimeDeleted { get; set; }
        public bool IsFolder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline;

    public partial class WorkflowManagedActions
    {
        public SharepointonlineActions Sharepointonline(string connectionId) => new SharepointonlineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SharepointonlineTriggers Sharepointonline(string connectionId) => new SharepointonlineTriggers(connectionId);
    }
}
