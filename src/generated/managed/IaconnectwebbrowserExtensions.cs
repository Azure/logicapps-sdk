//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectwebbrowser
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectwebbrowserActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse> BrowserGetChromeBrowserVersionFromFile(Expression<Func<string>> browserGetChromeBrowserVersionFromFileWorkflow, Expression<Func<string>> browserGetChromeBrowserVersionFromFileChromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromeBrowserVersionFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromeBrowserVersionFromFile = new JObject();
            var browserGetChromeBrowserVersionFromFilepropCount = 0;
            if (browserGetChromeBrowserVersionFromFileChromeBrowserEXE != null)
            {
                browserGetChromeBrowserVersionFromFile["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromeBrowserVersionFromFileChromeBrowserEXE);
                browserGetChromeBrowserVersionFromFilepropCount++;
            }

            browserGetChromeBrowserVersionFromFilepropCount++;
            browserGetChromeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(browserGetChromeBrowserVersionFromFileWorkflow);
            if (browserGetChromeBrowserVersionFromFilepropCount > 0)
            {
                callPayload.Body = browserGetChromeBrowserVersionFromFile;
            }

            return new ApiConnectionAction<BrowserGetChromeBrowserVersionFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse> BrowserGetChromeDriverFolder(Expression<Func<string>> browserGetChromeDriverFolderDirectoryPath, Expression<Func<string>> browserGetChromeDriverFolderWorkflow, Expression<Func<int>> browserGetChromeDriverFolderChromeMajorVersion = null, Expression<Func<string>> browserGetChromeDriverFolderChromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromeDriverFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromeDriverFolder = new JObject();
            var browserGetChromeDriverFolderpropCount = 0;
            browserGetChromeDriverFolderpropCount++;
            browserGetChromeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderDirectoryPath);
            if (browserGetChromeDriverFolderChromeMajorVersion != null)
            {
                browserGetChromeDriverFolder["ChromeMajorVersion"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderChromeMajorVersion);
                browserGetChromeDriverFolderpropCount++;
            }

            if (browserGetChromeDriverFolderChromeBrowserEXE != null)
            {
                browserGetChromeDriverFolder["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderChromeBrowserEXE);
                browserGetChromeDriverFolderpropCount++;
            }

            browserGetChromeDriverFolderpropCount++;
            browserGetChromeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderWorkflow);
            if (browserGetChromeDriverFolderpropCount > 0)
            {
                callPayload.Body = browserGetChromeDriverFolder;
            }

            return new ApiConnectionAction<BrowserGetChromeDriverFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse> BrowserDownloadSuitableChromeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetChromeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetWorkflow, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetChromeBrowserEXE = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetAttemptToLocateChromeDriverURLViaXMLIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetChromeDriverRootWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetAttemptToLocateChromeDriverURLViaJSONIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetChromeDriverJSONIndexWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetPrefer64bitChromeDriver = null)
        {
            var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromeDriverFromInternet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDownloadSuitableChromeDriverFromInternet = new JObject();
            var browserDownloadSuitableChromeDriverFromInternetpropCount = 0;
            if (browserDownloadSuitableChromeDriverFromInternetChromeBrowserEXE != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetChromeBrowserEXE);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromeDriverFromInternetpropCount++;
            browserDownloadSuitableChromeDriverFromInternet["ChromeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetChromeDriverDownloadParentFolder);
            if (browserDownloadSuitableChromeDriverFromInternetAttemptToLocateChromeDriverURLViaXMLIndex != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetAttemptToLocateChromeDriverURLViaXMLIndex);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetChromeDriverRootWebPageURL != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetChromeDriverRootWebPageURL);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetAttemptToLocateChromeDriverURLViaJSONIndex != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetAttemptToLocateChromeDriverURLViaJSONIndex);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetChromeDriverJSONIndexWebPageURL != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetChromeDriverJSONIndexWebPageURL);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetPrefer64bitChromeDriver != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetPrefer64bitChromeDriver);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromeDriverFromInternetpropCount++;
            browserDownloadSuitableChromeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetWorkflow);
            if (browserDownloadSuitableChromeDriverFromInternetpropCount > 0)
            {
                callPayload.Body = browserDownloadSuitableChromeDriverFromInternet;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse> BrowserIsSuitableChromeDriverAvailable(Expression<Func<string>> browserIsSuitableChromeDriverAvailableWorkflow, Expression<Func<string>> browserIsSuitableChromeDriverAvailableChromeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromeDriverAvailableChromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/IsSuitableChromeDriverAvailable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserIsSuitableChromeDriverAvailable = new JObject();
            var browserIsSuitableChromeDriverAvailablepropCount = 0;
            if (browserIsSuitableChromeDriverAvailableChromeDriverFolder != null)
            {
                browserIsSuitableChromeDriverAvailable["ChromeDriverFolder"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailableChromeDriverFolder);
                browserIsSuitableChromeDriverAvailablepropCount++;
            }

            if (browserIsSuitableChromeDriverAvailableChromeBrowserEXE != null)
            {
                browserIsSuitableChromeDriverAvailable["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailableChromeBrowserEXE);
                browserIsSuitableChromeDriverAvailablepropCount++;
            }

            browserIsSuitableChromeDriverAvailablepropCount++;
            browserIsSuitableChromeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailableWorkflow);
            if (browserIsSuitableChromeDriverAvailablepropCount > 0)
            {
                callPayload.Body = browserIsSuitableChromeDriverAvailable;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromeDriverAvailableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromeDriver(Expression<Func<string>> browserUploadNewChromeDriverLocalChromeDriverFilePath, Expression<Func<string>> browserUploadNewChromeDriverWorkflow, Expression<Func<bool>> browserUploadNewChromeDriverCompress = null, Expression<Func<int>> browserUploadNewChromeDriverChromeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromeDriverChromeDriverRootSaveFolder = null)
        {
            var apiCallPath = "/BrowserControl/UploadNewChromeDriver";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserUploadNewChromeDriver = new JObject();
            var browserUploadNewChromeDriverpropCount = 0;
            browserUploadNewChromeDriverpropCount++;
            browserUploadNewChromeDriver["LocalChromeDriverFilePath"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverLocalChromeDriverFilePath);
            if (browserUploadNewChromeDriverCompress != null)
            {
                browserUploadNewChromeDriver["Compress"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverCompress);
                browserUploadNewChromeDriverpropCount++;
            }

            if (browserUploadNewChromeDriverChromeBrowserMajorVersion != null)
            {
                browserUploadNewChromeDriver["ChromeBrowserMajorVersion"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverChromeBrowserMajorVersion);
                browserUploadNewChromeDriverpropCount++;
            }

            if (browserUploadNewChromeDriverChromeDriverRootSaveFolder != null)
            {
                browserUploadNewChromeDriver["ChromeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverChromeDriverRootSaveFolder);
                browserUploadNewChromeDriverpropCount++;
            }

            browserUploadNewChromeDriverpropCount++;
            browserUploadNewChromeDriver["Workflow"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverWorkflow);
            if (browserUploadNewChromeDriverpropCount > 0)
            {
                callPayload.Body = browserUploadNewChromeDriver;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromeResponse> BrowserOpenChrome(Expression<Func<string>> browserOpenChromeWorkflow, Expression<Func<string>> browserOpenChromeChromeDriverFolder = null, Expression<Func<bool>> browserOpenChromeKillExistingChromeDriver = null, Expression<Func<string>> browserOpenChromeUserDataDir = null, Expression<Func<bool>> browserOpenChromePrintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromeDefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromeDownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromeChromeDriverLogFilename = null, Expression<Func<string>> browserOpenChromeLocalChromeDriverFolder = null, Expression<Func<string>> browserOpenChromeChromeBrowserEXE = null, Expression<Func<bool>> browserOpenChromeIgnoreCertificateErrors = null, Expression<Func<string>> browserOpenChromeAdditionalArguments = null, Expression<Func<bool>> browserOpenChromeDoNothingIfChromeInstanceAlreadyOpen = null)
        {
            var apiCallPath = "/BrowserControl/OpenChrome";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenChrome = new JObject();
            var browserOpenChromepropCount = 0;
            if (browserOpenChromeChromeDriverFolder != null)
            {
                browserOpenChrome["ChromeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromeChromeDriverFolder);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeKillExistingChromeDriver != null)
            {
                browserOpenChrome["KillExistingChromeDriver"] = ExpressionConverter.ConvertO(browserOpenChromeKillExistingChromeDriver);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeUserDataDir != null)
            {
                browserOpenChrome["UserDataDir"] = ExpressionConverter.ConvertO(browserOpenChromeUserDataDir);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromePrintToDefaultPrinter != null)
            {
                browserOpenChrome["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(browserOpenChromePrintToDefaultPrinter);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeDefaultDownloadDirectory != null)
            {
                browserOpenChrome["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(browserOpenChromeDefaultDownloadDirectory);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeDownloadPDFInsteadOfOpening != null)
            {
                browserOpenChrome["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(browserOpenChromeDownloadPDFInsteadOfOpening);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeChromeDriverLogFilename != null)
            {
                browserOpenChrome["ChromeDriverLogFilename"] = ExpressionConverter.ConvertO(browserOpenChromeChromeDriverLogFilename);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeLocalChromeDriverFolder != null)
            {
                browserOpenChrome["LocalChromeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromeLocalChromeDriverFolder);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeChromeBrowserEXE != null)
            {
                browserOpenChrome["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserOpenChromeChromeBrowserEXE);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeIgnoreCertificateErrors != null)
            {
                browserOpenChrome["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(browserOpenChromeIgnoreCertificateErrors);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeAdditionalArguments != null)
            {
                browserOpenChrome["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenChromeAdditionalArguments);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeDoNothingIfChromeInstanceAlreadyOpen != null)
            {
                browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(browserOpenChromeDoNothingIfChromeInstanceAlreadyOpen);
                browserOpenChromepropCount++;
            }

            browserOpenChromepropCount++;
            browserOpenChrome["Workflow"] = ExpressionConverter.ConvertO(browserOpenChromeWorkflow);
            if (browserOpenChromepropCount > 0)
            {
                callPayload.Body = browserOpenChrome;
            }

            return new ApiConnectionAction<BrowserOpenChromeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChrome(Expression<Func<string>> browserCloseChromeWorkflow, Expression<Func<bool>> browserCloseChromePurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromePurgeStaticUserDataDir = null)
        {
            var apiCallPath = "/BrowserControl/CloseChrome";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseChrome = new JObject();
            var browserCloseChromepropCount = 0;
            if (browserCloseChromePurgeDynamicUserDataDir != null)
            {
                browserCloseChrome["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromePurgeDynamicUserDataDir);
                browserCloseChromepropCount++;
            }

            if (browserCloseChromePurgeStaticUserDataDir != null)
            {
                browserCloseChrome["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromePurgeStaticUserDataDir);
                browserCloseChromepropCount++;
            }

            browserCloseChromepropCount++;
            browserCloseChrome["Workflow"] = ExpressionConverter.ConvertO(browserCloseChromeWorkflow);
            if (browserCloseChromepropCount > 0)
            {
                callPayload.Body = browserCloseChrome;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserOpenInternetExplorer(Expression<Func<string>> browserOpenInternetExplorerWorkflow, Expression<Func<string>> browserOpenInternetExplorerIEDriverFolder = null, Expression<Func<bool>> browserOpenInternetExplorerKillExistingIEDriver = null, Expression<Func<bool>> browserOpenInternetExplorerKillExistingIE = null, Expression<Func<bool>> browserOpenInternetExplorerCleanSession = null, Expression<Func<bool>> browserOpenInternetExplorerEnableNativeEvents = null, Expression<Func<string>> browserOpenInternetExplorerWebDriverLogFile = null, Expression<Func<string>> browserOpenInternetExplorerWebDriverLogLevel = null, Expression<Func<bool>> browserOpenInternetExplorerDisableIEFirstRunCustomise = null, Expression<Func<string>> browserOpenInternetExplorerAdditionalArguments = null)
        {
            var apiCallPath = "/BrowserControl/OpenInternetExplorer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenInternetExplorer = new JObject();
            var browserOpenInternetExplorerpropCount = 0;
            if (browserOpenInternetExplorerIEDriverFolder != null)
            {
                browserOpenInternetExplorer["IEDriverFolder"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerIEDriverFolder);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerKillExistingIEDriver != null)
            {
                browserOpenInternetExplorer["KillExistingIEDriver"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerKillExistingIEDriver);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerKillExistingIE != null)
            {
                browserOpenInternetExplorer["KillExistingIE"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerKillExistingIE);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerCleanSession != null)
            {
                browserOpenInternetExplorer["CleanSession"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerCleanSession);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerEnableNativeEvents != null)
            {
                browserOpenInternetExplorer["EnableNativeEvents"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerEnableNativeEvents);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerWebDriverLogFile != null)
            {
                browserOpenInternetExplorer["WebDriverLogFile"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerWebDriverLogFile);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerWebDriverLogLevel != null)
            {
                browserOpenInternetExplorer["WebDriverLogLevel"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerWebDriverLogLevel);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerDisableIEFirstRunCustomise != null)
            {
                browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerDisableIEFirstRunCustomise);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerAdditionalArguments != null)
            {
                browserOpenInternetExplorer["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerAdditionalArguments);
                browserOpenInternetExplorerpropCount++;
            }

            browserOpenInternetExplorerpropCount++;
            browserOpenInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerWorkflow);
            if (browserOpenInternetExplorerpropCount > 0)
            {
                callPayload.Body = browserOpenInternetExplorer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseInternetExplorer(Expression<Func<string>> browserCloseInternetExplorerWorkflow, Expression<Func<bool>> browserCloseInternetExplorerUnloadIEDriver = null)
        {
            var apiCallPath = "/BrowserControl/CloseInternetExplorer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseInternetExplorer = new JObject();
            var browserCloseInternetExplorerpropCount = 0;
            if (browserCloseInternetExplorerUnloadIEDriver != null)
            {
                browserCloseInternetExplorer["UnloadIEDriver"] = ExpressionConverter.ConvertO(browserCloseInternetExplorerUnloadIEDriver);
                browserCloseInternetExplorerpropCount++;
            }

            browserCloseInternetExplorerpropCount++;
            browserCloseInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(browserCloseInternetExplorerWorkflow);
            if (browserCloseInternetExplorerpropCount > 0)
            {
                callPayload.Body = browserCloseInternetExplorer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse> BrowserGetChromiumEdgeDriverFolder(Expression<Func<string>> browserGetChromiumEdgeDriverFolderDirectoryPath, Expression<Func<string>> browserGetChromiumEdgeDriverFolderWorkflow, Expression<Func<int>> browserGetChromiumEdgeDriverFolderChromiumEdgeMajorVersion = null, Expression<Func<string>> browserGetChromiumEdgeDriverFolderChromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromiumEdgeDriverFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromiumEdgeDriverFolder = new JObject();
            var browserGetChromiumEdgeDriverFolderpropCount = 0;
            browserGetChromiumEdgeDriverFolderpropCount++;
            browserGetChromiumEdgeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderDirectoryPath);
            if (browserGetChromiumEdgeDriverFolderChromiumEdgeMajorVersion != null)
            {
                browserGetChromiumEdgeDriverFolder["ChromiumEdgeMajorVersion"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderChromiumEdgeMajorVersion);
                browserGetChromiumEdgeDriverFolderpropCount++;
            }

            if (browserGetChromiumEdgeDriverFolderChromiumEdgeBrowserEXE != null)
            {
                browserGetChromiumEdgeDriverFolder["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderChromiumEdgeBrowserEXE);
                browserGetChromiumEdgeDriverFolderpropCount++;
            }

            browserGetChromiumEdgeDriverFolderpropCount++;
            browserGetChromiumEdgeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderWorkflow);
            if (browserGetChromiumEdgeDriverFolderpropCount > 0)
            {
                callPayload.Body = browserGetChromiumEdgeDriverFolder;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeDriverFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse> BrowserGetChromiumEdgeBrowserVersionFromFile(Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFileWorkflow, Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFileChromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromiumEdgeBrowserVersionFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromiumEdgeBrowserVersionFromFile = new JObject();
            var browserGetChromiumEdgeBrowserVersionFromFilepropCount = 0;
            if (browserGetChromiumEdgeBrowserVersionFromFileChromiumEdgeBrowserEXE != null)
            {
                browserGetChromiumEdgeBrowserVersionFromFile["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeBrowserVersionFromFileChromiumEdgeBrowserEXE);
                browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
            }

            browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
            browserGetChromiumEdgeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeBrowserVersionFromFileWorkflow);
            if (browserGetChromiumEdgeBrowserVersionFromFilepropCount > 0)
            {
                callPayload.Body = browserGetChromiumEdgeBrowserVersionFromFile;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse> BrowserDownloadSuitableChromiumEdgeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetWorkflow, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeBrowserEXE = null, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeDriverRootWebPageURL = null)
        {
            var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromiumEdgeDriverFromInternet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDownloadSuitableChromiumEdgeDriverFromInternet = new JObject();
            var browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount = 0;
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeBrowserEXE != null)
            {
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeBrowserEXE);
                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeDriverDownloadParentFolder);
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeDriverRootWebPageURL != null)
            {
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetChromiumEdgeDriverRootWebPageURL);
                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            browserDownloadSuitableChromiumEdgeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetWorkflow);
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount > 0)
            {
                callPayload.Body = browserDownloadSuitableChromiumEdgeDriverFromInternet;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse> BrowserIsSuitableChromiumEdgeDriverAvailable(Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailableWorkflow, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailableChromiumEdgeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailableChromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/IsSuitableChromiumEdgeDriverAvailable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserIsSuitableChromiumEdgeDriverAvailable = new JObject();
            var browserIsSuitableChromiumEdgeDriverAvailablepropCount = 0;
            if (browserIsSuitableChromiumEdgeDriverAvailableChromiumEdgeDriverFolder != null)
            {
                browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailableChromiumEdgeDriverFolder);
                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            }

            if (browserIsSuitableChromiumEdgeDriverAvailableChromiumEdgeBrowserEXE != null)
            {
                browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailableChromiumEdgeBrowserEXE);
                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            }

            browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            browserIsSuitableChromiumEdgeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailableWorkflow);
            if (browserIsSuitableChromiumEdgeDriverAvailablepropCount > 0)
            {
                callPayload.Body = browserIsSuitableChromiumEdgeDriverAvailable;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromiumEdgeDriver(Expression<Func<string>> browserUploadNewChromiumEdgeDriverLocalChromiumEdgeDriverFilePath, Expression<Func<string>> browserUploadNewChromiumEdgeDriverWorkflow, Expression<Func<bool>> browserUploadNewChromiumEdgeDriverCompress = null, Expression<Func<int>> browserUploadNewChromiumEdgeDriverChromiumEdgeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromiumEdgeDriverChromiumEdgeDriverRootSaveFolder = null)
        {
            var apiCallPath = "/BrowserControl/UploadNewChromiumEdgeDriver";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserUploadNewChromiumEdgeDriver = new JObject();
            var browserUploadNewChromiumEdgeDriverpropCount = 0;
            browserUploadNewChromiumEdgeDriverpropCount++;
            browserUploadNewChromiumEdgeDriver["LocalChromiumEdgeDriverFilePath"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverLocalChromiumEdgeDriverFilePath);
            if (browserUploadNewChromiumEdgeDriverCompress != null)
            {
                browserUploadNewChromiumEdgeDriver["Compress"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverCompress);
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            if (browserUploadNewChromiumEdgeDriverChromiumEdgeBrowserMajorVersion != null)
            {
                browserUploadNewChromiumEdgeDriver["ChromiumEdgeBrowserMajorVersion"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverChromiumEdgeBrowserMajorVersion);
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            if (browserUploadNewChromiumEdgeDriverChromiumEdgeDriverRootSaveFolder != null)
            {
                browserUploadNewChromiumEdgeDriver["ChromiumEdgeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverChromiumEdgeDriverRootSaveFolder);
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            browserUploadNewChromiumEdgeDriverpropCount++;
            browserUploadNewChromiumEdgeDriver["Workflow"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverWorkflow);
            if (browserUploadNewChromiumEdgeDriverpropCount > 0)
            {
                callPayload.Body = browserUploadNewChromiumEdgeDriver;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse> BrowserOpenChromiumEdge(Expression<Func<string>> browserOpenChromiumEdgeWorkflow, Expression<Func<string>> browserOpenChromiumEdgeChromiumEdgeDriverFolder = null, Expression<Func<string>> browserOpenChromiumEdgeUserDataDir = null, Expression<Func<bool>> browserOpenChromiumEdgeKillExistingChromiumEdgeDriver = null, Expression<Func<bool>> browserOpenChromiumEdgePrintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromiumEdgeDefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromiumEdgeDownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromiumEdgeChromiumEdgeDriverLogFilename = null, Expression<Func<string>> browserOpenChromiumEdgeLocalChromiumEdgeDriverFolder = null, Expression<Func<bool>> browserOpenChromiumEdgeHideBrowserIsBeingAutomatedMessage = null, Expression<Func<string>> browserOpenChromiumEdgeChromiumEdgeBrowserEXE = null, Expression<Func<bool>> browserOpenChromiumEdgeIgnoreCertificateErrors = null, Expression<Func<string>> browserOpenChromiumEdgeAdditionalArguments = null, Expression<Func<bool>> browserOpenChromiumEdgeDoNothingIfChromiumEdgeInstanceAlreadyOpen = null)
        {
            var apiCallPath = "/BrowserControl/OpenChromiumEdge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenChromiumEdge = new JObject();
            var browserOpenChromiumEdgepropCount = 0;
            if (browserOpenChromiumEdgeChromiumEdgeDriverFolder != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeChromiumEdgeDriverFolder);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeUserDataDir != null)
            {
                browserOpenChromiumEdge["UserDataDir"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeUserDataDir);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeKillExistingChromiumEdgeDriver != null)
            {
                browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeKillExistingChromiumEdgeDriver);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgePrintToDefaultPrinter != null)
            {
                browserOpenChromiumEdge["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgePrintToDefaultPrinter);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeDefaultDownloadDirectory != null)
            {
                browserOpenChromiumEdge["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeDefaultDownloadDirectory);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeDownloadPDFInsteadOfOpening != null)
            {
                browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeDownloadPDFInsteadOfOpening);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeChromiumEdgeDriverLogFilename != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeDriverLogFilename"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeChromiumEdgeDriverLogFilename);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeLocalChromiumEdgeDriverFolder != null)
            {
                browserOpenChromiumEdge["LocalChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeLocalChromiumEdgeDriverFolder);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeHideBrowserIsBeingAutomatedMessage != null)
            {
                browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeHideBrowserIsBeingAutomatedMessage);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeChromiumEdgeBrowserEXE != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeChromiumEdgeBrowserEXE);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeIgnoreCertificateErrors != null)
            {
                browserOpenChromiumEdge["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeIgnoreCertificateErrors);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeAdditionalArguments != null)
            {
                browserOpenChromiumEdge["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeAdditionalArguments);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeDoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
            {
                browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeDoNothingIfChromiumEdgeInstanceAlreadyOpen);
                browserOpenChromiumEdgepropCount++;
            }

            browserOpenChromiumEdgepropCount++;
            browserOpenChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeWorkflow);
            if (browserOpenChromiumEdgepropCount > 0)
            {
                callPayload.Body = browserOpenChromiumEdge;
            }

            return new ApiConnectionAction<BrowserOpenChromiumEdgeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChromiumEdge(Expression<Func<string>> browserCloseChromiumEdgeWorkflow, Expression<Func<bool>> browserCloseChromiumEdgePurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromiumEdgePurgeStaticUserDataDir = null)
        {
            var apiCallPath = "/BrowserControl/CloseChromiumEdge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseChromiumEdge = new JObject();
            var browserCloseChromiumEdgepropCount = 0;
            if (browserCloseChromiumEdgePurgeDynamicUserDataDir != null)
            {
                browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgePurgeDynamicUserDataDir);
                browserCloseChromiumEdgepropCount++;
            }

            if (browserCloseChromiumEdgePurgeStaticUserDataDir != null)
            {
                browserCloseChromiumEdge["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgePurgeStaticUserDataDir);
                browserCloseChromiumEdgepropCount++;
            }

            browserCloseChromiumEdgepropCount++;
            browserCloseChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgeWorkflow);
            if (browserCloseChromiumEdgepropCount > 0)
            {
                callPayload.Body = browserCloseChromiumEdge;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMaximise(Expression<Func<string>> browserMaximiseWorkflow)
        {
            var apiCallPath = "/BrowserControl/MaximiseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMaximise = new JObject();
            var browserMaximisepropCount = 0;
            browserMaximisepropCount++;
            browserMaximise["Workflow"] = ExpressionConverter.ConvertO(browserMaximiseWorkflow);
            if (browserMaximisepropCount > 0)
            {
                callPayload.Body = browserMaximise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMinimise(Expression<Func<string>> browserMinimiseWorkflow)
        {
            var apiCallPath = "/BrowserControl/MinimiseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMinimise = new JObject();
            var browserMinimisepropCount = 0;
            browserMinimisepropCount++;
            browserMinimise["Workflow"] = ExpressionConverter.ConvertO(browserMinimiseWorkflow);
            if (browserMinimisepropCount > 0)
            {
                callPayload.Body = browserMinimise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFullscreen(Expression<Func<string>> browserFullscreenWorkflow)
        {
            var apiCallPath = "/BrowserControl/FullscreenBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserFullscreen = new JObject();
            var browserFullscreenpropCount = 0;
            browserFullscreenpropCount++;
            browserFullscreen["Workflow"] = ExpressionConverter.ConvertO(browserFullscreenWorkflow);
            if (browserFullscreenpropCount > 0)
            {
                callPayload.Body = browserFullscreen;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserNormaliseBrowser(Expression<Func<string>> browserNormaliseBrowserWorkflow, Expression<Func<int>> browserNormaliseBrowserX = null, Expression<Func<int>> browserNormaliseBrowserY = null, Expression<Func<int>> browserNormaliseBrowserWidth = null, Expression<Func<int>> browserNormaliseBrowserHeight = null)
        {
            var apiCallPath = "/BrowserControl/NormaliseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserNormaliseBrowser = new JObject();
            var browserNormaliseBrowserpropCount = 0;
            if (browserNormaliseBrowserX != null)
            {
                browserNormaliseBrowser["X"] = ExpressionConverter.ConvertO(browserNormaliseBrowserX);
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowserY != null)
            {
                browserNormaliseBrowser["Y"] = ExpressionConverter.ConvertO(browserNormaliseBrowserY);
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowserWidth != null)
            {
                browserNormaliseBrowser["Width"] = ExpressionConverter.ConvertO(browserNormaliseBrowserWidth);
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowserHeight != null)
            {
                browserNormaliseBrowser["Height"] = ExpressionConverter.ConvertO(browserNormaliseBrowserHeight);
                browserNormaliseBrowserpropCount++;
            }

            browserNormaliseBrowserpropCount++;
            browserNormaliseBrowser["Workflow"] = ExpressionConverter.ConvertO(browserNormaliseBrowserWorkflow);
            if (browserNormaliseBrowserpropCount > 0)
            {
                callPayload.Body = browserNormaliseBrowser;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowSize(Expression<Func<int>> browserSetWindowSizeWidth, Expression<Func<int>> browserSetWindowSizeHeight, Expression<Func<string>> browserSetWindowSizeWorkflow)
        {
            var apiCallPath = "/BrowserControl/SetBrowserWindowSize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetWindowSize = new JObject();
            var browserSetWindowSizepropCount = 0;
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Width"] = ExpressionConverter.ConvertO(browserSetWindowSizeWidth);
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Height"] = ExpressionConverter.ConvertO(browserSetWindowSizeHeight);
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Workflow"] = ExpressionConverter.ConvertO(browserSetWindowSizeWorkflow);
            if (browserSetWindowSizepropCount > 0)
            {
                callPayload.Body = browserSetWindowSize;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowPosition(Expression<Func<int>> browserSetWindowPositionX, Expression<Func<int>> browserSetWindowPositionY, Expression<Func<string>> browserSetWindowPositionWorkflow)
        {
            var apiCallPath = "/BrowserControl/SetBrowserWindowPosition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetWindowPosition = new JObject();
            var browserSetWindowPositionpropCount = 0;
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["X"] = ExpressionConverter.ConvertO(browserSetWindowPositionX);
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["Y"] = ExpressionConverter.ConvertO(browserSetWindowPositionY);
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["Workflow"] = ExpressionConverter.ConvertO(browserSetWindowPositionWorkflow);
            if (browserSetWindowPositionpropCount > 0)
            {
                callPayload.Body = browserSetWindowPosition;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTimeouts(Expression<Func<string>> browserSetTimeoutsWorkflow, Expression<Func<double>> browserSetTimeoutsElementWaitTimeoutSeconds = null, Expression<Func<double>> browserSetTimeoutsPageLoadTimeoutSeconds = null)
        {
            var apiCallPath = "/BrowserControl/SetTimeouts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetTimeouts = new JObject();
            var browserSetTimeoutspropCount = 0;
            if (browserSetTimeoutsElementWaitTimeoutSeconds != null)
            {
                browserSetTimeouts["ElementWaitTimeoutSeconds"] = ExpressionConverter.ConvertO(browserSetTimeoutsElementWaitTimeoutSeconds);
                browserSetTimeoutspropCount++;
            }

            if (browserSetTimeoutsPageLoadTimeoutSeconds != null)
            {
                browserSetTimeouts["PageLoadTimeoutSeconds"] = ExpressionConverter.ConvertO(browserSetTimeoutsPageLoadTimeoutSeconds);
                browserSetTimeoutspropCount++;
            }

            browserSetTimeoutspropCount++;
            browserSetTimeouts["Workflow"] = ExpressionConverter.ConvertO(browserSetTimeoutsWorkflow);
            if (browserSetTimeoutspropCount > 0)
            {
                callPayload.Body = browserSetTimeouts;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse> BrowserNavigateToURL(Expression<Func<string>> browserNavigateToURLURL, Expression<Func<string>> browserNavigateToURLWorkflow)
        {
            var apiCallPath = "/BrowserControl/NavigateToURL";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserNavigateToURL = new JObject();
            var browserNavigateToURLpropCount = 0;
            browserNavigateToURLpropCount++;
            browserNavigateToURL["URL"] = ExpressionConverter.ConvertO(browserNavigateToURLURL);
            browserNavigateToURLpropCount++;
            browserNavigateToURL["Workflow"] = ExpressionConverter.ConvertO(browserNavigateToURLWorkflow);
            if (browserNavigateToURLpropCount > 0)
            {
                callPayload.Body = browserNavigateToURL;
            }

            return new ApiConnectionAction<BrowserNavigateToURLResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserRefreshPage(Expression<Func<string>> browserRefreshPageWorkflow)
        {
            var apiCallPath = "/BrowserControl/RefreshPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserRefreshPage = new JObject();
            var browserRefreshPagepropCount = 0;
            browserRefreshPagepropCount++;
            browserRefreshPage["Workflow"] = ExpressionConverter.ConvertO(browserRefreshPageWorkflow);
            if (browserRefreshPagepropCount > 0)
            {
                callPayload.Body = browserRefreshPage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetAllElementHandles(Expression<Func<string>> browserResetAllElementHandlesWorkflow)
        {
            var apiCallPath = "/BrowserControl/ResetAllElementHandles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserResetAllElementHandles = new JObject();
            var browserResetAllElementHandlespropCount = 0;
            browserResetAllElementHandlespropCount++;
            browserResetAllElementHandles["Workflow"] = ExpressionConverter.ConvertO(browserResetAllElementHandlesWorkflow);
            if (browserResetAllElementHandlespropCount > 0)
            {
                callPayload.Body = browserResetAllElementHandles;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse> BrowserDoesElementExist(Expression<Func<string>> browserDoesElementExistWorkflow, Expression<Func<double>> browserDoesElementExistParentElementHandle = null, Expression<Func<double>> browserDoesElementExistSearchElementHandle = null, Expression<Func<string>> browserDoesElementExistSearchElementName = null, Expression<Func<string>> browserDoesElementExistSearchElementID = null, Expression<Func<string>> browserDoesElementExistSearchElementTagName = null, Expression<Func<string>> browserDoesElementExistSearchElementXPath = null, Expression<Func<string>> browserDoesElementExistSearchElementClassName = null, Expression<Func<string>> browserDoesElementExistSearchElementCSSSelector = null, Expression<Func<double>> browserDoesElementExistSearchElementIndex = null, Expression<Func<string>> browserDoesElementExistSearchElementMatchValue = null, Expression<Func<string>> browserDoesElementExistSearchElementMatchText = null, Expression<Func<string>> browserDoesElementExistSearchElementType = null, Expression<Func<double>> browserDoesElementExistSearchElementMinimumWidth = null, Expression<Func<double>> browserDoesElementExistSearchElementMinimumHeight = null, Expression<Func<double>> browserDoesElementExistSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDoesElementExistSearchElementBoundingBoxRight = null, Expression<Func<double>> browserDoesElementExistSearchElementBoundingBoxTop = null, Expression<Func<double>> browserDoesElementExistSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDoesElementExistOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/DoesElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDoesElementExist = new JObject();
            var browserDoesElementExistpropCount = 0;
            if (browserDoesElementExistParentElementHandle != null)
            {
                browserDoesElementExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDoesElementExistParentElementHandle);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementHandle != null)
            {
                browserDoesElementExist["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementHandle);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementName != null)
            {
                browserDoesElementExist["SearchElementName"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementID != null)
            {
                browserDoesElementExist["SearchElementID"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementID);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementTagName != null)
            {
                browserDoesElementExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementTagName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementXPath != null)
            {
                browserDoesElementExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementXPath);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementClassName != null)
            {
                browserDoesElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementClassName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementCSSSelector != null)
            {
                browserDoesElementExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementCSSSelector);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementIndex != null)
            {
                browserDoesElementExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementIndex);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementMatchValue != null)
            {
                browserDoesElementExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementMatchValue);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementMatchText != null)
            {
                browserDoesElementExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementMatchText);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementType != null)
            {
                browserDoesElementExist["SearchElementType"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementType);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementMinimumWidth != null)
            {
                browserDoesElementExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementMinimumWidth);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementMinimumHeight != null)
            {
                browserDoesElementExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementMinimumHeight);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementBoundingBoxLeft != null)
            {
                browserDoesElementExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementBoundingBoxLeft);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementBoundingBoxRight != null)
            {
                browserDoesElementExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementBoundingBoxRight);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementBoundingBoxTop != null)
            {
                browserDoesElementExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementBoundingBoxTop);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistSearchElementBoundingBoxBottom != null)
            {
                browserDoesElementExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDoesElementExistSearchElementBoundingBoxBottom);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDoesElementExistOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserDoesElementExistpropCount++;
            }

            browserDoesElementExistpropCount++;
            browserDoesElementExist["Workflow"] = ExpressionConverter.ConvertO(browserDoesElementExistWorkflow);
            if (browserDoesElementExistpropCount > 0)
            {
                callPayload.Body = browserDoesElementExist;
            }

            return new ApiConnectionAction<BrowserDoesElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse> BrowserCreateHandleToElement(Expression<Func<string>> browserCreateHandleToElementWorkflow, Expression<Func<double>> browserCreateHandleToElementParentElementHandle = null, Expression<Func<double>> browserCreateHandleToElementSearchElementHandle = null, Expression<Func<string>> browserCreateHandleToElementSearchElementName = null, Expression<Func<string>> browserCreateHandleToElementSearchElementID = null, Expression<Func<string>> browserCreateHandleToElementSearchElementTagName = null, Expression<Func<string>> browserCreateHandleToElementSearchElementXPath = null, Expression<Func<string>> browserCreateHandleToElementSearchElementClassName = null, Expression<Func<string>> browserCreateHandleToElementSearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToElementSearchElementIndex = null, Expression<Func<string>> browserCreateHandleToElementSearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToElementSearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToElementSearchElementType = null, Expression<Func<double>> browserCreateHandleToElementSearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToElementSearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CreateHandleToElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCreateHandleToElement = new JObject();
            var browserCreateHandleToElementpropCount = 0;
            if (browserCreateHandleToElementParentElementHandle != null)
            {
                browserCreateHandleToElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToElementParentElementHandle);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementHandle != null)
            {
                browserCreateHandleToElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementHandle);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementName != null)
            {
                browserCreateHandleToElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementID != null)
            {
                browserCreateHandleToElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementID);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementTagName != null)
            {
                browserCreateHandleToElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementTagName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementXPath != null)
            {
                browserCreateHandleToElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementXPath);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementClassName != null)
            {
                browserCreateHandleToElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementClassName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementCSSSelector != null)
            {
                browserCreateHandleToElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementCSSSelector);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementIndex != null)
            {
                browserCreateHandleToElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementIndex);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementMatchValue != null)
            {
                browserCreateHandleToElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementMatchValue);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementMatchText != null)
            {
                browserCreateHandleToElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementMatchText);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementType != null)
            {
                browserCreateHandleToElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementType);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementMinimumWidth != null)
            {
                browserCreateHandleToElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementMinimumWidth);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementMinimumHeight != null)
            {
                browserCreateHandleToElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementMinimumHeight);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementBoundingBoxLeft != null)
            {
                browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementBoundingBoxLeft);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementBoundingBoxRight != null)
            {
                browserCreateHandleToElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementBoundingBoxRight);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementBoundingBoxTop != null)
            {
                browserCreateHandleToElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementBoundingBoxTop);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementSearchElementBoundingBoxBottom != null)
            {
                browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCreateHandleToElementSearchElementBoundingBoxBottom);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCreateHandleToElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserCreateHandleToElementpropCount++;
            }

            browserCreateHandleToElementpropCount++;
            browserCreateHandleToElement["Workflow"] = ExpressionConverter.ConvertO(browserCreateHandleToElementWorkflow);
            if (browserCreateHandleToElementpropCount > 0)
            {
                callPayload.Body = browserCreateHandleToElement;
            }

            return new ApiConnectionAction<BrowserCreateHandleToElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse> BrowserCreateHandleToParentElement(Expression<Func<string>> browserCreateHandleToParentElementWorkflow, Expression<Func<double>> browserCreateHandleToParentElementParentElementHandle = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementHandle = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementName = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementID = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementTagName = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementXPath = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementClassName = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementIndex = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToParentElementSearchElementType = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToParentElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToParentElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CreateHandleToParentElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCreateHandleToParentElement = new JObject();
            var browserCreateHandleToParentElementpropCount = 0;
            if (browserCreateHandleToParentElementParentElementHandle != null)
            {
                browserCreateHandleToParentElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementParentElementHandle);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementHandle != null)
            {
                browserCreateHandleToParentElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementHandle);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementName != null)
            {
                browserCreateHandleToParentElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementID != null)
            {
                browserCreateHandleToParentElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementID);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementTagName != null)
            {
                browserCreateHandleToParentElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementTagName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementXPath != null)
            {
                browserCreateHandleToParentElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementXPath);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementClassName != null)
            {
                browserCreateHandleToParentElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementClassName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementCSSSelector != null)
            {
                browserCreateHandleToParentElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementCSSSelector);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementIndex != null)
            {
                browserCreateHandleToParentElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementIndex);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementMatchValue != null)
            {
                browserCreateHandleToParentElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementMatchValue);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementMatchText != null)
            {
                browserCreateHandleToParentElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementMatchText);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementType != null)
            {
                browserCreateHandleToParentElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementType);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementMinimumWidth != null)
            {
                browserCreateHandleToParentElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementMinimumWidth);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementMinimumHeight != null)
            {
                browserCreateHandleToParentElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementMinimumHeight);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementBoundingBoxLeft != null)
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementBoundingBoxLeft);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementBoundingBoxRight != null)
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementBoundingBoxRight);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementBoundingBoxTop != null)
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementBoundingBoxTop);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementSearchElementBoundingBoxBottom != null)
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementSearchElementBoundingBoxBottom);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserCreateHandleToParentElementpropCount++;
            }

            browserCreateHandleToParentElementpropCount++;
            browserCreateHandleToParentElement["Workflow"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementWorkflow);
            if (browserCreateHandleToParentElementpropCount > 0)
            {
                callPayload.Body = browserCreateHandleToParentElement;
            }

            return new ApiConnectionAction<BrowserCreateHandleToParentElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse> BrowserGetElementProperties(Expression<Func<string>> browserGetElementPropertiesWorkflow, Expression<Func<double>> browserGetElementPropertiesParentElementHandle = null, Expression<Func<double>> browserGetElementPropertiesSearchElementHandle = null, Expression<Func<string>> browserGetElementPropertiesSearchElementName = null, Expression<Func<string>> browserGetElementPropertiesSearchElementID = null, Expression<Func<string>> browserGetElementPropertiesSearchElementTagName = null, Expression<Func<string>> browserGetElementPropertiesSearchElementXPath = null, Expression<Func<string>> browserGetElementPropertiesSearchElementClassName = null, Expression<Func<string>> browserGetElementPropertiesSearchElementCSSSelector = null, Expression<Func<double>> browserGetElementPropertiesSearchElementIndex = null, Expression<Func<string>> browserGetElementPropertiesSearchElementMatchValue = null, Expression<Func<string>> browserGetElementPropertiesSearchElementMatchText = null, Expression<Func<string>> browserGetElementPropertiesSearchElementType = null, Expression<Func<double>> browserGetElementPropertiesSearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementPropertiesSearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementPropertiesSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementPropertiesSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementPropertiesSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementPropertiesSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementPropertiesGetHTMLCode = null, Expression<Func<bool>> browserGetElementPropertiesReturnElementHandle = null)
        {
            var apiCallPath = "/BrowserControl/GetElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementProperties = new JObject();
            var browserGetElementPropertiespropCount = 0;
            if (browserGetElementPropertiesParentElementHandle != null)
            {
                browserGetElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiesParentElementHandle);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementHandle != null)
            {
                browserGetElementProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementHandle);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementName != null)
            {
                browserGetElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementID != null)
            {
                browserGetElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementID);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementTagName != null)
            {
                browserGetElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementTagName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementXPath != null)
            {
                browserGetElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementXPath);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementClassName != null)
            {
                browserGetElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementClassName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementCSSSelector != null)
            {
                browserGetElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementCSSSelector);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementIndex != null)
            {
                browserGetElementProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementIndex);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementMatchValue != null)
            {
                browserGetElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementMatchValue);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementMatchText != null)
            {
                browserGetElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementMatchText);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementType != null)
            {
                browserGetElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementType);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementMinimumWidth != null)
            {
                browserGetElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementMinimumWidth);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementMinimumHeight != null)
            {
                browserGetElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementMinimumHeight);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementBoundingBoxLeft != null)
            {
                browserGetElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementBoundingBoxLeft);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementBoundingBoxRight != null)
            {
                browserGetElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementBoundingBoxRight);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementBoundingBoxTop != null)
            {
                browserGetElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementBoundingBoxTop);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesSearchElementBoundingBoxBottom != null)
            {
                browserGetElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementPropertiesSearchElementBoundingBoxBottom);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesGetHTMLCode != null)
            {
                browserGetElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementPropertiesGetHTMLCode);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesReturnElementHandle != null)
            {
                browserGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiesReturnElementHandle);
                browserGetElementPropertiespropCount++;
            }

            browserGetElementPropertiespropCount++;
            browserGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementPropertiesWorkflow);
            if (browserGetElementPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementProperties;
            }

            return new ApiConnectionAction<BrowserGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse> BrowserGetMultipleElementProperties(Expression<Func<string>> browserGetMultipleElementPropertiesWorkflow, Expression<Func<double>> browserGetMultipleElementPropertiesParentElementHandle = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementName = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementID = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementTagName = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementXPath = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementClassName = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementCSSSelector = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementMatchValue = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementMatchText = null, Expression<Func<string>> browserGetMultipleElementPropertiesSearchElementType = null, Expression<Func<double>> browserGetMultipleElementPropertiesSearchElementMinimumWidth = null, Expression<Func<double>> browserGetMultipleElementPropertiesSearchElementMinimumHeight = null, Expression<Func<double>> browserGetMultipleElementPropertiesSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetMultipleElementPropertiesSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetMultipleElementPropertiesSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetMultipleElementPropertiesSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetMultipleElementPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetMultipleElementPropertiesGetHTMLCode = null, Expression<Func<bool>> browserGetMultipleElementPropertiesCreateHandle = null, Expression<Func<bool>> browserGetMultipleElementPropertiesReturnValue = null, Expression<Func<bool>> browserGetMultipleElementPropertiesReturnText = null, Expression<Func<int>> browserGetMultipleElementPropertiesMaxValueLength = null, Expression<Func<int>> browserGetMultipleElementPropertiesMaxTextLength = null, Expression<Func<bool>> browserGetMultipleElementPropertiesReturnIsDisplayed = null, Expression<Func<bool>> browserGetMultipleElementPropertiesReturnCoordinates = null, Expression<Func<bool>> browserGetMultipleElementPropertiesReturnDimensions = null, Expression<Func<bool>> browserGetMultipleElementPropertiesReturnChildElementCount = null, Expression<Func<bool>> browserGetMultipleElementPropertiesReturnParentTag = null, Expression<Func<int>> browserGetMultipleElementPropertiesFirstItemToReturn = null, Expression<Func<int>> browserGetMultipleElementPropertiesMaxItemsToReturn = null)
        {
            var apiCallPath = "/BrowserControl/GetMultipleElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetMultipleElementProperties = new JObject();
            var browserGetMultipleElementPropertiespropCount = 0;
            if (browserGetMultipleElementPropertiesParentElementHandle != null)
            {
                browserGetMultipleElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesParentElementHandle);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementName != null)
            {
                browserGetMultipleElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementID != null)
            {
                browserGetMultipleElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementID);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementTagName != null)
            {
                browserGetMultipleElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementTagName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementXPath != null)
            {
                browserGetMultipleElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementXPath);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementClassName != null)
            {
                browserGetMultipleElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementClassName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementCSSSelector != null)
            {
                browserGetMultipleElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementCSSSelector);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementMatchValue != null)
            {
                browserGetMultipleElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementMatchValue);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementMatchText != null)
            {
                browserGetMultipleElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementMatchText);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementType != null)
            {
                browserGetMultipleElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementType);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementMinimumWidth != null)
            {
                browserGetMultipleElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementMinimumWidth);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementMinimumHeight != null)
            {
                browserGetMultipleElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementMinimumHeight);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementBoundingBoxLeft != null)
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementBoundingBoxLeft);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementBoundingBoxRight != null)
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementBoundingBoxRight);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementBoundingBoxTop != null)
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementBoundingBoxTop);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesSearchElementBoundingBoxBottom != null)
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesSearchElementBoundingBoxBottom);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesGetHTMLCode != null)
            {
                browserGetMultipleElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesGetHTMLCode);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesCreateHandle != null)
            {
                browserGetMultipleElementProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesCreateHandle);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesReturnValue != null)
            {
                browserGetMultipleElementProperties["ReturnValue"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesReturnValue);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesReturnText != null)
            {
                browserGetMultipleElementProperties["ReturnText"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesReturnText);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesMaxValueLength != null)
            {
                browserGetMultipleElementProperties["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesMaxValueLength);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesMaxTextLength != null)
            {
                browserGetMultipleElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesMaxTextLength);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesReturnIsDisplayed != null)
            {
                browserGetMultipleElementProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesReturnIsDisplayed);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesReturnCoordinates != null)
            {
                browserGetMultipleElementProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesReturnCoordinates);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesReturnDimensions != null)
            {
                browserGetMultipleElementProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesReturnDimensions);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesReturnChildElementCount != null)
            {
                browserGetMultipleElementProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesReturnChildElementCount);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesReturnParentTag != null)
            {
                browserGetMultipleElementProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesReturnParentTag);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesFirstItemToReturn != null)
            {
                browserGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesFirstItemToReturn);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesMaxItemsToReturn != null)
            {
                browserGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesMaxItemsToReturn);
                browserGetMultipleElementPropertiespropCount++;
            }

            browserGetMultipleElementPropertiespropCount++;
            browserGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesWorkflow);
            if (browserGetMultipleElementPropertiespropCount > 0)
            {
                callPayload.Body = browserGetMultipleElementProperties;
            }

            return new ApiConnectionAction<BrowserGetMultipleElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse> BrowserGetElementParentProperties(Expression<Func<string>> browserGetElementParentPropertiesWorkflow, Expression<Func<double>> browserGetElementParentPropertiesParentElementHandle = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementHandle = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementName = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementID = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementTagName = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementXPath = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementClassName = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementCSSSelector = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementIndex = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementMatchValue = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementMatchText = null, Expression<Func<string>> browserGetElementParentPropertiesSearchElementType = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementParentPropertiesSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementParentPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementParentPropertiesGetHTMLCode = null, Expression<Func<bool>> browserGetElementParentPropertiesCreateHandle = null)
        {
            var apiCallPath = "/BrowserControl/GetElementParentProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementParentProperties = new JObject();
            var browserGetElementParentPropertiespropCount = 0;
            if (browserGetElementParentPropertiesParentElementHandle != null)
            {
                browserGetElementParentProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesParentElementHandle);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementHandle != null)
            {
                browserGetElementParentProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementHandle);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementName != null)
            {
                browserGetElementParentProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementID != null)
            {
                browserGetElementParentProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementID);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementTagName != null)
            {
                browserGetElementParentProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementTagName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementXPath != null)
            {
                browserGetElementParentProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementXPath);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementClassName != null)
            {
                browserGetElementParentProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementClassName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementCSSSelector != null)
            {
                browserGetElementParentProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementCSSSelector);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementIndex != null)
            {
                browserGetElementParentProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementIndex);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementMatchValue != null)
            {
                browserGetElementParentProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementMatchValue);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementMatchText != null)
            {
                browserGetElementParentProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementMatchText);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementType != null)
            {
                browserGetElementParentProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementType);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementMinimumWidth != null)
            {
                browserGetElementParentProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementMinimumWidth);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementMinimumHeight != null)
            {
                browserGetElementParentProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementMinimumHeight);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementBoundingBoxLeft != null)
            {
                browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementBoundingBoxLeft);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementBoundingBoxRight != null)
            {
                browserGetElementParentProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementBoundingBoxRight);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementBoundingBoxTop != null)
            {
                browserGetElementParentProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementBoundingBoxTop);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesSearchElementBoundingBoxBottom != null)
            {
                browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesSearchElementBoundingBoxBottom);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesGetHTMLCode != null)
            {
                browserGetElementParentProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesGetHTMLCode);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesCreateHandle != null)
            {
                browserGetElementParentProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesCreateHandle);
                browserGetElementParentPropertiespropCount++;
            }

            browserGetElementParentPropertiespropCount++;
            browserGetElementParentProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesWorkflow);
            if (browserGetElementParentPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementParentProperties;
            }

            return new ApiConnectionAction<BrowserGetElementParentPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse> BrowserGetElementChildrenProperties(Expression<Func<string>> browserGetElementChildrenPropertiesWorkflow, Expression<Func<double>> browserGetElementChildrenPropertiesParentElementHandle = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementName = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementID = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementTagName = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementXPath = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementClassName = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementCSSSelector = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementMatchValue = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementMatchText = null, Expression<Func<string>> browserGetElementChildrenPropertiesSearchElementType = null, Expression<Func<double>> browserGetElementChildrenPropertiesSearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementChildrenPropertiesSearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementChildrenPropertiesSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementChildrenPropertiesSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementChildrenPropertiesSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementChildrenPropertiesSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementChildrenPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementChildrenPropertiesGetHTMLCode = null, Expression<Func<bool>> browserGetElementChildrenPropertiesCreateHandle = null, Expression<Func<bool>> browserGetElementChildrenPropertiesSearchSubTree = null, Expression<Func<bool>> browserGetElementChildrenPropertiesReturnValue = null, Expression<Func<bool>> browserGetElementChildrenPropertiesReturnText = null, Expression<Func<int>> browserGetElementChildrenPropertiesMaxValueLength = null, Expression<Func<int>> browserGetElementChildrenPropertiesMaxTextLength = null, Expression<Func<bool>> browserGetElementChildrenPropertiesReturnIsDisplayed = null, Expression<Func<bool>> browserGetElementChildrenPropertiesReturnCoordinates = null, Expression<Func<bool>> browserGetElementChildrenPropertiesReturnDimensions = null, Expression<Func<bool>> browserGetElementChildrenPropertiesReturnChildElementCount = null, Expression<Func<bool>> browserGetElementChildrenPropertiesReturnParentTag = null, Expression<Func<int>> browserGetElementChildrenPropertiesFirstItemToReturn = null, Expression<Func<int>> browserGetElementChildrenPropertiesMaxItemsToReturn = null)
        {
            var apiCallPath = "/BrowserControl/GetElementChildrenProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementChildrenProperties = new JObject();
            var browserGetElementChildrenPropertiespropCount = 0;
            if (browserGetElementChildrenPropertiesParentElementHandle != null)
            {
                browserGetElementChildrenProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesParentElementHandle);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementName != null)
            {
                browserGetElementChildrenProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementID != null)
            {
                browserGetElementChildrenProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementID);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementTagName != null)
            {
                browserGetElementChildrenProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementTagName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementXPath != null)
            {
                browserGetElementChildrenProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementXPath);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementClassName != null)
            {
                browserGetElementChildrenProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementClassName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementCSSSelector != null)
            {
                browserGetElementChildrenProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementCSSSelector);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementMatchValue != null)
            {
                browserGetElementChildrenProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementMatchValue);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementMatchText != null)
            {
                browserGetElementChildrenProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementMatchText);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementType != null)
            {
                browserGetElementChildrenProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementType);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementMinimumWidth != null)
            {
                browserGetElementChildrenProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementMinimumWidth);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementMinimumHeight != null)
            {
                browserGetElementChildrenProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementMinimumHeight);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementBoundingBoxLeft != null)
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementBoundingBoxLeft);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementBoundingBoxRight != null)
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementBoundingBoxRight);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementBoundingBoxTop != null)
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementBoundingBoxTop);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchElementBoundingBoxBottom != null)
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchElementBoundingBoxBottom);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesGetHTMLCode != null)
            {
                browserGetElementChildrenProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesGetHTMLCode);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesCreateHandle != null)
            {
                browserGetElementChildrenProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesCreateHandle);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesSearchSubTree != null)
            {
                browserGetElementChildrenProperties["SearchSubTree"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesSearchSubTree);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesReturnValue != null)
            {
                browserGetElementChildrenProperties["ReturnValue"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesReturnValue);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesReturnText != null)
            {
                browserGetElementChildrenProperties["ReturnText"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesReturnText);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesMaxValueLength != null)
            {
                browserGetElementChildrenProperties["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesMaxValueLength);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesMaxTextLength != null)
            {
                browserGetElementChildrenProperties["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesMaxTextLength);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesReturnIsDisplayed != null)
            {
                browserGetElementChildrenProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesReturnIsDisplayed);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesReturnCoordinates != null)
            {
                browserGetElementChildrenProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesReturnCoordinates);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesReturnDimensions != null)
            {
                browserGetElementChildrenProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesReturnDimensions);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesReturnChildElementCount != null)
            {
                browserGetElementChildrenProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesReturnChildElementCount);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesReturnParentTag != null)
            {
                browserGetElementChildrenProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesReturnParentTag);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesFirstItemToReturn != null)
            {
                browserGetElementChildrenProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesFirstItemToReturn);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesMaxItemsToReturn != null)
            {
                browserGetElementChildrenProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesMaxItemsToReturn);
                browserGetElementChildrenPropertiespropCount++;
            }

            browserGetElementChildrenPropertiespropCount++;
            browserGetElementChildrenProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesWorkflow);
            if (browserGetElementChildrenPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementChildrenProperties;
            }

            return new ApiConnectionAction<BrowserGetElementChildrenPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse> BrowserInputTextIntoElement(Expression<Func<string>> browserInputTextIntoElementWorkflow, Expression<Func<double>> browserInputTextIntoElementParentElementHandle = null, Expression<Func<double>> browserInputTextIntoElementSearchElementHandle = null, Expression<Func<string>> browserInputTextIntoElementSearchElementName = null, Expression<Func<string>> browserInputTextIntoElementSearchElementID = null, Expression<Func<string>> browserInputTextIntoElementSearchElementTagName = null, Expression<Func<string>> browserInputTextIntoElementSearchElementXPath = null, Expression<Func<string>> browserInputTextIntoElementSearchElementClassName = null, Expression<Func<string>> browserInputTextIntoElementSearchElementCSSSelector = null, Expression<Func<double>> browserInputTextIntoElementSearchElementIndex = null, Expression<Func<string>> browserInputTextIntoElementSearchElementMatchValue = null, Expression<Func<string>> browserInputTextIntoElementSearchElementMatchText = null, Expression<Func<string>> browserInputTextIntoElementSearchElementType = null, Expression<Func<double>> browserInputTextIntoElementSearchElementMinimumWidth = null, Expression<Func<double>> browserInputTextIntoElementSearchElementMinimumHeight = null, Expression<Func<double>> browserInputTextIntoElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputTextIntoElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputTextIntoElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputTextIntoElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputTextIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserInputTextIntoElementTextToInput = null, Expression<Func<bool>> browserInputTextIntoElementResetExistingValue = null, Expression<Func<int>> browserInputTextIntoElementInsertPosition = null)
        {
            var apiCallPath = "/BrowserControl/InputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputTextIntoElement = new JObject();
            var browserInputTextIntoElementpropCount = 0;
            if (browserInputTextIntoElementParentElementHandle != null)
            {
                browserInputTextIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserInputTextIntoElementParentElementHandle);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementHandle != null)
            {
                browserInputTextIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementHandle);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementName != null)
            {
                browserInputTextIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementID != null)
            {
                browserInputTextIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementID);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementTagName != null)
            {
                browserInputTextIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementTagName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementXPath != null)
            {
                browserInputTextIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementXPath);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementClassName != null)
            {
                browserInputTextIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementClassName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementCSSSelector != null)
            {
                browserInputTextIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementCSSSelector);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementIndex != null)
            {
                browserInputTextIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementIndex);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementMatchValue != null)
            {
                browserInputTextIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementMatchValue);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementMatchText != null)
            {
                browserInputTextIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementMatchText);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementType != null)
            {
                browserInputTextIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementType);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementMinimumWidth != null)
            {
                browserInputTextIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementMinimumWidth);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementMinimumHeight != null)
            {
                browserInputTextIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementMinimumHeight);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementBoundingBoxLeft != null)
            {
                browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementBoundingBoxLeft);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementBoundingBoxRight != null)
            {
                browserInputTextIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementBoundingBoxRight);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementBoundingBoxTop != null)
            {
                browserInputTextIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementBoundingBoxTop);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementSearchElementBoundingBoxBottom != null)
            {
                browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserInputTextIntoElementSearchElementBoundingBoxBottom);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserInputTextIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementTextToInput != null)
            {
                browserInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(browserInputTextIntoElementTextToInput);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementResetExistingValue != null)
            {
                browserInputTextIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(browserInputTextIntoElementResetExistingValue);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementInsertPosition != null)
            {
                browserInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(browserInputTextIntoElementInsertPosition);
                browserInputTextIntoElementpropCount++;
            }

            browserInputTextIntoElementpropCount++;
            browserInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserInputTextIntoElementWorkflow);
            if (browserInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = browserInputTextIntoElement;
            }

            return new ApiConnectionAction<BrowserInputTextIntoElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputTextIntoMultipleElements(Expression<Func<string>> browserInputTextIntoMultipleElementsInputElementsJSON, Expression<Func<string>> browserInputTextIntoMultipleElementsWorkflow)
        {
            var apiCallPath = "/BrowserControl/BrowserInputTextIntoMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputTextIntoMultipleElements = new JObject();
            var browserInputTextIntoMultipleElementspropCount = 0;
            browserInputTextIntoMultipleElementspropCount++;
            browserInputTextIntoMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(browserInputTextIntoMultipleElementsInputElementsJSON);
            browserInputTextIntoMultipleElementspropCount++;
            browserInputTextIntoMultipleElements["Workflow"] = ExpressionConverter.ConvertO(browserInputTextIntoMultipleElementsWorkflow);
            if (browserInputTextIntoMultipleElementspropCount > 0)
            {
                callPayload.Body = browserInputTextIntoMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressCtrlKeyOnElement(Expression<Func<string>> browserPressCtrlKeyOnElementControlKey, Expression<Func<string>> browserPressCtrlKeyOnElementWorkflow, Expression<Func<double>> browserPressCtrlKeyOnElementParentElementHandle = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementHandle = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementName = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementID = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementTagName = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementXPath = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementClassName = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementIndex = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementMatchValue = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementMatchText = null, Expression<Func<string>> browserPressCtrlKeyOnElementSearchElementType = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressCtrlKeyOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressCtrlKeyOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PressCtrlKeyOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPressCtrlKeyOnElement = new JObject();
            var browserPressCtrlKeyOnElementpropCount = 0;
            if (browserPressCtrlKeyOnElementParentElementHandle != null)
            {
                browserPressCtrlKeyOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementParentElementHandle);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementHandle != null)
            {
                browserPressCtrlKeyOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementHandle);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementID != null)
            {
                browserPressCtrlKeyOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementID);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementTagName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementTagName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementXPath != null)
            {
                browserPressCtrlKeyOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementXPath);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementClassName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementClassName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementCSSSelector != null)
            {
                browserPressCtrlKeyOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementCSSSelector);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementIndex != null)
            {
                browserPressCtrlKeyOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementIndex);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementMatchValue != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementMatchValue);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementMatchText != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementMatchText);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementType != null)
            {
                browserPressCtrlKeyOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementType);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementMinimumWidth != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementMinimumWidth);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementMinimumHeight != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementMinimumHeight);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementBoundingBoxLeft != null)
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementBoundingBoxLeft);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementBoundingBoxRight != null)
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementBoundingBoxRight);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementBoundingBoxTop != null)
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementBoundingBoxTop);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementSearchElementBoundingBoxBottom != null)
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementSearchElementBoundingBoxBottom);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserPressCtrlKeyOnElementpropCount++;
            }

            browserPressCtrlKeyOnElementpropCount++;
            browserPressCtrlKeyOnElement["ControlKey"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementControlKey);
            browserPressCtrlKeyOnElementpropCount++;
            browserPressCtrlKeyOnElement["Workflow"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementWorkflow);
            if (browserPressCtrlKeyOnElementpropCount > 0)
            {
                callPayload.Body = browserPressCtrlKeyOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserClickElement(Expression<Func<string>> browserClickElementWorkflow, Expression<Func<double>> browserClickElementParentElementHandle = null, Expression<Func<double>> browserClickElementSearchElementHandle = null, Expression<Func<string>> browserClickElementSearchElementName = null, Expression<Func<string>> browserClickElementSearchElementID = null, Expression<Func<string>> browserClickElementSearchElementTagName = null, Expression<Func<string>> browserClickElementSearchElementXPath = null, Expression<Func<string>> browserClickElementSearchElementClassName = null, Expression<Func<string>> browserClickElementSearchElementCSSSelector = null, Expression<Func<double>> browserClickElementSearchElementIndex = null, Expression<Func<string>> browserClickElementSearchElementMatchValue = null, Expression<Func<string>> browserClickElementSearchElementMatchText = null, Expression<Func<string>> browserClickElementSearchElementType = null, Expression<Func<double>> browserClickElementSearchElementMinimumWidth = null, Expression<Func<double>> browserClickElementSearchElementMinimumHeight = null, Expression<Func<double>> browserClickElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClickElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserClickElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserClickElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClickElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ClickElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserClickElement = new JObject();
            var browserClickElementpropCount = 0;
            if (browserClickElementParentElementHandle != null)
            {
                browserClickElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserClickElementParentElementHandle);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementHandle != null)
            {
                browserClickElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserClickElementSearchElementHandle);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementName != null)
            {
                browserClickElement["SearchElementName"] = ExpressionConverter.ConvertO(browserClickElementSearchElementName);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementID != null)
            {
                browserClickElement["SearchElementID"] = ExpressionConverter.ConvertO(browserClickElementSearchElementID);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementTagName != null)
            {
                browserClickElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserClickElementSearchElementTagName);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementXPath != null)
            {
                browserClickElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserClickElementSearchElementXPath);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementClassName != null)
            {
                browserClickElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserClickElementSearchElementClassName);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementCSSSelector != null)
            {
                browserClickElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserClickElementSearchElementCSSSelector);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementIndex != null)
            {
                browserClickElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserClickElementSearchElementIndex);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementMatchValue != null)
            {
                browserClickElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserClickElementSearchElementMatchValue);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementMatchText != null)
            {
                browserClickElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserClickElementSearchElementMatchText);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementType != null)
            {
                browserClickElement["SearchElementType"] = ExpressionConverter.ConvertO(browserClickElementSearchElementType);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementMinimumWidth != null)
            {
                browserClickElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserClickElementSearchElementMinimumWidth);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementMinimumHeight != null)
            {
                browserClickElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserClickElementSearchElementMinimumHeight);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementBoundingBoxLeft != null)
            {
                browserClickElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserClickElementSearchElementBoundingBoxLeft);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementBoundingBoxRight != null)
            {
                browserClickElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserClickElementSearchElementBoundingBoxRight);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementBoundingBoxTop != null)
            {
                browserClickElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserClickElementSearchElementBoundingBoxTop);
                browserClickElementpropCount++;
            }

            if (browserClickElementSearchElementBoundingBoxBottom != null)
            {
                browserClickElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserClickElementSearchElementBoundingBoxBottom);
                browserClickElementpropCount++;
            }

            if (browserClickElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserClickElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserClickElementpropCount++;
            }

            browserClickElementpropCount++;
            browserClickElement["Workflow"] = ExpressionConverter.ConvertO(browserClickElementWorkflow);
            if (browserClickElementpropCount > 0)
            {
                callPayload.Body = browserClickElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSubmitElement(Expression<Func<string>> browserSubmitElementWorkflow, Expression<Func<double>> browserSubmitElementParentElementHandle = null, Expression<Func<double>> browserSubmitElementSearchElementHandle = null, Expression<Func<string>> browserSubmitElementSearchElementName = null, Expression<Func<string>> browserSubmitElementSearchElementID = null, Expression<Func<string>> browserSubmitElementSearchElementTagName = null, Expression<Func<string>> browserSubmitElementSearchElementXPath = null, Expression<Func<string>> browserSubmitElementSearchElementClassName = null, Expression<Func<string>> browserSubmitElementSearchElementCSSSelector = null, Expression<Func<double>> browserSubmitElementSearchElementIndex = null, Expression<Func<string>> browserSubmitElementSearchElementMatchValue = null, Expression<Func<string>> browserSubmitElementSearchElementMatchText = null, Expression<Func<string>> browserSubmitElementSearchElementType = null, Expression<Func<double>> browserSubmitElementSearchElementMinimumWidth = null, Expression<Func<double>> browserSubmitElementSearchElementMinimumHeight = null, Expression<Func<double>> browserSubmitElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSubmitElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserSubmitElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserSubmitElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSubmitElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SubmitElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSubmitElement = new JObject();
            var browserSubmitElementpropCount = 0;
            if (browserSubmitElementParentElementHandle != null)
            {
                browserSubmitElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSubmitElementParentElementHandle);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementHandle != null)
            {
                browserSubmitElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementHandle);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementName != null)
            {
                browserSubmitElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementID != null)
            {
                browserSubmitElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementID);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementTagName != null)
            {
                browserSubmitElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementTagName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementXPath != null)
            {
                browserSubmitElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementXPath);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementClassName != null)
            {
                browserSubmitElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementClassName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementCSSSelector != null)
            {
                browserSubmitElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementCSSSelector);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementIndex != null)
            {
                browserSubmitElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementIndex);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementMatchValue != null)
            {
                browserSubmitElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementMatchValue);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementMatchText != null)
            {
                browserSubmitElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementMatchText);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementType != null)
            {
                browserSubmitElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementType);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementMinimumWidth != null)
            {
                browserSubmitElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementMinimumWidth);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementMinimumHeight != null)
            {
                browserSubmitElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementMinimumHeight);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementBoundingBoxLeft != null)
            {
                browserSubmitElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementBoundingBoxLeft);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementBoundingBoxRight != null)
            {
                browserSubmitElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementBoundingBoxRight);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementBoundingBoxTop != null)
            {
                browserSubmitElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementBoundingBoxTop);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementSearchElementBoundingBoxBottom != null)
            {
                browserSubmitElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSubmitElementSearchElementBoundingBoxBottom);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSubmitElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserSubmitElementpropCount++;
            }

            browserSubmitElementpropCount++;
            browserSubmitElement["Workflow"] = ExpressionConverter.ConvertO(browserSubmitElementWorkflow);
            if (browserSubmitElementpropCount > 0)
            {
                callPayload.Body = browserSubmitElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckElement(Expression<Func<string>> browserCheckElementWorkflow, Expression<Func<double>> browserCheckElementParentElementHandle = null, Expression<Func<double>> browserCheckElementSearchElementHandle = null, Expression<Func<string>> browserCheckElementSearchElementName = null, Expression<Func<string>> browserCheckElementSearchElementID = null, Expression<Func<string>> browserCheckElementSearchElementTagName = null, Expression<Func<string>> browserCheckElementSearchElementXPath = null, Expression<Func<string>> browserCheckElementSearchElementClassName = null, Expression<Func<string>> browserCheckElementSearchElementCSSSelector = null, Expression<Func<double>> browserCheckElementSearchElementIndex = null, Expression<Func<string>> browserCheckElementSearchElementMatchValue = null, Expression<Func<string>> browserCheckElementSearchElementMatchText = null, Expression<Func<string>> browserCheckElementSearchElementType = null, Expression<Func<double>> browserCheckElementSearchElementMinimumWidth = null, Expression<Func<double>> browserCheckElementSearchElementMinimumHeight = null, Expression<Func<double>> browserCheckElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCheckElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserCheckElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserCheckElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCheckElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserCheckElementCheckElement = null)
        {
            var apiCallPath = "/BrowserControl/CheckElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCheckElement = new JObject();
            var browserCheckElementpropCount = 0;
            if (browserCheckElementParentElementHandle != null)
            {
                browserCheckElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCheckElementParentElementHandle);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementHandle != null)
            {
                browserCheckElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementHandle);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementName != null)
            {
                browserCheckElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementID != null)
            {
                browserCheckElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementID);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementTagName != null)
            {
                browserCheckElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementTagName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementXPath != null)
            {
                browserCheckElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementXPath);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementClassName != null)
            {
                browserCheckElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementClassName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementCSSSelector != null)
            {
                browserCheckElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementCSSSelector);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementIndex != null)
            {
                browserCheckElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementIndex);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementMatchValue != null)
            {
                browserCheckElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementMatchValue);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementMatchText != null)
            {
                browserCheckElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementMatchText);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementType != null)
            {
                browserCheckElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementType);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementMinimumWidth != null)
            {
                browserCheckElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementMinimumWidth);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementMinimumHeight != null)
            {
                browserCheckElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementMinimumHeight);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementBoundingBoxLeft != null)
            {
                browserCheckElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementBoundingBoxLeft);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementBoundingBoxRight != null)
            {
                browserCheckElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementBoundingBoxRight);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementBoundingBoxTop != null)
            {
                browserCheckElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementBoundingBoxTop);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementSearchElementBoundingBoxBottom != null)
            {
                browserCheckElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCheckElementSearchElementBoundingBoxBottom);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCheckElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementCheckElement != null)
            {
                browserCheckElement["CheckElement"] = ExpressionConverter.ConvertO(browserCheckElementCheckElement);
                browserCheckElementpropCount++;
            }

            browserCheckElementpropCount++;
            browserCheckElement["Workflow"] = ExpressionConverter.ConvertO(browserCheckElementWorkflow);
            if (browserCheckElementpropCount > 0)
            {
                callPayload.Body = browserCheckElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckMultipleElements(Expression<Func<string>> browserCheckMultipleElementsInputElementsJSON, Expression<Func<string>> browserCheckMultipleElementsWorkflow)
        {
            var apiCallPath = "/BrowserControl/BrowserCheckMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCheckMultipleElements = new JObject();
            var browserCheckMultipleElementspropCount = 0;
            browserCheckMultipleElementspropCount++;
            browserCheckMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(browserCheckMultipleElementsInputElementsJSON);
            browserCheckMultipleElementspropCount++;
            browserCheckMultipleElements["Workflow"] = ExpressionConverter.ConvertO(browserCheckMultipleElementsWorkflow);
            if (browserCheckMultipleElementspropCount > 0)
            {
                callPayload.Body = browserCheckMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse> BrowserGetSelectionProperties(Expression<Func<string>> browserGetSelectionPropertiesWorkflow, Expression<Func<double>> browserGetSelectionPropertiesParentElementHandle = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementHandle = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementName = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementID = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementTagName = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementXPath = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementClassName = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementCSSSelector = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementIndex = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementMatchValue = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementMatchText = null, Expression<Func<string>> browserGetSelectionPropertiesSearchElementType = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementMinimumWidth = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementMinimumHeight = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetSelectionPropertiesSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetSelectionPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetSelectionProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetSelectionProperties = new JObject();
            var browserGetSelectionPropertiespropCount = 0;
            if (browserGetSelectionPropertiesParentElementHandle != null)
            {
                browserGetSelectionProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesParentElementHandle);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementHandle != null)
            {
                browserGetSelectionProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementHandle);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementName != null)
            {
                browserGetSelectionProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementID != null)
            {
                browserGetSelectionProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementID);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementTagName != null)
            {
                browserGetSelectionProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementTagName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementXPath != null)
            {
                browserGetSelectionProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementXPath);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementClassName != null)
            {
                browserGetSelectionProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementClassName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementCSSSelector != null)
            {
                browserGetSelectionProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementCSSSelector);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementIndex != null)
            {
                browserGetSelectionProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementIndex);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementMatchValue != null)
            {
                browserGetSelectionProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementMatchValue);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementMatchText != null)
            {
                browserGetSelectionProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementMatchText);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementType != null)
            {
                browserGetSelectionProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementType);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementMinimumWidth != null)
            {
                browserGetSelectionProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementMinimumWidth);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementMinimumHeight != null)
            {
                browserGetSelectionProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementMinimumHeight);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementBoundingBoxLeft != null)
            {
                browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementBoundingBoxLeft);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementBoundingBoxRight != null)
            {
                browserGetSelectionProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementBoundingBoxRight);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementBoundingBoxTop != null)
            {
                browserGetSelectionProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementBoundingBoxTop);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesSearchElementBoundingBoxBottom != null)
            {
                browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesSearchElementBoundingBoxBottom);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetSelectionPropertiespropCount++;
            }

            browserGetSelectionPropertiespropCount++;
            browserGetSelectionProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesWorkflow);
            if (browserGetSelectionPropertiespropCount > 0)
            {
                callPayload.Body = browserGetSelectionProperties;
            }

            return new ApiConnectionAction<BrowserGetSelectionPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectSelection(Expression<Func<string>> browserSelectSelectionWorkflow, Expression<Func<double>> browserSelectSelectionParentElementHandle = null, Expression<Func<double>> browserSelectSelectionSearchElementHandle = null, Expression<Func<string>> browserSelectSelectionSearchElementName = null, Expression<Func<string>> browserSelectSelectionSearchElementID = null, Expression<Func<string>> browserSelectSelectionSearchElementTagName = null, Expression<Func<string>> browserSelectSelectionSearchElementXPath = null, Expression<Func<string>> browserSelectSelectionSearchElementClassName = null, Expression<Func<string>> browserSelectSelectionSearchElementCSSSelector = null, Expression<Func<double>> browserSelectSelectionSearchElementIndex = null, Expression<Func<string>> browserSelectSelectionSearchElementMatchValue = null, Expression<Func<string>> browserSelectSelectionSearchElementMatchText = null, Expression<Func<string>> browserSelectSelectionSearchElementType = null, Expression<Func<double>> browserSelectSelectionSearchElementMinimumWidth = null, Expression<Func<double>> browserSelectSelectionSearchElementMinimumHeight = null, Expression<Func<double>> browserSelectSelectionSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectSelectionSearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectSelectionSearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectSelectionSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectSelectionOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserSelectSelectionValueToSelect = null, Expression<Func<string>> browserSelectSelectionTextToSelect = null, Expression<Func<double>> browserSelectSelectionIndexToSelect = null)
        {
            var apiCallPath = "/BrowserControl/SelectSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSelectSelection = new JObject();
            var browserSelectSelectionpropCount = 0;
            if (browserSelectSelectionParentElementHandle != null)
            {
                browserSelectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSelectSelectionParentElementHandle);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementHandle != null)
            {
                browserSelectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementHandle);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementName != null)
            {
                browserSelectSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementID != null)
            {
                browserSelectSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementID);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementTagName != null)
            {
                browserSelectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementTagName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementXPath != null)
            {
                browserSelectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementXPath);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementClassName != null)
            {
                browserSelectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementClassName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementCSSSelector != null)
            {
                browserSelectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementCSSSelector);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementIndex != null)
            {
                browserSelectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementIndex);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementMatchValue != null)
            {
                browserSelectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementMatchValue);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementMatchText != null)
            {
                browserSelectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementMatchText);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementType != null)
            {
                browserSelectSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementType);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementMinimumWidth != null)
            {
                browserSelectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementMinimumWidth);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementMinimumHeight != null)
            {
                browserSelectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementMinimumHeight);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementBoundingBoxLeft != null)
            {
                browserSelectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementBoundingBoxLeft);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementBoundingBoxRight != null)
            {
                browserSelectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementBoundingBoxRight);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementBoundingBoxTop != null)
            {
                browserSelectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementBoundingBoxTop);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionSearchElementBoundingBoxBottom != null)
            {
                browserSelectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSelectSelectionSearchElementBoundingBoxBottom);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSelectSelectionOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionValueToSelect != null)
            {
                browserSelectSelection["ValueToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectionValueToSelect);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionTextToSelect != null)
            {
                browserSelectSelection["TextToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectionTextToSelect);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionIndexToSelect != null)
            {
                browserSelectSelection["IndexToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectionIndexToSelect);
                browserSelectSelectionpropCount++;
            }

            browserSelectSelectionpropCount++;
            browserSelectSelection["Workflow"] = ExpressionConverter.ConvertO(browserSelectSelectionWorkflow);
            if (browserSelectSelectionpropCount > 0)
            {
                callPayload.Body = browserSelectSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectSelection(Expression<Func<string>> browserDeselectSelectionWorkflow, Expression<Func<double>> browserDeselectSelectionParentElementHandle = null, Expression<Func<double>> browserDeselectSelectionSearchElementHandle = null, Expression<Func<string>> browserDeselectSelectionSearchElementName = null, Expression<Func<string>> browserDeselectSelectionSearchElementID = null, Expression<Func<string>> browserDeselectSelectionSearchElementTagName = null, Expression<Func<string>> browserDeselectSelectionSearchElementXPath = null, Expression<Func<string>> browserDeselectSelectionSearchElementClassName = null, Expression<Func<string>> browserDeselectSelectionSearchElementCSSSelector = null, Expression<Func<double>> browserDeselectSelectionSearchElementIndex = null, Expression<Func<string>> browserDeselectSelectionSearchElementMatchValue = null, Expression<Func<string>> browserDeselectSelectionSearchElementMatchText = null, Expression<Func<string>> browserDeselectSelectionSearchElementType = null, Expression<Func<double>> browserDeselectSelectionSearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectSelectionSearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectSelectionSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectSelectionSearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectSelectionSearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectSelectionSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectSelectionOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDeselectSelectionValueToDeselect = null, Expression<Func<string>> browserDeselectSelectionTextToDeselect = null, Expression<Func<double>> browserDeselectSelectionIndexToDeselect = null)
        {
            var apiCallPath = "/BrowserControl/DeselectSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDeselectSelection = new JObject();
            var browserDeselectSelectionpropCount = 0;
            if (browserDeselectSelectionParentElementHandle != null)
            {
                browserDeselectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDeselectSelectionParentElementHandle);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementHandle != null)
            {
                browserDeselectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementHandle);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementName != null)
            {
                browserDeselectSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementID != null)
            {
                browserDeselectSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementID);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementTagName != null)
            {
                browserDeselectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementTagName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementXPath != null)
            {
                browserDeselectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementXPath);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementClassName != null)
            {
                browserDeselectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementClassName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementCSSSelector != null)
            {
                browserDeselectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementCSSSelector);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementIndex != null)
            {
                browserDeselectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementIndex);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementMatchValue != null)
            {
                browserDeselectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementMatchValue);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementMatchText != null)
            {
                browserDeselectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementMatchText);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementType != null)
            {
                browserDeselectSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementType);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementMinimumWidth != null)
            {
                browserDeselectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementMinimumWidth);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementMinimumHeight != null)
            {
                browserDeselectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementMinimumHeight);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementBoundingBoxLeft != null)
            {
                browserDeselectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementBoundingBoxLeft);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementBoundingBoxRight != null)
            {
                browserDeselectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementBoundingBoxRight);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementBoundingBoxTop != null)
            {
                browserDeselectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementBoundingBoxTop);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionSearchElementBoundingBoxBottom != null)
            {
                browserDeselectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDeselectSelectionSearchElementBoundingBoxBottom);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDeselectSelectionOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionValueToDeselect != null)
            {
                browserDeselectSelection["ValueToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectionValueToDeselect);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionTextToDeselect != null)
            {
                browserDeselectSelection["TextToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectionTextToDeselect);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionIndexToDeselect != null)
            {
                browserDeselectSelection["IndexToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectionIndexToDeselect);
                browserDeselectSelectionpropCount++;
            }

            browserDeselectSelectionpropCount++;
            browserDeselectSelection["Workflow"] = ExpressionConverter.ConvertO(browserDeselectSelectionWorkflow);
            if (browserDeselectSelectionpropCount > 0)
            {
                callPayload.Body = browserDeselectSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectAllSelection(Expression<Func<string>> browserDeselectAllSelectionWorkflow, Expression<Func<double>> browserDeselectAllSelectionParentElementHandle = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementHandle = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementName = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementID = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementTagName = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementXPath = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementClassName = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementCSSSelector = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementIndex = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementMatchValue = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementMatchText = null, Expression<Func<string>> browserDeselectAllSelectionSearchElementType = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectAllSelectionSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectAllSelectionOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/DeselectAllSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDeselectAllSelection = new JObject();
            var browserDeselectAllSelectionpropCount = 0;
            if (browserDeselectAllSelectionParentElementHandle != null)
            {
                browserDeselectAllSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionParentElementHandle);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementHandle != null)
            {
                browserDeselectAllSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementHandle);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementName != null)
            {
                browserDeselectAllSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementID != null)
            {
                browserDeselectAllSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementID);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementTagName != null)
            {
                browserDeselectAllSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementTagName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementXPath != null)
            {
                browserDeselectAllSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementXPath);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementClassName != null)
            {
                browserDeselectAllSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementClassName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementCSSSelector != null)
            {
                browserDeselectAllSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementCSSSelector);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementIndex != null)
            {
                browserDeselectAllSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementIndex);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementMatchValue != null)
            {
                browserDeselectAllSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementMatchValue);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementMatchText != null)
            {
                browserDeselectAllSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementMatchText);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementType != null)
            {
                browserDeselectAllSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementType);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementMinimumWidth != null)
            {
                browserDeselectAllSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementMinimumWidth);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementMinimumHeight != null)
            {
                browserDeselectAllSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementMinimumHeight);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementBoundingBoxLeft != null)
            {
                browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementBoundingBoxLeft);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementBoundingBoxRight != null)
            {
                browserDeselectAllSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementBoundingBoxRight);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementBoundingBoxTop != null)
            {
                browserDeselectAllSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementBoundingBoxTop);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionSearchElementBoundingBoxBottom != null)
            {
                browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionSearchElementBoundingBoxBottom);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserDeselectAllSelectionpropCount++;
            }

            browserDeselectAllSelectionpropCount++;
            browserDeselectAllSelection["Workflow"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionWorkflow);
            if (browserDeselectAllSelectionpropCount > 0)
            {
                callPayload.Body = browserDeselectAllSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse> BrowserGetTableContents(Expression<Func<string>> browserGetTableContentsWorkflow, Expression<Func<double>> browserGetTableContentsParentElementHandle = null, Expression<Func<double>> browserGetTableContentsSearchElementHandle = null, Expression<Func<string>> browserGetTableContentsSearchElementName = null, Expression<Func<string>> browserGetTableContentsSearchElementID = null, Expression<Func<string>> browserGetTableContentsSearchElementTagName = null, Expression<Func<string>> browserGetTableContentsSearchElementXPath = null, Expression<Func<string>> browserGetTableContentsSearchElementClassName = null, Expression<Func<string>> browserGetTableContentsSearchElementCSSSelector = null, Expression<Func<double>> browserGetTableContentsSearchElementIndex = null, Expression<Func<string>> browserGetTableContentsSearchElementMatchValue = null, Expression<Func<string>> browserGetTableContentsSearchElementMatchText = null, Expression<Func<string>> browserGetTableContentsSearchElementType = null, Expression<Func<double>> browserGetTableContentsSearchElementMinimumWidth = null, Expression<Func<double>> browserGetTableContentsSearchElementMinimumHeight = null, Expression<Func<double>> browserGetTableContentsSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetTableContentsSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetTableContentsSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetTableContentsSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetTableContentsOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<double>> browserGetTableContentsCreateColumnNamesFromRow = null, Expression<Func<bool>> browserGetTableContentsMergeChildTables = null)
        {
            var apiCallPath = "/BrowserControl/GetTableContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetTableContents = new JObject();
            var browserGetTableContentspropCount = 0;
            if (browserGetTableContentsParentElementHandle != null)
            {
                browserGetTableContents["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetTableContentsParentElementHandle);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementHandle != null)
            {
                browserGetTableContents["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementHandle);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementName != null)
            {
                browserGetTableContents["SearchElementName"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementID != null)
            {
                browserGetTableContents["SearchElementID"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementID);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementTagName != null)
            {
                browserGetTableContents["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementTagName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementXPath != null)
            {
                browserGetTableContents["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementXPath);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementClassName != null)
            {
                browserGetTableContents["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementClassName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementCSSSelector != null)
            {
                browserGetTableContents["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementCSSSelector);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementIndex != null)
            {
                browserGetTableContents["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementIndex);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementMatchValue != null)
            {
                browserGetTableContents["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementMatchValue);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementMatchText != null)
            {
                browserGetTableContents["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementMatchText);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementType != null)
            {
                browserGetTableContents["SearchElementType"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementType);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementMinimumWidth != null)
            {
                browserGetTableContents["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementMinimumWidth);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementMinimumHeight != null)
            {
                browserGetTableContents["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementMinimumHeight);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementBoundingBoxLeft != null)
            {
                browserGetTableContents["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementBoundingBoxLeft);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementBoundingBoxRight != null)
            {
                browserGetTableContents["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementBoundingBoxRight);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementBoundingBoxTop != null)
            {
                browserGetTableContents["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementBoundingBoxTop);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsSearchElementBoundingBoxBottom != null)
            {
                browserGetTableContents["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetTableContentsSearchElementBoundingBoxBottom);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetTableContentsOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsCreateColumnNamesFromRow != null)
            {
                browserGetTableContents["CreateColumnNamesFromRow"] = ExpressionConverter.ConvertO(browserGetTableContentsCreateColumnNamesFromRow);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsMergeChildTables != null)
            {
                browserGetTableContents["MergeChildTables"] = ExpressionConverter.ConvertO(browserGetTableContentsMergeChildTables);
                browserGetTableContentspropCount++;
            }

            browserGetTableContents["ReturnAsDataTable"] = true;
            browserGetTableContentspropCount++;
            browserGetTableContentspropCount++;
            browserGetTableContents["Workflow"] = ExpressionConverter.ConvertO(browserGetTableContentsWorkflow);
            if (browserGetTableContentspropCount > 0)
            {
                callPayload.Body = browserGetTableContents;
            }

            return new ApiConnectionAction<BrowserGetTableContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollElementIntoView(Expression<Func<string>> browserScrollElementIntoViewWorkflow, Expression<Func<double>> browserScrollElementIntoViewParentElementHandle = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementHandle = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementName = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementID = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementTagName = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementXPath = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementClassName = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementCSSSelector = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementIndex = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementMatchValue = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementMatchText = null, Expression<Func<string>> browserScrollElementIntoViewSearchElementType = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementMinimumWidth = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementMinimumHeight = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementBoundingBoxRight = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementBoundingBoxTop = null, Expression<Func<double>> browserScrollElementIntoViewSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserScrollElementIntoViewOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ScrollElementIntoView";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollElementIntoView = new JObject();
            var browserScrollElementIntoViewpropCount = 0;
            if (browserScrollElementIntoViewParentElementHandle != null)
            {
                browserScrollElementIntoView["ParentElementHandle"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewParentElementHandle);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementHandle != null)
            {
                browserScrollElementIntoView["SearchElementHandle"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementHandle);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementName != null)
            {
                browserScrollElementIntoView["SearchElementName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementID != null)
            {
                browserScrollElementIntoView["SearchElementID"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementID);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementTagName != null)
            {
                browserScrollElementIntoView["SearchElementTagName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementTagName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementXPath != null)
            {
                browserScrollElementIntoView["SearchElementXPath"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementXPath);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementClassName != null)
            {
                browserScrollElementIntoView["SearchElementClassName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementClassName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementCSSSelector != null)
            {
                browserScrollElementIntoView["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementCSSSelector);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementIndex != null)
            {
                browserScrollElementIntoView["SearchElementIndex"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementIndex);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementMatchValue != null)
            {
                browserScrollElementIntoView["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementMatchValue);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementMatchText != null)
            {
                browserScrollElementIntoView["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementMatchText);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementType != null)
            {
                browserScrollElementIntoView["SearchElementType"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementType);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementMinimumWidth != null)
            {
                browserScrollElementIntoView["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementMinimumWidth);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementMinimumHeight != null)
            {
                browserScrollElementIntoView["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementMinimumHeight);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementBoundingBoxLeft != null)
            {
                browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementBoundingBoxLeft);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementBoundingBoxRight != null)
            {
                browserScrollElementIntoView["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementBoundingBoxRight);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementBoundingBoxTop != null)
            {
                browserScrollElementIntoView["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementBoundingBoxTop);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewSearchElementBoundingBoxBottom != null)
            {
                browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewSearchElementBoundingBoxBottom);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserScrollElementIntoViewpropCount++;
            }

            browserScrollElementIntoViewpropCount++;
            browserScrollElementIntoView["Workflow"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewWorkflow);
            if (browserScrollElementIntoViewpropCount > 0)
            {
                callPayload.Body = browserScrollElementIntoView;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse> BrowserExecuteJavaScript(Expression<Func<string>> browserExecuteJavaScriptJavaScriptCode, Expression<Func<string>> browserExecuteJavaScriptWorkflow)
        {
            var apiCallPath = "/BrowserControl/ExecuteJavaScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserExecuteJavaScript = new JObject();
            var browserExecuteJavaScriptpropCount = 0;
            browserExecuteJavaScriptpropCount++;
            browserExecuteJavaScript["JavaScriptCode"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptJavaScriptCode);
            browserExecuteJavaScriptpropCount++;
            browserExecuteJavaScript["Workflow"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptWorkflow);
            if (browserExecuteJavaScriptpropCount > 0)
            {
                callPayload.Body = browserExecuteJavaScript;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse> BrowserGetElementBoundingRect(Expression<Func<string>> browserGetElementBoundingRectWorkflow, Expression<Func<double>> browserGetElementBoundingRectParentElementHandle = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementHandle = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementName = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementID = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementTagName = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementXPath = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementClassName = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementCSSSelector = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementIndex = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementMatchValue = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementMatchText = null, Expression<Func<string>> browserGetElementBoundingRectSearchElementType = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementBoundingRectSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementBoundingRectOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetElementBoundingRect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementBoundingRect = new JObject();
            var browserGetElementBoundingRectpropCount = 0;
            if (browserGetElementBoundingRectParentElementHandle != null)
            {
                browserGetElementBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectParentElementHandle);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementHandle != null)
            {
                browserGetElementBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementHandle);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementName != null)
            {
                browserGetElementBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementID != null)
            {
                browserGetElementBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementID);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementTagName != null)
            {
                browserGetElementBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementTagName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementXPath != null)
            {
                browserGetElementBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementXPath);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementClassName != null)
            {
                browserGetElementBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementClassName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementCSSSelector != null)
            {
                browserGetElementBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementCSSSelector);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementIndex != null)
            {
                browserGetElementBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementIndex);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementMatchValue != null)
            {
                browserGetElementBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementMatchValue);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementMatchText != null)
            {
                browserGetElementBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementMatchText);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementType != null)
            {
                browserGetElementBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementType);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementMinimumWidth != null)
            {
                browserGetElementBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementMinimumWidth);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementMinimumHeight != null)
            {
                browserGetElementBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementMinimumHeight);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementBoundingBoxLeft != null)
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementBoundingBoxLeft);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementBoundingBoxRight != null)
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementBoundingBoxRight);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementBoundingBoxTop != null)
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementBoundingBoxTop);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectSearchElementBoundingBoxBottom != null)
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectSearchElementBoundingBoxBottom);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetElementBoundingRectpropCount++;
            }

            browserGetElementBoundingRectpropCount++;
            browserGetElementBoundingRect["Workflow"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectWorkflow);
            if (browserGetElementBoundingRectpropCount > 0)
            {
                callPayload.Body = browserGetElementBoundingRect;
            }

            return new ApiConnectionAction<BrowserGetElementBoundingRectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDrawRectangleAroundElement(Expression<Func<string>> browserDrawRectangleAroundElementWorkflow, Expression<Func<double>> browserDrawRectangleAroundElementParentElementHandle = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementHandle = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementName = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementID = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementTagName = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementXPath = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementClassName = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementCSSSelector = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementIndex = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementMatchValue = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementMatchText = null, Expression<Func<string>> browserDrawRectangleAroundElementSearchElementType = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementMinimumWidth = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementMinimumHeight = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserDrawRectangleAroundElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDrawRectangleAroundElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDrawRectangleAroundElementPenColour = null, Expression<Func<int>> browserDrawRectangleAroundElementPenThicknessPixels = null)
        {
            var apiCallPath = "/BrowserControl/DrawRectangleAroundElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDrawRectangleAroundElement = new JObject();
            var browserDrawRectangleAroundElementpropCount = 0;
            if (browserDrawRectangleAroundElementParentElementHandle != null)
            {
                browserDrawRectangleAroundElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementParentElementHandle);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementHandle != null)
            {
                browserDrawRectangleAroundElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementHandle);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementName != null)
            {
                browserDrawRectangleAroundElement["SearchElementName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementID != null)
            {
                browserDrawRectangleAroundElement["SearchElementID"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementID);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementTagName != null)
            {
                browserDrawRectangleAroundElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementTagName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementXPath != null)
            {
                browserDrawRectangleAroundElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementXPath);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementClassName != null)
            {
                browserDrawRectangleAroundElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementClassName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementCSSSelector != null)
            {
                browserDrawRectangleAroundElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementCSSSelector);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementIndex != null)
            {
                browserDrawRectangleAroundElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementIndex);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementMatchValue != null)
            {
                browserDrawRectangleAroundElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementMatchValue);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementMatchText != null)
            {
                browserDrawRectangleAroundElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementMatchText);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementType != null)
            {
                browserDrawRectangleAroundElement["SearchElementType"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementType);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementMinimumWidth != null)
            {
                browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementMinimumWidth);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementMinimumHeight != null)
            {
                browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementMinimumHeight);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementBoundingBoxLeft != null)
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementBoundingBoxLeft);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementBoundingBoxRight != null)
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementBoundingBoxRight);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementBoundingBoxTop != null)
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementBoundingBoxTop);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementSearchElementBoundingBoxBottom != null)
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementSearchElementBoundingBoxBottom);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementPenColour != null)
            {
                browserDrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementPenColour);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementPenThicknessPixels != null)
            {
                browserDrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementPenThicknessPixels);
                browserDrawRectangleAroundElementpropCount++;
            }

            browserDrawRectangleAroundElementpropCount++;
            browserDrawRectangleAroundElement["Workflow"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementWorkflow);
            if (browserDrawRectangleAroundElementpropCount > 0)
            {
                callPayload.Body = browserDrawRectangleAroundElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse> BrowserGetBrowserParentWindowDetails(Expression<Func<string>> browserGetBrowserParentWindowDetailsWorkflow, Expression<Func<int>> browserGetBrowserParentWindowDetailsBrowserPID = null, Expression<Func<string>> browserGetBrowserParentWindowDetailsSearchDocumentElementClassName = null)
        {
            var apiCallPath = "/BrowserControl/GetBrowserParentWindowDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetBrowserParentWindowDetails = new JObject();
            var browserGetBrowserParentWindowDetailspropCount = 0;
            if (browserGetBrowserParentWindowDetailsBrowserPID != null)
            {
                browserGetBrowserParentWindowDetails["BrowserPID"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailsBrowserPID);
                browserGetBrowserParentWindowDetailspropCount++;
            }

            if (browserGetBrowserParentWindowDetailsSearchDocumentElementClassName != null)
            {
                browserGetBrowserParentWindowDetails["SearchDocumentElementClassName"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailsSearchDocumentElementClassName);
                browserGetBrowserParentWindowDetailspropCount++;
            }

            browserGetBrowserParentWindowDetailspropCount++;
            browserGetBrowserParentWindowDetails["Workflow"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailsWorkflow);
            if (browserGetBrowserParentWindowDetailspropCount > 0)
            {
                callPayload.Body = browserGetBrowserParentWindowDetails;
            }

            return new ApiConnectionAction<BrowserGetBrowserParentWindowDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse> BrowserGetElementScreenBoundingRect(Expression<Func<string>> browserGetElementScreenBoundingRectWorkflow, Expression<Func<double>> browserGetElementScreenBoundingRectParentElementHandle = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementHandle = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementName = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementID = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementTagName = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementXPath = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementClassName = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementCSSSelector = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementIndex = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementMatchValue = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementMatchText = null, Expression<Func<string>> browserGetElementScreenBoundingRectSearchElementType = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementScreenBoundingRectSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementScreenBoundingRectOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetElementScreenBoundingRect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementScreenBoundingRect = new JObject();
            var browserGetElementScreenBoundingRectpropCount = 0;
            if (browserGetElementScreenBoundingRectParentElementHandle != null)
            {
                browserGetElementScreenBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectParentElementHandle);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementHandle != null)
            {
                browserGetElementScreenBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementHandle);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementID != null)
            {
                browserGetElementScreenBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementID);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementTagName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementTagName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementXPath != null)
            {
                browserGetElementScreenBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementXPath);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementClassName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementClassName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementCSSSelector != null)
            {
                browserGetElementScreenBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementCSSSelector);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementIndex != null)
            {
                browserGetElementScreenBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementIndex);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementMatchValue != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementMatchValue);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementMatchText != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementMatchText);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementType != null)
            {
                browserGetElementScreenBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementType);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementMinimumWidth != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementMinimumWidth);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementMinimumHeight != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementMinimumHeight);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementBoundingBoxLeft != null)
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementBoundingBoxLeft);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementBoundingBoxRight != null)
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementBoundingBoxRight);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementBoundingBoxTop != null)
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementBoundingBoxTop);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectSearchElementBoundingBoxBottom != null)
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectSearchElementBoundingBoxBottom);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGetElementScreenBoundingRectpropCount++;
            }

            browserGetElementScreenBoundingRectpropCount++;
            browserGetElementScreenBoundingRect["Workflow"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectWorkflow);
            if (browserGetElementScreenBoundingRectpropCount > 0)
            {
                callPayload.Body = browserGetElementScreenBoundingRect;
            }

            return new ApiConnectionAction<BrowserGetElementScreenBoundingRectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFocusElement(Expression<Func<string>> browserFocusElementWorkflow, Expression<Func<double>> browserFocusElementParentElementHandle = null, Expression<Func<double>> browserFocusElementSearchElementHandle = null, Expression<Func<string>> browserFocusElementSearchElementName = null, Expression<Func<string>> browserFocusElementSearchElementID = null, Expression<Func<string>> browserFocusElementSearchElementTagName = null, Expression<Func<string>> browserFocusElementSearchElementXPath = null, Expression<Func<string>> browserFocusElementSearchElementClassName = null, Expression<Func<string>> browserFocusElementSearchElementCSSSelector = null, Expression<Func<double>> browserFocusElementSearchElementIndex = null, Expression<Func<string>> browserFocusElementSearchElementMatchValue = null, Expression<Func<string>> browserFocusElementSearchElementMatchText = null, Expression<Func<string>> browserFocusElementSearchElementType = null, Expression<Func<double>> browserFocusElementSearchElementMinimumWidth = null, Expression<Func<double>> browserFocusElementSearchElementMinimumHeight = null, Expression<Func<double>> browserFocusElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserFocusElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserFocusElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserFocusElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserFocusElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/FocusElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserFocusElement = new JObject();
            var browserFocusElementpropCount = 0;
            if (browserFocusElementParentElementHandle != null)
            {
                browserFocusElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserFocusElementParentElementHandle);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementHandle != null)
            {
                browserFocusElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementHandle);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementName != null)
            {
                browserFocusElement["SearchElementName"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementID != null)
            {
                browserFocusElement["SearchElementID"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementID);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementTagName != null)
            {
                browserFocusElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementTagName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementXPath != null)
            {
                browserFocusElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementXPath);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementClassName != null)
            {
                browserFocusElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementClassName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementCSSSelector != null)
            {
                browserFocusElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementCSSSelector);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementIndex != null)
            {
                browserFocusElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementIndex);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementMatchValue != null)
            {
                browserFocusElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementMatchValue);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementMatchText != null)
            {
                browserFocusElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementMatchText);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementType != null)
            {
                browserFocusElement["SearchElementType"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementType);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementMinimumWidth != null)
            {
                browserFocusElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementMinimumWidth);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementMinimumHeight != null)
            {
                browserFocusElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementMinimumHeight);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementBoundingBoxLeft != null)
            {
                browserFocusElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementBoundingBoxLeft);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementBoundingBoxRight != null)
            {
                browserFocusElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementBoundingBoxRight);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementBoundingBoxTop != null)
            {
                browserFocusElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementBoundingBoxTop);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementSearchElementBoundingBoxBottom != null)
            {
                browserFocusElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserFocusElementSearchElementBoundingBoxBottom);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserFocusElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserFocusElementpropCount++;
            }

            browserFocusElementpropCount++;
            browserFocusElement["Workflow"] = ExpressionConverter.ConvertO(browserFocusElementWorkflow);
            if (browserFocusElementpropCount > 0)
            {
                callPayload.Body = browserFocusElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressEnterOnElement(Expression<Func<string>> browserPressEnterOnElementWorkflow, Expression<Func<double>> browserPressEnterOnElementParentElementHandle = null, Expression<Func<double>> browserPressEnterOnElementSearchElementHandle = null, Expression<Func<string>> browserPressEnterOnElementSearchElementName = null, Expression<Func<string>> browserPressEnterOnElementSearchElementID = null, Expression<Func<string>> browserPressEnterOnElementSearchElementTagName = null, Expression<Func<string>> browserPressEnterOnElementSearchElementXPath = null, Expression<Func<string>> browserPressEnterOnElementSearchElementClassName = null, Expression<Func<string>> browserPressEnterOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserPressEnterOnElementSearchElementIndex = null, Expression<Func<string>> browserPressEnterOnElementSearchElementMatchValue = null, Expression<Func<string>> browserPressEnterOnElementSearchElementMatchText = null, Expression<Func<string>> browserPressEnterOnElementSearchElementType = null, Expression<Func<double>> browserPressEnterOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserPressEnterOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserPressEnterOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressEnterOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressEnterOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressEnterOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressEnterOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PressEnterOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPressEnterOnElement = new JObject();
            var browserPressEnterOnElementpropCount = 0;
            if (browserPressEnterOnElementParentElementHandle != null)
            {
                browserPressEnterOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPressEnterOnElementParentElementHandle);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementHandle != null)
            {
                browserPressEnterOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementHandle);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementName != null)
            {
                browserPressEnterOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementID != null)
            {
                browserPressEnterOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementID);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementTagName != null)
            {
                browserPressEnterOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementTagName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementXPath != null)
            {
                browserPressEnterOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementXPath);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementClassName != null)
            {
                browserPressEnterOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementClassName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementCSSSelector != null)
            {
                browserPressEnterOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementCSSSelector);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementIndex != null)
            {
                browserPressEnterOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementIndex);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementMatchValue != null)
            {
                browserPressEnterOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementMatchValue);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementMatchText != null)
            {
                browserPressEnterOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementMatchText);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementType != null)
            {
                browserPressEnterOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementType);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementMinimumWidth != null)
            {
                browserPressEnterOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementMinimumWidth);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementMinimumHeight != null)
            {
                browserPressEnterOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementMinimumHeight);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementBoundingBoxLeft != null)
            {
                browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementBoundingBoxLeft);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementBoundingBoxRight != null)
            {
                browserPressEnterOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementBoundingBoxRight);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementBoundingBoxTop != null)
            {
                browserPressEnterOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementBoundingBoxTop);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementSearchElementBoundingBoxBottom != null)
            {
                browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPressEnterOnElementSearchElementBoundingBoxBottom);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPressEnterOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserPressEnterOnElementpropCount++;
            }

            browserPressEnterOnElementpropCount++;
            browserPressEnterOnElement["Workflow"] = ExpressionConverter.ConvertO(browserPressEnterOnElementWorkflow);
            if (browserPressEnterOnElementpropCount > 0)
            {
                callPayload.Body = browserPressEnterOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseLeftClickOnElement(Expression<Func<string>> browserMouseLeftClickOnElementWorkflow, Expression<Func<double>> browserMouseLeftClickOnElementParentElementHandle = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementHandle = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementName = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementID = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementTagName = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementXPath = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementClassName = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementIndex = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementMatchValue = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementMatchText = null, Expression<Func<string>> browserMouseLeftClickOnElementSearchElementType = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseLeftClickOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseLeftClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseLeftClickOnElementFocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/MouseLeftClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMouseLeftClickOnElement = new JObject();
            var browserMouseLeftClickOnElementpropCount = 0;
            if (browserMouseLeftClickOnElementParentElementHandle != null)
            {
                browserMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementParentElementHandle);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementHandle != null)
            {
                browserMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementHandle);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementName != null)
            {
                browserMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementID != null)
            {
                browserMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementID);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementTagName != null)
            {
                browserMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementTagName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementXPath != null)
            {
                browserMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementXPath);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementClassName != null)
            {
                browserMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementClassName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementCSSSelector != null)
            {
                browserMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementCSSSelector);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementIndex != null)
            {
                browserMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementIndex);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementMatchValue != null)
            {
                browserMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementMatchValue);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementMatchText != null)
            {
                browserMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementMatchText);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementType != null)
            {
                browserMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementType);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementMinimumWidth != null)
            {
                browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementMinimumWidth);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementMinimumHeight != null)
            {
                browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementMinimumHeight);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementBoundingBoxLeft != null)
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementBoundingBoxLeft);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementBoundingBoxRight != null)
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementBoundingBoxRight);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementBoundingBoxTop != null)
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementBoundingBoxTop);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementSearchElementBoundingBoxBottom != null)
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementSearchElementBoundingBoxBottom);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementFocusFirst != null)
            {
                browserMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementFocusFirst);
                browserMouseLeftClickOnElementpropCount++;
            }

            browserMouseLeftClickOnElementpropCount++;
            browserMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementWorkflow);
            if (browserMouseLeftClickOnElementpropCount > 0)
            {
                callPayload.Body = browserMouseLeftClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseRightClickOnElement(Expression<Func<string>> browserMouseRightClickOnElementWorkflow, Expression<Func<double>> browserMouseRightClickOnElementParentElementHandle = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementHandle = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementName = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementID = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementTagName = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementXPath = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementClassName = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementIndex = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementMatchValue = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementMatchText = null, Expression<Func<string>> browserMouseRightClickOnElementSearchElementType = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseRightClickOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseRightClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseRightClickOnElementFocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/MouseRightClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMouseRightClickOnElement = new JObject();
            var browserMouseRightClickOnElementpropCount = 0;
            if (browserMouseRightClickOnElementParentElementHandle != null)
            {
                browserMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementParentElementHandle);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementHandle != null)
            {
                browserMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementHandle);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementName != null)
            {
                browserMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementID != null)
            {
                browserMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementID);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementTagName != null)
            {
                browserMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementTagName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementXPath != null)
            {
                browserMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementXPath);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementClassName != null)
            {
                browserMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementClassName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementCSSSelector != null)
            {
                browserMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementCSSSelector);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementIndex != null)
            {
                browserMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementIndex);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementMatchValue != null)
            {
                browserMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementMatchValue);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementMatchText != null)
            {
                browserMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementMatchText);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementType != null)
            {
                browserMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementType);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementMinimumWidth != null)
            {
                browserMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementMinimumWidth);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementMinimumHeight != null)
            {
                browserMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementMinimumHeight);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementBoundingBoxLeft != null)
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementBoundingBoxLeft);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementBoundingBoxRight != null)
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementBoundingBoxRight);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementBoundingBoxTop != null)
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementBoundingBoxTop);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementSearchElementBoundingBoxBottom != null)
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementSearchElementBoundingBoxBottom);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementFocusFirst != null)
            {
                browserMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementFocusFirst);
                browserMouseRightClickOnElementpropCount++;
            }

            browserMouseRightClickOnElementpropCount++;
            browserMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementWorkflow);
            if (browserMouseRightClickOnElementpropCount > 0)
            {
                callPayload.Body = browserMouseRightClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserJavaScriptClickOnElement(Expression<Func<string>> browserJavaScriptClickOnElementWorkflow, Expression<Func<double>> browserJavaScriptClickOnElementParentElementHandle = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementHandle = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementName = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementID = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementTagName = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementXPath = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementClassName = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementIndex = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementMatchValue = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementMatchText = null, Expression<Func<string>> browserJavaScriptClickOnElementSearchElementType = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserJavaScriptClickOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserJavaScriptClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/JavaScriptClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserJavaScriptClickOnElement = new JObject();
            var browserJavaScriptClickOnElementpropCount = 0;
            if (browserJavaScriptClickOnElementParentElementHandle != null)
            {
                browserJavaScriptClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementParentElementHandle);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementHandle != null)
            {
                browserJavaScriptClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementHandle);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementName != null)
            {
                browserJavaScriptClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementID != null)
            {
                browserJavaScriptClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementID);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementTagName != null)
            {
                browserJavaScriptClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementTagName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementXPath != null)
            {
                browserJavaScriptClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementXPath);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementClassName != null)
            {
                browserJavaScriptClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementClassName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementCSSSelector != null)
            {
                browserJavaScriptClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementCSSSelector);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementIndex != null)
            {
                browserJavaScriptClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementIndex);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementMatchValue != null)
            {
                browserJavaScriptClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementMatchValue);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementMatchText != null)
            {
                browserJavaScriptClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementMatchText);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementType != null)
            {
                browserJavaScriptClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementType);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementMinimumWidth != null)
            {
                browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementMinimumWidth);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementMinimumHeight != null)
            {
                browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementMinimumHeight);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementBoundingBoxLeft != null)
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementBoundingBoxLeft);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementBoundingBoxRight != null)
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementBoundingBoxRight);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementBoundingBoxTop != null)
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementBoundingBoxTop);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementSearchElementBoundingBoxBottom != null)
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementSearchElementBoundingBoxBottom);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserJavaScriptClickOnElementpropCount++;
            }

            browserJavaScriptClickOnElementpropCount++;
            browserJavaScriptClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementWorkflow);
            if (browserJavaScriptClickOnElementpropCount > 0)
            {
                callPayload.Body = browserJavaScriptClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse> BrowserExecuteJavaScriptOnElement(Expression<Func<string>> browserExecuteJavaScriptOnElementJavaScriptToExecute, Expression<Func<string>> browserExecuteJavaScriptOnElementWorkflow, Expression<Func<double>> browserExecuteJavaScriptOnElementParentElementHandle = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementHandle = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementID = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementTagName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementXPath = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementClassName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementIndex = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementMatchValue = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementMatchText = null, Expression<Func<string>> browserExecuteJavaScriptOnElementSearchElementType = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserExecuteJavaScriptOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserExecuteJavaScriptOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ExecuteJavaScriptOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserExecuteJavaScriptOnElement = new JObject();
            var browserExecuteJavaScriptOnElementpropCount = 0;
            if (browserExecuteJavaScriptOnElementParentElementHandle != null)
            {
                browserExecuteJavaScriptOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementParentElementHandle);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementHandle != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementHandle);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementID != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementID);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementTagName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementTagName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementXPath != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementXPath);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementClassName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementClassName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementCSSSelector != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementCSSSelector);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementIndex != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementIndex);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementMatchValue != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementMatchValue);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementMatchText != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementMatchText);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementType != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementType);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementMinimumWidth != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementMinimumWidth);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementMinimumHeight != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementMinimumHeight);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementBoundingBoxLeft != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementBoundingBoxLeft);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementBoundingBoxRight != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementBoundingBoxRight);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementBoundingBoxTop != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementBoundingBoxTop);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementSearchElementBoundingBoxBottom != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementSearchElementBoundingBoxBottom);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            browserExecuteJavaScriptOnElementpropCount++;
            browserExecuteJavaScriptOnElement["JavaScriptToExecute"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementJavaScriptToExecute);
            browserExecuteJavaScriptOnElementpropCount++;
            browserExecuteJavaScriptOnElement["Workflow"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementWorkflow);
            if (browserExecuteJavaScriptOnElementpropCount > 0)
            {
                callPayload.Body = browserExecuteJavaScriptOnElement;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptOnElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseLeftClickOnElement(Expression<Func<string>> browserGlobalMouseLeftClickOnElementWorkflow, Expression<Func<double>> browserGlobalMouseLeftClickOnElementParentElementHandle = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementHandle = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementID = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementTagName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementXPath = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementClassName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementIndex = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementSearchElementType = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementClickOffsetX = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementClickOffsetY = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementFocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/GlobalMouseLeftClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGlobalMouseLeftClickOnElement = new JObject();
            var browserGlobalMouseLeftClickOnElementpropCount = 0;
            if (browserGlobalMouseLeftClickOnElementParentElementHandle != null)
            {
                browserGlobalMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementParentElementHandle);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementHandle != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementHandle);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementID != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementID);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementTagName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementTagName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementXPath != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementXPath);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementClassName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementClassName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementCSSSelector != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementCSSSelector);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementIndex != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementIndex);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementMatchValue != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementMatchValue);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementMatchText != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementMatchText);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementType != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementType);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementMinimumWidth != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementMinimumWidth);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementMinimumHeight != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementMinimumHeight);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxLeft != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxLeft);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxRight != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxRight);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxTop != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxTop);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxBottom != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementSearchElementBoundingBoxBottom);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementClickOffsetX != null)
            {
                browserGlobalMouseLeftClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementClickOffsetX);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementClickOffsetY != null)
            {
                browserGlobalMouseLeftClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementClickOffsetY);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementFocusFirst != null)
            {
                browserGlobalMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementFocusFirst);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            browserGlobalMouseLeftClickOnElementpropCount++;
            browserGlobalMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementWorkflow);
            if (browserGlobalMouseLeftClickOnElementpropCount > 0)
            {
                callPayload.Body = browserGlobalMouseLeftClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseRightClickOnElement(Expression<Func<string>> browserGlobalMouseRightClickOnElementWorkflow, Expression<Func<double>> browserGlobalMouseRightClickOnElementParentElementHandle = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementHandle = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementID = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementTagName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementXPath = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementClassName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementIndex = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementSearchElementType = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementClickOffsetX = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementClickOffsetY = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementFocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/GlobalMouseRightClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGlobalMouseRightClickOnElement = new JObject();
            var browserGlobalMouseRightClickOnElementpropCount = 0;
            if (browserGlobalMouseRightClickOnElementParentElementHandle != null)
            {
                browserGlobalMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementParentElementHandle);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementHandle != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementHandle);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementID != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementID);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementTagName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementTagName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementXPath != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementXPath);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementClassName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementClassName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementCSSSelector != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementCSSSelector);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementIndex != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementIndex);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementMatchValue != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementMatchValue);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementMatchText != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementMatchText);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementType != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementType);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementMinimumWidth != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementMinimumWidth);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementMinimumHeight != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementMinimumHeight);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementBoundingBoxLeft != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementBoundingBoxLeft);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementBoundingBoxRight != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementBoundingBoxRight);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementBoundingBoxTop != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementBoundingBoxTop);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementSearchElementBoundingBoxBottom != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementSearchElementBoundingBoxBottom);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementClickOffsetX != null)
            {
                browserGlobalMouseRightClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementClickOffsetX);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementClickOffsetY != null)
            {
                browserGlobalMouseRightClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementClickOffsetY);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementFocusFirst != null)
            {
                browserGlobalMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementFocusFirst);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            browserGlobalMouseRightClickOnElementpropCount++;
            browserGlobalMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementWorkflow);
            if (browserGlobalMouseRightClickOnElementpropCount > 0)
            {
                callPayload.Body = browserGlobalMouseRightClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse> BrowserOpenNewTab(Expression<Func<string>> browserOpenNewTabWorkflow, Expression<Func<string>> browserOpenNewTabURL = null, Expression<Func<bool>> browserOpenNewTabSwitchControlToNewTab = null)
        {
            var apiCallPath = "/BrowserControl/OpenNewTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenNewTab = new JObject();
            var browserOpenNewTabpropCount = 0;
            if (browserOpenNewTabURL != null)
            {
                browserOpenNewTab["URL"] = ExpressionConverter.ConvertO(browserOpenNewTabURL);
                browserOpenNewTabpropCount++;
            }

            if (browserOpenNewTabSwitchControlToNewTab != null)
            {
                browserOpenNewTab["SwitchControlToNewTab"] = ExpressionConverter.ConvertO(browserOpenNewTabSwitchControlToNewTab);
                browserOpenNewTabpropCount++;
            }

            browserOpenNewTabpropCount++;
            browserOpenNewTab["Workflow"] = ExpressionConverter.ConvertO(browserOpenNewTabWorkflow);
            if (browserOpenNewTabpropCount > 0)
            {
                callPayload.Body = browserOpenNewTab;
            }

            return new ApiConnectionAction<BrowserOpenNewTabResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTabsResponse> BrowserGetTabs(Expression<Func<string>> browserGetTabsWorkflow)
        {
            var apiCallPath = "/BrowserControl/GetTabs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetTabs = new JObject();
            var browserGetTabspropCount = 0;
            browserGetTabspropCount++;
            browserGetTabs["Workflow"] = ExpressionConverter.ConvertO(browserGetTabsWorkflow);
            if (browserGetTabspropCount > 0)
            {
                callPayload.Body = browserGetTabs;
            }

            return new ApiConnectionAction<BrowserGetTabsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTab(Expression<Func<string>> browserSetTabWorkflow, Expression<Func<string>> browserSetTabTabName = null, Expression<Func<int>> browserSetTabTabIndex = null)
        {
            var apiCallPath = "/BrowserControl/SetTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetTab = new JObject();
            var browserSetTabpropCount = 0;
            if (browserSetTabTabName != null)
            {
                browserSetTab["TabName"] = ExpressionConverter.ConvertO(browserSetTabTabName);
                browserSetTabpropCount++;
            }

            if (browserSetTabTabIndex != null)
            {
                browserSetTab["TabIndex"] = ExpressionConverter.ConvertO(browserSetTabTabIndex);
                browserSetTabpropCount++;
            }

            browserSetTabpropCount++;
            browserSetTab["Workflow"] = ExpressionConverter.ConvertO(browserSetTabWorkflow);
            if (browserSetTabpropCount > 0)
            {
                callPayload.Body = browserSetTab;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseActiveTab(Expression<Func<string>> browserCloseActiveTabWorkflow)
        {
            var apiCallPath = "/BrowserControl/CloseActiveTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseActiveTab = new JObject();
            var browserCloseActiveTabpropCount = 0;
            browserCloseActiveTabpropCount++;
            browserCloseActiveTab["Workflow"] = ExpressionConverter.ConvertO(browserCloseActiveTabWorkflow);
            if (browserCloseActiveTabpropCount > 0)
            {
                callPayload.Body = browserCloseActiveTab;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSavePageToFile(Expression<Func<string>> browserSavePageToFileSaveFilename, Expression<Func<string>> browserSavePageToFileWorkflow)
        {
            var apiCallPath = "/BrowserControl/SavePageToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSavePageToFile = new JObject();
            var browserSavePageToFilepropCount = 0;
            browserSavePageToFilepropCount++;
            browserSavePageToFile["SaveFilename"] = ExpressionConverter.ConvertO(browserSavePageToFileSaveFilename);
            browserSavePageToFilepropCount++;
            browserSavePageToFile["Workflow"] = ExpressionConverter.ConvertO(browserSavePageToFileWorkflow);
            if (browserSavePageToFilepropCount > 0)
            {
                callPayload.Body = browserSavePageToFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetPageTextResponse> BrowserGetPageText(Expression<Func<string>> browserGetPageTextWorkflow)
        {
            var apiCallPath = "/BrowserControl/GetPageText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetPageText = new JObject();
            var browserGetPageTextpropCount = 0;
            browserGetPageTextpropCount++;
            browserGetPageText["Workflow"] = ExpressionConverter.ConvertO(browserGetPageTextWorkflow);
            if (browserGetPageTextpropCount > 0)
            {
                callPayload.Body = browserGetPageText;
            }

            return new ApiConnectionAction<BrowserGetPageTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToFrameElement(Expression<Func<string>> browserSwitchToFrameElementWorkflow, Expression<Func<double>> browserSwitchToFrameElementParentElementHandle = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementHandle = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementName = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementID = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementTagName = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementXPath = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementClassName = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementCSSSelector = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementIndex = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementMatchValue = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementMatchText = null, Expression<Func<string>> browserSwitchToFrameElementSearchElementType = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementMinimumWidth = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementMinimumHeight = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserSwitchToFrameElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSwitchToFrameElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SwitchToFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToFrameElement = new JObject();
            var browserSwitchToFrameElementpropCount = 0;
            if (browserSwitchToFrameElementParentElementHandle != null)
            {
                browserSwitchToFrameElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementParentElementHandle);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementHandle != null)
            {
                browserSwitchToFrameElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementHandle);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementName != null)
            {
                browserSwitchToFrameElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementID != null)
            {
                browserSwitchToFrameElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementID);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementTagName != null)
            {
                browserSwitchToFrameElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementTagName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementXPath != null)
            {
                browserSwitchToFrameElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementXPath);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementClassName != null)
            {
                browserSwitchToFrameElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementClassName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementCSSSelector != null)
            {
                browserSwitchToFrameElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementCSSSelector);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementIndex != null)
            {
                browserSwitchToFrameElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementIndex);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementMatchValue != null)
            {
                browserSwitchToFrameElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementMatchValue);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementMatchText != null)
            {
                browserSwitchToFrameElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementMatchText);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementType != null)
            {
                browserSwitchToFrameElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementType);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementMinimumWidth != null)
            {
                browserSwitchToFrameElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementMinimumWidth);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementMinimumHeight != null)
            {
                browserSwitchToFrameElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementMinimumHeight);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementBoundingBoxLeft != null)
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementBoundingBoxLeft);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementBoundingBoxRight != null)
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementBoundingBoxRight);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementBoundingBoxTop != null)
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementBoundingBoxTop);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementSearchElementBoundingBoxBottom != null)
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementSearchElementBoundingBoxBottom);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserSwitchToFrameElementpropCount++;
            }

            browserSwitchToFrameElementpropCount++;
            browserSwitchToFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementWorkflow);
            if (browserSwitchToFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse> BrowserGetCurrentFrameWindowPixelCoordinate(Expression<Func<string>> browserGetCurrentFrameWindowPixelCoordinateWorkflow)
        {
            var apiCallPath = "/BrowserControl/GetCurrentFrameWindowPixelCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetCurrentFrameWindowPixelCoordinate = new JObject();
            var browserGetCurrentFrameWindowPixelCoordinatepropCount = 0;
            browserGetCurrentFrameWindowPixelCoordinatepropCount++;
            browserGetCurrentFrameWindowPixelCoordinate["Workflow"] = ExpressionConverter.ConvertO(browserGetCurrentFrameWindowPixelCoordinateWorkflow);
            if (browserGetCurrentFrameWindowPixelCoordinatepropCount > 0)
            {
                callPayload.Body = browserGetCurrentFrameWindowPixelCoordinate;
            }

            return new ApiConnectionAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToParentFrameElement(Expression<Func<string>> browserSwitchToParentFrameElementWorkflow)
        {
            var apiCallPath = "/BrowserControl/SwitchToParentFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToParentFrameElement = new JObject();
            var browserSwitchToParentFrameElementpropCount = 0;
            browserSwitchToParentFrameElementpropCount++;
            browserSwitchToParentFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToParentFrameElementWorkflow);
            if (browserSwitchToParentFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToParentFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToRootFrameElement(Expression<Func<string>> browserSwitchToRootFrameElementWorkflow)
        {
            var apiCallPath = "/BrowserControl/SwitchToRootFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToRootFrameElement = new JObject();
            var browserSwitchToRootFrameElementpropCount = 0;
            browserSwitchToRootFrameElementpropCount++;
            browserSwitchToRootFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToRootFrameElementWorkflow);
            if (browserSwitchToRootFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToRootFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetFrameStack(Expression<Func<string>> browserResetFrameStackWorkflow)
        {
            var apiCallPath = "/BrowserControl/ResetFrameStack";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserResetFrameStack = new JObject();
            var browserResetFrameStackpropCount = 0;
            browserResetFrameStackpropCount++;
            browserResetFrameStack["Workflow"] = ExpressionConverter.ConvertO(browserResetFrameStackWorkflow);
            if (browserResetFrameStackpropCount > 0)
            {
                callPayload.Body = browserResetFrameStack;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserClearElementTextResponse> BrowserClearElementText(Expression<Func<string>> browserClearElementTextWorkflow, Expression<Func<double>> browserClearElementTextParentElementHandle = null, Expression<Func<double>> browserClearElementTextSearchElementHandle = null, Expression<Func<string>> browserClearElementTextSearchElementName = null, Expression<Func<string>> browserClearElementTextSearchElementID = null, Expression<Func<string>> browserClearElementTextSearchElementTagName = null, Expression<Func<string>> browserClearElementTextSearchElementXPath = null, Expression<Func<string>> browserClearElementTextSearchElementClassName = null, Expression<Func<string>> browserClearElementTextSearchElementCSSSelector = null, Expression<Func<double>> browserClearElementTextSearchElementIndex = null, Expression<Func<string>> browserClearElementTextSearchElementMatchValue = null, Expression<Func<string>> browserClearElementTextSearchElementMatchText = null, Expression<Func<string>> browserClearElementTextSearchElementType = null, Expression<Func<double>> browserClearElementTextSearchElementMinimumWidth = null, Expression<Func<double>> browserClearElementTextSearchElementMinimumHeight = null, Expression<Func<double>> browserClearElementTextSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClearElementTextSearchElementBoundingBoxRight = null, Expression<Func<double>> browserClearElementTextSearchElementBoundingBoxTop = null, Expression<Func<double>> browserClearElementTextSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClearElementTextOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ClearElementText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserClearElementText = new JObject();
            var browserClearElementTextpropCount = 0;
            if (browserClearElementTextParentElementHandle != null)
            {
                browserClearElementText["ParentElementHandle"] = ExpressionConverter.ConvertO(browserClearElementTextParentElementHandle);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementHandle != null)
            {
                browserClearElementText["SearchElementHandle"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementHandle);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementName != null)
            {
                browserClearElementText["SearchElementName"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementID != null)
            {
                browserClearElementText["SearchElementID"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementID);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementTagName != null)
            {
                browserClearElementText["SearchElementTagName"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementTagName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementXPath != null)
            {
                browserClearElementText["SearchElementXPath"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementXPath);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementClassName != null)
            {
                browserClearElementText["SearchElementClassName"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementClassName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementCSSSelector != null)
            {
                browserClearElementText["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementCSSSelector);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementIndex != null)
            {
                browserClearElementText["SearchElementIndex"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementIndex);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementMatchValue != null)
            {
                browserClearElementText["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementMatchValue);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementMatchText != null)
            {
                browserClearElementText["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementMatchText);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementType != null)
            {
                browserClearElementText["SearchElementType"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementType);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementMinimumWidth != null)
            {
                browserClearElementText["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementMinimumWidth);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementMinimumHeight != null)
            {
                browserClearElementText["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementMinimumHeight);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementBoundingBoxLeft != null)
            {
                browserClearElementText["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementBoundingBoxLeft);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementBoundingBoxRight != null)
            {
                browserClearElementText["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementBoundingBoxRight);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementBoundingBoxTop != null)
            {
                browserClearElementText["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementBoundingBoxTop);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextSearchElementBoundingBoxBottom != null)
            {
                browserClearElementText["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserClearElementTextSearchElementBoundingBoxBottom);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserClearElementTextOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserClearElementTextpropCount++;
            }

            browserClearElementTextpropCount++;
            browserClearElementText["Workflow"] = ExpressionConverter.ConvertO(browserClearElementTextWorkflow);
            if (browserClearElementTextpropCount > 0)
            {
                callPayload.Body = browserClearElementText;
            }

            return new ApiConnectionAction<BrowserClearElementTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCopySelectedTextOnElement(Expression<Func<string>> browserCopySelectedTextOnElementWorkflow, Expression<Func<double>> browserCopySelectedTextOnElementParentElementHandle = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementHandle = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementName = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementID = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementTagName = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementXPath = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementClassName = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementIndex = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementMatchValue = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementMatchText = null, Expression<Func<string>> browserCopySelectedTextOnElementSearchElementType = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserCopySelectedTextOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCopySelectedTextOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CopySelectedTextOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCopySelectedTextOnElement = new JObject();
            var browserCopySelectedTextOnElementpropCount = 0;
            if (browserCopySelectedTextOnElementParentElementHandle != null)
            {
                browserCopySelectedTextOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementParentElementHandle);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementHandle != null)
            {
                browserCopySelectedTextOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementHandle);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementName != null)
            {
                browserCopySelectedTextOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementID != null)
            {
                browserCopySelectedTextOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementID);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementTagName != null)
            {
                browserCopySelectedTextOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementTagName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementXPath != null)
            {
                browserCopySelectedTextOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementXPath);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementClassName != null)
            {
                browserCopySelectedTextOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementClassName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementCSSSelector != null)
            {
                browserCopySelectedTextOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementCSSSelector);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementIndex != null)
            {
                browserCopySelectedTextOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementIndex);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementMatchValue != null)
            {
                browserCopySelectedTextOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementMatchValue);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementMatchText != null)
            {
                browserCopySelectedTextOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementMatchText);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementType != null)
            {
                browserCopySelectedTextOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementType);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementMinimumWidth != null)
            {
                browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementMinimumWidth);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementMinimumHeight != null)
            {
                browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementMinimumHeight);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementBoundingBoxLeft != null)
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementBoundingBoxLeft);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementBoundingBoxRight != null)
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementBoundingBoxRight);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementBoundingBoxTop != null)
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementBoundingBoxTop);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementSearchElementBoundingBoxBottom != null)
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementSearchElementBoundingBoxBottom);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserCopySelectedTextOnElementpropCount++;
            }

            browserCopySelectedTextOnElementpropCount++;
            browserCopySelectedTextOnElement["Workflow"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementWorkflow);
            if (browserCopySelectedTextOnElementpropCount > 0)
            {
                callPayload.Body = browserCopySelectedTextOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputPasswordIntoElement(Expression<Func<string>> browserInputPasswordIntoElementPasswordToInput, Expression<Func<string>> browserInputPasswordIntoElementWorkflow, Expression<Func<double>> browserInputPasswordIntoElementParentElementHandle = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementHandle = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementName = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementID = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementTagName = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementXPath = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementClassName = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementCSSSelector = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementIndex = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementMatchValue = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementMatchText = null, Expression<Func<string>> browserInputPasswordIntoElementSearchElementType = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementMinimumWidth = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementMinimumHeight = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputPasswordIntoElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputPasswordIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserInputPasswordIntoElementResetExistingValue = null, Expression<Func<bool>> browserInputPasswordIntoElementPasswordContainsStoredPassword = null)
        {
            var apiCallPath = "/BrowserControl/InputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputPasswordIntoElement = new JObject();
            var browserInputPasswordIntoElementpropCount = 0;
            if (browserInputPasswordIntoElementParentElementHandle != null)
            {
                browserInputPasswordIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementParentElementHandle);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementHandle != null)
            {
                browserInputPasswordIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementHandle);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementName != null)
            {
                browserInputPasswordIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementID != null)
            {
                browserInputPasswordIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementID);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementTagName != null)
            {
                browserInputPasswordIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementTagName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementXPath != null)
            {
                browserInputPasswordIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementXPath);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementClassName != null)
            {
                browserInputPasswordIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementClassName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementCSSSelector != null)
            {
                browserInputPasswordIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementCSSSelector);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementIndex != null)
            {
                browserInputPasswordIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementIndex);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementMatchValue != null)
            {
                browserInputPasswordIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementMatchValue);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementMatchText != null)
            {
                browserInputPasswordIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementMatchText);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementType != null)
            {
                browserInputPasswordIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementType);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementMinimumWidth != null)
            {
                browserInputPasswordIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementMinimumWidth);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementMinimumHeight != null)
            {
                browserInputPasswordIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementMinimumHeight);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementBoundingBoxLeft != null)
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementBoundingBoxLeft);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementBoundingBoxRight != null)
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementBoundingBoxRight);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementBoundingBoxTop != null)
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementBoundingBoxTop);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementSearchElementBoundingBoxBottom != null)
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementSearchElementBoundingBoxBottom);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserInputPasswordIntoElementpropCount++;
            }

            browserInputPasswordIntoElementpropCount++;
            browserInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementPasswordToInput);
            if (browserInputPasswordIntoElementResetExistingValue != null)
            {
                browserInputPasswordIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementResetExistingValue);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementPasswordContainsStoredPassword != null)
            {
                browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementPasswordContainsStoredPassword);
                browserInputPasswordIntoElementpropCount++;
            }

            browserInputPasswordIntoElementpropCount++;
            browserInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementWorkflow);
            if (browserInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = browserInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPasteIntoElement(Expression<Func<string>> browserPasteIntoElementWorkflow, Expression<Func<double>> browserPasteIntoElementParentElementHandle = null, Expression<Func<double>> browserPasteIntoElementSearchElementHandle = null, Expression<Func<string>> browserPasteIntoElementSearchElementName = null, Expression<Func<string>> browserPasteIntoElementSearchElementID = null, Expression<Func<string>> browserPasteIntoElementSearchElementTagName = null, Expression<Func<string>> browserPasteIntoElementSearchElementXPath = null, Expression<Func<string>> browserPasteIntoElementSearchElementClassName = null, Expression<Func<string>> browserPasteIntoElementSearchElementCSSSelector = null, Expression<Func<double>> browserPasteIntoElementSearchElementIndex = null, Expression<Func<string>> browserPasteIntoElementSearchElementMatchValue = null, Expression<Func<string>> browserPasteIntoElementSearchElementMatchText = null, Expression<Func<string>> browserPasteIntoElementSearchElementType = null, Expression<Func<double>> browserPasteIntoElementSearchElementMinimumWidth = null, Expression<Func<double>> browserPasteIntoElementSearchElementMinimumHeight = null, Expression<Func<double>> browserPasteIntoElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPasteIntoElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserPasteIntoElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserPasteIntoElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPasteIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PasteIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPasteIntoElement = new JObject();
            var browserPasteIntoElementpropCount = 0;
            if (browserPasteIntoElementParentElementHandle != null)
            {
                browserPasteIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPasteIntoElementParentElementHandle);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementHandle != null)
            {
                browserPasteIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementHandle);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementName != null)
            {
                browserPasteIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementID != null)
            {
                browserPasteIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementID);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementTagName != null)
            {
                browserPasteIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementTagName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementXPath != null)
            {
                browserPasteIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementXPath);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementClassName != null)
            {
                browserPasteIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementClassName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementCSSSelector != null)
            {
                browserPasteIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementCSSSelector);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementIndex != null)
            {
                browserPasteIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementIndex);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementMatchValue != null)
            {
                browserPasteIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementMatchValue);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementMatchText != null)
            {
                browserPasteIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementMatchText);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementType != null)
            {
                browserPasteIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementType);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementMinimumWidth != null)
            {
                browserPasteIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementMinimumWidth);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementMinimumHeight != null)
            {
                browserPasteIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementMinimumHeight);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementBoundingBoxLeft != null)
            {
                browserPasteIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementBoundingBoxLeft);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementBoundingBoxRight != null)
            {
                browserPasteIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementBoundingBoxRight);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementBoundingBoxTop != null)
            {
                browserPasteIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementBoundingBoxTop);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementSearchElementBoundingBoxBottom != null)
            {
                browserPasteIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPasteIntoElementSearchElementBoundingBoxBottom);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPasteIntoElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserPasteIntoElementpropCount++;
            }

            browserPasteIntoElementpropCount++;
            browserPasteIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserPasteIntoElementWorkflow);
            if (browserPasteIntoElementpropCount > 0)
            {
                callPayload.Body = browserPasteIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPrintCurrentPage(Expression<Func<string>> browserPrintCurrentPageWorkflow)
        {
            var apiCallPath = "/BrowserControl/PrintCurrentPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPrintCurrentPage = new JObject();
            var browserPrintCurrentPagepropCount = 0;
            browserPrintCurrentPagepropCount++;
            browserPrintCurrentPage["Workflow"] = ExpressionConverter.ConvertO(browserPrintCurrentPageWorkflow);
            if (browserPrintCurrentPagepropCount > 0)
            {
                callPayload.Body = browserPrintCurrentPage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowByPixels(Expression<Func<string>> browserScrollWindowByPixelsWorkflow, Expression<Func<double>> browserScrollWindowByPixelsX = null, Expression<Func<double>> browserScrollWindowByPixelsY = null)
        {
            var apiCallPath = "/BrowserControl/ScrollWindowByPixels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollWindowByPixels = new JObject();
            var browserScrollWindowByPixelspropCount = 0;
            if (browserScrollWindowByPixelsX != null)
            {
                browserScrollWindowByPixels["X"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsX);
                browserScrollWindowByPixelspropCount++;
            }

            if (browserScrollWindowByPixelsY != null)
            {
                browserScrollWindowByPixels["Y"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsY);
                browserScrollWindowByPixelspropCount++;
            }

            browserScrollWindowByPixelspropCount++;
            browserScrollWindowByPixels["Workflow"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsWorkflow);
            if (browserScrollWindowByPixelspropCount > 0)
            {
                callPayload.Body = browserScrollWindowByPixels;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowToPixels(Expression<Func<string>> browserScrollWindowToPixelsWorkflow, Expression<Func<double>> browserScrollWindowToPixelsX = null, Expression<Func<double>> browserScrollWindowToPixelsY = null)
        {
            var apiCallPath = "/BrowserControl/ScrollWindowToPixels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollWindowToPixels = new JObject();
            var browserScrollWindowToPixelspropCount = 0;
            if (browserScrollWindowToPixelsX != null)
            {
                browserScrollWindowToPixels["X"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsX);
                browserScrollWindowToPixelspropCount++;
            }

            if (browserScrollWindowToPixelsY != null)
            {
                browserScrollWindowToPixels["Y"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsY);
                browserScrollWindowToPixelspropCount++;
            }

            browserScrollWindowToPixelspropCount++;
            browserScrollWindowToPixels["Workflow"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsWorkflow);
            if (browserScrollWindowToPixelspropCount > 0)
            {
                callPayload.Body = browserScrollWindowToPixels;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectAllOnElement(Expression<Func<string>> browserSelectAllOnElementWorkflow, Expression<Func<double>> browserSelectAllOnElementParentElementHandle = null, Expression<Func<double>> browserSelectAllOnElementSearchElementHandle = null, Expression<Func<string>> browserSelectAllOnElementSearchElementName = null, Expression<Func<string>> browserSelectAllOnElementSearchElementID = null, Expression<Func<string>> browserSelectAllOnElementSearchElementTagName = null, Expression<Func<string>> browserSelectAllOnElementSearchElementXPath = null, Expression<Func<string>> browserSelectAllOnElementSearchElementClassName = null, Expression<Func<string>> browserSelectAllOnElementSearchElementCSSSelector = null, Expression<Func<double>> browserSelectAllOnElementSearchElementIndex = null, Expression<Func<string>> browserSelectAllOnElementSearchElementMatchValue = null, Expression<Func<string>> browserSelectAllOnElementSearchElementMatchText = null, Expression<Func<string>> browserSelectAllOnElementSearchElementType = null, Expression<Func<double>> browserSelectAllOnElementSearchElementMinimumWidth = null, Expression<Func<double>> browserSelectAllOnElementSearchElementMinimumHeight = null, Expression<Func<double>> browserSelectAllOnElementSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectAllOnElementSearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectAllOnElementSearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectAllOnElementSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectAllOnElementOnlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SelectAllOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSelectAllOnElement = new JObject();
            var browserSelectAllOnElementpropCount = 0;
            if (browserSelectAllOnElementParentElementHandle != null)
            {
                browserSelectAllOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSelectAllOnElementParentElementHandle);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementHandle != null)
            {
                browserSelectAllOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementHandle);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementName != null)
            {
                browserSelectAllOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementID != null)
            {
                browserSelectAllOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementID);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementTagName != null)
            {
                browserSelectAllOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementTagName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementXPath != null)
            {
                browserSelectAllOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementXPath);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementClassName != null)
            {
                browserSelectAllOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementClassName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementCSSSelector != null)
            {
                browserSelectAllOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementCSSSelector);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementIndex != null)
            {
                browserSelectAllOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementIndex);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementMatchValue != null)
            {
                browserSelectAllOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementMatchValue);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementMatchText != null)
            {
                browserSelectAllOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementMatchText);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementType != null)
            {
                browserSelectAllOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementType);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementMinimumWidth != null)
            {
                browserSelectAllOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementMinimumWidth);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementMinimumHeight != null)
            {
                browserSelectAllOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementMinimumHeight);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementBoundingBoxLeft != null)
            {
                browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementBoundingBoxLeft);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementBoundingBoxRight != null)
            {
                browserSelectAllOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementBoundingBoxRight);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementBoundingBoxTop != null)
            {
                browserSelectAllOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementBoundingBoxTop);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementSearchElementBoundingBoxBottom != null)
            {
                browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSelectAllOnElementSearchElementBoundingBoxBottom);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSelectAllOnElementOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserSelectAllOnElementpropCount++;
            }

            browserSelectAllOnElementpropCount++;
            browserSelectAllOnElement["Workflow"] = ExpressionConverter.ConvertO(browserSelectAllOnElementWorkflow);
            if (browserSelectAllOnElementpropCount > 0)
            {
                callPayload.Body = browserSelectAllOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse> BrowserWaitForElementToExist(Expression<Func<int>> browserWaitForElementToExistSecondsToWait, Expression<Func<string>> browserWaitForElementToExistWorkflow, Expression<Func<double>> browserWaitForElementToExistParentElementHandle = null, Expression<Func<string>> browserWaitForElementToExistSearchElementName = null, Expression<Func<string>> browserWaitForElementToExistSearchElementID = null, Expression<Func<string>> browserWaitForElementToExistSearchElementTagName = null, Expression<Func<string>> browserWaitForElementToExistSearchElementXPath = null, Expression<Func<string>> browserWaitForElementToExistSearchElementClassName = null, Expression<Func<string>> browserWaitForElementToExistSearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToExistSearchElementIndex = null, Expression<Func<string>> browserWaitForElementToExistSearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToExistSearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToExistSearchElementType = null, Expression<Func<double>> browserWaitForElementToExistSearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToExistSearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToExistSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToExistSearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToExistSearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToExistSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToExistOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToExistRaiseExceptionIfElementNotFound = null, Expression<Func<bool>> browserWaitForElementToExistUseExplicitWaitConditionsIfPossible = null, Expression<Func<bool>> browserWaitForElementToExistWaitForSearchElementToBeDisplayed = null)
        {
            var apiCallPath = "/BrowserControl/WaitForElementToExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserWaitForElementToExist = new JObject();
            var browserWaitForElementToExistpropCount = 0;
            if (browserWaitForElementToExistParentElementHandle != null)
            {
                browserWaitForElementToExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToExistParentElementHandle);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementName != null)
            {
                browserWaitForElementToExist["SearchElementName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementID != null)
            {
                browserWaitForElementToExist["SearchElementID"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementID);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementTagName != null)
            {
                browserWaitForElementToExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementTagName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementXPath != null)
            {
                browserWaitForElementToExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementXPath);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementClassName != null)
            {
                browserWaitForElementToExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementClassName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementCSSSelector != null)
            {
                browserWaitForElementToExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementCSSSelector);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementIndex != null)
            {
                browserWaitForElementToExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementIndex);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementMatchValue != null)
            {
                browserWaitForElementToExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementMatchValue);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementMatchText != null)
            {
                browserWaitForElementToExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementMatchText);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementType != null)
            {
                browserWaitForElementToExist["SearchElementType"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementType);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementMinimumWidth != null)
            {
                browserWaitForElementToExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementMinimumWidth);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementMinimumHeight != null)
            {
                browserWaitForElementToExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementMinimumHeight);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementBoundingBoxLeft != null)
            {
                browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementBoundingBoxLeft);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementBoundingBoxRight != null)
            {
                browserWaitForElementToExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementBoundingBoxRight);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementBoundingBoxTop != null)
            {
                browserWaitForElementToExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementBoundingBoxTop);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistSearchElementBoundingBoxBottom != null)
            {
                browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSearchElementBoundingBoxBottom);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserWaitForElementToExistOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserWaitForElementToExistpropCount++;
            }

            browserWaitForElementToExistpropCount++;
            browserWaitForElementToExist["SecondsToWait"] = ExpressionConverter.ConvertO(browserWaitForElementToExistSecondsToWait);
            if (browserWaitForElementToExistRaiseExceptionIfElementNotFound != null)
            {
                browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserWaitForElementToExistRaiseExceptionIfElementNotFound);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistUseExplicitWaitConditionsIfPossible != null)
            {
                browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = ExpressionConverter.ConvertO(browserWaitForElementToExistUseExplicitWaitConditionsIfPossible);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistWaitForSearchElementToBeDisplayed != null)
            {
                browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = ExpressionConverter.ConvertO(browserWaitForElementToExistWaitForSearchElementToBeDisplayed);
                browserWaitForElementToExistpropCount++;
            }

            browserWaitForElementToExistpropCount++;
            browserWaitForElementToExist["Workflow"] = ExpressionConverter.ConvertO(browserWaitForElementToExistWorkflow);
            if (browserWaitForElementToExistpropCount > 0)
            {
                callPayload.Body = browserWaitForElementToExist;
            }

            return new ApiConnectionAction<BrowserWaitForElementToExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse> BrowserWaitForElementToNotExist(Expression<Func<int>> browserWaitForElementToNotExistSecondsToWait, Expression<Func<string>> browserWaitForElementToNotExistWorkflow, Expression<Func<double>> browserWaitForElementToNotExistParentElementHandle = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementHandle = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementName = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementID = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementTagName = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementXPath = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementClassName = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementIndex = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToNotExistSearchElementType = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToNotExistSearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToNotExistOnlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToNotExistRaiseExceptionIfElementStillExists = null, Expression<Func<bool>> browserWaitForElementToNotExistSearchElementMustBeDisplayed = null)
        {
            var apiCallPath = "/BrowserControl/WaitForElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserWaitForElementToNotExist = new JObject();
            var browserWaitForElementToNotExistpropCount = 0;
            if (browserWaitForElementToNotExistParentElementHandle != null)
            {
                browserWaitForElementToNotExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistParentElementHandle);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementHandle != null)
            {
                browserWaitForElementToNotExist["SearchElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementHandle);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementName != null)
            {
                browserWaitForElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementID != null)
            {
                browserWaitForElementToNotExist["SearchElementID"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementID);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementTagName != null)
            {
                browserWaitForElementToNotExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementTagName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementXPath != null)
            {
                browserWaitForElementToNotExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementXPath);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementClassName != null)
            {
                browserWaitForElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementClassName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementCSSSelector != null)
            {
                browserWaitForElementToNotExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementCSSSelector);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementIndex != null)
            {
                browserWaitForElementToNotExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementIndex);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementMatchValue != null)
            {
                browserWaitForElementToNotExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementMatchValue);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementMatchText != null)
            {
                browserWaitForElementToNotExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementMatchText);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementType != null)
            {
                browserWaitForElementToNotExist["SearchElementType"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementType);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementMinimumWidth != null)
            {
                browserWaitForElementToNotExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementMinimumWidth);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementMinimumHeight != null)
            {
                browserWaitForElementToNotExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementMinimumHeight);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementBoundingBoxLeft != null)
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementBoundingBoxLeft);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementBoundingBoxRight != null)
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementBoundingBoxRight);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementBoundingBoxTop != null)
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementBoundingBoxTop);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementBoundingBoxBottom != null)
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementBoundingBoxBottom);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistOnlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistOnlyElementTopLeftNeedsToBeInBoundingBox);
                browserWaitForElementToNotExistpropCount++;
            }

            browserWaitForElementToNotExistpropCount++;
            browserWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSecondsToWait);
            if (browserWaitForElementToNotExistRaiseExceptionIfElementStillExists != null)
            {
                browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistRaiseExceptionIfElementStillExists);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistSearchElementMustBeDisplayed != null)
            {
                browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistSearchElementMustBeDisplayed);
                browserWaitForElementToNotExistpropCount++;
            }

            browserWaitForElementToNotExistpropCount++;
            browserWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistWorkflow);
            if (browserWaitForElementToNotExistpropCount > 0)
            {
                callPayload.Body = browserWaitForElementToNotExist;
            }

            return new ApiConnectionAction<BrowserWaitForElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse> BrowserGetWebElementAtScreenCoordinates(Expression<Func<string>> browserGetWebElementAtScreenCoordinatesWorkflow, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesXCoord = null, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesYCoord = null, Expression<Func<bool>> browserGetWebElementAtScreenCoordinatesRaiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/BrowserControl/GetWebElementAtScreenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementAtScreenCoordinates = new JObject();
            var browserGetWebElementAtScreenCoordinatespropCount = 0;
            if (browserGetWebElementAtScreenCoordinatesXCoord != null)
            {
                browserGetWebElementAtScreenCoordinates["XCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesXCoord);
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            if (browserGetWebElementAtScreenCoordinatesYCoord != null)
            {
                browserGetWebElementAtScreenCoordinates["YCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesYCoord);
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            if (browserGetWebElementAtScreenCoordinatesRaiseExceptionIfElementNotFound != null)
            {
                browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesRaiseExceptionIfElementNotFound);
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            browserGetWebElementAtScreenCoordinatespropCount++;
            browserGetWebElementAtScreenCoordinates["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesWorkflow);
            if (browserGetWebElementAtScreenCoordinatespropCount > 0)
            {
                callPayload.Body = browserGetWebElementAtScreenCoordinates;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtScreenCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse> BrowserGetWebElementAtBrowserDocumentWindowCoordinates(Expression<Func<string>> browserGetWebElementAtBrowserDocumentWindowCoordinatesWorkflow, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesXCoord = null, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesYCoord = null, Expression<Func<bool>> browserGetWebElementAtBrowserDocumentWindowCoordinatesRaiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/BrowserControl/GetWebElementAtBrowserDocumentWindowCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementAtBrowserDocumentWindowCoordinates = new JObject();
            var browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount = 0;
            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesXCoord != null)
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesXCoord);
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesYCoord != null)
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesYCoord);
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesRaiseExceptionIfElementNotFound != null)
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesRaiseExceptionIfElementNotFound);
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            browserGetWebElementAtBrowserDocumentWindowCoordinates["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesWorkflow);
            if (browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount > 0)
            {
                callPayload.Body = browserGetWebElementAtBrowserDocumentWindowCoordinates;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse> BrowserGetWebElementPropertiesAsList(Expression<Func<int>> browserGetWebElementPropertiesAsListElementHandle, Expression<Func<string>> browserGetWebElementPropertiesAsListWorkflow, Expression<Func<bool>> browserGetWebElementPropertiesAsListGetHTMLCode = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListReturnValue = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListReturnText = null, Expression<Func<int>> browserGetWebElementPropertiesAsListMaxValueLength = null, Expression<Func<int>> browserGetWebElementPropertiesAsListMaxTextLength = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListReturnCoordinates = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListReturnParentTag = null)
        {
            var apiCallPath = "/BrowserControl/BrowserGetWebElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementPropertiesAsList = new JObject();
            var browserGetWebElementPropertiesAsListpropCount = 0;
            browserGetWebElementPropertiesAsListpropCount++;
            browserGetWebElementPropertiesAsList["ElementHandle"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListElementHandle);
            if (browserGetWebElementPropertiesAsListGetHTMLCode != null)
            {
                browserGetWebElementPropertiesAsList["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListGetHTMLCode);
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListReturnValue != null)
            {
                browserGetWebElementPropertiesAsList["ReturnValue"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListReturnValue);
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListReturnText != null)
            {
                browserGetWebElementPropertiesAsList["ReturnText"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListReturnText);
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListMaxValueLength != null)
            {
                browserGetWebElementPropertiesAsList["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListMaxValueLength);
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListMaxTextLength != null)
            {
                browserGetWebElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListMaxTextLength);
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListReturnCoordinates != null)
            {
                browserGetWebElementPropertiesAsList["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListReturnCoordinates);
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListReturnParentTag != null)
            {
                browserGetWebElementPropertiesAsList["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListReturnParentTag);
                browserGetWebElementPropertiesAsListpropCount++;
            }

            browserGetWebElementPropertiesAsListpropCount++;
            browserGetWebElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListWorkflow);
            if (browserGetWebElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = browserGetWebElementPropertiesAsList;
            }

            return new ApiConnectionAction<BrowserGetWebElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse> IsBrowserInstanceOpen(Expression<Func<string>> isBrowserInstanceOpenWorkflow)
        {
            var apiCallPath = "/BrowserControl/IsBrowserInstanceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isBrowserInstanceOpen = new JObject();
            var isBrowserInstanceOpenpropCount = 0;
            isBrowserInstanceOpenpropCount++;
            isBrowserInstanceOpen["Workflow"] = ExpressionConverter.ConvertO(isBrowserInstanceOpenWorkflow);
            if (isBrowserInstanceOpenpropCount > 0)
            {
                callPayload.Body = isBrowserInstanceOpen;
            }

            return new ApiConnectionAction<IsBrowserInstanceOpenResponse>(callPayload);
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

    public class BrowserGetChromeDriverFolderResponse
    {
        public string ChromeDriverFolder { get; set; }
    }

    public class BrowserDownloadSuitableChromeDriverFromInternetResponse
    {
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromeDriverAvailableResponse
    {
        public string ChromeBrowserFileVersion { get; set; }
        public int ChromeBrowserMajorVersion { get; set; }
        public bool SuitableChromeDriverAvailable { get; set; }
        public string SuitableChromeDriverPath { get; set; }
    }

    public class BrowserOpenChromeResponse
    {
        public int ChromeDriverPID { get; set; }
        public int ChromeDriverTCPPort { get; set; }
        public int ChromePID { get; set; }
        public int ChromeTCPPort { get; set; }
        public string ChromeInstanceUserDataDir { get; set; }
        public bool ChromeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserGetChromiumEdgeDriverFolderResponse
    {
        public string ChromiumEdgeDriverFolder { get; set; }
    }

    public class BrowserGetChromiumEdgeBrowserVersionFromFileResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
    }

    public class BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse
    {
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserIsSuitableChromiumEdgeDriverAvailableResponse
    {
        public string ChromiumEdgeBrowserFileVersion { get; set; }
        public int ChromiumEdgeBrowserMajorVersion { get; set; }
        public bool SuitableChromiumEdgeDriverAvailable { get; set; }
        public string SuitableChromiumEdgeDriverPath { get; set; }
    }

    public class BrowserOpenChromiumEdgeResponse
    {
        public int ChromiumEdgeDriverPID { get; set; }
        public int ChromiumEdgeDriverTCPPort { get; set; }
        public int ChromiumEdgePID { get; set; }
        public int ChromiumEdgeTCPPort { get; set; }
        public string ChromiumEdgeInstanceUserDataDir { get; set; }
        public bool ChromiumEdgeInstanceAlreadyOpen { get; set; }
    }

    public class BrowserNavigateToURLResponse
    {
        public string PageTitle { get; set; }
        public string PageURL { get; set; }
    }

    public class BrowserDoesElementExistResponse
    {
        public bool ElementExists { get; set; }
    }

    public class BrowserCreateHandleToElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserCreateHandleToParentElementResponse
    {
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetElementPropertiesResponse
    {
        public string ElementName { get; set; }
        public string ElementID { get; set; }
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

    public class BrowserGetMultipleElementPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserGetElementParentPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class BrowserGetElementChildrenPropertiesResponse
    {
        public double NumberOfElementsFound { get; set; }
        public JToken[] ElementProperties { get; set; }
        public bool MoreElementsAvailable { get; set; }
    }

    public class BrowserInputTextIntoElementResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserGetSelectionPropertiesResponse
    {
        public string SelectedOptionText { get; set; }
        public string SelectedOptionValue { get; set; }
        public double NumberOfOptions { get; set; }
        public JToken[] SelectionOptions { get; set; }
    }

    public class BrowserGetTableContentsResponse
    {
        public double NumberOfRows { get; set; }
        public double NumberOfColumns { get; set; }
        public string TableContentsJSON { get; set; }
    }

    public class BrowserExecuteJavaScriptResponse
    {
        public string JavaScriptResponse { get; set; }
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

    public class BrowserExecuteJavaScriptOnElementResponse
    {
        public string JavaScriptResponse { get; set; }
    }

    public class BrowserOpenNewTabResponse
    {
        public string NewTabName { get; set; }
        public int NewTabIndex { get; set; }
    }

    public class BrowserGetTabsResponse
    {
        public int NumberOfTabs { get; set; }
        public string CurrentTabHandle { get; set; }
        public string BrowserTabsJSON { get; set; }
    }

    public class BrowserGetPageTextResponse
    {
        public string PageText { get; set; }
    }

    public class BrowserGetCurrentFrameWindowPixelCoordinateResponse
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class BrowserClearElementTextResponse
    {
        public string PreviousValue { get; set; }
    }

    public class BrowserWaitForElementToExistResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
    }

    public class BrowserWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class BrowserGetWebElementAtScreenCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse
    {
        public bool ElementExists { get; set; }
        public double ElementHandle { get; set; }
        public string ElementTagName { get; set; }
    }

    public class BrowserGetWebElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string ElementPropertiesJSON { get; set; }
    }

    public class IsBrowserInstanceOpenResponse
    {
        public bool IsBrowserInstanceOpen { get; set; }
        public string BrowserName { get; set; }
        public int BrowserMajorVersion { get; set; }
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