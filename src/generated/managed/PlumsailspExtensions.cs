//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailsp
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailspActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsCreateSiteFromTemplatePost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requesttitle, Expression<Func<string>> requesttemplate, Expression<Func<string>> requestleafURL, Expression<Func<string>> requestdescription = null, Expression<Func<int>> requestlcid = null, Expression<Func<bool>> requestinheritPermissions = null, Expression<Func<bool>> requestinheritNavigation = null, Expression<Func<bool>> requestonTopNavigation = null, Expression<Func<bool>> requestonQuickLaunch = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateSiteFromTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requesttitle);
            requestpropCount++;
            request["template"] = ExpressionConverter.ConvertO(requesttemplate);
            requestpropCount++;
            request["leafUrl"] = ExpressionConverter.ConvertO(requestleafURL);
            if (requestdescription != null)
            {
                request["description"] = ExpressionConverter.ConvertO(requestdescription);
                requestpropCount++;
            }

            if (requestlcid != null)
            {
                request["lcid"] = ExpressionConverter.ConvertO(requestlcid);
                requestpropCount++;
            }

            if (requestinheritPermissions != null)
            {
                request["inheritPermissions"] = ExpressionConverter.ConvertO(requestinheritPermissions);
                requestpropCount++;
            }

            if (requestinheritNavigation != null)
            {
                request["inheritNavigation"] = ExpressionConverter.ConvertO(requestinheritNavigation);
                requestpropCount++;
            }

            if (requestonTopNavigation != null)
            {
                request["onTopNav"] = ExpressionConverter.ConvertO(requestonTopNavigation);
                requestpropCount++;
            }

            if (requestonQuickLaunch != null)
            {
                request["onQuickLaunch"] = ExpressionConverter.ConvertO(requestonQuickLaunch);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<WebUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsChangePermissionsPost(Expression<Func<actionTypeInput>> actionType, Expression<Func<targetInput>> target, Expression<Func<object>> request = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/ChangePermissions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
            callPayload.Queries["target"] = ExpressionConverter.Convert(target);
            callPayload.Body = ExpressionConverter.ConvertO(request);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsActivateFeaturePost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestfeatureID, Expression<Func<bool>> requestforce = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/ActivateFeature";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["featureId"] = ExpressionConverter.ConvertO(requestfeatureID);
            if (requestforce != null)
            {
                request["force"] = ExpressionConverter.ConvertO(requestforce);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsDeactivateFeaturePost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestfeatureID, Expression<Func<bool>> requestforce = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeactivateFeature";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["featureId"] = ExpressionConverter.ConvertO(requestfeatureID);
            if (requestforce != null)
            {
                request["force"] = ExpressionConverter.ConvertO(requestforce);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsCreateListOrLibraryPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requesttitle, Expression<Func<string>> requesttemplate, Expression<Func<string>> requestpartialURL = null, Expression<Func<string>> requestdescription = null, Expression<Func<bool>> requestonQuickLaunch = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateListOrLibrary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requesttitle);
            requestpropCount++;
            request["template"] = ExpressionConverter.ConvertO(requesttemplate);
            if (requestpartialURL != null)
            {
                request["partialUrl"] = ExpressionConverter.ConvertO(requestpartialURL);
                requestpropCount++;
            }

            if (requestdescription != null)
            {
                request["description"] = ExpressionConverter.ConvertO(requestdescription);
                requestpropCount++;
            }

            if (requestonQuickLaunch != null)
            {
                request["onQuickLaunch"] = ExpressionConverter.ConvertO(requestonQuickLaunch);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsSetDefaultSiteGroupPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<requestgroupTypeInput>> requestgroupType, Expression<Func<string>> requestgroupName)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/SetDefaultSiteGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupType"] = ExpressionConverter.ConvertO(requestgroupType);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCopyDocumentFromLibraryPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestsourceURL, Expression<Func<string>> requestdestinationURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyDocumentFromLibrary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestsourceURL);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsMoveDocumentFromLibraryPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestsourceURL, Expression<Func<string>> requestdestinationURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveDocumentFromLibrary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestsourceURL);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveDocumentByUrlPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestdocumentURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveDocumentByUrl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestdocumentURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsCreateDocumentSetPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestdocumentSetName, Expression<Func<string>> requesttargetList, Expression<Func<string>> requestcontentType = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateDocumentSet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["documentSetName"] = ExpressionConverter.ConvertO(requestdocumentSetName);
            requestpropCount++;
            request["targetListUrl"] = ExpressionConverter.ConvertO(requesttargetList);
            if (requestcontentType != null)
            {
                request["contentType"] = ExpressionConverter.ConvertO(requestcontentType);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentSetInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsCopyDocumentSetPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestsourceURL, Expression<Func<string>> requestdestinationURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyDocumentSet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestsourceURL);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentSetInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsMoveDocumentSetPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestsourceURL, Expression<Func<string>> requestdestinationURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveDocumentSet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestsourceURL);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentSetInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCreateFolderByUrlPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestfolderURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateFolderByUrl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["folderUrl"] = ExpressionConverter.ConvertO(requestfolderURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<FolderInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCreateFolderInListPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requesttargetList, Expression<Func<string>> requestfolderPath)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateFolderInList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["targetListUrl"] = ExpressionConverter.ConvertO(requesttargetList);
            requestpropCount++;
            request["folderPath"] = ExpressionConverter.ConvertO(requestfolderPath);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<FolderInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveFolderByUrlPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestfolderURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveFolderByUrl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestfolderURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCopyFolderFromLibraryPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestsourceURL, Expression<Func<string>> requestdestinationURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyFolderFromLibrary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestsourceURL);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<FolderInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsMoveFolderFromLibraryPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestsourceURL, Expression<Func<string>> requestdestinationURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveFolderFromLibrary";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["sourceUrl"] = ExpressionConverter.ConvertO(requestsourceURL);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<FolderInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCheckInDocumentPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestdocumentURL, Expression<Func<string>> requestcomment = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckInDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["documentUrl"] = ExpressionConverter.ConvertO(requestdocumentURL);
            if (requestcomment != null)
            {
                request["comment"] = ExpressionConverter.ConvertO(requestcomment);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCheckOutDocumentPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestdocumentURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckOutDocument";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["documentUrl"] = ExpressionConverter.ConvertO(requestdocumentURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsCreateModernSitePost(Expression<Func<siteTypeInput>> siteType, Expression<Func<object>> request = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateModernSite";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["siteType"] = ExpressionConverter.Convert(siteType);
            callPayload.Body = ExpressionConverter.ConvertO(request);
            return new ApiConnectionAction<WebUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsApplySiteDesignPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestsiteDesign)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/ApplySiteDesign";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["url"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["siteDesign"] = ExpressionConverter.ConvertO(requestsiteDesign);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<WebUrlResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsCreateSharePointGroupPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestgroupDescription = null, Expression<Func<string>> requestgroupOwner = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateSharePointGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            if (requestgroupDescription != null)
            {
                request["groupDescription"] = ExpressionConverter.ConvertO(requestgroupDescription);
                requestpropCount++;
            }

            if (requestgroupOwner != null)
            {
                request["userLogin"] = ExpressionConverter.ConvertO(requestgroupOwner);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveSharePointGroupPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveSharePointGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateSharePointGroupPropertiesPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestpropertiestitle = null, Expression<Func<string>> requestpropertiesdescription = null, Expression<Func<string>> requestpropertiesowner = null, Expression<Func<bool>> requestpropertiesallowMembersEditMembership = null, Expression<Func<bool>> requestpropertiesallowRequestToJoinLeave = null, Expression<Func<bool>> requestpropertiesautoAcceptRequestToJoinLeave = null, Expression<Func<bool>> requestpropertiesonlyAllowMembersViewMembership = null, Expression<Func<string>> requestpropertiesrequestToJoinLeaveEmailSetting = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateSharePointGroupProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (requestpropertiestitle != null)
            {
                propertiesObject["title"] = ExpressionConverter.ConvertO(requestpropertiestitle);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesdescription != null)
            {
                propertiesObject["description"] = ExpressionConverter.ConvertO(requestpropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesowner != null)
            {
                propertiesObject["owner"] = ExpressionConverter.ConvertO(requestpropertiesowner);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesallowMembersEditMembership != null)
            {
                propertiesObject["allowMembersEditMembership"] = ExpressionConverter.ConvertO(requestpropertiesallowMembersEditMembership);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesallowRequestToJoinLeave != null)
            {
                propertiesObject["allowRequestToJoinLeave"] = ExpressionConverter.ConvertO(requestpropertiesallowRequestToJoinLeave);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesautoAcceptRequestToJoinLeave != null)
            {
                propertiesObject["autoAcceptRequestToJoinLeave"] = ExpressionConverter.ConvertO(requestpropertiesautoAcceptRequestToJoinLeave);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesonlyAllowMembersViewMembership != null)
            {
                propertiesObject["onlyAllowMembersViewMembership"] = ExpressionConverter.ConvertO(requestpropertiesonlyAllowMembersViewMembership);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesrequestToJoinLeaveEmailSetting != null)
            {
                propertiesObject["requestToJoinLeaveEmailSetting"] = ExpressionConverter.ConvertO(requestpropertiesrequestToJoinLeaveEmailSetting);
                propertiesObjectpropCount++;
            }

            if (propertiesObjectpropCount > 0)
            {
                request["properties"] = propertiesObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<GroupExistResponse> FlowV1SharePointFlowJobsCheckSharePointGroupExistsPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckSharePointGroupExists";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<GroupExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsAddUserToSharePointGroupPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestuser, Expression<Func<bool>> requestsendEmail = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddUserToSharePointGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            requestpropCount++;
            request["userLogin"] = ExpressionConverter.ConvertO(requestuser);
            if (requestsendEmail != null)
            {
                request["sendEmail"] = ExpressionConverter.ConvertO(requestsendEmail);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveUserFromSharePointGroupPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestuser)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveUserFromSharePointGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            requestpropCount++;
            request["userLogin"] = ExpressionConverter.ConvertO(requestuser);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<GetSPGroupMembersResponse> FlowV1SharePointFlowJobsGetSharePointGroupMembersPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetSharePointGroupMembers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<GetSPGroupMembersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<UserExistsResponse> FlowV1SharePointFlowJobsUserExistInSharePointGroupPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestgroupName, Expression<Func<string>> requestuser)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/UserExistInSharePointGroup";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["groupName"] = ExpressionConverter.ConvertO(requestgroupName);
            requestpropCount++;
            request["userLogin"] = ExpressionConverter.ConvertO(requestuser);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<UserExistsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateSharePointSitePropertiesPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestpropertiestitle = null, Expression<Func<string>> requestpropertiesdescription = null, Expression<Func<bool>> requestpropertiesquickLaunchEnabled = null, Expression<Func<bool>> requestpropertiestreeViewEnabled = null, Expression<Func<string>> requestpropertiessiteLogoURL = null, Expression<Func<string>> requestpropertiesalternateCssURL = null, Expression<Func<string>> requestpropertiesassociatedMemberGroup = null, Expression<Func<string>> requestpropertiesassociatedOwnerGroup = null, Expression<Func<string>> requestpropertiesassociatedVisitorGroup = null, Expression<Func<bool>> requestpropertiescontainsConfidentialInfo = null, Expression<Func<string>> requestpropertiescustomMasterURL = null, Expression<Func<bool>> requestpropertiesenableMinimalDownload = null, Expression<Func<bool>> requestpropertiesisMultilingual = null, Expression<Func<string>> requestpropertiesmasterURL = null, Expression<Func<bool>> requestpropertiesmembersCanShare = null, Expression<Func<bool>> requestpropertiesnoCrawl = null, Expression<Func<bool>> requestpropertiesoverwriteTranslationsOnChange = null, Expression<Func<string>> requestpropertiesrequestAccessEmail = null, Expression<Func<bool>> requestpropertiessaveSiteAsTemplateEnabled = null, Expression<Func<string>> requestpropertiesserverRelativeURL = null, Expression<Func<bool>> requestpropertiessyndicationEnabled = null, Expression<Func<int>> requestpropertiesuIVersion = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateSharePointSiteProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            var propertiesObject = new JObject();
            var propertiesObjectpropCount = 0;
            if (requestpropertiestitle != null)
            {
                propertiesObject["title"] = ExpressionConverter.ConvertO(requestpropertiestitle);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesdescription != null)
            {
                propertiesObject["description"] = ExpressionConverter.ConvertO(requestpropertiesdescription);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesquickLaunchEnabled != null)
            {
                propertiesObject["quickLaunchEnabled"] = ExpressionConverter.ConvertO(requestpropertiesquickLaunchEnabled);
                propertiesObjectpropCount++;
            }

            if (requestpropertiestreeViewEnabled != null)
            {
                propertiesObject["treeViewEnabled"] = ExpressionConverter.ConvertO(requestpropertiestreeViewEnabled);
                propertiesObjectpropCount++;
            }

            if (requestpropertiessiteLogoURL != null)
            {
                propertiesObject["siteLogoUrl"] = ExpressionConverter.ConvertO(requestpropertiessiteLogoURL);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesalternateCssURL != null)
            {
                propertiesObject["alternateCssUrl"] = ExpressionConverter.ConvertO(requestpropertiesalternateCssURL);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesassociatedMemberGroup != null)
            {
                propertiesObject["associatedMemberGroup"] = ExpressionConverter.ConvertO(requestpropertiesassociatedMemberGroup);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesassociatedOwnerGroup != null)
            {
                propertiesObject["associatedOwnerGroup"] = ExpressionConverter.ConvertO(requestpropertiesassociatedOwnerGroup);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesassociatedVisitorGroup != null)
            {
                propertiesObject["associatedVisitorGroup"] = ExpressionConverter.ConvertO(requestpropertiesassociatedVisitorGroup);
                propertiesObjectpropCount++;
            }

            if (requestpropertiescontainsConfidentialInfo != null)
            {
                propertiesObject["containsConfidentialInfo"] = ExpressionConverter.ConvertO(requestpropertiescontainsConfidentialInfo);
                propertiesObjectpropCount++;
            }

            if (requestpropertiescustomMasterURL != null)
            {
                propertiesObject["customMasterUrl"] = ExpressionConverter.ConvertO(requestpropertiescustomMasterURL);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesenableMinimalDownload != null)
            {
                propertiesObject["enableMinimalDownload"] = ExpressionConverter.ConvertO(requestpropertiesenableMinimalDownload);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesisMultilingual != null)
            {
                propertiesObject["isMultilingual"] = ExpressionConverter.ConvertO(requestpropertiesisMultilingual);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesmasterURL != null)
            {
                propertiesObject["masterUrl"] = ExpressionConverter.ConvertO(requestpropertiesmasterURL);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesmembersCanShare != null)
            {
                propertiesObject["membersCanShare"] = ExpressionConverter.ConvertO(requestpropertiesmembersCanShare);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesnoCrawl != null)
            {
                propertiesObject["noCrawl"] = ExpressionConverter.ConvertO(requestpropertiesnoCrawl);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesoverwriteTranslationsOnChange != null)
            {
                propertiesObject["overwriteTranslationsOnChange"] = ExpressionConverter.ConvertO(requestpropertiesoverwriteTranslationsOnChange);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesrequestAccessEmail != null)
            {
                propertiesObject["requestAccessEmail"] = ExpressionConverter.ConvertO(requestpropertiesrequestAccessEmail);
                propertiesObjectpropCount++;
            }

            if (requestpropertiessaveSiteAsTemplateEnabled != null)
            {
                propertiesObject["saveSiteAsTemplateEnabled"] = ExpressionConverter.ConvertO(requestpropertiessaveSiteAsTemplateEnabled);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesserverRelativeURL != null)
            {
                propertiesObject["serverRelativeUrl"] = ExpressionConverter.ConvertO(requestpropertiesserverRelativeURL);
                propertiesObjectpropCount++;
            }

            if (requestpropertiessyndicationEnabled != null)
            {
                propertiesObject["syndicationEnabled"] = ExpressionConverter.ConvertO(requestpropertiessyndicationEnabled);
                propertiesObjectpropCount++;
            }

            if (requestpropertiesuIVersion != null)
            {
                propertiesObject["uiVersion"] = ExpressionConverter.ConvertO(requestpropertiesuIVersion);
                propertiesObjectpropCount++;
            }

            if (propertiesObjectpropCount > 0)
            {
                request["properties"] = propertiesObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsDeleteSharePointSitePost(Expression<Func<string>> requestsharePointSiteURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeleteSharePointSite";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<SPSiteOptionValueResponse> FlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsStringPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestoptionName)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetSharePointSiteOptionValueAsString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["optionName"] = ExpressionConverter.ConvertO(requestoptionName);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<SPSiteOptionValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsInviteExternalUserToSharePointPost(Expression<Func<targetInput>> target, Expression<Func<object>> request = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/InviteExternalUserToSharePoint";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["target"] = ExpressionConverter.Convert(target);
            callPayload.Body = ExpressionConverter.ConvertO(request);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListFileUrlsResponse> FlowV1SharePointFlowJobsCopyAttachmentsToUrlPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistURL, Expression<Func<int>> requestitemID, Expression<Func<string>> requestdestinationFolderURL, Expression<Func<bool>> requestoverwrite = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyAttachmentsToUrl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemID);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationFolderURL);
            if (requestoverwrite != null)
            {
                request["overwrite"] = ExpressionConverter.ConvertO(requestoverwrite);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ListFileUrlsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListFileUrlsResponse> FlowV1SharePointFlowJobsMoveAttachmentsToUrlPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistURL, Expression<Func<int>> requestitemID, Expression<Func<string>> requestdestinationFolderURL, Expression<Func<bool>> requestoverwrite = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveAttachmentsToUrl";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemID);
            requestpropCount++;
            request["destinationUrl"] = ExpressionConverter.ConvertO(requestdestinationFolderURL);
            if (requestoverwrite != null)
            {
                request["overwrite"] = ExpressionConverter.ConvertO(requestoverwrite);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ListFileUrlsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsAddContentTypeToSharePointListPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistURL, Expression<Func<string>> requestcontentTypeName, Expression<Func<bool>> requestmakeItDefault = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddContentTypeToSharePointList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            requestpropCount++;
            request["contentTypeName"] = ExpressionConverter.ConvertO(requestcontentTypeName);
            if (requestmakeItDefault != null)
            {
                request["makeItDefault"] = ExpressionConverter.ConvertO(requestmakeItDefault);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListItemIdResponse> FlowV1SharePointFlowJobsCopyListItemToSharePointListPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistURL, Expression<Func<string>> requestitemID, Expression<Func<string>> requestdestinationListURL, Expression<Func<bool>> requestcopyAttachments = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyListItemToSharePointList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemID);
            requestpropCount++;
            request["destinationListUrl"] = ExpressionConverter.ConvertO(requestdestinationListURL);
            if (requestcopyAttachments != null)
            {
                request["copyAttachments"] = ExpressionConverter.ConvertO(requestcopyAttachments);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ListItemIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListItemIdResponse> FlowV1SharePointFlowJobsMoveListItemToSharePointListPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistURL, Expression<Func<string>> requestitemID, Expression<Func<string>> requestdestinationListURL, Expression<Func<bool>> requestmoveAttachments = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveListItemToSharePointList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemID);
            requestpropCount++;
            request["destinationListUrl"] = ExpressionConverter.ConvertO(requestdestinationListURL);
            if (requestmoveAttachments != null)
            {
                request["copyAttachments"] = ExpressionConverter.ConvertO(requestmoveAttachments);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<ListItemIdResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WorkflowGuidResponse> FlowV1SharePointFlowJobsStartListWorkflowPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestworkflowName, Expression<Func<string>> requestlistURL, Expression<Func<int>> requestitemID)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/StartListWorkflow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["workflowName"] = ExpressionConverter.ConvertO(requestworkflowName);
            var inputParametersObject = new JObject();
            var inputParametersObjectpropCount = 0;
            if (inputParametersObjectpropCount > 0)
            {
                request["inputParameters"] = inputParametersObject;
                requestpropCount++;
            }

            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemID);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<WorkflowGuidResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WorkflowGuidResponse> FlowV1SharePointFlowJobsStartSiteWorkflowPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestworkflowName)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/StartSiteWorkflow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["workflowName"] = ExpressionConverter.ConvertO(requestworkflowName);
            var inputParametersObject = new JObject();
            var inputParametersObjectpropCount = 0;
            if (inputParametersObjectpropCount > 0)
            {
                request["inputParameters"] = inputParametersObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<WorkflowGuidResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsGetItemsByCamlQueryPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistURL, Expression<Func<string>> requestcAMLQuery, Expression<Func<string>> requestfolderURL = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetItemsByCamlQuery";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            if (requestfolderURL != null)
            {
                request["folderUrl"] = ExpressionConverter.ConvertO(requestfolderURL);
                requestpropCount++;
            }

            requestpropCount++;
            request["camlQuery"] = ExpressionConverter.ConvertO(requestcAMLQuery);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<VersionsHistoryResponse> FlowV1SharePointFlowJobsGetVersionsHistoryPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistURL, Expression<Func<int>> requestitemID, Expression<Func<string>> requestfieldName)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetVersionsHistory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listUrl"] = ExpressionConverter.ConvertO(requestlistURL);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemID);
            requestpropCount++;
            request["fieldName"] = ExpressionConverter.ConvertO(requestfieldName);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<VersionsHistoryResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsProvisionPnPTemplatePost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requesttemplateContent, Expression<Func<bool>> requestoverwriteSystemPropertyBagValues = null, Expression<Func<bool>> requestignoreDuplicateDataRowErrors = null, Expression<Func<bool>> requestclearNavigation = null, Expression<Func<bool>> requestprovisionContentTypesToSubWebs = null, Expression<Func<bool>> requestprovisionFieldsToSubWebs = null, Expression<Func<string>> requesthandlers = null, Expression<Func<string>> requestexcludeHandlers = null, Expression<Func<string>> requestparameters = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/ProvisionPnPTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["xmlTemplateContent"] = ExpressionConverter.ConvertO(requesttemplateContent);
            if (requestoverwriteSystemPropertyBagValues != null)
            {
                request["overwriteSystemPropertyBagValues"] = ExpressionConverter.ConvertO(requestoverwriteSystemPropertyBagValues);
                requestpropCount++;
            }

            if (requestignoreDuplicateDataRowErrors != null)
            {
                request["ignoreDuplicateDataRowErrors"] = ExpressionConverter.ConvertO(requestignoreDuplicateDataRowErrors);
                requestpropCount++;
            }

            if (requestclearNavigation != null)
            {
                request["clearNavigation"] = ExpressionConverter.ConvertO(requestclearNavigation);
                requestpropCount++;
            }

            if (requestprovisionContentTypesToSubWebs != null)
            {
                request["provisionContentTypesToSubWebs"] = ExpressionConverter.ConvertO(requestprovisionContentTypesToSubWebs);
                requestpropCount++;
            }

            if (requestprovisionFieldsToSubWebs != null)
            {
                request["provisionFieldsToSubWebs"] = ExpressionConverter.ConvertO(requestprovisionFieldsToSubWebs);
                requestpropCount++;
            }

            if (requesthandlers != null)
            {
                request["handlers"] = ExpressionConverter.ConvertO(requesthandlers);
                requestpropCount++;
            }

            if (requestexcludeHandlers != null)
            {
                request["excludeHandlers"] = ExpressionConverter.ConvertO(requestexcludeHandlers);
                requestpropCount++;
            }

            if (requestparameters != null)
            {
                request["parameters"] = ExpressionConverter.ConvertO(requestparameters);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsProvisionPnPTenantTemplatePost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requesttemplateContent, Expression<Func<bool>> requestoverwriteSystemPropertyBagValues = null, Expression<Func<bool>> requestignoreDuplicateDataRowErrors = null, Expression<Func<bool>> requestclearNavigation = null, Expression<Func<bool>> requestprovisionContentTypesToSubWebs = null, Expression<Func<bool>> requestprovisionFieldsToSubWebs = null, Expression<Func<string>> requesthandlers = null, Expression<Func<string>> requestexcludeHandlers = null, Expression<Func<string>> requestparameters = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/ProvisionPnPTenantTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["xmlTemplateContent"] = ExpressionConverter.ConvertO(requesttemplateContent);
            if (requestoverwriteSystemPropertyBagValues != null)
            {
                request["overwriteSystemPropertyBagValues"] = ExpressionConverter.ConvertO(requestoverwriteSystemPropertyBagValues);
                requestpropCount++;
            }

            if (requestignoreDuplicateDataRowErrors != null)
            {
                request["ignoreDuplicateDataRowErrors"] = ExpressionConverter.ConvertO(requestignoreDuplicateDataRowErrors);
                requestpropCount++;
            }

            if (requestclearNavigation != null)
            {
                request["clearNavigation"] = ExpressionConverter.ConvertO(requestclearNavigation);
                requestpropCount++;
            }

            if (requestprovisionContentTypesToSubWebs != null)
            {
                request["provisionContentTypesToSubWebs"] = ExpressionConverter.ConvertO(requestprovisionContentTypesToSubWebs);
                requestpropCount++;
            }

            if (requestprovisionFieldsToSubWebs != null)
            {
                request["provisionFieldsToSubWebs"] = ExpressionConverter.ConvertO(requestprovisionFieldsToSubWebs);
                requestpropCount++;
            }

            if (requesthandlers != null)
            {
                request["handlers"] = ExpressionConverter.ConvertO(requesthandlers);
                requestpropCount++;
            }

            if (requestexcludeHandlers != null)
            {
                request["excludeHandlers"] = ExpressionConverter.ConvertO(requestexcludeHandlers);
                requestpropCount++;
            }

            if (requestparameters != null)
            {
                request["parameters"] = ExpressionConverter.ConvertO(requestparameters);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsAddSiteNavigationPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<requestlocationInput>> requestlocation, Expression<Func<string>> requesttitle, Expression<Func<string>> requestparent = null, Expression<Func<string>> requesturl = null, Expression<Func<bool>> requestprepend = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddSiteNavigation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["location"] = ExpressionConverter.ConvertO(requestlocation);
            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requesttitle);
            if (requestparent != null)
            {
                request["parent"] = ExpressionConverter.ConvertO(requestparent);
                requestpropCount++;
            }

            if (requesturl != null)
            {
                request["url"] = ExpressionConverter.ConvertO(requesturl);
                requestpropCount++;
            }

            if (requestprepend != null)
            {
                request["prepend"] = ExpressionConverter.ConvertO(requestprepend);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveSiteNavigationPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<requestlocationInput>> requestlocation, Expression<Func<string>> requesttitle, Expression<Func<string>> requestparent = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveSiteNavigation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["location"] = ExpressionConverter.ConvertO(requestlocation);
            requestpropCount++;
            request["title"] = ExpressionConverter.ConvertO(requesttitle);
            if (requestparent != null)
            {
                request["parent"] = ExpressionConverter.ConvertO(requestparent);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateListItemPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistName, Expression<Func<string>> requestitemIDOrURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateListItem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listName"] = ExpressionConverter.ConvertO(requestlistName);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemIDOrURL);
            var dataObject = new JObject();
            var dataObjectpropCount = 0;
            if (dataObjectpropCount > 0)
            {
                request["data"] = dataObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsDeclareDocumentAsRecordPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistName, Expression<Func<string>> requestitemIDOrURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeclareDocumentAsRecord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listName"] = ExpressionConverter.ConvertO(requestlistName);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemIDOrURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUndeclareDocumentAsRecordPost(Expression<Func<string>> requestsharePointSiteURL, Expression<Func<string>> requestlistName, Expression<Func<string>> requestitemIDOrURL)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/UndeclareDocumentAsRecord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["spUrl"] = ExpressionConverter.ConvertO(requestsharePointSiteURL);
            requestpropCount++;
            request["listName"] = ExpressionConverter.ConvertO(requestlistName);
            requestpropCount++;
            request["itemId"] = ExpressionConverter.ConvertO(requestitemIDOrURL);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsParseCsvPost(Expression<Func<string>> requestcontentOfCSVDocument, Expression<Func<string>> requestheaders, Expression<Func<requestdelimiterInput>> requestdelimiter = null, Expression<Func<requestlocaleInput>> requestlocale = null, Expression<Func<int>> requestlimit = null, Expression<Func<bool>> requestskipFirstLine = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/ParseCsv";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["content"] = ExpressionConverter.ConvertO(requestcontentOfCSVDocument);
            if (requestdelimiter != null)
            {
                request["delimiter"] = ExpressionConverter.ConvertO(requestdelimiter);
                requestpropCount++;
            }

            if (requestlocale != null)
            {
                request["locale"] = ExpressionConverter.ConvertO(requestlocale);
                requestpropCount++;
            }

            if (requestlimit != null)
            {
                request["limit"] = ExpressionConverter.ConvertO(requestlimit);
                requestpropCount++;
            }

            requestpropCount++;
            request["headers"] = ExpressionConverter.ConvertO(requestheaders);
            if (requestskipFirstLine != null)
            {
                request["skipFirstLine"] = ExpressionConverter.ConvertO(requestskipFirstLine);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsRegExpMatchPost(Expression<Func<string>> requestpattern, Expression<Func<string>> requesttext)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpMatch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["pattern"] = ExpressionConverter.ConvertO(requestpattern);
            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<StringResultResponse> FlowV1SharePointFlowJobsRegExpReplacePost(Expression<Func<string>> requestpattern, Expression<Func<string>> requesttext, Expression<Func<string>> requestreplacement = null)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpReplace";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["pattern"] = ExpressionConverter.ConvertO(requestpattern);
            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            if (requestreplacement != null)
            {
                request["replacement"] = ExpressionConverter.ConvertO(requestreplacement);
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<StringResultResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<BooleanResultResponse> FlowV1SharePointFlowJobsRegExpTestPost(Expression<Func<string>> requestpattern, Expression<Func<string>> requesttext)
        {
            var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpTest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["pattern"] = ExpressionConverter.ConvertO(requestpattern);
            requestpropCount++;
            request["text"] = ExpressionConverter.ConvertO(requesttext);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<BooleanResultResponse>(callPayload);
        }
    }

    public class PlumsailspTriggers([ConnectionName] string connectionId)
    {
    }

    public class WebUrlResponse
    {
        [JsonProperty("url")]
        public string WebURL { get; set; }
    }

    public enum actionTypeInput
    {
        Grant,
        Remove,
        RemoveAll,
        RestoreInheritance
    }

    public enum targetInput
    {
        Site,
        Item,
        Group
    }

    public enum requestgroupTypeInput
    {
        Owner,
        Member,
        Visitor
    }

    public class DocumentInfoResponse
    {
        [JsonProperty("id")]
        public int DocumentID { get; set; }

        [JsonProperty("url")]
        public string DocumentURL { get; set; }
    }

    public class DocumentSetInfoResponse
    {
        [JsonProperty("id")]
        public int DocumentSetID { get; set; }

        [JsonProperty("url")]
        public string DocumentSetURL { get; set; }
    }

    public class FolderInfoResponse
    {
        [JsonProperty("id")]
        public int FolderID { get; set; }

        [JsonProperty("url")]
        public string FolderURL { get; set; }
    }

    public enum siteTypeInput
    {
        TeamSite,
        CommunicationSite,
        TeamSiteWithoutGroup
    }

    public class GroupExistResponse
    {
        [JsonProperty("groupExists")]
        public bool GroupExists { get; set; }
    }

    public class GetSPGroupMembersResponse
    {
        [JsonProperty("users")]
        public SharePointUserResponse[] Users { get; set; }
    }

    public class SharePointUserResponse
    {
        [JsonProperty("id")]
        public int UserID { get; set; }

        [JsonProperty("loginName")]
        public string UserName { get; set; }

        [JsonProperty("email")]
        public string UserEmail { get; set; }

        [JsonProperty("claims")]
        public string UserClaims { get; set; }
    }

    public class UserExistsResponse
    {
        [JsonProperty("userExists")]
        public bool UserExists { get; set; }
    }

    public class SPSiteOptionValueResponse
    {
        [JsonProperty("optionValue")]
        public string OptionValue { get; set; }
    }

    public class ListFileUrlsResponse
    {
        [JsonProperty("fileUrls")]
        public string[] FileURLs { get; set; }
    }

    public class ListItemIdResponse
    {
        [JsonProperty("resultItemId")]
        public int ResultItemID { get; set; }
    }

    public class WorkflowGuidResponse
    {
        [JsonProperty("workflowGuid")]
        public string WorkflowGUID { get; set; }
    }

    public class VersionsHistoryResponse
    {
        [JsonProperty("countVersions")]
        public int CountVersions { get; set; }

        [JsonProperty("versions")]
        public SharePointVersionResponse[] Versions { get; set; }
    }

    public class SharePointVersionResponse
    {
        [JsonProperty("editor")]
        public SharePointUserResponse Editor { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum requestlocationInput
    {
        Top,
        QuickLaunch
    }

    public enum requestdelimiterInput
    {
        Comma,
        Semicolon,
        Tab,
        Pipe
    }

    public enum requestlocaleInput
    {
        [EnumMember(Value = "aa-DJ")]
        AaDJ,
        [EnumMember(Value = "aa-ER")]
        AaER,
        [EnumMember(Value = "aa-ET")]
        AaET,
        [EnumMember(Value = "af-NA")]
        AfNA,
        [EnumMember(Value = "af-ZA")]
        AfZA,
        [EnumMember(Value = "agq-CM")]
        AgqCM,
        [EnumMember(Value = "ak-GH")]
        AkGH,
        [EnumMember(Value = "am-ET")]
        AmET,
        [EnumMember(Value = "ar-001")]
        Ar001,
        [EnumMember(Value = "ar-AE")]
        ArAE,
        [EnumMember(Value = "ar-BH")]
        ArBH,
        [EnumMember(Value = "ar-DJ")]
        ArDJ,
        [EnumMember(Value = "ar-DZ")]
        ArDZ,
        [EnumMember(Value = "ar-EG")]
        ArEG,
        [EnumMember(Value = "ar-ER")]
        ArER,
        [EnumMember(Value = "ar-IL")]
        ArIL,
        [EnumMember(Value = "ar-IQ")]
        ArIQ,
        [EnumMember(Value = "ar-JO")]
        ArJO,
        [EnumMember(Value = "ar-KM")]
        ArKM,
        [EnumMember(Value = "ar-KW")]
        ArKW,
        [EnumMember(Value = "ar-LB")]
        ArLB,
        [EnumMember(Value = "ar-LY")]
        ArLY,
        [EnumMember(Value = "ar-MA")]
        ArMA,
        [EnumMember(Value = "ar-MR")]
        ArMR,
        [EnumMember(Value = "ar-OM")]
        ArOM,
        [EnumMember(Value = "ar-PS")]
        ArPS,
        [EnumMember(Value = "ar-QA")]
        ArQA,
        [EnumMember(Value = "ar-SA")]
        ArSA,
        [EnumMember(Value = "ar-SD")]
        ArSD,
        [EnumMember(Value = "ar-SO")]
        ArSO,
        [EnumMember(Value = "ar-SS")]
        ArSS,
        [EnumMember(Value = "ar-SY")]
        ArSY,
        [EnumMember(Value = "ar-TD")]
        ArTD,
        [EnumMember(Value = "ar-TN")]
        ArTN,
        [EnumMember(Value = "ar-YE")]
        ArYE,
        [EnumMember(Value = "arn-CL")]
        ArnCL,
        [EnumMember(Value = "as-IN")]
        AsIN,
        [EnumMember(Value = "asa-TZ")]
        AsaTZ,
        [EnumMember(Value = "ast-ES")]
        AstES,
        [EnumMember(Value = "az-Cyrl-AZ")]
        AzCyrlAZ,
        [EnumMember(Value = "az-Latn-AZ")]
        AzLatnAZ,
        [EnumMember(Value = "ba-RU")]
        BaRU,
        [EnumMember(Value = "bas-CM")]
        BasCM,
        [EnumMember(Value = "be-BY")]
        BeBY,
        [EnumMember(Value = "bem-ZM")]
        BemZM,
        [EnumMember(Value = "bez-TZ")]
        BezTZ,
        [EnumMember(Value = "bg-BG")]
        BgBG,
        [EnumMember(Value = "bm-ML")]
        BmML,
        [EnumMember(Value = "bn-BD")]
        BnBD,
        [EnumMember(Value = "bn-IN")]
        BnIN,
        [EnumMember(Value = "bo-CN")]
        BoCN,
        [EnumMember(Value = "bo-IN")]
        BoIN,
        [EnumMember(Value = "br-FR")]
        BrFR,
        [EnumMember(Value = "brx-IN")]
        BrxIN,
        [EnumMember(Value = "bs-Cyrl-BA")]
        BsCyrlBA,
        [EnumMember(Value = "bs-Latn-BA")]
        BsLatnBA,
        [EnumMember(Value = "byn-ER")]
        BynER,
        [EnumMember(Value = "ca-AD")]
        CaAD,
        [EnumMember(Value = "ca-ES")]
        CaES,
        [EnumMember(Value = "ca-FR")]
        CaFR,
        [EnumMember(Value = "ca-IT")]
        CaIT,
        [EnumMember(Value = "ccp-BD")]
        CcpBD,
        [EnumMember(Value = "ccp-IN")]
        CcpIN,
        [EnumMember(Value = "ce-RU")]
        CeRU,
        [EnumMember(Value = "ceb-PH")]
        CebPH,
        [EnumMember(Value = "cgg-UG")]
        CggUG,
        [EnumMember(Value = "chr-US")]
        ChrUS,
        [EnumMember(Value = "ckb-IQ")]
        CkbIQ,
        [EnumMember(Value = "ckb-IR")]
        CkbIR,
        [EnumMember(Value = "co-FR")]
        CoFR,
        [EnumMember(Value = "cs-CZ")]
        CsCZ,
        [EnumMember(Value = "cu-RU")]
        CuRU,
        [EnumMember(Value = "cy-GB")]
        CyGB,
        [EnumMember(Value = "da-DK")]
        DaDK,
        [EnumMember(Value = "da-GL")]
        DaGL,
        [EnumMember(Value = "dav-KE")]
        DavKE,
        [EnumMember(Value = "de-AT")]
        DeAT,
        [EnumMember(Value = "de-BE")]
        DeBE,
        [EnumMember(Value = "de-CH")]
        DeCH,
        [EnumMember(Value = "de-DE")]
        DeDE,
        [EnumMember(Value = "de-IT")]
        DeIT,
        [EnumMember(Value = "de-LI")]
        DeLI,
        [EnumMember(Value = "de-LU")]
        DeLU,
        [EnumMember(Value = "dje-NE")]
        DjeNE,
        [EnumMember(Value = "dsb-DE")]
        DsbDE,
        [EnumMember(Value = "dua-CM")]
        DuaCM,
        [EnumMember(Value = "dv-MV")]
        DvMV,
        [EnumMember(Value = "dyo-SN")]
        DyoSN,
        [EnumMember(Value = "dz-BT")]
        DzBT,
        [EnumMember(Value = "ebu-KE")]
        EbuKE,
        [EnumMember(Value = "ee-GH")]
        EeGH,
        [EnumMember(Value = "ee-TG")]
        EeTG,
        [EnumMember(Value = "el-CY")]
        ElCY,
        [EnumMember(Value = "el-GR")]
        ElGR,
        [EnumMember(Value = "en-001")]
        En001,
        [EnumMember(Value = "en-150")]
        En150,
        [EnumMember(Value = "en-AE")]
        EnAE,
        [EnumMember(Value = "en-AG")]
        EnAG,
        [EnumMember(Value = "en-AI")]
        EnAI,
        [EnumMember(Value = "en-AS")]
        EnAS,
        [EnumMember(Value = "en-AT")]
        EnAT,
        [EnumMember(Value = "en-AU")]
        EnAU,
        [EnumMember(Value = "en-BB")]
        EnBB,
        [EnumMember(Value = "en-BE")]
        EnBE,
        [EnumMember(Value = "en-BI")]
        EnBI,
        [EnumMember(Value = "en-BM")]
        EnBM,
        [EnumMember(Value = "en-BS")]
        EnBS,
        [EnumMember(Value = "en-BW")]
        EnBW,
        [EnumMember(Value = "en-BZ")]
        EnBZ,
        [EnumMember(Value = "en-CA")]
        EnCA,
        [EnumMember(Value = "en-CC")]
        EnCC,
        [EnumMember(Value = "en-CH")]
        EnCH,
        [EnumMember(Value = "en-CK")]
        EnCK,
        [EnumMember(Value = "en-CM")]
        EnCM,
        [EnumMember(Value = "en-CX")]
        EnCX,
        [EnumMember(Value = "en-CY")]
        EnCY,
        [EnumMember(Value = "en-DE")]
        EnDE,
        [EnumMember(Value = "en-DK")]
        EnDK,
        [EnumMember(Value = "en-DM")]
        EnDM,
        [EnumMember(Value = "en-ER")]
        EnER,
        [EnumMember(Value = "en-FI")]
        EnFI,
        [EnumMember(Value = "en-FJ")]
        EnFJ,
        [EnumMember(Value = "en-FK")]
        EnFK,
        [EnumMember(Value = "en-FM")]
        EnFM,
        [EnumMember(Value = "en-GB")]
        EnGB,
        [EnumMember(Value = "en-GD")]
        EnGD,
        [EnumMember(Value = "en-GG")]
        EnGG,
        [EnumMember(Value = "en-GH")]
        EnGH,
        [EnumMember(Value = "en-GI")]
        EnGI,
        [EnumMember(Value = "en-GM")]
        EnGM,
        [EnumMember(Value = "en-GU")]
        EnGU,
        [EnumMember(Value = "en-GY")]
        EnGY,
        [EnumMember(Value = "en-HK")]
        EnHK,
        [EnumMember(Value = "en-IE")]
        EnIE,
        [EnumMember(Value = "en-IL")]
        EnIL,
        [EnumMember(Value = "en-IM")]
        EnIM,
        [EnumMember(Value = "en-IN")]
        EnIN,
        [EnumMember(Value = "en-IO")]
        EnIO,
        [EnumMember(Value = "en-JE")]
        EnJE,
        [EnumMember(Value = "en-JM")]
        EnJM,
        [EnumMember(Value = "en-KE")]
        EnKE,
        [EnumMember(Value = "en-KI")]
        EnKI,
        [EnumMember(Value = "en-KN")]
        EnKN,
        [EnumMember(Value = "en-KY")]
        EnKY,
        [EnumMember(Value = "en-LC")]
        EnLC,
        [EnumMember(Value = "en-LR")]
        EnLR,
        [EnumMember(Value = "en-LS")]
        EnLS,
        [EnumMember(Value = "en-MG")]
        EnMG,
        [EnumMember(Value = "en-MH")]
        EnMH,
        [EnumMember(Value = "en-MO")]
        EnMO,
        [EnumMember(Value = "en-MP")]
        EnMP,
        [EnumMember(Value = "en-MS")]
        EnMS,
        [EnumMember(Value = "en-MT")]
        EnMT,
        [EnumMember(Value = "en-MU")]
        EnMU,
        [EnumMember(Value = "en-MW")]
        EnMW,
        [EnumMember(Value = "en-MY")]
        EnMY,
        [EnumMember(Value = "en-NA")]
        EnNA,
        [EnumMember(Value = "en-NF")]
        EnNF,
        [EnumMember(Value = "en-NG")]
        EnNG,
        [EnumMember(Value = "en-NL")]
        EnNL,
        [EnumMember(Value = "en-NR")]
        EnNR,
        [EnumMember(Value = "en-NU")]
        EnNU,
        [EnumMember(Value = "en-NZ")]
        EnNZ,
        [EnumMember(Value = "en-PG")]
        EnPG,
        [EnumMember(Value = "en-PH")]
        EnPH,
        [EnumMember(Value = "en-PK")]
        EnPK,
        [EnumMember(Value = "en-PN")]
        EnPN,
        [EnumMember(Value = "en-PR")]
        EnPR,
        [EnumMember(Value = "en-PW")]
        EnPW,
        [EnumMember(Value = "en-RW")]
        EnRW,
        [EnumMember(Value = "en-SB")]
        EnSB,
        [EnumMember(Value = "en-SC")]
        EnSC,
        [EnumMember(Value = "en-SD")]
        EnSD,
        [EnumMember(Value = "en-SE")]
        EnSE,
        [EnumMember(Value = "en-SG")]
        EnSG,
        [EnumMember(Value = "en-SH")]
        EnSH,
        [EnumMember(Value = "en-SI")]
        EnSI,
        [EnumMember(Value = "en-SL")]
        EnSL,
        [EnumMember(Value = "en-SS")]
        EnSS,
        [EnumMember(Value = "en-SX")]
        EnSX,
        [EnumMember(Value = "en-SZ")]
        EnSZ,
        [EnumMember(Value = "en-TC")]
        EnTC,
        [EnumMember(Value = "en-TK")]
        EnTK,
        [EnumMember(Value = "en-TO")]
        EnTO,
        [EnumMember(Value = "en-TT")]
        EnTT,
        [EnumMember(Value = "en-TV")]
        EnTV,
        [EnumMember(Value = "en-TZ")]
        EnTZ,
        [EnumMember(Value = "en-UG")]
        EnUG,
        [EnumMember(Value = "en-UM")]
        EnUM,
        [EnumMember(Value = "en-US")]
        EnUS,
        [EnumMember(Value = "en-US-POSIX")]
        EnUSPOSIX,
        [EnumMember(Value = "en-VC")]
        EnVC,
        [EnumMember(Value = "en-VG")]
        EnVG,
        [EnumMember(Value = "en-VI")]
        EnVI,
        [EnumMember(Value = "en-VU")]
        EnVU,
        [EnumMember(Value = "en-WS")]
        EnWS,
        [EnumMember(Value = "en-ZA")]
        EnZA,
        [EnumMember(Value = "en-ZM")]
        EnZM,
        [EnumMember(Value = "en-ZW")]
        EnZW,
        [EnumMember(Value = "eo-001")]
        Eo001,
        [EnumMember(Value = "es-419")]
        Es419,
        [EnumMember(Value = "es-AR")]
        EsAR,
        [EnumMember(Value = "es-BO")]
        EsBO,
        [EnumMember(Value = "es-BR")]
        EsBR,
        [EnumMember(Value = "es-BZ")]
        EsBZ,
        [EnumMember(Value = "es-CL")]
        EsCL,
        [EnumMember(Value = "es-CO")]
        EsCO,
        [EnumMember(Value = "es-CR")]
        EsCR,
        [EnumMember(Value = "es-CU")]
        EsCU,
        [EnumMember(Value = "es-DO")]
        EsDO,
        [EnumMember(Value = "es-EC")]
        EsEC,
        [EnumMember(Value = "es-ES")]
        EsES,
        [EnumMember(Value = "es-GQ")]
        EsGQ,
        [EnumMember(Value = "es-GT")]
        EsGT,
        [EnumMember(Value = "es-HN")]
        EsHN,
        [EnumMember(Value = "es-MX")]
        EsMX,
        [EnumMember(Value = "es-NI")]
        EsNI,
        [EnumMember(Value = "es-PA")]
        EsPA,
        [EnumMember(Value = "es-PE")]
        EsPE,
        [EnumMember(Value = "es-PH")]
        EsPH,
        [EnumMember(Value = "es-PR")]
        EsPR,
        [EnumMember(Value = "es-PY")]
        EsPY,
        [EnumMember(Value = "es-SV")]
        EsSV,
        [EnumMember(Value = "es-US")]
        EsUS,
        [EnumMember(Value = "es-UY")]
        EsUY,
        [EnumMember(Value = "es-VE")]
        EsVE,
        [EnumMember(Value = "et-EE")]
        EtEE,
        [EnumMember(Value = "eu-ES")]
        EuES,
        [EnumMember(Value = "ewo-CM")]
        EwoCM,
        [EnumMember(Value = "fa-AF")]
        FaAF,
        [EnumMember(Value = "fa-IR")]
        FaIR,
        [EnumMember(Value = "ff-Latn-BF")]
        FfLatnBF,
        [EnumMember(Value = "ff-Latn-CM")]
        FfLatnCM,
        [EnumMember(Value = "ff-Latn-GH")]
        FfLatnGH,
        [EnumMember(Value = "ff-Latn-GM")]
        FfLatnGM,
        [EnumMember(Value = "ff-Latn-GN")]
        FfLatnGN,
        [EnumMember(Value = "ff-Latn-GW")]
        FfLatnGW,
        [EnumMember(Value = "ff-Latn-LR")]
        FfLatnLR,
        [EnumMember(Value = "ff-Latn-MR")]
        FfLatnMR,
        [EnumMember(Value = "ff-Latn-NE")]
        FfLatnNE,
        [EnumMember(Value = "ff-Latn-NG")]
        FfLatnNG,
        [EnumMember(Value = "ff-Latn-SL")]
        FfLatnSL,
        [EnumMember(Value = "ff-Latn-SN")]
        FfLatnSN,
        [EnumMember(Value = "fi-FI")]
        FiFI,
        [EnumMember(Value = "fil-PH")]
        FilPH,
        [EnumMember(Value = "fo-DK")]
        FoDK,
        [EnumMember(Value = "fo-FO")]
        FoFO,
        [EnumMember(Value = "fr-BE")]
        FrBE,
        [EnumMember(Value = "fr-BF")]
        FrBF,
        [EnumMember(Value = "fr-BI")]
        FrBI,
        [EnumMember(Value = "fr-BJ")]
        FrBJ,
        [EnumMember(Value = "fr-BL")]
        FrBL,
        [EnumMember(Value = "fr-CA")]
        FrCA,
        [EnumMember(Value = "fr-CD")]
        FrCD,
        [EnumMember(Value = "fr-CF")]
        FrCF,
        [EnumMember(Value = "fr-CG")]
        FrCG,
        [EnumMember(Value = "fr-CH")]
        FrCH,
        [EnumMember(Value = "fr-CI")]
        FrCI,
        [EnumMember(Value = "fr-CM")]
        FrCM,
        [EnumMember(Value = "fr-DJ")]
        FrDJ,
        [EnumMember(Value = "fr-DZ")]
        FrDZ,
        [EnumMember(Value = "fr-FR")]
        FrFR,
        [EnumMember(Value = "fr-GA")]
        FrGA,
        [EnumMember(Value = "fr-GF")]
        FrGF,
        [EnumMember(Value = "fr-GN")]
        FrGN,
        [EnumMember(Value = "fr-GP")]
        FrGP,
        [EnumMember(Value = "fr-GQ")]
        FrGQ,
        [EnumMember(Value = "fr-HT")]
        FrHT,
        [EnumMember(Value = "fr-KM")]
        FrKM,
        [EnumMember(Value = "fr-LU")]
        FrLU,
        [EnumMember(Value = "fr-MA")]
        FrMA,
        [EnumMember(Value = "fr-MC")]
        FrMC,
        [EnumMember(Value = "fr-MF")]
        FrMF,
        [EnumMember(Value = "fr-MG")]
        FrMG,
        [EnumMember(Value = "fr-ML")]
        FrML,
        [EnumMember(Value = "fr-MQ")]
        FrMQ,
        [EnumMember(Value = "fr-MR")]
        FrMR,
        [EnumMember(Value = "fr-MU")]
        FrMU,
        [EnumMember(Value = "fr-NC")]
        FrNC,
        [EnumMember(Value = "fr-NE")]
        FrNE,
        [EnumMember(Value = "fr-PF")]
        FrPF,
        [EnumMember(Value = "fr-PM")]
        FrPM,
        [EnumMember(Value = "fr-RE")]
        FrRE,
        [EnumMember(Value = "fr-RW")]
        FrRW,
        [EnumMember(Value = "fr-SC")]
        FrSC,
        [EnumMember(Value = "fr-SN")]
        FrSN,
        [EnumMember(Value = "fr-SY")]
        FrSY,
        [EnumMember(Value = "fr-TD")]
        FrTD,
        [EnumMember(Value = "fr-TG")]
        FrTG,
        [EnumMember(Value = "fr-TN")]
        FrTN,
        [EnumMember(Value = "fr-VU")]
        FrVU,
        [EnumMember(Value = "fr-WF")]
        FrWF,
        [EnumMember(Value = "fr-YT")]
        FrYT,
        [EnumMember(Value = "fur-IT")]
        FurIT,
        [EnumMember(Value = "fy-NL")]
        FyNL,
        [EnumMember(Value = "ga-IE")]
        GaIE,
        [EnumMember(Value = "gd-GB")]
        GdGB,
        [EnumMember(Value = "gl-ES")]
        GlES,
        [EnumMember(Value = "gn-PY")]
        GnPY,
        [EnumMember(Value = "gsw-CH")]
        GswCH,
        [EnumMember(Value = "gsw-FR")]
        GswFR,
        [EnumMember(Value = "gsw-LI")]
        GswLI,
        [EnumMember(Value = "gu-IN")]
        GuIN,
        [EnumMember(Value = "guz-KE")]
        GuzKE,
        [EnumMember(Value = "gv-IM")]
        GvIM,
        [EnumMember(Value = "ha-GH")]
        HaGH,
        [EnumMember(Value = "ha-NE")]
        HaNE,
        [EnumMember(Value = "ha-NG")]
        HaNG,
        [EnumMember(Value = "haw-US")]
        HawUS,
        [EnumMember(Value = "he-IL")]
        HeIL,
        [EnumMember(Value = "hi-IN")]
        HiIN,
        [EnumMember(Value = "hr-BA")]
        HrBA,
        [EnumMember(Value = "hr-HR")]
        HrHR,
        [EnumMember(Value = "hsb-DE")]
        HsbDE,
        [EnumMember(Value = "hu-HU")]
        HuHU,
        [EnumMember(Value = "hy-AM")]
        HyAM,
        [EnumMember(Value = "ia-001")]
        Ia001,
        [EnumMember(Value = "id-ID")]
        IdID,
        [EnumMember(Value = "ig-NG")]
        IgNG,
        [EnumMember(Value = "ii-CN")]
        IiCN,
        [EnumMember(Value = "is-IS")]
        IsIS,
        [EnumMember(Value = "it-CH")]
        ItCH,
        [EnumMember(Value = "it-IT")]
        ItIT,
        [EnumMember(Value = "it-SM")]
        ItSM,
        [EnumMember(Value = "it-VA")]
        ItVA,
        [EnumMember(Value = "iu-CA")]
        IuCA,
        [EnumMember(Value = "iu-Latn-CA")]
        IuLatnCA,
        [EnumMember(Value = "ja-JP")]
        JaJP,
        [EnumMember(Value = "jgo-CM")]
        JgoCM,
        [EnumMember(Value = "jmc-TZ")]
        JmcTZ,
        [EnumMember(Value = "jv-ID")]
        JvID,
        [EnumMember(Value = "ka-GE")]
        KaGE,
        [EnumMember(Value = "kab-DZ")]
        KabDZ,
        [EnumMember(Value = "kam-KE")]
        KamKE,
        [EnumMember(Value = "kde-TZ")]
        KdeTZ,
        [EnumMember(Value = "kea-CV")]
        KeaCV,
        [EnumMember(Value = "khq-ML")]
        KhqML,
        [EnumMember(Value = "ki-KE")]
        KiKE,
        [EnumMember(Value = "kk-KZ")]
        KkKZ,
        [EnumMember(Value = "kkj-CM")]
        KkjCM,
        [EnumMember(Value = "kl-GL")]
        KlGL,
        [EnumMember(Value = "kln-KE")]
        KlnKE,
        [EnumMember(Value = "km-KH")]
        KmKH,
        [EnumMember(Value = "kn-IN")]
        KnIN,
        [EnumMember(Value = "ko-KP")]
        KoKP,
        [EnumMember(Value = "ko-KR")]
        KoKR,
        [EnumMember(Value = "kok-IN")]
        KokIN,
        [EnumMember(Value = "ks-IN")]
        KsIN,
        [EnumMember(Value = "ksb-TZ")]
        KsbTZ,
        [EnumMember(Value = "ksf-CM")]
        KsfCM,
        [EnumMember(Value = "ksh-DE")]
        KshDE,
        [EnumMember(Value = "kw-GB")]
        KwGB,
        [EnumMember(Value = "ky-KG")]
        KyKG,
        [EnumMember(Value = "lag-TZ")]
        LagTZ,
        [EnumMember(Value = "lb-LU")]
        LbLU,
        [EnumMember(Value = "lg-UG")]
        LgUG,
        [EnumMember(Value = "lkt-US")]
        LktUS,
        [EnumMember(Value = "ln-AO")]
        LnAO,
        [EnumMember(Value = "ln-CD")]
        LnCD,
        [EnumMember(Value = "ln-CF")]
        LnCF,
        [EnumMember(Value = "ln-CG")]
        LnCG,
        [EnumMember(Value = "lo-LA")]
        LoLA,
        [EnumMember(Value = "lrc-IQ")]
        LrcIQ,
        [EnumMember(Value = "lrc-IR")]
        LrcIR,
        [EnumMember(Value = "lt-LT")]
        LtLT,
        [EnumMember(Value = "lu-CD")]
        LuCD,
        [EnumMember(Value = "luo-KE")]
        LuoKE,
        [EnumMember(Value = "luy-KE")]
        LuyKE,
        [EnumMember(Value = "lv-LV")]
        LvLV,
        [EnumMember(Value = "mas-KE")]
        MasKE,
        [EnumMember(Value = "mas-TZ")]
        MasTZ,
        [EnumMember(Value = "mer-KE")]
        MerKE,
        [EnumMember(Value = "mfe-MU")]
        MfeMU,
        [EnumMember(Value = "mg-MG")]
        MgMG,
        [EnumMember(Value = "mgh-MZ")]
        MghMZ,
        [EnumMember(Value = "mgo-CM")]
        MgoCM,
        [EnumMember(Value = "mi-NZ")]
        MiNZ,
        [EnumMember(Value = "mk-MK")]
        MkMK,
        [EnumMember(Value = "ml-IN")]
        MlIN,
        [EnumMember(Value = "mn-MN")]
        MnMN,
        [EnumMember(Value = "mn-Mong-CN")]
        MnMongCN,
        [EnumMember(Value = "mn-Mong-MN")]
        MnMongMN,
        [EnumMember(Value = "moh-CA")]
        MohCA,
        [EnumMember(Value = "mr-IN")]
        MrIN,
        [EnumMember(Value = "ms-BN")]
        MsBN,
        [EnumMember(Value = "ms-MY")]
        MsMY,
        [EnumMember(Value = "ms-SG")]
        MsSG,
        [EnumMember(Value = "mt-MT")]
        MtMT,
        [EnumMember(Value = "mua-CM")]
        MuaCM,
        [EnumMember(Value = "my-MM")]
        MyMM,
        [EnumMember(Value = "mzn-IR")]
        MznIR,
        [EnumMember(Value = "naq-NA")]
        NaqNA,
        [EnumMember(Value = "nb-NO")]
        NbNO,
        [EnumMember(Value = "nb-SJ")]
        NbSJ,
        [EnumMember(Value = "nd-ZW")]
        NdZW,
        [EnumMember(Value = "nds-DE")]
        NdsDE,
        [EnumMember(Value = "nds-NL")]
        NdsNL,
        [EnumMember(Value = "ne-IN")]
        NeIN,
        [EnumMember(Value = "ne-NP")]
        NeNP,
        [EnumMember(Value = "nl-AW")]
        NlAW,
        [EnumMember(Value = "nl-BE")]
        NlBE,
        [EnumMember(Value = "nl-BQ")]
        NlBQ,
        [EnumMember(Value = "nl-CW")]
        NlCW,
        [EnumMember(Value = "nl-NL")]
        NlNL,
        [EnumMember(Value = "nl-SR")]
        NlSR,
        [EnumMember(Value = "nl-SX")]
        NlSX,
        [EnumMember(Value = "nmg-CM")]
        NmgCM,
        [EnumMember(Value = "nn-NO")]
        NnNO,
        [EnumMember(Value = "nnh-CM")]
        NnhCM,
        [EnumMember(Value = "nqo-GN")]
        NqoGN,
        [EnumMember(Value = "nr-ZA")]
        NrZA,
        [EnumMember(Value = "nso-ZA")]
        NsoZA,
        [EnumMember(Value = "nus-SS")]
        NusSS,
        [EnumMember(Value = "nyn-UG")]
        NynUG,
        [EnumMember(Value = "oc-FR")]
        OcFR,
        [EnumMember(Value = "om-ET")]
        OmET,
        [EnumMember(Value = "om-KE")]
        OmKE,
        [EnumMember(Value = "or-IN")]
        OrIN,
        [EnumMember(Value = "os-GE")]
        OsGE,
        [EnumMember(Value = "os-RU")]
        OsRU,
        [EnumMember(Value = "pa-Arab-PK")]
        PaArabPK,
        [EnumMember(Value = "pa-Guru-IN")]
        PaGuruIN,
        [EnumMember(Value = "pl-PL")]
        PlPL,
        [EnumMember(Value = "prg-001")]
        Prg001,
        [EnumMember(Value = "ps-AF")]
        PsAF,
        [EnumMember(Value = "ps-PK")]
        PsPK,
        [EnumMember(Value = "pt-AO")]
        PtAO,
        [EnumMember(Value = "pt-BR")]
        PtBR,
        [EnumMember(Value = "pt-CH")]
        PtCH,
        [EnumMember(Value = "pt-CV")]
        PtCV,
        [EnumMember(Value = "pt-GQ")]
        PtGQ,
        [EnumMember(Value = "pt-GW")]
        PtGW,
        [EnumMember(Value = "pt-LU")]
        PtLU,
        [EnumMember(Value = "pt-MO")]
        PtMO,
        [EnumMember(Value = "pt-MZ")]
        PtMZ,
        [EnumMember(Value = "pt-PT")]
        PtPT,
        [EnumMember(Value = "pt-ST")]
        PtST,
        [EnumMember(Value = "pt-TL")]
        PtTL,
        [EnumMember(Value = "qu-BO")]
        QuBO,
        [EnumMember(Value = "qu-EC")]
        QuEC,
        [EnumMember(Value = "qu-PE")]
        QuPE,
        [EnumMember(Value = "quc-GT")]
        QucGT,
        [EnumMember(Value = "rm-CH")]
        RmCH,
        [EnumMember(Value = "rn-BI")]
        RnBI,
        [EnumMember(Value = "ro-MD")]
        RoMD,
        [EnumMember(Value = "ro-RO")]
        RoRO,
        [EnumMember(Value = "rof-TZ")]
        RofTZ,
        [EnumMember(Value = "ru-BY")]
        RuBY,
        [EnumMember(Value = "ru-KG")]
        RuKG,
        [EnumMember(Value = "ru-KZ")]
        RuKZ,
        [EnumMember(Value = "ru-MD")]
        RuMD,
        [EnumMember(Value = "ru-RU")]
        RuRU,
        [EnumMember(Value = "ru-UA")]
        RuUA,
        [EnumMember(Value = "rw-RW")]
        RwRW,
        [EnumMember(Value = "rwk-TZ")]
        RwkTZ,
        [EnumMember(Value = "sa-IN")]
        SaIN,
        [EnumMember(Value = "sah-RU")]
        SahRU,
        [EnumMember(Value = "saq-KE")]
        SaqKE,
        [EnumMember(Value = "sbp-TZ")]
        SbpTZ,
        [EnumMember(Value = "sd-PK")]
        SdPK,
        [EnumMember(Value = "se-FI")]
        SeFI,
        [EnumMember(Value = "se-NO")]
        SeNO,
        [EnumMember(Value = "se-SE")]
        SeSE,
        [EnumMember(Value = "seh-MZ")]
        SehMZ,
        [EnumMember(Value = "ses-ML")]
        SesML,
        [EnumMember(Value = "sg-CF")]
        SgCF,
        [EnumMember(Value = "shi-Latn-MA")]
        ShiLatnMA,
        [EnumMember(Value = "shi-Tfng-MA")]
        ShiTfngMA,
        [EnumMember(Value = "si-LK")]
        SiLK,
        [EnumMember(Value = "sk-SK")]
        SkSK,
        [EnumMember(Value = "sl-SI")]
        SlSI,
        [EnumMember(Value = "sma-NO")]
        SmaNO,
        [EnumMember(Value = "sma-SE")]
        SmaSE,
        [EnumMember(Value = "smj-NO")]
        SmjNO,
        [EnumMember(Value = "smj-SE")]
        SmjSE,
        [EnumMember(Value = "smn-FI")]
        SmnFI,
        [EnumMember(Value = "sms-FI")]
        SmsFI,
        [EnumMember(Value = "sn-ZW")]
        SnZW,
        [EnumMember(Value = "so-DJ")]
        SoDJ,
        [EnumMember(Value = "so-ET")]
        SoET,
        [EnumMember(Value = "so-KE")]
        SoKE,
        [EnumMember(Value = "so-SO")]
        SoSO,
        [EnumMember(Value = "sq-AL")]
        SqAL,
        [EnumMember(Value = "sq-MK")]
        SqMK,
        [EnumMember(Value = "sq-XK")]
        SqXK,
        [EnumMember(Value = "sr-Cyrl-BA")]
        SrCyrlBA,
        [EnumMember(Value = "sr-Cyrl-ME")]
        SrCyrlME,
        [EnumMember(Value = "sr-Cyrl-RS")]
        SrCyrlRS,
        [EnumMember(Value = "sr-Cyrl-XK")]
        SrCyrlXK,
        [EnumMember(Value = "sr-Latn-BA")]
        SrLatnBA,
        [EnumMember(Value = "sr-Latn-ME")]
        SrLatnME,
        [EnumMember(Value = "sr-Latn-RS")]
        SrLatnRS,
        [EnumMember(Value = "sr-Latn-XK")]
        SrLatnXK,
        [EnumMember(Value = "ss-SZ")]
        SsSZ,
        [EnumMember(Value = "ss-ZA")]
        SsZA,
        [EnumMember(Value = "ssy-ER")]
        SsyER,
        [EnumMember(Value = "st-LS")]
        StLS,
        [EnumMember(Value = "st-ZA")]
        StZA,
        [EnumMember(Value = "sv-AX")]
        SvAX,
        [EnumMember(Value = "sv-FI")]
        SvFI,
        [EnumMember(Value = "sv-SE")]
        SvSE,
        [EnumMember(Value = "sw-CD")]
        SwCD,
        [EnumMember(Value = "sw-KE")]
        SwKE,
        [EnumMember(Value = "sw-TZ")]
        SwTZ,
        [EnumMember(Value = "sw-UG")]
        SwUG,
        [EnumMember(Value = "syr-SY")]
        SyrSY,
        [EnumMember(Value = "ta-IN")]
        TaIN,
        [EnumMember(Value = "ta-LK")]
        TaLK,
        [EnumMember(Value = "ta-MY")]
        TaMY,
        [EnumMember(Value = "ta-SG")]
        TaSG,
        [EnumMember(Value = "te-IN")]
        TeIN,
        [EnumMember(Value = "teo-KE")]
        TeoKE,
        [EnumMember(Value = "teo-UG")]
        TeoUG,
        [EnumMember(Value = "tg-TJ")]
        TgTJ,
        [EnumMember(Value = "th-TH")]
        ThTH,
        [EnumMember(Value = "ti-ER")]
        TiER,
        [EnumMember(Value = "ti-ET")]
        TiET,
        [EnumMember(Value = "tig-ER")]
        TigER,
        [EnumMember(Value = "tk-TM")]
        TkTM,
        [EnumMember(Value = "tn-BW")]
        TnBW,
        [EnumMember(Value = "tn-ZA")]
        TnZA,
        [EnumMember(Value = "to-TO")]
        ToTO,
        [EnumMember(Value = "tr-CY")]
        TrCY,
        [EnumMember(Value = "tr-TR")]
        TrTR,
        [EnumMember(Value = "ts-ZA")]
        TsZA,
        [EnumMember(Value = "tt-RU")]
        TtRU,
        [EnumMember(Value = "twq-NE")]
        TwqNE,
        [EnumMember(Value = "tzm-MA")]
        TzmMA,
        [EnumMember(Value = "ug-CN")]
        UgCN,
        [EnumMember(Value = "uk-UA")]
        UkUA,
        [EnumMember(Value = "ur-IN")]
        UrIN,
        [EnumMember(Value = "ur-PK")]
        UrPK,
        [EnumMember(Value = "uz-Arab-AF")]
        UzArabAF,
        [EnumMember(Value = "uz-Cyrl-UZ")]
        UzCyrlUZ,
        [EnumMember(Value = "uz-Latn-UZ")]
        UzLatnUZ,
        [EnumMember(Value = "vai-Latn-LR")]
        VaiLatnLR,
        [EnumMember(Value = "vai-Vaii-LR")]
        VaiVaiiLR,
        [EnumMember(Value = "ve-ZA")]
        VeZA,
        [EnumMember(Value = "vi-VN")]
        ViVN,
        [EnumMember(Value = "vo-001")]
        Vo001,
        [EnumMember(Value = "vun-TZ")]
        VunTZ,
        [EnumMember(Value = "wae-CH")]
        WaeCH,
        [EnumMember(Value = "wal-ET")]
        WalET,
        [EnumMember(Value = "wo-SN")]
        WoSN,
        [EnumMember(Value = "xh-ZA")]
        XhZA,
        [EnumMember(Value = "xog-UG")]
        XogUG,
        [EnumMember(Value = "yav-CM")]
        YavCM,
        [EnumMember(Value = "yi-001")]
        Yi001,
        [EnumMember(Value = "yo-BJ")]
        YoBJ,
        [EnumMember(Value = "yo-NG")]
        YoNG,
        [EnumMember(Value = "zgh-MA")]
        ZghMA,
        [EnumMember(Value = "zh-Hans-CN")]
        ZhHansCN,
        [EnumMember(Value = "zh-Hans-HK")]
        ZhHansHK,
        [EnumMember(Value = "zh-Hans-MO")]
        ZhHansMO,
        [EnumMember(Value = "zh-Hans-SG")]
        ZhHansSG,
        [EnumMember(Value = "zh-Hant-HK")]
        ZhHantHK,
        [EnumMember(Value = "zh-Hant-MO")]
        ZhHantMO,
        [EnumMember(Value = "zh-Hant-TW")]
        ZhHantTW,
        [EnumMember(Value = "zu-ZA")]
        ZuZA
    }

    public class StringResultResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public class BooleanResultResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailsp;

    public partial class WorkflowManagedActions
    {
        public PlumsailspActions Plumsailsp(string connectionId) => new PlumsailspActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlumsailspTriggers Plumsailsp(string connectionId) => new PlumsailspTriggers(connectionId);
    }
}