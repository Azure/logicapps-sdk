//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SharepointonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetAllTables([WorkflowExpression] Func<string> dataset)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/alltables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TablesList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApproveHubSiteJoinResponse> ApproveHubSiteJoin([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> joiningSiteId)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(joiningSiteId, nameof(joiningSiteId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/approvehubsitejoin", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["joiningSiteId"] = SourceExpressionConverter.ConvertO(joiningSiteId);
                return callPayload;
            }

            return new ApiConnectionAction<ApproveHubSiteJoinResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CancelHubSiteJoinApproval([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/cancelhubsitejoinapproval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = SourceExpressionConverter.ConvertO(approvalCorrelationId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SharingLinkPermission> CreateSharingLink([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> permissionlinkType, [WorkflowExpression] Func<string> permissionlinkScope, [WorkflowExpression] Func<string> permissionlinkExpiration = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(permissionlinkType, nameof(permissionlinkType), required: true);
            SourceExpression.Validate(permissionlinkScope, nameof(permissionlinkScope), required: true);
            SourceExpression.Validate(permissionlinkExpiration, nameof(permissionlinkExpiration), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/codeless/_api/v2.0/sites/root/lists/{1}/items/{2}/driveItem/createLink", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var permission = new JObject();
                var permissionpropCount = 0;
                permissionpropCount++;
                permission["type"] = SourceExpressionConverter.ConvertToken(permissionlinkType);
                permissionpropCount++;
                permission["scope"] = SourceExpressionConverter.ConvertToken(permissionlinkScope);
                if (permissionlinkExpiration != null)
                {
                    permission["expirationDateTime"] = SourceExpressionConverter.ConvertToken(permissionlinkExpiration);
                    permissionpropCount++;
                }

                if (permissionpropCount > 0)
                {
                    callPayload.Body = permission;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SharingLinkPermission>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata> CopyFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(destination, nameof(destination), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["destination"] = SourceExpressionConverter.ConvertO(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = SourceExpressionConverter.ConvertO(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFileAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfileToCopy, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFileIsAlreadyThere)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(parametersfileToCopy, nameof(parametersfileToCopy), required: true);
            SourceExpression.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            SourceExpression.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            SourceExpression.Validate(parametersifAnotherFileIsAlreadyThere, nameof(parametersifAnotherFileIsAlreadyThere), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFileAsync", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFileId"] = SourceExpressionConverter.ConvertToken(parametersfileToCopy);
                parameterspropCount++;
                parameters["destinationDataset"] = SourceExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = SourceExpressionConverter.ConvertToken(parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = SourceExpressionConverter.ConvertToken(parametersifAnotherFileIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CopyFolderAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfolderToCopy, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFolderIsAlreadyThere)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(parametersfolderToCopy, nameof(parametersfolderToCopy), required: true);
            SourceExpression.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            SourceExpression.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            SourceExpression.Validate(parametersifAnotherFolderIsAlreadyThere, nameof(parametersifAnotherFolderIsAlreadyThere), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/copyFolderAsync", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFolderId"] = SourceExpressionConverter.ConvertToken(parametersfolderToCopy);
                parameterspropCount++;
                parameters["destinationDataset"] = SourceExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = SourceExpressionConverter.ConvertToken(parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = SourceExpressionConverter.ConvertToken(parametersifAnotherFolderIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderPath, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadata([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadataResponse> UpdateFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContent([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/files/{1}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListRootFolder([WorkflowExpression] Func<string> dataset)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ListFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/folders/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFileMetadataByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileByPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.SetHiddenQueryDefault("queryParametersSingleEncoded", true);
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetFileContentByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path, [WorkflowExpression] Func<bool> inferContentType = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(path, nameof(path), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFileContentByPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadata([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["id"] = SourceExpressionConverter.ConvertO(id);
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> GetFolderMetadataByPath([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> path)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(path, nameof(path), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/GetFolderByPath", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["path"] = SourceExpressionConverter.ConvertO(path);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction HttpRequest([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<parametersmethodInput> parametersmethod, [WorkflowExpression] Func<string> parametersuri, [WorkflowExpression] Func<string> parametersbody = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(parametersmethod, nameof(parametersmethod), required: true);
            SourceExpression.Validate(parametersuri, nameof(parametersuri), required: true);
            SourceExpression.Validate(parametersbody, nameof(parametersbody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/httprequest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["method"] = SourceExpressionConverter.Convert(parametersmethod);
                parameterspropCount++;
                parameters["uri"] = SourceExpressionConverter.ConvertToken(parametersuri);
                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    parameters["headers"] = headersObject;
                    parameterspropCount++;
                }

                if (parametersbody != null)
                {
                    parameters["body"] = SourceExpressionConverter.ConvertToken(parametersbody);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction JoinHubSite([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> hubSiteId, [WorkflowExpression] Func<string> approvalToken = null, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(hubSiteId, nameof(hubSiteId), required: true);
            SourceExpression.Validate(approvalToken, nameof(approvalToken), required: false);
            SourceExpression.Validate(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/joinhubsite", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["hubSiteId"] = SourceExpressionConverter.ConvertO(hubSiteId);
                if (approvalToken != null)
                    callPayload.Queries["approvalToken"] = SourceExpressionConverter.ConvertO(approvalToken);
                if (approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = SourceExpressionConverter.ConvertO(approvalCorrelationId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFileAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfileToMove, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFileIsAlreadyThere)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(parametersfileToMove, nameof(parametersfileToMove), required: true);
            SourceExpression.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            SourceExpression.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            SourceExpression.Validate(parametersifAnotherFileIsAlreadyThere, nameof(parametersifAnotherFileIsAlreadyThere), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFileAsync", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFileId"] = SourceExpressionConverter.ConvertToken(parametersfileToMove);
                parameterspropCount++;
                parameters["destinationDataset"] = SourceExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = SourceExpressionConverter.ConvertToken(parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = SourceExpressionConverter.ConvertToken(parametersifAnotherFileIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> MoveFolderAsync([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> parametersfolderToMove, [WorkflowExpression] Func<string> parametersdestinationSiteAddress, [WorkflowExpression] Func<string> parametersdestinationFolder, [WorkflowExpression] Func<int> parametersifAnotherFolderIsAlreadyThere)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(parametersfolderToMove, nameof(parametersfolderToMove), required: true);
            SourceExpression.Validate(parametersdestinationSiteAddress, nameof(parametersdestinationSiteAddress), required: true);
            SourceExpression.Validate(parametersdestinationFolder, nameof(parametersdestinationFolder), required: true);
            SourceExpression.Validate(parametersifAnotherFolderIsAlreadyThere, nameof(parametersifAnotherFolderIsAlreadyThere), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/moveFolderAsync", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["sourceFolderId"] = SourceExpressionConverter.ConvertToken(parametersfolderToMove);
                parameterspropCount++;
                parameters["destinationDataset"] = SourceExpressionConverter.ConvertToken(parametersdestinationSiteAddress);
                parameterspropCount++;
                parameters["destinationFolderPath"] = SourceExpressionConverter.ConvertToken(parametersdestinationFolder);
                parameterspropCount++;
                parameters["nameConflictBehavior"] = SourceExpressionConverter.ConvertToken(parametersifAnotherFolderIsAlreadyThere);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction NotifyHubSiteJoinApprovalStarted([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> approvalCorrelationId = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(approvalCorrelationId, nameof(approvalCorrelationId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/notifyhubsitejoinapprovalstarted", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (approvalCorrelationId != null)
                    callPayload.Queries["approvalCorrelationId"] = SourceExpressionConverter.ConvertO(approvalCorrelationId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<TablesList> GetTables([WorkflowExpression] Func<string> dataset)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TablesList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewDocumentSet([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> parametersdocumentSetPath, [WorkflowExpression] Func<string> parameterscontentTypeId, [WorkflowExpression] Func<object> parametersdynamicProperties = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(parametersdocumentSetPath, nameof(parametersdocumentSetPath), required: true);
            SourceExpression.Validate(parameterscontentTypeId, nameof(parameterscontentTypeId), required: true);
            SourceExpression.Validate(parametersdynamicProperties, nameof(parametersdynamicProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewdocumentset", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["path"] = SourceExpressionConverter.ConvertToken(parametersdocumentSetPath);
                parameterspropCount++;
                parameters["contentTypeId"] = SourceExpressionConverter.ConvertToken(parameterscontentTypeId);
                if (parametersdynamicProperties != null)
                {
                    parameters["DynamicProperties"] = SourceExpressionConverter.ConvertToken(parametersdynamicProperties);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> CreateNewFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> parametersfolderPath, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(parametersfolderPath, nameof(parametersfolderPath), required: true);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/createnewfolder", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                var parameters = new JObject();
                var parameterspropCount = 0;
                parameterspropCount++;
                parameters["path"] = SourceExpressionConverter.ConvertToken(parametersfolderPath);
                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListExpandedUser> SearchForUser([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> entityId, [WorkflowExpression] Func<string> searchValue, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(entityId, nameof(entityId), required: true);
            SourceExpression.Validate(searchValue, nameof(searchValue), required: true);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/entities/{2}/searchforuser", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(entityId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["searchValue"] = SourceExpressionConverter.ConvertO(searchValue);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionAction<SPListExpandedUser>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> viewScopeOption = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(viewScopeOption, nameof(viewScopeOption), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/getfileitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (viewScopeOption != null)
                    callPayload.Queries["viewScopeOption"] = SourceExpressionConverter.ConvertO(viewScopeOption);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> viewScopeOption = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(viewScopeOption, nameof(viewScopeOption), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (viewScopeOption != null)
                    callPayload.Queries["viewScopeOption"] = SourceExpressionConverter.ConvertO(viewScopeOption);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PostItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<ApprovalData> CreateApprovalRequest([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> approvalType, [WorkflowExpression] Func<object> approvalSchema = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(approvalType, nameof(approvalType), required: true);
            SourceExpression.Validate(approvalSchema, nameof(approvalSchema), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/approval", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["approvalType"] = SourceExpressionConverter.ConvertO(approvalType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(approvalSchema);
                return callPayload;
            }

            return new ApiConnectionAction<ApprovalData>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> GetItemChanges([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> since, [WorkflowExpression] Func<string> until = null, [WorkflowExpression] Func<bool> includeDrafts = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(since, nameof(since), required: true);
            SourceExpression.Validate(until, nameof(until), required: false);
            SourceExpression.Validate(includeDrafts, nameof(includeDrafts), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/changes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["since"] = SourceExpressionConverter.ConvertO(since);
                if (until != null)
                    callPayload.Queries["until"] = SourceExpressionConverter.ConvertO(until);
                callPayload.Queries["includeDrafts"] = Convert.ToString(false);
                if (includeDrafts != null)
                    callPayload.Queries["includeDrafts"] = SourceExpressionConverter.ConvertO(includeDrafts);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckInFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parametercomments, [WorkflowExpression] Func<int> parametercheckInType)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(parametercomments, nameof(parametercomments), required: true);
            SourceExpression.Validate(parametercheckInType, nameof(parametercheckInType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkinfile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameter = new JObject();
                var parameterpropCount = 0;
                parameterpropCount++;
                parameter["comment"] = SourceExpressionConverter.ConvertToken(parametercomments);
                parameterpropCount++;
                parameter["checkinType"] = SourceExpressionConverter.ConvertToken(parametercheckInType);
                if (parameterpropCount > 0)
                {
                    callPayload.Body = parameter;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction CheckOutFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/checkoutfile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DiscardFileCheckOut([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/discardfilecheckout", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> GetFileItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/getfileitem", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction GrantAccess([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parameterrecipients, [WorkflowExpression] Func<string> parameterroles, [WorkflowExpression] Func<string> parametermessage = null, [WorkflowExpression] Func<bool> parameternotifyRecipients = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(parameterrecipients, nameof(parameterrecipients), required: true);
            SourceExpression.Validate(parameterroles, nameof(parameterroles), required: true);
            SourceExpression.Validate(parametermessage, nameof(parametermessage), required: false);
            SourceExpression.Validate(parameternotifyRecipients, nameof(parameternotifyRecipients), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/grantaccess", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameter = new JObject();
                var parameterpropCount = 0;
                parameterpropCount++;
                parameter["recipients"] = SourceExpressionConverter.ConvertToken(parameterrecipients);
                parameterpropCount++;
                parameter["roleValue"] = SourceExpressionConverter.ConvertToken(parameterroles);
                if (parametermessage != null)
                {
                    parameter["emailBody"] = SourceExpressionConverter.ConvertToken(parametermessage);
                    parameterpropCount++;
                }

                if (parameternotifyRecipients != null)
                {
                    parameter["sendEmail"] = SourceExpressionConverter.ConvertToken(parameternotifyRecipients);
                    parameterpropCount++;
                }

                if (parameterpropCount > 0)
                {
                    callPayload.Body = parameter;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<JToken> PatchFileItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitem", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Item> PatchFileItemWithPredictedValues([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<string> parametersmodelId = null, [WorkflowExpression] Func<string> parameterspredictResult = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(parametersmodelId, nameof(parametersmodelId), required: false);
            SourceExpression.Validate(parameterspredictResult, nameof(parameterspredictResult), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/patchfileitemwithpredictedvalues", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var parameters = new JObject();
                var parameterspropCount = 0;
                if (parametersmodelId != null)
                {
                    parameters["modelId"] = SourceExpressionConverter.ConvertToken(parametersmodelId);
                    parameterspropCount++;
                }

                if (parameterspredictResult != null)
                {
                    parameters["predictResult"] = SourceExpressionConverter.ConvertToken(parameterspredictResult);
                    parameterspropCount++;
                }

                if (parameterspropCount > 0)
                {
                    callPayload.Body = parameters;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SetApprovalStatusOutput> SetApprovalStatus([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id, [WorkflowExpression] Func<approvalActionInput> approvalAction, [WorkflowExpression] Func<string> comments = null, [WorkflowExpression] Func<string> entityTag = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(approvalAction, nameof(approvalAction), required: true);
            SourceExpression.Validate(comments, nameof(comments), required: false);
            SourceExpression.Validate(entityTag, nameof(entityTag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/setapprovalstatus", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["approvalAction"] = SourceExpressionConverter.Convert(approvalAction);
                callPayload.Queries["comments"] = Convert.ToString("");
                if (comments != null)
                    callPayload.Queries["comments"] = SourceExpressionConverter.ConvertO(comments);
                callPayload.Queries["entityTag"] = Convert.ToString("");
                if (entityTag != null)
                    callPayload.Queries["entityTag"] = SourceExpressionConverter.ConvertO(entityTag);
                return callPayload;
            }

            return new ApiConnectionAction<SetApprovalStatusOutput>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction UnshareItem([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/unshare", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment[]> GetItemAttachments([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> itemId)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(itemId, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SPListItemAttachment[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPListItemAttachment> CreateAttachment([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> displayName, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(displayName, nameof(displayName), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["displayName"] = SourceExpressionConverter.ConvertO(displayName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SPListItemAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> attachmentId)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<string> GetAttachmentContent([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<int> itemId, [WorkflowExpression] Func<string> attachmentId)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(itemId, nameof(itemId), required: true);
            SourceExpression.Validate(attachmentId, nameof(attachmentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/items/{2}/attachments/{3}/$value", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(itemId, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateContentAssemblyDocument([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> template, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> fileName = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(template, nameof(template), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(fileName, nameof(fileName), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/templates/{2}/createnewdocument", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(template, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (fileName != null)
                    callPayload.Queries["fileName"] = SourceExpressionConverter.ConvertO(fileName);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<Table[]> GetTableViews([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/views", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Table[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<SPBlobMetadataResponse> CreateAgreementsSolutionDocument([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> template, [WorkflowExpression] Func<object> item = null, [WorkflowExpression] Func<string> documentName = null, [WorkflowExpression] Func<string> table = null, [WorkflowExpression] Func<string> view = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(template, nameof(template), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(documentName, nameof(documentName), required: false);
            SourceExpression.Validate(table, nameof(table), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/agreements/templates/{1}/createnewdocument", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(template, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (documentName != null)
                    callPayload.Queries["documentName"] = SourceExpressionConverter.ConvertO(documentName);
                if (table != null)
                    callPayload.Queries["table"] = SourceExpressionConverter.ConvertO(table);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<SPBlobMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sharepointonline")]
        public IBodyWorkflowAction<BlobMetadata[]> ExtractFolder([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> destination, [WorkflowExpression] Func<bool> overwrite = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(destination, nameof(destination), required: true);
            SourceExpression.Validate(overwrite, nameof(overwrite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/extractFolderV2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["destination"] = SourceExpressionConverter.ConvertO(destination);
                callPayload.Queries["overwrite"] = Convert.ToString(false);
                if (overwrite != null)
                    callPayload.Queries["overwrite"] = SourceExpressionConverter.ConvertO(overwrite);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<BlobMetadata[]>(BuildSourceInput);
        }
    }

    public class SharepointonlineTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ItemsList> OnChangedItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onchangeditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeletedfileitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                return callPayload;
            }

            return new ApiConnectionTrigger<DeletedItemList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<DeletedItemList> OnDeletedItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/ondeleteditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionTrigger<DeletedItemList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnNewFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewfileitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnNewItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onnewitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileClassifiedTimes([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileclassifiedtimes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedFileItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> folderPath = null, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(folderPath, nameof(folderPath), required: false);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdatedfileitems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (folderPath != null)
                    callPayload.Queries["folderPath"] = SourceExpressionConverter.ConvertO(folderPath);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<ItemsList> OnUpdatedItems([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> view = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/tables/{1}/onupdateditems", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionTrigger<ItemsList>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnNewFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onnewfile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<string> OnUpdatedFile([WorkflowExpression] Func<string> dataset, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<bool> inferContentType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(dataset, nameof(dataset), required: true);
            SourceExpression.Validate(folderId, nameof(folderId), required: true);
            SourceExpression.Validate(inferContentType, nameof(inferContentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/datasets/{0}/triggers/onupdatedfile", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataset, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                callPayload.Queries["includeFileContent"] = Convert.ToString(true);
                callPayload.Queries["inferContentType"] = Convert.ToString(true);
                if (inferContentType != null)
                    callPayload.Queries["inferContentType"] = SourceExpressionConverter.ConvertO(inferContentType);
                callPayload.Queries["queryParametersSingleEncoded"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionTrigger<string>(BuildSourceInput, triggerName, recurrence);
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