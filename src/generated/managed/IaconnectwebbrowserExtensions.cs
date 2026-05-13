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
        public IBodyWorkflowAction<BrowserGetChromeBrowserVersionFromFileResponse> BrowserGetChromeBrowserVersionFromFile(Expression<Func<string>> browserGetChromeBrowserVersionFromFileworkflow, Expression<Func<string>> browserGetChromeBrowserVersionFromFilechromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromeBrowserVersionFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromeBrowserVersionFromFile = new JObject();
            var browserGetChromeBrowserVersionFromFilepropCount = 0;
            if (browserGetChromeBrowserVersionFromFilechromeBrowserEXE != null)
            {
                browserGetChromeBrowserVersionFromFile["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromeBrowserVersionFromFilechromeBrowserEXE);
                browserGetChromeBrowserVersionFromFilepropCount++;
            }

            browserGetChromeBrowserVersionFromFilepropCount++;
            browserGetChromeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(browserGetChromeBrowserVersionFromFileworkflow);
            if (browserGetChromeBrowserVersionFromFilepropCount > 0)
            {
                callPayload.Body = browserGetChromeBrowserVersionFromFile;
            }

            return new ApiConnectionAction<BrowserGetChromeBrowserVersionFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromeDriverFolderResponse> BrowserGetChromeDriverFolder(Expression<Func<string>> browserGetChromeDriverFolderdirectoryPath, Expression<Func<string>> browserGetChromeDriverFolderworkflow, Expression<Func<int>> browserGetChromeDriverFolderchromeMajorVersion = null, Expression<Func<string>> browserGetChromeDriverFolderchromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromeDriverFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromeDriverFolder = new JObject();
            var browserGetChromeDriverFolderpropCount = 0;
            browserGetChromeDriverFolderpropCount++;
            browserGetChromeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderdirectoryPath);
            if (browserGetChromeDriverFolderchromeMajorVersion != null)
            {
                browserGetChromeDriverFolder["ChromeMajorVersion"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderchromeMajorVersion);
                browserGetChromeDriverFolderpropCount++;
            }

            if (browserGetChromeDriverFolderchromeBrowserEXE != null)
            {
                browserGetChromeDriverFolder["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderchromeBrowserEXE);
                browserGetChromeDriverFolderpropCount++;
            }

            browserGetChromeDriverFolderpropCount++;
            browserGetChromeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(browserGetChromeDriverFolderworkflow);
            if (browserGetChromeDriverFolderpropCount > 0)
            {
                callPayload.Body = browserGetChromeDriverFolder;
            }

            return new ApiConnectionAction<BrowserGetChromeDriverFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromeDriverFromInternetResponse> BrowserDownloadSuitableChromeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetworkflow, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex = null, Expression<Func<string>> browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL = null, Expression<Func<bool>> browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver = null)
        {
            var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromeDriverFromInternet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDownloadSuitableChromeDriverFromInternet = new JObject();
            var browserDownloadSuitableChromeDriverFromInternetpropCount = 0;
            if (browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE != null)
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeBrowserEXE);
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromeDriverFromInternetpropCount++;
            browserDownloadSuitableChromeDriverFromInternet["ChromeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeDriverDownloadParentFolder);
            if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaXMLIndex);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaXMLIndex"] = true;
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeDriverRootWebPageURL);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverRootWebPageURL"] = "https://chromedriver.storage.googleapis.com/";
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetattemptToLocateChromeDriverURLViaJSONIndex);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["AttemptToLocateChromeDriverURLViaJSONIndex"] = true;
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetchromeDriverJSONIndexWebPageURL);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["ChromeDriverJSONIndexWebPageURL"] = "https://googlechromelabs.github.io/chrome-for-testing/latest-versions-per-milestone-with-downloads.json";
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            if (browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
            {
                if (browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver != null)
                {
                    browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetprefer64bitChromeDriver);
                    browserDownloadSuitableChromeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromeDriverFromInternet["Prefer64bitChromeDriver"] = false;
                browserDownloadSuitableChromeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromeDriverFromInternetpropCount++;
            browserDownloadSuitableChromeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromeDriverFromInternetworkflow);
            if (browserDownloadSuitableChromeDriverFromInternetpropCount > 0)
            {
                callPayload.Body = browserDownloadSuitableChromeDriverFromInternet;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromeDriverFromInternetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromeDriverAvailableResponse> BrowserIsSuitableChromeDriverAvailable(Expression<Func<string>> browserIsSuitableChromeDriverAvailableworkflow, Expression<Func<string>> browserIsSuitableChromeDriverAvailablechromeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromeDriverAvailablechromeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/IsSuitableChromeDriverAvailable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserIsSuitableChromeDriverAvailable = new JObject();
            var browserIsSuitableChromeDriverAvailablepropCount = 0;
            if (browserIsSuitableChromeDriverAvailablechromeDriverFolder != null)
            {
                browserIsSuitableChromeDriverAvailable["ChromeDriverFolder"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailablechromeDriverFolder);
                browserIsSuitableChromeDriverAvailablepropCount++;
            }

            if (browserIsSuitableChromeDriverAvailablechromeBrowserEXE != null)
            {
                browserIsSuitableChromeDriverAvailable["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailablechromeBrowserEXE);
                browserIsSuitableChromeDriverAvailablepropCount++;
            }

            browserIsSuitableChromeDriverAvailablepropCount++;
            browserIsSuitableChromeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(browserIsSuitableChromeDriverAvailableworkflow);
            if (browserIsSuitableChromeDriverAvailablepropCount > 0)
            {
                callPayload.Body = browserIsSuitableChromeDriverAvailable;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromeDriverAvailableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromeDriver(Expression<Func<string>> browserUploadNewChromeDriverlocalChromeDriverFilePath, Expression<Func<string>> browserUploadNewChromeDriverworkflow, Expression<Func<bool>> browserUploadNewChromeDrivercompress = null, Expression<Func<int>> browserUploadNewChromeDriverchromeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromeDriverchromeDriverRootSaveFolder = null)
        {
            var apiCallPath = "/BrowserControl/UploadNewChromeDriver";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserUploadNewChromeDriver = new JObject();
            var browserUploadNewChromeDriverpropCount = 0;
            browserUploadNewChromeDriverpropCount++;
            browserUploadNewChromeDriver["LocalChromeDriverFilePath"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverlocalChromeDriverFilePath);
            if (browserUploadNewChromeDrivercompress != null)
            {
                if (browserUploadNewChromeDrivercompress != null)
                {
                    browserUploadNewChromeDriver["Compress"] = ExpressionConverter.ConvertO(browserUploadNewChromeDrivercompress);
                    browserUploadNewChromeDriverpropCount++;
                }

                browserUploadNewChromeDriverpropCount++;
            }
            else
            {
                browserUploadNewChromeDriver["Compress"] = false;
                browserUploadNewChromeDriverpropCount++;
            }

            if (browserUploadNewChromeDriverchromeBrowserMajorVersion != null)
            {
                browserUploadNewChromeDriver["ChromeBrowserMajorVersion"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverchromeBrowserMajorVersion);
                browserUploadNewChromeDriverpropCount++;
            }

            if (browserUploadNewChromeDriverchromeDriverRootSaveFolder != null)
            {
                browserUploadNewChromeDriver["ChromeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverchromeDriverRootSaveFolder);
                browserUploadNewChromeDriverpropCount++;
            }

            browserUploadNewChromeDriverpropCount++;
            browserUploadNewChromeDriver["Workflow"] = ExpressionConverter.ConvertO(browserUploadNewChromeDriverworkflow);
            if (browserUploadNewChromeDriverpropCount > 0)
            {
                callPayload.Body = browserUploadNewChromeDriver;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromeResponse> BrowserOpenChrome(Expression<Func<string>> browserOpenChromeworkflow, Expression<Func<string>> browserOpenChromechromeDriverFolder = null, Expression<Func<bool>> browserOpenChromekillExistingChromeDriver = null, Expression<Func<string>> browserOpenChromeuserDataDir = null, Expression<Func<bool>> browserOpenChromeprintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromedefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromedownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromechromeDriverLogFilename = null, Expression<Func<string>> browserOpenChromelocalChromeDriverFolder = null, Expression<Func<string>> browserOpenChromechromeBrowserEXE = null, Expression<Func<bool>> browserOpenChromeignoreCertificateErrors = null, Expression<Func<string>> browserOpenChromeadditionalArguments = null, Expression<Func<bool>> browserOpenChromedoNothingIfChromeInstanceAlreadyOpen = null)
        {
            var apiCallPath = "/BrowserControl/OpenChrome";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenChrome = new JObject();
            var browserOpenChromepropCount = 0;
            if (browserOpenChromechromeDriverFolder != null)
            {
                browserOpenChrome["ChromeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromechromeDriverFolder);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromekillExistingChromeDriver != null)
            {
                if (browserOpenChromekillExistingChromeDriver != null)
                {
                    browserOpenChrome["KillExistingChromeDriver"] = ExpressionConverter.ConvertO(browserOpenChromekillExistingChromeDriver);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["KillExistingChromeDriver"] = true;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeuserDataDir != null)
            {
                browserOpenChrome["UserDataDir"] = ExpressionConverter.ConvertO(browserOpenChromeuserDataDir);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeprintToDefaultPrinter != null)
            {
                if (browserOpenChromeprintToDefaultPrinter != null)
                {
                    browserOpenChrome["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(browserOpenChromeprintToDefaultPrinter);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["PrintToDefaultPrinter"] = true;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromedefaultDownloadDirectory != null)
            {
                browserOpenChrome["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(browserOpenChromedefaultDownloadDirectory);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromedownloadPDFInsteadOfOpening != null)
            {
                if (browserOpenChromedownloadPDFInsteadOfOpening != null)
                {
                    browserOpenChrome["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(browserOpenChromedownloadPDFInsteadOfOpening);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["DownloadPDFInsteadOfOpening"] = false;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromechromeDriverLogFilename != null)
            {
                browserOpenChrome["ChromeDriverLogFilename"] = ExpressionConverter.ConvertO(browserOpenChromechromeDriverLogFilename);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromelocalChromeDriverFolder != null)
            {
                browserOpenChrome["LocalChromeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromelocalChromeDriverFolder);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromechromeBrowserEXE != null)
            {
                browserOpenChrome["ChromeBrowserEXE"] = ExpressionConverter.ConvertO(browserOpenChromechromeBrowserEXE);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeignoreCertificateErrors != null)
            {
                if (browserOpenChromeignoreCertificateErrors != null)
                {
                    browserOpenChrome["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(browserOpenChromeignoreCertificateErrors);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["IgnoreCertificateErrors"] = false;
                browserOpenChromepropCount++;
            }

            if (browserOpenChromeadditionalArguments != null)
            {
                browserOpenChrome["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenChromeadditionalArguments);
                browserOpenChromepropCount++;
            }

            if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
            {
                if (browserOpenChromedoNothingIfChromeInstanceAlreadyOpen != null)
                {
                    browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(browserOpenChromedoNothingIfChromeInstanceAlreadyOpen);
                    browserOpenChromepropCount++;
                }

                browserOpenChromepropCount++;
            }
            else
            {
                browserOpenChrome["DoNothingIfChromeInstanceAlreadyOpen"] = false;
                browserOpenChromepropCount++;
            }

            browserOpenChromepropCount++;
            browserOpenChrome["Workflow"] = ExpressionConverter.ConvertO(browserOpenChromeworkflow);
            if (browserOpenChromepropCount > 0)
            {
                callPayload.Body = browserOpenChrome;
            }

            return new ApiConnectionAction<BrowserOpenChromeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChrome(Expression<Func<string>> browserCloseChromeworkflow, Expression<Func<bool>> browserCloseChromepurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromepurgeStaticUserDataDir = null)
        {
            var apiCallPath = "/BrowserControl/CloseChrome";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseChrome = new JObject();
            var browserCloseChromepropCount = 0;
            if (browserCloseChromepurgeDynamicUserDataDir != null)
            {
                if (browserCloseChromepurgeDynamicUserDataDir != null)
                {
                    browserCloseChrome["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromepurgeDynamicUserDataDir);
                    browserCloseChromepropCount++;
                }

                browserCloseChromepropCount++;
            }
            else
            {
                browserCloseChrome["PurgeDynamicUserDataDir"] = true;
                browserCloseChromepropCount++;
            }

            if (browserCloseChromepurgeStaticUserDataDir != null)
            {
                if (browserCloseChromepurgeStaticUserDataDir != null)
                {
                    browserCloseChrome["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromepurgeStaticUserDataDir);
                    browserCloseChromepropCount++;
                }

                browserCloseChromepropCount++;
            }
            else
            {
                browserCloseChrome["PurgeStaticUserDataDir"] = false;
                browserCloseChromepropCount++;
            }

            browserCloseChromepropCount++;
            browserCloseChrome["Workflow"] = ExpressionConverter.ConvertO(browserCloseChromeworkflow);
            if (browserCloseChromepropCount > 0)
            {
                callPayload.Body = browserCloseChrome;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserOpenInternetExplorer(Expression<Func<string>> browserOpenInternetExplorerworkflow, Expression<Func<string>> browserOpenInternetExploreriEDriverFolder = null, Expression<Func<bool>> browserOpenInternetExplorerkillExistingIEDriver = null, Expression<Func<bool>> browserOpenInternetExplorerkillExistingIE = null, Expression<Func<bool>> browserOpenInternetExplorercleanSession = null, Expression<Func<bool>> browserOpenInternetExplorerenableNativeEvents = null, Expression<Func<string>> browserOpenInternetExplorerwebDriverLogFile = null, Expression<Func<string>> browserOpenInternetExplorerwebDriverLogLevel = null, Expression<Func<bool>> browserOpenInternetExplorerdisableIEFirstRunCustomise = null, Expression<Func<string>> browserOpenInternetExploreradditionalArguments = null)
        {
            var apiCallPath = "/BrowserControl/OpenInternetExplorer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenInternetExplorer = new JObject();
            var browserOpenInternetExplorerpropCount = 0;
            if (browserOpenInternetExploreriEDriverFolder != null)
            {
                browserOpenInternetExplorer["IEDriverFolder"] = ExpressionConverter.ConvertO(browserOpenInternetExploreriEDriverFolder);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerkillExistingIEDriver != null)
            {
                if (browserOpenInternetExplorerkillExistingIEDriver != null)
                {
                    browserOpenInternetExplorer["KillExistingIEDriver"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerkillExistingIEDriver);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["KillExistingIEDriver"] = false;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerkillExistingIE != null)
            {
                if (browserOpenInternetExplorerkillExistingIE != null)
                {
                    browserOpenInternetExplorer["KillExistingIE"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerkillExistingIE);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["KillExistingIE"] = true;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorercleanSession != null)
            {
                if (browserOpenInternetExplorercleanSession != null)
                {
                    browserOpenInternetExplorer["CleanSession"] = ExpressionConverter.ConvertO(browserOpenInternetExplorercleanSession);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["CleanSession"] = false;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerenableNativeEvents != null)
            {
                if (browserOpenInternetExplorerenableNativeEvents != null)
                {
                    browserOpenInternetExplorer["EnableNativeEvents"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerenableNativeEvents);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["EnableNativeEvents"] = true;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerwebDriverLogFile != null)
            {
                browserOpenInternetExplorer["WebDriverLogFile"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerwebDriverLogFile);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerwebDriverLogLevel != null)
            {
                browserOpenInternetExplorer["WebDriverLogLevel"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerwebDriverLogLevel);
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
            {
                if (browserOpenInternetExplorerdisableIEFirstRunCustomise != null)
                {
                    browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerdisableIEFirstRunCustomise);
                    browserOpenInternetExplorerpropCount++;
                }

                browserOpenInternetExplorerpropCount++;
            }
            else
            {
                browserOpenInternetExplorer["DisableIEFirstRunCustomise"] = true;
                browserOpenInternetExplorerpropCount++;
            }

            if (browserOpenInternetExploreradditionalArguments != null)
            {
                browserOpenInternetExplorer["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenInternetExploreradditionalArguments);
                browserOpenInternetExplorerpropCount++;
            }

            browserOpenInternetExplorerpropCount++;
            browserOpenInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(browserOpenInternetExplorerworkflow);
            if (browserOpenInternetExplorerpropCount > 0)
            {
                callPayload.Body = browserOpenInternetExplorer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseInternetExplorer(Expression<Func<string>> browserCloseInternetExplorerworkflow, Expression<Func<bool>> browserCloseInternetExplorerunloadIEDriver = null)
        {
            var apiCallPath = "/BrowserControl/CloseInternetExplorer";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseInternetExplorer = new JObject();
            var browserCloseInternetExplorerpropCount = 0;
            if (browserCloseInternetExplorerunloadIEDriver != null)
            {
                if (browserCloseInternetExplorerunloadIEDriver != null)
                {
                    browserCloseInternetExplorer["UnloadIEDriver"] = ExpressionConverter.ConvertO(browserCloseInternetExplorerunloadIEDriver);
                    browserCloseInternetExplorerpropCount++;
                }

                browserCloseInternetExplorerpropCount++;
            }
            else
            {
                browserCloseInternetExplorer["UnloadIEDriver"] = false;
                browserCloseInternetExplorerpropCount++;
            }

            browserCloseInternetExplorerpropCount++;
            browserCloseInternetExplorer["Workflow"] = ExpressionConverter.ConvertO(browserCloseInternetExplorerworkflow);
            if (browserCloseInternetExplorerpropCount > 0)
            {
                callPayload.Body = browserCloseInternetExplorer;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeDriverFolderResponse> BrowserGetChromiumEdgeDriverFolder(Expression<Func<string>> browserGetChromiumEdgeDriverFolderdirectoryPath, Expression<Func<string>> browserGetChromiumEdgeDriverFolderworkflow, Expression<Func<int>> browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion = null, Expression<Func<string>> browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromiumEdgeDriverFolder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromiumEdgeDriverFolder = new JObject();
            var browserGetChromiumEdgeDriverFolderpropCount = 0;
            browserGetChromiumEdgeDriverFolderpropCount++;
            browserGetChromiumEdgeDriverFolder["DirectoryPath"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderdirectoryPath);
            if (browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion != null)
            {
                browserGetChromiumEdgeDriverFolder["ChromiumEdgeMajorVersion"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderchromiumEdgeMajorVersion);
                browserGetChromiumEdgeDriverFolderpropCount++;
            }

            if (browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE != null)
            {
                browserGetChromiumEdgeDriverFolder["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderchromiumEdgeBrowserEXE);
                browserGetChromiumEdgeDriverFolderpropCount++;
            }

            browserGetChromiumEdgeDriverFolderpropCount++;
            browserGetChromiumEdgeDriverFolder["Workflow"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeDriverFolderworkflow);
            if (browserGetChromiumEdgeDriverFolderpropCount > 0)
            {
                callPayload.Body = browserGetChromiumEdgeDriverFolder;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeDriverFolderResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse> BrowserGetChromiumEdgeBrowserVersionFromFile(Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFileworkflow, Expression<Func<string>> browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/GetChromiumEdgeBrowserVersionFromFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetChromiumEdgeBrowserVersionFromFile = new JObject();
            var browserGetChromiumEdgeBrowserVersionFromFilepropCount = 0;
            if (browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE != null)
            {
                browserGetChromiumEdgeBrowserVersionFromFile["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeBrowserVersionFromFilechromiumEdgeBrowserEXE);
                browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
            }

            browserGetChromiumEdgeBrowserVersionFromFilepropCount++;
            browserGetChromiumEdgeBrowserVersionFromFile["Workflow"] = ExpressionConverter.ConvertO(browserGetChromiumEdgeBrowserVersionFromFileworkflow);
            if (browserGetChromiumEdgeBrowserVersionFromFilepropCount > 0)
            {
                callPayload.Body = browserGetChromiumEdgeBrowserVersionFromFile;
            }

            return new ApiConnectionAction<BrowserGetChromiumEdgeBrowserVersionFromFileResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse> BrowserDownloadSuitableChromiumEdgeDriverFromInternet(Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE = null, Expression<Func<string>> browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL = null)
        {
            var apiCallPath = "/BrowserControl/BrowserDownloadSuitableChromiumEdgeDriverFromInternet";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDownloadSuitableChromiumEdgeDriverFromInternet = new JObject();
            var browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount = 0;
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE != null)
            {
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeBrowserEXE);
                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverDownloadParentFolder"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverDownloadParentFolder);
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
            {
                if (browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL != null)
                {
                    browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetchromiumEdgeDriverRootWebPageURL);
                    browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
                }

                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            }
            else
            {
                browserDownloadSuitableChromiumEdgeDriverFromInternet["ChromiumEdgeDriverRootWebPageURL"] = "https://msedgewebdriverstorage.blob.core.windows.net/edgewebdriver/";
                browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            }

            browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount++;
            browserDownloadSuitableChromiumEdgeDriverFromInternet["Workflow"] = ExpressionConverter.ConvertO(browserDownloadSuitableChromiumEdgeDriverFromInternetworkflow);
            if (browserDownloadSuitableChromiumEdgeDriverFromInternetpropCount > 0)
            {
                callPayload.Body = browserDownloadSuitableChromiumEdgeDriverFromInternet;
            }

            return new ApiConnectionAction<BrowserDownloadSuitableChromiumEdgeDriverFromInternetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse> BrowserIsSuitableChromiumEdgeDriverAvailable(Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailableworkflow, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder = null, Expression<Func<string>> browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE = null)
        {
            var apiCallPath = "/BrowserControl/IsSuitableChromiumEdgeDriverAvailable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserIsSuitableChromiumEdgeDriverAvailable = new JObject();
            var browserIsSuitableChromiumEdgeDriverAvailablepropCount = 0;
            if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder != null)
            {
                browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeDriverFolder);
                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            }

            if (browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE != null)
            {
                browserIsSuitableChromiumEdgeDriverAvailable["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailablechromiumEdgeBrowserEXE);
                browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            }

            browserIsSuitableChromiumEdgeDriverAvailablepropCount++;
            browserIsSuitableChromiumEdgeDriverAvailable["Workflow"] = ExpressionConverter.ConvertO(browserIsSuitableChromiumEdgeDriverAvailableworkflow);
            if (browserIsSuitableChromiumEdgeDriverAvailablepropCount > 0)
            {
                callPayload.Body = browserIsSuitableChromiumEdgeDriverAvailable;
            }

            return new ApiConnectionAction<BrowserIsSuitableChromiumEdgeDriverAvailableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserUploadNewChromiumEdgeDriver(Expression<Func<string>> browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath, Expression<Func<string>> browserUploadNewChromiumEdgeDriverworkflow, Expression<Func<bool>> browserUploadNewChromiumEdgeDrivercompress = null, Expression<Func<int>> browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion = null, Expression<Func<string>> browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder = null)
        {
            var apiCallPath = "/BrowserControl/UploadNewChromiumEdgeDriver";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserUploadNewChromiumEdgeDriver = new JObject();
            var browserUploadNewChromiumEdgeDriverpropCount = 0;
            browserUploadNewChromiumEdgeDriverpropCount++;
            browserUploadNewChromiumEdgeDriver["LocalChromiumEdgeDriverFilePath"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverlocalChromiumEdgeDriverFilePath);
            if (browserUploadNewChromiumEdgeDrivercompress != null)
            {
                if (browserUploadNewChromiumEdgeDrivercompress != null)
                {
                    browserUploadNewChromiumEdgeDriver["Compress"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDrivercompress);
                    browserUploadNewChromiumEdgeDriverpropCount++;
                }

                browserUploadNewChromiumEdgeDriverpropCount++;
            }
            else
            {
                browserUploadNewChromiumEdgeDriver["Compress"] = false;
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            if (browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion != null)
            {
                browserUploadNewChromiumEdgeDriver["ChromiumEdgeBrowserMajorVersion"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverchromiumEdgeBrowserMajorVersion);
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            if (browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder != null)
            {
                browserUploadNewChromiumEdgeDriver["ChromiumEdgeDriverRootSaveFolder"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverchromiumEdgeDriverRootSaveFolder);
                browserUploadNewChromiumEdgeDriverpropCount++;
            }

            browserUploadNewChromiumEdgeDriverpropCount++;
            browserUploadNewChromiumEdgeDriver["Workflow"] = ExpressionConverter.ConvertO(browserUploadNewChromiumEdgeDriverworkflow);
            if (browserUploadNewChromiumEdgeDriverpropCount > 0)
            {
                callPayload.Body = browserUploadNewChromiumEdgeDriver;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenChromiumEdgeResponse> BrowserOpenChromiumEdge(Expression<Func<string>> browserOpenChromiumEdgeworkflow, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeDriverFolder = null, Expression<Func<string>> browserOpenChromiumEdgeuserDataDir = null, Expression<Func<bool>> browserOpenChromiumEdgekillExistingChromiumEdgeDriver = null, Expression<Func<bool>> browserOpenChromiumEdgeprintToDefaultPrinter = null, Expression<Func<string>> browserOpenChromiumEdgedefaultDownloadDirectory = null, Expression<Func<bool>> browserOpenChromiumEdgedownloadPDFInsteadOfOpening = null, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeDriverLogFilename = null, Expression<Func<string>> browserOpenChromiumEdgelocalChromiumEdgeDriverFolder = null, Expression<Func<bool>> browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage = null, Expression<Func<string>> browserOpenChromiumEdgechromiumEdgeBrowserEXE = null, Expression<Func<bool>> browserOpenChromiumEdgeignoreCertificateErrors = null, Expression<Func<string>> browserOpenChromiumEdgeadditionalArguments = null, Expression<Func<bool>> browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen = null)
        {
            var apiCallPath = "/BrowserControl/OpenChromiumEdge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenChromiumEdge = new JObject();
            var browserOpenChromiumEdgepropCount = 0;
            if (browserOpenChromiumEdgechromiumEdgeDriverFolder != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgechromiumEdgeDriverFolder);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeuserDataDir != null)
            {
                browserOpenChromiumEdge["UserDataDir"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeuserDataDir);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
            {
                if (browserOpenChromiumEdgekillExistingChromiumEdgeDriver != null)
                {
                    browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgekillExistingChromiumEdgeDriver);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["KillExistingChromiumEdgeDriver"] = true;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeprintToDefaultPrinter != null)
            {
                if (browserOpenChromiumEdgeprintToDefaultPrinter != null)
                {
                    browserOpenChromiumEdge["PrintToDefaultPrinter"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeprintToDefaultPrinter);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["PrintToDefaultPrinter"] = true;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgedefaultDownloadDirectory != null)
            {
                browserOpenChromiumEdge["DefaultDownloadDirectory"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgedefaultDownloadDirectory);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
            {
                if (browserOpenChromiumEdgedownloadPDFInsteadOfOpening != null)
                {
                    browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgedownloadPDFInsteadOfOpening);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["DownloadPDFInsteadOfOpening"] = false;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgechromiumEdgeDriverLogFilename != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeDriverLogFilename"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgechromiumEdgeDriverLogFilename);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgelocalChromiumEdgeDriverFolder != null)
            {
                browserOpenChromiumEdge["LocalChromiumEdgeDriverFolder"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgelocalChromiumEdgeDriverFolder);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
            {
                if (browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage != null)
                {
                    browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgehideBrowserIsBeingAutomatedMessage);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["HideBrowserIsBeingAutomatedMessage"] = true;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgechromiumEdgeBrowserEXE != null)
            {
                browserOpenChromiumEdge["ChromiumEdgeBrowserEXE"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgechromiumEdgeBrowserEXE);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeignoreCertificateErrors != null)
            {
                if (browserOpenChromiumEdgeignoreCertificateErrors != null)
                {
                    browserOpenChromiumEdge["IgnoreCertificateErrors"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeignoreCertificateErrors);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["IgnoreCertificateErrors"] = false;
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgeadditionalArguments != null)
            {
                browserOpenChromiumEdge["AdditionalArguments"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeadditionalArguments);
                browserOpenChromiumEdgepropCount++;
            }

            if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
            {
                if (browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen != null)
                {
                    browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgedoNothingIfChromiumEdgeInstanceAlreadyOpen);
                    browserOpenChromiumEdgepropCount++;
                }

                browserOpenChromiumEdgepropCount++;
            }
            else
            {
                browserOpenChromiumEdge["DoNothingIfChromiumEdgeInstanceAlreadyOpen"] = false;
                browserOpenChromiumEdgepropCount++;
            }

            browserOpenChromiumEdgepropCount++;
            browserOpenChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(browserOpenChromiumEdgeworkflow);
            if (browserOpenChromiumEdgepropCount > 0)
            {
                callPayload.Body = browserOpenChromiumEdge;
            }

            return new ApiConnectionAction<BrowserOpenChromiumEdgeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseChromiumEdge(Expression<Func<string>> browserCloseChromiumEdgeworkflow, Expression<Func<bool>> browserCloseChromiumEdgepurgeDynamicUserDataDir = null, Expression<Func<bool>> browserCloseChromiumEdgepurgeStaticUserDataDir = null)
        {
            var apiCallPath = "/BrowserControl/CloseChromiumEdge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseChromiumEdge = new JObject();
            var browserCloseChromiumEdgepropCount = 0;
            if (browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
            {
                if (browserCloseChromiumEdgepurgeDynamicUserDataDir != null)
                {
                    browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgepurgeDynamicUserDataDir);
                    browserCloseChromiumEdgepropCount++;
                }

                browserCloseChromiumEdgepropCount++;
            }
            else
            {
                browserCloseChromiumEdge["PurgeDynamicUserDataDir"] = true;
                browserCloseChromiumEdgepropCount++;
            }

            if (browserCloseChromiumEdgepurgeStaticUserDataDir != null)
            {
                if (browserCloseChromiumEdgepurgeStaticUserDataDir != null)
                {
                    browserCloseChromiumEdge["PurgeStaticUserDataDir"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgepurgeStaticUserDataDir);
                    browserCloseChromiumEdgepropCount++;
                }

                browserCloseChromiumEdgepropCount++;
            }
            else
            {
                browserCloseChromiumEdge["PurgeStaticUserDataDir"] = false;
                browserCloseChromiumEdgepropCount++;
            }

            browserCloseChromiumEdgepropCount++;
            browserCloseChromiumEdge["Workflow"] = ExpressionConverter.ConvertO(browserCloseChromiumEdgeworkflow);
            if (browserCloseChromiumEdgepropCount > 0)
            {
                callPayload.Body = browserCloseChromiumEdge;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMaximise(Expression<Func<string>> browserMaximiseworkflow)
        {
            var apiCallPath = "/BrowserControl/MaximiseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMaximise = new JObject();
            var browserMaximisepropCount = 0;
            browserMaximisepropCount++;
            browserMaximise["Workflow"] = ExpressionConverter.ConvertO(browserMaximiseworkflow);
            if (browserMaximisepropCount > 0)
            {
                callPayload.Body = browserMaximise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMinimise(Expression<Func<string>> browserMinimiseworkflow)
        {
            var apiCallPath = "/BrowserControl/MinimiseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMinimise = new JObject();
            var browserMinimisepropCount = 0;
            browserMinimisepropCount++;
            browserMinimise["Workflow"] = ExpressionConverter.ConvertO(browserMinimiseworkflow);
            if (browserMinimisepropCount > 0)
            {
                callPayload.Body = browserMinimise;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFullscreen(Expression<Func<string>> browserFullscreenworkflow)
        {
            var apiCallPath = "/BrowserControl/FullscreenBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserFullscreen = new JObject();
            var browserFullscreenpropCount = 0;
            browserFullscreenpropCount++;
            browserFullscreen["Workflow"] = ExpressionConverter.ConvertO(browserFullscreenworkflow);
            if (browserFullscreenpropCount > 0)
            {
                callPayload.Body = browserFullscreen;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserNormaliseBrowser(Expression<Func<string>> browserNormaliseBrowserworkflow, Expression<Func<int>> browserNormaliseBrowserx = null, Expression<Func<int>> browserNormaliseBrowsery = null, Expression<Func<int>> browserNormaliseBrowserwidth = null, Expression<Func<int>> browserNormaliseBrowserheight = null)
        {
            var apiCallPath = "/BrowserControl/NormaliseBrowser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserNormaliseBrowser = new JObject();
            var browserNormaliseBrowserpropCount = 0;
            if (browserNormaliseBrowserx != null)
            {
                if (browserNormaliseBrowserx != null)
                {
                    browserNormaliseBrowser["X"] = ExpressionConverter.ConvertO(browserNormaliseBrowserx);
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
            }
            else
            {
                browserNormaliseBrowser["X"] = 20;
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowsery != null)
            {
                if (browserNormaliseBrowsery != null)
                {
                    browserNormaliseBrowser["Y"] = ExpressionConverter.ConvertO(browserNormaliseBrowsery);
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
            }
            else
            {
                browserNormaliseBrowser["Y"] = 20;
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowserwidth != null)
            {
                if (browserNormaliseBrowserwidth != null)
                {
                    browserNormaliseBrowser["Width"] = ExpressionConverter.ConvertO(browserNormaliseBrowserwidth);
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
            }
            else
            {
                browserNormaliseBrowser["Width"] = -40;
                browserNormaliseBrowserpropCount++;
            }

            if (browserNormaliseBrowserheight != null)
            {
                if (browserNormaliseBrowserheight != null)
                {
                    browserNormaliseBrowser["Height"] = ExpressionConverter.ConvertO(browserNormaliseBrowserheight);
                    browserNormaliseBrowserpropCount++;
                }

                browserNormaliseBrowserpropCount++;
            }
            else
            {
                browserNormaliseBrowser["Height"] = -40;
                browserNormaliseBrowserpropCount++;
            }

            browserNormaliseBrowserpropCount++;
            browserNormaliseBrowser["Workflow"] = ExpressionConverter.ConvertO(browserNormaliseBrowserworkflow);
            if (browserNormaliseBrowserpropCount > 0)
            {
                callPayload.Body = browserNormaliseBrowser;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowSize(Expression<Func<int>> browserSetWindowSizewidth, Expression<Func<int>> browserSetWindowSizeheight, Expression<Func<string>> browserSetWindowSizeworkflow)
        {
            var apiCallPath = "/BrowserControl/SetBrowserWindowSize";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetWindowSize = new JObject();
            var browserSetWindowSizepropCount = 0;
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Width"] = ExpressionConverter.ConvertO(browserSetWindowSizewidth);
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Height"] = ExpressionConverter.ConvertO(browserSetWindowSizeheight);
            browserSetWindowSizepropCount++;
            browserSetWindowSize["Workflow"] = ExpressionConverter.ConvertO(browserSetWindowSizeworkflow);
            if (browserSetWindowSizepropCount > 0)
            {
                callPayload.Body = browserSetWindowSize;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetWindowPosition(Expression<Func<int>> browserSetWindowPositionx, Expression<Func<int>> browserSetWindowPositiony, Expression<Func<string>> browserSetWindowPositionworkflow)
        {
            var apiCallPath = "/BrowserControl/SetBrowserWindowPosition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetWindowPosition = new JObject();
            var browserSetWindowPositionpropCount = 0;
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["X"] = ExpressionConverter.ConvertO(browserSetWindowPositionx);
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["Y"] = ExpressionConverter.ConvertO(browserSetWindowPositiony);
            browserSetWindowPositionpropCount++;
            browserSetWindowPosition["Workflow"] = ExpressionConverter.ConvertO(browserSetWindowPositionworkflow);
            if (browserSetWindowPositionpropCount > 0)
            {
                callPayload.Body = browserSetWindowPosition;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTimeouts(Expression<Func<string>> browserSetTimeoutsworkflow, Expression<Func<double>> browserSetTimeoutselementWaitTimeoutSeconds = null, Expression<Func<double>> browserSetTimeoutspageLoadTimeoutSeconds = null)
        {
            var apiCallPath = "/BrowserControl/SetTimeouts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetTimeouts = new JObject();
            var browserSetTimeoutspropCount = 0;
            if (browserSetTimeoutselementWaitTimeoutSeconds != null)
            {
                browserSetTimeouts["ElementWaitTimeoutSeconds"] = ExpressionConverter.ConvertO(browserSetTimeoutselementWaitTimeoutSeconds);
                browserSetTimeoutspropCount++;
            }

            if (browserSetTimeoutspageLoadTimeoutSeconds != null)
            {
                browserSetTimeouts["PageLoadTimeoutSeconds"] = ExpressionConverter.ConvertO(browserSetTimeoutspageLoadTimeoutSeconds);
                browserSetTimeoutspropCount++;
            }

            browserSetTimeoutspropCount++;
            browserSetTimeouts["Workflow"] = ExpressionConverter.ConvertO(browserSetTimeoutsworkflow);
            if (browserSetTimeoutspropCount > 0)
            {
                callPayload.Body = browserSetTimeouts;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserNavigateToURLResponse> BrowserNavigateToURL(Expression<Func<string>> browserNavigateToURLuRL, Expression<Func<string>> browserNavigateToURLworkflow)
        {
            var apiCallPath = "/BrowserControl/NavigateToURL";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserNavigateToURL = new JObject();
            var browserNavigateToURLpropCount = 0;
            browserNavigateToURLpropCount++;
            browserNavigateToURL["URL"] = ExpressionConverter.ConvertO(browserNavigateToURLuRL);
            browserNavigateToURLpropCount++;
            browserNavigateToURL["Workflow"] = ExpressionConverter.ConvertO(browserNavigateToURLworkflow);
            if (browserNavigateToURLpropCount > 0)
            {
                callPayload.Body = browserNavigateToURL;
            }

            return new ApiConnectionAction<BrowserNavigateToURLResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserRefreshPage(Expression<Func<string>> browserRefreshPageworkflow)
        {
            var apiCallPath = "/BrowserControl/RefreshPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserRefreshPage = new JObject();
            var browserRefreshPagepropCount = 0;
            browserRefreshPagepropCount++;
            browserRefreshPage["Workflow"] = ExpressionConverter.ConvertO(browserRefreshPageworkflow);
            if (browserRefreshPagepropCount > 0)
            {
                callPayload.Body = browserRefreshPage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetAllElementHandles(Expression<Func<string>> browserResetAllElementHandlesworkflow)
        {
            var apiCallPath = "/BrowserControl/ResetAllElementHandles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserResetAllElementHandles = new JObject();
            var browserResetAllElementHandlespropCount = 0;
            browserResetAllElementHandlespropCount++;
            browserResetAllElementHandles["Workflow"] = ExpressionConverter.ConvertO(browserResetAllElementHandlesworkflow);
            if (browserResetAllElementHandlespropCount > 0)
            {
                callPayload.Body = browserResetAllElementHandles;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserDoesElementExistResponse> BrowserDoesElementExist(Expression<Func<string>> browserDoesElementExistworkflow, Expression<Func<double>> browserDoesElementExistparentElementHandle = null, Expression<Func<double>> browserDoesElementExistsearchElementHandle = null, Expression<Func<string>> browserDoesElementExistsearchElementName = null, Expression<Func<string>> browserDoesElementExistsearchElementID = null, Expression<Func<string>> browserDoesElementExistsearchElementTagName = null, Expression<Func<string>> browserDoesElementExistsearchElementXPath = null, Expression<Func<string>> browserDoesElementExistsearchElementClassName = null, Expression<Func<string>> browserDoesElementExistsearchElementCSSSelector = null, Expression<Func<double>> browserDoesElementExistsearchElementIndex = null, Expression<Func<string>> browserDoesElementExistsearchElementMatchValue = null, Expression<Func<string>> browserDoesElementExistsearchElementMatchText = null, Expression<Func<string>> browserDoesElementExistsearchElementType = null, Expression<Func<double>> browserDoesElementExistsearchElementMinimumWidth = null, Expression<Func<double>> browserDoesElementExistsearchElementMinimumHeight = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDoesElementExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/DoesElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDoesElementExist = new JObject();
            var browserDoesElementExistpropCount = 0;
            if (browserDoesElementExistparentElementHandle != null)
            {
                browserDoesElementExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDoesElementExistparentElementHandle);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementHandle != null)
            {
                browserDoesElementExist["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementHandle);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementName != null)
            {
                browserDoesElementExist["SearchElementName"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementID != null)
            {
                browserDoesElementExist["SearchElementID"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementID);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementTagName != null)
            {
                browserDoesElementExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementTagName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementXPath != null)
            {
                browserDoesElementExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementXPath);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementClassName != null)
            {
                browserDoesElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementClassName);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementCSSSelector != null)
            {
                browserDoesElementExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementCSSSelector);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementIndex != null)
            {
                if (browserDoesElementExistsearchElementIndex != null)
                {
                    browserDoesElementExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementIndex);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementIndex"] = 1;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMatchValue != null)
            {
                browserDoesElementExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMatchValue);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMatchText != null)
            {
                browserDoesElementExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMatchText);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementType != null)
            {
                browserDoesElementExist["SearchElementType"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementType);
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMinimumWidth != null)
            {
                if (browserDoesElementExistsearchElementMinimumWidth != null)
                {
                    browserDoesElementExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMinimumWidth);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementMinimumWidth"] = 1;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementMinimumHeight != null)
            {
                if (browserDoesElementExistsearchElementMinimumHeight != null)
                {
                    browserDoesElementExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementMinimumHeight);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementMinimumHeight"] = 1;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxLeft != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxLeft != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxLeft);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxLeft"] = -99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxRight != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxRight != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxRight);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxRight"] = 99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxTop != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxTop != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxTop);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxTop"] = -99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistsearchElementBoundingBoxBottom != null)
            {
                if (browserDoesElementExistsearchElementBoundingBoxBottom != null)
                {
                    browserDoesElementExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDoesElementExistsearchElementBoundingBoxBottom);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["SearchElementBoundingBoxBottom"] = 99999;
                browserDoesElementExistpropCount++;
            }

            if (browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDoesElementExistonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserDoesElementExistpropCount++;
                }

                browserDoesElementExistpropCount++;
            }
            else
            {
                browserDoesElementExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserDoesElementExistpropCount++;
            }

            browserDoesElementExistpropCount++;
            browserDoesElementExist["Workflow"] = ExpressionConverter.ConvertO(browserDoesElementExistworkflow);
            if (browserDoesElementExistpropCount > 0)
            {
                callPayload.Body = browserDoesElementExist;
            }

            return new ApiConnectionAction<BrowserDoesElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToElementResponse> BrowserCreateHandleToElement(Expression<Func<string>> browserCreateHandleToElementworkflow, Expression<Func<double>> browserCreateHandleToElementparentElementHandle = null, Expression<Func<double>> browserCreateHandleToElementsearchElementHandle = null, Expression<Func<string>> browserCreateHandleToElementsearchElementName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementID = null, Expression<Func<string>> browserCreateHandleToElementsearchElementTagName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementXPath = null, Expression<Func<string>> browserCreateHandleToElementsearchElementClassName = null, Expression<Func<string>> browserCreateHandleToElementsearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToElementsearchElementIndex = null, Expression<Func<string>> browserCreateHandleToElementsearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToElementsearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToElementsearchElementType = null, Expression<Func<double>> browserCreateHandleToElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CreateHandleToElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCreateHandleToElement = new JObject();
            var browserCreateHandleToElementpropCount = 0;
            if (browserCreateHandleToElementparentElementHandle != null)
            {
                browserCreateHandleToElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToElementparentElementHandle);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementHandle != null)
            {
                browserCreateHandleToElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementHandle);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementName != null)
            {
                browserCreateHandleToElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementID != null)
            {
                browserCreateHandleToElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementID);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementTagName != null)
            {
                browserCreateHandleToElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementTagName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementXPath != null)
            {
                browserCreateHandleToElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementXPath);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementClassName != null)
            {
                browserCreateHandleToElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementClassName);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementCSSSelector != null)
            {
                browserCreateHandleToElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementCSSSelector);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementIndex != null)
            {
                if (browserCreateHandleToElementsearchElementIndex != null)
                {
                    browserCreateHandleToElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementIndex);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementIndex"] = 1;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMatchValue != null)
            {
                browserCreateHandleToElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMatchValue);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMatchText != null)
            {
                browserCreateHandleToElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMatchText);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementType != null)
            {
                browserCreateHandleToElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementType);
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMinimumWidth != null)
            {
                if (browserCreateHandleToElementsearchElementMinimumWidth != null)
                {
                    browserCreateHandleToElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMinimumWidth);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementMinimumWidth"] = 1;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementMinimumHeight != null)
            {
                if (browserCreateHandleToElementsearchElementMinimumHeight != null)
                {
                    browserCreateHandleToElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementMinimumHeight);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementMinimumHeight"] = 1;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxLeft != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxLeft);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxRight != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxRight != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxRight);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxRight"] = 99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxTop != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxTop != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxTop);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxTop"] = -99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCreateHandleToElementsearchElementBoundingBoxBottom != null)
                {
                    browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCreateHandleToElementsearchElementBoundingBoxBottom);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCreateHandleToElementpropCount++;
            }

            if (browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCreateHandleToElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserCreateHandleToElementpropCount++;
                }

                browserCreateHandleToElementpropCount++;
            }
            else
            {
                browserCreateHandleToElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserCreateHandleToElementpropCount++;
            }

            browserCreateHandleToElementpropCount++;
            browserCreateHandleToElement["Workflow"] = ExpressionConverter.ConvertO(browserCreateHandleToElementworkflow);
            if (browserCreateHandleToElementpropCount > 0)
            {
                callPayload.Body = browserCreateHandleToElement;
            }

            return new ApiConnectionAction<BrowserCreateHandleToElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserCreateHandleToParentElementResponse> BrowserCreateHandleToParentElement(Expression<Func<string>> browserCreateHandleToParentElementworkflow, Expression<Func<double>> browserCreateHandleToParentElementparentElementHandle = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementHandle = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementID = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementTagName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementXPath = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementClassName = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementCSSSelector = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementIndex = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementMatchValue = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementMatchText = null, Expression<Func<string>> browserCreateHandleToParentElementsearchElementType = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCreateHandleToParentElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CreateHandleToParentElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCreateHandleToParentElement = new JObject();
            var browserCreateHandleToParentElementpropCount = 0;
            if (browserCreateHandleToParentElementparentElementHandle != null)
            {
                browserCreateHandleToParentElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementparentElementHandle);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementHandle != null)
            {
                browserCreateHandleToParentElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementHandle);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementName != null)
            {
                browserCreateHandleToParentElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementID != null)
            {
                browserCreateHandleToParentElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementID);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementTagName != null)
            {
                browserCreateHandleToParentElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementTagName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementXPath != null)
            {
                browserCreateHandleToParentElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementXPath);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementClassName != null)
            {
                browserCreateHandleToParentElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementClassName);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementCSSSelector != null)
            {
                browserCreateHandleToParentElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementCSSSelector);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementIndex != null)
            {
                if (browserCreateHandleToParentElementsearchElementIndex != null)
                {
                    browserCreateHandleToParentElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementIndex);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementIndex"] = 1;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMatchValue != null)
            {
                browserCreateHandleToParentElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMatchValue);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMatchText != null)
            {
                browserCreateHandleToParentElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMatchText);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementType != null)
            {
                browserCreateHandleToParentElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementType);
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
            {
                if (browserCreateHandleToParentElementsearchElementMinimumWidth != null)
                {
                    browserCreateHandleToParentElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMinimumWidth);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementMinimumWidth"] = 1;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementMinimumHeight != null)
            {
                if (browserCreateHandleToParentElementsearchElementMinimumHeight != null)
                {
                    browserCreateHandleToParentElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementMinimumHeight);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementMinimumHeight"] = 1;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxLeft != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxLeft);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxRight != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxRight);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxRight"] = 99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxTop != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxTop);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxTop"] = -99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCreateHandleToParentElementsearchElementBoundingBoxBottom != null)
                {
                    browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementsearchElementBoundingBoxBottom);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCreateHandleToParentElementpropCount++;
            }

            if (browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserCreateHandleToParentElementpropCount++;
                }

                browserCreateHandleToParentElementpropCount++;
            }
            else
            {
                browserCreateHandleToParentElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserCreateHandleToParentElementpropCount++;
            }

            browserCreateHandleToParentElementpropCount++;
            browserCreateHandleToParentElement["Workflow"] = ExpressionConverter.ConvertO(browserCreateHandleToParentElementworkflow);
            if (browserCreateHandleToParentElementpropCount > 0)
            {
                callPayload.Body = browserCreateHandleToParentElement;
            }

            return new ApiConnectionAction<BrowserCreateHandleToParentElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementPropertiesResponse> BrowserGetElementProperties(Expression<Func<string>> browserGetElementPropertiesworkflow, Expression<Func<double>> browserGetElementPropertiesparentElementHandle = null, Expression<Func<double>> browserGetElementPropertiessearchElementHandle = null, Expression<Func<string>> browserGetElementPropertiessearchElementName = null, Expression<Func<string>> browserGetElementPropertiessearchElementID = null, Expression<Func<string>> browserGetElementPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetElementPropertiessearchElementIndex = null, Expression<Func<string>> browserGetElementPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementPropertiessearchElementType = null, Expression<Func<double>> browserGetElementPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementPropertiesreturnElementHandle = null)
        {
            var apiCallPath = "/BrowserControl/GetElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementProperties = new JObject();
            var browserGetElementPropertiespropCount = 0;
            if (browserGetElementPropertiesparentElementHandle != null)
            {
                browserGetElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiesparentElementHandle);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementHandle != null)
            {
                browserGetElementProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementHandle);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementName != null)
            {
                browserGetElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementID != null)
            {
                browserGetElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementID);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementTagName != null)
            {
                browserGetElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementTagName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementXPath != null)
            {
                browserGetElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementXPath);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementClassName != null)
            {
                browserGetElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementClassName);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementCSSSelector != null)
            {
                browserGetElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementCSSSelector);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementIndex != null)
            {
                if (browserGetElementPropertiessearchElementIndex != null)
                {
                    browserGetElementProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementIndex);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementIndex"] = 1;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMatchValue != null)
            {
                browserGetElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMatchValue);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMatchText != null)
            {
                browserGetElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMatchText);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementType != null)
            {
                browserGetElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementType);
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetElementPropertiessearchElementMinimumWidth != null)
                {
                    browserGetElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMinimumWidth);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementMinimumWidth"] = 1;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetElementPropertiessearchElementMinimumHeight != null)
                {
                    browserGetElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementMinimumHeight);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementMinimumHeight"] = 1;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxLeft);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxRight);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxTop);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementPropertiessearchElementBoundingBoxBottom);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesgetHTMLCode != null)
            {
                if (browserGetElementPropertiesgetHTMLCode != null)
                {
                    browserGetElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementPropertiesgetHTMLCode);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["GetHTMLCode"] = false;
                browserGetElementPropertiespropCount++;
            }

            if (browserGetElementPropertiesreturnElementHandle != null)
            {
                if (browserGetElementPropertiesreturnElementHandle != null)
                {
                    browserGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(browserGetElementPropertiesreturnElementHandle);
                    browserGetElementPropertiespropCount++;
                }

                browserGetElementPropertiespropCount++;
            }
            else
            {
                browserGetElementProperties["ReturnElementHandle"] = true;
                browserGetElementPropertiespropCount++;
            }

            browserGetElementPropertiespropCount++;
            browserGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementPropertiesworkflow);
            if (browserGetElementPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementProperties;
            }

            return new ApiConnectionAction<BrowserGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetMultipleElementPropertiesResponse> BrowserGetMultipleElementProperties(Expression<Func<string>> browserGetMultipleElementPropertiesworkflow, Expression<Func<double>> browserGetMultipleElementPropertiesparentElementHandle = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementID = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementTagName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementXPath = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementClassName = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementCSSSelector = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetMultipleElementPropertiessearchElementType = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetMultipleElementPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetMultipleElementPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetMultipleElementPropertiescreateHandle = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnValue = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnText = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxValueLength = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxTextLength = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnIsDisplayed = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnCoordinates = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnDimensions = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnChildElementCount = null, Expression<Func<bool>> browserGetMultipleElementPropertiesreturnParentTag = null, Expression<Func<int>> browserGetMultipleElementPropertiesfirstItemToReturn = null, Expression<Func<int>> browserGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            var apiCallPath = "/BrowserControl/GetMultipleElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetMultipleElementProperties = new JObject();
            var browserGetMultipleElementPropertiespropCount = 0;
            if (browserGetMultipleElementPropertiesparentElementHandle != null)
            {
                browserGetMultipleElementProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesparentElementHandle);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementName != null)
            {
                browserGetMultipleElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementID != null)
            {
                browserGetMultipleElementProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementID);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementTagName != null)
            {
                browserGetMultipleElementProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementTagName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementXPath != null)
            {
                browserGetMultipleElementProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementXPath);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementClassName != null)
            {
                browserGetMultipleElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementClassName);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementCSSSelector != null)
            {
                browserGetMultipleElementProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementCSSSelector);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMatchValue != null)
            {
                browserGetMultipleElementProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMatchValue);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMatchText != null)
            {
                browserGetMultipleElementProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMatchText);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementType != null)
            {
                browserGetMultipleElementProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementType);
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetMultipleElementPropertiessearchElementMinimumWidth != null)
                {
                    browserGetMultipleElementProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMinimumWidth);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementMinimumWidth"] = 1;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetMultipleElementPropertiessearchElementMinimumHeight != null)
                {
                    browserGetMultipleElementProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementMinimumHeight);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementMinimumHeight"] = 1;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxLeft);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxRight);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxTop);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetMultipleElementPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiessearchElementBoundingBoxBottom);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesgetHTMLCode != null)
            {
                if (browserGetMultipleElementPropertiesgetHTMLCode != null)
                {
                    browserGetMultipleElementProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesgetHTMLCode);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["GetHTMLCode"] = false;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiescreateHandle != null)
            {
                if (browserGetMultipleElementPropertiescreateHandle != null)
                {
                    browserGetMultipleElementProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiescreateHandle);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["CreateHandle"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnValue != null)
            {
                if (browserGetMultipleElementPropertiesreturnValue != null)
                {
                    browserGetMultipleElementProperties["ReturnValue"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnValue);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnValue"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnText != null)
            {
                if (browserGetMultipleElementPropertiesreturnText != null)
                {
                    browserGetMultipleElementProperties["ReturnText"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnText);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnText"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesmaxValueLength != null)
            {
                if (browserGetMultipleElementPropertiesmaxValueLength != null)
                {
                    browserGetMultipleElementProperties["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesmaxValueLength);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["MaxValueLength"] = 0;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesmaxTextLength != null)
            {
                if (browserGetMultipleElementPropertiesmaxTextLength != null)
                {
                    browserGetMultipleElementProperties["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesmaxTextLength);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["MaxTextLength"] = 0;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnIsDisplayed != null)
            {
                if (browserGetMultipleElementPropertiesreturnIsDisplayed != null)
                {
                    browserGetMultipleElementProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnIsDisplayed);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnIsDisplayed"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnCoordinates != null)
            {
                if (browserGetMultipleElementPropertiesreturnCoordinates != null)
                {
                    browserGetMultipleElementProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnCoordinates);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnCoordinates"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnDimensions != null)
            {
                if (browserGetMultipleElementPropertiesreturnDimensions != null)
                {
                    browserGetMultipleElementProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnDimensions);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnDimensions"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnChildElementCount != null)
            {
                if (browserGetMultipleElementPropertiesreturnChildElementCount != null)
                {
                    browserGetMultipleElementProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnChildElementCount);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnChildElementCount"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesreturnParentTag != null)
            {
                if (browserGetMultipleElementPropertiesreturnParentTag != null)
                {
                    browserGetMultipleElementProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesreturnParentTag);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["ReturnParentTag"] = true;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesfirstItemToReturn != null)
            {
                if (browserGetMultipleElementPropertiesfirstItemToReturn != null)
                {
                    browserGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesfirstItemToReturn);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["FirstItemToReturn"] = 1;
                browserGetMultipleElementPropertiespropCount++;
            }

            if (browserGetMultipleElementPropertiesmaxItemsToReturn != null)
            {
                if (browserGetMultipleElementPropertiesmaxItemsToReturn != null)
                {
                    browserGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesmaxItemsToReturn);
                    browserGetMultipleElementPropertiespropCount++;
                }

                browserGetMultipleElementPropertiespropCount++;
            }
            else
            {
                browserGetMultipleElementProperties["MaxItemsToReturn"] = 0;
                browserGetMultipleElementPropertiespropCount++;
            }

            browserGetMultipleElementPropertiespropCount++;
            browserGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetMultipleElementPropertiesworkflow);
            if (browserGetMultipleElementPropertiespropCount > 0)
            {
                callPayload.Body = browserGetMultipleElementProperties;
            }

            return new ApiConnectionAction<BrowserGetMultipleElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementParentPropertiesResponse> BrowserGetElementParentProperties(Expression<Func<string>> browserGetElementParentPropertiesworkflow, Expression<Func<double>> browserGetElementParentPropertiesparentElementHandle = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementHandle = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementID = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementIndex = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementParentPropertiessearchElementType = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementParentPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementParentPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementParentPropertiescreateHandle = null)
        {
            var apiCallPath = "/BrowserControl/GetElementParentProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementParentProperties = new JObject();
            var browserGetElementParentPropertiespropCount = 0;
            if (browserGetElementParentPropertiesparentElementHandle != null)
            {
                browserGetElementParentProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesparentElementHandle);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementHandle != null)
            {
                browserGetElementParentProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementHandle);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementName != null)
            {
                browserGetElementParentProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementID != null)
            {
                browserGetElementParentProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementID);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementTagName != null)
            {
                browserGetElementParentProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementTagName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementXPath != null)
            {
                browserGetElementParentProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementXPath);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementClassName != null)
            {
                browserGetElementParentProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementClassName);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementCSSSelector != null)
            {
                browserGetElementParentProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementCSSSelector);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementIndex != null)
            {
                if (browserGetElementParentPropertiessearchElementIndex != null)
                {
                    browserGetElementParentProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementIndex);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementIndex"] = 1;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMatchValue != null)
            {
                browserGetElementParentProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMatchValue);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMatchText != null)
            {
                browserGetElementParentProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMatchText);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementType != null)
            {
                browserGetElementParentProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementType);
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetElementParentPropertiessearchElementMinimumWidth != null)
                {
                    browserGetElementParentProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMinimumWidth);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementMinimumWidth"] = 1;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetElementParentPropertiessearchElementMinimumHeight != null)
                {
                    browserGetElementParentProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementMinimumHeight);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementMinimumHeight"] = 1;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxLeft);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxRight);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxTop);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementParentPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiessearchElementBoundingBoxBottom);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiesgetHTMLCode != null)
            {
                if (browserGetElementParentPropertiesgetHTMLCode != null)
                {
                    browserGetElementParentProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesgetHTMLCode);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["GetHTMLCode"] = false;
                browserGetElementParentPropertiespropCount++;
            }

            if (browserGetElementParentPropertiescreateHandle != null)
            {
                if (browserGetElementParentPropertiescreateHandle != null)
                {
                    browserGetElementParentProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiescreateHandle);
                    browserGetElementParentPropertiespropCount++;
                }

                browserGetElementParentPropertiespropCount++;
            }
            else
            {
                browserGetElementParentProperties["CreateHandle"] = true;
                browserGetElementParentPropertiespropCount++;
            }

            browserGetElementParentPropertiespropCount++;
            browserGetElementParentProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementParentPropertiesworkflow);
            if (browserGetElementParentPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementParentProperties;
            }

            return new ApiConnectionAction<BrowserGetElementParentPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementChildrenPropertiesResponse> BrowserGetElementChildrenProperties(Expression<Func<string>> browserGetElementChildrenPropertiesworkflow, Expression<Func<double>> browserGetElementChildrenPropertiesparentElementHandle = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementID = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementTagName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementXPath = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementClassName = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementCSSSelector = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetElementChildrenPropertiessearchElementType = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementChildrenPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserGetElementChildrenPropertiesgetHTMLCode = null, Expression<Func<bool>> browserGetElementChildrenPropertiescreateHandle = null, Expression<Func<bool>> browserGetElementChildrenPropertiessearchSubTree = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnValue = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnText = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxValueLength = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxTextLength = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnIsDisplayed = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnCoordinates = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnDimensions = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnChildElementCount = null, Expression<Func<bool>> browserGetElementChildrenPropertiesreturnParentTag = null, Expression<Func<int>> browserGetElementChildrenPropertiesfirstItemToReturn = null, Expression<Func<int>> browserGetElementChildrenPropertiesmaxItemsToReturn = null)
        {
            var apiCallPath = "/BrowserControl/GetElementChildrenProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementChildrenProperties = new JObject();
            var browserGetElementChildrenPropertiespropCount = 0;
            if (browserGetElementChildrenPropertiesparentElementHandle != null)
            {
                browserGetElementChildrenProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesparentElementHandle);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementName != null)
            {
                browserGetElementChildrenProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementID != null)
            {
                browserGetElementChildrenProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementID);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementTagName != null)
            {
                browserGetElementChildrenProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementTagName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementXPath != null)
            {
                browserGetElementChildrenProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementXPath);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementClassName != null)
            {
                browserGetElementChildrenProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementClassName);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementCSSSelector != null)
            {
                browserGetElementChildrenProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementCSSSelector);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMatchValue != null)
            {
                browserGetElementChildrenProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMatchValue);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMatchText != null)
            {
                browserGetElementChildrenProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMatchText);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementType != null)
            {
                browserGetElementChildrenProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementType);
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetElementChildrenPropertiessearchElementMinimumWidth != null)
                {
                    browserGetElementChildrenProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMinimumWidth);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementMinimumWidth"] = 1;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetElementChildrenPropertiessearchElementMinimumHeight != null)
                {
                    browserGetElementChildrenProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementMinimumHeight);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementMinimumHeight"] = 1;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxLeft);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxRight);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxTop);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementChildrenPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchElementBoundingBoxBottom);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesgetHTMLCode != null)
            {
                if (browserGetElementChildrenPropertiesgetHTMLCode != null)
                {
                    browserGetElementChildrenProperties["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesgetHTMLCode);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["GetHTMLCode"] = false;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiescreateHandle != null)
            {
                if (browserGetElementChildrenPropertiescreateHandle != null)
                {
                    browserGetElementChildrenProperties["CreateHandle"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiescreateHandle);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["CreateHandle"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiessearchSubTree != null)
            {
                if (browserGetElementChildrenPropertiessearchSubTree != null)
                {
                    browserGetElementChildrenProperties["SearchSubTree"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiessearchSubTree);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["SearchSubTree"] = false;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnValue != null)
            {
                if (browserGetElementChildrenPropertiesreturnValue != null)
                {
                    browserGetElementChildrenProperties["ReturnValue"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnValue);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnValue"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnText != null)
            {
                if (browserGetElementChildrenPropertiesreturnText != null)
                {
                    browserGetElementChildrenProperties["ReturnText"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnText);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnText"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesmaxValueLength != null)
            {
                if (browserGetElementChildrenPropertiesmaxValueLength != null)
                {
                    browserGetElementChildrenProperties["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesmaxValueLength);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["MaxValueLength"] = 0;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesmaxTextLength != null)
            {
                if (browserGetElementChildrenPropertiesmaxTextLength != null)
                {
                    browserGetElementChildrenProperties["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesmaxTextLength);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["MaxTextLength"] = 0;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnIsDisplayed != null)
            {
                if (browserGetElementChildrenPropertiesreturnIsDisplayed != null)
                {
                    browserGetElementChildrenProperties["ReturnIsDisplayed"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnIsDisplayed);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnIsDisplayed"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnCoordinates != null)
            {
                if (browserGetElementChildrenPropertiesreturnCoordinates != null)
                {
                    browserGetElementChildrenProperties["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnCoordinates);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnCoordinates"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnDimensions != null)
            {
                if (browserGetElementChildrenPropertiesreturnDimensions != null)
                {
                    browserGetElementChildrenProperties["ReturnDimensions"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnDimensions);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnDimensions"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnChildElementCount != null)
            {
                if (browserGetElementChildrenPropertiesreturnChildElementCount != null)
                {
                    browserGetElementChildrenProperties["ReturnChildElementCount"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnChildElementCount);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnChildElementCount"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesreturnParentTag != null)
            {
                if (browserGetElementChildrenPropertiesreturnParentTag != null)
                {
                    browserGetElementChildrenProperties["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesreturnParentTag);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["ReturnParentTag"] = true;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesfirstItemToReturn != null)
            {
                if (browserGetElementChildrenPropertiesfirstItemToReturn != null)
                {
                    browserGetElementChildrenProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesfirstItemToReturn);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["FirstItemToReturn"] = 1;
                browserGetElementChildrenPropertiespropCount++;
            }

            if (browserGetElementChildrenPropertiesmaxItemsToReturn != null)
            {
                if (browserGetElementChildrenPropertiesmaxItemsToReturn != null)
                {
                    browserGetElementChildrenProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesmaxItemsToReturn);
                    browserGetElementChildrenPropertiespropCount++;
                }

                browserGetElementChildrenPropertiespropCount++;
            }
            else
            {
                browserGetElementChildrenProperties["MaxItemsToReturn"] = 0;
                browserGetElementChildrenPropertiespropCount++;
            }

            browserGetElementChildrenPropertiespropCount++;
            browserGetElementChildrenProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetElementChildrenPropertiesworkflow);
            if (browserGetElementChildrenPropertiespropCount > 0)
            {
                callPayload.Body = browserGetElementChildrenProperties;
            }

            return new ApiConnectionAction<BrowserGetElementChildrenPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserInputTextIntoElementResponse> BrowserInputTextIntoElement(Expression<Func<string>> browserInputTextIntoElementworkflow, Expression<Func<double>> browserInputTextIntoElementparentElementHandle = null, Expression<Func<double>> browserInputTextIntoElementsearchElementHandle = null, Expression<Func<string>> browserInputTextIntoElementsearchElementName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementID = null, Expression<Func<string>> browserInputTextIntoElementsearchElementTagName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementXPath = null, Expression<Func<string>> browserInputTextIntoElementsearchElementClassName = null, Expression<Func<string>> browserInputTextIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserInputTextIntoElementsearchElementIndex = null, Expression<Func<string>> browserInputTextIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserInputTextIntoElementsearchElementMatchText = null, Expression<Func<string>> browserInputTextIntoElementsearchElementType = null, Expression<Func<double>> browserInputTextIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserInputTextIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputTextIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserInputTextIntoElementtextToInput = null, Expression<Func<bool>> browserInputTextIntoElementresetExistingValue = null, Expression<Func<int>> browserInputTextIntoElementinsertPosition = null)
        {
            var apiCallPath = "/BrowserControl/InputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputTextIntoElement = new JObject();
            var browserInputTextIntoElementpropCount = 0;
            if (browserInputTextIntoElementparentElementHandle != null)
            {
                browserInputTextIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserInputTextIntoElementparentElementHandle);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementHandle != null)
            {
                browserInputTextIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementHandle);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementName != null)
            {
                browserInputTextIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementID != null)
            {
                browserInputTextIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementID);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementTagName != null)
            {
                browserInputTextIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementTagName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementXPath != null)
            {
                browserInputTextIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementXPath);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementClassName != null)
            {
                browserInputTextIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementClassName);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementCSSSelector != null)
            {
                browserInputTextIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementCSSSelector);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementIndex != null)
            {
                if (browserInputTextIntoElementsearchElementIndex != null)
                {
                    browserInputTextIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementIndex);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementIndex"] = 1;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMatchValue != null)
            {
                browserInputTextIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMatchValue);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMatchText != null)
            {
                browserInputTextIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMatchText);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementType != null)
            {
                browserInputTextIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementType);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMinimumWidth != null)
            {
                if (browserInputTextIntoElementsearchElementMinimumWidth != null)
                {
                    browserInputTextIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMinimumWidth);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementMinimumWidth"] = 1;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementMinimumHeight != null)
            {
                if (browserInputTextIntoElementsearchElementMinimumHeight != null)
                {
                    browserInputTextIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementMinimumHeight);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementMinimumHeight"] = 1;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxLeft != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxLeft);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxRight != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxRight != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxRight);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxRight"] = 99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxTop != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxTop != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxTop);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxTop"] = -99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
            {
                if (browserInputTextIntoElementsearchElementBoundingBoxBottom != null)
                {
                    browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserInputTextIntoElementsearchElementBoundingBoxBottom);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserInputTextIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementtextToInput != null)
            {
                browserInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(browserInputTextIntoElementtextToInput);
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementresetExistingValue != null)
            {
                if (browserInputTextIntoElementresetExistingValue != null)
                {
                    browserInputTextIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(browserInputTextIntoElementresetExistingValue);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["ResetExistingValue"] = true;
                browserInputTextIntoElementpropCount++;
            }

            if (browserInputTextIntoElementinsertPosition != null)
            {
                if (browserInputTextIntoElementinsertPosition != null)
                {
                    browserInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(browserInputTextIntoElementinsertPosition);
                    browserInputTextIntoElementpropCount++;
                }

                browserInputTextIntoElementpropCount++;
            }
            else
            {
                browserInputTextIntoElement["InsertPosition"] = -1;
                browserInputTextIntoElementpropCount++;
            }

            browserInputTextIntoElementpropCount++;
            browserInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserInputTextIntoElementworkflow);
            if (browserInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = browserInputTextIntoElement;
            }

            return new ApiConnectionAction<BrowserInputTextIntoElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputTextIntoMultipleElements(Expression<Func<string>> browserInputTextIntoMultipleElementsinputElementsJSON, Expression<Func<string>> browserInputTextIntoMultipleElementsworkflow)
        {
            var apiCallPath = "/BrowserControl/BrowserInputTextIntoMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputTextIntoMultipleElements = new JObject();
            var browserInputTextIntoMultipleElementspropCount = 0;
            browserInputTextIntoMultipleElementspropCount++;
            browserInputTextIntoMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(browserInputTextIntoMultipleElementsinputElementsJSON);
            browserInputTextIntoMultipleElementspropCount++;
            browserInputTextIntoMultipleElements["Workflow"] = ExpressionConverter.ConvertO(browserInputTextIntoMultipleElementsworkflow);
            if (browserInputTextIntoMultipleElementspropCount > 0)
            {
                callPayload.Body = browserInputTextIntoMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressCtrlKeyOnElement(Expression<Func<string>> browserPressCtrlKeyOnElementcontrolKey, Expression<Func<string>> browserPressCtrlKeyOnElementworkflow, Expression<Func<double>> browserPressCtrlKeyOnElementparentElementHandle = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementHandle = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementID = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementTagName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementXPath = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementClassName = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementIndex = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementMatchValue = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementMatchText = null, Expression<Func<string>> browserPressCtrlKeyOnElementsearchElementType = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PressCtrlKeyOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPressCtrlKeyOnElement = new JObject();
            var browserPressCtrlKeyOnElementpropCount = 0;
            if (browserPressCtrlKeyOnElementparentElementHandle != null)
            {
                browserPressCtrlKeyOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementparentElementHandle);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementHandle != null)
            {
                browserPressCtrlKeyOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementHandle);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementID != null)
            {
                browserPressCtrlKeyOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementID);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementTagName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementTagName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementXPath != null)
            {
                browserPressCtrlKeyOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementXPath);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementClassName != null)
            {
                browserPressCtrlKeyOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementClassName);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementCSSSelector != null)
            {
                browserPressCtrlKeyOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementCSSSelector);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementIndex != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementIndex != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementIndex);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementIndex"] = 1;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMatchValue != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMatchValue);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMatchText != null)
            {
                browserPressCtrlKeyOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMatchText);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementType != null)
            {
                browserPressCtrlKeyOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementType);
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementMinimumWidth != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMinimumWidth);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementMinimumWidth"] = 1;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementMinimumHeight != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementMinimumHeight);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementMinimumHeight"] = 1;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxLeft);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxRight != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxRight);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxTop != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxTop);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementsearchElementBoundingBoxBottom);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserPressCtrlKeyOnElementpropCount++;
            }

            if (browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserPressCtrlKeyOnElementpropCount++;
                }

                browserPressCtrlKeyOnElementpropCount++;
            }
            else
            {
                browserPressCtrlKeyOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserPressCtrlKeyOnElementpropCount++;
            }

            browserPressCtrlKeyOnElementpropCount++;
            browserPressCtrlKeyOnElement["ControlKey"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementcontrolKey);
            browserPressCtrlKeyOnElementpropCount++;
            browserPressCtrlKeyOnElement["Workflow"] = ExpressionConverter.ConvertO(browserPressCtrlKeyOnElementworkflow);
            if (browserPressCtrlKeyOnElementpropCount > 0)
            {
                callPayload.Body = browserPressCtrlKeyOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserClickElement(Expression<Func<string>> browserClickElementworkflow, Expression<Func<double>> browserClickElementparentElementHandle = null, Expression<Func<double>> browserClickElementsearchElementHandle = null, Expression<Func<string>> browserClickElementsearchElementName = null, Expression<Func<string>> browserClickElementsearchElementID = null, Expression<Func<string>> browserClickElementsearchElementTagName = null, Expression<Func<string>> browserClickElementsearchElementXPath = null, Expression<Func<string>> browserClickElementsearchElementClassName = null, Expression<Func<string>> browserClickElementsearchElementCSSSelector = null, Expression<Func<double>> browserClickElementsearchElementIndex = null, Expression<Func<string>> browserClickElementsearchElementMatchValue = null, Expression<Func<string>> browserClickElementsearchElementMatchText = null, Expression<Func<string>> browserClickElementsearchElementType = null, Expression<Func<double>> browserClickElementsearchElementMinimumWidth = null, Expression<Func<double>> browserClickElementsearchElementMinimumHeight = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserClickElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ClickElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserClickElement = new JObject();
            var browserClickElementpropCount = 0;
            if (browserClickElementparentElementHandle != null)
            {
                browserClickElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserClickElementparentElementHandle);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementHandle != null)
            {
                browserClickElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserClickElementsearchElementHandle);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementName != null)
            {
                browserClickElement["SearchElementName"] = ExpressionConverter.ConvertO(browserClickElementsearchElementName);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementID != null)
            {
                browserClickElement["SearchElementID"] = ExpressionConverter.ConvertO(browserClickElementsearchElementID);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementTagName != null)
            {
                browserClickElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserClickElementsearchElementTagName);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementXPath != null)
            {
                browserClickElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserClickElementsearchElementXPath);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementClassName != null)
            {
                browserClickElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserClickElementsearchElementClassName);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementCSSSelector != null)
            {
                browserClickElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserClickElementsearchElementCSSSelector);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementIndex != null)
            {
                if (browserClickElementsearchElementIndex != null)
                {
                    browserClickElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserClickElementsearchElementIndex);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementIndex"] = 1;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMatchValue != null)
            {
                browserClickElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMatchValue);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMatchText != null)
            {
                browserClickElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMatchText);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementType != null)
            {
                browserClickElement["SearchElementType"] = ExpressionConverter.ConvertO(browserClickElementsearchElementType);
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMinimumWidth != null)
            {
                if (browserClickElementsearchElementMinimumWidth != null)
                {
                    browserClickElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMinimumWidth);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementMinimumWidth"] = 1;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementMinimumHeight != null)
            {
                if (browserClickElementsearchElementMinimumHeight != null)
                {
                    browserClickElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserClickElementsearchElementMinimumHeight);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementMinimumHeight"] = 1;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxLeft != null)
            {
                if (browserClickElementsearchElementBoundingBoxLeft != null)
                {
                    browserClickElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxLeft);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxLeft"] = -99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxRight != null)
            {
                if (browserClickElementsearchElementBoundingBoxRight != null)
                {
                    browserClickElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxRight);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxRight"] = 99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxTop != null)
            {
                if (browserClickElementsearchElementBoundingBoxTop != null)
                {
                    browserClickElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxTop);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxTop"] = -99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementsearchElementBoundingBoxBottom != null)
            {
                if (browserClickElementsearchElementBoundingBoxBottom != null)
                {
                    browserClickElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserClickElementsearchElementBoundingBoxBottom);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["SearchElementBoundingBoxBottom"] = 99999;
                browserClickElementpropCount++;
            }

            if (browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserClickElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserClickElementpropCount++;
                }

                browserClickElementpropCount++;
            }
            else
            {
                browserClickElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserClickElementpropCount++;
            }

            browserClickElementpropCount++;
            browserClickElement["Workflow"] = ExpressionConverter.ConvertO(browserClickElementworkflow);
            if (browserClickElementpropCount > 0)
            {
                callPayload.Body = browserClickElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSubmitElement(Expression<Func<string>> browserSubmitElementworkflow, Expression<Func<double>> browserSubmitElementparentElementHandle = null, Expression<Func<double>> browserSubmitElementsearchElementHandle = null, Expression<Func<string>> browserSubmitElementsearchElementName = null, Expression<Func<string>> browserSubmitElementsearchElementID = null, Expression<Func<string>> browserSubmitElementsearchElementTagName = null, Expression<Func<string>> browserSubmitElementsearchElementXPath = null, Expression<Func<string>> browserSubmitElementsearchElementClassName = null, Expression<Func<string>> browserSubmitElementsearchElementCSSSelector = null, Expression<Func<double>> browserSubmitElementsearchElementIndex = null, Expression<Func<string>> browserSubmitElementsearchElementMatchValue = null, Expression<Func<string>> browserSubmitElementsearchElementMatchText = null, Expression<Func<string>> browserSubmitElementsearchElementType = null, Expression<Func<double>> browserSubmitElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSubmitElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSubmitElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SubmitElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSubmitElement = new JObject();
            var browserSubmitElementpropCount = 0;
            if (browserSubmitElementparentElementHandle != null)
            {
                browserSubmitElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSubmitElementparentElementHandle);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementHandle != null)
            {
                browserSubmitElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementHandle);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementName != null)
            {
                browserSubmitElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementID != null)
            {
                browserSubmitElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementID);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementTagName != null)
            {
                browserSubmitElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementTagName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementXPath != null)
            {
                browserSubmitElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementXPath);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementClassName != null)
            {
                browserSubmitElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementClassName);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementCSSSelector != null)
            {
                browserSubmitElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementCSSSelector);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementIndex != null)
            {
                if (browserSubmitElementsearchElementIndex != null)
                {
                    browserSubmitElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementIndex);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementIndex"] = 1;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMatchValue != null)
            {
                browserSubmitElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMatchValue);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMatchText != null)
            {
                browserSubmitElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMatchText);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementType != null)
            {
                browserSubmitElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementType);
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMinimumWidth != null)
            {
                if (browserSubmitElementsearchElementMinimumWidth != null)
                {
                    browserSubmitElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMinimumWidth);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementMinimumWidth"] = 1;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementMinimumHeight != null)
            {
                if (browserSubmitElementsearchElementMinimumHeight != null)
                {
                    browserSubmitElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementMinimumHeight);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementMinimumHeight"] = 1;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxLeft != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxLeft != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxLeft);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxLeft"] = -99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxRight != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxRight != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxRight);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxRight"] = 99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxTop != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxTop != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxTop);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxTop"] = -99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementsearchElementBoundingBoxBottom != null)
            {
                if (browserSubmitElementsearchElementBoundingBoxBottom != null)
                {
                    browserSubmitElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSubmitElementsearchElementBoundingBoxBottom);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["SearchElementBoundingBoxBottom"] = 99999;
                browserSubmitElementpropCount++;
            }

            if (browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSubmitElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserSubmitElementpropCount++;
                }

                browserSubmitElementpropCount++;
            }
            else
            {
                browserSubmitElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserSubmitElementpropCount++;
            }

            browserSubmitElementpropCount++;
            browserSubmitElement["Workflow"] = ExpressionConverter.ConvertO(browserSubmitElementworkflow);
            if (browserSubmitElementpropCount > 0)
            {
                callPayload.Body = browserSubmitElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckElement(Expression<Func<string>> browserCheckElementworkflow, Expression<Func<double>> browserCheckElementparentElementHandle = null, Expression<Func<double>> browserCheckElementsearchElementHandle = null, Expression<Func<string>> browserCheckElementsearchElementName = null, Expression<Func<string>> browserCheckElementsearchElementID = null, Expression<Func<string>> browserCheckElementsearchElementTagName = null, Expression<Func<string>> browserCheckElementsearchElementXPath = null, Expression<Func<string>> browserCheckElementsearchElementClassName = null, Expression<Func<string>> browserCheckElementsearchElementCSSSelector = null, Expression<Func<double>> browserCheckElementsearchElementIndex = null, Expression<Func<string>> browserCheckElementsearchElementMatchValue = null, Expression<Func<string>> browserCheckElementsearchElementMatchText = null, Expression<Func<string>> browserCheckElementsearchElementType = null, Expression<Func<double>> browserCheckElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCheckElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCheckElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserCheckElementcheckElement = null)
        {
            var apiCallPath = "/BrowserControl/CheckElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCheckElement = new JObject();
            var browserCheckElementpropCount = 0;
            if (browserCheckElementparentElementHandle != null)
            {
                browserCheckElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCheckElementparentElementHandle);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementHandle != null)
            {
                browserCheckElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementHandle);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementName != null)
            {
                browserCheckElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementID != null)
            {
                browserCheckElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementID);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementTagName != null)
            {
                browserCheckElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementTagName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementXPath != null)
            {
                browserCheckElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementXPath);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementClassName != null)
            {
                browserCheckElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementClassName);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementCSSSelector != null)
            {
                browserCheckElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementCSSSelector);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementIndex != null)
            {
                if (browserCheckElementsearchElementIndex != null)
                {
                    browserCheckElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementIndex);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementIndex"] = 1;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMatchValue != null)
            {
                browserCheckElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMatchValue);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMatchText != null)
            {
                browserCheckElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMatchText);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementType != null)
            {
                browserCheckElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementType);
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMinimumWidth != null)
            {
                if (browserCheckElementsearchElementMinimumWidth != null)
                {
                    browserCheckElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMinimumWidth);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementMinimumWidth"] = 1;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementMinimumHeight != null)
            {
                if (browserCheckElementsearchElementMinimumHeight != null)
                {
                    browserCheckElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementMinimumHeight);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementMinimumHeight"] = 1;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCheckElementsearchElementBoundingBoxLeft != null)
                {
                    browserCheckElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxLeft);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxRight != null)
            {
                if (browserCheckElementsearchElementBoundingBoxRight != null)
                {
                    browserCheckElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxRight);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxRight"] = 99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxTop != null)
            {
                if (browserCheckElementsearchElementBoundingBoxTop != null)
                {
                    browserCheckElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxTop);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxTop"] = -99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCheckElementsearchElementBoundingBoxBottom != null)
                {
                    browserCheckElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCheckElementsearchElementBoundingBoxBottom);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCheckElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserCheckElementpropCount++;
            }

            if (browserCheckElementcheckElement != null)
            {
                if (browserCheckElementcheckElement != null)
                {
                    browserCheckElement["CheckElement"] = ExpressionConverter.ConvertO(browserCheckElementcheckElement);
                    browserCheckElementpropCount++;
                }

                browserCheckElementpropCount++;
            }
            else
            {
                browserCheckElement["CheckElement"] = true;
                browserCheckElementpropCount++;
            }

            browserCheckElementpropCount++;
            browserCheckElement["Workflow"] = ExpressionConverter.ConvertO(browserCheckElementworkflow);
            if (browserCheckElementpropCount > 0)
            {
                callPayload.Body = browserCheckElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCheckMultipleElements(Expression<Func<string>> browserCheckMultipleElementsinputElementsJSON, Expression<Func<string>> browserCheckMultipleElementsworkflow)
        {
            var apiCallPath = "/BrowserControl/BrowserCheckMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCheckMultipleElements = new JObject();
            var browserCheckMultipleElementspropCount = 0;
            browserCheckMultipleElementspropCount++;
            browserCheckMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(browserCheckMultipleElementsinputElementsJSON);
            browserCheckMultipleElementspropCount++;
            browserCheckMultipleElements["Workflow"] = ExpressionConverter.ConvertO(browserCheckMultipleElementsworkflow);
            if (browserCheckMultipleElementspropCount > 0)
            {
                callPayload.Body = browserCheckMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetSelectionPropertiesResponse> BrowserGetSelectionProperties(Expression<Func<string>> browserGetSelectionPropertiesworkflow, Expression<Func<double>> browserGetSelectionPropertiesparentElementHandle = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementHandle = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementID = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementTagName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementXPath = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementClassName = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementCSSSelector = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementIndex = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementMatchValue = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementMatchText = null, Expression<Func<string>> browserGetSelectionPropertiessearchElementType = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementMinimumWidth = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementMinimumHeight = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetSelectionPropertiessearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetSelectionProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetSelectionProperties = new JObject();
            var browserGetSelectionPropertiespropCount = 0;
            if (browserGetSelectionPropertiesparentElementHandle != null)
            {
                browserGetSelectionProperties["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesparentElementHandle);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementHandle != null)
            {
                browserGetSelectionProperties["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementHandle);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementName != null)
            {
                browserGetSelectionProperties["SearchElementName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementID != null)
            {
                browserGetSelectionProperties["SearchElementID"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementID);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementTagName != null)
            {
                browserGetSelectionProperties["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementTagName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementXPath != null)
            {
                browserGetSelectionProperties["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementXPath);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementClassName != null)
            {
                browserGetSelectionProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementClassName);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementCSSSelector != null)
            {
                browserGetSelectionProperties["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementCSSSelector);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementIndex != null)
            {
                if (browserGetSelectionPropertiessearchElementIndex != null)
                {
                    browserGetSelectionProperties["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementIndex);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementIndex"] = 1;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMatchValue != null)
            {
                browserGetSelectionProperties["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMatchValue);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMatchText != null)
            {
                browserGetSelectionProperties["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMatchText);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementType != null)
            {
                browserGetSelectionProperties["SearchElementType"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementType);
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
            {
                if (browserGetSelectionPropertiessearchElementMinimumWidth != null)
                {
                    browserGetSelectionProperties["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMinimumWidth);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementMinimumWidth"] = 1;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementMinimumHeight != null)
            {
                if (browserGetSelectionPropertiessearchElementMinimumHeight != null)
                {
                    browserGetSelectionProperties["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementMinimumHeight);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementMinimumHeight"] = 1;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxLeft != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxLeft);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxLeft"] = -99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxRight != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxRight);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxRight"] = 99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxTop != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxTop);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxTop"] = -99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
            {
                if (browserGetSelectionPropertiessearchElementBoundingBoxBottom != null)
                {
                    browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiessearchElementBoundingBoxBottom);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["SearchElementBoundingBoxBottom"] = 99999;
                browserGetSelectionPropertiespropCount++;
            }

            if (browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetSelectionPropertiespropCount++;
                }

                browserGetSelectionPropertiespropCount++;
            }
            else
            {
                browserGetSelectionProperties["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetSelectionPropertiespropCount++;
            }

            browserGetSelectionPropertiespropCount++;
            browserGetSelectionProperties["Workflow"] = ExpressionConverter.ConvertO(browserGetSelectionPropertiesworkflow);
            if (browserGetSelectionPropertiespropCount > 0)
            {
                callPayload.Body = browserGetSelectionProperties;
            }

            return new ApiConnectionAction<BrowserGetSelectionPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectSelection(Expression<Func<string>> browserSelectSelectionworkflow, Expression<Func<double>> browserSelectSelectionparentElementHandle = null, Expression<Func<double>> browserSelectSelectionsearchElementHandle = null, Expression<Func<string>> browserSelectSelectionsearchElementName = null, Expression<Func<string>> browserSelectSelectionsearchElementID = null, Expression<Func<string>> browserSelectSelectionsearchElementTagName = null, Expression<Func<string>> browserSelectSelectionsearchElementXPath = null, Expression<Func<string>> browserSelectSelectionsearchElementClassName = null, Expression<Func<string>> browserSelectSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserSelectSelectionsearchElementIndex = null, Expression<Func<string>> browserSelectSelectionsearchElementMatchValue = null, Expression<Func<string>> browserSelectSelectionsearchElementMatchText = null, Expression<Func<string>> browserSelectSelectionsearchElementType = null, Expression<Func<double>> browserSelectSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserSelectSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserSelectSelectionvalueToSelect = null, Expression<Func<string>> browserSelectSelectiontextToSelect = null, Expression<Func<double>> browserSelectSelectionindexToSelect = null)
        {
            var apiCallPath = "/BrowserControl/SelectSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSelectSelection = new JObject();
            var browserSelectSelectionpropCount = 0;
            if (browserSelectSelectionparentElementHandle != null)
            {
                browserSelectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSelectSelectionparentElementHandle);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementHandle != null)
            {
                browserSelectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementHandle);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementName != null)
            {
                browserSelectSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementID != null)
            {
                browserSelectSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementID);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementTagName != null)
            {
                browserSelectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementTagName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementXPath != null)
            {
                browserSelectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementXPath);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementClassName != null)
            {
                browserSelectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementClassName);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementCSSSelector != null)
            {
                browserSelectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementCSSSelector);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementIndex != null)
            {
                if (browserSelectSelectionsearchElementIndex != null)
                {
                    browserSelectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementIndex);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementIndex"] = 1;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMatchValue != null)
            {
                browserSelectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMatchValue);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMatchText != null)
            {
                browserSelectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMatchText);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementType != null)
            {
                browserSelectSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementType);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMinimumWidth != null)
            {
                if (browserSelectSelectionsearchElementMinimumWidth != null)
                {
                    browserSelectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMinimumWidth);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementMinimumWidth"] = 1;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementMinimumHeight != null)
            {
                if (browserSelectSelectionsearchElementMinimumHeight != null)
                {
                    browserSelectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementMinimumHeight);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementMinimumHeight"] = 1;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxLeft != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxLeft != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxLeft);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxLeft"] = -99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxRight != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxRight != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxRight);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxRight"] = 99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxTop != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxTop != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxTop);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxTop"] = -99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionsearchElementBoundingBoxBottom != null)
            {
                if (browserSelectSelectionsearchElementBoundingBoxBottom != null)
                {
                    browserSelectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSelectSelectionsearchElementBoundingBoxBottom);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["SearchElementBoundingBoxBottom"] = 99999;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSelectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionvalueToSelect != null)
            {
                browserSelectSelection["ValueToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectionvalueToSelect);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectiontextToSelect != null)
            {
                browserSelectSelection["TextToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectiontextToSelect);
                browserSelectSelectionpropCount++;
            }

            if (browserSelectSelectionindexToSelect != null)
            {
                if (browserSelectSelectionindexToSelect != null)
                {
                    browserSelectSelection["IndexToSelect"] = ExpressionConverter.ConvertO(browserSelectSelectionindexToSelect);
                    browserSelectSelectionpropCount++;
                }

                browserSelectSelectionpropCount++;
            }
            else
            {
                browserSelectSelection["IndexToSelect"] = 1;
                browserSelectSelectionpropCount++;
            }

            browserSelectSelectionpropCount++;
            browserSelectSelection["Workflow"] = ExpressionConverter.ConvertO(browserSelectSelectionworkflow);
            if (browserSelectSelectionpropCount > 0)
            {
                callPayload.Body = browserSelectSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectSelection(Expression<Func<string>> browserDeselectSelectionworkflow, Expression<Func<double>> browserDeselectSelectionparentElementHandle = null, Expression<Func<double>> browserDeselectSelectionsearchElementHandle = null, Expression<Func<string>> browserDeselectSelectionsearchElementName = null, Expression<Func<string>> browserDeselectSelectionsearchElementID = null, Expression<Func<string>> browserDeselectSelectionsearchElementTagName = null, Expression<Func<string>> browserDeselectSelectionsearchElementXPath = null, Expression<Func<string>> browserDeselectSelectionsearchElementClassName = null, Expression<Func<string>> browserDeselectSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserDeselectSelectionsearchElementIndex = null, Expression<Func<string>> browserDeselectSelectionsearchElementMatchValue = null, Expression<Func<string>> browserDeselectSelectionsearchElementMatchText = null, Expression<Func<string>> browserDeselectSelectionsearchElementType = null, Expression<Func<double>> browserDeselectSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDeselectSelectionvalueToDeselect = null, Expression<Func<string>> browserDeselectSelectiontextToDeselect = null, Expression<Func<double>> browserDeselectSelectionindexToDeselect = null)
        {
            var apiCallPath = "/BrowserControl/DeselectSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDeselectSelection = new JObject();
            var browserDeselectSelectionpropCount = 0;
            if (browserDeselectSelectionparentElementHandle != null)
            {
                browserDeselectSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDeselectSelectionparentElementHandle);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementHandle != null)
            {
                browserDeselectSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementHandle);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementName != null)
            {
                browserDeselectSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementID != null)
            {
                browserDeselectSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementID);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementTagName != null)
            {
                browserDeselectSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementTagName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementXPath != null)
            {
                browserDeselectSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementXPath);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementClassName != null)
            {
                browserDeselectSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementClassName);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementCSSSelector != null)
            {
                browserDeselectSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementCSSSelector);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementIndex != null)
            {
                if (browserDeselectSelectionsearchElementIndex != null)
                {
                    browserDeselectSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementIndex);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementIndex"] = 1;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMatchValue != null)
            {
                browserDeselectSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMatchValue);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMatchText != null)
            {
                browserDeselectSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMatchText);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementType != null)
            {
                browserDeselectSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementType);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMinimumWidth != null)
            {
                if (browserDeselectSelectionsearchElementMinimumWidth != null)
                {
                    browserDeselectSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMinimumWidth);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementMinimumWidth"] = 1;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementMinimumHeight != null)
            {
                if (browserDeselectSelectionsearchElementMinimumHeight != null)
                {
                    browserDeselectSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementMinimumHeight);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementMinimumHeight"] = 1;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxLeft != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxLeft != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxLeft);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxLeft"] = -99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxRight != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxRight != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxRight);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxRight"] = 99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxTop != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxTop != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxTop);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxTop"] = -99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionsearchElementBoundingBoxBottom != null)
            {
                if (browserDeselectSelectionsearchElementBoundingBoxBottom != null)
                {
                    browserDeselectSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDeselectSelectionsearchElementBoundingBoxBottom);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["SearchElementBoundingBoxBottom"] = 99999;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDeselectSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionvalueToDeselect != null)
            {
                browserDeselectSelection["ValueToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectionvalueToDeselect);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectiontextToDeselect != null)
            {
                browserDeselectSelection["TextToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectiontextToDeselect);
                browserDeselectSelectionpropCount++;
            }

            if (browserDeselectSelectionindexToDeselect != null)
            {
                if (browserDeselectSelectionindexToDeselect != null)
                {
                    browserDeselectSelection["IndexToDeselect"] = ExpressionConverter.ConvertO(browserDeselectSelectionindexToDeselect);
                    browserDeselectSelectionpropCount++;
                }

                browserDeselectSelectionpropCount++;
            }
            else
            {
                browserDeselectSelection["IndexToDeselect"] = 1;
                browserDeselectSelectionpropCount++;
            }

            browserDeselectSelectionpropCount++;
            browserDeselectSelection["Workflow"] = ExpressionConverter.ConvertO(browserDeselectSelectionworkflow);
            if (browserDeselectSelectionpropCount > 0)
            {
                callPayload.Body = browserDeselectSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDeselectAllSelection(Expression<Func<string>> browserDeselectAllSelectionworkflow, Expression<Func<double>> browserDeselectAllSelectionparentElementHandle = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementHandle = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementID = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementTagName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementXPath = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementClassName = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementCSSSelector = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementIndex = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementMatchValue = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementMatchText = null, Expression<Func<string>> browserDeselectAllSelectionsearchElementType = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementMinimumWidth = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementMinimumHeight = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDeselectAllSelectionsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/DeselectAllSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDeselectAllSelection = new JObject();
            var browserDeselectAllSelectionpropCount = 0;
            if (browserDeselectAllSelectionparentElementHandle != null)
            {
                browserDeselectAllSelection["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionparentElementHandle);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementHandle != null)
            {
                browserDeselectAllSelection["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementHandle);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementName != null)
            {
                browserDeselectAllSelection["SearchElementName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementID != null)
            {
                browserDeselectAllSelection["SearchElementID"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementID);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementTagName != null)
            {
                browserDeselectAllSelection["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementTagName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementXPath != null)
            {
                browserDeselectAllSelection["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementXPath);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementClassName != null)
            {
                browserDeselectAllSelection["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementClassName);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementCSSSelector != null)
            {
                browserDeselectAllSelection["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementCSSSelector);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementIndex != null)
            {
                if (browserDeselectAllSelectionsearchElementIndex != null)
                {
                    browserDeselectAllSelection["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementIndex);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementIndex"] = 1;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMatchValue != null)
            {
                browserDeselectAllSelection["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMatchValue);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMatchText != null)
            {
                browserDeselectAllSelection["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMatchText);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementType != null)
            {
                browserDeselectAllSelection["SearchElementType"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementType);
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
            {
                if (browserDeselectAllSelectionsearchElementMinimumWidth != null)
                {
                    browserDeselectAllSelection["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMinimumWidth);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementMinimumWidth"] = 1;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementMinimumHeight != null)
            {
                if (browserDeselectAllSelectionsearchElementMinimumHeight != null)
                {
                    browserDeselectAllSelection["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementMinimumHeight);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementMinimumHeight"] = 1;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxLeft != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxLeft);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxLeft"] = -99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxRight != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxRight);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxRight"] = 99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxTop != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxTop);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxTop"] = -99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
            {
                if (browserDeselectAllSelectionsearchElementBoundingBoxBottom != null)
                {
                    browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionsearchElementBoundingBoxBottom);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["SearchElementBoundingBoxBottom"] = 99999;
                browserDeselectAllSelectionpropCount++;
            }

            if (browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDeselectAllSelectiononlyElementTopLeftNeedsToBeInBoundingBox);
                    browserDeselectAllSelectionpropCount++;
                }

                browserDeselectAllSelectionpropCount++;
            }
            else
            {
                browserDeselectAllSelection["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserDeselectAllSelectionpropCount++;
            }

            browserDeselectAllSelectionpropCount++;
            browserDeselectAllSelection["Workflow"] = ExpressionConverter.ConvertO(browserDeselectAllSelectionworkflow);
            if (browserDeselectAllSelectionpropCount > 0)
            {
                callPayload.Body = browserDeselectAllSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTableContentsResponse> BrowserGetTableContents(Expression<Func<string>> browserGetTableContentsworkflow, Expression<Func<double>> browserGetTableContentsparentElementHandle = null, Expression<Func<double>> browserGetTableContentssearchElementHandle = null, Expression<Func<string>> browserGetTableContentssearchElementName = null, Expression<Func<string>> browserGetTableContentssearchElementID = null, Expression<Func<string>> browserGetTableContentssearchElementTagName = null, Expression<Func<string>> browserGetTableContentssearchElementXPath = null, Expression<Func<string>> browserGetTableContentssearchElementClassName = null, Expression<Func<string>> browserGetTableContentssearchElementCSSSelector = null, Expression<Func<double>> browserGetTableContentssearchElementIndex = null, Expression<Func<string>> browserGetTableContentssearchElementMatchValue = null, Expression<Func<string>> browserGetTableContentssearchElementMatchText = null, Expression<Func<string>> browserGetTableContentssearchElementType = null, Expression<Func<double>> browserGetTableContentssearchElementMinimumWidth = null, Expression<Func<double>> browserGetTableContentssearchElementMinimumHeight = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetTableContentssearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<double>> browserGetTableContentscreateColumnNamesFromRow = null, Expression<Func<bool>> browserGetTableContentsmergeChildTables = null)
        {
            var apiCallPath = "/BrowserControl/GetTableContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetTableContents = new JObject();
            var browserGetTableContentspropCount = 0;
            if (browserGetTableContentsparentElementHandle != null)
            {
                browserGetTableContents["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetTableContentsparentElementHandle);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementHandle != null)
            {
                browserGetTableContents["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementHandle);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementName != null)
            {
                browserGetTableContents["SearchElementName"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementID != null)
            {
                browserGetTableContents["SearchElementID"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementID);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementTagName != null)
            {
                browserGetTableContents["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementTagName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementXPath != null)
            {
                browserGetTableContents["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementXPath);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementClassName != null)
            {
                browserGetTableContents["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementClassName);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementCSSSelector != null)
            {
                browserGetTableContents["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementCSSSelector);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementIndex != null)
            {
                if (browserGetTableContentssearchElementIndex != null)
                {
                    browserGetTableContents["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementIndex);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementIndex"] = 1;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMatchValue != null)
            {
                browserGetTableContents["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMatchValue);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMatchText != null)
            {
                browserGetTableContents["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMatchText);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementType != null)
            {
                browserGetTableContents["SearchElementType"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementType);
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMinimumWidth != null)
            {
                if (browserGetTableContentssearchElementMinimumWidth != null)
                {
                    browserGetTableContents["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMinimumWidth);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementMinimumWidth"] = 1;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementMinimumHeight != null)
            {
                if (browserGetTableContentssearchElementMinimumHeight != null)
                {
                    browserGetTableContents["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementMinimumHeight);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementMinimumHeight"] = 1;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxLeft != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxLeft != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxLeft);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxLeft"] = -99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxRight != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxRight != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxRight);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxRight"] = 99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxTop != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxTop != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxTop);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxTop"] = -99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentssearchElementBoundingBoxBottom != null)
            {
                if (browserGetTableContentssearchElementBoundingBoxBottom != null)
                {
                    browserGetTableContents["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetTableContentssearchElementBoundingBoxBottom);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["SearchElementBoundingBoxBottom"] = 99999;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetTableContentsonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentscreateColumnNamesFromRow != null)
            {
                if (browserGetTableContentscreateColumnNamesFromRow != null)
                {
                    browserGetTableContents["CreateColumnNamesFromRow"] = ExpressionConverter.ConvertO(browserGetTableContentscreateColumnNamesFromRow);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["CreateColumnNamesFromRow"] = 0;
                browserGetTableContentspropCount++;
            }

            if (browserGetTableContentsmergeChildTables != null)
            {
                if (browserGetTableContentsmergeChildTables != null)
                {
                    browserGetTableContents["MergeChildTables"] = ExpressionConverter.ConvertO(browserGetTableContentsmergeChildTables);
                    browserGetTableContentspropCount++;
                }

                browserGetTableContentspropCount++;
            }
            else
            {
                browserGetTableContents["MergeChildTables"] = false;
                browserGetTableContentspropCount++;
            }

            browserGetTableContents["ReturnAsDataTable"] = true;
            browserGetTableContentspropCount++;
            browserGetTableContentspropCount++;
            browserGetTableContents["Workflow"] = ExpressionConverter.ConvertO(browserGetTableContentsworkflow);
            if (browserGetTableContentspropCount > 0)
            {
                callPayload.Body = browserGetTableContents;
            }

            return new ApiConnectionAction<BrowserGetTableContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollElementIntoView(Expression<Func<string>> browserScrollElementIntoViewworkflow, Expression<Func<double>> browserScrollElementIntoViewparentElementHandle = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementHandle = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementID = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementTagName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementXPath = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementClassName = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementCSSSelector = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementIndex = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementMatchValue = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementMatchText = null, Expression<Func<string>> browserScrollElementIntoViewsearchElementType = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementMinimumWidth = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementMinimumHeight = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxRight = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxTop = null, Expression<Func<double>> browserScrollElementIntoViewsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ScrollElementIntoView";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollElementIntoView = new JObject();
            var browserScrollElementIntoViewpropCount = 0;
            if (browserScrollElementIntoViewparentElementHandle != null)
            {
                browserScrollElementIntoView["ParentElementHandle"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewparentElementHandle);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementHandle != null)
            {
                browserScrollElementIntoView["SearchElementHandle"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementHandle);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementName != null)
            {
                browserScrollElementIntoView["SearchElementName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementID != null)
            {
                browserScrollElementIntoView["SearchElementID"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementID);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementTagName != null)
            {
                browserScrollElementIntoView["SearchElementTagName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementTagName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementXPath != null)
            {
                browserScrollElementIntoView["SearchElementXPath"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementXPath);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementClassName != null)
            {
                browserScrollElementIntoView["SearchElementClassName"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementClassName);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementCSSSelector != null)
            {
                browserScrollElementIntoView["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementCSSSelector);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementIndex != null)
            {
                if (browserScrollElementIntoViewsearchElementIndex != null)
                {
                    browserScrollElementIntoView["SearchElementIndex"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementIndex);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementIndex"] = 1;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMatchValue != null)
            {
                browserScrollElementIntoView["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMatchValue);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMatchText != null)
            {
                browserScrollElementIntoView["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMatchText);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementType != null)
            {
                browserScrollElementIntoView["SearchElementType"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementType);
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
            {
                if (browserScrollElementIntoViewsearchElementMinimumWidth != null)
                {
                    browserScrollElementIntoView["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMinimumWidth);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementMinimumWidth"] = 1;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementMinimumHeight != null)
            {
                if (browserScrollElementIntoViewsearchElementMinimumHeight != null)
                {
                    browserScrollElementIntoView["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementMinimumHeight);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementMinimumHeight"] = 1;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxLeft != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxLeft);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxLeft"] = -99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxRight != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxRight);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxRight"] = 99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxTop != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxTop);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxTop"] = -99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
            {
                if (browserScrollElementIntoViewsearchElementBoundingBoxBottom != null)
                {
                    browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewsearchElementBoundingBoxBottom);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["SearchElementBoundingBoxBottom"] = 99999;
                browserScrollElementIntoViewpropCount++;
            }

            if (browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserScrollElementIntoViewpropCount++;
                }

                browserScrollElementIntoViewpropCount++;
            }
            else
            {
                browserScrollElementIntoView["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserScrollElementIntoViewpropCount++;
            }

            browserScrollElementIntoViewpropCount++;
            browserScrollElementIntoView["Workflow"] = ExpressionConverter.ConvertO(browserScrollElementIntoViewworkflow);
            if (browserScrollElementIntoViewpropCount > 0)
            {
                callPayload.Body = browserScrollElementIntoView;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptResponse> BrowserExecuteJavaScript(Expression<Func<string>> browserExecuteJavaScriptjavaScriptCode, Expression<Func<string>> browserExecuteJavaScriptworkflow)
        {
            var apiCallPath = "/BrowserControl/ExecuteJavaScript";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserExecuteJavaScript = new JObject();
            var browserExecuteJavaScriptpropCount = 0;
            browserExecuteJavaScriptpropCount++;
            browserExecuteJavaScript["JavaScriptCode"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptjavaScriptCode);
            browserExecuteJavaScriptpropCount++;
            browserExecuteJavaScript["Workflow"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptworkflow);
            if (browserExecuteJavaScriptpropCount > 0)
            {
                callPayload.Body = browserExecuteJavaScript;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementBoundingRectResponse> BrowserGetElementBoundingRect(Expression<Func<string>> browserGetElementBoundingRectworkflow, Expression<Func<double>> browserGetElementBoundingRectparentElementHandle = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementHandle = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementID = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementTagName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementXPath = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementClassName = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementCSSSelector = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementIndex = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementMatchValue = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementMatchText = null, Expression<Func<string>> browserGetElementBoundingRectsearchElementType = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementBoundingRectsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetElementBoundingRect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementBoundingRect = new JObject();
            var browserGetElementBoundingRectpropCount = 0;
            if (browserGetElementBoundingRectparentElementHandle != null)
            {
                browserGetElementBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectparentElementHandle);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementHandle != null)
            {
                browserGetElementBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementHandle);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementName != null)
            {
                browserGetElementBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementID != null)
            {
                browserGetElementBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementID);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementTagName != null)
            {
                browserGetElementBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementTagName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementXPath != null)
            {
                browserGetElementBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementXPath);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementClassName != null)
            {
                browserGetElementBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementClassName);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementCSSSelector != null)
            {
                browserGetElementBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementCSSSelector);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementIndex != null)
            {
                if (browserGetElementBoundingRectsearchElementIndex != null)
                {
                    browserGetElementBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementIndex);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementIndex"] = 1;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMatchValue != null)
            {
                browserGetElementBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMatchValue);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMatchText != null)
            {
                browserGetElementBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMatchText);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementType != null)
            {
                browserGetElementBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementType);
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
            {
                if (browserGetElementBoundingRectsearchElementMinimumWidth != null)
                {
                    browserGetElementBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMinimumWidth);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementMinimumWidth"] = 1;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementMinimumHeight != null)
            {
                if (browserGetElementBoundingRectsearchElementMinimumHeight != null)
                {
                    browserGetElementBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementMinimumHeight);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementMinimumHeight"] = 1;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxLeft);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxRight != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxRight);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxTop != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxTop);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectsearchElementBoundingBoxBottom);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementBoundingRectpropCount++;
            }

            if (browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementBoundingRectpropCount++;
                }

                browserGetElementBoundingRectpropCount++;
            }
            else
            {
                browserGetElementBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementBoundingRectpropCount++;
            }

            browserGetElementBoundingRectpropCount++;
            browserGetElementBoundingRect["Workflow"] = ExpressionConverter.ConvertO(browserGetElementBoundingRectworkflow);
            if (browserGetElementBoundingRectpropCount > 0)
            {
                callPayload.Body = browserGetElementBoundingRect;
            }

            return new ApiConnectionAction<BrowserGetElementBoundingRectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserDrawRectangleAroundElement(Expression<Func<string>> browserDrawRectangleAroundElementworkflow, Expression<Func<double>> browserDrawRectangleAroundElementparentElementHandle = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementHandle = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementID = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementTagName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementXPath = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementClassName = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementCSSSelector = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementIndex = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementMatchValue = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementMatchText = null, Expression<Func<string>> browserDrawRectangleAroundElementsearchElementType = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementMinimumWidth = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementMinimumHeight = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserDrawRectangleAroundElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<string>> browserDrawRectangleAroundElementpenColour = null, Expression<Func<int>> browserDrawRectangleAroundElementpenThicknessPixels = null)
        {
            var apiCallPath = "/BrowserControl/DrawRectangleAroundElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserDrawRectangleAroundElement = new JObject();
            var browserDrawRectangleAroundElementpropCount = 0;
            if (browserDrawRectangleAroundElementparentElementHandle != null)
            {
                browserDrawRectangleAroundElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementparentElementHandle);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementHandle != null)
            {
                browserDrawRectangleAroundElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementHandle);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementName != null)
            {
                browserDrawRectangleAroundElement["SearchElementName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementID != null)
            {
                browserDrawRectangleAroundElement["SearchElementID"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementID);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementTagName != null)
            {
                browserDrawRectangleAroundElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementTagName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementXPath != null)
            {
                browserDrawRectangleAroundElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementXPath);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementClassName != null)
            {
                browserDrawRectangleAroundElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementClassName);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementCSSSelector != null)
            {
                browserDrawRectangleAroundElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementCSSSelector);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementIndex != null)
            {
                if (browserDrawRectangleAroundElementsearchElementIndex != null)
                {
                    browserDrawRectangleAroundElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementIndex);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementIndex"] = 1;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMatchValue != null)
            {
                browserDrawRectangleAroundElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMatchValue);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMatchText != null)
            {
                browserDrawRectangleAroundElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMatchText);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementType != null)
            {
                browserDrawRectangleAroundElement["SearchElementType"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementType);
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
            {
                if (browserDrawRectangleAroundElementsearchElementMinimumWidth != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMinimumWidth);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementMinimumWidth"] = 1;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
            {
                if (browserDrawRectangleAroundElementsearchElementMinimumHeight != null)
                {
                    browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementMinimumHeight);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementMinimumHeight"] = 1;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxLeft != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxLeft);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxLeft"] = -99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxRight != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxRight);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxRight"] = 99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxTop != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxTop);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxTop"] = -99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
            {
                if (browserDrawRectangleAroundElementsearchElementBoundingBoxBottom != null)
                {
                    browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementsearchElementBoundingBoxBottom);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["SearchElementBoundingBoxBottom"] = 99999;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementpenColour != null)
            {
                if (browserDrawRectangleAroundElementpenColour != null)
                {
                    browserDrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementpenColour);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["PenColour"] = "green";
                browserDrawRectangleAroundElementpropCount++;
            }

            if (browserDrawRectangleAroundElementpenThicknessPixels != null)
            {
                if (browserDrawRectangleAroundElementpenThicknessPixels != null)
                {
                    browserDrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementpenThicknessPixels);
                    browserDrawRectangleAroundElementpropCount++;
                }

                browserDrawRectangleAroundElementpropCount++;
            }
            else
            {
                browserDrawRectangleAroundElement["PenThicknessPixels"] = 4;
                browserDrawRectangleAroundElementpropCount++;
            }

            browserDrawRectangleAroundElementpropCount++;
            browserDrawRectangleAroundElement["Workflow"] = ExpressionConverter.ConvertO(browserDrawRectangleAroundElementworkflow);
            if (browserDrawRectangleAroundElementpropCount > 0)
            {
                callPayload.Body = browserDrawRectangleAroundElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetBrowserParentWindowDetailsResponse> BrowserGetBrowserParentWindowDetails(Expression<Func<string>> browserGetBrowserParentWindowDetailsworkflow, Expression<Func<int>> browserGetBrowserParentWindowDetailsbrowserPID = null, Expression<Func<string>> browserGetBrowserParentWindowDetailssearchDocumentElementClassName = null)
        {
            var apiCallPath = "/BrowserControl/GetBrowserParentWindowDetails";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetBrowserParentWindowDetails = new JObject();
            var browserGetBrowserParentWindowDetailspropCount = 0;
            if (browserGetBrowserParentWindowDetailsbrowserPID != null)
            {
                browserGetBrowserParentWindowDetails["BrowserPID"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailsbrowserPID);
                browserGetBrowserParentWindowDetailspropCount++;
            }

            if (browserGetBrowserParentWindowDetailssearchDocumentElementClassName != null)
            {
                browserGetBrowserParentWindowDetails["SearchDocumentElementClassName"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailssearchDocumentElementClassName);
                browserGetBrowserParentWindowDetailspropCount++;
            }

            browserGetBrowserParentWindowDetailspropCount++;
            browserGetBrowserParentWindowDetails["Workflow"] = ExpressionConverter.ConvertO(browserGetBrowserParentWindowDetailsworkflow);
            if (browserGetBrowserParentWindowDetailspropCount > 0)
            {
                callPayload.Body = browserGetBrowserParentWindowDetails;
            }

            return new ApiConnectionAction<BrowserGetBrowserParentWindowDetailsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetElementScreenBoundingRectResponse> BrowserGetElementScreenBoundingRect(Expression<Func<string>> browserGetElementScreenBoundingRectworkflow, Expression<Func<double>> browserGetElementScreenBoundingRectparentElementHandle = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementHandle = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementID = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementTagName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementXPath = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementClassName = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementCSSSelector = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementIndex = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementMatchValue = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementMatchText = null, Expression<Func<string>> browserGetElementScreenBoundingRectsearchElementType = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementMinimumWidth = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementMinimumHeight = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/GetElementScreenBoundingRect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetElementScreenBoundingRect = new JObject();
            var browserGetElementScreenBoundingRectpropCount = 0;
            if (browserGetElementScreenBoundingRectparentElementHandle != null)
            {
                browserGetElementScreenBoundingRect["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectparentElementHandle);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementHandle != null)
            {
                browserGetElementScreenBoundingRect["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementHandle);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementID != null)
            {
                browserGetElementScreenBoundingRect["SearchElementID"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementID);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementTagName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementTagName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementXPath != null)
            {
                browserGetElementScreenBoundingRect["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementXPath);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementClassName != null)
            {
                browserGetElementScreenBoundingRect["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementClassName);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementCSSSelector != null)
            {
                browserGetElementScreenBoundingRect["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementCSSSelector);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementIndex != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementIndex != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementIndex);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementIndex"] = 1;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMatchValue != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMatchValue);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMatchText != null)
            {
                browserGetElementScreenBoundingRect["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMatchText);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementType != null)
            {
                browserGetElementScreenBoundingRect["SearchElementType"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementType);
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementMinimumWidth != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMinimumWidth);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementMinimumWidth"] = 1;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementMinimumHeight != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementMinimumHeight);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementMinimumHeight"] = 1;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxLeft);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxLeft"] = -99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxRight != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxRight);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxRight"] = 99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxTop != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxTop);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxTop"] = -99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
            {
                if (browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom != null)
                {
                    browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectsearchElementBoundingBoxBottom);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["SearchElementBoundingBoxBottom"] = 99999;
                browserGetElementScreenBoundingRectpropCount++;
            }

            if (browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGetElementScreenBoundingRectpropCount++;
                }

                browserGetElementScreenBoundingRectpropCount++;
            }
            else
            {
                browserGetElementScreenBoundingRect["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGetElementScreenBoundingRectpropCount++;
            }

            browserGetElementScreenBoundingRectpropCount++;
            browserGetElementScreenBoundingRect["Workflow"] = ExpressionConverter.ConvertO(browserGetElementScreenBoundingRectworkflow);
            if (browserGetElementScreenBoundingRectpropCount > 0)
            {
                callPayload.Body = browserGetElementScreenBoundingRect;
            }

            return new ApiConnectionAction<BrowserGetElementScreenBoundingRectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserFocusElement(Expression<Func<string>> browserFocusElementworkflow, Expression<Func<double>> browserFocusElementparentElementHandle = null, Expression<Func<double>> browserFocusElementsearchElementHandle = null, Expression<Func<string>> browserFocusElementsearchElementName = null, Expression<Func<string>> browserFocusElementsearchElementID = null, Expression<Func<string>> browserFocusElementsearchElementTagName = null, Expression<Func<string>> browserFocusElementsearchElementXPath = null, Expression<Func<string>> browserFocusElementsearchElementClassName = null, Expression<Func<string>> browserFocusElementsearchElementCSSSelector = null, Expression<Func<double>> browserFocusElementsearchElementIndex = null, Expression<Func<string>> browserFocusElementsearchElementMatchValue = null, Expression<Func<string>> browserFocusElementsearchElementMatchText = null, Expression<Func<string>> browserFocusElementsearchElementType = null, Expression<Func<double>> browserFocusElementsearchElementMinimumWidth = null, Expression<Func<double>> browserFocusElementsearchElementMinimumHeight = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserFocusElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/FocusElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserFocusElement = new JObject();
            var browserFocusElementpropCount = 0;
            if (browserFocusElementparentElementHandle != null)
            {
                browserFocusElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserFocusElementparentElementHandle);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementHandle != null)
            {
                browserFocusElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementHandle);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementName != null)
            {
                browserFocusElement["SearchElementName"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementID != null)
            {
                browserFocusElement["SearchElementID"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementID);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementTagName != null)
            {
                browserFocusElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementTagName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementXPath != null)
            {
                browserFocusElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementXPath);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementClassName != null)
            {
                browserFocusElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementClassName);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementCSSSelector != null)
            {
                browserFocusElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementCSSSelector);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementIndex != null)
            {
                if (browserFocusElementsearchElementIndex != null)
                {
                    browserFocusElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementIndex);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementIndex"] = 1;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMatchValue != null)
            {
                browserFocusElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMatchValue);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMatchText != null)
            {
                browserFocusElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMatchText);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementType != null)
            {
                browserFocusElement["SearchElementType"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementType);
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMinimumWidth != null)
            {
                if (browserFocusElementsearchElementMinimumWidth != null)
                {
                    browserFocusElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMinimumWidth);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementMinimumWidth"] = 1;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementMinimumHeight != null)
            {
                if (browserFocusElementsearchElementMinimumHeight != null)
                {
                    browserFocusElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementMinimumHeight);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementMinimumHeight"] = 1;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxLeft != null)
            {
                if (browserFocusElementsearchElementBoundingBoxLeft != null)
                {
                    browserFocusElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxLeft);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxLeft"] = -99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxRight != null)
            {
                if (browserFocusElementsearchElementBoundingBoxRight != null)
                {
                    browserFocusElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxRight);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxRight"] = 99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxTop != null)
            {
                if (browserFocusElementsearchElementBoundingBoxTop != null)
                {
                    browserFocusElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxTop);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxTop"] = -99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementsearchElementBoundingBoxBottom != null)
            {
                if (browserFocusElementsearchElementBoundingBoxBottom != null)
                {
                    browserFocusElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserFocusElementsearchElementBoundingBoxBottom);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["SearchElementBoundingBoxBottom"] = 99999;
                browserFocusElementpropCount++;
            }

            if (browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserFocusElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserFocusElementpropCount++;
                }

                browserFocusElementpropCount++;
            }
            else
            {
                browserFocusElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserFocusElementpropCount++;
            }

            browserFocusElementpropCount++;
            browserFocusElement["Workflow"] = ExpressionConverter.ConvertO(browserFocusElementworkflow);
            if (browserFocusElementpropCount > 0)
            {
                callPayload.Body = browserFocusElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPressEnterOnElement(Expression<Func<string>> browserPressEnterOnElementworkflow, Expression<Func<double>> browserPressEnterOnElementparentElementHandle = null, Expression<Func<double>> browserPressEnterOnElementsearchElementHandle = null, Expression<Func<string>> browserPressEnterOnElementsearchElementName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementID = null, Expression<Func<string>> browserPressEnterOnElementsearchElementTagName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementXPath = null, Expression<Func<string>> browserPressEnterOnElementsearchElementClassName = null, Expression<Func<string>> browserPressEnterOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserPressEnterOnElementsearchElementIndex = null, Expression<Func<string>> browserPressEnterOnElementsearchElementMatchValue = null, Expression<Func<string>> browserPressEnterOnElementsearchElementMatchText = null, Expression<Func<string>> browserPressEnterOnElementsearchElementType = null, Expression<Func<double>> browserPressEnterOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPressEnterOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPressEnterOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PressEnterOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPressEnterOnElement = new JObject();
            var browserPressEnterOnElementpropCount = 0;
            if (browserPressEnterOnElementparentElementHandle != null)
            {
                browserPressEnterOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPressEnterOnElementparentElementHandle);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementHandle != null)
            {
                browserPressEnterOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementHandle);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementName != null)
            {
                browserPressEnterOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementID != null)
            {
                browserPressEnterOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementID);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementTagName != null)
            {
                browserPressEnterOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementTagName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementXPath != null)
            {
                browserPressEnterOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementXPath);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementClassName != null)
            {
                browserPressEnterOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementClassName);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementCSSSelector != null)
            {
                browserPressEnterOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementCSSSelector);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementIndex != null)
            {
                if (browserPressEnterOnElementsearchElementIndex != null)
                {
                    browserPressEnterOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementIndex);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementIndex"] = 1;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMatchValue != null)
            {
                browserPressEnterOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMatchValue);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMatchText != null)
            {
                browserPressEnterOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMatchText);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementType != null)
            {
                browserPressEnterOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementType);
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMinimumWidth != null)
            {
                if (browserPressEnterOnElementsearchElementMinimumWidth != null)
                {
                    browserPressEnterOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMinimumWidth);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementMinimumWidth"] = 1;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementMinimumHeight != null)
            {
                if (browserPressEnterOnElementsearchElementMinimumHeight != null)
                {
                    browserPressEnterOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementMinimumHeight);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementMinimumHeight"] = 1;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxLeft);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxRight != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxRight);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxTop != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxTop);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserPressEnterOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPressEnterOnElementsearchElementBoundingBoxBottom);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserPressEnterOnElementpropCount++;
            }

            if (browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPressEnterOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserPressEnterOnElementpropCount++;
                }

                browserPressEnterOnElementpropCount++;
            }
            else
            {
                browserPressEnterOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserPressEnterOnElementpropCount++;
            }

            browserPressEnterOnElementpropCount++;
            browserPressEnterOnElement["Workflow"] = ExpressionConverter.ConvertO(browserPressEnterOnElementworkflow);
            if (browserPressEnterOnElementpropCount > 0)
            {
                callPayload.Body = browserPressEnterOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseLeftClickOnElement(Expression<Func<string>> browserMouseLeftClickOnElementworkflow, Expression<Func<double>> browserMouseLeftClickOnElementparentElementHandle = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementHandle = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementID = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementTagName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementXPath = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementClassName = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementIndex = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserMouseLeftClickOnElementsearchElementType = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseLeftClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/MouseLeftClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMouseLeftClickOnElement = new JObject();
            var browserMouseLeftClickOnElementpropCount = 0;
            if (browserMouseLeftClickOnElementparentElementHandle != null)
            {
                browserMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementparentElementHandle);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementHandle != null)
            {
                browserMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementHandle);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementName != null)
            {
                browserMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementID != null)
            {
                browserMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementID);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementTagName != null)
            {
                browserMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementTagName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementXPath != null)
            {
                browserMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementXPath);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementClassName != null)
            {
                browserMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementClassName);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementCSSSelector != null)
            {
                browserMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementCSSSelector);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementIndex != null)
            {
                if (browserMouseLeftClickOnElementsearchElementIndex != null)
                {
                    browserMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementIndex);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementIndex"] = 1;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMatchValue != null)
            {
                browserMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMatchValue);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMatchText != null)
            {
                browserMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMatchText);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementType != null)
            {
                browserMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementType);
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMinimumWidth);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementMinimumHeight);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxRight);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxTop);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserMouseLeftClickOnElementpropCount++;
            }

            if (browserMouseLeftClickOnElementfocusFirst != null)
            {
                if (browserMouseLeftClickOnElementfocusFirst != null)
                {
                    browserMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementfocusFirst);
                    browserMouseLeftClickOnElementpropCount++;
                }

                browserMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserMouseLeftClickOnElement["FocusFirst"] = false;
                browserMouseLeftClickOnElementpropCount++;
            }

            browserMouseLeftClickOnElementpropCount++;
            browserMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserMouseLeftClickOnElementworkflow);
            if (browserMouseLeftClickOnElementpropCount > 0)
            {
                callPayload.Body = browserMouseLeftClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserMouseRightClickOnElement(Expression<Func<string>> browserMouseRightClickOnElementworkflow, Expression<Func<double>> browserMouseRightClickOnElementparentElementHandle = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementHandle = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementID = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementTagName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementXPath = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementClassName = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementIndex = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserMouseRightClickOnElementsearchElementType = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserMouseRightClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserMouseRightClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/MouseRightClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserMouseRightClickOnElement = new JObject();
            var browserMouseRightClickOnElementpropCount = 0;
            if (browserMouseRightClickOnElementparentElementHandle != null)
            {
                browserMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementparentElementHandle);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementHandle != null)
            {
                browserMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementHandle);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementName != null)
            {
                browserMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementID != null)
            {
                browserMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementID);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementTagName != null)
            {
                browserMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementTagName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementXPath != null)
            {
                browserMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementXPath);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementClassName != null)
            {
                browserMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementClassName);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementCSSSelector != null)
            {
                browserMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementCSSSelector);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementIndex != null)
            {
                if (browserMouseRightClickOnElementsearchElementIndex != null)
                {
                    browserMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementIndex);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementIndex"] = 1;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMatchValue != null)
            {
                browserMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMatchValue);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMatchText != null)
            {
                browserMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMatchText);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementType != null)
            {
                browserMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementType);
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    browserMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMinimumWidth);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    browserMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementMinimumHeight);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxLeft);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxRight);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxTop);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementsearchElementBoundingBoxBottom);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserMouseRightClickOnElementpropCount++;
            }

            if (browserMouseRightClickOnElementfocusFirst != null)
            {
                if (browserMouseRightClickOnElementfocusFirst != null)
                {
                    browserMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementfocusFirst);
                    browserMouseRightClickOnElementpropCount++;
                }

                browserMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserMouseRightClickOnElement["FocusFirst"] = false;
                browserMouseRightClickOnElementpropCount++;
            }

            browserMouseRightClickOnElementpropCount++;
            browserMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserMouseRightClickOnElementworkflow);
            if (browserMouseRightClickOnElementpropCount > 0)
            {
                callPayload.Body = browserMouseRightClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserJavaScriptClickOnElement(Expression<Func<string>> browserJavaScriptClickOnElementworkflow, Expression<Func<double>> browserJavaScriptClickOnElementparentElementHandle = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementHandle = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementID = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementTagName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementXPath = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementClassName = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementIndex = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserJavaScriptClickOnElementsearchElementType = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserJavaScriptClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/JavaScriptClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserJavaScriptClickOnElement = new JObject();
            var browserJavaScriptClickOnElementpropCount = 0;
            if (browserJavaScriptClickOnElementparentElementHandle != null)
            {
                browserJavaScriptClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementparentElementHandle);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementHandle != null)
            {
                browserJavaScriptClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementHandle);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementName != null)
            {
                browserJavaScriptClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementID != null)
            {
                browserJavaScriptClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementID);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementTagName != null)
            {
                browserJavaScriptClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementTagName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementXPath != null)
            {
                browserJavaScriptClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementXPath);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementClassName != null)
            {
                browserJavaScriptClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementClassName);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementCSSSelector != null)
            {
                browserJavaScriptClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementCSSSelector);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementIndex != null)
            {
                if (browserJavaScriptClickOnElementsearchElementIndex != null)
                {
                    browserJavaScriptClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementIndex);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementIndex"] = 1;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMatchValue != null)
            {
                browserJavaScriptClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMatchValue);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMatchText != null)
            {
                browserJavaScriptClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMatchText);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementType != null)
            {
                browserJavaScriptClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementType);
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserJavaScriptClickOnElementsearchElementMinimumWidth != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMinimumWidth);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementMinimumWidth"] = 1;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserJavaScriptClickOnElementsearchElementMinimumHeight != null)
                {
                    browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementMinimumHeight);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementMinimumHeight"] = 1;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxLeft);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxRight);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxTop);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserJavaScriptClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementsearchElementBoundingBoxBottom);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserJavaScriptClickOnElementpropCount++;
            }

            if (browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserJavaScriptClickOnElementpropCount++;
                }

                browserJavaScriptClickOnElementpropCount++;
            }
            else
            {
                browserJavaScriptClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserJavaScriptClickOnElementpropCount++;
            }

            browserJavaScriptClickOnElementpropCount++;
            browserJavaScriptClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserJavaScriptClickOnElementworkflow);
            if (browserJavaScriptClickOnElementpropCount > 0)
            {
                callPayload.Body = browserJavaScriptClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserExecuteJavaScriptOnElementResponse> BrowserExecuteJavaScriptOnElement(Expression<Func<string>> browserExecuteJavaScriptOnElementjavaScriptToExecute, Expression<Func<string>> browserExecuteJavaScriptOnElementworkflow, Expression<Func<double>> browserExecuteJavaScriptOnElementparentElementHandle = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementHandle = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementID = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementTagName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementXPath = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementClassName = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementIndex = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementMatchValue = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementMatchText = null, Expression<Func<string>> browserExecuteJavaScriptOnElementsearchElementType = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ExecuteJavaScriptOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserExecuteJavaScriptOnElement = new JObject();
            var browserExecuteJavaScriptOnElementpropCount = 0;
            if (browserExecuteJavaScriptOnElementparentElementHandle != null)
            {
                browserExecuteJavaScriptOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementparentElementHandle);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementHandle != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementHandle);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementID != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementID);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementTagName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementTagName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementXPath != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementXPath);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementClassName != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementClassName);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementCSSSelector != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementCSSSelector);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementIndex != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementIndex);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementIndex"] = 1;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMatchValue != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMatchValue);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMatchText != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMatchText);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementType != null)
            {
                browserExecuteJavaScriptOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementType);
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementMinimumWidth != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMinimumWidth);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementMinimumWidth"] = 1;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementMinimumHeight != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementMinimumHeight);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementMinimumHeight"] = 1;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxLeft);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxRight);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxTop);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementsearchElementBoundingBoxBottom);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            if (browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserExecuteJavaScriptOnElementpropCount++;
                }

                browserExecuteJavaScriptOnElementpropCount++;
            }
            else
            {
                browserExecuteJavaScriptOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserExecuteJavaScriptOnElementpropCount++;
            }

            browserExecuteJavaScriptOnElementpropCount++;
            browserExecuteJavaScriptOnElement["JavaScriptToExecute"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementjavaScriptToExecute);
            browserExecuteJavaScriptOnElementpropCount++;
            browserExecuteJavaScriptOnElement["Workflow"] = ExpressionConverter.ConvertO(browserExecuteJavaScriptOnElementworkflow);
            if (browserExecuteJavaScriptOnElementpropCount > 0)
            {
                callPayload.Body = browserExecuteJavaScriptOnElement;
            }

            return new ApiConnectionAction<BrowserExecuteJavaScriptOnElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseLeftClickOnElement(Expression<Func<string>> browserGlobalMouseLeftClickOnElementworkflow, Expression<Func<double>> browserGlobalMouseLeftClickOnElementparentElementHandle = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementHandle = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementID = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementTagName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementXPath = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementClassName = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementIndex = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseLeftClickOnElementsearchElementType = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementclickOffsetX = null, Expression<Func<int>> browserGlobalMouseLeftClickOnElementclickOffsetY = null, Expression<Func<bool>> browserGlobalMouseLeftClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/GlobalMouseLeftClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGlobalMouseLeftClickOnElement = new JObject();
            var browserGlobalMouseLeftClickOnElementpropCount = 0;
            if (browserGlobalMouseLeftClickOnElementparentElementHandle != null)
            {
                browserGlobalMouseLeftClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementparentElementHandle);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementHandle != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementHandle);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementID != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementID);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementTagName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementTagName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementXPath != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementXPath);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementClassName != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementClassName);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementCSSSelector != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementCSSSelector);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementIndex != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementIndex);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementIndex"] = 1;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMatchValue != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMatchValue);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMatchText != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMatchText);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementType != null)
            {
                browserGlobalMouseLeftClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementType);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMinimumWidth);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMinimumWidth"] = 1;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementMinimumHeight);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementMinimumHeight"] = 1;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxLeft);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxRight);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxTop);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementsearchElementBoundingBoxBottom);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementclickOffsetX != null)
            {
                browserGlobalMouseLeftClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementclickOffsetX);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementclickOffsetY != null)
            {
                browserGlobalMouseLeftClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementclickOffsetY);
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
            {
                if (browserGlobalMouseLeftClickOnElementfocusFirst != null)
                {
                    browserGlobalMouseLeftClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementfocusFirst);
                    browserGlobalMouseLeftClickOnElementpropCount++;
                }

                browserGlobalMouseLeftClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseLeftClickOnElement["FocusFirst"] = false;
                browserGlobalMouseLeftClickOnElementpropCount++;
            }

            browserGlobalMouseLeftClickOnElementpropCount++;
            browserGlobalMouseLeftClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserGlobalMouseLeftClickOnElementworkflow);
            if (browserGlobalMouseLeftClickOnElementpropCount > 0)
            {
                callPayload.Body = browserGlobalMouseLeftClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserGlobalMouseRightClickOnElement(Expression<Func<string>> browserGlobalMouseRightClickOnElementworkflow, Expression<Func<double>> browserGlobalMouseRightClickOnElementparentElementHandle = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementHandle = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementID = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementTagName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementXPath = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementClassName = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementIndex = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementMatchValue = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementMatchText = null, Expression<Func<string>> browserGlobalMouseRightClickOnElementsearchElementType = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementclickOffsetX = null, Expression<Func<int>> browserGlobalMouseRightClickOnElementclickOffsetY = null, Expression<Func<bool>> browserGlobalMouseRightClickOnElementfocusFirst = null)
        {
            var apiCallPath = "/BrowserControl/GlobalMouseRightClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGlobalMouseRightClickOnElement = new JObject();
            var browserGlobalMouseRightClickOnElementpropCount = 0;
            if (browserGlobalMouseRightClickOnElementparentElementHandle != null)
            {
                browserGlobalMouseRightClickOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementparentElementHandle);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementHandle != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementHandle);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementID != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementID);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementTagName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementTagName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementXPath != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementXPath);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementClassName != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementClassName);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementCSSSelector != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementCSSSelector);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementIndex != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementIndex);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementIndex"] = 1;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMatchValue != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMatchValue);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMatchText != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMatchText);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementType != null)
            {
                browserGlobalMouseRightClickOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementType);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementMinimumWidth != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMinimumWidth);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementMinimumWidth"] = 1;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementMinimumHeight != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementMinimumHeight);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementMinimumHeight"] = 1;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxLeft);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxRight);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxTop);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementsearchElementBoundingBoxBottom);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementclickOffsetX != null)
            {
                browserGlobalMouseRightClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementclickOffsetX);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementclickOffsetY != null)
            {
                browserGlobalMouseRightClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementclickOffsetY);
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            if (browserGlobalMouseRightClickOnElementfocusFirst != null)
            {
                if (browserGlobalMouseRightClickOnElementfocusFirst != null)
                {
                    browserGlobalMouseRightClickOnElement["FocusFirst"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementfocusFirst);
                    browserGlobalMouseRightClickOnElementpropCount++;
                }

                browserGlobalMouseRightClickOnElementpropCount++;
            }
            else
            {
                browserGlobalMouseRightClickOnElement["FocusFirst"] = false;
                browserGlobalMouseRightClickOnElementpropCount++;
            }

            browserGlobalMouseRightClickOnElementpropCount++;
            browserGlobalMouseRightClickOnElement["Workflow"] = ExpressionConverter.ConvertO(browserGlobalMouseRightClickOnElementworkflow);
            if (browserGlobalMouseRightClickOnElementpropCount > 0)
            {
                callPayload.Body = browserGlobalMouseRightClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserOpenNewTabResponse> BrowserOpenNewTab(Expression<Func<string>> browserOpenNewTabworkflow, Expression<Func<string>> browserOpenNewTabuRL = null, Expression<Func<bool>> browserOpenNewTabswitchControlToNewTab = null)
        {
            var apiCallPath = "/BrowserControl/OpenNewTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserOpenNewTab = new JObject();
            var browserOpenNewTabpropCount = 0;
            if (browserOpenNewTabuRL != null)
            {
                browserOpenNewTab["URL"] = ExpressionConverter.ConvertO(browserOpenNewTabuRL);
                browserOpenNewTabpropCount++;
            }

            if (browserOpenNewTabswitchControlToNewTab != null)
            {
                if (browserOpenNewTabswitchControlToNewTab != null)
                {
                    browserOpenNewTab["SwitchControlToNewTab"] = ExpressionConverter.ConvertO(browserOpenNewTabswitchControlToNewTab);
                    browserOpenNewTabpropCount++;
                }

                browserOpenNewTabpropCount++;
            }
            else
            {
                browserOpenNewTab["SwitchControlToNewTab"] = true;
                browserOpenNewTabpropCount++;
            }

            browserOpenNewTabpropCount++;
            browserOpenNewTab["Workflow"] = ExpressionConverter.ConvertO(browserOpenNewTabworkflow);
            if (browserOpenNewTabpropCount > 0)
            {
                callPayload.Body = browserOpenNewTab;
            }

            return new ApiConnectionAction<BrowserOpenNewTabResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetTabsResponse> BrowserGetTabs(Expression<Func<string>> browserGetTabsworkflow)
        {
            var apiCallPath = "/BrowserControl/GetTabs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetTabs = new JObject();
            var browserGetTabspropCount = 0;
            browserGetTabspropCount++;
            browserGetTabs["Workflow"] = ExpressionConverter.ConvertO(browserGetTabsworkflow);
            if (browserGetTabspropCount > 0)
            {
                callPayload.Body = browserGetTabs;
            }

            return new ApiConnectionAction<BrowserGetTabsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSetTab(Expression<Func<string>> browserSetTabworkflow, Expression<Func<string>> browserSetTabtabName = null, Expression<Func<int>> browserSetTabtabIndex = null)
        {
            var apiCallPath = "/BrowserControl/SetTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSetTab = new JObject();
            var browserSetTabpropCount = 0;
            if (browserSetTabtabName != null)
            {
                browserSetTab["TabName"] = ExpressionConverter.ConvertO(browserSetTabtabName);
                browserSetTabpropCount++;
            }

            if (browserSetTabtabIndex != null)
            {
                browserSetTab["TabIndex"] = ExpressionConverter.ConvertO(browserSetTabtabIndex);
                browserSetTabpropCount++;
            }

            browserSetTabpropCount++;
            browserSetTab["Workflow"] = ExpressionConverter.ConvertO(browserSetTabworkflow);
            if (browserSetTabpropCount > 0)
            {
                callPayload.Body = browserSetTab;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCloseActiveTab(Expression<Func<string>> browserCloseActiveTabworkflow)
        {
            var apiCallPath = "/BrowserControl/CloseActiveTab";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCloseActiveTab = new JObject();
            var browserCloseActiveTabpropCount = 0;
            browserCloseActiveTabpropCount++;
            browserCloseActiveTab["Workflow"] = ExpressionConverter.ConvertO(browserCloseActiveTabworkflow);
            if (browserCloseActiveTabpropCount > 0)
            {
                callPayload.Body = browserCloseActiveTab;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSavePageToFile(Expression<Func<string>> browserSavePageToFilesaveFilename, Expression<Func<string>> browserSavePageToFileworkflow)
        {
            var apiCallPath = "/BrowserControl/SavePageToFile";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSavePageToFile = new JObject();
            var browserSavePageToFilepropCount = 0;
            browserSavePageToFilepropCount++;
            browserSavePageToFile["SaveFilename"] = ExpressionConverter.ConvertO(browserSavePageToFilesaveFilename);
            browserSavePageToFilepropCount++;
            browserSavePageToFile["Workflow"] = ExpressionConverter.ConvertO(browserSavePageToFileworkflow);
            if (browserSavePageToFilepropCount > 0)
            {
                callPayload.Body = browserSavePageToFile;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetPageTextResponse> BrowserGetPageText(Expression<Func<string>> browserGetPageTextworkflow)
        {
            var apiCallPath = "/BrowserControl/GetPageText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetPageText = new JObject();
            var browserGetPageTextpropCount = 0;
            browserGetPageTextpropCount++;
            browserGetPageText["Workflow"] = ExpressionConverter.ConvertO(browserGetPageTextworkflow);
            if (browserGetPageTextpropCount > 0)
            {
                callPayload.Body = browserGetPageText;
            }

            return new ApiConnectionAction<BrowserGetPageTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToFrameElement(Expression<Func<string>> browserSwitchToFrameElementworkflow, Expression<Func<double>> browserSwitchToFrameElementparentElementHandle = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementHandle = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementID = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementTagName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementXPath = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementClassName = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementCSSSelector = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementIndex = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementMatchValue = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementMatchText = null, Expression<Func<string>> browserSwitchToFrameElementsearchElementType = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSwitchToFrameElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SwitchToFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToFrameElement = new JObject();
            var browserSwitchToFrameElementpropCount = 0;
            if (browserSwitchToFrameElementparentElementHandle != null)
            {
                browserSwitchToFrameElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementparentElementHandle);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementHandle != null)
            {
                browserSwitchToFrameElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementHandle);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementName != null)
            {
                browserSwitchToFrameElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementID != null)
            {
                browserSwitchToFrameElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementID);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementTagName != null)
            {
                browserSwitchToFrameElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementTagName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementXPath != null)
            {
                browserSwitchToFrameElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementXPath);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementClassName != null)
            {
                browserSwitchToFrameElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementClassName);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementCSSSelector != null)
            {
                browserSwitchToFrameElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementCSSSelector);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementIndex != null)
            {
                if (browserSwitchToFrameElementsearchElementIndex != null)
                {
                    browserSwitchToFrameElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementIndex);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementIndex"] = 1;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMatchValue != null)
            {
                browserSwitchToFrameElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMatchValue);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMatchText != null)
            {
                browserSwitchToFrameElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMatchText);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementType != null)
            {
                browserSwitchToFrameElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementType);
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
            {
                if (browserSwitchToFrameElementsearchElementMinimumWidth != null)
                {
                    browserSwitchToFrameElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMinimumWidth);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementMinimumWidth"] = 1;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementMinimumHeight != null)
            {
                if (browserSwitchToFrameElementsearchElementMinimumHeight != null)
                {
                    browserSwitchToFrameElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementMinimumHeight);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementMinimumHeight"] = 1;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxLeft != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxLeft);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxLeft"] = -99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxRight != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxRight);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxRight"] = 99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxTop != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxTop);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxTop"] = -99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
            {
                if (browserSwitchToFrameElementsearchElementBoundingBoxBottom != null)
                {
                    browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementsearchElementBoundingBoxBottom);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["SearchElementBoundingBoxBottom"] = 99999;
                browserSwitchToFrameElementpropCount++;
            }

            if (browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserSwitchToFrameElementpropCount++;
                }

                browserSwitchToFrameElementpropCount++;
            }
            else
            {
                browserSwitchToFrameElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserSwitchToFrameElementpropCount++;
            }

            browserSwitchToFrameElementpropCount++;
            browserSwitchToFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToFrameElementworkflow);
            if (browserSwitchToFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse> BrowserGetCurrentFrameWindowPixelCoordinate(Expression<Func<string>> browserGetCurrentFrameWindowPixelCoordinateworkflow)
        {
            var apiCallPath = "/BrowserControl/GetCurrentFrameWindowPixelCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetCurrentFrameWindowPixelCoordinate = new JObject();
            var browserGetCurrentFrameWindowPixelCoordinatepropCount = 0;
            browserGetCurrentFrameWindowPixelCoordinatepropCount++;
            browserGetCurrentFrameWindowPixelCoordinate["Workflow"] = ExpressionConverter.ConvertO(browserGetCurrentFrameWindowPixelCoordinateworkflow);
            if (browserGetCurrentFrameWindowPixelCoordinatepropCount > 0)
            {
                callPayload.Body = browserGetCurrentFrameWindowPixelCoordinate;
            }

            return new ApiConnectionAction<BrowserGetCurrentFrameWindowPixelCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToParentFrameElement(Expression<Func<string>> browserSwitchToParentFrameElementworkflow)
        {
            var apiCallPath = "/BrowserControl/SwitchToParentFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToParentFrameElement = new JObject();
            var browserSwitchToParentFrameElementpropCount = 0;
            browserSwitchToParentFrameElementpropCount++;
            browserSwitchToParentFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToParentFrameElementworkflow);
            if (browserSwitchToParentFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToParentFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSwitchToRootFrameElement(Expression<Func<string>> browserSwitchToRootFrameElementworkflow)
        {
            var apiCallPath = "/BrowserControl/SwitchToRootFrameElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSwitchToRootFrameElement = new JObject();
            var browserSwitchToRootFrameElementpropCount = 0;
            browserSwitchToRootFrameElementpropCount++;
            browserSwitchToRootFrameElement["Workflow"] = ExpressionConverter.ConvertO(browserSwitchToRootFrameElementworkflow);
            if (browserSwitchToRootFrameElementpropCount > 0)
            {
                callPayload.Body = browserSwitchToRootFrameElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserResetFrameStack(Expression<Func<string>> browserResetFrameStackworkflow)
        {
            var apiCallPath = "/BrowserControl/ResetFrameStack";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserResetFrameStack = new JObject();
            var browserResetFrameStackpropCount = 0;
            browserResetFrameStackpropCount++;
            browserResetFrameStack["Workflow"] = ExpressionConverter.ConvertO(browserResetFrameStackworkflow);
            if (browserResetFrameStackpropCount > 0)
            {
                callPayload.Body = browserResetFrameStack;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserClearElementTextResponse> BrowserClearElementText(Expression<Func<string>> browserClearElementTextworkflow, Expression<Func<double>> browserClearElementTextparentElementHandle = null, Expression<Func<double>> browserClearElementTextsearchElementHandle = null, Expression<Func<string>> browserClearElementTextsearchElementName = null, Expression<Func<string>> browserClearElementTextsearchElementID = null, Expression<Func<string>> browserClearElementTextsearchElementTagName = null, Expression<Func<string>> browserClearElementTextsearchElementXPath = null, Expression<Func<string>> browserClearElementTextsearchElementClassName = null, Expression<Func<string>> browserClearElementTextsearchElementCSSSelector = null, Expression<Func<double>> browserClearElementTextsearchElementIndex = null, Expression<Func<string>> browserClearElementTextsearchElementMatchValue = null, Expression<Func<string>> browserClearElementTextsearchElementMatchText = null, Expression<Func<string>> browserClearElementTextsearchElementType = null, Expression<Func<double>> browserClearElementTextsearchElementMinimumWidth = null, Expression<Func<double>> browserClearElementTextsearchElementMinimumHeight = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxRight = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxTop = null, Expression<Func<double>> browserClearElementTextsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/ClearElementText";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserClearElementText = new JObject();
            var browserClearElementTextpropCount = 0;
            if (browserClearElementTextparentElementHandle != null)
            {
                browserClearElementText["ParentElementHandle"] = ExpressionConverter.ConvertO(browserClearElementTextparentElementHandle);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementHandle != null)
            {
                browserClearElementText["SearchElementHandle"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementHandle);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementName != null)
            {
                browserClearElementText["SearchElementName"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementID != null)
            {
                browserClearElementText["SearchElementID"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementID);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementTagName != null)
            {
                browserClearElementText["SearchElementTagName"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementTagName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementXPath != null)
            {
                browserClearElementText["SearchElementXPath"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementXPath);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementClassName != null)
            {
                browserClearElementText["SearchElementClassName"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementClassName);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementCSSSelector != null)
            {
                browserClearElementText["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementCSSSelector);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementIndex != null)
            {
                if (browserClearElementTextsearchElementIndex != null)
                {
                    browserClearElementText["SearchElementIndex"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementIndex);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementIndex"] = 1;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMatchValue != null)
            {
                browserClearElementText["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMatchValue);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMatchText != null)
            {
                browserClearElementText["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMatchText);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementType != null)
            {
                browserClearElementText["SearchElementType"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementType);
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMinimumWidth != null)
            {
                if (browserClearElementTextsearchElementMinimumWidth != null)
                {
                    browserClearElementText["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMinimumWidth);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementMinimumWidth"] = 1;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementMinimumHeight != null)
            {
                if (browserClearElementTextsearchElementMinimumHeight != null)
                {
                    browserClearElementText["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementMinimumHeight);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementMinimumHeight"] = 1;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxLeft != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxLeft != null)
                {
                    browserClearElementText["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxLeft);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxLeft"] = -99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxRight != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxRight != null)
                {
                    browserClearElementText["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxRight);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxRight"] = 99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxTop != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxTop != null)
                {
                    browserClearElementText["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxTop);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxTop"] = -99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextsearchElementBoundingBoxBottom != null)
            {
                if (browserClearElementTextsearchElementBoundingBoxBottom != null)
                {
                    browserClearElementText["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserClearElementTextsearchElementBoundingBoxBottom);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["SearchElementBoundingBoxBottom"] = 99999;
                browserClearElementTextpropCount++;
            }

            if (browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserClearElementTextonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserClearElementTextpropCount++;
                }

                browserClearElementTextpropCount++;
            }
            else
            {
                browserClearElementText["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserClearElementTextpropCount++;
            }

            browserClearElementTextpropCount++;
            browserClearElementText["Workflow"] = ExpressionConverter.ConvertO(browserClearElementTextworkflow);
            if (browserClearElementTextpropCount > 0)
            {
                callPayload.Body = browserClearElementText;
            }

            return new ApiConnectionAction<BrowserClearElementTextResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserCopySelectedTextOnElement(Expression<Func<string>> browserCopySelectedTextOnElementworkflow, Expression<Func<double>> browserCopySelectedTextOnElementparentElementHandle = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementHandle = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementID = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementTagName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementXPath = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementClassName = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementIndex = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementMatchValue = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementMatchText = null, Expression<Func<string>> browserCopySelectedTextOnElementsearchElementType = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserCopySelectedTextOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/CopySelectedTextOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserCopySelectedTextOnElement = new JObject();
            var browserCopySelectedTextOnElementpropCount = 0;
            if (browserCopySelectedTextOnElementparentElementHandle != null)
            {
                browserCopySelectedTextOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementparentElementHandle);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementHandle != null)
            {
                browserCopySelectedTextOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementHandle);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementName != null)
            {
                browserCopySelectedTextOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementID != null)
            {
                browserCopySelectedTextOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementID);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementTagName != null)
            {
                browserCopySelectedTextOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementTagName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementXPath != null)
            {
                browserCopySelectedTextOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementXPath);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementClassName != null)
            {
                browserCopySelectedTextOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementClassName);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementCSSSelector != null)
            {
                browserCopySelectedTextOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementCSSSelector);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementIndex != null)
            {
                if (browserCopySelectedTextOnElementsearchElementIndex != null)
                {
                    browserCopySelectedTextOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementIndex);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementIndex"] = 1;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMatchValue != null)
            {
                browserCopySelectedTextOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMatchValue);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMatchText != null)
            {
                browserCopySelectedTextOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMatchText);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementType != null)
            {
                browserCopySelectedTextOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementType);
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
            {
                if (browserCopySelectedTextOnElementsearchElementMinimumWidth != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMinimumWidth);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementMinimumWidth"] = 1;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
            {
                if (browserCopySelectedTextOnElementsearchElementMinimumHeight != null)
                {
                    browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementMinimumHeight);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementMinimumHeight"] = 1;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxLeft);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxRight != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxRight);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxTop != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxTop);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserCopySelectedTextOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementsearchElementBoundingBoxBottom);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserCopySelectedTextOnElementpropCount++;
            }

            if (browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserCopySelectedTextOnElementpropCount++;
                }

                browserCopySelectedTextOnElementpropCount++;
            }
            else
            {
                browserCopySelectedTextOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserCopySelectedTextOnElementpropCount++;
            }

            browserCopySelectedTextOnElementpropCount++;
            browserCopySelectedTextOnElement["Workflow"] = ExpressionConverter.ConvertO(browserCopySelectedTextOnElementworkflow);
            if (browserCopySelectedTextOnElementpropCount > 0)
            {
                callPayload.Body = browserCopySelectedTextOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserInputPasswordIntoElement(Expression<Func<string>> browserInputPasswordIntoElementpasswordToInput, Expression<Func<string>> browserInputPasswordIntoElementworkflow, Expression<Func<double>> browserInputPasswordIntoElementparentElementHandle = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementHandle = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementID = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementTagName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementXPath = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementClassName = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementIndex = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementMatchText = null, Expression<Func<string>> browserInputPasswordIntoElementsearchElementType = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserInputPasswordIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserInputPasswordIntoElementresetExistingValue = null, Expression<Func<bool>> browserInputPasswordIntoElementpasswordContainsStoredPassword = null)
        {
            var apiCallPath = "/BrowserControl/InputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserInputPasswordIntoElement = new JObject();
            var browserInputPasswordIntoElementpropCount = 0;
            if (browserInputPasswordIntoElementparentElementHandle != null)
            {
                browserInputPasswordIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementparentElementHandle);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementHandle != null)
            {
                browserInputPasswordIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementHandle);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementName != null)
            {
                browserInputPasswordIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementID != null)
            {
                browserInputPasswordIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementID);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementTagName != null)
            {
                browserInputPasswordIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementTagName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementXPath != null)
            {
                browserInputPasswordIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementXPath);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementClassName != null)
            {
                browserInputPasswordIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementClassName);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementCSSSelector != null)
            {
                browserInputPasswordIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementCSSSelector);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementIndex != null)
            {
                if (browserInputPasswordIntoElementsearchElementIndex != null)
                {
                    browserInputPasswordIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementIndex);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementIndex"] = 1;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMatchValue != null)
            {
                browserInputPasswordIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMatchValue);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMatchText != null)
            {
                browserInputPasswordIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMatchText);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementType != null)
            {
                browserInputPasswordIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementType);
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
            {
                if (browserInputPasswordIntoElementsearchElementMinimumWidth != null)
                {
                    browserInputPasswordIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMinimumWidth);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementMinimumWidth"] = 1;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementMinimumHeight != null)
            {
                if (browserInputPasswordIntoElementsearchElementMinimumHeight != null)
                {
                    browserInputPasswordIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementMinimumHeight);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementMinimumHeight"] = 1;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxLeft != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxLeft);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxRight != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxRight);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxRight"] = 99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxTop != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxTop);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxTop"] = -99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
            {
                if (browserInputPasswordIntoElementsearchElementBoundingBoxBottom != null)
                {
                    browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementsearchElementBoundingBoxBottom);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserInputPasswordIntoElementpropCount++;
            }

            browserInputPasswordIntoElementpropCount++;
            browserInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementpasswordToInput);
            if (browserInputPasswordIntoElementresetExistingValue != null)
            {
                if (browserInputPasswordIntoElementresetExistingValue != null)
                {
                    browserInputPasswordIntoElement["ResetExistingValue"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementresetExistingValue);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["ResetExistingValue"] = true;
                browserInputPasswordIntoElementpropCount++;
            }

            if (browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
            {
                if (browserInputPasswordIntoElementpasswordContainsStoredPassword != null)
                {
                    browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementpasswordContainsStoredPassword);
                    browserInputPasswordIntoElementpropCount++;
                }

                browserInputPasswordIntoElementpropCount++;
            }
            else
            {
                browserInputPasswordIntoElement["PasswordContainsStoredPassword"] = false;
                browserInputPasswordIntoElementpropCount++;
            }

            browserInputPasswordIntoElementpropCount++;
            browserInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserInputPasswordIntoElementworkflow);
            if (browserInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = browserInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPasteIntoElement(Expression<Func<string>> browserPasteIntoElementworkflow, Expression<Func<double>> browserPasteIntoElementparentElementHandle = null, Expression<Func<double>> browserPasteIntoElementsearchElementHandle = null, Expression<Func<string>> browserPasteIntoElementsearchElementName = null, Expression<Func<string>> browserPasteIntoElementsearchElementID = null, Expression<Func<string>> browserPasteIntoElementsearchElementTagName = null, Expression<Func<string>> browserPasteIntoElementsearchElementXPath = null, Expression<Func<string>> browserPasteIntoElementsearchElementClassName = null, Expression<Func<string>> browserPasteIntoElementsearchElementCSSSelector = null, Expression<Func<double>> browserPasteIntoElementsearchElementIndex = null, Expression<Func<string>> browserPasteIntoElementsearchElementMatchValue = null, Expression<Func<string>> browserPasteIntoElementsearchElementMatchText = null, Expression<Func<string>> browserPasteIntoElementsearchElementType = null, Expression<Func<double>> browserPasteIntoElementsearchElementMinimumWidth = null, Expression<Func<double>> browserPasteIntoElementsearchElementMinimumHeight = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserPasteIntoElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/PasteIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPasteIntoElement = new JObject();
            var browserPasteIntoElementpropCount = 0;
            if (browserPasteIntoElementparentElementHandle != null)
            {
                browserPasteIntoElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserPasteIntoElementparentElementHandle);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementHandle != null)
            {
                browserPasteIntoElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementHandle);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementName != null)
            {
                browserPasteIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementID != null)
            {
                browserPasteIntoElement["SearchElementID"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementID);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementTagName != null)
            {
                browserPasteIntoElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementTagName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementXPath != null)
            {
                browserPasteIntoElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementXPath);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementClassName != null)
            {
                browserPasteIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementClassName);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementCSSSelector != null)
            {
                browserPasteIntoElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementCSSSelector);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementIndex != null)
            {
                if (browserPasteIntoElementsearchElementIndex != null)
                {
                    browserPasteIntoElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementIndex);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementIndex"] = 1;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMatchValue != null)
            {
                browserPasteIntoElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMatchValue);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMatchText != null)
            {
                browserPasteIntoElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMatchText);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementType != null)
            {
                browserPasteIntoElement["SearchElementType"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementType);
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMinimumWidth != null)
            {
                if (browserPasteIntoElementsearchElementMinimumWidth != null)
                {
                    browserPasteIntoElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMinimumWidth);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementMinimumWidth"] = 1;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementMinimumHeight != null)
            {
                if (browserPasteIntoElementsearchElementMinimumHeight != null)
                {
                    browserPasteIntoElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementMinimumHeight);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementMinimumHeight"] = 1;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxLeft != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxLeft != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxLeft);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxLeft"] = -99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxRight != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxRight != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxRight);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxRight"] = 99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxTop != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxTop != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxTop);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxTop"] = -99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementsearchElementBoundingBoxBottom != null)
            {
                if (browserPasteIntoElementsearchElementBoundingBoxBottom != null)
                {
                    browserPasteIntoElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserPasteIntoElementsearchElementBoundingBoxBottom);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["SearchElementBoundingBoxBottom"] = 99999;
                browserPasteIntoElementpropCount++;
            }

            if (browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserPasteIntoElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserPasteIntoElementpropCount++;
                }

                browserPasteIntoElementpropCount++;
            }
            else
            {
                browserPasteIntoElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserPasteIntoElementpropCount++;
            }

            browserPasteIntoElementpropCount++;
            browserPasteIntoElement["Workflow"] = ExpressionConverter.ConvertO(browserPasteIntoElementworkflow);
            if (browserPasteIntoElementpropCount > 0)
            {
                callPayload.Body = browserPasteIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserPrintCurrentPage(Expression<Func<string>> browserPrintCurrentPageworkflow)
        {
            var apiCallPath = "/BrowserControl/PrintCurrentPage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserPrintCurrentPage = new JObject();
            var browserPrintCurrentPagepropCount = 0;
            browserPrintCurrentPagepropCount++;
            browserPrintCurrentPage["Workflow"] = ExpressionConverter.ConvertO(browserPrintCurrentPageworkflow);
            if (browserPrintCurrentPagepropCount > 0)
            {
                callPayload.Body = browserPrintCurrentPage;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowByPixels(Expression<Func<string>> browserScrollWindowByPixelsworkflow, Expression<Func<double>> browserScrollWindowByPixelsx = null, Expression<Func<double>> browserScrollWindowByPixelsy = null)
        {
            var apiCallPath = "/BrowserControl/ScrollWindowByPixels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollWindowByPixels = new JObject();
            var browserScrollWindowByPixelspropCount = 0;
            if (browserScrollWindowByPixelsx != null)
            {
                browserScrollWindowByPixels["X"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsx);
                browserScrollWindowByPixelspropCount++;
            }

            if (browserScrollWindowByPixelsy != null)
            {
                browserScrollWindowByPixels["Y"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsy);
                browserScrollWindowByPixelspropCount++;
            }

            browserScrollWindowByPixelspropCount++;
            browserScrollWindowByPixels["Workflow"] = ExpressionConverter.ConvertO(browserScrollWindowByPixelsworkflow);
            if (browserScrollWindowByPixelspropCount > 0)
            {
                callPayload.Body = browserScrollWindowByPixels;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserScrollWindowToPixels(Expression<Func<string>> browserScrollWindowToPixelsworkflow, Expression<Func<double>> browserScrollWindowToPixelsx = null, Expression<Func<double>> browserScrollWindowToPixelsy = null)
        {
            var apiCallPath = "/BrowserControl/ScrollWindowToPixels";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserScrollWindowToPixels = new JObject();
            var browserScrollWindowToPixelspropCount = 0;
            if (browserScrollWindowToPixelsx != null)
            {
                browserScrollWindowToPixels["X"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsx);
                browserScrollWindowToPixelspropCount++;
            }

            if (browserScrollWindowToPixelsy != null)
            {
                browserScrollWindowToPixels["Y"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsy);
                browserScrollWindowToPixelspropCount++;
            }

            browserScrollWindowToPixelspropCount++;
            browserScrollWindowToPixels["Workflow"] = ExpressionConverter.ConvertO(browserScrollWindowToPixelsworkflow);
            if (browserScrollWindowToPixelspropCount > 0)
            {
                callPayload.Body = browserScrollWindowToPixels;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IWorkflowAction BrowserSelectAllOnElement(Expression<Func<string>> browserSelectAllOnElementworkflow, Expression<Func<double>> browserSelectAllOnElementparentElementHandle = null, Expression<Func<double>> browserSelectAllOnElementsearchElementHandle = null, Expression<Func<string>> browserSelectAllOnElementsearchElementName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementID = null, Expression<Func<string>> browserSelectAllOnElementsearchElementTagName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementXPath = null, Expression<Func<string>> browserSelectAllOnElementsearchElementClassName = null, Expression<Func<string>> browserSelectAllOnElementsearchElementCSSSelector = null, Expression<Func<double>> browserSelectAllOnElementsearchElementIndex = null, Expression<Func<string>> browserSelectAllOnElementsearchElementMatchValue = null, Expression<Func<string>> browserSelectAllOnElementsearchElementMatchText = null, Expression<Func<string>> browserSelectAllOnElementsearchElementType = null, Expression<Func<double>> browserSelectAllOnElementsearchElementMinimumWidth = null, Expression<Func<double>> browserSelectAllOnElementsearchElementMinimumHeight = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxRight = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxTop = null, Expression<Func<double>> browserSelectAllOnElementsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox = null)
        {
            var apiCallPath = "/BrowserControl/SelectAllOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserSelectAllOnElement = new JObject();
            var browserSelectAllOnElementpropCount = 0;
            if (browserSelectAllOnElementparentElementHandle != null)
            {
                browserSelectAllOnElement["ParentElementHandle"] = ExpressionConverter.ConvertO(browserSelectAllOnElementparentElementHandle);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementHandle != null)
            {
                browserSelectAllOnElement["SearchElementHandle"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementHandle);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementName != null)
            {
                browserSelectAllOnElement["SearchElementName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementID != null)
            {
                browserSelectAllOnElement["SearchElementID"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementID);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementTagName != null)
            {
                browserSelectAllOnElement["SearchElementTagName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementTagName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementXPath != null)
            {
                browserSelectAllOnElement["SearchElementXPath"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementXPath);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementClassName != null)
            {
                browserSelectAllOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementClassName);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementCSSSelector != null)
            {
                browserSelectAllOnElement["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementCSSSelector);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementIndex != null)
            {
                if (browserSelectAllOnElementsearchElementIndex != null)
                {
                    browserSelectAllOnElement["SearchElementIndex"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementIndex);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementIndex"] = 1;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMatchValue != null)
            {
                browserSelectAllOnElement["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMatchValue);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMatchText != null)
            {
                browserSelectAllOnElement["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMatchText);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementType != null)
            {
                browserSelectAllOnElement["SearchElementType"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementType);
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMinimumWidth != null)
            {
                if (browserSelectAllOnElementsearchElementMinimumWidth != null)
                {
                    browserSelectAllOnElement["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMinimumWidth);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementMinimumWidth"] = 1;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementMinimumHeight != null)
            {
                if (browserSelectAllOnElementsearchElementMinimumHeight != null)
                {
                    browserSelectAllOnElement["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementMinimumHeight);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementMinimumHeight"] = 1;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxLeft != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxLeft);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxLeft"] = -99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxRight != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxRight != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxRight);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxRight"] = 99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxTop != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxTop != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxTop);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxTop"] = -99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
            {
                if (browserSelectAllOnElementsearchElementBoundingBoxBottom != null)
                {
                    browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserSelectAllOnElementsearchElementBoundingBoxBottom);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["SearchElementBoundingBoxBottom"] = 99999;
                browserSelectAllOnElementpropCount++;
            }

            if (browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserSelectAllOnElementonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserSelectAllOnElementpropCount++;
                }

                browserSelectAllOnElementpropCount++;
            }
            else
            {
                browserSelectAllOnElement["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserSelectAllOnElementpropCount++;
            }

            browserSelectAllOnElementpropCount++;
            browserSelectAllOnElement["Workflow"] = ExpressionConverter.ConvertO(browserSelectAllOnElementworkflow);
            if (browserSelectAllOnElementpropCount > 0)
            {
                callPayload.Body = browserSelectAllOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToExistResponse> BrowserWaitForElementToExist(Expression<Func<int>> browserWaitForElementToExistsecondsToWait, Expression<Func<string>> browserWaitForElementToExistworkflow, Expression<Func<double>> browserWaitForElementToExistparentElementHandle = null, Expression<Func<string>> browserWaitForElementToExistsearchElementName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementID = null, Expression<Func<string>> browserWaitForElementToExistsearchElementTagName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementXPath = null, Expression<Func<string>> browserWaitForElementToExistsearchElementClassName = null, Expression<Func<string>> browserWaitForElementToExistsearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToExistsearchElementIndex = null, Expression<Func<string>> browserWaitForElementToExistsearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToExistsearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToExistsearchElementType = null, Expression<Func<double>> browserWaitForElementToExistsearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToExistsearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToExistraiseExceptionIfElementNotFound = null, Expression<Func<bool>> browserWaitForElementToExistuseExplicitWaitConditionsIfPossible = null, Expression<Func<bool>> browserWaitForElementToExistwaitForSearchElementToBeDisplayed = null)
        {
            var apiCallPath = "/BrowserControl/WaitForElementToExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserWaitForElementToExist = new JObject();
            var browserWaitForElementToExistpropCount = 0;
            if (browserWaitForElementToExistparentElementHandle != null)
            {
                browserWaitForElementToExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToExistparentElementHandle);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementName != null)
            {
                browserWaitForElementToExist["SearchElementName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementID != null)
            {
                browserWaitForElementToExist["SearchElementID"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementID);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementTagName != null)
            {
                browserWaitForElementToExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementTagName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementXPath != null)
            {
                browserWaitForElementToExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementXPath);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementClassName != null)
            {
                browserWaitForElementToExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementClassName);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementCSSSelector != null)
            {
                browserWaitForElementToExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementCSSSelector);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementIndex != null)
            {
                if (browserWaitForElementToExistsearchElementIndex != null)
                {
                    browserWaitForElementToExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementIndex);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementIndex"] = 1;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMatchValue != null)
            {
                browserWaitForElementToExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMatchValue);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMatchText != null)
            {
                browserWaitForElementToExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMatchText);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementType != null)
            {
                browserWaitForElementToExist["SearchElementType"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementType);
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMinimumWidth != null)
            {
                if (browserWaitForElementToExistsearchElementMinimumWidth != null)
                {
                    browserWaitForElementToExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMinimumWidth);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementMinimumWidth"] = 1;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementMinimumHeight != null)
            {
                if (browserWaitForElementToExistsearchElementMinimumHeight != null)
                {
                    browserWaitForElementToExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementMinimumHeight);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementMinimumHeight"] = 1;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxLeft != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxLeft);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxLeft"] = -99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxRight != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxRight != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxRight);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxRight"] = 99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxTop != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxTop != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxTop);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxTop"] = -99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
            {
                if (browserWaitForElementToExistsearchElementBoundingBoxBottom != null)
                {
                    browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsearchElementBoundingBoxBottom);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["SearchElementBoundingBoxBottom"] = 99999;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserWaitForElementToExistonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserWaitForElementToExistpropCount++;
            }

            browserWaitForElementToExistpropCount++;
            browserWaitForElementToExist["SecondsToWait"] = ExpressionConverter.ConvertO(browserWaitForElementToExistsecondsToWait);
            if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
            {
                if (browserWaitForElementToExistraiseExceptionIfElementNotFound != null)
                {
                    browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserWaitForElementToExistraiseExceptionIfElementNotFound);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["RaiseExceptionIfElementNotFound"] = false;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
            {
                if (browserWaitForElementToExistuseExplicitWaitConditionsIfPossible != null)
                {
                    browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = ExpressionConverter.ConvertO(browserWaitForElementToExistuseExplicitWaitConditionsIfPossible);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["UseExplicitWaitConditionsIfPossible"] = true;
                browserWaitForElementToExistpropCount++;
            }

            if (browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
            {
                if (browserWaitForElementToExistwaitForSearchElementToBeDisplayed != null)
                {
                    browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = ExpressionConverter.ConvertO(browserWaitForElementToExistwaitForSearchElementToBeDisplayed);
                    browserWaitForElementToExistpropCount++;
                }

                browserWaitForElementToExistpropCount++;
            }
            else
            {
                browserWaitForElementToExist["WaitForSearchElementToBeDisplayed"] = false;
                browserWaitForElementToExistpropCount++;
            }

            browserWaitForElementToExistpropCount++;
            browserWaitForElementToExist["Workflow"] = ExpressionConverter.ConvertO(browserWaitForElementToExistworkflow);
            if (browserWaitForElementToExistpropCount > 0)
            {
                callPayload.Body = browserWaitForElementToExist;
            }

            return new ApiConnectionAction<BrowserWaitForElementToExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserWaitForElementToNotExistResponse> BrowserWaitForElementToNotExist(Expression<Func<int>> browserWaitForElementToNotExistsecondsToWait, Expression<Func<string>> browserWaitForElementToNotExistworkflow, Expression<Func<double>> browserWaitForElementToNotExistparentElementHandle = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementHandle = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementID = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementTagName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementXPath = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementClassName = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementCSSSelector = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementIndex = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementMatchValue = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementMatchText = null, Expression<Func<string>> browserWaitForElementToNotExistsearchElementType = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementMinimumWidth = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementMinimumHeight = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxLeft = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxRight = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxTop = null, Expression<Func<double>> browserWaitForElementToNotExistsearchElementBoundingBoxBottom = null, Expression<Func<bool>> browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox = null, Expression<Func<bool>> browserWaitForElementToNotExistraiseExceptionIfElementStillExists = null, Expression<Func<bool>> browserWaitForElementToNotExistsearchElementMustBeDisplayed = null)
        {
            var apiCallPath = "/BrowserControl/WaitForElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserWaitForElementToNotExist = new JObject();
            var browserWaitForElementToNotExistpropCount = 0;
            if (browserWaitForElementToNotExistparentElementHandle != null)
            {
                browserWaitForElementToNotExist["ParentElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistparentElementHandle);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementHandle != null)
            {
                browserWaitForElementToNotExist["SearchElementHandle"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementHandle);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementName != null)
            {
                browserWaitForElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementID != null)
            {
                browserWaitForElementToNotExist["SearchElementID"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementID);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementTagName != null)
            {
                browserWaitForElementToNotExist["SearchElementTagName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementTagName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementXPath != null)
            {
                browserWaitForElementToNotExist["SearchElementXPath"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementXPath);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementClassName != null)
            {
                browserWaitForElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementClassName);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementCSSSelector != null)
            {
                browserWaitForElementToNotExist["SearchElementCSSSelector"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementCSSSelector);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementIndex != null)
            {
                if (browserWaitForElementToNotExistsearchElementIndex != null)
                {
                    browserWaitForElementToNotExist["SearchElementIndex"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementIndex);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementIndex"] = 1;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMatchValue != null)
            {
                browserWaitForElementToNotExist["SearchElementMatchValue"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMatchValue);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMatchText != null)
            {
                browserWaitForElementToNotExist["SearchElementMatchText"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMatchText);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementType != null)
            {
                browserWaitForElementToNotExist["SearchElementType"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementType);
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
            {
                if (browserWaitForElementToNotExistsearchElementMinimumWidth != null)
                {
                    browserWaitForElementToNotExist["SearchElementMinimumWidth"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMinimumWidth);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementMinimumWidth"] = 1;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMinimumHeight != null)
            {
                if (browserWaitForElementToNotExistsearchElementMinimumHeight != null)
                {
                    browserWaitForElementToNotExist["SearchElementMinimumHeight"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMinimumHeight);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementMinimumHeight"] = 1;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxLeft != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxLeft);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxLeft"] = -99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxRight != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxRight);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxRight"] = 99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxTop != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxTop);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxTop"] = -99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
            {
                if (browserWaitForElementToNotExistsearchElementBoundingBoxBottom != null)
                {
                    browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementBoundingBoxBottom);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementBoundingBoxBottom"] = 99999;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
            {
                if (browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox != null)
                {
                    browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistonlyElementTopLeftNeedsToBeInBoundingBox);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["OnlyElementTopLeftNeedsToBeInBoundingBox"] = false;
                browserWaitForElementToNotExistpropCount++;
            }

            browserWaitForElementToNotExistpropCount++;
            browserWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsecondsToWait);
            if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
            {
                if (browserWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistraiseExceptionIfElementStillExists);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                browserWaitForElementToNotExistpropCount++;
            }

            if (browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
            {
                if (browserWaitForElementToNotExistsearchElementMustBeDisplayed != null)
                {
                    browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistsearchElementMustBeDisplayed);
                    browserWaitForElementToNotExistpropCount++;
                }

                browserWaitForElementToNotExistpropCount++;
            }
            else
            {
                browserWaitForElementToNotExist["SearchElementMustBeDisplayed"] = false;
                browserWaitForElementToNotExistpropCount++;
            }

            browserWaitForElementToNotExistpropCount++;
            browserWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(browserWaitForElementToNotExistworkflow);
            if (browserWaitForElementToNotExistpropCount > 0)
            {
                callPayload.Body = browserWaitForElementToNotExist;
            }

            return new ApiConnectionAction<BrowserWaitForElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtScreenCoordinatesResponse> BrowserGetWebElementAtScreenCoordinates(Expression<Func<string>> browserGetWebElementAtScreenCoordinatesworkflow, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesxCoord = null, Expression<Func<int>> browserGetWebElementAtScreenCoordinatesyCoord = null, Expression<Func<bool>> browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/BrowserControl/GetWebElementAtScreenCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementAtScreenCoordinates = new JObject();
            var browserGetWebElementAtScreenCoordinatespropCount = 0;
            if (browserGetWebElementAtScreenCoordinatesxCoord != null)
            {
                if (browserGetWebElementAtScreenCoordinatesxCoord != null)
                {
                    browserGetWebElementAtScreenCoordinates["XCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesxCoord);
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                browserGetWebElementAtScreenCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtScreenCoordinates["XCoord"] = 0;
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            if (browserGetWebElementAtScreenCoordinatesyCoord != null)
            {
                if (browserGetWebElementAtScreenCoordinatesyCoord != null)
                {
                    browserGetWebElementAtScreenCoordinates["YCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesyCoord);
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                browserGetWebElementAtScreenCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtScreenCoordinates["YCoord"] = 0;
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            if (browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
            {
                if (browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesraiseExceptionIfElementNotFound);
                    browserGetWebElementAtScreenCoordinatespropCount++;
                }

                browserGetWebElementAtScreenCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtScreenCoordinates["RaiseExceptionIfElementNotFound"] = false;
                browserGetWebElementAtScreenCoordinatespropCount++;
            }

            browserGetWebElementAtScreenCoordinatespropCount++;
            browserGetWebElementAtScreenCoordinates["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementAtScreenCoordinatesworkflow);
            if (browserGetWebElementAtScreenCoordinatespropCount > 0)
            {
                callPayload.Body = browserGetWebElementAtScreenCoordinates;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtScreenCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse> BrowserGetWebElementAtBrowserDocumentWindowCoordinates(Expression<Func<string>> browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord = null, Expression<Func<int>> browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord = null, Expression<Func<bool>> browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/BrowserControl/GetWebElementAtBrowserDocumentWindowCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementAtBrowserDocumentWindowCoordinates = new JObject();
            var browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount = 0;
            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
            {
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord != null)
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesxCoord);
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["XCoord"] = 0;
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
            {
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord != null)
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesyCoord);
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["YCoord"] = 0;
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            if (browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
            {
                if (browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesraiseExceptionIfElementNotFound);
                    browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
                }

                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }
            else
            {
                browserGetWebElementAtBrowserDocumentWindowCoordinates["RaiseExceptionIfElementNotFound"] = false;
                browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            }

            browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount++;
            browserGetWebElementAtBrowserDocumentWindowCoordinates["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementAtBrowserDocumentWindowCoordinatesworkflow);
            if (browserGetWebElementAtBrowserDocumentWindowCoordinatespropCount > 0)
            {
                callPayload.Body = browserGetWebElementAtBrowserDocumentWindowCoordinates;
            }

            return new ApiConnectionAction<BrowserGetWebElementAtBrowserDocumentWindowCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<BrowserGetWebElementPropertiesAsListResponse> BrowserGetWebElementPropertiesAsList(Expression<Func<int>> browserGetWebElementPropertiesAsListelementHandle, Expression<Func<string>> browserGetWebElementPropertiesAsListworkflow, Expression<Func<bool>> browserGetWebElementPropertiesAsListgetHTMLCode = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnValue = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnText = null, Expression<Func<int>> browserGetWebElementPropertiesAsListmaxValueLength = null, Expression<Func<int>> browserGetWebElementPropertiesAsListmaxTextLength = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnCoordinates = null, Expression<Func<bool>> browserGetWebElementPropertiesAsListreturnParentTag = null)
        {
            var apiCallPath = "/BrowserControl/BrowserGetWebElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var browserGetWebElementPropertiesAsList = new JObject();
            var browserGetWebElementPropertiesAsListpropCount = 0;
            browserGetWebElementPropertiesAsListpropCount++;
            browserGetWebElementPropertiesAsList["ElementHandle"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListelementHandle);
            if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
            {
                if (browserGetWebElementPropertiesAsListgetHTMLCode != null)
                {
                    browserGetWebElementPropertiesAsList["GetHTMLCode"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListgetHTMLCode);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["GetHTMLCode"] = false;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnValue != null)
            {
                if (browserGetWebElementPropertiesAsListreturnValue != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnValue"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnValue);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["ReturnValue"] = true;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnText != null)
            {
                if (browserGetWebElementPropertiesAsListreturnText != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnText"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnText);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["ReturnText"] = true;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListmaxValueLength != null)
            {
                if (browserGetWebElementPropertiesAsListmaxValueLength != null)
                {
                    browserGetWebElementPropertiesAsList["MaxValueLength"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListmaxValueLength);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["MaxValueLength"] = 0;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListmaxTextLength != null)
            {
                if (browserGetWebElementPropertiesAsListmaxTextLength != null)
                {
                    browserGetWebElementPropertiesAsList["MaxTextLength"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListmaxTextLength);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["MaxTextLength"] = 0;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnCoordinates != null)
            {
                if (browserGetWebElementPropertiesAsListreturnCoordinates != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnCoordinates"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnCoordinates);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["ReturnCoordinates"] = true;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            if (browserGetWebElementPropertiesAsListreturnParentTag != null)
            {
                if (browserGetWebElementPropertiesAsListreturnParentTag != null)
                {
                    browserGetWebElementPropertiesAsList["ReturnParentTag"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListreturnParentTag);
                    browserGetWebElementPropertiesAsListpropCount++;
                }

                browserGetWebElementPropertiesAsListpropCount++;
            }
            else
            {
                browserGetWebElementPropertiesAsList["ReturnParentTag"] = true;
                browserGetWebElementPropertiesAsListpropCount++;
            }

            browserGetWebElementPropertiesAsListpropCount++;
            browserGetWebElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(browserGetWebElementPropertiesAsListworkflow);
            if (browserGetWebElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = browserGetWebElementPropertiesAsList;
            }

            return new ApiConnectionAction<BrowserGetWebElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectwebbrowser")]
        public IBodyWorkflowAction<IsBrowserInstanceOpenResponse> IsBrowserInstanceOpen(Expression<Func<string>> isBrowserInstanceOpenworkflow)
        {
            var apiCallPath = "/BrowserControl/IsBrowserInstanceOpen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var isBrowserInstanceOpen = new JObject();
            var isBrowserInstanceOpenpropCount = 0;
            isBrowserInstanceOpenpropCount++;
            isBrowserInstanceOpen["Workflow"] = ExpressionConverter.ConvertO(isBrowserInstanceOpenworkflow);
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