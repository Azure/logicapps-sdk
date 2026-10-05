//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Plumsailsp
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlumsailspActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCreateSiteFromTemplate))]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsCreateSiteFromTemplate([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requesttemplate, [WorkflowExpression] Func<string> requestleafURL, [WorkflowExpression] Func<string> requestdescription = null, [WorkflowExpression] Func<int> requestlcid = null, [WorkflowExpression] Func<bool> requestinheritPermissions = null, [WorkflowExpression] Func<bool> requestinheritNavigation = null, [WorkflowExpression] Func<bool> requestonTopNavigation = null, [WorkflowExpression] Func<bool> requestonQuickLaunch = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebUrlResponse> __BuildFlowV1SharePointFlowJobsCreateSiteFromTemplate(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requesttitle, WorkflowValue<string> requesttemplate, WorkflowValue<string> requestleafURL, WorkflowValue<string> requestdescription = null, WorkflowValue<int> requestlcid = null, WorkflowValue<bool> requestinheritPermissions = null, WorkflowValue<bool> requestinheritNavigation = null, WorkflowValue<bool> requestonTopNavigation = null, WorkflowValue<bool> requestonQuickLaunch = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requesttitle, nameof(requesttitle), required: true);
            WorkflowValue.Validate(requesttemplate, nameof(requesttemplate), required: true);
            WorkflowValue.Validate(requestleafURL, nameof(requestleafURL), required: true);
            WorkflowValue.Validate(requestdescription, nameof(requestdescription), required: false);
            WorkflowValue.Validate(requestlcid, nameof(requestlcid), required: false);
            WorkflowValue.Validate(requestinheritPermissions, nameof(requestinheritPermissions), required: false);
            WorkflowValue.Validate(requestinheritNavigation, nameof(requestinheritNavigation), required: false);
            WorkflowValue.Validate(requestonTopNavigation, nameof(requestonTopNavigation), required: false);
            WorkflowValue.Validate(requestonQuickLaunch, nameof(requestonQuickLaunch), required: false);
            return new DeferredBodyAction<WebUrlResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsChangePermissions))]
        public IWorkflowAction FlowV1SharePointFlowJobsChangePermissions([WorkflowExpression] Func<actionTypeInput> actionType, [WorkflowExpression] Func<targetInput> target, [WorkflowExpression] Func<object> request = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsChangePermissions(WorkflowValue<actionTypeInput> actionType, WorkflowValue<targetInput> target, WorkflowValue<object> request = null)
        {
            WorkflowValue.Validate(actionType, nameof(actionType), required: true);
            WorkflowValue.Validate(target, nameof(target), required: true);
            WorkflowValue.Validate(request, nameof(request), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/ChangePermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["actionType"] = ExpressionConverter.Convert(actionType);
                callPayload.Queries["target"] = ExpressionConverter.Convert(target);
                callPayload.Body = ExpressionConverter.ConvertO(request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsActivateFeature))]
        public IWorkflowAction FlowV1SharePointFlowJobsActivateFeature([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfeatureID, [WorkflowExpression] Func<bool> requestforce = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsActivateFeature(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestfeatureID, WorkflowValue<bool> requestforce = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestfeatureID, nameof(requestfeatureID), required: true);
            WorkflowValue.Validate(requestforce, nameof(requestforce), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsDeactivateFeature))]
        public IWorkflowAction FlowV1SharePointFlowJobsDeactivateFeature([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfeatureID, [WorkflowExpression] Func<bool> requestforce = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsDeactivateFeature(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestfeatureID, WorkflowValue<bool> requestforce = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestfeatureID, nameof(requestfeatureID), required: true);
            WorkflowValue.Validate(requestforce, nameof(requestforce), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCreateListOrLibrary))]
        public IWorkflowAction FlowV1SharePointFlowJobsCreateListOrLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requesttemplate, [WorkflowExpression] Func<string> requestpartialURL = null, [WorkflowExpression] Func<string> requestdescription = null, [WorkflowExpression] Func<bool> requestonQuickLaunch = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsCreateListOrLibrary(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requesttitle, WorkflowValue<string> requesttemplate, WorkflowValue<string> requestpartialURL = null, WorkflowValue<string> requestdescription = null, WorkflowValue<bool> requestonQuickLaunch = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requesttitle, nameof(requesttitle), required: true);
            WorkflowValue.Validate(requesttemplate, nameof(requesttemplate), required: true);
            WorkflowValue.Validate(requestpartialURL, nameof(requestpartialURL), required: false);
            WorkflowValue.Validate(requestdescription, nameof(requestdescription), required: false);
            WorkflowValue.Validate(requestonQuickLaunch, nameof(requestonQuickLaunch), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsSetDefaultSiteGroup))]
        public IWorkflowAction FlowV1SharePointFlowJobsSetDefaultSiteGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<requestgroupTypeInput> requestgroupType, [WorkflowExpression] Func<string> requestgroupName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsSetDefaultSiteGroup(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<requestgroupTypeInput> requestgroupType, WorkflowValue<string> requestgroupName)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupType, nameof(requestgroupType), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCopyDocumentFromLibrary))]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCopyDocumentFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentInfoResponse> __BuildFlowV1SharePointFlowJobsCopyDocumentFromLibrary(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestsourceURL, WorkflowValue<string> requestdestinationURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            WorkflowValue.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            return new DeferredBodyAction<DocumentInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsMoveDocumentFromLibrary))]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsMoveDocumentFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentInfoResponse> __BuildFlowV1SharePointFlowJobsMoveDocumentFromLibrary(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestsourceURL, WorkflowValue<string> requestdestinationURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            WorkflowValue.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            return new DeferredBodyAction<DocumentInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRemoveDocumentByUrl))]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveDocumentByUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsRemoveDocumentByUrl(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestdocumentURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestdocumentURL, nameof(requestdocumentURL), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCreateDocumentSet))]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsCreateDocumentSet([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentSetName, [WorkflowExpression] Func<string> requesttargetList, [WorkflowExpression] Func<string> requestcontentType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentSetInfoResponse> __BuildFlowV1SharePointFlowJobsCreateDocumentSet(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestdocumentSetName, WorkflowValue<string> requesttargetList, WorkflowValue<string> requestcontentType = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestdocumentSetName, nameof(requestdocumentSetName), required: true);
            WorkflowValue.Validate(requesttargetList, nameof(requesttargetList), required: true);
            WorkflowValue.Validate(requestcontentType, nameof(requestcontentType), required: false);
            return new DeferredBodyAction<DocumentSetInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCopyDocumentSet))]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsCopyDocumentSet([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentSetInfoResponse> __BuildFlowV1SharePointFlowJobsCopyDocumentSet(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestsourceURL, WorkflowValue<string> requestdestinationURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            WorkflowValue.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            return new DeferredBodyAction<DocumentSetInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsMoveDocumentSet))]
        public IBodyWorkflowAction<DocumentSetInfoResponse> FlowV1SharePointFlowJobsMoveDocumentSet([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentSetInfoResponse> __BuildFlowV1SharePointFlowJobsMoveDocumentSet(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestsourceURL, WorkflowValue<string> requestdestinationURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            WorkflowValue.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            return new DeferredBodyAction<DocumentSetInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCreateFolderByUrl))]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCreateFolderByUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfolderURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FolderInfoResponse> __BuildFlowV1SharePointFlowJobsCreateFolderByUrl(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestfolderURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestfolderURL, nameof(requestfolderURL), required: true);
            return new DeferredBodyAction<FolderInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCreateFolderInList))]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCreateFolderInList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttargetList, [WorkflowExpression] Func<string> requestfolderPath)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FolderInfoResponse> __BuildFlowV1SharePointFlowJobsCreateFolderInList(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requesttargetList, WorkflowValue<string> requestfolderPath)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requesttargetList, nameof(requesttargetList), required: true);
            WorkflowValue.Validate(requestfolderPath, nameof(requestfolderPath), required: true);
            return new DeferredBodyAction<FolderInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRemoveFolderByUrl))]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveFolderByUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestfolderURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsRemoveFolderByUrl(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestfolderURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestfolderURL, nameof(requestfolderURL), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCopyFolderFromLibrary))]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsCopyFolderFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FolderInfoResponse> __BuildFlowV1SharePointFlowJobsCopyFolderFromLibrary(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestsourceURL, WorkflowValue<string> requestdestinationURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            WorkflowValue.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            return new DeferredBodyAction<FolderInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsMoveFolderFromLibrary))]
        public IBodyWorkflowAction<FolderInfoResponse> FlowV1SharePointFlowJobsMoveFolderFromLibrary([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsourceURL, [WorkflowExpression] Func<string> requestdestinationURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FolderInfoResponse> __BuildFlowV1SharePointFlowJobsMoveFolderFromLibrary(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestsourceURL, WorkflowValue<string> requestdestinationURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestsourceURL, nameof(requestsourceURL), required: true);
            WorkflowValue.Validate(requestdestinationURL, nameof(requestdestinationURL), required: true);
            return new DeferredBodyAction<FolderInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCheckInDocument))]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCheckInDocument([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentURL, [WorkflowExpression] Func<string> requestcomment = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentInfoResponse> __BuildFlowV1SharePointFlowJobsCheckInDocument(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestdocumentURL, WorkflowValue<string> requestcomment = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestdocumentURL, nameof(requestdocumentURL), required: true);
            WorkflowValue.Validate(requestcomment, nameof(requestcomment), required: false);
            return new DeferredBodyAction<DocumentInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCheckOutDocument))]
        public IBodyWorkflowAction<DocumentInfoResponse> FlowV1SharePointFlowJobsCheckOutDocument([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestdocumentURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DocumentInfoResponse> __BuildFlowV1SharePointFlowJobsCheckOutDocument(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestdocumentURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestdocumentURL, nameof(requestdocumentURL), required: true);
            return new DeferredBodyAction<DocumentInfoResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCreateModernSite))]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsCreateModernSite([WorkflowExpression] Func<siteTypeInput> siteType, [WorkflowExpression] Func<object> request = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebUrlResponse> __BuildFlowV1SharePointFlowJobsCreateModernSite(WorkflowValue<siteTypeInput> siteType, WorkflowValue<object> request = null)
        {
            WorkflowValue.Validate(siteType, nameof(siteType), required: true);
            WorkflowValue.Validate(request, nameof(request), required: false);
            return new DeferredBodyAction<WebUrlResponse>(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/CreateModernSite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["siteType"] = ExpressionConverter.Convert(siteType);
                callPayload.Body = ExpressionConverter.ConvertO(request);
                return new ApiConnectionAction<WebUrlResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsApplySiteDesign))]
        public IBodyWorkflowAction<WebUrlResponse> FlowV1SharePointFlowJobsApplySiteDesign([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestsiteDesign)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WebUrlResponse> __BuildFlowV1SharePointFlowJobsApplySiteDesign(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestsiteDesign)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestsiteDesign, nameof(requestsiteDesign), required: true);
            return new DeferredBodyAction<WebUrlResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCreateSharePointGroup))]
        public IWorkflowAction FlowV1SharePointFlowJobsCreateSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestgroupDescription = null, [WorkflowExpression] Func<string> requestgroupOwner = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsCreateSharePointGroup(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName, WorkflowValue<string> requestgroupDescription = null, WorkflowValue<string> requestgroupOwner = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            WorkflowValue.Validate(requestgroupDescription, nameof(requestgroupDescription), required: false);
            WorkflowValue.Validate(requestgroupOwner, nameof(requestgroupOwner), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRemoveSharePointGroup))]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsRemoveSharePointGroup(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsUpdateSharePointGroupProperties))]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateSharePointGroupProperties([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestpropertiestitle = null, [WorkflowExpression] Func<string> requestpropertiesdescription = null, [WorkflowExpression] Func<string> requestpropertiesowner = null, [WorkflowExpression] Func<bool> requestpropertiesallowMembersEditMembership = null, [WorkflowExpression] Func<bool> requestpropertiesallowRequestToJoinLeave = null, [WorkflowExpression] Func<bool> requestpropertiesautoAcceptRequestToJoinLeave = null, [WorkflowExpression] Func<bool> requestpropertiesonlyAllowMembersViewMembership = null, [WorkflowExpression] Func<string> requestpropertiesrequestToJoinLeaveEmailSetting = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsUpdateSharePointGroupProperties(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName, WorkflowValue<string> requestpropertiestitle = null, WorkflowValue<string> requestpropertiesdescription = null, WorkflowValue<string> requestpropertiesowner = null, WorkflowValue<bool> requestpropertiesallowMembersEditMembership = null, WorkflowValue<bool> requestpropertiesallowRequestToJoinLeave = null, WorkflowValue<bool> requestpropertiesautoAcceptRequestToJoinLeave = null, WorkflowValue<bool> requestpropertiesonlyAllowMembersViewMembership = null, WorkflowValue<string> requestpropertiesrequestToJoinLeaveEmailSetting = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            WorkflowValue.Validate(requestpropertiestitle, nameof(requestpropertiestitle), required: false);
            WorkflowValue.Validate(requestpropertiesdescription, nameof(requestpropertiesdescription), required: false);
            WorkflowValue.Validate(requestpropertiesowner, nameof(requestpropertiesowner), required: false);
            WorkflowValue.Validate(requestpropertiesallowMembersEditMembership, nameof(requestpropertiesallowMembersEditMembership), required: false);
            WorkflowValue.Validate(requestpropertiesallowRequestToJoinLeave, nameof(requestpropertiesallowRequestToJoinLeave), required: false);
            WorkflowValue.Validate(requestpropertiesautoAcceptRequestToJoinLeave, nameof(requestpropertiesautoAcceptRequestToJoinLeave), required: false);
            WorkflowValue.Validate(requestpropertiesonlyAllowMembersViewMembership, nameof(requestpropertiesonlyAllowMembersViewMembership), required: false);
            WorkflowValue.Validate(requestpropertiesrequestToJoinLeaveEmailSetting, nameof(requestpropertiesrequestToJoinLeaveEmailSetting), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCheckSharePointGroupExists))]
        public IBodyWorkflowAction<GroupExistResponse> FlowV1SharePointFlowJobsCheckSharePointGroupExists([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GroupExistResponse> __BuildFlowV1SharePointFlowJobsCheckSharePointGroupExists(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            return new DeferredBodyAction<GroupExistResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsAddUserToSharePointGroup))]
        public IWorkflowAction FlowV1SharePointFlowJobsAddUserToSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestuser, [WorkflowExpression] Func<bool> requestsendEmail = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsAddUserToSharePointGroup(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName, WorkflowValue<string> requestuser, WorkflowValue<bool> requestsendEmail = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            WorkflowValue.Validate(requestuser, nameof(requestuser), required: true);
            WorkflowValue.Validate(requestsendEmail, nameof(requestsendEmail), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRemoveUserFromSharePointGroup))]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveUserFromSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestuser)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsRemoveUserFromSharePointGroup(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName, WorkflowValue<string> requestuser)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            WorkflowValue.Validate(requestuser, nameof(requestuser), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsGetSharePointGroupMembers))]
        public IBodyWorkflowAction<GetSPGroupMembersResponse> FlowV1SharePointFlowJobsGetSharePointGroupMembers([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSPGroupMembersResponse> __BuildFlowV1SharePointFlowJobsGetSharePointGroupMembers(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            return new DeferredBodyAction<GetSPGroupMembersResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsUserExistInSharePointGroup))]
        public IBodyWorkflowAction<UserExistsResponse> FlowV1SharePointFlowJobsUserExistInSharePointGroup([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestgroupName, [WorkflowExpression] Func<string> requestuser)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UserExistsResponse> __BuildFlowV1SharePointFlowJobsUserExistInSharePointGroup(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestgroupName, WorkflowValue<string> requestuser)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestgroupName, nameof(requestgroupName), required: true);
            WorkflowValue.Validate(requestuser, nameof(requestuser), required: true);
            return new DeferredBodyAction<UserExistsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsUpdateSharePointSiteProperties))]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateSharePointSiteProperties([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestpropertiestitle = null, [WorkflowExpression] Func<string> requestpropertiesdescription = null, [WorkflowExpression] Func<bool> requestpropertiesquickLaunchEnabled = null, [WorkflowExpression] Func<bool> requestpropertiestreeViewEnabled = null, [WorkflowExpression] Func<string> requestpropertiessiteLogoURL = null, [WorkflowExpression] Func<string> requestpropertiesalternateCssURL = null, [WorkflowExpression] Func<string> requestpropertiesassociatedMemberGroup = null, [WorkflowExpression] Func<string> requestpropertiesassociatedOwnerGroup = null, [WorkflowExpression] Func<string> requestpropertiesassociatedVisitorGroup = null, [WorkflowExpression] Func<bool> requestpropertiescontainsConfidentialInfo = null, [WorkflowExpression] Func<string> requestpropertiescustomMasterURL = null, [WorkflowExpression] Func<bool> requestpropertiesenableMinimalDownload = null, [WorkflowExpression] Func<bool> requestpropertiesisMultilingual = null, [WorkflowExpression] Func<string> requestpropertiesmasterURL = null, [WorkflowExpression] Func<bool> requestpropertiesmembersCanShare = null, [WorkflowExpression] Func<bool> requestpropertiesnoCrawl = null, [WorkflowExpression] Func<bool> requestpropertiesoverwriteTranslationsOnChange = null, [WorkflowExpression] Func<string> requestpropertiesrequestAccessEmail = null, [WorkflowExpression] Func<bool> requestpropertiessaveSiteAsTemplateEnabled = null, [WorkflowExpression] Func<string> requestpropertiesserverRelativeURL = null, [WorkflowExpression] Func<bool> requestpropertiessyndicationEnabled = null, [WorkflowExpression] Func<int> requestpropertiesuIVersion = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsUpdateSharePointSiteProperties(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestpropertiestitle = null, WorkflowValue<string> requestpropertiesdescription = null, WorkflowValue<bool> requestpropertiesquickLaunchEnabled = null, WorkflowValue<bool> requestpropertiestreeViewEnabled = null, WorkflowValue<string> requestpropertiessiteLogoURL = null, WorkflowValue<string> requestpropertiesalternateCssURL = null, WorkflowValue<string> requestpropertiesassociatedMemberGroup = null, WorkflowValue<string> requestpropertiesassociatedOwnerGroup = null, WorkflowValue<string> requestpropertiesassociatedVisitorGroup = null, WorkflowValue<bool> requestpropertiescontainsConfidentialInfo = null, WorkflowValue<string> requestpropertiescustomMasterURL = null, WorkflowValue<bool> requestpropertiesenableMinimalDownload = null, WorkflowValue<bool> requestpropertiesisMultilingual = null, WorkflowValue<string> requestpropertiesmasterURL = null, WorkflowValue<bool> requestpropertiesmembersCanShare = null, WorkflowValue<bool> requestpropertiesnoCrawl = null, WorkflowValue<bool> requestpropertiesoverwriteTranslationsOnChange = null, WorkflowValue<string> requestpropertiesrequestAccessEmail = null, WorkflowValue<bool> requestpropertiessaveSiteAsTemplateEnabled = null, WorkflowValue<string> requestpropertiesserverRelativeURL = null, WorkflowValue<bool> requestpropertiessyndicationEnabled = null, WorkflowValue<int> requestpropertiesuIVersion = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestpropertiestitle, nameof(requestpropertiestitle), required: false);
            WorkflowValue.Validate(requestpropertiesdescription, nameof(requestpropertiesdescription), required: false);
            WorkflowValue.Validate(requestpropertiesquickLaunchEnabled, nameof(requestpropertiesquickLaunchEnabled), required: false);
            WorkflowValue.Validate(requestpropertiestreeViewEnabled, nameof(requestpropertiestreeViewEnabled), required: false);
            WorkflowValue.Validate(requestpropertiessiteLogoURL, nameof(requestpropertiessiteLogoURL), required: false);
            WorkflowValue.Validate(requestpropertiesalternateCssURL, nameof(requestpropertiesalternateCssURL), required: false);
            WorkflowValue.Validate(requestpropertiesassociatedMemberGroup, nameof(requestpropertiesassociatedMemberGroup), required: false);
            WorkflowValue.Validate(requestpropertiesassociatedOwnerGroup, nameof(requestpropertiesassociatedOwnerGroup), required: false);
            WorkflowValue.Validate(requestpropertiesassociatedVisitorGroup, nameof(requestpropertiesassociatedVisitorGroup), required: false);
            WorkflowValue.Validate(requestpropertiescontainsConfidentialInfo, nameof(requestpropertiescontainsConfidentialInfo), required: false);
            WorkflowValue.Validate(requestpropertiescustomMasterURL, nameof(requestpropertiescustomMasterURL), required: false);
            WorkflowValue.Validate(requestpropertiesenableMinimalDownload, nameof(requestpropertiesenableMinimalDownload), required: false);
            WorkflowValue.Validate(requestpropertiesisMultilingual, nameof(requestpropertiesisMultilingual), required: false);
            WorkflowValue.Validate(requestpropertiesmasterURL, nameof(requestpropertiesmasterURL), required: false);
            WorkflowValue.Validate(requestpropertiesmembersCanShare, nameof(requestpropertiesmembersCanShare), required: false);
            WorkflowValue.Validate(requestpropertiesnoCrawl, nameof(requestpropertiesnoCrawl), required: false);
            WorkflowValue.Validate(requestpropertiesoverwriteTranslationsOnChange, nameof(requestpropertiesoverwriteTranslationsOnChange), required: false);
            WorkflowValue.Validate(requestpropertiesrequestAccessEmail, nameof(requestpropertiesrequestAccessEmail), required: false);
            WorkflowValue.Validate(requestpropertiessaveSiteAsTemplateEnabled, nameof(requestpropertiessaveSiteAsTemplateEnabled), required: false);
            WorkflowValue.Validate(requestpropertiesserverRelativeURL, nameof(requestpropertiesserverRelativeURL), required: false);
            WorkflowValue.Validate(requestpropertiessyndicationEnabled, nameof(requestpropertiessyndicationEnabled), required: false);
            WorkflowValue.Validate(requestpropertiesuIVersion, nameof(requestpropertiesuIVersion), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsDeleteSharePointSite))]
        public IWorkflowAction FlowV1SharePointFlowJobsDeleteSharePointSite([WorkflowExpression] Func<string> requestsharePointSiteURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsDeleteSharePointSite(WorkflowValue<string> requestsharePointSiteURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsString))]
        public IBodyWorkflowAction<SPSiteOptionValueResponse> FlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsString([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestoptionName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SPSiteOptionValueResponse> __BuildFlowV1SharePointFlowJobsGetSharePointSiteOptionValueAsString(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestoptionName)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestoptionName, nameof(requestoptionName), required: true);
            return new DeferredBodyAction<SPSiteOptionValueResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsInviteExternalUserToSharePoint))]
        public IWorkflowAction FlowV1SharePointFlowJobsInviteExternalUserToSharePoint([WorkflowExpression] Func<targetInput> target, [WorkflowExpression] Func<object> request = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsInviteExternalUserToSharePoint(WorkflowValue<targetInput> target, WorkflowValue<object> request = null)
        {
            WorkflowValue.Validate(target, nameof(target), required: true);
            WorkflowValue.Validate(request, nameof(request), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/flow/v1/SharePointFlow/jobs/InviteExternalUserToSharePoint";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["target"] = ExpressionConverter.Convert(target);
                callPayload.Body = ExpressionConverter.ConvertO(request);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCopyAttachmentsToUrl))]
        public IBodyWorkflowAction<ListFileUrlsResponse> FlowV1SharePointFlowJobsCopyAttachmentsToUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemID, [WorkflowExpression] Func<string> requestdestinationFolderURL, [WorkflowExpression] Func<bool> requestoverwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListFileUrlsResponse> __BuildFlowV1SharePointFlowJobsCopyAttachmentsToUrl(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistURL, WorkflowValue<int> requestitemID, WorkflowValue<string> requestdestinationFolderURL, WorkflowValue<bool> requestoverwrite = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestitemID, nameof(requestitemID), required: true);
            WorkflowValue.Validate(requestdestinationFolderURL, nameof(requestdestinationFolderURL), required: true);
            WorkflowValue.Validate(requestoverwrite, nameof(requestoverwrite), required: false);
            return new DeferredBodyAction<ListFileUrlsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsMoveAttachmentsToUrl))]
        public IBodyWorkflowAction<ListFileUrlsResponse> FlowV1SharePointFlowJobsMoveAttachmentsToUrl([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemID, [WorkflowExpression] Func<string> requestdestinationFolderURL, [WorkflowExpression] Func<bool> requestoverwrite = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListFileUrlsResponse> __BuildFlowV1SharePointFlowJobsMoveAttachmentsToUrl(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistURL, WorkflowValue<int> requestitemID, WorkflowValue<string> requestdestinationFolderURL, WorkflowValue<bool> requestoverwrite = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestitemID, nameof(requestitemID), required: true);
            WorkflowValue.Validate(requestdestinationFolderURL, nameof(requestdestinationFolderURL), required: true);
            WorkflowValue.Validate(requestoverwrite, nameof(requestoverwrite), required: false);
            return new DeferredBodyAction<ListFileUrlsResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsAddContentTypeToSharePointList))]
        public IWorkflowAction FlowV1SharePointFlowJobsAddContentTypeToSharePointList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestcontentTypeName, [WorkflowExpression] Func<bool> requestmakeItDefault = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsAddContentTypeToSharePointList(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistURL, WorkflowValue<string> requestcontentTypeName, WorkflowValue<bool> requestmakeItDefault = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestcontentTypeName, nameof(requestcontentTypeName), required: true);
            WorkflowValue.Validate(requestmakeItDefault, nameof(requestmakeItDefault), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsCopyListItemToSharePointList))]
        public IBodyWorkflowAction<ListItemIdResponse> FlowV1SharePointFlowJobsCopyListItemToSharePointList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestitemID, [WorkflowExpression] Func<string> requestdestinationListURL, [WorkflowExpression] Func<bool> requestcopyAttachments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListItemIdResponse> __BuildFlowV1SharePointFlowJobsCopyListItemToSharePointList(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistURL, WorkflowValue<string> requestitemID, WorkflowValue<string> requestdestinationListURL, WorkflowValue<bool> requestcopyAttachments = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestitemID, nameof(requestitemID), required: true);
            WorkflowValue.Validate(requestdestinationListURL, nameof(requestdestinationListURL), required: true);
            WorkflowValue.Validate(requestcopyAttachments, nameof(requestcopyAttachments), required: false);
            return new DeferredBodyAction<ListItemIdResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsMoveListItemToSharePointList))]
        public IBodyWorkflowAction<ListItemIdResponse> FlowV1SharePointFlowJobsMoveListItemToSharePointList([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestitemID, [WorkflowExpression] Func<string> requestdestinationListURL, [WorkflowExpression] Func<bool> requestmoveAttachments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListItemIdResponse> __BuildFlowV1SharePointFlowJobsMoveListItemToSharePointList(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistURL, WorkflowValue<string> requestitemID, WorkflowValue<string> requestdestinationListURL, WorkflowValue<bool> requestmoveAttachments = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestitemID, nameof(requestitemID), required: true);
            WorkflowValue.Validate(requestdestinationListURL, nameof(requestdestinationListURL), required: true);
            WorkflowValue.Validate(requestmoveAttachments, nameof(requestmoveAttachments), required: false);
            return new DeferredBodyAction<ListItemIdResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsStartListWorkflow))]
        public IBodyWorkflowAction<WorkflowGuidResponse> FlowV1SharePointFlowJobsStartListWorkflow([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestworkflowName, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemID)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkflowGuidResponse> __BuildFlowV1SharePointFlowJobsStartListWorkflow(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestworkflowName, WorkflowValue<string> requestlistURL, WorkflowValue<int> requestitemID)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestworkflowName, nameof(requestworkflowName), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestitemID, nameof(requestitemID), required: true);
            return new DeferredBodyAction<WorkflowGuidResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsStartSiteWorkflow))]
        public IBodyWorkflowAction<WorkflowGuidResponse> FlowV1SharePointFlowJobsStartSiteWorkflow([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestworkflowName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkflowGuidResponse> __BuildFlowV1SharePointFlowJobsStartSiteWorkflow(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestworkflowName)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestworkflowName, nameof(requestworkflowName), required: true);
            return new DeferredBodyAction<WorkflowGuidResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsGetItemsByCamlQuery))]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsGetItemsByCamlQuery([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<string> requestcAMLQuery, [WorkflowExpression] Func<string> requestfolderURL = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFlowV1SharePointFlowJobsGetItemsByCamlQuery(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistURL, WorkflowValue<string> requestcAMLQuery, WorkflowValue<string> requestfolderURL = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestcAMLQuery, nameof(requestcAMLQuery), required: true);
            WorkflowValue.Validate(requestfolderURL, nameof(requestfolderURL), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsGetVersionsHistory))]
        public IBodyWorkflowAction<VersionsHistoryResponse> FlowV1SharePointFlowJobsGetVersionsHistory([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistURL, [WorkflowExpression] Func<int> requestitemID, [WorkflowExpression] Func<string> requestfieldName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<VersionsHistoryResponse> __BuildFlowV1SharePointFlowJobsGetVersionsHistory(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistURL, WorkflowValue<int> requestitemID, WorkflowValue<string> requestfieldName)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistURL, nameof(requestlistURL), required: true);
            WorkflowValue.Validate(requestitemID, nameof(requestitemID), required: true);
            WorkflowValue.Validate(requestfieldName, nameof(requestfieldName), required: true);
            return new DeferredBodyAction<VersionsHistoryResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsProvisionPnPTemplate))]
        public IWorkflowAction FlowV1SharePointFlowJobsProvisionPnPTemplate([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttemplateContent, [WorkflowExpression] Func<bool> requestoverwriteSystemPropertyBagValues = null, [WorkflowExpression] Func<bool> requestignoreDuplicateDataRowErrors = null, [WorkflowExpression] Func<bool> requestclearNavigation = null, [WorkflowExpression] Func<bool> requestprovisionContentTypesToSubWebs = null, [WorkflowExpression] Func<bool> requestprovisionFieldsToSubWebs = null, [WorkflowExpression] Func<string> requesthandlers = null, [WorkflowExpression] Func<string> requestexcludeHandlers = null, [WorkflowExpression] Func<string> requestparameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsProvisionPnPTemplate(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requesttemplateContent, WorkflowValue<bool> requestoverwriteSystemPropertyBagValues = null, WorkflowValue<bool> requestignoreDuplicateDataRowErrors = null, WorkflowValue<bool> requestclearNavigation = null, WorkflowValue<bool> requestprovisionContentTypesToSubWebs = null, WorkflowValue<bool> requestprovisionFieldsToSubWebs = null, WorkflowValue<string> requesthandlers = null, WorkflowValue<string> requestexcludeHandlers = null, WorkflowValue<string> requestparameters = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requesttemplateContent, nameof(requesttemplateContent), required: true);
            WorkflowValue.Validate(requestoverwriteSystemPropertyBagValues, nameof(requestoverwriteSystemPropertyBagValues), required: false);
            WorkflowValue.Validate(requestignoreDuplicateDataRowErrors, nameof(requestignoreDuplicateDataRowErrors), required: false);
            WorkflowValue.Validate(requestclearNavigation, nameof(requestclearNavigation), required: false);
            WorkflowValue.Validate(requestprovisionContentTypesToSubWebs, nameof(requestprovisionContentTypesToSubWebs), required: false);
            WorkflowValue.Validate(requestprovisionFieldsToSubWebs, nameof(requestprovisionFieldsToSubWebs), required: false);
            WorkflowValue.Validate(requesthandlers, nameof(requesthandlers), required: false);
            WorkflowValue.Validate(requestexcludeHandlers, nameof(requestexcludeHandlers), required: false);
            WorkflowValue.Validate(requestparameters, nameof(requestparameters), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsProvisionPnPTenantTemplate))]
        public IWorkflowAction FlowV1SharePointFlowJobsProvisionPnPTenantTemplate([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requesttemplateContent, [WorkflowExpression] Func<bool> requestoverwriteSystemPropertyBagValues = null, [WorkflowExpression] Func<bool> requestignoreDuplicateDataRowErrors = null, [WorkflowExpression] Func<bool> requestclearNavigation = null, [WorkflowExpression] Func<bool> requestprovisionContentTypesToSubWebs = null, [WorkflowExpression] Func<bool> requestprovisionFieldsToSubWebs = null, [WorkflowExpression] Func<string> requesthandlers = null, [WorkflowExpression] Func<string> requestexcludeHandlers = null, [WorkflowExpression] Func<string> requestparameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsProvisionPnPTenantTemplate(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requesttemplateContent, WorkflowValue<bool> requestoverwriteSystemPropertyBagValues = null, WorkflowValue<bool> requestignoreDuplicateDataRowErrors = null, WorkflowValue<bool> requestclearNavigation = null, WorkflowValue<bool> requestprovisionContentTypesToSubWebs = null, WorkflowValue<bool> requestprovisionFieldsToSubWebs = null, WorkflowValue<string> requesthandlers = null, WorkflowValue<string> requestexcludeHandlers = null, WorkflowValue<string> requestparameters = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requesttemplateContent, nameof(requesttemplateContent), required: true);
            WorkflowValue.Validate(requestoverwriteSystemPropertyBagValues, nameof(requestoverwriteSystemPropertyBagValues), required: false);
            WorkflowValue.Validate(requestignoreDuplicateDataRowErrors, nameof(requestignoreDuplicateDataRowErrors), required: false);
            WorkflowValue.Validate(requestclearNavigation, nameof(requestclearNavigation), required: false);
            WorkflowValue.Validate(requestprovisionContentTypesToSubWebs, nameof(requestprovisionContentTypesToSubWebs), required: false);
            WorkflowValue.Validate(requestprovisionFieldsToSubWebs, nameof(requestprovisionFieldsToSubWebs), required: false);
            WorkflowValue.Validate(requesthandlers, nameof(requesthandlers), required: false);
            WorkflowValue.Validate(requestexcludeHandlers, nameof(requestexcludeHandlers), required: false);
            WorkflowValue.Validate(requestparameters, nameof(requestparameters), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsAddSiteNavigation))]
        public IWorkflowAction FlowV1SharePointFlowJobsAddSiteNavigation([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<requestlocationInput> requestlocation, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requestparent = null, [WorkflowExpression] Func<string> requesturl = null, [WorkflowExpression] Func<bool> requestprepend = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsAddSiteNavigation(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<requestlocationInput> requestlocation, WorkflowValue<string> requesttitle, WorkflowValue<string> requestparent = null, WorkflowValue<string> requesturl = null, WorkflowValue<bool> requestprepend = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlocation, nameof(requestlocation), required: true);
            WorkflowValue.Validate(requesttitle, nameof(requesttitle), required: true);
            WorkflowValue.Validate(requestparent, nameof(requestparent), required: false);
            WorkflowValue.Validate(requesturl, nameof(requesturl), required: false);
            WorkflowValue.Validate(requestprepend, nameof(requestprepend), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRemoveSiteNavigation))]
        public IWorkflowAction FlowV1SharePointFlowJobsRemoveSiteNavigation([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<requestlocationInput> requestlocation, [WorkflowExpression] Func<string> requesttitle, [WorkflowExpression] Func<string> requestparent = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsRemoveSiteNavigation(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<requestlocationInput> requestlocation, WorkflowValue<string> requesttitle, WorkflowValue<string> requestparent = null)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlocation, nameof(requestlocation), required: true);
            WorkflowValue.Validate(requesttitle, nameof(requesttitle), required: true);
            WorkflowValue.Validate(requestparent, nameof(requestparent), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsUpdateListItem))]
        public IWorkflowAction FlowV1SharePointFlowJobsUpdateListItem([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistName, [WorkflowExpression] Func<string> requestitemIDOrURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsUpdateListItem(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistName, WorkflowValue<string> requestitemIDOrURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistName, nameof(requestlistName), required: true);
            WorkflowValue.Validate(requestitemIDOrURL, nameof(requestitemIDOrURL), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsDeclareDocumentAsRecord))]
        public IWorkflowAction FlowV1SharePointFlowJobsDeclareDocumentAsRecord([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistName, [WorkflowExpression] Func<string> requestitemIDOrURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsDeclareDocumentAsRecord(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistName, WorkflowValue<string> requestitemIDOrURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistName, nameof(requestlistName), required: true);
            WorkflowValue.Validate(requestitemIDOrURL, nameof(requestitemIDOrURL), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsUndeclareDocumentAsRecord))]
        public IWorkflowAction FlowV1SharePointFlowJobsUndeclareDocumentAsRecord([WorkflowExpression] Func<string> requestsharePointSiteURL, [WorkflowExpression] Func<string> requestlistName, [WorkflowExpression] Func<string> requestitemIDOrURL)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFlowV1SharePointFlowJobsUndeclareDocumentAsRecord(WorkflowValue<string> requestsharePointSiteURL, WorkflowValue<string> requestlistName, WorkflowValue<string> requestitemIDOrURL)
        {
            WorkflowValue.Validate(requestsharePointSiteURL, nameof(requestsharePointSiteURL), required: true);
            WorkflowValue.Validate(requestlistName, nameof(requestlistName), required: true);
            WorkflowValue.Validate(requestitemIDOrURL, nameof(requestitemIDOrURL), required: true);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsParseCsv))]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsParseCsv([WorkflowExpression] Func<string> requestcontentOfCSVDocument, [WorkflowExpression] Func<string> requestheaders, [WorkflowExpression] Func<requestdelimiterInput> requestdelimiter = null, [WorkflowExpression] Func<requestlocaleInput> requestlocale = null, [WorkflowExpression] Func<int> requestlimit = null, [WorkflowExpression] Func<bool> requestskipFirstLine = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFlowV1SharePointFlowJobsParseCsv(WorkflowValue<string> requestcontentOfCSVDocument, WorkflowValue<string> requestheaders, WorkflowValue<requestdelimiterInput> requestdelimiter = null, WorkflowValue<requestlocaleInput> requestlocale = null, WorkflowValue<int> requestlimit = null, WorkflowValue<bool> requestskipFirstLine = null)
        {
            WorkflowValue.Validate(requestcontentOfCSVDocument, nameof(requestcontentOfCSVDocument), required: true);
            WorkflowValue.Validate(requestheaders, nameof(requestheaders), required: true);
            WorkflowValue.Validate(requestdelimiter, nameof(requestdelimiter), required: false);
            WorkflowValue.Validate(requestlocale, nameof(requestlocale), required: false);
            WorkflowValue.Validate(requestlimit, nameof(requestlimit), required: false);
            WorkflowValue.Validate(requestskipFirstLine, nameof(requestskipFirstLine), required: false);
            return new DeferredBodyAction<JToken>(() =>
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
                    if (requestlocale != null)
                    {
                        request["locale"] = ExpressionConverter.ConvertO(requestlocale);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRegExpMatch))]
        public IBodyWorkflowAction<JToken> FlowV1SharePointFlowJobsRegExpMatch([WorkflowExpression] Func<string> requestpattern, [WorkflowExpression] Func<string> requesttext)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildFlowV1SharePointFlowJobsRegExpMatch(WorkflowValue<string> requestpattern, WorkflowValue<string> requesttext)
        {
            WorkflowValue.Validate(requestpattern, nameof(requestpattern), required: true);
            WorkflowValue.Validate(requesttext, nameof(requesttext), required: true);
            return new DeferredBodyAction<JToken>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRegExpReplace))]
        public IBodyWorkflowAction<StringResultResponse> FlowV1SharePointFlowJobsRegExpReplace([WorkflowExpression] Func<string> requestpattern, [WorkflowExpression] Func<string> requesttext, [WorkflowExpression] Func<string> requestreplacement = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StringResultResponse> __BuildFlowV1SharePointFlowJobsRegExpReplace(WorkflowValue<string> requestpattern, WorkflowValue<string> requesttext, WorkflowValue<string> requestreplacement = null)
        {
            WorkflowValue.Validate(requestpattern, nameof(requestpattern), required: true);
            WorkflowValue.Validate(requesttext, nameof(requesttext), required: true);
            WorkflowValue.Validate(requestreplacement, nameof(requestreplacement), required: false);
            return new DeferredBodyAction<StringResultResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "plumsailsp")]
        [WorkflowExpressionFactory(nameof(__BuildFlowV1SharePointFlowJobsRegExpTest))]
        public IBodyWorkflowAction<BooleanResultResponse> FlowV1SharePointFlowJobsRegExpTest([WorkflowExpression] Func<string> requestpattern, [WorkflowExpression] Func<string> requesttext)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BooleanResultResponse> __BuildFlowV1SharePointFlowJobsRegExpTest(WorkflowValue<string> requestpattern, WorkflowValue<string> requesttext)
        {
            WorkflowValue.Validate(requestpattern, nameof(requestpattern), required: true);
            WorkflowValue.Validate(requesttext, nameof(requesttext), required: true);
            return new DeferredBodyAction<BooleanResultResponse>(() =>
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
            });
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
