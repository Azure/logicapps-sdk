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
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsCreateSiteFromTemplate([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requesttemplate, [WorkflowExpression] Func<string> requestleafURL, [WorkflowExpression] Func<string> requestdescription = null, [WorkflowExpression] Func<int> requestlcid = null, [WorkflowExpression] Func<bool> requestinheritPermissions = null, [WorkflowExpression] Func<bool> requestinheritNavigation = null, [WorkflowExpression] Func<bool> requestonTopNavigation = null, [WorkflowExpression] Func<bool> requestonQuickLaunch = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requesttitle, nameof(requesttitle), required: true);
            SourceExpression.Validate(requesttemplate, nameof(requesttemplate), required: true);
            SourceExpression.Validate(requestleafURL, nameof(requestleafURL), required: true);
            SourceExpression.Validate(requestdescription, nameof(requestdescription), required: false);
            SourceExpression.Validate(requestlcid, nameof(requestlcid), required: false);
            SourceExpression.Validate(requestinheritPermissions, nameof(requestinheritPermissions), required: false);
            SourceExpression.Validate(requestinheritNavigation, nameof(requestinheritNavigation), required: false);
            SourceExpression.Validate(requestonTopNavigation, nameof(requestonTopNavigation), required: false);
            SourceExpression.Validate(requestonQuickLaunch, nameof(requestonQuickLaunch), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateSiteFromTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                requestpropCount++;
                request["template"] = SourceExpressionConverter.ConvertToken(requesttemplate);
                requestpropCount++;
                request["leafUrl"] = SourceExpressionConverter.ConvertToken(requestleafURL);
                if (requestdescription != null)
                {
                    request["description"] = SourceExpressionConverter.ConvertToken(requestdescription);
                    requestpropCount++;
                }

                if (requestlcid != null)
                {
                    request["lcid"] = SourceExpressionConverter.ConvertToken(requestlcid);
                    requestpropCount++;
                }

                if (requestinheritPermissions != null)
                {
                    request["inheritPermissions"] = SourceExpressionConverter.ConvertToken(requestinheritPermissions);
                    requestpropCount++;
                }

                if (requestinheritNavigation != null)
                {
                    request["inheritNavigation"] = SourceExpressionConverter.ConvertToken(requestinheritNavigation);
                    requestpropCount++;
                }

                if (requestonTopNavigation != null)
                {
                    request["onTopNav"] = SourceExpressionConverter.ConvertToken(requestonTopNavigation);
                    requestpropCount++;
                }

                if (requestonQuickLaunch != null)
                {
                    request["onQuickLaunch"] = SourceExpressionConverter.ConvertToken(requestonQuickLaunch);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WebUrlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsChangePermissions([WorkflowExpression] Func<actionTypeInput> actionType, [WorkflowExpression] Func<targetInput> target, [WorkflowExpression] Func<object> request = null)
        {
            SourceExpression.Validate(actionType, nameof(actionType), required: true);
            SourceExpression.Validate(target, nameof(target), required: true);
            SourceExpression.Validate(request, nameof(request), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ChangePermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = SourceExpressionConverter.Convert(actionType);
                callPayload.Queries["target"] = SourceExpressionConverter.Convert(target);
                callPayload.Body = SourceExpressionConverter.ConvertToken(request);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsActivateFeature([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfeatureId, [WorkflowExpression] Func<bool> requestforce = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestfeatureId, nameof(requestfeatureId), required: true);
            SourceExpression.Validate(requestforce, nameof(requestforce), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ActivateFeature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["featureId"] = SourceExpressionConverter.ConvertToken(requestfeatureId);
                if (requestforce != null)
                {
                    request["force"] = SourceExpressionConverter.ConvertToken(requestforce);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsDeactivateFeature([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfeatureId, [WorkflowExpression] Func<bool> requestforce = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestfeatureId, nameof(requestfeatureId), required: true);
            SourceExpression.Validate(requestforce, nameof(requestforce), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeactivateFeature";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["featureId"] = SourceExpressionConverter.ConvertToken(requestfeatureId);
                if (requestforce != null)
                {
                    request["force"] = SourceExpressionConverter.ConvertToken(requestforce);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsCreateListOrLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requesttemplate, [WorkflowExpression] Func<string> requestpartialURL = null, [WorkflowExpression] Func<string> requestdescription = null, [WorkflowExpression] Func<bool> requestonQuickLaunch = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requesttitle, nameof(requesttitle), required: true);
            SourceExpression.Validate(requesttemplate, nameof(requesttemplate), required: true);
            SourceExpression.Validate(requestpartialURL, nameof(requestpartialURL), required: false);
            SourceExpression.Validate(requestdescription, nameof(requestdescription), required: false);
            SourceExpression.Validate(requestonQuickLaunch, nameof(requestonQuickLaunch), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateListOrLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                requestpropCount++;
                request["template"] = SourceExpressionConverter.ConvertToken(requesttemplate);
                if (requestpartialURL != null)
                {
                    request["partialUrl"] = SourceExpressionConverter.ConvertToken(requestpartialURL);
                    requestpropCount++;
                }

                if (requestdescription != null)
                {
                    request["description"] = SourceExpressionConverter.ConvertToken(requestdescription);
                    requestpropCount++;
                }

                if (requestonQuickLaunch != null)
                {
                    request["onQuickLaunch"] = SourceExpressionConverter.ConvertToken(requestonQuickLaunch);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsSetDefaultSiteGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<requestgroupTypeInput> requestgroupType, [WorkflowExpression] Func<string> requestgroupName)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupType, nameof(requestgroupType), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/SetDefaultSiteGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupType"] = SourceExpressionConverter.Convert(requestgroupType);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCopyDocumentFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            SourceExpression.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyDocumentFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestsourceURL);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsMoveDocumentFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            SourceExpression.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveDocumentFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestsourceURL);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveDocumentByUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestdocumentURL, nameof(requestdocumentURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveDocumentByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestdocumentURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsCreateDocumentSet([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentSetName, [WorkflowExpression] Func<string> requesttargetList, [WorkflowExpression] Func<string> requestcontentType = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestdocumentSetName, nameof(requestdocumentSetName), required: true);
            SourceExpression.Validate(requesttargetList, nameof(requesttargetList), required: true);
            SourceExpression.Validate(requestcontentType, nameof(requestcontentType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateDocumentSet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["documentSetName"] = SourceExpressionConverter.ConvertToken(requestdocumentSetName);
                requestpropCount++;
                request["targetListUrl"] = SourceExpressionConverter.ConvertToken(requesttargetList);
                if (requestcontentType != null)
                {
                    request["contentType"] = SourceExpressionConverter.ConvertToken(requestcontentType);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentSetInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsCopyDocumentSet([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            SourceExpression.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyDocumentSet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestsourceURL);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentSetInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsMoveDocumentSet([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            SourceExpression.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveDocumentSet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestsourceURL);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentSetInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCreateFolderByUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfolderURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestfolderURL, nameof(requestfolderURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateFolderByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["folderUrl"] = SourceExpressionConverter.ConvertToken(requestfolderURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCreateFolderInList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttargetList, [WorkflowExpression] Func<string> requestfolderPath)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requesttargetList, nameof(requesttargetList), required: true);
            SourceExpression.Validate(requestfolderPath, nameof(requestfolderPath), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateFolderInList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["targetListUrl"] = SourceExpressionConverter.ConvertToken(requesttargetList);
                requestpropCount++;
                request["folderPath"] = SourceExpressionConverter.ConvertToken(requestfolderPath);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveFolderByUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfolderURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestfolderURL, nameof(requestfolderURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveFolderByUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestfolderURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCopyFolderFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            SourceExpression.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyFolderFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestsourceURL);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsMoveFolderFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            SourceExpression.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveFolderFromLibrary";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["sourceUrl"] = SourceExpressionConverter.ConvertToken(requestsourceURL);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FolderInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCheckInDocument([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentURL, [WorkflowExpression] Func<string> requestcomment = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestdocumentURL, nameof(requestdocumentURL), required: true);
            SourceExpression.Validate(requestcomment, nameof(requestcomment), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckInDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["documentUrl"] = SourceExpressionConverter.ConvertToken(requestdocumentURL);
                if (requestcomment != null)
                {
                    request["comment"] = SourceExpressionConverter.ConvertToken(requestcomment);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCheckOutDocument([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestdocumentURL, nameof(requestdocumentURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckOutDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["documentUrl"] = SourceExpressionConverter.ConvertToken(requestdocumentURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsCreateModernSite([WorkflowExpression] Func<siteTypeInput> siteType, [WorkflowExpression] Func<object> request = null)
        {
            SourceExpression.Validate(siteType, nameof(siteType), required: true);
            SourceExpression.Validate(request, nameof(request), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateModernSite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteType"] = SourceExpressionConverter.Convert(siteType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(request);
                return callPayload;
            }

            return new ApiConnectionAction<WebUrlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsApplySiteDesign([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsiteDesign)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestsiteDesign, nameof(requestsiteDesign), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ApplySiteDesign";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["url"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["siteDesign"] = SourceExpressionConverter.ConvertToken(requestsiteDesign);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WebUrlResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsCreateSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestgroupDescription = null, [WorkflowExpression] Func<string> requestgroupOwner = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            SourceExpression.Validate(requestgroupDescription, nameof(requestgroupDescription), required: false);
            SourceExpression.Validate(requestgroupOwner, nameof(requestgroupOwner), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                if (requestgroupDescription != null)
                {
                    request["groupDescription"] = SourceExpressionConverter.ConvertToken(requestgroupDescription);
                    requestpropCount++;
                }

                if (requestgroupOwner != null)
                {
                    request["userLogin"] = SourceExpressionConverter.ConvertToken(requestgroupOwner);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateSharePointGroupProperties([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestpropertiestitle = null, [WorkflowExpression] Func<string> requestpropertiesdescription = null, [WorkflowExpression] Func<string> requestpropertiesowner = null, [WorkflowExpression] Func<bool> requestpropertiesallowMembersEditMembership = null, [WorkflowExpression] Func<bool> requestpropertiesallowRequestToJoinLeave = null, [WorkflowExpression] Func<bool> requestpropertiesautoAcceptRequestToJoinLeave = null, [WorkflowExpression] Func<bool> requestpropertiesonlyAllowMembersViewMembership = null, [WorkflowExpression] Func<string> requestpropertiesrequestToJoinLeaveEmailSetting = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            SourceExpression.Validate(requestpropertiestitle, nameof(requestpropertiestitle), required: false);
            SourceExpression.Validate(requestpropertiesdescription, nameof(requestpropertiesdescription), required: false);
            SourceExpression.Validate(requestpropertiesowner, nameof(requestpropertiesowner), required: false);
            SourceExpression.Validate(requestpropertiesallowMembersEditMembership, nameof(requestpropertiesallowMembersEditMembership), required: false);
            SourceExpression.Validate(requestpropertiesallowRequestToJoinLeave, nameof(requestpropertiesallowRequestToJoinLeave), required: false);
            SourceExpression.Validate(requestpropertiesautoAcceptRequestToJoinLeave, nameof(requestpropertiesautoAcceptRequestToJoinLeave), required: false);
            SourceExpression.Validate(requestpropertiesonlyAllowMembersViewMembership, nameof(requestpropertiesonlyAllowMembersViewMembership), required: false);
            SourceExpression.Validate(requestpropertiesrequestToJoinLeaveEmailSetting, nameof(requestpropertiesrequestToJoinLeaveEmailSetting), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateSharePointGroupProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (requestpropertiestitle != null)
                {
                    propertiesObject["title"] = SourceExpressionConverter.ConvertToken(requestpropertiestitle);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(requestpropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesowner != null)
                {
                    propertiesObject["owner"] = SourceExpressionConverter.ConvertToken(requestpropertiesowner);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesallowMembersEditMembership != null)
                {
                    propertiesObject["allowMembersEditMembership"] = SourceExpressionConverter.ConvertToken(requestpropertiesallowMembersEditMembership);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesallowRequestToJoinLeave != null)
                {
                    propertiesObject["allowRequestToJoinLeave"] = SourceExpressionConverter.ConvertToken(requestpropertiesallowRequestToJoinLeave);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesautoAcceptRequestToJoinLeave != null)
                {
                    propertiesObject["autoAcceptRequestToJoinLeave"] = SourceExpressionConverter.ConvertToken(requestpropertiesautoAcceptRequestToJoinLeave);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesonlyAllowMembersViewMembership != null)
                {
                    propertiesObject["onlyAllowMembersViewMembership"] = SourceExpressionConverter.ConvertToken(requestpropertiesonlyAllowMembersViewMembership);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesrequestToJoinLeaveEmailSetting != null)
                {
                    propertiesObject["requestToJoinLeaveEmailSetting"] = SourceExpressionConverter.ConvertToken(requestpropertiesrequestToJoinLeaveEmailSetting);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<GroupExistResponse> FlowV1SharePointFlowJobsCheckSharePointGroupExists([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CheckSharePointGroupExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GroupExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsAddUserToSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestuser, [WorkflowExpression] Func<bool> requestsendEmail = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            SourceExpression.Validate(requestuser, nameof(requestuser), required: true);
            SourceExpression.Validate(requestsendEmail, nameof(requestsendEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddUserToSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                requestpropCount++;
                request["userLogin"] = SourceExpressionConverter.ConvertToken(requestuser);
                if (requestsendEmail != null)
                {
                    request["sendEmail"] = SourceExpressionConverter.ConvertToken(requestsendEmail);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveUserFromSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestuser)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            SourceExpression.Validate(requestuser, nameof(requestuser), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveUserFromSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                requestpropCount++;
                request["userLogin"] = SourceExpressionConverter.ConvertToken(requestuser);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<GetSPGroupMembersResponse> FlowV1SharePointFlowJobsGetSharePointGroupMembers([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetSharePointGroupMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetSPGroupMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<UserExistsResponse> FlowV1SharePointFlowJobsUserExistInSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestuser)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestgroupName, nameof(requestgroupName), required: true);
            SourceExpression.Validate(requestuser, nameof(requestuser), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UserExistInSharePointGroup";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["groupName"] = SourceExpressionConverter.ConvertToken(requestgroupName);
                requestpropCount++;
                request["userLogin"] = SourceExpressionConverter.ConvertToken(requestuser);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserExistsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateSharePointSiteProperties([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestpropertiestitle = null, [WorkflowExpression] Func<string> requestpropertiesdescription = null, [WorkflowExpression] Func<bool> requestpropertiesquickLaunchEnabled = null, [WorkflowExpression] Func<bool> requestpropertiestreeViewEnabled = null, [WorkflowExpression] Func<string> requestpropertiessiteLogoURL = null, [WorkflowExpression] Func<string> requestpropertiesalternateCssURL = null, [WorkflowExpression] Func<string> requestpropertiesassociatedMemberGroup = null, [WorkflowExpression] Func<string> requestpropertiesassociatedOwnerGroup = null, [WorkflowExpression] Func<string> requestpropertiesassociatedVisitorGroup = null, [WorkflowExpression] Func<bool> requestpropertiescontainsConfidentialInfo = null, [WorkflowExpression] Func<string> requestpropertiescustomMasterURL = null, [WorkflowExpression] Func<bool> requestpropertiesenableMinimalDownload = null, [WorkflowExpression] Func<bool> requestpropertiesisMultilingual = null, [WorkflowExpression] Func<string> requestpropertiesmasterURL = null, [WorkflowExpression] Func<bool> requestpropertiesmembersCanShare = null, [WorkflowExpression] Func<bool> requestpropertiesnoCrawl = null, [WorkflowExpression] Func<bool> requestpropertiesoverwriteTranslationsOnChange = null, [WorkflowExpression] Func<string> requestpropertiesrequestAccessEmail = null, [WorkflowExpression] Func<bool> requestpropertiessaveSiteAsTemplateEnabled = null, [WorkflowExpression] Func<string> requestpropertiesserverRelativeURL = null, [WorkflowExpression] Func<bool> requestpropertiessyndicationEnabled = null, [WorkflowExpression] Func<int> requestpropertiesuIVersion = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestpropertiestitle, nameof(requestpropertiestitle), required: false);
            SourceExpression.Validate(requestpropertiesdescription, nameof(requestpropertiesdescription), required: false);
            SourceExpression.Validate(requestpropertiesquickLaunchEnabled, nameof(requestpropertiesquickLaunchEnabled), required: false);
            SourceExpression.Validate(requestpropertiestreeViewEnabled, nameof(requestpropertiestreeViewEnabled), required: false);
            SourceExpression.Validate(requestpropertiessiteLogoURL, nameof(requestpropertiessiteLogoURL), required: false);
            SourceExpression.Validate(requestpropertiesalternateCssURL, nameof(requestpropertiesalternateCssURL), required: false);
            SourceExpression.Validate(requestpropertiesassociatedMemberGroup, nameof(requestpropertiesassociatedMemberGroup), required: false);
            SourceExpression.Validate(requestpropertiesassociatedOwnerGroup, nameof(requestpropertiesassociatedOwnerGroup), required: false);
            SourceExpression.Validate(requestpropertiesassociatedVisitorGroup, nameof(requestpropertiesassociatedVisitorGroup), required: false);
            SourceExpression.Validate(requestpropertiescontainsConfidentialInfo, nameof(requestpropertiescontainsConfidentialInfo), required: false);
            SourceExpression.Validate(requestpropertiescustomMasterURL, nameof(requestpropertiescustomMasterURL), required: false);
            SourceExpression.Validate(requestpropertiesenableMinimalDownload, nameof(requestpropertiesenableMinimalDownload), required: false);
            SourceExpression.Validate(requestpropertiesisMultilingual, nameof(requestpropertiesisMultilingual), required: false);
            SourceExpression.Validate(requestpropertiesmasterURL, nameof(requestpropertiesmasterURL), required: false);
            SourceExpression.Validate(requestpropertiesmembersCanShare, nameof(requestpropertiesmembersCanShare), required: false);
            SourceExpression.Validate(requestpropertiesnoCrawl, nameof(requestpropertiesnoCrawl), required: false);
            SourceExpression.Validate(requestpropertiesoverwriteTranslationsOnChange, nameof(requestpropertiesoverwriteTranslationsOnChange), required: false);
            SourceExpression.Validate(requestpropertiesrequestAccessEmail, nameof(requestpropertiesrequestAccessEmail), required: false);
            SourceExpression.Validate(requestpropertiessaveSiteAsTemplateEnabled, nameof(requestpropertiessaveSiteAsTemplateEnabled), required: false);
            SourceExpression.Validate(requestpropertiesserverRelativeURL, nameof(requestpropertiesserverRelativeURL), required: false);
            SourceExpression.Validate(requestpropertiessyndicationEnabled, nameof(requestpropertiessyndicationEnabled), required: false);
            SourceExpression.Validate(requestpropertiesuIVersion, nameof(requestpropertiesuIVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateSharePointSiteProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                var propertiesObject = new JObject();
                var propertiesObjectpropCount = 0;
                if (requestpropertiestitle != null)
                {
                    propertiesObject["title"] = SourceExpressionConverter.ConvertToken(requestpropertiestitle);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesdescription != null)
                {
                    propertiesObject["description"] = SourceExpressionConverter.ConvertToken(requestpropertiesdescription);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesquickLaunchEnabled != null)
                {
                    propertiesObject["quickLaunchEnabled"] = SourceExpressionConverter.ConvertToken(requestpropertiesquickLaunchEnabled);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiestreeViewEnabled != null)
                {
                    propertiesObject["treeViewEnabled"] = SourceExpressionConverter.ConvertToken(requestpropertiestreeViewEnabled);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiessiteLogoURL != null)
                {
                    propertiesObject["siteLogoUrl"] = SourceExpressionConverter.ConvertToken(requestpropertiessiteLogoURL);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesalternateCssURL != null)
                {
                    propertiesObject["alternateCssUrl"] = SourceExpressionConverter.ConvertToken(requestpropertiesalternateCssURL);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesassociatedMemberGroup != null)
                {
                    propertiesObject["associatedMemberGroup"] = SourceExpressionConverter.ConvertToken(requestpropertiesassociatedMemberGroup);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesassociatedOwnerGroup != null)
                {
                    propertiesObject["associatedOwnerGroup"] = SourceExpressionConverter.ConvertToken(requestpropertiesassociatedOwnerGroup);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesassociatedVisitorGroup != null)
                {
                    propertiesObject["associatedVisitorGroup"] = SourceExpressionConverter.ConvertToken(requestpropertiesassociatedVisitorGroup);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiescontainsConfidentialInfo != null)
                {
                    propertiesObject["containsConfidentialInfo"] = SourceExpressionConverter.ConvertToken(requestpropertiescontainsConfidentialInfo);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiescustomMasterURL != null)
                {
                    propertiesObject["customMasterUrl"] = SourceExpressionConverter.ConvertToken(requestpropertiescustomMasterURL);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesenableMinimalDownload != null)
                {
                    propertiesObject["enableMinimalDownload"] = SourceExpressionConverter.ConvertToken(requestpropertiesenableMinimalDownload);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesisMultilingual != null)
                {
                    propertiesObject["isMultilingual"] = SourceExpressionConverter.ConvertToken(requestpropertiesisMultilingual);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesmasterURL != null)
                {
                    propertiesObject["masterUrl"] = SourceExpressionConverter.ConvertToken(requestpropertiesmasterURL);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesmembersCanShare != null)
                {
                    propertiesObject["membersCanShare"] = SourceExpressionConverter.ConvertToken(requestpropertiesmembersCanShare);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesnoCrawl != null)
                {
                    propertiesObject["noCrawl"] = SourceExpressionConverter.ConvertToken(requestpropertiesnoCrawl);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesoverwriteTranslationsOnChange != null)
                {
                    propertiesObject["overwriteTranslationsOnChange"] = SourceExpressionConverter.ConvertToken(requestpropertiesoverwriteTranslationsOnChange);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesrequestAccessEmail != null)
                {
                    propertiesObject["requestAccessEmail"] = SourceExpressionConverter.ConvertToken(requestpropertiesrequestAccessEmail);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiessaveSiteAsTemplateEnabled != null)
                {
                    propertiesObject["saveSiteAsTemplateEnabled"] = SourceExpressionConverter.ConvertToken(requestpropertiessaveSiteAsTemplateEnabled);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesserverRelativeURL != null)
                {
                    propertiesObject["serverRelativeUrl"] = SourceExpressionConverter.ConvertToken(requestpropertiesserverRelativeURL);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiessyndicationEnabled != null)
                {
                    propertiesObject["syndicationEnabled"] = SourceExpressionConverter.ConvertToken(requestpropertiessyndicationEnabled);
                    propertiesObjectpropCount++;
                }

                if (requestpropertiesuIVersion != null)
                {
                    propertiesObject["uiVersion"] = SourceExpressionConverter.ConvertToken(requestpropertiesuIVersion);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsDeleteSharePointSite([WorkflowExpression] Func<string> requestsharePointSiteURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeleteSharePointSite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<SPSiteOptionValueResponse> FlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsString([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestoptionName)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestoptionName, nameof(requestoptionName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetSharePointSiteOptionValueAsString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["optionName"] = SourceExpressionConverter.ConvertToken(requestoptionName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SPSiteOptionValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsInviteExternalUserToSharePoint([WorkflowExpression] Func<targetInput> target, [WorkflowExpression] Func<object> request = null)
        {
            SourceExpression.Validate(target, nameof(target), required: true);
            SourceExpression.Validate(request, nameof(request), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/InviteExternalUserToSharePoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["target"] = SourceExpressionConverter.Convert(target);
                callPayload.Body = SourceExpressionConverter.ConvertToken(request);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListFileUrlsResponse> FlowV1SharePointFlowJobsCopyAttachmentsToUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemId, [WorkflowExpression] Func<string> requestdestinationFolderURL, [WorkflowExpression] Func<bool> requestoverwrite = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestitemId, nameof(requestitemId), required: true);
            SourceExpression.Validate(requestdestinationFolderURL, nameof(requestdestinationFolderURL), required: true);
            SourceExpression.Validate(requestoverwrite, nameof(requestoverwrite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyAttachmentsToUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemId);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationFolderURL);
                if (requestoverwrite != null)
                {
                    request["overwrite"] = SourceExpressionConverter.ConvertToken(requestoverwrite);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListFileUrlsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListFileUrlsResponse> FlowV1SharePointFlowJobsMoveAttachmentsToUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemId, [WorkflowExpression] Func<string> requestdestinationFolderURL, [WorkflowExpression] Func<bool> requestoverwrite = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestitemId, nameof(requestitemId), required: true);
            SourceExpression.Validate(requestdestinationFolderURL, nameof(requestdestinationFolderURL), required: true);
            SourceExpression.Validate(requestoverwrite, nameof(requestoverwrite), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveAttachmentsToUrl";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemId);
                requestpropCount++;
                request["destinationUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationFolderURL);
                if (requestoverwrite != null)
                {
                    request["overwrite"] = SourceExpressionConverter.ConvertToken(requestoverwrite);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListFileUrlsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsAddContentTypeToSharePointList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestcontentTypeName, [WorkflowExpression] Func<bool> requestmakeItDefault = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestcontentTypeName, nameof(requestcontentTypeName), required: true);
            SourceExpression.Validate(requestmakeItDefault, nameof(requestmakeItDefault), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddContentTypeToSharePointList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                requestpropCount++;
                request["contentTypeName"] = SourceExpressionConverter.ConvertToken(requestcontentTypeName);
                if (requestmakeItDefault != null)
                {
                    request["makeItDefault"] = SourceExpressionConverter.ConvertToken(requestmakeItDefault);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListItemIdResponse> FlowV1SharePointFlowJobsCopyListItemToSharePointList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestitemId, [WorkflowExpression] Func<string> requestdestinationListURL, [WorkflowExpression] Func<bool> requestcopyAttachments = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestitemId, nameof(requestitemId), required: true);
            SourceExpression.Validate(requestdestinationListURL, nameof(requestdestinationListURL), required: true);
            SourceExpression.Validate(requestcopyAttachments, nameof(requestcopyAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CopyListItemToSharePointList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemId);
                requestpropCount++;
                request["destinationListUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationListURL);
                if (requestcopyAttachments != null)
                {
                    request["copyAttachments"] = SourceExpressionConverter.ConvertToken(requestcopyAttachments);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListItemIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<ListItemIdResponse> FlowV1SharePointFlowJobsMoveListItemToSharePointList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestitemId, [WorkflowExpression] Func<string> requestdestinationListURL, [WorkflowExpression] Func<bool> requestmoveAttachments = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestitemId, nameof(requestitemId), required: true);
            SourceExpression.Validate(requestdestinationListURL, nameof(requestdestinationListURL), required: true);
            SourceExpression.Validate(requestmoveAttachments, nameof(requestmoveAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/MoveListItemToSharePointList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemId);
                requestpropCount++;
                request["destinationListUrl"] = SourceExpressionConverter.ConvertToken(requestdestinationListURL);
                if (requestmoveAttachments != null)
                {
                    request["copyAttachments"] = SourceExpressionConverter.ConvertToken(requestmoveAttachments);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ListItemIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WorkflowGuidResponse> FlowV1SharePointFlowJobsStartListWorkflow([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestworkflowName, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemId)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestworkflowName, nameof(requestworkflowName), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestitemId, nameof(requestitemId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/StartListWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["workflowName"] = SourceExpressionConverter.ConvertToken(requestworkflowName);
                var inputParametersObject = new JObject();
                var inputParametersObjectpropCount = 0;
                if (inputParametersObjectpropCount > 0)
                {
                    request["inputParameters"] = inputParametersObject;
                    requestpropCount++;
                }

                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemId);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowGuidResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<WorkflowGuidResponse> FlowV1SharePointFlowJobsStartSiteWorkflow([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestworkflowName)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestworkflowName, nameof(requestworkflowName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/StartSiteWorkflow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["workflowName"] = SourceExpressionConverter.ConvertToken(requestworkflowName);
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
                return callPayload;
            }

            return new ApiConnectionAction<WorkflowGuidResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsGetItemsByCamlQuery([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestcAMLQuery, [WorkflowExpression] Func<string> requestfolderURL = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestcAMLQuery, nameof(requestcAMLQuery), required: true);
            SourceExpression.Validate(requestfolderURL, nameof(requestfolderURL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetItemsByCamlQuery";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                if (requestfolderURL != null)
                {
                    request["folderUrl"] = SourceExpressionConverter.ConvertToken(requestfolderURL);
                    requestpropCount++;
                }

                requestpropCount++;
                request["camlQuery"] = SourceExpressionConverter.ConvertToken(requestcAMLQuery);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<VersionsHistoryResponse> FlowV1SharePointFlowJobsGetVersionsHistory([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemId, [WorkflowExpression] Func<string> requestfieldName)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistURL, nameof(requestlistURL), required: true);
            SourceExpression.Validate(requestitemId, nameof(requestitemId), required: true);
            SourceExpression.Validate(requestfieldName, nameof(requestfieldName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/GetVersionsHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listUrl"] = SourceExpressionConverter.ConvertToken(requestlistURL);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemId);
                requestpropCount++;
                request["fieldName"] = SourceExpressionConverter.ConvertToken(requestfieldName);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<VersionsHistoryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsProvisionPnPTemplate([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttemplateContent, [WorkflowExpression] Func<bool> requestoverwriteSystemPropertyBagValues = null, [WorkflowExpression] Func<bool> requestignoreDuplicateDataRowErrors = null, [WorkflowExpression] Func<bool> requestclearNavigation = null, [WorkflowExpression] Func<bool> requestprovisionContentTypesToSubWebs = null, [WorkflowExpression] Func<bool> requestprovisionFieldsToSubWebs = null, [WorkflowExpression] Func<string> requesthandlers = null, [WorkflowExpression] Func<string> requestexcludeHandlers = null, [WorkflowExpression] Func<string> requestparameters = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requesttemplateContent, nameof(requesttemplateContent), required: true);
            SourceExpression.Validate(requestoverwriteSystemPropertyBagValues, nameof(requestoverwriteSystemPropertyBagValues), required: false);
            SourceExpression.Validate(requestignoreDuplicateDataRowErrors, nameof(requestignoreDuplicateDataRowErrors), required: false);
            SourceExpression.Validate(requestclearNavigation, nameof(requestclearNavigation), required: false);
            SourceExpression.Validate(requestprovisionContentTypesToSubWebs, nameof(requestprovisionContentTypesToSubWebs), required: false);
            SourceExpression.Validate(requestprovisionFieldsToSubWebs, nameof(requestprovisionFieldsToSubWebs), required: false);
            SourceExpression.Validate(requesthandlers, nameof(requesthandlers), required: false);
            SourceExpression.Validate(requestexcludeHandlers, nameof(requestexcludeHandlers), required: false);
            SourceExpression.Validate(requestparameters, nameof(requestparameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ProvisionPnPTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["xmlTemplateContent"] = SourceExpressionConverter.ConvertToken(requesttemplateContent);
                if (requestoverwriteSystemPropertyBagValues != null)
                {
                    request["overwriteSystemPropertyBagValues"] = SourceExpressionConverter.ConvertToken(requestoverwriteSystemPropertyBagValues);
                    requestpropCount++;
                }

                if (requestignoreDuplicateDataRowErrors != null)
                {
                    request["ignoreDuplicateDataRowErrors"] = SourceExpressionConverter.ConvertToken(requestignoreDuplicateDataRowErrors);
                    requestpropCount++;
                }

                if (requestclearNavigation != null)
                {
                    request["clearNavigation"] = SourceExpressionConverter.ConvertToken(requestclearNavigation);
                    requestpropCount++;
                }

                if (requestprovisionContentTypesToSubWebs != null)
                {
                    request["provisionContentTypesToSubWebs"] = SourceExpressionConverter.ConvertToken(requestprovisionContentTypesToSubWebs);
                    requestpropCount++;
                }

                if (requestprovisionFieldsToSubWebs != null)
                {
                    request["provisionFieldsToSubWebs"] = SourceExpressionConverter.ConvertToken(requestprovisionFieldsToSubWebs);
                    requestpropCount++;
                }

                if (requesthandlers != null)
                {
                    request["handlers"] = SourceExpressionConverter.ConvertToken(requesthandlers);
                    requestpropCount++;
                }

                if (requestexcludeHandlers != null)
                {
                    request["excludeHandlers"] = SourceExpressionConverter.ConvertToken(requestexcludeHandlers);
                    requestpropCount++;
                }

                if (requestparameters != null)
                {
                    request["parameters"] = SourceExpressionConverter.ConvertToken(requestparameters);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsProvisionPnPTenantTemplate([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttemplateContent, [WorkflowExpression] Func<bool> requestoverwriteSystemPropertyBagValues = null, [WorkflowExpression] Func<bool> requestignoreDuplicateDataRowErrors = null, [WorkflowExpression] Func<bool> requestclearNavigation = null, [WorkflowExpression] Func<bool> requestprovisionContentTypesToSubWebs = null, [WorkflowExpression] Func<bool> requestprovisionFieldsToSubWebs = null, [WorkflowExpression] Func<string> requesthandlers = null, [WorkflowExpression] Func<string> requestexcludeHandlers = null, [WorkflowExpression] Func<string> requestparameters = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requesttemplateContent, nameof(requesttemplateContent), required: true);
            SourceExpression.Validate(requestoverwriteSystemPropertyBagValues, nameof(requestoverwriteSystemPropertyBagValues), required: false);
            SourceExpression.Validate(requestignoreDuplicateDataRowErrors, nameof(requestignoreDuplicateDataRowErrors), required: false);
            SourceExpression.Validate(requestclearNavigation, nameof(requestclearNavigation), required: false);
            SourceExpression.Validate(requestprovisionContentTypesToSubWebs, nameof(requestprovisionContentTypesToSubWebs), required: false);
            SourceExpression.Validate(requestprovisionFieldsToSubWebs, nameof(requestprovisionFieldsToSubWebs), required: false);
            SourceExpression.Validate(requesthandlers, nameof(requesthandlers), required: false);
            SourceExpression.Validate(requestexcludeHandlers, nameof(requestexcludeHandlers), required: false);
            SourceExpression.Validate(requestparameters, nameof(requestparameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ProvisionPnPTenantTemplate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["xmlTemplateContent"] = SourceExpressionConverter.ConvertToken(requesttemplateContent);
                if (requestoverwriteSystemPropertyBagValues != null)
                {
                    request["overwriteSystemPropertyBagValues"] = SourceExpressionConverter.ConvertToken(requestoverwriteSystemPropertyBagValues);
                    requestpropCount++;
                }

                if (requestignoreDuplicateDataRowErrors != null)
                {
                    request["ignoreDuplicateDataRowErrors"] = SourceExpressionConverter.ConvertToken(requestignoreDuplicateDataRowErrors);
                    requestpropCount++;
                }

                if (requestclearNavigation != null)
                {
                    request["clearNavigation"] = SourceExpressionConverter.ConvertToken(requestclearNavigation);
                    requestpropCount++;
                }

                if (requestprovisionContentTypesToSubWebs != null)
                {
                    request["provisionContentTypesToSubWebs"] = SourceExpressionConverter.ConvertToken(requestprovisionContentTypesToSubWebs);
                    requestpropCount++;
                }

                if (requestprovisionFieldsToSubWebs != null)
                {
                    request["provisionFieldsToSubWebs"] = SourceExpressionConverter.ConvertToken(requestprovisionFieldsToSubWebs);
                    requestpropCount++;
                }

                if (requesthandlers != null)
                {
                    request["handlers"] = SourceExpressionConverter.ConvertToken(requesthandlers);
                    requestpropCount++;
                }

                if (requestexcludeHandlers != null)
                {
                    request["excludeHandlers"] = SourceExpressionConverter.ConvertToken(requestexcludeHandlers);
                    requestpropCount++;
                }

                if (requestparameters != null)
                {
                    request["parameters"] = SourceExpressionConverter.ConvertToken(requestparameters);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsAddSiteNavigation([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<requestlocationInput> requestlocation, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requestparent = null, [WorkflowExpression] Func<string> requesturl = null, [WorkflowExpression] Func<bool> requestprepend = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlocation, nameof(requestlocation), required: true);
            SourceExpression.Validate(requesttitle, nameof(requesttitle), required: true);
            SourceExpression.Validate(requestparent, nameof(requestparent), required: false);
            SourceExpression.Validate(requesturl, nameof(requesturl), required: false);
            SourceExpression.Validate(requestprepend, nameof(requestprepend), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/AddSiteNavigation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["location"] = SourceExpressionConverter.Convert(requestlocation);
                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                if (requestparent != null)
                {
                    request["parent"] = SourceExpressionConverter.ConvertToken(requestparent);
                    requestpropCount++;
                }

                if (requesturl != null)
                {
                    request["url"] = SourceExpressionConverter.ConvertToken(requesturl);
                    requestpropCount++;
                }

                if (requestprepend != null)
                {
                    request["prepend"] = SourceExpressionConverter.ConvertToken(requestprepend);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveSiteNavigation([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<requestlocationInput> requestlocation, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requestparent = null)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlocation, nameof(requestlocation), required: true);
            SourceExpression.Validate(requesttitle, nameof(requesttitle), required: true);
            SourceExpression.Validate(requestparent, nameof(requestparent), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RemoveSiteNavigation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["location"] = SourceExpressionConverter.Convert(requestlocation);
                requestpropCount++;
                request["title"] = SourceExpressionConverter.ConvertToken(requesttitle);
                if (requestparent != null)
                {
                    request["parent"] = SourceExpressionConverter.ConvertToken(requestparent);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateListItem([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistName, [WorkflowExpression] Func<string> requestitemIdOrURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistName, nameof(requestlistName), required: true);
            SourceExpression.Validate(requestitemIdOrURL, nameof(requestitemIdOrURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UpdateListItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listName"] = SourceExpressionConverter.ConvertToken(requestlistName);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemIdOrURL);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsDeclareDocumentAsRecord([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistName, [WorkflowExpression] Func<string> requestitemIdOrURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistName, nameof(requestlistName), required: true);
            SourceExpression.Validate(requestitemIdOrURL, nameof(requestitemIdOrURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/DeclareDocumentAsRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listName"] = SourceExpressionConverter.ConvertToken(requestlistName);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemIdOrURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IWorkflowAction FlowV1SharePointFlowJobsUndeclareDocumentAsRecord([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistName, [WorkflowExpression] Func<string> requestitemIdOrURL)
        {
            SourceExpression.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            SourceExpression.Validate(requestlistName, nameof(requestlistName), required: true);
            SourceExpression.Validate(requestitemIdOrURL, nameof(requestitemIdOrURL), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/UndeclareDocumentAsRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["spUrl"] = SourceExpressionConverter.ConvertToken(requestsharePointSiteURL);
                requestpropCount++;
                request["listName"] = SourceExpressionConverter.ConvertToken(requestlistName);
                requestpropCount++;
                request["itemId"] = SourceExpressionConverter.ConvertToken(requestitemIdOrURL);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsParseCsv([WorkflowExpression] Func<string> requestcontentOfCSVDocument, [WorkflowExpression] Func<string> requestheaders, [WorkflowExpression] Func<requestdelimiterInput> requestdelimiter = null, [WorkflowExpression] Func<requestlocaleInput> requestlocale = null, [WorkflowExpression] Func<int> requestlimit = null, [WorkflowExpression] Func<bool> requestskipFirstLine = null)
        {
            SourceExpression.Validate(requestcontentOfCSVDocument, nameof(requestcontentOfCSVDocument), required: true);
            SourceExpression.Validate(requestheaders, nameof(requestheaders), required: true);
            SourceExpression.Validate(requestdelimiter, nameof(requestdelimiter), required: false);
            SourceExpression.Validate(requestlocale, nameof(requestlocale), required: false);
            SourceExpression.Validate(requestlimit, nameof(requestlimit), required: false);
            SourceExpression.Validate(requestskipFirstLine, nameof(requestskipFirstLine), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ParseCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["content"] = SourceExpressionConverter.ConvertToken(requestcontentOfCSVDocument);
                if (requestdelimiter != null)
                {
                    request["delimiter"] = SourceExpressionConverter.Convert(requestdelimiter);
                    requestpropCount++;
                }

                if (requestlocale != null)
                {
                    if (requestlocale != null)
                    {
                        request["locale"] = SourceExpressionConverter.Convert(requestlocale);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["locale"] = "en-US";
                    requestpropCount++;
                }

                if (requestlimit != null)
                {
                    request["limit"] = SourceExpressionConverter.ConvertToken(requestlimit);
                    requestpropCount++;
                }

                requestpropCount++;
                request["headers"] = SourceExpressionConverter.ConvertToken(requestheaders);
                if (requestskipFirstLine != null)
                {
                    request["skipFirstLine"] = SourceExpressionConverter.ConvertToken(requestskipFirstLine);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsRegExpMatch([WorkflowExpression] Func<string> requestpattern, [WorkflowExpression] Func<string> requesttext)
        {
            SourceExpression.Validate(requestpattern, nameof(requestpattern), required: true);
            SourceExpression.Validate(requesttext, nameof(requesttext), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpMatch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["pattern"] = SourceExpressionConverter.ConvertToken(requestpattern);
                requestpropCount++;
                request["text"] = SourceExpressionConverter.ConvertToken(requesttext);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<StringResultResponse> FlowV1SharePointFlowJobsRegExpReplace([WorkflowExpression] Func<string> requestpattern, [WorkflowExpression] Func<string> requesttext, [WorkflowExpression] Func<string> requestreplacement = null)
        {
            SourceExpression.Validate(requestpattern, nameof(requestpattern), required: true);
            SourceExpression.Validate(requesttext, nameof(requesttext), required: true);
            SourceExpression.Validate(requestreplacement, nameof(requestreplacement), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpReplace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["pattern"] = SourceExpressionConverter.ConvertToken(requestpattern);
                requestpropCount++;
                request["text"] = SourceExpressionConverter.ConvertToken(requesttext);
                if (requestreplacement != null)
                {
                    request["replacement"] = SourceExpressionConverter.ConvertToken(requestreplacement);
                    requestpropCount++;
                }

                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<StringResultResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        public IBodyWorkflowAction<BooleanResultResponse> FlowV1SharePointFlowJobsRegExpTest([WorkflowExpression] Func<string> requestpattern, [WorkflowExpression] Func<string> requesttext)
        {
            SourceExpression.Validate(requestpattern, nameof(requestpattern), required: true);
            SourceExpression.Validate(requesttext, nameof(requesttext), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/RegExpTest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                requestpropCount++;
                request["pattern"] = SourceExpressionConverter.ConvertToken(requestpattern);
                requestpropCount++;
                request["text"] = SourceExpressionConverter.ConvertToken(requesttext);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BooleanResultResponse>(BuildSourceInput);
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
        IdId,
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
        JvId,
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