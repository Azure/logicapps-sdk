//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Marketoma
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MarketomaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdentity> IdentityUsingGET(Expression<Func<string>> clientId, Expression<Func<string>> clientSecret, Expression<Func<grantTypeInput>> grantType)
        {
            var apiCallPath = "/identity/oauth/token";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["client_id"] = ExpressionConverter.Convert(clientId);
            callPayload.Queries["client_secret"] = ExpressionConverter.Convert(clientSecret);
            callPayload.Queries["grant_type"] = ExpressionConverter.Convert(grantType);
            return new ApiConnectionAction<ResponseOfIdentity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdentity> IdentityUsingPOST(Expression<Func<string>> clientId, Expression<Func<string>> clientSecret, Expression<Func<grantTypeInput>> grantType)
        {
            var apiCallPath = "/identity/oauth/token";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["client_id"] = ExpressionConverter.Convert(clientId);
            callPayload.Queries["client_secret"] = ExpressionConverter.Convert(clientSecret);
            callPayload.Queries["grant_type"] = ExpressionConverter.Convert(grantType);
            return new ApiConnectionAction<ResponseOfIdentity>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFileResponse> GetFileByNameUsingGET(Expression<Func<string>> name)
        {
            var apiCallPath = "/rest/asset/v1/file/byName.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<ResponseOfFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFileResponse> GetFileByIdUsingGET(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/file/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFileResponse> UpdateContentUsingPOST(Expression<Func<int>> id, Expression<Func<string>> requestfile, Expression<Func<int>> requestid)
        {
            var apiCallPath = String.Format("/rest/asset/v1/file/{0}/content.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["file"] = ExpressionConverter.ConvertO(requestfile);
            requestpropCount++;
            request["id"] = ExpressionConverter.ConvertO(requestid);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ResponseOfFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFileResponse> GetFilesUsingGET(Expression<Func<int>> getFilesRequestfolderid, Expression<Func<getFilesRequestfoldertypeInput>> getFilesRequestfoldertype, Expression<Func<int>> getFilesRequestmaxReturn = null, Expression<Func<int>> getFilesRequestoffset = null, Expression<Func<string>> folder = null)
        {
            var apiCallPath = "/rest/asset/v1/files.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folder != null)
                callPayload.Queries["folder"] = ExpressionConverter.Convert(folder);
            var getFilesRequest = new JObject();
            var getFilesRequestpropCount = 0;
            var folderObject = new JObject();
            var folderObjectpropCount = 0;
            folderObjectpropCount++;
            folderObject["id"] = ExpressionConverter.ConvertO(getFilesRequestfolderid);
            folderObjectpropCount++;
            folderObject["type"] = ExpressionConverter.ConvertO(getFilesRequestfoldertype);
            if (folderObjectpropCount > 0)
            {
                getFilesRequest["folder"] = folderObject;
                getFilesRequestpropCount++;
            }

            if (getFilesRequestmaxReturn != null)
            {
                getFilesRequest["maxReturn"] = ExpressionConverter.ConvertO(getFilesRequestmaxReturn);
                getFilesRequestpropCount++;
            }

            if (getFilesRequestoffset != null)
            {
                getFilesRequest["offset"] = ExpressionConverter.ConvertO(getFilesRequestoffset);
                getFilesRequestpropCount++;
            }

            if (getFilesRequestpropCount > 0)
            {
                callPayload.Body = getFilesRequest;
            }

            return new ApiConnectionAction<ResponseOfFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFileResponse> CreateFileUsingPOST(Expression<Func<string>> createFileRequestfile, Expression<Func<int>> createFileRequestfolderid, Expression<Func<createFileRequestfoldertypeInput>> createFileRequestfoldertype, Expression<Func<string>> createFileRequestname, Expression<Func<string>> createFileRequestdescription = null, Expression<Func<bool>> createFileRequestinsertOnly = null)
        {
            var apiCallPath = "/rest/asset/v1/files.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createFileRequest = new JObject();
            var createFileRequestpropCount = 0;
            if (createFileRequestdescription != null)
            {
                createFileRequest["description"] = ExpressionConverter.ConvertO(createFileRequestdescription);
                createFileRequestpropCount++;
            }

            createFileRequestpropCount++;
            createFileRequest["file"] = ExpressionConverter.ConvertO(createFileRequestfile);
            var folderObject = new JObject();
            var folderObjectpropCount = 0;
            folderObjectpropCount++;
            folderObject["id"] = ExpressionConverter.ConvertO(createFileRequestfolderid);
            folderObjectpropCount++;
            folderObject["type"] = ExpressionConverter.ConvertO(createFileRequestfoldertype);
            if (folderObjectpropCount > 0)
            {
                createFileRequest["folder"] = folderObject;
                createFileRequestpropCount++;
            }

            if (createFileRequestinsertOnly != null)
            {
                createFileRequest["insertOnly"] = ExpressionConverter.ConvertO(createFileRequestinsertOnly);
                createFileRequestpropCount++;
            }

            createFileRequestpropCount++;
            createFileRequest["name"] = ExpressionConverter.ConvertO(createFileRequestname);
            if (createFileRequestpropCount > 0)
            {
                callPayload.Body = createFileRequest;
            }

            return new ApiConnectionAction<ResponseOfFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFolderResponse> GetFolderByNameUsingGET(Expression<Func<string>> name, Expression<Func<string>> type = null, Expression<Func<string>> root = null, Expression<Func<string>> workSpace = null)
        {
            var apiCallPath = "/rest/asset/v1/folder/byName.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (root != null)
                callPayload.Queries["root"] = ExpressionConverter.Convert(root);
            if (workSpace != null)
                callPayload.Queries["workSpace"] = ExpressionConverter.Convert(workSpace);
            return new ApiConnectionAction<ResponseOfFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFolderResponse> GetFolderByIdUsingGET(Expression<Func<int>> id, Expression<Func<typeInput>> type)
        {
            var apiCallPath = String.Format("/rest/asset/v1/folder/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<ResponseOfFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFolderResponse> UpdateFolderUsingPOST(Expression<Func<int>> id, Expression<Func<updateFolderRequesttypeInput>> updateFolderRequesttype, Expression<Func<string>> updateFolderRequestdescription = null, Expression<Func<bool>> updateFolderRequestisArchive = null, Expression<Func<string>> updateFolderRequestname = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/folder/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var updateFolderRequest = new JObject();
            var updateFolderRequestpropCount = 0;
            if (updateFolderRequestdescription != null)
            {
                updateFolderRequest["description"] = ExpressionConverter.ConvertO(updateFolderRequestdescription);
                updateFolderRequestpropCount++;
            }

            if (updateFolderRequestisArchive != null)
            {
                updateFolderRequest["isArchive"] = ExpressionConverter.ConvertO(updateFolderRequestisArchive);
                updateFolderRequestpropCount++;
            }

            if (updateFolderRequestname != null)
            {
                updateFolderRequest["name"] = ExpressionConverter.ConvertO(updateFolderRequestname);
                updateFolderRequestpropCount++;
            }

            updateFolderRequestpropCount++;
            updateFolderRequest["type"] = ExpressionConverter.ConvertO(updateFolderRequesttype);
            if (updateFolderRequestpropCount > 0)
            {
                callPayload.Body = updateFolderRequest;
            }

            return new ApiConnectionAction<ResponseOfFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFolderContentResponse> GetFolderContentUsingGET(Expression<Func<int>> id, Expression<Func<typeInput>> type, Expression<Func<int>> maxReturn = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/folder/{0}/content.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (maxReturn != null)
                callPayload.Queries["maxReturn"] = ExpressionConverter.Convert(maxReturn);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            return new ApiConnectionAction<ResponseOfFolderContentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> DeleteFolderUsingPOST(Expression<Func<int>> id, Expression<Func<typeInput>> type)
        {
            var apiCallPath = String.Format("/rest/asset/v1/folder/{0}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFolderResponse> GetFolderUsingGET(Expression<Func<string>> root = null, Expression<Func<int>> maxDepth = null, Expression<Func<int>> maxReturn = null, Expression<Func<int>> offset = null, Expression<Func<string>> workSpace = null)
        {
            var apiCallPath = "/rest/asset/v1/folders.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (root != null)
                callPayload.Queries["root"] = ExpressionConverter.Convert(root);
            if (maxDepth != null)
                callPayload.Queries["maxDepth"] = ExpressionConverter.Convert(maxDepth);
            if (maxReturn != null)
                callPayload.Queries["maxReturn"] = ExpressionConverter.Convert(maxReturn);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (workSpace != null)
                callPayload.Queries["workSpace"] = ExpressionConverter.Convert(workSpace);
            return new ApiConnectionAction<ResponseOfFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfFolderResponse> CreateFolderUsingPOST(Expression<Func<string>> createFolderRequestname, Expression<Func<int>> createFolderRequestparentid, Expression<Func<createFolderRequestparenttypeInput>> createFolderRequestparenttype, Expression<Func<string>> createFolderRequestdescription = null)
        {
            var apiCallPath = "/rest/asset/v1/folders.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createFolderRequest = new JObject();
            var createFolderRequestpropCount = 0;
            if (createFolderRequestdescription != null)
            {
                createFolderRequest["description"] = ExpressionConverter.ConvertO(createFolderRequestdescription);
                createFolderRequestpropCount++;
            }

            createFolderRequestpropCount++;
            createFolderRequest["name"] = ExpressionConverter.ConvertO(createFolderRequestname);
            var parentObject = new JObject();
            var parentObjectpropCount = 0;
            parentObjectpropCount++;
            parentObject["id"] = ExpressionConverter.ConvertO(createFolderRequestparentid);
            parentObjectpropCount++;
            parentObject["type"] = ExpressionConverter.ConvertO(createFolderRequestparenttype);
            if (parentObjectpropCount > 0)
            {
                createFolderRequest["parent"] = parentObject;
                createFolderRequestpropCount++;
            }

            if (createFolderRequestpropCount > 0)
            {
                callPayload.Body = createFolderRequest;
            }

            return new ApiConnectionAction<ResponseOfFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramResponse> GetProgramByNameUsingGET(Expression<Func<string>> name, Expression<Func<bool>> includeTags = null, Expression<Func<bool>> includeCosts = null)
        {
            var apiCallPath = "/rest/asset/v1/program/byName.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (includeTags != null)
                callPayload.Queries["includeTags"] = ExpressionConverter.Convert(includeTags);
            if (includeCosts != null)
                callPayload.Queries["includeCosts"] = ExpressionConverter.Convert(includeCosts);
            return new ApiConnectionAction<ResponseOfProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramResponse> GetProgramListByTagUsingGET(Expression<Func<string>> tagType, Expression<Func<string>> tagValue, Expression<Func<int>> maxReturn = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/rest/asset/v1/program/byTag.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tagType"] = ExpressionConverter.Convert(tagType);
            callPayload.Queries["tagValue"] = ExpressionConverter.Convert(tagValue);
            if (maxReturn != null)
                callPayload.Queries["maxReturn"] = ExpressionConverter.Convert(maxReturn);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<ResponseOfProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramResponse> GetProgramByIdUsingGET(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramResponse> UpdateProgramUsingPOST(Expression<Func<int>> id, Expression<Func<CostRequest[]>> updateProgramRequestcosts = null, Expression<Func<bool>> updateProgramRequestcostsDestructiveUpdate = null, Expression<Func<string>> updateProgramRequestdescription = null, Expression<Func<string>> updateProgramRequestendDate = null, Expression<Func<string>> updateProgramRequestname = null, Expression<Func<string>> updateProgramRequeststartDate = null, Expression<Func<TagRequest[]>> updateProgramRequesttags = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var updateProgramRequest = new JObject();
            var updateProgramRequestpropCount = 0;
            if (updateProgramRequestcosts != null)
            {
                updateProgramRequest["costs"] = ExpressionConverter.ConvertO(updateProgramRequestcosts);
                updateProgramRequestpropCount++;
            }

            if (updateProgramRequestcostsDestructiveUpdate != null)
            {
                updateProgramRequest["costsDestructiveUpdate"] = ExpressionConverter.ConvertO(updateProgramRequestcostsDestructiveUpdate);
                updateProgramRequestpropCount++;
            }

            if (updateProgramRequestdescription != null)
            {
                updateProgramRequest["description"] = ExpressionConverter.ConvertO(updateProgramRequestdescription);
                updateProgramRequestpropCount++;
            }

            if (updateProgramRequestendDate != null)
            {
                updateProgramRequest["endDate"] = ExpressionConverter.ConvertO(updateProgramRequestendDate);
                updateProgramRequestpropCount++;
            }

            if (updateProgramRequestname != null)
            {
                updateProgramRequest["name"] = ExpressionConverter.ConvertO(updateProgramRequestname);
                updateProgramRequestpropCount++;
            }

            if (updateProgramRequeststartDate != null)
            {
                updateProgramRequest["startDate"] = ExpressionConverter.ConvertO(updateProgramRequeststartDate);
                updateProgramRequestpropCount++;
            }

            if (updateProgramRequesttags != null)
            {
                updateProgramRequest["tags"] = ExpressionConverter.ConvertO(updateProgramRequesttags);
                updateProgramRequestpropCount++;
            }

            if (updateProgramRequestpropCount > 0)
            {
                callPayload.Body = updateProgramRequest;
            }

            return new ApiConnectionAction<ResponseOfProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfSmartListResponseWithRules> GetSmartListByProgramIdUsingGET(Expression<Func<int>> programId, Expression<Func<bool>> includeRules = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}/smartList.json", ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeRules != null)
                callPayload.Queries["includeRules"] = ExpressionConverter.Convert(includeRules);
            return new ApiConnectionAction<ResponseOfSmartListResponseWithRules>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> ApproveProgramUsingPOST(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}/approve.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramResponse> CloneProgramUsingPOST(Expression<Func<int>> id, Expression<Func<int>> cloneProgramRequestfolderid, Expression<Func<cloneProgramRequestfoldertypeInput>> cloneProgramRequestfoldertype, Expression<Func<string>> cloneProgramRequestname, Expression<Func<string>> cloneProgramRequestdescription = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}/clone.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var cloneProgramRequest = new JObject();
            var cloneProgramRequestpropCount = 0;
            if (cloneProgramRequestdescription != null)
            {
                cloneProgramRequest["description"] = ExpressionConverter.ConvertO(cloneProgramRequestdescription);
                cloneProgramRequestpropCount++;
            }

            var folderObject = new JObject();
            var folderObjectpropCount = 0;
            folderObjectpropCount++;
            folderObject["id"] = ExpressionConverter.ConvertO(cloneProgramRequestfolderid);
            folderObjectpropCount++;
            folderObject["type"] = ExpressionConverter.ConvertO(cloneProgramRequestfoldertype);
            if (folderObjectpropCount > 0)
            {
                cloneProgramRequest["folder"] = folderObject;
                cloneProgramRequestpropCount++;
            }

            cloneProgramRequestpropCount++;
            cloneProgramRequest["name"] = ExpressionConverter.ConvertO(cloneProgramRequestname);
            if (cloneProgramRequestpropCount > 0)
            {
                callPayload.Body = cloneProgramRequest;
            }

            return new ApiConnectionAction<ResponseOfProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> DeleteProgramUsingPOST(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> UnapproveProgramUsingPOST(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}/unapprove.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> UpdateProgramTagUsingPOST(Expression<Func<int>> id, Expression<Func<string>> tagType, Expression<Func<string>> tagValue)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}/tag/{1}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(tagType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["tagValue"] = ExpressionConverter.Convert(tagValue);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> DeleteProgramTagUsingPOST(Expression<Func<int>> id, Expression<Func<string>> tagType)
        {
            var apiCallPath = String.Format("/rest/asset/v1/program/{0}/tag/{1}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1), ExpressionConverter.ConvertWithUrlEncoding(tagType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfBrowseAllPrograms> BrowseProgramsUsingGET(Expression<Func<int>> maxReturn = null, Expression<Func<int>> offset = null, Expression<Func<filterTypeInput>> filterType = null, Expression<Func<string>> earliestUpdatedAt = null, Expression<Func<string>> latestUpdatedAt = null)
        {
            var apiCallPath = "/rest/asset/v1/programs.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (maxReturn != null)
                callPayload.Queries["maxReturn"] = ExpressionConverter.Convert(maxReturn);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (filterType != null)
                callPayload.Queries["filterType"] = ExpressionConverter.Convert(filterType);
            if (earliestUpdatedAt != null)
                callPayload.Queries["earliestUpdatedAt"] = ExpressionConverter.Convert(earliestUpdatedAt);
            if (latestUpdatedAt != null)
                callPayload.Queries["latestUpdatedAt"] = ExpressionConverter.Convert(latestUpdatedAt);
            return new ApiConnectionAction<ResponseOfBrowseAllPrograms>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramResponse> CreateProgramUsingPOST(Expression<Func<string>> createProgramRequestchannel, Expression<Func<int>> createProgramRequestfolderid, Expression<Func<createProgramRequestfoldertypeInput>> createProgramRequestfoldertype, Expression<Func<string>> createProgramRequestname, Expression<Func<string>> createProgramRequesttype, Expression<Func<CostRequest[]>> createProgramRequestcosts = null, Expression<Func<string>> createProgramRequestdescription = null, Expression<Func<TagRequest[]>> createProgramRequesttags = null)
        {
            var apiCallPath = "/rest/asset/v1/programs.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createProgramRequest = new JObject();
            var createProgramRequestpropCount = 0;
            createProgramRequestpropCount++;
            createProgramRequest["channel"] = ExpressionConverter.ConvertO(createProgramRequestchannel);
            if (createProgramRequestcosts != null)
            {
                createProgramRequest["costs"] = ExpressionConverter.ConvertO(createProgramRequestcosts);
                createProgramRequestpropCount++;
            }

            if (createProgramRequestdescription != null)
            {
                createProgramRequest["description"] = ExpressionConverter.ConvertO(createProgramRequestdescription);
                createProgramRequestpropCount++;
            }

            var folderObject = new JObject();
            var folderObjectpropCount = 0;
            folderObjectpropCount++;
            folderObject["id"] = ExpressionConverter.ConvertO(createProgramRequestfolderid);
            folderObjectpropCount++;
            folderObject["type"] = ExpressionConverter.ConvertO(createProgramRequestfoldertype);
            if (folderObjectpropCount > 0)
            {
                createProgramRequest["folder"] = folderObject;
                createProgramRequestpropCount++;
            }

            createProgramRequestpropCount++;
            createProgramRequest["name"] = ExpressionConverter.ConvertO(createProgramRequestname);
            if (createProgramRequesttags != null)
            {
                createProgramRequest["tags"] = ExpressionConverter.ConvertO(createProgramRequesttags);
                createProgramRequestpropCount++;
            }

            createProgramRequestpropCount++;
            createProgramRequest["type"] = ExpressionConverter.ConvertO(createProgramRequesttype);
            if (createProgramRequestpropCount > 0)
            {
                callPayload.Body = createProgramRequest;
            }

            return new ApiConnectionAction<ResponseOfProgramResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfSmartListResponseWithRules> GetSmartListByIdUsingGET(Expression<Func<int>> id, Expression<Func<bool>> includeRules = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/smartList/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (includeRules != null)
                callPayload.Queries["includeRules"] = ExpressionConverter.Convert(includeRules);
            return new ApiConnectionAction<ResponseOfSmartListResponseWithRules>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfSmartListResponse> GetSmartListByNameUsingGET(Expression<Func<string>> name)
        {
            var apiCallPath = "/rest/asset/v1/smartList/byName.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<ResponseOfSmartListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> DeleteSmartListByIdUsingPOST(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/smartList/{0}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfSmartListResponse> GetSmartListsUsingGET(Expression<Func<string>> folder = null, Expression<Func<int>> offset = null, Expression<Func<int>> maxReturn = null, Expression<Func<string>> earliestUpdatedAt = null, Expression<Func<string>> latestUpdatedAt = null)
        {
            var apiCallPath = "/rest/asset/v1/smartLists.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folder != null)
                callPayload.Queries["folder"] = ExpressionConverter.Convert(folder);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (maxReturn != null)
                callPayload.Queries["maxReturn"] = ExpressionConverter.Convert(maxReturn);
            if (earliestUpdatedAt != null)
                callPayload.Queries["earliestUpdatedAt"] = ExpressionConverter.Convert(earliestUpdatedAt);
            if (latestUpdatedAt != null)
                callPayload.Queries["latestUpdatedAt"] = ExpressionConverter.Convert(latestUpdatedAt);
            return new ApiConnectionAction<ResponseOfSmartListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfSmartListResponse> CloneSmartListUsingPOST(Expression<Func<int>> id, Expression<Func<string>> cloneSmartListRequestname, Expression<Func<int>> cloneSmartListRequestfolderid, Expression<Func<cloneSmartListRequestfoldertypeInput>> cloneSmartListRequestfoldertype, Expression<Func<string>> cloneSmartListRequestdescription = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/smartList/{0}/clone.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var cloneSmartListRequest = new JObject();
            var cloneSmartListRequestpropCount = 0;
            cloneSmartListRequestpropCount++;
            cloneSmartListRequest["name"] = ExpressionConverter.ConvertO(cloneSmartListRequestname);
            var folderObject = new JObject();
            var folderObjectpropCount = 0;
            folderObjectpropCount++;
            folderObject["id"] = ExpressionConverter.ConvertO(cloneSmartListRequestfolderid);
            folderObjectpropCount++;
            folderObject["type"] = ExpressionConverter.ConvertO(cloneSmartListRequestfoldertype);
            if (folderObjectpropCount > 0)
            {
                cloneSmartListRequest["folder"] = folderObject;
                cloneSmartListRequestpropCount++;
            }

            if (cloneSmartListRequestdescription != null)
            {
                cloneSmartListRequest["description"] = ExpressionConverter.ConvertO(cloneSmartListRequestdescription);
                cloneSmartListRequestpropCount++;
            }

            if (cloneSmartListRequestpropCount > 0)
            {
                callPayload.Body = cloneSmartListRequest;
            }

            return new ApiConnectionAction<ResponseOfSmartListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfStaticListResponse> GetStaticListByIdUsingGET(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/staticList/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfStaticListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfStaticListResponse> UpdateStaticListUsingPOST(Expression<Func<int>> id, Expression<Func<string>> updateStaticListRequestdescription = null, Expression<Func<string>> updateStaticListRequestname = null)
        {
            var apiCallPath = String.Format("/rest/asset/v1/staticList/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var updateStaticListRequest = new JObject();
            var updateStaticListRequestpropCount = 0;
            if (updateStaticListRequestdescription != null)
            {
                updateStaticListRequest["description"] = ExpressionConverter.ConvertO(updateStaticListRequestdescription);
                updateStaticListRequestpropCount++;
            }

            if (updateStaticListRequestname != null)
            {
                updateStaticListRequest["name"] = ExpressionConverter.ConvertO(updateStaticListRequestname);
                updateStaticListRequestpropCount++;
            }

            if (updateStaticListRequestpropCount > 0)
            {
                callPayload.Body = updateStaticListRequest;
            }

            return new ApiConnectionAction<ResponseOfStaticListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfStaticListResponse> GetStaticListsUsingGET(Expression<Func<string>> folder = null, Expression<Func<int>> offset = null, Expression<Func<int>> maxReturn = null, Expression<Func<string>> earliestUpdatedAt = null, Expression<Func<string>> latestUpdatedAt = null)
        {
            var apiCallPath = "/rest/asset/v1/staticLists.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (folder != null)
                callPayload.Queries["folder"] = ExpressionConverter.Convert(folder);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (maxReturn != null)
                callPayload.Queries["maxReturn"] = ExpressionConverter.Convert(maxReturn);
            if (earliestUpdatedAt != null)
                callPayload.Queries["earliestUpdatedAt"] = ExpressionConverter.Convert(earliestUpdatedAt);
            if (latestUpdatedAt != null)
                callPayload.Queries["latestUpdatedAt"] = ExpressionConverter.Convert(latestUpdatedAt);
            return new ApiConnectionAction<ResponseOfStaticListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfStaticListResponse> CreateStaticListUsingPOST(Expression<Func<string>> createStaticListRequestname, Expression<Func<int>> createStaticListRequestfolderid, Expression<Func<createStaticListRequestfoldertypeInput>> createStaticListRequestfoldertype, Expression<Func<string>> createStaticListRequestdescription = null)
        {
            var apiCallPath = "/rest/asset/v1/staticLists.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var createStaticListRequest = new JObject();
            var createStaticListRequestpropCount = 0;
            if (createStaticListRequestdescription != null)
            {
                createStaticListRequest["description"] = ExpressionConverter.ConvertO(createStaticListRequestdescription);
                createStaticListRequestpropCount++;
            }

            createStaticListRequestpropCount++;
            createStaticListRequest["name"] = ExpressionConverter.ConvertO(createStaticListRequestname);
            var folderObject = new JObject();
            var folderObjectpropCount = 0;
            folderObjectpropCount++;
            folderObject["id"] = ExpressionConverter.ConvertO(createStaticListRequestfolderid);
            folderObjectpropCount++;
            folderObject["type"] = ExpressionConverter.ConvertO(createStaticListRequestfoldertype);
            if (folderObjectpropCount > 0)
            {
                createStaticListRequest["folder"] = folderObject;
                createStaticListRequestpropCount++;
            }

            if (createStaticListRequestpropCount > 0)
            {
                callPayload.Body = createStaticListRequest;
            }

            return new ApiConnectionAction<ResponseOfStaticListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfStaticListResponse> GetStaticListByNameUsingGET(Expression<Func<string>> name)
        {
            var apiCallPath = "/rest/asset/v1/staticList/byName.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            return new ApiConnectionAction<ResponseOfStaticListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfIdResponse> DeleteStaticListByIdUsingPOST(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/rest/asset/v1/staticList/{0}/delete.json", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfImportLeadResponse> ImportLeadUsingPOST(Expression<Func<formatInput>> format, Expression<Func<object>> file, Expression<Func<string>> lookupField = null, Expression<Func<string>> partitionName = null, Expression<Func<int>> listId = null)
        {
            var apiCallPath = "/bulk/v1/leads.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            if (lookupField != null)
                callPayload.Queries["lookupField"] = ExpressionConverter.Convert(lookupField);
            if (partitionName != null)
                callPayload.Queries["partitionName"] = ExpressionConverter.Convert(partitionName);
            if (listId != null)
                callPayload.Queries["listId"] = ExpressionConverter.Convert(listId);
            return new ApiConnectionAction<ResponseOfImportLeadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfImportLeadResponse> GetImportLeadStatusUsingGET(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/bulk/v1/leads/batch/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfImportLeadResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<JToken> GetImportLeadFailuresUsingGET(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/bulk/v1/leads/batch/{0}/failures.json", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<JToken> GetImportLeadWarningsUsingGET(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/bulk/v1/leads/batch/{0}/warnings.json", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponseWithToken> GetExportLeadsUsingGET(Expression<Func<string[]>> status = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = "/bulk/v1/leads/export.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfExportResponseWithToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> CreateExportLeadsUsingPOST(Expression<Func<string>> exportLeadRequestcolumnHeaderNamesname, Expression<Func<string>> exportLeadRequestcolumnHeaderNamesvalue, Expression<Func<string[]>> exportLeadRequestfields, Expression<Func<int>> exportLeadRequestfiltersmartListId, Expression<Func<string>> exportLeadRequestfiltersmartListName, Expression<Func<int>> exportLeadRequestfilterstaticListId, Expression<Func<string>> exportLeadRequestfilterstaticListName, Expression<Func<string>> exportLeadRequestfiltercreatedAtendAt = null, Expression<Func<string>> exportLeadRequestfiltercreatedAtstartAt = null, Expression<Func<string>> exportLeadRequestfilterupdatedAtendAt = null, Expression<Func<string>> exportLeadRequestfilterupdatedAtstartAt = null, Expression<Func<string>> exportLeadRequestformat = null)
        {
            var apiCallPath = "/bulk/v1/leads/export/create.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exportLeadRequest = new JObject();
            var exportLeadRequestpropCount = 0;
            var columnHeaderNamesObject = new JObject();
            var columnHeaderNamesObjectpropCount = 0;
            columnHeaderNamesObjectpropCount++;
            columnHeaderNamesObject["name"] = ExpressionConverter.ConvertO(exportLeadRequestcolumnHeaderNamesname);
            columnHeaderNamesObjectpropCount++;
            columnHeaderNamesObject["value"] = ExpressionConverter.ConvertO(exportLeadRequestcolumnHeaderNamesvalue);
            if (columnHeaderNamesObjectpropCount > 0)
            {
                exportLeadRequest["columnHeaderNames"] = columnHeaderNamesObject;
                exportLeadRequestpropCount++;
            }

            exportLeadRequestpropCount++;
            exportLeadRequest["fields"] = ExpressionConverter.ConvertO(exportLeadRequestfields);
            var filterObject = new JObject();
            var filterObjectpropCount = 0;
            var createdAtObject = new JObject();
            var createdAtObjectpropCount = 0;
            if (exportLeadRequestfiltercreatedAtendAt != null)
            {
                createdAtObject["endAt"] = ExpressionConverter.ConvertO(exportLeadRequestfiltercreatedAtendAt);
                createdAtObjectpropCount++;
            }

            if (exportLeadRequestfiltercreatedAtstartAt != null)
            {
                createdAtObject["startAt"] = ExpressionConverter.ConvertO(exportLeadRequestfiltercreatedAtstartAt);
                createdAtObjectpropCount++;
            }

            if (createdAtObjectpropCount > 0)
            {
                filterObject["createdAt"] = createdAtObject;
                filterObjectpropCount++;
            }

            filterObjectpropCount++;
            filterObject["smartListId"] = ExpressionConverter.ConvertO(exportLeadRequestfiltersmartListId);
            filterObjectpropCount++;
            filterObject["smartListName"] = ExpressionConverter.ConvertO(exportLeadRequestfiltersmartListName);
            filterObjectpropCount++;
            filterObject["staticListId"] = ExpressionConverter.ConvertO(exportLeadRequestfilterstaticListId);
            filterObjectpropCount++;
            filterObject["staticListName"] = ExpressionConverter.ConvertO(exportLeadRequestfilterstaticListName);
            var updatedAtObject = new JObject();
            var updatedAtObjectpropCount = 0;
            if (exportLeadRequestfiltercreatedAtendAt != null)
            {
                updatedAtObject["endAt"] = ExpressionConverter.ConvertO(exportLeadRequestfiltercreatedAtendAt);
                updatedAtObjectpropCount++;
            }

            if (exportLeadRequestfiltercreatedAtstartAt != null)
            {
                updatedAtObject["startAt"] = ExpressionConverter.ConvertO(exportLeadRequestfiltercreatedAtstartAt);
                updatedAtObjectpropCount++;
            }

            if (updatedAtObjectpropCount > 0)
            {
                filterObject["updatedAt"] = updatedAtObject;
                filterObjectpropCount++;
            }

            if (filterObjectpropCount > 0)
            {
                exportLeadRequest["filter"] = filterObject;
                exportLeadRequestpropCount++;
            }

            if (exportLeadRequestformat != null)
            {
                exportLeadRequest["format"] = ExpressionConverter.ConvertO(exportLeadRequestformat);
                exportLeadRequestpropCount++;
            }

            if (exportLeadRequestpropCount > 0)
            {
                callPayload.Body = exportLeadRequest;
            }

            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> CancelExportLeadsUsingPOST(Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/bulk/v1/leads/export/{0}/cancel.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> EnqueueExportLeadsUsingPOST(Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/bulk/v1/leads/export/{0}/enqueue.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<JToken> GetExportLeadsFileUsingGET(Expression<Func<string>> exportId, Expression<Func<string>> range = null)
        {
            var apiCallPath = String.Format("/bulk/v1/leads/export/{0}/file.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (range != null)
                callPayload.Headers["Range"] = ExpressionConverter.Convert(range);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> GetExportLeadsStatusUsingGET(Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/bulk/v1/leads/export/{0}/status.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfImportProgramMemberResponse> ImportProgramMemberUsingPOST(Expression<Func<string>> programId, Expression<Func<string>> programMemberStatus, Expression<Func<formatInput>> format, Expression<Func<object>> file)
        {
            var apiCallPath = String.Format("/bulk/v1/program/{0}/members/import.json", ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["programMemberStatus"] = ExpressionConverter.Convert(programMemberStatus);
            callPayload.Queries["format"] = ExpressionConverter.Convert(format);
            return new ApiConnectionAction<ResponseOfImportProgramMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<JToken> GetImportProgramMemberFailuresUsingGET(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/bulk/v1/program/members/import/{0}/failures.json", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfImportProgramMemberResponse> GetImportProgramMemberStatusUsingGET(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/bulk/v1/program/members/import/{0}/status.json", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfImportProgramMemberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<JToken> GetImportProgramMemberWarningsUsingGET(Expression<Func<int>> batchId)
        {
            var apiCallPath = String.Format("/bulk/v1/program/members/import/{0}/warnings.json", ExpressionConverter.ConvertWithUrlEncoding(batchId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponseWithToken> GetExportProgramMembersUsingGET(Expression<Func<string[]>> status = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = "/bulk/v1/program/members/export.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfExportResponseWithToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> CreateExportProgramMembersUsingPOST(Expression<Func<string>> exportProgramMemberRequestcolumnHeaderNamesname, Expression<Func<string>> exportProgramMemberRequestcolumnHeaderNamesvalue, Expression<Func<string[]>> exportProgramMemberRequestfields, Expression<Func<int>> exportProgramMemberRequestfilterprogramId, Expression<Func<int[]>> exportProgramMemberRequestfilterprogramIds, Expression<Func<bool>> exportProgramMemberRequestfilterisExhausted = null, Expression<Func<exportProgramMemberRequestfilternurtureCadenceInput>> exportProgramMemberRequestfilternurtureCadence = null, Expression<Func<string[]>> exportProgramMemberRequestfilterstatusNames = null, Expression<Func<string>> exportProgramMemberRequestfilterupdatedAtendAt = null, Expression<Func<string>> exportProgramMemberRequestfilterupdatedAtstartAt = null, Expression<Func<string>> exportProgramMemberRequestformat = null)
        {
            var apiCallPath = "/bulk/v1/program/members/export/create.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var exportProgramMemberRequest = new JObject();
            var exportProgramMemberRequestpropCount = 0;
            var columnHeaderNamesObject = new JObject();
            var columnHeaderNamesObjectpropCount = 0;
            columnHeaderNamesObjectpropCount++;
            columnHeaderNamesObject["name"] = ExpressionConverter.ConvertO(exportProgramMemberRequestcolumnHeaderNamesname);
            columnHeaderNamesObjectpropCount++;
            columnHeaderNamesObject["value"] = ExpressionConverter.ConvertO(exportProgramMemberRequestcolumnHeaderNamesvalue);
            if (columnHeaderNamesObjectpropCount > 0)
            {
                exportProgramMemberRequest["columnHeaderNames"] = columnHeaderNamesObject;
                exportProgramMemberRequestpropCount++;
            }

            exportProgramMemberRequestpropCount++;
            exportProgramMemberRequest["fields"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfields);
            var filterObject = new JObject();
            var filterObjectpropCount = 0;
            filterObjectpropCount++;
            filterObject["programId"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfilterprogramId);
            filterObjectpropCount++;
            filterObject["programIds"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfilterprogramIds);
            if (exportProgramMemberRequestfilterisExhausted != null)
            {
                filterObject["isExhausted"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfilterisExhausted);
                filterObjectpropCount++;
            }

            if (exportProgramMemberRequestfilternurtureCadence != null)
            {
                filterObject["nurtureCadence"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfilternurtureCadence);
                filterObjectpropCount++;
            }

            if (exportProgramMemberRequestfilterstatusNames != null)
            {
                filterObject["statusNames"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfilterstatusNames);
                filterObjectpropCount++;
            }

            var updatedAtObject = new JObject();
            var updatedAtObjectpropCount = 0;
            if (exportProgramMemberRequestfilterupdatedAtendAt != null)
            {
                updatedAtObject["endAt"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfilterupdatedAtendAt);
                updatedAtObjectpropCount++;
            }

            if (exportProgramMemberRequestfilterupdatedAtstartAt != null)
            {
                updatedAtObject["startAt"] = ExpressionConverter.ConvertO(exportProgramMemberRequestfilterupdatedAtstartAt);
                updatedAtObjectpropCount++;
            }

            if (updatedAtObjectpropCount > 0)
            {
                filterObject["updatedAt"] = updatedAtObject;
                filterObjectpropCount++;
            }

            if (filterObjectpropCount > 0)
            {
                exportProgramMemberRequest["filter"] = filterObject;
                exportProgramMemberRequestpropCount++;
            }

            if (exportProgramMemberRequestformat != null)
            {
                exportProgramMemberRequest["format"] = ExpressionConverter.ConvertO(exportProgramMemberRequestformat);
                exportProgramMemberRequestpropCount++;
            }

            if (exportProgramMemberRequestpropCount > 0)
            {
                callPayload.Body = exportProgramMemberRequest;
            }

            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> CancelExportProgramMembersUsingPOST(Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/bulk/v1/program/members/export/{0}/cancel.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> EnqueueExportProgramMembersUsingPOST(Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/bulk/v1/program/members/export/{0}/enqueue.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<JToken> GetExportProgramMembersFileUsingGET(Expression<Func<string>> exportId, Expression<Func<string>> range = null)
        {
            var apiCallPath = String.Format("/bulk/v1/program/members/export/{0}/file.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (range != null)
                callPayload.Headers["Range"] = ExpressionConverter.Convert(range);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfExportResponse> GetExportProgramMembersStatusUsingGET(Expression<Func<string>> exportId)
        {
            var apiCallPath = String.Format("/bulk/v1/program/members/export/{0}/status.json", ExpressionConverter.ConvertWithUrlEncoding(exportId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfExportResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfCampaign> GetCampaignsUsingGET(Expression<Func<int[]>> id = null, Expression<Func<string[]>> name = null, Expression<Func<string[]>> programName = null, Expression<Func<string[]>> workspaceName = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null, Expression<Func<bool>> isTriggerable = null)
        {
            var apiCallPath = "/rest/v1/campaigns.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (programName != null)
                callPayload.Queries["programName"] = ExpressionConverter.Convert(programName);
            if (workspaceName != null)
                callPayload.Queries["workspaceName"] = ExpressionConverter.Convert(workspaceName);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            if (isTriggerable != null)
                callPayload.Queries["isTriggerable"] = ExpressionConverter.Convert(isTriggerable);
            return new ApiConnectionAction<ResponseOfCampaign>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfCampaign> GetCampaignByIdUsingGET(Expression<Func<int>> campaignId)
        {
            var apiCallPath = String.Format("/rest/v1/campaigns/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfCampaign>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfCampaign> ScheduleCampaignUsingPOST(Expression<Func<int>> campaignId, Expression<Func<string>> scheduleCampaignRequestinputcloneToProgramName = null, Expression<Func<string>> scheduleCampaignRequestinputrunAt = null, Expression<Func<Token[]>> scheduleCampaignRequestinputtokens = null)
        {
            var apiCallPath = String.Format("/rest/v1/campaigns/{0}/schedule.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var scheduleCampaignRequest = new JObject();
            var scheduleCampaignRequestpropCount = 0;
            var inputObject = new JObject();
            var inputObjectpropCount = 0;
            if (scheduleCampaignRequestinputcloneToProgramName != null)
            {
                inputObject["cloneToProgramName"] = ExpressionConverter.ConvertO(scheduleCampaignRequestinputcloneToProgramName);
                inputObjectpropCount++;
            }

            if (scheduleCampaignRequestinputrunAt != null)
            {
                inputObject["runAt"] = ExpressionConverter.ConvertO(scheduleCampaignRequestinputrunAt);
                inputObjectpropCount++;
            }

            if (scheduleCampaignRequestinputtokens != null)
            {
                inputObject["tokens"] = ExpressionConverter.ConvertO(scheduleCampaignRequestinputtokens);
                inputObjectpropCount++;
            }

            if (inputObjectpropCount > 0)
            {
                scheduleCampaignRequest["input"] = inputObject;
                scheduleCampaignRequestpropCount++;
            }

            if (scheduleCampaignRequestpropCount > 0)
            {
                callPayload.Body = scheduleCampaignRequest;
            }

            return new ApiConnectionAction<ResponseOfCampaign>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfCampaign> TriggerCampaignUsingPOST(Expression<Func<int>> campaignId, Expression<Func<InputLead[]>> triggerCampaignRequestinputleads, Expression<Func<Token[]>> triggerCampaignRequestinputtokens = null)
        {
            var apiCallPath = String.Format("/rest/v1/campaigns/{0}/trigger.json", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var triggerCampaignRequest = new JObject();
            var triggerCampaignRequestpropCount = 0;
            var inputObject = new JObject();
            var inputObjectpropCount = 0;
            inputObjectpropCount++;
            inputObject["leads"] = ExpressionConverter.ConvertO(triggerCampaignRequestinputleads);
            if (triggerCampaignRequestinputtokens != null)
            {
                inputObject["tokens"] = ExpressionConverter.ConvertO(triggerCampaignRequestinputtokens);
                inputObjectpropCount++;
            }

            if (inputObjectpropCount > 0)
            {
                triggerCampaignRequest["input"] = inputObject;
                triggerCampaignRequestpropCount++;
            }

            if (triggerCampaignRequestpropCount > 0)
            {
                callPayload.Body = triggerCampaignRequest;
            }

            return new ApiConnectionAction<ResponseOfCampaign>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLead> GetLeadByIdUsingGET(Expression<Func<int>> leadId, Expression<Func<string[]>> fields = null)
        {
            var apiCallPath = String.Format("/rest/v1/lead/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(leadId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            return new ApiConnectionAction<ResponseOfLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLead> GetLeadsByFilterUsingGET(Expression<Func<string>> filterType, Expression<Func<string[]>> filterValues, Expression<Func<string[]>> fields = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = "/rest/v1/leads.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filterType"] = ExpressionConverter.Convert(filterType);
            callPayload.Queries["filterValues"] = ExpressionConverter.Convert(filterValues);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLead> SyncLeadUsingPOST(Expression<Func<Lead[]>> syncLeadRequestinput, Expression<Func<syncLeadRequestactionInput>> syncLeadRequestaction = null, Expression<Func<bool>> syncLeadRequestasyncProcessing = null, Expression<Func<string>> syncLeadRequestlookupField = null, Expression<Func<string>> syncLeadRequestpartitionName = null)
        {
            var apiCallPath = "/rest/v1/leads.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var syncLeadRequest = new JObject();
            var syncLeadRequestpropCount = 0;
            if (syncLeadRequestaction != null)
            {
                syncLeadRequest["action"] = ExpressionConverter.ConvertO(syncLeadRequestaction);
                syncLeadRequestpropCount++;
            }

            if (syncLeadRequestasyncProcessing != null)
            {
                syncLeadRequest["asyncProcessing"] = ExpressionConverter.ConvertO(syncLeadRequestasyncProcessing);
                syncLeadRequestpropCount++;
            }

            syncLeadRequestpropCount++;
            syncLeadRequest["input"] = ExpressionConverter.ConvertO(syncLeadRequestinput);
            if (syncLeadRequestlookupField != null)
            {
                syncLeadRequest["lookupField"] = ExpressionConverter.ConvertO(syncLeadRequestlookupField);
                syncLeadRequestpropCount++;
            }

            if (syncLeadRequestpartitionName != null)
            {
                syncLeadRequest["partitionName"] = ExpressionConverter.ConvertO(syncLeadRequestpartitionName);
                syncLeadRequestpropCount++;
            }

            if (syncLeadRequestpropCount > 0)
            {
                callPayload.Body = syncLeadRequest;
            }

            return new ApiConnectionAction<ResponseOfLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLead> DeleteLeadsUsingPOST(Expression<Func<LeadInputData[]>> deleteLeadRequestinput, Expression<Func<int[]>> id = null)
        {
            var apiCallPath = "/rest/v1/leads/delete.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var deleteLeadRequest = new JObject();
            var deleteLeadRequestpropCount = 0;
            deleteLeadRequestpropCount++;
            deleteLeadRequest["input"] = ExpressionConverter.ConvertO(deleteLeadRequestinput);
            if (deleteLeadRequestpropCount > 0)
            {
                callPayload.Body = deleteLeadRequest;
            }

            return new ApiConnectionAction<ResponseOfLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLeadAttribute> DescribeUsingGET2()
        {
            var apiCallPath = "/rest/v1/leads/describe.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfLeadAttribute>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLeadAttribute2> DescribeUsingGET6()
        {
            var apiCallPath = "/rest/v1/leads/describe2.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfLeadAttribute2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLeadField> GetLeadFieldByNameUsingGET(Expression<Func<string>> fieldApiName)
        {
            var apiCallPath = String.Format("/rest/v1/leads/schema/fields/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(fieldApiName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfLeadField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfUpdateLeadField> UpdateLeadFieldUsingPOST(Expression<Func<string>> fieldApiName, Expression<Func<UpdateLeadField[]>> updateLeadFieldRequestinput)
        {
            var apiCallPath = String.Format("/rest/v1/leads/schema/fields/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(fieldApiName, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var updateLeadFieldRequest = new JObject();
            var updateLeadFieldRequestpropCount = 0;
            updateLeadFieldRequestpropCount++;
            updateLeadFieldRequest["input"] = ExpressionConverter.ConvertO(updateLeadFieldRequestinput);
            if (updateLeadFieldRequestpropCount > 0)
            {
                callPayload.Body = updateLeadFieldRequest;
            }

            return new ApiConnectionAction<ResponseOfUpdateLeadField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLeadField> GetProgramMemberFieldByNameUsingGET(Expression<Func<string>> fieldApiName)
        {
            var apiCallPath = String.Format("/rest/v1/programs/members/schema/fields/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(fieldApiName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfLeadField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramMemberStatus> SyncProgramMemberStatusUsingPOST(Expression<Func<int>> programId, Expression<Func<string>> syncProgramMemberStatusRequeststatusName, Expression<Func<ProgramMemberStatus[]>> syncProgramMemberStatusRequestinput)
        {
            var apiCallPath = String.Format("/rest/v1/programs/{0}/members/status.json", ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var syncProgramMemberStatusRequest = new JObject();
            var syncProgramMemberStatusRequestpropCount = 0;
            syncProgramMemberStatusRequestpropCount++;
            syncProgramMemberStatusRequest["statusName"] = ExpressionConverter.ConvertO(syncProgramMemberStatusRequeststatusName);
            syncProgramMemberStatusRequestpropCount++;
            syncProgramMemberStatusRequest["input"] = ExpressionConverter.ConvertO(syncProgramMemberStatusRequestinput);
            if (syncProgramMemberStatusRequestpropCount > 0)
            {
                callPayload.Body = syncProgramMemberStatusRequest;
            }

            return new ApiConnectionAction<ResponseOfProgramMemberStatus>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramMember> GetProgramMembersUsingGET(Expression<Func<int>> programId, Expression<Func<string>> filterType, Expression<Func<string[]>> filterValues, Expression<Func<string>> startAt = null, Expression<Func<string>> endAt = null, Expression<Func<string[]>> fields = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = String.Format("/rest/v1/programs/{0}/members.json", ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["filterType"] = ExpressionConverter.Convert(filterType);
            callPayload.Queries["filterValues"] = ExpressionConverter.Convert(filterValues);
            if (startAt != null)
                callPayload.Queries["startAt"] = ExpressionConverter.Convert(startAt);
            if (endAt != null)
                callPayload.Queries["endAt"] = ExpressionConverter.Convert(endAt);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfProgramMember>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramMemberData> SyncProgramMemberDataUsingPOST(Expression<Func<int>> programId, Expression<Func<ProgramMemberData[]>> syncProgramMemberDataRequestinput)
        {
            var apiCallPath = String.Format("/rest/v1/programs/{0}/members.json", ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var syncProgramMemberDataRequest = new JObject();
            var syncProgramMemberDataRequestpropCount = 0;
            syncProgramMemberDataRequestpropCount++;
            syncProgramMemberDataRequest["input"] = ExpressionConverter.ConvertO(syncProgramMemberDataRequestinput);
            if (syncProgramMemberDataRequestpropCount > 0)
            {
                callPayload.Body = syncProgramMemberDataRequest;
            }

            return new ApiConnectionAction<ResponseOfProgramMemberData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramMemberDelete> DeleteProgramMemberUsingPOST(Expression<Func<int>> programId, Expression<Func<ProgramMemberDelete[]>> deleteProgramMemberRequestinput)
        {
            var apiCallPath = String.Format("/rest/v1/programs/{0}/members/delete.json", ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var deleteProgramMemberRequest = new JObject();
            var deleteProgramMemberRequestpropCount = 0;
            deleteProgramMemberRequestpropCount++;
            deleteProgramMemberRequest["input"] = ExpressionConverter.ConvertO(deleteProgramMemberRequestinput);
            if (deleteProgramMemberRequestpropCount > 0)
            {
                callPayload.Body = deleteProgramMemberRequest;
            }

            return new ApiConnectionAction<ResponseOfProgramMemberDelete>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramMemberAttributes2> DescribeProgramMemberUsingGET2()
        {
            var apiCallPath = "/rest/v1/programs/members/describe.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfProgramMemberAttributes2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfProgramMemberAttributes> DescribeProgramMemberUsingGET()
        {
            var apiCallPath = "/rest/v1/program/members/describe.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfProgramMemberAttributes>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLead> GetLeadsByProgramIdUsingGET(Expression<Func<int>> programId, Expression<Func<string[]>> fields = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = String.Format("/rest/v1/leads/programs/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(programId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfPushLeadToMarketo> PushToMarketoUsingPOST(Expression<Func<PushLead[]>> pushLeadToMarketoRequestinput = null, Expression<Func<string>> pushLeadToMarketoRequestlookupField = null, Expression<Func<string>> pushLeadToMarketoRequestpartitionName = null, Expression<Func<string>> pushLeadToMarketoRequestprogramName = null, Expression<Func<string>> pushLeadToMarketoRequestprogramStatus = null, Expression<Func<string>> pushLeadToMarketoRequestreason = null, Expression<Func<string>> pushLeadToMarketoRequestsource = null)
        {
            var apiCallPath = "/rest/v1/leads/push.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var pushLeadToMarketoRequest = new JObject();
            var pushLeadToMarketoRequestpropCount = 0;
            if (pushLeadToMarketoRequestinput != null)
            {
                pushLeadToMarketoRequest["input"] = ExpressionConverter.ConvertO(pushLeadToMarketoRequestinput);
                pushLeadToMarketoRequestpropCount++;
            }

            if (pushLeadToMarketoRequestlookupField != null)
            {
                pushLeadToMarketoRequest["lookupField"] = ExpressionConverter.ConvertO(pushLeadToMarketoRequestlookupField);
                pushLeadToMarketoRequestpropCount++;
            }

            if (pushLeadToMarketoRequestpartitionName != null)
            {
                pushLeadToMarketoRequest["partitionName"] = ExpressionConverter.ConvertO(pushLeadToMarketoRequestpartitionName);
                pushLeadToMarketoRequestpropCount++;
            }

            if (pushLeadToMarketoRequestprogramName != null)
            {
                pushLeadToMarketoRequest["programName"] = ExpressionConverter.ConvertO(pushLeadToMarketoRequestprogramName);
                pushLeadToMarketoRequestpropCount++;
            }

            if (pushLeadToMarketoRequestprogramStatus != null)
            {
                pushLeadToMarketoRequest["programStatus"] = ExpressionConverter.ConvertO(pushLeadToMarketoRequestprogramStatus);
                pushLeadToMarketoRequestpropCount++;
            }

            if (pushLeadToMarketoRequestreason != null)
            {
                pushLeadToMarketoRequest["reason"] = ExpressionConverter.ConvertO(pushLeadToMarketoRequestreason);
                pushLeadToMarketoRequestpropCount++;
            }

            if (pushLeadToMarketoRequestsource != null)
            {
                pushLeadToMarketoRequest["source"] = ExpressionConverter.ConvertO(pushLeadToMarketoRequestsource);
                pushLeadToMarketoRequestpropCount++;
            }

            if (pushLeadToMarketoRequestpropCount > 0)
            {
                callPayload.Body = pushLeadToMarketoRequest;
            }

            return new ApiConnectionAction<ResponseOfPushLeadToMarketo>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLeadByListId> GetLeadsByListIdUsingGET(Expression<Func<int>> listId, Expression<Func<string[]>> fields = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = String.Format("/rest/v1/list/{0}/leads.json", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfLeadByListId>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfStaticList> GetListsUsingGET(Expression<Func<int[]>> id = null, Expression<Func<string[]>> name = null, Expression<Func<string[]>> programName = null, Expression<Func<string[]>> workspaceName = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = "/rest/v1/lists.json";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (programName != null)
                callPayload.Queries["programName"] = ExpressionConverter.Convert(programName);
            if (workspaceName != null)
                callPayload.Queries["workspaceName"] = ExpressionConverter.Convert(workspaceName);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfStaticList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfStaticList> GetListByIdUsingGET(Expression<Func<int>> listId)
        {
            var apiCallPath = String.Format("/rest/v1/lists/{0}.json", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseOfStaticList>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfLead> GetLeadsByListIdUsingGET1(Expression<Func<int>> listId, Expression<Func<string[]>> fields = null, Expression<Func<int>> batchSize = null, Expression<Func<string>> nextPageToken = null)
        {
            var apiCallPath = String.Format("/rest/v1/lists/{0}/leads.json", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = ExpressionConverter.Convert(fields);
            if (batchSize != null)
                callPayload.Queries["batchSize"] = ExpressionConverter.Convert(batchSize);
            if (nextPageToken != null)
                callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(nextPageToken);
            return new ApiConnectionAction<ResponseOfLead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfListOperationOutputData> AddLeadsToListUsingPOST(Expression<Func<int>> listId, Expression<Func<LeadInputData[]>> listOperationRequestinput, Expression<Func<int[]>> id = null)
        {
            var apiCallPath = String.Format("/rest/v1/lists/{0}/leads.json", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var listOperationRequest = new JObject();
            var listOperationRequestpropCount = 0;
            listOperationRequestpropCount++;
            listOperationRequest["input"] = ExpressionConverter.ConvertO(listOperationRequestinput);
            if (listOperationRequestpropCount > 0)
            {
                callPayload.Body = listOperationRequest;
            }

            return new ApiConnectionAction<ResponseOfListOperationOutputData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfListOperationOutputData> RemoveLeadsFromListUsingDELETE(Expression<Func<int>> listId, Expression<Func<LeadInputData[]>> listOperationRequestinput, Expression<Func<int[]>> id)
        {
            var apiCallPath = String.Format("/rest/v1/lists/{0}/leads.json", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var listOperationRequest = new JObject();
            var listOperationRequestpropCount = 0;
            listOperationRequestpropCount++;
            listOperationRequest["input"] = ExpressionConverter.ConvertO(listOperationRequestinput);
            if (listOperationRequestpropCount > 0)
            {
                callPayload.Body = listOperationRequest;
            }

            return new ApiConnectionAction<ResponseOfListOperationOutputData>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "marketoma")]
        public IBodyWorkflowAction<ResponseOfListOperationOutputData> AreLeadsMemberOfListUsingGET(Expression<Func<int>> listId, Expression<Func<LeadInputData[]>> listOperationRequestinput, Expression<Func<int[]>> id = null)
        {
            var apiCallPath = String.Format("/rest/v1/lists/{0}/leads/ismember.json", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (id != null)
                callPayload.Queries["id"] = ExpressionConverter.Convert(id);
            var listOperationRequest = new JObject();
            var listOperationRequestpropCount = 0;
            listOperationRequestpropCount++;
            listOperationRequest["input"] = ExpressionConverter.ConvertO(listOperationRequestinput);
            if (listOperationRequestpropCount > 0)
            {
                callPayload.Body = listOperationRequest;
            }

            return new ApiConnectionAction<ResponseOfListOperationOutputData>(callPayload);
        }
    }

    public class MarketomaTriggers([ConnectionName] string connectionId)
    {
    }

    public class ResponseOfIdentity
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("token_type")]
        public ResponseOfIdentityTokenTypeType TokenType { get; set; }
    }

    public enum ResponseOfIdentityTokenTypeType
    {
        [EnumMember(Value = "bearer")]
        Bearer
    }

    public enum grantTypeInput
    {
        [EnumMember(Value = "client_credentials")]
        ClientCredentials
    }

    public class ResponseOfFileResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public FileResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class Error
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class FileResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("folder")]
        public FileFolder Folder { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FileFolder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public enum getFilesRequestfoldertypeInput
    {
        Folder,
        Program
    }

    public enum createFileRequestfoldertypeInput
    {
        Folder,
        Program
    }

    public class ResponseOfFolderResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public FolderResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class FolderResponse
    {
        [JsonProperty("accessZoneId")]
        public int AccessZoneId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("folderId")]
        public Folder FolderId { get; set; }

        [JsonProperty("folderType")]
        public FolderResponseFolderTypeType FolderType { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("isArchive")]
        public bool IsArchive { get; set; }

        [JsonProperty("isSystem")]
        public bool IsSystem { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent")]
        public Folder Parent { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }
    }

    public class Folder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public FolderTypeType Type { get; set; }
    }

    public enum FolderTypeType
    {
        Folder,
        Program
    }

    public enum FolderResponseFolderTypeType
    {
        Email,
        [EnumMember(Value = "Email Batch Program")]
        EmailBatchProgram,
        [EnumMember(Value = "Email Template")]
        EmailTemplate,
        Image,
        [EnumMember(Value = "Landing Page")]
        LandingPage,
        [EnumMember(Value = "Landing Page Form")]
        LandingPageForm,
        [EnumMember(Value = "Landing Page Template")]
        LandingPageTemplate,
        [EnumMember(Value = "Marketing Event")]
        MarketingEvent,
        [EnumMember(Value = "Marketing Folder")]
        MarketingFolder,
        [EnumMember(Value = "Marketing Program")]
        MarketingProgram,
        [EnumMember(Value = "Nurture Program")]
        NurtureProgram,
        Report,
        [EnumMember(Value = "Revenue Cycle Model")]
        RevenueCycleModel,
        Zone
    }

    public enum typeInput
    {
        Program,
        Folder
    }

    public enum updateFolderRequesttypeInput
    {
        Folder,
        Program
    }

    public class ResponseOfFolderContentResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public FolderContentResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class FolderContentResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ResponseOfIdResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public IdResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class IdResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public enum createFolderRequestparenttypeInput
    {
        Folder,
        Program
    }

    public class ResponseOfProgramResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ProgramResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class ProgramResponse
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("costs")]
        public Costs[] Costs { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("folder")]
        public ProgramFolder Folder { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sfdcId")]
        public string SfdcId { get; set; }

        [JsonProperty("sfdcName")]
        public string SfdcName { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("status")]
        public ProgramResponseStatusType Status { get; set; }

        [JsonProperty("tags")]
        public Tags[] Tags { get; set; }

        [JsonProperty("type")]
        public ProgramResponseTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }

        [JsonProperty("marketingProgramProgressionId")]
        public int MarketingProgramProgressionId { get; set; }

        [JsonProperty("headStart")]
        public bool HeadStart { get; set; }
    }

    public class Costs
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class ProgramFolder
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("folderName")]
        public string FolderName { get; set; }
    }

    public enum ProgramResponseStatusType
    {
        [EnumMember(Value = "locked")]
        Locked,
        [EnumMember(Value = "unlocked")]
        Unlocked,
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    public class Tags
    {
        [JsonProperty("tagType")]
        public string TagType { get; set; }

        [JsonProperty("tagValue")]
        public string TagValue { get; set; }
    }

    public enum ProgramResponseTypeType
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "event")]
        Event,
        [EnumMember(Value = "webinar")]
        Webinar,
        [EnumMember(Value = "nurture")]
        Nurture
    }

    public class CostRequest
    {
        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class TagRequest
    {
        [JsonProperty("tagType")]
        public string TagType { get; set; }

        [JsonProperty("tagValue")]
        public string TagValue { get; set; }
    }

    public class ResponseOfSmartListResponseWithRules
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public SmartListResponseWithRules[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class SmartListResponseWithRules
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("folder")]
        public Folder Folder { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }

        [JsonProperty("rules")]
        public SmartListRules Rules { get; set; }
    }

    public class SmartListRules
    {
        [JsonProperty("filterMatchType")]
        public SmartListRulesFilterMatchTypeType FilterMatchType { get; set; }

        [JsonProperty("triggers")]
        public string[] Triggers { get; set; }

        [JsonProperty("filters")]
        public SmartListFilters[] Filters { get; set; }
    }

    public enum SmartListRulesFilterMatchTypeType
    {
        All,
        Any,
        Advanced
    }

    public class SmartListFilters
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ruleTypeId")]
        public int RuleTypeId { get; set; }

        [JsonProperty("ruleType")]
        public string RuleType { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("conditions")]
        public SmartListConditions[] Conditions { get; set; }
    }

    public class SmartListConditions
    {
        [JsonProperty("activityAttributeId")]
        public int ActivityAttributeId { get; set; }

        [JsonProperty("activityAttributeName")]
        public string ActivityAttributeName { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }
    }

    public enum cloneProgramRequestfoldertypeInput
    {
        Folder,
        Program
    }

    public class ResponseOfBrowseAllPrograms
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public BrowseAllPrograms[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class BrowseAllPrograms
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("folder")]
        public Folder Folder { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sfdcId")]
        public string SfdcId { get; set; }

        [JsonProperty("sfdcName")]
        public string SfdcName { get; set; }

        [JsonProperty("status")]
        public BrowseAllProgramsStatusType Status { get; set; }

        [JsonProperty("type")]
        public BrowseAllProgramsTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }
    }

    public enum BrowseAllProgramsStatusType
    {
        [EnumMember(Value = "locked")]
        Locked,
        [EnumMember(Value = "unlocked")]
        Unlocked,
        [EnumMember(Value = "on")]
        On,
        [EnumMember(Value = "off")]
        Off
    }

    public enum BrowseAllProgramsTypeType
    {
        [EnumMember(Value = "program")]
        Program,
        [EnumMember(Value = "event")]
        Event,
        [EnumMember(Value = "webinar")]
        Webinar,
        [EnumMember(Value = "nurture")]
        Nurture
    }

    public enum filterTypeInput
    {
        [EnumMember(Value = "id")]
        Id,
        [EnumMember(Value = "programId")]
        ProgramId,
        [EnumMember(Value = "folderId")]
        FolderId,
        [EnumMember(Value = "workspace")]
        Workspace
    }

    public enum createProgramRequestfoldertypeInput
    {
        Folder,
        Program
    }

    public class ResponseOfSmartListResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public SmartListResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class SmartListResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("folder")]
        public Folder Folder { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }
    }

    public enum cloneSmartListRequestfoldertypeInput
    {
        Folder,
        Program
    }

    public class ResponseOfStaticListResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public StaticListResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public string[] Warnings { get; set; }
    }

    public class StaticListResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("folder")]
        public Folder Folder { get; set; }

        [JsonProperty("workspace")]
        public string Workspace { get; set; }

        [JsonProperty("computedUrl")]
        public string ComputedUrl { get; set; }
    }

    public enum createStaticListRequestfoldertypeInput
    {
        Folder,
        Program
    }

    public class ResponseOfImportLeadResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ImportLeadResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ImportLeadResponse
    {
        [JsonProperty("batchId")]
        public int BatchId { get; set; }

        [JsonProperty("importId")]
        public string ImportId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("numOfLeadsProcessed")]
        public int NumOfLeadsProcessed { get; set; }

        [JsonProperty("numOfRowsFailed")]
        public int NumOfRowsFailed { get; set; }

        [JsonProperty("numOfRowsWithWarning")]
        public int NumOfRowsWithWarning { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Warning
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public enum formatInput
    {
        CSV,
        TSV,
        SSV
    }

    public class ResponseOfExportResponseWithToken
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ExportResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ExportResponse
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("errorMsg")]
        public string ErrorMsg { get; set; }

        [JsonProperty("exportId")]
        public string ExportId { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("fileChecksum")]
        public string FileChecksum { get; set; }

        [JsonProperty("finishedAt")]
        public string FinishedAt { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("numberOfRecords")]
        public int NumberOfRecords { get; set; }

        [JsonProperty("queuedAt")]
        public string QueuedAt { get; set; }

        [JsonProperty("startedAt")]
        public string StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResponseOfExportResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ExportResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ResponseOfImportProgramMemberResponse
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ImportProgramMemberResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ImportProgramMemberResponse
    {
        [JsonProperty("batchId")]
        public int BatchId { get; set; }

        [JsonProperty("importId")]
        public string ImportId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public enum exportProgramMemberRequestfilternurtureCadenceInput
    {
        [EnumMember(Value = "paus")]
        Paus,
        [EnumMember(Value = "norm")]
        Norm
    }

    public class ResponseOfCampaign
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public Campaign[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class Campaign
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("programId")]
        public int ProgramId { get; set; }

        [JsonProperty("programName")]
        public string ProgramName { get; set; }

        [JsonProperty("type")]
        public CampaignTypeType Type { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("workspaceName")]
        public string WorkspaceName { get; set; }
    }

    public enum CampaignTypeType
    {
        [EnumMember(Value = "batch")]
        Batch,
        [EnumMember(Value = "trigger")]
        Trigger
    }

    public class Token
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class InputLead
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ResponseOfLead
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public Lead[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class Lead
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("membership")]
        public ProgramMembership Membership { get; set; }

        [JsonProperty("reason")]
        public Reason Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ProgramMembership
    {
        [JsonProperty("acquiredBy")]
        public bool AcquiredBy { get; set; }

        [JsonProperty("isExhausted")]
        public bool IsExhausted { get; set; }

        [JsonProperty("membershipDate")]
        public string MembershipDate { get; set; }

        [JsonProperty("nurtureCadence")]
        public string NurtureCadence { get; set; }

        [JsonProperty("progressionStatus")]
        public string ProgressionStatus { get; set; }

        [JsonProperty("reachedSuccess")]
        public bool ReachedSuccess { get; set; }

        [JsonProperty("stream")]
        public string Stream { get; set; }
    }

    public class Reason
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public enum syncLeadRequestactionInput
    {
        [EnumMember(Value = "createOnly")]
        CreateOnly,
        [EnumMember(Value = "updateOnly")]
        UpdateOnly,
        [EnumMember(Value = "createOrUpdate")]
        CreateOrUpdate,
        [EnumMember(Value = "createDuplicate")]
        CreateDuplicate
    }

    public class LeadInputData
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }

    public class ResponseOfLeadAttribute
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public LeadAttribute[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class LeadAttribute
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("rest")]
        public LeadMapAttribute Rest { get; set; }

        [JsonProperty("soap")]
        public LeadMapAttribute Soap { get; set; }
    }

    public class LeadMapAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
    }

    public class ResponseOfLeadAttribute2
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public LeadAttribute2[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class LeadAttribute2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("searchableFields")]
        public string[][] SearchableFields { get; set; }

        [JsonProperty("fields")]
        public LeadAttribute2Fields[] Fields { get; set; }
    }

    public class LeadAttribute2Fields
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("updateable")]
        public bool Updateable { get; set; }

        [JsonProperty("crmManaged")]
        public bool CrmManaged { get; set; }
    }

    public class ResponseOfLeadField
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public LeadField[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class LeadField
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("isHtmlEncodingInEmail")]
        public bool IsHtmlEncodingInEmail { get; set; }

        [JsonProperty("isSensitive")]
        public bool IsSensitive { get; set; }

        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }

        [JsonProperty("isApiCreated")]
        public bool IsApiCreated { get; set; }
    }

    public class ResponseOfUpdateLeadField
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public LeadFieldStatus[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class LeadFieldStatus
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public LeadFieldStatusStatusType Status { get; set; }
    }

    public enum LeadFieldStatusStatusType
    {
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "updated")]
        Updated
    }

    public class UpdateLeadField
    {
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("isHtmlEncodingInEmail")]
        public bool IsHtmlEncodingInEmail { get; set; }

        [JsonProperty("isSensitive")]
        public bool IsSensitive { get; set; }
    }

    public class ResponseOfProgramMemberStatus
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ProgramMemberStatusResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ProgramMemberStatusResponse
    {
        [JsonProperty("status")]
        public ProgramMemberStatusResponseStatusType Status { get; set; }

        [JsonProperty("reasons")]
        public Reason[] Reasons { get; set; }

        [JsonProperty("leadId")]
        public int LeadId { get; set; }

        [JsonProperty("seq")]
        public int Seq { get; set; }
    }

    public enum ProgramMemberStatusResponseStatusType
    {
        [EnumMember(Value = "updated")]
        Updated,
        [EnumMember(Value = "skipped")]
        Skipped
    }

    public class ProgramMemberStatus
    {
        [JsonProperty("leadId")]
        public int LeadId { get; set; }
    }

    public class ResponseOfProgramMember
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ProgramMember[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ProgramMember
    {
        [JsonProperty("seq")]
        public int Seq { get; set; }

        [JsonProperty("leadId")]
        public int LeadId { get; set; }

        [JsonProperty("reachedSuccess")]
        public bool ReachedSuccess { get; set; }

        [JsonProperty("programId")]
        public int ProgramId { get; set; }

        [JsonProperty("acquiredBy")]
        public bool AcquiredBy { get; set; }

        [JsonProperty("membershipDate")]
        public string MembershipDate { get; set; }
    }

    public class ResponseOfProgramMemberData
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ProgramMemberStatusResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ProgramMemberData
    {
        [JsonProperty("leadId")]
        public int LeadId { get; set; }

        [JsonProperty("{fieldApiName}")]
        public string FieldApiName { get; set; }

        [JsonProperty("{fieldApiName2}")]
        public string FieldApiName2 { get; set; }
    }

    public class ResponseOfProgramMemberDelete
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ProgramMemberDeleteResponse[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ProgramMemberDeleteResponse
    {
        [JsonProperty("status")]
        public ProgramMemberDeleteResponseStatusType Status { get; set; }

        [JsonProperty("reasons")]
        public Reason[] Reasons { get; set; }

        [JsonProperty("leadId")]
        public int LeadId { get; set; }

        [JsonProperty("seq")]
        public int Seq { get; set; }
    }

    public enum ProgramMemberDeleteResponseStatusType
    {
        [EnumMember(Value = "deleted")]
        Deleted,
        [EnumMember(Value = "skipped")]
        Skipped
    }

    public class ProgramMemberDelete
    {
        [JsonProperty("leadId")]
        public int LeadId { get; set; }
    }

    public class ResponseOfProgramMemberAttributes2
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ProgramMemberAttribute2[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ProgramMemberAttribute2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("dedupeFields")]
        public string[] DedupeFields { get; set; }

        [JsonProperty("searchableFields")]
        public string[][] SearchableFields { get; set; }

        [JsonProperty("fields")]
        public LeadAttribute2Fields2[] Fields { get; set; }
    }

    public class LeadAttribute2Fields2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("updateable")]
        public bool Updateable { get; set; }

        [JsonProperty("crmManaged")]
        public bool CrmManaged { get; set; }
    }

    public class ResponseOfProgramMemberAttributes
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ProgramMemberAttribute[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ProgramMemberAttribute
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fields")]
        public LeadAttribute2Fields[] Fields { get; set; }
    }

    public class ResponseOfPushLeadToMarketo
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public Lead[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class PushLead
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("reason")]
        public Reason Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ResponseOfLeadByListId
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public Lead[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ResponseOfStaticList
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public StaticList[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class StaticList
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("programName")]
        public string ProgramName { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("workspaceName")]
        public string WorkspaceName { get; set; }
    }

    public class ResponseOfListOperationOutputData
    {
        [JsonProperty("errors")]
        public Error[] Errors { get; set; }

        [JsonProperty("moreResult")]
        public bool MoreResult { get; set; }

        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("result")]
        public ListOperationOutputData[] Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("warnings")]
        public Warning[] Warnings { get; set; }
    }

    public class ListOperationOutputData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("reasons")]
        public Reason[] Reasons { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Marketoma;

    public partial class WorkflowManagedActions
    {
        public MarketomaActions Marketoma(string connectionId) => new MarketomaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MarketomaTriggers Marketoma(string connectionId) => new MarketomaTriggers(connectionId);
    }
}