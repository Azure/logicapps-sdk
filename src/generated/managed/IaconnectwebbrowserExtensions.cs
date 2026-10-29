//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectwebbrowserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse, ApiConnectionActionConfiguration> BrowserGetChromeBrowserVersionFromFile(Expression<Func<BrowserGetChromeBrowserVersionFromFileInput>> browserGetChromeBrowserVersionFromFile)
        {
            var __workflow_browserGetChromeBrowserVersionFromFile = WorkflowExpression.Compile(browserGetChromeBrowserVersionFromFile, nameof(browserGetChromeBrowserVersionFromFile), required: true);
            return new DeferredBodyAction<BrowserGetChromeBrowserVersionFromFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetChromeBrowserVersionFromFile);
                return new ApiConnectionAction<BrowserGetChromeBrowserVersionFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse, ApiConnectionActionConfiguration> BrowserGetChromeDriverFolder(Expression<Func<BrowserGetChromeDriverFolderInput>> browserGetChromeDriverFolder)
        {
            var __workflow_browserGetChromeDriverFolder = WorkflowExpression.Compile(browserGetChromeDriverFolder, nameof(browserGetChromeDriverFolder), required: true);
            return new DeferredBodyAction<BrowserGetChromeDriverFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetChromeDriverFolder);
                return new ApiConnectionAction<BrowserGetChromeDriverFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse, ApiConnectionActionConfiguration> BrowserDownloadSuitableChromeDriverFromInternet(Expression<Func<BrowserDownloadSuitableChromeDriverFromInternetInput>> browserDownloadSuitableChromeDriverFromInternet)
        {
            var __workflow_browserDownloadSuitableChromeDriverFromInternet = WorkflowExpression.Compile(browserDownloadSuitableChromeDriverFromInternet, nameof(browserDownloadSuitableChromeDriverFromInternet), required: true);
            return new DeferredBodyAction<BrowserDownloadSuitableChromeDriverFromInternetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromeDriverFromInternet);
                return new ApiConnectionAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse, ApiConnectionActionConfiguration> BrowserIsSuitableChromeDriverAvailable(Expression<Func<BrowserIsSuitableChromeDriverAvailableInput>> browserIsSuitableChromeDriverAvailable)
        {
            var __workflow_browserIsSuitableChromeDriverAvailable = WorkflowExpression.Compile(browserIsSuitableChromeDriverAvailable, nameof(browserIsSuitableChromeDriverAvailable), required: true);
            return new DeferredBodyAction<BrowserIsSuitableChromeDriverAvailableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromeDriverAvailable);
                return new ApiConnectionAction<BrowserIsSuitableChromeDriverAvailableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserUploadNewChromeDriver(Expression<Func<BrowserUploadNewChromeDriverInput>> browserUploadNewChromeDriver)
        {
            var __workflow_browserUploadNewChromeDriver = WorkflowExpression.Compile(browserUploadNewChromeDriver, nameof(browserUploadNewChromeDriver), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/UploadNewChromeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromeDriver);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromeResponse, ApiConnectionActionConfiguration> BrowserOpenChrome(Expression<Func<BrowserOpenChromeInput>> browserOpenChrome)
        {
            var __workflow_browserOpenChrome = WorkflowExpression.Compile(browserOpenChrome, nameof(browserOpenChrome), required: true);
            return new DeferredBodyAction<BrowserOpenChromeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenChrome";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserOpenChrome);
                return new ApiConnectionAction<BrowserOpenChromeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserCloseChrome(Expression<Func<BrowserCloseChromeInput>> browserCloseChrome)
        {
            var __workflow_browserCloseChrome = WorkflowExpression.Compile(browserCloseChrome, nameof(browserCloseChrome), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CloseChrome";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCloseChrome);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserOpenInternetExplorer(Expression<Func<BrowserOpenInternetExplorerInput>> browserOpenInternetExplorer)
        {
            var __workflow_browserOpenInternetExplorer = WorkflowExpression.Compile(browserOpenInternetExplorer, nameof(browserOpenInternetExplorer), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenInternetExplorer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserOpenInternetExplorer);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserCloseInternetExplorer(Expression<Func<BrowserCloseInternetExplorerInput>> browserCloseInternetExplorer)
        {
            var __workflow_browserCloseInternetExplorer = WorkflowExpression.Compile(browserCloseInternetExplorer, nameof(browserCloseInternetExplorer), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CloseInternetExplorer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCloseInternetExplorer);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse, ApiConnectionActionConfiguration> BrowserGetChromiumEdgeDriverFolder(Expression<Func<BrowserGetChromiumEdgeDriverFolderInput>> browserGetChromiumEdgeDriverFolder)
        {
            var __workflow_browserGetChromiumEdgeDriverFolder = WorkflowExpression.Compile(browserGetChromiumEdgeDriverFolder, nameof(browserGetChromiumEdgeDriverFolder), required: true);
            return new DeferredBodyAction<BrowserGetChromiumEdgeDriverFolderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeDriverFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeDriverFolder);
                return new ApiConnectionAction<BrowserGetChromiumEdgeDriverFolderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse, ApiConnectionActionConfiguration> BrowserGetChromiumEdgeBrowserVersionFromFile(Expression<Func<BrowserGetChromiumEdgeBrowserVersionFromFileInput>> browserGetChromiumEdgeBrowserVersionFromFile)
        {
            var __workflow_browserGetChromiumEdgeBrowserVersionFromFile = WorkflowExpression.Compile(browserGetChromiumEdgeBrowserVersionFromFile, nameof(browserGetChromiumEdgeBrowserVersionFromFile), required: true);
            return new DeferredBodyAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetChromiumEdgeBrowserVersionFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetChromiumEdgeBrowserVersionFromFile);
                return new ApiConnectionAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse, ApiConnectionActionConfiguration> BrowserDownloadSuitableChromiumEdgeDriverFromInternet(Expression<Func<BrowserDownloadSuitableChromiumEdgeDriverFromInternetInput>> browserDownloadSuitableChromiumEdgeDriverFromInternet)
        {
            var __workflow_browserDownloadSuitableChromiumEdgeDriverFromInternet = WorkflowExpression.Compile(browserDownloadSuitableChromiumEdgeDriverFromInternet, nameof(browserDownloadSuitableChromiumEdgeDriverFromInternet), required: true);
            return new DeferredBodyAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromiumEdgeDriverFromInternet";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserDownloadSuitableChromiumEdgeDriverFromInternet);
                return new ApiConnectionAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse, ApiConnectionActionConfiguration> BrowserIsSuitableChromiumEdgeDriverAvailable(Expression<Func<BrowserIsSuitableChromiumEdgeDriverAvailableInput>> browserIsSuitableChromiumEdgeDriverAvailable)
        {
            var __workflow_browserIsSuitableChromiumEdgeDriverAvailable = WorkflowExpression.Compile(browserIsSuitableChromiumEdgeDriverAvailable, nameof(browserIsSuitableChromiumEdgeDriverAvailable), required: true);
            return new DeferredBodyAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/IsSuitableChromiumEdgeDriverAvailable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserIsSuitableChromiumEdgeDriverAvailable);
                return new ApiConnectionAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserUploadNewChromiumEdgeDriver(Expression<Func<BrowserUploadNewChromiumEdgeDriverInput>> browserUploadNewChromiumEdgeDriver)
        {
            var __workflow_browserUploadNewChromiumEdgeDriver = WorkflowExpression.Compile(browserUploadNewChromiumEdgeDriver, nameof(browserUploadNewChromiumEdgeDriver), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/UploadNewChromiumEdgeDriver";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserUploadNewChromiumEdgeDriver);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse, ApiConnectionActionConfiguration> BrowserOpenChromiumEdge(Expression<Func<BrowserOpenChromiumEdgeInput>> browserOpenChromiumEdge)
        {
            var __workflow_browserOpenChromiumEdge = WorkflowExpression.Compile(browserOpenChromiumEdge, nameof(browserOpenChromiumEdge), required: true);
            return new DeferredBodyAction<BrowserOpenChromiumEdgeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenChromiumEdge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserOpenChromiumEdge);
                return new ApiConnectionAction<BrowserOpenChromiumEdgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserCloseChromiumEdge(Expression<Func<BrowserCloseChromiumEdgeInput>> browserCloseChromiumEdge)
        {
            var __workflow_browserCloseChromiumEdge = WorkflowExpression.Compile(browserCloseChromiumEdge, nameof(browserCloseChromiumEdge), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CloseChromiumEdge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCloseChromiumEdge);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserMaximise(Expression<Func<BrowserMaximiseInput>> browserMaximise)
        {
            var __workflow_browserMaximise = WorkflowExpression.Compile(browserMaximise, nameof(browserMaximise), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/MaximiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserMaximise);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserMinimise(Expression<Func<BrowserMinimiseInput>> browserMinimise)
        {
            var __workflow_browserMinimise = WorkflowExpression.Compile(browserMinimise, nameof(browserMinimise), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/MinimiseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserMinimise);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserFullscreen(Expression<Func<BrowserFullscreenInput>> browserFullscreen)
        {
            var __workflow_browserFullscreen = WorkflowExpression.Compile(browserFullscreen, nameof(browserFullscreen), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/FullscreenBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserFullscreen);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserNormaliseBrowser(Expression<Func<BrowserNormaliseBrowserInput>> browserNormaliseBrowser)
        {
            var __workflow_browserNormaliseBrowser = WorkflowExpression.Compile(browserNormaliseBrowser, nameof(browserNormaliseBrowser), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/NormaliseBrowser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserNormaliseBrowser);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSetWindowSize(Expression<Func<BrowserSetWindowSizeInput>> browserSetWindowSize)
        {
            var __workflow_browserSetWindowSize = WorkflowExpression.Compile(browserSetWindowSize, nameof(browserSetWindowSize), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowSize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSetWindowSize);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSetWindowPosition(Expression<Func<BrowserSetWindowPositionInput>> browserSetWindowPosition)
        {
            var __workflow_browserSetWindowPosition = WorkflowExpression.Compile(browserSetWindowPosition, nameof(browserSetWindowPosition), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SetBrowserWindowPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSetWindowPosition);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSetTimeouts(Expression<Func<BrowserSetTimeoutsInput>> browserSetTimeouts)
        {
            var __workflow_browserSetTimeouts = WorkflowExpression.Compile(browserSetTimeouts, nameof(browserSetTimeouts), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SetTimeouts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSetTimeouts);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse, ApiConnectionActionConfiguration> BrowserNavigateToURL(Expression<Func<BrowserNavigateToURLInput>> browserNavigateToURL)
        {
            var __workflow_browserNavigateToURL = WorkflowExpression.Compile(browserNavigateToURL, nameof(browserNavigateToURL), required: true);
            return new DeferredBodyAction<BrowserNavigateToURLResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/NavigateToURL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserNavigateToURL);
                return new ApiConnectionAction<BrowserNavigateToURLResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserRefreshPage(Expression<Func<BrowserRefreshPageInput>> browserRefreshPage)
        {
            var __workflow_browserRefreshPage = WorkflowExpression.Compile(browserRefreshPage, nameof(browserRefreshPage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/RefreshPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserRefreshPage);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserResetAllElementHandles(Expression<Func<BrowserResetAllElementHandlesInput>> browserResetAllElementHandles)
        {
            var __workflow_browserResetAllElementHandles = WorkflowExpression.Compile(browserResetAllElementHandles, nameof(browserResetAllElementHandles), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserResetAllElementHandles);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse, ApiConnectionActionConfiguration> BrowserDoesElementExist(Expression<Func<BrowserDoesElementExistInput>> browserDoesElementExist)
        {
            var __workflow_browserDoesElementExist = WorkflowExpression.Compile(browserDoesElementExist, nameof(browserDoesElementExist), required: true);
            return new DeferredBodyAction<BrowserDoesElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserDoesElementExist);
                return new ApiConnectionAction<BrowserDoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse, ApiConnectionActionConfiguration> BrowserCreateHandleToElement(Expression<Func<BrowserCreateHandleToElementInput>> browserCreateHandleToElement)
        {
            var __workflow_browserCreateHandleToElement = WorkflowExpression.Compile(browserCreateHandleToElement, nameof(browserCreateHandleToElement), required: true);
            return new DeferredBodyAction<BrowserCreateHandleToElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CreateHandleToElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToElement);
                return new ApiConnectionAction<BrowserCreateHandleToElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse, ApiConnectionActionConfiguration> BrowserCreateHandleToParentElement(Expression<Func<BrowserCreateHandleToParentElementInput>> browserCreateHandleToParentElement)
        {
            var __workflow_browserCreateHandleToParentElement = WorkflowExpression.Compile(browserCreateHandleToParentElement, nameof(browserCreateHandleToParentElement), required: true);
            return new DeferredBodyAction<BrowserCreateHandleToParentElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CreateHandleToParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCreateHandleToParentElement);
                return new ApiConnectionAction<BrowserCreateHandleToParentElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse, ApiConnectionActionConfiguration> BrowserGetElementProperties(Expression<Func<BrowserGetElementPropertiesInput>> browserGetElementProperties)
        {
            var __workflow_browserGetElementProperties = WorkflowExpression.Compile(browserGetElementProperties, nameof(browserGetElementProperties), required: true);
            return new DeferredBodyAction<BrowserGetElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetElementProperties);
                return new ApiConnectionAction<BrowserGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration> BrowserGetMultipleElementProperties(Expression<Func<BrowserGetMultipleElementPropertiesInput>> browserGetMultipleElementProperties)
        {
            var __workflow_browserGetMultipleElementProperties = WorkflowExpression.Compile(browserGetMultipleElementProperties, nameof(browserGetMultipleElementProperties), required: true);
            return new DeferredBodyAction<BrowserGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetMultipleElementProperties);
                return new ApiConnectionAction<BrowserGetMultipleElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse, ApiConnectionActionConfiguration> BrowserGetElementParentProperties(Expression<Func<BrowserGetElementParentPropertiesInput>> browserGetElementParentProperties)
        {
            var __workflow_browserGetElementParentProperties = WorkflowExpression.Compile(browserGetElementParentProperties, nameof(browserGetElementParentProperties), required: true);
            return new DeferredBodyAction<BrowserGetElementParentPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementParentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetElementParentProperties);
                return new ApiConnectionAction<BrowserGetElementParentPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse, ApiConnectionActionConfiguration> BrowserGetElementChildrenProperties(Expression<Func<BrowserGetElementChildrenPropertiesInput>> browserGetElementChildrenProperties)
        {
            var __workflow_browserGetElementChildrenProperties = WorkflowExpression.Compile(browserGetElementChildrenProperties, nameof(browserGetElementChildrenProperties), required: true);
            return new DeferredBodyAction<BrowserGetElementChildrenPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementChildrenProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetElementChildrenProperties);
                return new ApiConnectionAction<BrowserGetElementChildrenPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse, ApiConnectionActionConfiguration> BrowserInputTextIntoElement(Expression<Func<BrowserInputTextIntoElementInput>> browserInputTextIntoElement)
        {
            var __workflow_browserInputTextIntoElement = WorkflowExpression.Compile(browserInputTextIntoElement, nameof(browserInputTextIntoElement), required: true);
            return new DeferredBodyAction<BrowserInputTextIntoElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoElement);
                return new ApiConnectionAction<BrowserInputTextIntoElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserInputTextIntoMultipleElements(Expression<Func<BrowserInputTextIntoMultipleElementsInput>> browserInputTextIntoMultipleElements)
        {
            var __workflow_browserInputTextIntoMultipleElements = WorkflowExpression.Compile(browserInputTextIntoMultipleElements, nameof(browserInputTextIntoMultipleElements), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserInputTextIntoMultipleElements);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserPressCtrlKeyOnElement(Expression<Func<BrowserPressCtrlKeyOnElementInput>> browserPressCtrlKeyOnElement)
        {
            var __workflow_browserPressCtrlKeyOnElement = WorkflowExpression.Compile(browserPressCtrlKeyOnElement, nameof(browserPressCtrlKeyOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/PressCtrlKeyOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserPressCtrlKeyOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserClickElement(Expression<Func<BrowserClickElementInput>> browserClickElement)
        {
            var __workflow_browserClickElement = WorkflowExpression.Compile(browserClickElement, nameof(browserClickElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ClickElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserClickElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSubmitElement(Expression<Func<BrowserSubmitElementInput>> browserSubmitElement)
        {
            var __workflow_browserSubmitElement = WorkflowExpression.Compile(browserSubmitElement, nameof(browserSubmitElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SubmitElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSubmitElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserCheckElement(Expression<Func<BrowserCheckElementInput>> browserCheckElement)
        {
            var __workflow_browserCheckElement = WorkflowExpression.Compile(browserCheckElement, nameof(browserCheckElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCheckElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserCheckMultipleElements(Expression<Func<BrowserCheckMultipleElementsInput>> browserCheckMultipleElements)
        {
            var __workflow_browserCheckMultipleElements = WorkflowExpression.Compile(browserCheckMultipleElements, nameof(browserCheckMultipleElements), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserCheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCheckMultipleElements);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse, ApiConnectionActionConfiguration> BrowserGetSelectionProperties(Expression<Func<BrowserGetSelectionPropertiesInput>> browserGetSelectionProperties)
        {
            var __workflow_browserGetSelectionProperties = WorkflowExpression.Compile(browserGetSelectionProperties, nameof(browserGetSelectionProperties), required: true);
            return new DeferredBodyAction<BrowserGetSelectionPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetSelectionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetSelectionProperties);
                return new ApiConnectionAction<BrowserGetSelectionPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSelectSelection(Expression<Func<BrowserSelectSelectionInput>> browserSelectSelection)
        {
            var __workflow_browserSelectSelection = WorkflowExpression.Compile(browserSelectSelection, nameof(browserSelectSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SelectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSelectSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserDeselectSelection(Expression<Func<BrowserDeselectSelectionInput>> browserDeselectSelection)
        {
            var __workflow_browserDeselectSelection = WorkflowExpression.Compile(browserDeselectSelection, nameof(browserDeselectSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/DeselectSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserDeselectSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserDeselectAllSelection(Expression<Func<BrowserDeselectAllSelectionInput>> browserDeselectAllSelection)
        {
            var __workflow_browserDeselectAllSelection = WorkflowExpression.Compile(browserDeselectAllSelection, nameof(browserDeselectAllSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/DeselectAllSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserDeselectAllSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse, ApiConnectionActionConfiguration> BrowserGetTableContents(Expression<Func<BrowserGetTableContentsInput>> browserGetTableContents)
        {
            var __workflow_browserGetTableContents = WorkflowExpression.Compile(browserGetTableContents, nameof(browserGetTableContents), required: true);
            return new DeferredBodyAction<BrowserGetTableContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetTableContents);
                return new ApiConnectionAction<BrowserGetTableContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserScrollElementIntoView(Expression<Func<BrowserScrollElementIntoViewInput>> browserScrollElementIntoView)
        {
            var __workflow_browserScrollElementIntoView = WorkflowExpression.Compile(browserScrollElementIntoView, nameof(browserScrollElementIntoView), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollElementIntoView";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserScrollElementIntoView);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse, ApiConnectionActionConfiguration> BrowserExecuteJavaScript(Expression<Func<BrowserExecuteJavaScriptInput>> browserExecuteJavaScript)
        {
            var __workflow_browserExecuteJavaScript = WorkflowExpression.Compile(browserExecuteJavaScript, nameof(browserExecuteJavaScript), required: true);
            return new DeferredBodyAction<BrowserExecuteJavaScriptResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScript";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScript);
                return new ApiConnectionAction<BrowserExecuteJavaScriptResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse, ApiConnectionActionConfiguration> BrowserGetElementBoundingRect(Expression<Func<BrowserGetElementBoundingRectInput>> browserGetElementBoundingRect)
        {
            var __workflow_browserGetElementBoundingRect = WorkflowExpression.Compile(browserGetElementBoundingRect, nameof(browserGetElementBoundingRect), required: true);
            return new DeferredBodyAction<BrowserGetElementBoundingRectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetElementBoundingRect);
                return new ApiConnectionAction<BrowserGetElementBoundingRectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserDrawRectangleAroundElement(Expression<Func<BrowserDrawRectangleAroundElementInput>> browserDrawRectangleAroundElement)
        {
            var __workflow_browserDrawRectangleAroundElement = WorkflowExpression.Compile(browserDrawRectangleAroundElement, nameof(browserDrawRectangleAroundElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserDrawRectangleAroundElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse, ApiConnectionActionConfiguration> BrowserGetBrowserParentWindowDetails(Expression<Func<BrowserGetBrowserParentWindowDetailsInput>> browserGetBrowserParentWindowDetails)
        {
            var __workflow_browserGetBrowserParentWindowDetails = WorkflowExpression.Compile(browserGetBrowserParentWindowDetails, nameof(browserGetBrowserParentWindowDetails), required: true);
            return new DeferredBodyAction<BrowserGetBrowserParentWindowDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetBrowserParentWindowDetails";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetBrowserParentWindowDetails);
                return new ApiConnectionAction<BrowserGetBrowserParentWindowDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse, ApiConnectionActionConfiguration> BrowserGetElementScreenBoundingRect(Expression<Func<BrowserGetElementScreenBoundingRectInput>> browserGetElementScreenBoundingRect)
        {
            var __workflow_browserGetElementScreenBoundingRect = WorkflowExpression.Compile(browserGetElementScreenBoundingRect, nameof(browserGetElementScreenBoundingRect), required: true);
            return new DeferredBodyAction<BrowserGetElementScreenBoundingRectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetElementScreenBoundingRect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetElementScreenBoundingRect);
                return new ApiConnectionAction<BrowserGetElementScreenBoundingRectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserFocusElement(Expression<Func<BrowserFocusElementInput>> browserFocusElement)
        {
            var __workflow_browserFocusElement = WorkflowExpression.Compile(browserFocusElement, nameof(browserFocusElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserFocusElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserPressEnterOnElement(Expression<Func<BrowserPressEnterOnElementInput>> browserPressEnterOnElement)
        {
            var __workflow_browserPressEnterOnElement = WorkflowExpression.Compile(browserPressEnterOnElement, nameof(browserPressEnterOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/PressEnterOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserPressEnterOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserMouseLeftClickOnElement(Expression<Func<BrowserMouseLeftClickOnElementInput>> browserMouseLeftClickOnElement)
        {
            var __workflow_browserMouseLeftClickOnElement = WorkflowExpression.Compile(browserMouseLeftClickOnElement, nameof(browserMouseLeftClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/MouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserMouseLeftClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserMouseRightClickOnElement(Expression<Func<BrowserMouseRightClickOnElementInput>> browserMouseRightClickOnElement)
        {
            var __workflow_browserMouseRightClickOnElement = WorkflowExpression.Compile(browserMouseRightClickOnElement, nameof(browserMouseRightClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/MouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserMouseRightClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserJavaScriptClickOnElement(Expression<Func<BrowserJavaScriptClickOnElementInput>> browserJavaScriptClickOnElement)
        {
            var __workflow_browserJavaScriptClickOnElement = WorkflowExpression.Compile(browserJavaScriptClickOnElement, nameof(browserJavaScriptClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/JavaScriptClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserJavaScriptClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse, ApiConnectionActionConfiguration> BrowserExecuteJavaScriptOnElement(Expression<Func<BrowserExecuteJavaScriptOnElementInput>> browserExecuteJavaScriptOnElement)
        {
            var __workflow_browserExecuteJavaScriptOnElement = WorkflowExpression.Compile(browserExecuteJavaScriptOnElement, nameof(browserExecuteJavaScriptOnElement), required: true);
            return new DeferredBodyAction<BrowserExecuteJavaScriptOnElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ExecuteJavaScriptOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserExecuteJavaScriptOnElement);
                return new ApiConnectionAction<BrowserExecuteJavaScriptOnElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserGlobalMouseLeftClickOnElement(Expression<Func<BrowserGlobalMouseLeftClickOnElementInput>> browserGlobalMouseLeftClickOnElement)
        {
            var __workflow_browserGlobalMouseLeftClickOnElement = WorkflowExpression.Compile(browserGlobalMouseLeftClickOnElement, nameof(browserGlobalMouseLeftClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GlobalMouseLeftClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseLeftClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserGlobalMouseRightClickOnElement(Expression<Func<BrowserGlobalMouseRightClickOnElementInput>> browserGlobalMouseRightClickOnElement)
        {
            var __workflow_browserGlobalMouseRightClickOnElement = WorkflowExpression.Compile(browserGlobalMouseRightClickOnElement, nameof(browserGlobalMouseRightClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GlobalMouseRightClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGlobalMouseRightClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse, ApiConnectionActionConfiguration> BrowserOpenNewTab(Expression<Func<BrowserOpenNewTabInput>> browserOpenNewTab)
        {
            var __workflow_browserOpenNewTab = WorkflowExpression.Compile(browserOpenNewTab, nameof(browserOpenNewTab), required: true);
            return new DeferredBodyAction<BrowserOpenNewTabResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/OpenNewTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserOpenNewTab);
                return new ApiConnectionAction<BrowserOpenNewTabResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTabsResponse, ApiConnectionActionConfiguration> BrowserGetTabs(Expression<Func<BrowserGetTabsInput>> browserGetTabs)
        {
            var __workflow_browserGetTabs = WorkflowExpression.Compile(browserGetTabs, nameof(browserGetTabs), required: true);
            return new DeferredBodyAction<BrowserGetTabsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetTabs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetTabs);
                return new ApiConnectionAction<BrowserGetTabsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSetTab(Expression<Func<BrowserSetTabInput>> browserSetTab)
        {
            var __workflow_browserSetTab = WorkflowExpression.Compile(browserSetTab, nameof(browserSetTab), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SetTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSetTab);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserCloseActiveTab(Expression<Func<BrowserCloseActiveTabInput>> browserCloseActiveTab)
        {
            var __workflow_browserCloseActiveTab = WorkflowExpression.Compile(browserCloseActiveTab, nameof(browserCloseActiveTab), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CloseActiveTab";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCloseActiveTab);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSavePageToFile(Expression<Func<BrowserSavePageToFileInput>> browserSavePageToFile)
        {
            var __workflow_browserSavePageToFile = WorkflowExpression.Compile(browserSavePageToFile, nameof(browserSavePageToFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SavePageToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSavePageToFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetPageTextResponse, ApiConnectionActionConfiguration> BrowserGetPageText(Expression<Func<BrowserGetPageTextInput>> browserGetPageText)
        {
            var __workflow_browserGetPageText = WorkflowExpression.Compile(browserGetPageText, nameof(browserGetPageText), required: true);
            return new DeferredBodyAction<BrowserGetPageTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetPageText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetPageText);
                return new ApiConnectionAction<BrowserGetPageTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSwitchToFrameElement(Expression<Func<BrowserSwitchToFrameElementInput>> browserSwitchToFrameElement)
        {
            var __workflow_browserSwitchToFrameElement = WorkflowExpression.Compile(browserSwitchToFrameElement, nameof(browserSwitchToFrameElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSwitchToFrameElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse, ApiConnectionActionConfiguration> BrowserGetCurrentFrameWindowPixelCoordinate(Expression<Func<BrowserGetCurrentFrameWindowPixelCoordinateInput>> browserGetCurrentFrameWindowPixelCoordinate)
        {
            var __workflow_browserGetCurrentFrameWindowPixelCoordinate = WorkflowExpression.Compile(browserGetCurrentFrameWindowPixelCoordinate, nameof(browserGetCurrentFrameWindowPixelCoordinate), required: true);
            return new DeferredBodyAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetCurrentFrameWindowPixelCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetCurrentFrameWindowPixelCoordinate);
                return new ApiConnectionAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSwitchToParentFrameElement(Expression<Func<BrowserSwitchToParentFrameElementInput>> browserSwitchToParentFrameElement)
        {
            var __workflow_browserSwitchToParentFrameElement = WorkflowExpression.Compile(browserSwitchToParentFrameElement, nameof(browserSwitchToParentFrameElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToParentFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSwitchToParentFrameElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSwitchToRootFrameElement(Expression<Func<BrowserSwitchToRootFrameElementInput>> browserSwitchToRootFrameElement)
        {
            var __workflow_browserSwitchToRootFrameElement = WorkflowExpression.Compile(browserSwitchToRootFrameElement, nameof(browserSwitchToRootFrameElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SwitchToRootFrameElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSwitchToRootFrameElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserResetFrameStack(Expression<Func<BrowserResetFrameStackInput>> browserResetFrameStack)
        {
            var __workflow_browserResetFrameStack = WorkflowExpression.Compile(browserResetFrameStack, nameof(browserResetFrameStack), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ResetFrameStack";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserResetFrameStack);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserClearElementTextResponse, ApiConnectionActionConfiguration> BrowserClearElementText(Expression<Func<BrowserClearElementTextInput>> browserClearElementText)
        {
            var __workflow_browserClearElementText = WorkflowExpression.Compile(browserClearElementText, nameof(browserClearElementText), required: true);
            return new DeferredBodyAction<BrowserClearElementTextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ClearElementText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserClearElementText);
                return new ApiConnectionAction<BrowserClearElementTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserCopySelectedTextOnElement(Expression<Func<BrowserCopySelectedTextOnElementInput>> browserCopySelectedTextOnElement)
        {
            var __workflow_browserCopySelectedTextOnElement = WorkflowExpression.Compile(browserCopySelectedTextOnElement, nameof(browserCopySelectedTextOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/CopySelectedTextOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserCopySelectedTextOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserInputPasswordIntoElement(Expression<Func<BrowserInputPasswordIntoElementInput>> browserInputPasswordIntoElement)
        {
            var __workflow_browserInputPasswordIntoElement = WorkflowExpression.Compile(browserInputPasswordIntoElement, nameof(browserInputPasswordIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserInputPasswordIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserPasteIntoElement(Expression<Func<BrowserPasteIntoElementInput>> browserPasteIntoElement)
        {
            var __workflow_browserPasteIntoElement = WorkflowExpression.Compile(browserPasteIntoElement, nameof(browserPasteIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/PasteIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserPasteIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserPrintCurrentPage(Expression<Func<BrowserPrintCurrentPageInput>> browserPrintCurrentPage)
        {
            var __workflow_browserPrintCurrentPage = WorkflowExpression.Compile(browserPrintCurrentPage, nameof(browserPrintCurrentPage), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/PrintCurrentPage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserPrintCurrentPage);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserScrollWindowByPixels(Expression<Func<BrowserScrollWindowByPixelsInput>> browserScrollWindowByPixels)
        {
            var __workflow_browserScrollWindowByPixels = WorkflowExpression.Compile(browserScrollWindowByPixels, nameof(browserScrollWindowByPixels), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollWindowByPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserScrollWindowByPixels);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserScrollWindowToPixels(Expression<Func<BrowserScrollWindowToPixelsInput>> browserScrollWindowToPixels)
        {
            var __workflow_browserScrollWindowToPixels = WorkflowExpression.Compile(browserScrollWindowToPixels, nameof(browserScrollWindowToPixels), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/ScrollWindowToPixels";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserScrollWindowToPixels);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BrowserSelectAllOnElement(Expression<Func<BrowserSelectAllOnElementInput>> browserSelectAllOnElement)
        {
            var __workflow_browserSelectAllOnElement = WorkflowExpression.Compile(browserSelectAllOnElement, nameof(browserSelectAllOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/SelectAllOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserSelectAllOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse, ApiConnectionActionConfiguration> BrowserWaitForElementToExist(Expression<Func<BrowserWaitForElementToExistInput>> browserWaitForElementToExist)
        {
            var __workflow_browserWaitForElementToExist = WorkflowExpression.Compile(browserWaitForElementToExist, nameof(browserWaitForElementToExist), required: true);
            return new DeferredBodyAction<BrowserWaitForElementToExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/WaitForElementToExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToExist);
                return new ApiConnectionAction<BrowserWaitForElementToExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse, ApiConnectionActionConfiguration> BrowserWaitForElementToNotExist(Expression<Func<BrowserWaitForElementToNotExistInput>> browserWaitForElementToNotExist)
        {
            var __workflow_browserWaitForElementToNotExist = WorkflowExpression.Compile(browserWaitForElementToNotExist, nameof(browserWaitForElementToNotExist), required: true);
            return new DeferredBodyAction<BrowserWaitForElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/WaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserWaitForElementToNotExist);
                return new ApiConnectionAction<BrowserWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse, ApiConnectionActionConfiguration> BrowserGetWebElementAtScreenCoordinates(Expression<Func<BrowserGetWebElementAtScreenCoordinatesInput>> browserGetWebElementAtScreenCoordinates)
        {
            var __workflow_browserGetWebElementAtScreenCoordinates = WorkflowExpression.Compile(browserGetWebElementAtScreenCoordinates, nameof(browserGetWebElementAtScreenCoordinates), required: true);
            return new DeferredBodyAction<BrowserGetWebElementAtScreenCoordinatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetWebElementAtScreenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtScreenCoordinates);
                return new ApiConnectionAction<BrowserGetWebElementAtScreenCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse, ApiConnectionActionConfiguration> BrowserGetWebElementAtBrowserDocumentWindowCoordinates(Expression<Func<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesInput>> browserGetWebElementAtBrowserDocumentWindowCoordinates)
        {
            var __workflow_browserGetWebElementAtBrowserDocumentWindowCoordinates = WorkflowExpression.Compile(browserGetWebElementAtBrowserDocumentWindowCoordinates, nameof(browserGetWebElementAtBrowserDocumentWindowCoordinates), required: true);
            return new DeferredBodyAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/GetWebElementAtBrowserDocumentWindowCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetWebElementAtBrowserDocumentWindowCoordinates);
                return new ApiConnectionAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse, ApiConnectionActionConfiguration> BrowserGetWebElementPropertiesAsList(Expression<Func<BrowserGetWebElementPropertiesAsListInput>> browserGetWebElementPropertiesAsList)
        {
            var __workflow_browserGetWebElementPropertiesAsList = WorkflowExpression.Compile(browserGetWebElementPropertiesAsList, nameof(browserGetWebElementPropertiesAsList), required: true);
            return new DeferredBodyAction<BrowserGetWebElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/BrowserGetWebElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_browserGetWebElementPropertiesAsList);
                return new ApiConnectionAction<BrowserGetWebElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse, ApiConnectionActionConfiguration> IsBrowserInstanceOpen(Expression<Func<IsBrowserInstanceOpenInput>> isBrowserInstanceOpen)
        {
            var __workflow_isBrowserInstanceOpen = WorkflowExpression.Compile(isBrowserInstanceOpen, nameof(isBrowserInstanceOpen), required: true);
            return new DeferredBodyAction<IsBrowserInstanceOpenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/BrowserControl/IsBrowserInstanceOpen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isBrowserInstanceOpen);
                return new ApiConnectionAction<IsBrowserInstanceOpenResponse>(callPayload);
            });
        }
    }

    public class IaconnectwebbrowserTriggers([ConnectionName] string connectionId)
    {
    }

    public class BrowserGetChromeBrowserVersionFromFileResponse
    {
        public string ChromeBrowserFileVersion { get; set; }
        public int ChromeBrowserMajorVersion { get; set; }
    }

    public class BrowserGetChromeBrowserVersionFromFileInput
    {
        public string ChromeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetChromeDriverFolderResponse
    {
        public string ChromeDriverFolder { get; set; }
    }

    public class BrowserGetChromeDriverFolderInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }
        public int? ChromeMajorVersion { get; set; }
        public string ChromeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserDownloadSuitableChromeDriverFromInternetResponse
    {
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserDownloadSuitableChromeDriverFromInternetInput
    {
        public string ChromeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChromeDriverDownloadParentFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttemptToLocateChromeDriverURLViaXMLIndex { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChromeDriverRootWebPageURL { get; set; } = "https://chromedriver.storage.googleapis.com/";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttemptToLocateChromeDriverURLViaJSONIndex { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChromeDriverJSONIndexWebPageURL { get; set; } = "https://googlechromelabs.github.io/chrome-for-testing/latest-versions-per-milestone-with-downloads.json";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Prefer64bitChromeDriver { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserIsSuitableChromeDriverAvailableResponse
    {
        public string ChromeBrowserFileVersion { get; set; }
        public int ChromeBrowserMajorVersion { get; set; }
        public bool SuitableChromeDriverAvailable { get; set; }
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromeDriverAvailableInput
    {
        public string ChromeDriverFolder { get; set; }
        public string ChromeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserUploadNewChromeDriverInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LocalChromeDriverFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = false;
        public int? ChromeBrowserMajorVersion { get; set; }
        public string ChromeDriverRootSaveFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserOpenChromeResponse
    {
        [JsonProperty("ChromeDriverPID")]
        public int ChromeDriverPId { get; set; }
        public int ChromeDriverTCPPort { get; set; }

        [JsonProperty("ChromePID")]
        public int ChromePId { get; set; }
        public int ChromeTCPPort { get; set; }
        public string ChromeInstanceUserDataDir { get; set; }
        public bool ChromeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserOpenChromeInput
    {
        public string ChromeDriverFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KillExistingChromeDriver { get; set; } = true;
        public string UserDataDir { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintToDefaultPrinter { get; set; } = true;
        public string DefaultDownloadDirectory { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DownloadPDFInsteadOfOpening { get; set; } = false;
        public string ChromeDriverLogFilename { get; set; }
        public string LocalChromeDriverFolder { get; set; }
        public string ChromeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreCertificateErrors { get; set; } = false;
        public string AdditionalArguments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DoNothingIfChromeInstanceAlreadyOpen { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCloseChromeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PurgeDynamicUserDataDir { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PurgeStaticUserDataDir { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserOpenInternetExplorerInput
    {
        public string IEDriverFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KillExistingIEDriver { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KillExistingIE { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CleanSession { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableNativeEvents { get; set; } = true;
        public string WebDriverLogFile { get; set; }
        public string WebDriverLogLevel { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableIEFirstRunCustomise { get; set; } = true;
        public string AdditionalArguments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCloseInternetExplorerInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UnloadIEDriver { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetChromiumEdgeDriverFolderResponse
    {
        public string ChromiumEdgeDriverFolder { get; set; }
    }

    public class BrowserGetChromiumEdgeDriverFolderInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }
        public int? ChromiumEdgeMajorVersion { get; set; }
        public string ChromiumEdgeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetChromiumEdgeBrowserVersionFromFileResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
    }

    public class BrowserGetChromiumEdgeBrowserVersionFromFileInput
    {
        public string ChromiumEdgeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse
    {
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserDownloadSuitableChromiumEdgeDriverFromInternetInput
    {
        public string ChromiumEdgeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChromiumEdgeDriverDownloadParentFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ChromiumEdgeDriverRootWebPageURL { get; set; } = "https://msedgewebdriverstorage.blob.core.windows.net/edgewebdriver/";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserIsSuitableChromiumEdgeDriverAvailableResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
        public bool SuitableChromiumEdgeDriverAvailable { get; set; }
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromiumEdgeDriverAvailableInput
    {
        public string ChromiumEdgeDriverFolder { get; set; }
        public string ChromiumEdgeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserUploadNewChromiumEdgeDriverInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LocalChromiumEdgeDriverFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = false;
        public int? ChromiumEdgeBrowserMajorVersion { get; set; }
        public string ChromiumEdgeDriverRootSaveFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserOpenChromiumEdgeResponse
    {
        [JsonProperty("ChromiumEdgeDriverPID")]
        public int ChromiumEdgeDriverPId { get; set; }
        public int ChromiumEdgeDriverTCPPort { get; set; }

        [JsonProperty("ChromiumEdgePID")]
        public int ChromiumEdgePId { get; set; }
        public int ChromiumEdgeTCPPort { get; set; }
        public string ChromiumEdgeInstanceUserDataDir { get; set; }
        public bool ChromiumEdgeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserOpenChromiumEdgeInput
    {
        public string ChromiumEdgeDriverFolder { get; set; }
        public string UserDataDir { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KillExistingChromiumEdgeDriver { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PrintToDefaultPrinter { get; set; } = true;
        public string DefaultDownloadDirectory { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DownloadPDFInsteadOfOpening { get; set; } = false;
        public string ChromiumEdgeDriverLogFilename { get; set; }
        public string LocalChromiumEdgeDriverFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideBrowserIsBeingAutomatedMessage { get; set; } = true;
        public string ChromiumEdgeBrowserEXE { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreCertificateErrors { get; set; } = false;
        public string AdditionalArguments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DoNothingIfChromiumEdgeInstanceAlreadyOpen { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCloseChromiumEdgeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PurgeDynamicUserDataDir { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PurgeStaticUserDataDir { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserMaximiseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserMinimiseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserFullscreenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserNormaliseBrowserInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? X { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Y { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Width { get; set; } = -40;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Height { get; set; } = -40;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSetWindowSizeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Width { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Height { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSetWindowPositionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int X { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Y { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSetTimeoutsInput
    {
        public double? ElementWaitTimeoutSeconds { get; set; }
        public double? PageLoadTimeoutSeconds { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserNavigateToURLResponse
    {
        public string PageTitle { get; set; }
        public string PageURL { get; set; }
    }

    public class BrowserNavigateToURLInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string URL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserRefreshPageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserResetAllElementHandlesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserDoesElementExistResponse
    {
        public bool ElementExists { get; set; }
    }

    public class BrowserDoesElementExistInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCreateHandleToElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserCreateHandleToElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCreateHandleToParentElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserCreateHandleToParentElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetElementPropertiesResponse
    {
        public string ElementName { get; set; }

        [JsonProperty("ElementID")]
        public string ElementId { get; set; }
        public string ElementTagName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementValue { get; set; }
        public string ElementText { get; set; }
        public bool ElementEnabled { get; set; }
        public bool ElementDisplayed { get; set; }
        public double ElementXCoordinate { get; set; }
        public double ElementYCoordinate { get; set; }
        public double ElementWidth { get; set; }
        public double ElementHeight { get; set; }
        public bool ElementSelected { get; set; }
        public string ElementType { get; set; }
        public string InnerHTML { get; set; }
        public string OuterHTML { get; set; }
        public double ChildElementCount { get; set; }
        public string ParentTagName { get; set; }
        public double ElementHandle { get; set; }
    }

    public class BrowserGetElementPropertiesInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetHTMLCode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetMultipleElementPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserGetMultipleElementPropertiesInput
    {
        public double? ParentElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetHTMLCode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnText { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxValueLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnIsDisplayed { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnCoordinates { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDimensions { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnChildElementCount { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnParentTag { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetElementParentPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class BrowserGetElementParentPropertiesInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetHTMLCode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetElementChildrenPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserGetElementChildrenPropertiesInput
    {
        public double? ParentElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetHTMLCode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnText { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxValueLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnIsDisplayed { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnCoordinates { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDimensions { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnChildElementCount { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnParentTag { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserInputTextIntoElementResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserInputTextIntoElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetExistingValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? InsertPosition { get; set; } = -1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserInputTextIntoMultipleElementsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputElementsJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserPressCtrlKeyOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ControlKey { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserClickElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSubmitElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCheckElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCheckMultipleElementsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputElementsJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetSelectionPropertiesResponse
    {
        public string SelectedOptionText { get; set; }
        public string SelectedOptionValue { get; set; }
        public double NumberOfOptions { get; set; }
        public JToken[] SelectionOptions { get; set; }
    }

    public class BrowserGetSelectionPropertiesInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSelectSelectionInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;
        public string ValueToSelect { get; set; }
        public string TextToSelect { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? IndexToSelect { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserDeselectSelectionInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;
        public string ValueToDeselect { get; set; }
        public string TextToDeselect { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? IndexToDeselect { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserDeselectAllSelectionInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetTableContentsResponse
    {
        public double NumberOfRows { get; set; }
        public double NumberOfColumns { get; set; }
        public string TableContentsJSON { get; set; }
    }

    public class BrowserGetTableContentsInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? CreateColumnNamesFromRow { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MergeChildTables { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        internal bool ReturnAsDataTable { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserScrollElementIntoViewInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserExecuteJavaScriptResponse
    {
        public string JavaScriptResponse { get; set; }
    }

    public class BrowserExecuteJavaScriptInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string JavaScriptCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetElementBoundingRectResponse
    {
        public double ElementLeftPixels { get; set; }
        public double ElementRightPixels { get; set; }
        public double ElementTopPixels { get; set; }
        public double ElementBottomPixels { get; set; }
        public double ElementCenterXPixels { get; set; }
        public double ElementCenterYPixels { get; set; }
    }

    public class BrowserGetElementBoundingRectInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserDrawRectangleAroundElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PenColour { get; set; } = "green";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PenThicknessPixels { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetBrowserParentWindowDetailsResponse
    {
        public string MainWindowElementName { get; set; }
        public string MainWindowElementClassName { get; set; }
        public int MainWindowLeftXPixels { get; set; }
        public int MainWindowTopYPixels { get; set; }
        public int MainWindowWidthPixels { get; set; }
        public int MainWindowHeightPixels { get; set; }
        public string DocumentElementName { get; set; }
        public string DocumentElementClassName { get; set; }
        public int DocumentLeftXPixels { get; set; }
        public int DocumentTopYPixels { get; set; }
        public int DocumentWidthPixels { get; set; }
        public int DocumentHeightPixels { get; set; }
    }

    public class BrowserGetBrowserParentWindowDetailsInput
    {
        [JsonProperty("BrowserPID")]
        public int? BrowserPId { get; set; }
        public string SearchDocumentElementClassName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetElementScreenBoundingRectResponse
    {
        public double ElementScreenLeftPixels { get; set; }
        public double ElementScreenRightPixels { get; set; }
        public double ElementScreenTopPixels { get; set; }
        public double ElementScreenBottomPixels { get; set; }
        public double ElementScreenCenterXPixels { get; set; }
        public double ElementScreenCenterYPixels { get; set; }
        public bool ElementIsOnscreen { get; set; }
        public string OffscreenDirection { get; set; }
    }

    public class BrowserGetElementScreenBoundingRectInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserFocusElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserPressEnterOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserMouseLeftClickOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserMouseRightClickOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserJavaScriptClickOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserExecuteJavaScriptOnElementResponse
    {
        public string JavaScriptResponse { get; set; }
    }

    public class BrowserExecuteJavaScriptOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string JavaScriptToExecute { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGlobalMouseLeftClickOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;
        public int? ClickOffsetX { get; set; }
        public int? ClickOffsetY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGlobalMouseRightClickOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;
        public int? ClickOffsetX { get; set; }
        public int? ClickOffsetY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserOpenNewTabResponse
    {
        public string NewTabName { get; set; }
        public int NewTabIndex { get; set; }
    }

    public class BrowserOpenNewTabInput
    {
        public string URL { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SwitchControlToNewTab { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetTabsResponse
    {
        public int NumberOfTabs { get; set; }
        public string CurrentTabHandle { get; set; }
        public string BrowserTabsJSON { get; set; }
    }

    public class BrowserGetTabsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSetTabInput
    {
        public string TabName { get; set; }
        public int? TabIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCloseActiveTabInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSavePageToFileInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaveFilename { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetPageTextResponse
    {
        public string PageText { get; set; }
    }

    public class BrowserGetPageTextInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSwitchToFrameElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetCurrentFrameWindowPixelCoordinateResponse
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class BrowserGetCurrentFrameWindowPixelCoordinateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSwitchToParentFrameElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSwitchToRootFrameElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserResetFrameStackInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserClearElementTextResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserClearElementTextInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserCopySelectedTextOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserInputPasswordIntoElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ResetExistingValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserPasteIntoElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserPrintCurrentPageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserScrollWindowByPixelsInput
    {
        public double? X { get; set; }
        public double? Y { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserScrollWindowToPixelsInput
    {
        public double? X { get; set; }
        public double? Y { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserSelectAllOnElementInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserWaitForElementToExistResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
    }

    public class BrowserWaitForElementToExistInput
    {
        public double? ParentElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseExplicitWaitConditionsIfPossible { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WaitForSearchElementToBeDisplayed { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class BrowserWaitForElementToNotExistInput
    {
        public double? ParentElementHandle { get; set; }
        public double? SearchElementHandle { get; set; }
        public string SearchElementName { get; set; }

        [JsonProperty("SearchElementID")]
        public string SearchElementId { get; set; }
        public string SearchElementTagName { get; set; }
        public string SearchElementXPath { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementCSSSelector { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementIndex { get; set; } = 1;
        public string SearchElementMatchValue { get; set; }
        public string SearchElementMatchText { get; set; }
        public string SearchElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementMinimumHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SearchElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyElementTopLeftNeedsToBeInBoundingBox { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementStillExists { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchElementMustBeDisplayed { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetWebElementAtScreenCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementAtScreenCoordinatesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? XCoord { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? YCoord { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementAtBrowserDocumentWindowCoordinatesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? XCoord { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? YCoord { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BrowserGetWebElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string ElementPropertiesJSON { get; set; }
    }

    public class BrowserGetWebElementPropertiesAsListInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetHTMLCode { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnText { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxValueLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnCoordinates { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnParentTag { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class IsBrowserInstanceOpenResponse
    {
        public bool IsBrowserInstanceOpen { get; set; }
        public string BrowserName { get; set; }
        public int BrowserMajorVersion { get; set; }
    }

    public class IsBrowserInstanceOpenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser;

    public partial class WorkflowManagedActions
    {
        public IaconnectwebbrowserActions Iaconnectwebbrowser(string connectionId) => new IaconnectwebbrowserActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectwebbrowserTriggers Iaconnectwebbrowser(string connectionId) => new IaconnectwebbrowserTriggers(connectionId);
    }
}